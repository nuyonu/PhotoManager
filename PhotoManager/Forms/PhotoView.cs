using MyPhotosDatabase;
using MyPhotosDatabase.Enums;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhotoManager.Forms
{
    public partial class PhotoView : Form
    {
        private readonly PictureBox photoShowPictureBox = new PictureBox();
        private readonly Media _media;
        public PhotoView(Media media)
        {
            InitializeComponent();
            _media = media;

            photoShowPictureBox.Dock = DockStyle.Fill;
            photoShowPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            videoShowMediaPlayer.Hide();
            photoShowPictureBox.Hide();

            panelShow.Controls.Add(photoShowPictureBox);

            InitializeData();
        }
        public void InitializeData()
        {
            if(_media.Type == MediaType.Photo.ToString())
            {
                photoShowPictureBox.Show();
                photoShowPictureBox.Image = (Bitmap)Image.FromFile(_media.Path);
            }
            else
            {
                videoShowMediaPlayer.Show();
                videoShowMediaPlayer.settings.autoStart = false;
                videoShowMediaPlayer.URL = _media.Path;
                buttonPrint.Enabled = false;
            }
            textBoxName.Text = _media.Name;
            textBoxPath.Text = _media.Path;
            textBoxCreated.Text = _media.CreatedDate.ToString();
            textBoxDescription.Text = _media.Description;
            textBoxEvent.Text = _media.Event;
            textBoxPeople.Text = _media.People;
            textBoxLocation.Text = _media.Location;
            textBoxTags.Text = _media.Tags;
        }
        private void ButtonSaveChanges_Click(object sender, EventArgs e)
        { 
            _media.Name = textBoxName.Text;
            _media.Event = textBoxEvent.Text;
            _media.People = textBoxPeople.Text;
            _media.Location = textBoxLocation.Text;
            _media.Tags = textBoxTags.Text;
            _media.Description = textBoxDescription.Text;
            MyPhotosAPI.UpdateMedia(_media.Id, _media);
        }
        private void ButtonOpenFileExplorer_Click(object sender, EventArgs e)
        {
            if (File.Exists(_media.Path))
            {
                Process.Start("explorer.exe", Path.GetDirectoryName(_media.Path));
            }
        }
        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = _media.Path;
            process.StartInfo.Verb = "Print";
            process.Start();
        }
    }
}
