using MyPhotosDatabase;
using MyPhotosDatabase.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoManager.Forms
{
    public partial class MyPhotosForm : Form
    {
        private const int PHOTO_SIZE = 100;
        private List<Media> _media;
        private readonly List<CheckBox> checkBoxes = new List<CheckBox>();
        private readonly List<CheckBox> checkedCheckBoxes = new List<CheckBox>();
        Size photoSize = new Size(PHOTO_SIZE, PHOTO_SIZE);
        public MyPhotosForm()
        {
            InitializeComponent();
            LoadPhotos();
            buttonArchive.Enabled = false;
        }
        private void LoadPhotos(string toSearch = "",
                                bool byDate = false,
                                bool byEvent = false,
                                bool byPeople = false,
                                bool byLocation = false,
                                bool byTags = false,
                                bool byDescription = false)
        {

            Func<Media, bool> predicate = media =>
                !media.Deleted && (media.Name.ToLower().Contains(toSearch.ToLower()) ||
                (media.CreatedDate.ToString().ToLower().Contains(toSearch.ToLower()) && byDate) ||
                (media.Event.ToLower().Contains(toSearch.ToLower()) && byEvent) ||
                (media.People.ToLower().Contains(toSearch.ToLower()) && byPeople) ||
                (media.Location.ToLower().Contains(toSearch.ToLower()) && byLocation) ||
                (media.Tags.ToLower().Contains(toSearch.ToLower()) && byTags) ||
                (media.Description.ToLower().Contains(toSearch.ToLower()) && byDescription));
            _media = MyPhotosAPI.GetAll(predicate);

            checkBoxes.Clear();
            flowLayoutPanelMyPhotos.Controls.Clear();
            flowLayoutPanelMyPhotos.Hide();
            try
            {
                Thread threadInput = new Thread(AddMediaToFlowLayout);
                threadInput.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

        }
        private void AddMediaToFlowLayout()
        {
            SetLoading(true);
            Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(() => false);
            Size minMaxSize = new Size(photoSize.Width, photoSize.Height + 20);
            Parallel.ForEach(_media, (tempMedia, state) =>
            {
                Panel panelPhoto = new Panel();
                CheckBox checkBox = new CheckBox();
                Label labelPhoto = new Label();

                PictureBox pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = tempMedia.Id
                };
                try
                {
                    if (tempMedia.Type == MediaType.Photo.ToString())
                        pictureBox.Image = new Bitmap(tempMedia.Path).GetThumbnailImage(PHOTO_SIZE, PHOTO_SIZE, myCallback, IntPtr.Zero);
                    else
                        pictureBox.Image = Properties.Resources.VideoImage;
                }
                catch
                {
                    pictureBox.Image = Properties.Resources.MediaDeleted;
                }
                pictureBox.Click += PhotoShowPictureBox_Click;
                pictureBox.Dock = DockStyle.Fill;

                labelPhoto.Text = tempMedia.Name;
                labelPhoto.AutoEllipsis = true;
                labelPhoto.Dock = DockStyle.Bottom;

                panelPhoto.MinimumSize = minMaxSize;
                panelPhoto.MaximumSize = minMaxSize;

                checkBox.Location = new Point(PHOTO_SIZE - 13, PHOTO_SIZE - 20);
                checkBox.Name = tempMedia.Id.ToString();
                checkBox.Tag = panelPhoto;
                checkBox.BackColor = Color.Transparent;
                checkBox.CheckedChanged += CheckBoxPicture_Modified;

                pictureBox.Controls.Add(checkBox);
                panelPhoto.Controls.Add(pictureBox);
                panelPhoto.Controls.Add(labelPhoto);

                checkBoxes.Add(checkBox);

                try
                {
                    Invoke(new Action(() =>
                    {
                        flowLayoutPanelMyPhotos.Controls.Add(panelPhoto);
                    }));
                }
                catch
                {
                    state.Break();
                }
            });
            SetLoading(false);
        }
        private void InvokeOnFormThread(MethodInvoker methodInvoker)
        {
            if (IsHandleCreated)
                Invoke(new EventHandler(delegate { methodInvoker(); }));
            else
                methodInvoker();
        }
        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                InvokeOnFormThread((MethodInvoker)delegate
                {
                    pictureBoxLoading.Visible = true;
                    this.Cursor = Cursors.WaitCursor;
                });
            }
            else
            {
                InvokeOnFormThread((MethodInvoker)delegate
                {
                    pictureBoxLoading.Visible = false;
                    flowLayoutPanelMyPhotos.Show();
                    this.Cursor = Cursors.Default;
                });
            }
        }
        private void PhotoShowPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox currentPictureBox = (PictureBox)sender;
            Media currentMediaToShow = MyPhotosAPI.GetMediaById((Guid)currentPictureBox.Tag);
            try
            {
                if (!currentMediaToShow.Deleted)
                {
                    Form formToShow = new PhotoView(currentMediaToShow);
                    formToShow.Show();
                }
                else
                {
                    DialogResult messageResult = MessageBox.Show("This " + currentMediaToShow.Type + " has been deleted recent. You want to reload media?",
                                    "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (messageResult == DialogResult.Yes)
                        Search();
                }
            }
            catch
            {
                DialogResult messageResult = MessageBox.Show("This " + currentMediaToShow.Type + " has been moved/deleted recent from your computer. You want to delete media from database?",
                                "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (messageResult == DialogResult.Yes)
                {
                    MyPhotosAPI.DeleteMediaById(currentMediaToShow.Id);
                    Search();
                }
            }
        }
        private void Search()
        {
            string toSearch = textBoxSearch.Text;
            bool byDate = checkBoxByDate.Checked;
            bool byEvent = checkBoxByEvent.Checked;
            bool byPeople = checkBoxByPeople.Checked;
            bool byTags = checkBoxByTags.Checked;
            bool byLocation = checkBoxByLocation.Checked;
            bool byDescription = checkBoxByDescription.Checked;
            LoadPhotos(toSearch, byDate, byEvent, byPeople, byLocation, byTags, byDescription);
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void CheckBoxPicture_Modified(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;
            if (currentCheckBox.Checked)
                checkedCheckBoxes.Add(currentCheckBox);
            else
                checkedCheckBoxes.Remove(currentCheckBox);
            if (checkedCheckBoxes.Count > 0)
                buttonArchive.Enabled = true;
            else
                buttonArchive.Enabled = false;
        }
        private void ButtonDeleteSelected_Click(object sender, EventArgs e)
        {
            foreach (CheckBox tempCheckBox in checkedCheckBoxes)
            {
                string id = tempCheckBox.Name;
                MyPhotosAPI.DeleteMediaById(Guid.Parse(id));
                flowLayoutPanelMyPhotos.Controls.Remove((Panel) tempCheckBox.Tag);
            }
        }
        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in checkBoxes)
                checkBox.Checked = true;
            buttonSelectAll.Click -= ButtonSelectAll_Click;
            buttonSelectAll.Click += ButtonUnselectAll_Click;
            buttonSelectAll.Text = "Unselect all";
        }
        private void ButtonUnselectAll_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in checkBoxes)
                checkBox.Checked = false;
            buttonSelectAll.Click -= ButtonUnselectAll_Click;
            buttonSelectAll.Click += ButtonSelectAll_Click;
            buttonSelectAll.Text = "Select all";
        }

        private void ButtonArchive_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            string currentTime = DateTime.Now.ToString("u").Replace(":", "_").Replace("-", "_");
            var zipName = "MyPhotos_" + currentTime + ".zip";
            var zip = ZipFile.Open(Path.Combine(folder.SelectedPath, zipName), ZipArchiveMode.Create);
            foreach (CheckBox tempCheckBox in checkedCheckBoxes)
            {
                string id = tempCheckBox.Name;
                Media tempMedia = MyPhotosAPI.GetMediaById(Guid.Parse(id));
                zip.CreateEntryFromFile(tempMedia.Path, tempMedia.Name, CompressionLevel.Optimal);
            }
            zip.Dispose();
        }
    }
}
