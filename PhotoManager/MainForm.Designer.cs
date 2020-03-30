namespace PhotoManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonExit = new FontAwesome.Sharp.IconButton();
            this.buttonMyPhotos = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuAddPhotos = new System.Windows.Forms.Panel();
            this.fromFolderButton = new System.Windows.Forms.Button();
            this.fromFilesButton = new System.Windows.Forms.Button();
            this.buttonAddPhotos = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuAddPhotos.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(26)))));
            this.panelSideMenu.Controls.Add(this.buttonExit);
            this.panelSideMenu.Controls.Add(this.buttonMyPhotos);
            this.panelSideMenu.Controls.Add(this.panelSubMenuAddPhotos);
            this.panelSideMenu.Controls.Add(this.buttonAddPhotos);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(26)))));
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonExit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.buttonExit.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.IconSize = 32;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(0, 510);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.buttonExit.Rotation = 0D;
            this.buttonExit.Size = new System.Drawing.Size(200, 51);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonMyPhotos
            // 
            this.buttonMyPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(26)))));
            this.buttonMyPhotos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMyPhotos.FlatAppearance.BorderSize = 0;
            this.buttonMyPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyPhotos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonMyPhotos.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyPhotos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMyPhotos.IconChar = FontAwesome.Sharp.IconChar.PhotoVideo;
            this.buttonMyPhotos.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMyPhotos.IconSize = 32;
            this.buttonMyPhotos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyPhotos.Location = new System.Drawing.Point(0, 265);
            this.buttonMyPhotos.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMyPhotos.Name = "buttonMyPhotos";
            this.buttonMyPhotos.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.buttonMyPhotos.Rotation = 0D;
            this.buttonMyPhotos.Size = new System.Drawing.Size(200, 51);
            this.buttonMyPhotos.TabIndex = 4;
            this.buttonMyPhotos.Text = "My Photos";
            this.buttonMyPhotos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyPhotos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMyPhotos.UseVisualStyleBackColor = false;
            this.buttonMyPhotos.Click += new System.EventHandler(this.ButtonMyPhotos_Click);
            // 
            // panelSubMenuAddPhotos
            // 
            this.panelSubMenuAddPhotos.AutoSize = true;
            this.panelSubMenuAddPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.panelSubMenuAddPhotos.Controls.Add(this.fromFolderButton);
            this.panelSubMenuAddPhotos.Controls.Add(this.fromFilesButton);
            this.panelSubMenuAddPhotos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuAddPhotos.Location = new System.Drawing.Point(0, 163);
            this.panelSubMenuAddPhotos.Margin = new System.Windows.Forms.Padding(0);
            this.panelSubMenuAddPhotos.Name = "panelSubMenuAddPhotos";
            this.panelSubMenuAddPhotos.Size = new System.Drawing.Size(200, 102);
            this.panelSubMenuAddPhotos.TabIndex = 3;
            // 
            // fromFolderButton
            // 
            this.fromFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.fromFolderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.fromFolderButton.FlatAppearance.BorderSize = 0;
            this.fromFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromFolderButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromFolderButton.Location = new System.Drawing.Point(0, 51);
            this.fromFolderButton.Margin = new System.Windows.Forms.Padding(0);
            this.fromFolderButton.Name = "fromFolderButton";
            this.fromFolderButton.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.fromFolderButton.Size = new System.Drawing.Size(200, 51);
            this.fromFolderButton.TabIndex = 3;
            this.fromFolderButton.Text = "Folder";
            this.fromFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fromFolderButton.UseVisualStyleBackColor = false;
            this.fromFolderButton.Click += new System.EventHandler(this.FromFolderButton_Click);
            // 
            // fromFilesButton
            // 
            this.fromFilesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.fromFilesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.fromFilesButton.FlatAppearance.BorderSize = 0;
            this.fromFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromFilesButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromFilesButton.Location = new System.Drawing.Point(0, 0);
            this.fromFilesButton.Margin = new System.Windows.Forms.Padding(0);
            this.fromFilesButton.Name = "fromFilesButton";
            this.fromFilesButton.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.fromFilesButton.Size = new System.Drawing.Size(200, 51);
            this.fromFilesButton.TabIndex = 2;
            this.fromFilesButton.Text = "Files";
            this.fromFilesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fromFilesButton.UseVisualStyleBackColor = false;
            this.fromFilesButton.Click += new System.EventHandler(this.FromFilesButton_Click);
            // 
            // buttonAddPhotos
            // 
            this.buttonAddPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(26)))));
            this.buttonAddPhotos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddPhotos.FlatAppearance.BorderSize = 0;
            this.buttonAddPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPhotos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonAddPhotos.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPhotos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddPhotos.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.buttonAddPhotos.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddPhotos.IconSize = 32;
            this.buttonAddPhotos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddPhotos.Location = new System.Drawing.Point(0, 112);
            this.buttonAddPhotos.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddPhotos.Name = "buttonAddPhotos";
            this.buttonAddPhotos.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.buttonAddPhotos.Rotation = 0D;
            this.buttonAddPhotos.Size = new System.Drawing.Size(200, 51);
            this.buttonAddPhotos.TabIndex = 1;
            this.buttonAddPhotos.Text = "Add Photos/Videos";
            this.buttonAddPhotos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddPhotos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddPhotos.UseVisualStyleBackColor = false;
            this.buttonAddPhotos.Click += new System.EventHandler(this.ButtonAddPhotos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.buttonLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 112);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonLogo
            // 
            this.buttonLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(26)))));
            this.buttonLogo.BackgroundImage = global::PhotoManager.Properties.Resources.Logo1;
            this.buttonLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLogo.FlatAppearance.BorderSize = 0;
            this.buttonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogo.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogo.Location = new System.Drawing.Point(0, 0);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(200, 112);
            this.buttonLogo.TabIndex = 0;
            this.buttonLogo.UseVisualStyleBackColor = false;
            this.buttonLogo.Click += new System.EventHandler(this.ButtonLogo_Click);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(200, 0);
            this.panelChild.Margin = new System.Windows.Forms.Padding(0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(584, 561);
            this.panelChild.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "PhotoManager";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelSubMenuAddPhotos.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Panel panelSubMenuAddPhotos;
        private System.Windows.Forms.Button fromFolderButton;
        private System.Windows.Forms.Button fromFilesButton;
        private FontAwesome.Sharp.IconButton buttonAddPhotos;
        private FontAwesome.Sharp.IconButton buttonMyPhotos;
        private FontAwesome.Sharp.IconButton buttonExit;
        private System.Windows.Forms.Button buttonLogo;
    }
}

