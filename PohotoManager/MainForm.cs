using PhotoManager.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PhotoManager
{
    public partial class MainForm : Form
    {
        private List<Button> allButtons = new List<Button>();
        public MainForm()
        {
            InitializeComponent();
            OpenChildForm(new Main());
            CustomizeDesign();

            CollectButtons(panelSubMenuAddPhotos);
            CollectButtons(panelSideMenu);
            CollectButtons(panelLogo);

            DisableCurrentButton(buttonLogo);
            this.DoubleBuffered = true;
        }
        private void CustomizeDesign()
        {
            panelSubMenuAddPhotos.Visible = false;
        }
        private void ShowSubMenu(Panel panel)
        {
            if (panel.Visible == true)
                panel.Visible = false;
            else
            {
                HidAllSubMenus();
                panel.Visible = true;
            }
        }
        private void HidAllSubMenus()
        {
            panelSubMenuAddPhotos.Visible = false;
        }
        private void ButtonAddPhotos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuAddPhotos);
        }
        private void ButtonMyPhotos_Click(object sender, EventArgs e)
        {
            HidAllSubMenus();
            DisableCurrentButton(buttonMyPhotos);
            OpenChildForm(new MyPhotosForm());
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void FromFilesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddPhotos(Mode.Files));
            DisableCurrentButton(fromFilesButton);
        }
        private void FromFolderButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddPhotos(Mode.Directory));
            DisableCurrentButton(fromFolderButton);
        }
        private void DisableCurrentButton(Button currentButton)
        {
            currentButton.Enabled = false;
            (from button in allButtons
                        where button != currentButton
                        select button).ToList().ForEach(b => b.Enabled = true);
        }
        private void CollectButtons(Control control)
        {
            foreach (Button button in control.Controls.OfType<Button>())
            {
                allButtons.Add(button);
            }
        }

        private void ButtonLogo_Click(object sender, EventArgs e)
        {
            HidAllSubMenus();
            OpenChildForm(new Main());
            DisableCurrentButton(buttonLogo);
        }
    }
}
