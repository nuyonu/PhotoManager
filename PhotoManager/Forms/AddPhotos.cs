using AxWMPLib;
using MyPhotosDatabase;
using MyPhotosDatabase.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PhotoManager.Forms
{
    public enum Mode
    {
        Directory,
        Files
    }
    public partial class AddPhotos : Form
    {
        private readonly Mode mode;
        private readonly List<string> photosPath = new List<string>();
        private readonly PictureBox photoShowPictureBox = new PictureBox();
        private readonly AxWindowsMediaPlayer videoShowMediaPlayer = new AxWindowsMediaPlayer();
        private int currentPicture  = 0;

        private readonly string[] VIDEO_EXTENSIONS = new string[] { "*.mkv", "*.mp4" };
        private readonly string[] PHOTO_EXTENSIONS = new string[] { "*.jpeg", "*.jpg", "*.gif", "*.png" };
        public AddPhotos(Mode mode)
        {
            InitializeComponent();
            this.mode = mode;
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            if (mode == Mode.Directory)
            {
                buttonLoad.Text = "Load from " + mode.ToString();
            } 
            else
            {
                buttonLoad.Text = "Load " + mode.ToString();
            }

            photoShowPictureBox.Dock = DockStyle.Fill;
            photoShowPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            videoShowMediaPlayer.Dock = DockStyle.Fill;

            Disable(buttonSwitchLeft);
            Disable(buttonAddToDatabase);
            Disable(buttonSwitchRight);
        }
        private void ButtonSwitchLeft_Click(object sender, EventArgs e)
        {
            currentPicture--;
            SetContentshow();
            AdjustsTheControlButtons();
        }

        private void ButtonSwitchRight_Click(object sender, EventArgs e)
        {
            currentPicture++;
            SetContentshow();
            AdjustsTheControlButtons();
        }

        private void AdjustsTheControlButtons()
        {
            if (currentPicture == 0)
                Disable(buttonSwitchLeft);
            else
                Enable(buttonSwitchLeft);
            if (currentPicture < photosPath.Count - 1)
                Enable(buttonSwitchRight);
            else
                Disable(buttonSwitchRight);
            if (photosPath.Count == 0)
                Disable(buttonAddToDatabase);
            else
                Enable(buttonAddToDatabase);
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            if(mode == Mode.Directory)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                string[] extensions = PHOTO_EXTENSIONS.Concat(VIDEO_EXTENSIONS).ToArray();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    foreach (var photoPath in Directory.GetFiles(folderBrowserDialog.SelectedPath)
                        .Where(file => extensions.Contains("*" + Path.GetExtension(file).ToLower())))
                    {
                        if (photosPath.Contains(photoPath) || MyPhotosAPI.AlreadyInDatabaseAndNotDeleted(photoPath))
                            continue;
                        else
                            photosPath.Add(photoPath);
                    }
            }
            else if (mode == Mode.Files)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Allowed files (*.jpg, *.jpeg, *.gif, *.png, *.mp4, *.mkv) | *.jpg; *.jpeg; *.gif; *.png; *.mp4; *.mkv; |" +
                       "Images files (*.jpg, *.jpeg, *.gif, *.png) | *.jpg; *.jpeg; *.gif; *.png; |" +
                       "Video files (*.mp4, *.mkv) | *.mp4; *.mkv;",    
                    Multiselect = true,
                    Title = "PhotoManager"

                };
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach(var photoPath in openFileDialog.FileNames)
                    {
                        if (photosPath.Contains(photoPath) || MyPhotosAPI.AlreadyInDatabaseAndNotDeleted(photoPath))
                            continue;
                        else
                            photosPath.Add(photoPath);
                    }
                }
            }
            if (photosPath.Count > 0)
            {
                panelShow.Controls.Add(photoShowPictureBox);
                panelShow.Controls.Add(videoShowMediaPlayer);
                labelShow.Hide();
                Enable(buttonAddToDatabase);
                if (photosPath.Count > 1)
                    Enable(buttonSwitchRight);
            }
            SetContentshow();
        }
        private void SetContentshow()
        {
            if (photosPath.Count > 0)
            {
                string tempPath = photosPath[currentPicture];
                if (VIDEO_EXTENSIONS.Contains("*" + Path.GetExtension(tempPath)))
                {
                    photoShowPictureBox.Hide();
                    videoShowMediaPlayer.Show();
                    videoShowMediaPlayer.settings.autoStart = false;
                    videoShowMediaPlayer.URL = tempPath;
                }
                else
                {
                    videoShowMediaPlayer.Hide();
                    if (videoShowMediaPlayer.URL != null)
                        videoShowMediaPlayer.Ctlcontrols.stop();
                    photoShowPictureBox.Show();
                    photoShowPictureBox.Image = (Bitmap)Image.FromFile(tempPath);
                    
                }
                textBoxName.Text = Path.GetFileName(tempPath);
                textBoxPath.Text = tempPath;
                textBoxCreated.Text = File.GetCreationTime(tempPath).ToString();
                labelCount.Text = (currentPicture + 1) + "/" + photosPath.Count;
            }
            else
            {
                photoShowPictureBox.Hide();
                videoShowMediaPlayer.Hide();
                labelCount.Text = currentPicture + "/" + photosPath.Count;
                labelShow.Show();
                labelShow.Text = "There are no uploaded \n\t images/videos";
            }
        }

        private void ButtonAddToDatabase_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string path = textBoxPath.Text;
            string format = Path.GetExtension(path);
            string type = (VIDEO_EXTENSIONS.Contains("*" + format)  ? MediaType.Video : MediaType.Photo).ToString();
            string created = textBoxCreated.Text;
            string _event = textBoxEvent.Text;
            string people = textBoxPeople.Text;
            string location = textBoxLocation.Text;
            string tags = textBoxLocation.Text;
            string description = textBoxDescription.Text;

            Media media = new Media()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Path = path,
                Format = format,
                Type = type,
                CreatedDate = DateTime.Parse(created),
                Event = _event,
                People = people,
                Description = description,
                Location = location,
                Tags = tags
            };

            MyPhotosAPI.SaveMedia(media);

            photosPath.Remove(path);
            if (currentPicture > 0)
                currentPicture--;

            textBoxEvent.Text = "";
            textBoxPeople.Text = "";
            textBoxLocation.Text = "";
            textBoxDescription.Text = "";

            SetContentshow();
            AdjustsTheControlButtons();
        }
        private void Enable(Control control)
        {
            control.Enabled = true;
        }
        private void Disable(Control control)
        {
            control.Enabled = false;
        }
    }
}
