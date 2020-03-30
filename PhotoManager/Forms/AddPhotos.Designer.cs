namespace PhotoManager.Forms
{
    partial class AddPhotos
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            this.panelRightMenu = new System.Windows.Forms.Panel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxTags = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxPeople = new System.Windows.Forms.TextBox();
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.textBoxCreated = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonSwitchRight = new FontAwesome.Sharp.IconButton();
            this.buttonSwitchLeft = new FontAwesome.Sharp.IconButton();
            this.buttonAddToDatabase = new System.Windows.Forms.Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.labelShow = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.panelRightMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Location = new System.Drawing.Point(10, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 18);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Top;
            label5.Location = new System.Drawing.Point(10, 48);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 18);
            label5.TabIndex = 18;
            label5.Text = "Path";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = System.Windows.Forms.DockStyle.Top;
            label10.Location = new System.Drawing.Point(10, 91);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(52, 18);
            label10.TabIndex = 20;
            label10.Text = "Created";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Location = new System.Drawing.Point(10, 134);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 18);
            label3.TabIndex = 22;
            label3.Text = "Event";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Top;
            label4.Location = new System.Drawing.Point(10, 177);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 18);
            label4.TabIndex = 24;
            label4.Text = "People";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = System.Windows.Forms.DockStyle.Top;
            label7.Location = new System.Drawing.Point(10, 220);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(57, 18);
            label7.TabIndex = 26;
            label7.Text = "Location";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = System.Windows.Forms.DockStyle.Top;
            label8.Location = new System.Drawing.Point(10, 306);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(73, 18);
            label8.TabIndex = 30;
            label8.Text = "Description";
            // 
            // panelRightMenu
            // 
            this.panelRightMenu.Controls.Add(this.textBoxDescription);
            this.panelRightMenu.Controls.Add(label8);
            this.panelRightMenu.Controls.Add(this.textBoxTags);
            this.panelRightMenu.Controls.Add(this.label1);
            this.panelRightMenu.Controls.Add(this.textBoxLocation);
            this.panelRightMenu.Controls.Add(label7);
            this.panelRightMenu.Controls.Add(this.textBoxPeople);
            this.panelRightMenu.Controls.Add(label4);
            this.panelRightMenu.Controls.Add(this.textBoxEvent);
            this.panelRightMenu.Controls.Add(label3);
            this.panelRightMenu.Controls.Add(this.textBoxCreated);
            this.panelRightMenu.Controls.Add(label10);
            this.panelRightMenu.Controls.Add(this.textBoxPath);
            this.panelRightMenu.Controls.Add(label5);
            this.panelRightMenu.Controls.Add(this.textBoxName);
            this.panelRightMenu.Controls.Add(this.buttonLoad);
            this.panelRightMenu.Controls.Add(label2);
            this.panelRightMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightMenu.Location = new System.Drawing.Point(276, 0);
            this.panelRightMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRightMenu.Name = "panelRightMenu";
            this.panelRightMenu.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.panelRightMenu.Size = new System.Drawing.Size(292, 522);
            this.panelRightMenu.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(10, 324);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(272, 156);
            this.textBoxDescription.TabIndex = 31;
            // 
            // textBoxTags
            // 
            this.textBoxTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTags.Location = new System.Drawing.Point(10, 281);
            this.textBoxTags.Name = "textBoxTags";
            this.textBoxTags.Size = new System.Drawing.Size(272, 25);
            this.textBoxTags.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tags";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxLocation.Location = new System.Drawing.Point(10, 238);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(272, 25);
            this.textBoxLocation.TabIndex = 27;
            // 
            // textBoxPeople
            // 
            this.textBoxPeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPeople.Location = new System.Drawing.Point(10, 195);
            this.textBoxPeople.Name = "textBoxPeople";
            this.textBoxPeople.Size = new System.Drawing.Size(272, 25);
            this.textBoxPeople.TabIndex = 25;
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxEvent.Location = new System.Drawing.Point(10, 152);
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(272, 25);
            this.textBoxEvent.TabIndex = 23;
            // 
            // textBoxCreated
            // 
            this.textBoxCreated.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxCreated.Enabled = false;
            this.textBoxCreated.Location = new System.Drawing.Point(10, 109);
            this.textBoxCreated.Name = "textBoxCreated";
            this.textBoxCreated.Size = new System.Drawing.Size(272, 25);
            this.textBoxCreated.TabIndex = 21;
            this.textBoxCreated.Text = "Disabled";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPath.Enabled = false;
            this.textBoxPath.Location = new System.Drawing.Point(10, 66);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(272, 25);
            this.textBoxPath.TabIndex = 19;
            this.textBoxPath.Text = "Disabled";
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxName.Location = new System.Drawing.Point(10, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(272, 25);
            this.textBoxName.TabIndex = 17;
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Location = new System.Drawing.Point(10, 480);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(272, 32);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load from directory";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCount);
            this.panel2.Controls.Add(this.buttonSwitchRight);
            this.panel2.Controls.Add(this.buttonSwitchLeft);
            this.panel2.Controls.Add(this.buttonAddToDatabase);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 453);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 69);
            this.panel2.TabIndex = 1;
            // 
            // labelCount
            // 
            this.labelCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(121, 4);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(27, 18);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "0/0";
            // 
            // buttonSwitchRight
            // 
            this.buttonSwitchRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSwitchRight.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSwitchRight.FlatAppearance.BorderSize = 0;
            this.buttonSwitchRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitchRight.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSwitchRight.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.buttonSwitchRight.IconColor = System.Drawing.Color.Black;
            this.buttonSwitchRight.IconSize = 16;
            this.buttonSwitchRight.Location = new System.Drawing.Point(205, 24);
            this.buttonSwitchRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSwitchRight.Name = "buttonSwitchRight";
            this.buttonSwitchRight.Rotation = 0D;
            this.buttonSwitchRight.Size = new System.Drawing.Size(45, 32);
            this.buttonSwitchRight.TabIndex = 3;
            this.buttonSwitchRight.UseVisualStyleBackColor = false;
            this.buttonSwitchRight.Click += new System.EventHandler(this.ButtonSwitchRight_Click);
            // 
            // buttonSwitchLeft
            // 
            this.buttonSwitchLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSwitchLeft.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSwitchLeft.FlatAppearance.BorderSize = 0;
            this.buttonSwitchLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitchLeft.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSwitchLeft.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.buttonSwitchLeft.IconColor = System.Drawing.Color.Black;
            this.buttonSwitchLeft.IconSize = 16;
            this.buttonSwitchLeft.Location = new System.Drawing.Point(27, 24);
            this.buttonSwitchLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSwitchLeft.Name = "buttonSwitchLeft";
            this.buttonSwitchLeft.Rotation = 0D;
            this.buttonSwitchLeft.Size = new System.Drawing.Size(45, 32);
            this.buttonSwitchLeft.TabIndex = 2;
            this.buttonSwitchLeft.UseVisualStyleBackColor = false;
            this.buttonSwitchLeft.Click += new System.EventHandler(this.ButtonSwitchLeft_Click);
            // 
            // buttonAddToDatabase
            // 
            this.buttonAddToDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddToDatabase.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddToDatabase.FlatAppearance.BorderSize = 0;
            this.buttonAddToDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToDatabase.Location = new System.Drawing.Point(78, 24);
            this.buttonAddToDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddToDatabase.Name = "buttonAddToDatabase";
            this.buttonAddToDatabase.Size = new System.Drawing.Size(121, 32);
            this.buttonAddToDatabase.TabIndex = 1;
            this.buttonAddToDatabase.Text = "Save";
            this.buttonAddToDatabase.UseVisualStyleBackColor = false;
            this.buttonAddToDatabase.Click += new System.EventHandler(this.ButtonAddToDatabase_Click);
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.labelShow);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelShow.Name = "panelShow";
            this.panelShow.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.panelShow.Size = new System.Drawing.Size(276, 453);
            this.panelShow.TabIndex = 2;
            // 
            // labelShow
            // 
            this.labelShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShow.Location = new System.Drawing.Point(57, 207);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(172, 42);
            this.labelShow.TabIndex = 0;
            this.labelShow.Text = "Loaded images/videos\r\n    will displayed here";
            // 
            // AddPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(568, 522);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelRightMenu);
            this.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddPhotos";
            this.Text = "AddPhotos";
            this.panelRightMenu.ResumeLayout(false);
            this.panelRightMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRightMenu;
        private System.Windows.Forms.Button buttonAddToDatabase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Button buttonLoad;
        private FontAwesome.Sharp.IconButton buttonSwitchLeft;
        private FontAwesome.Sharp.IconButton buttonSwitchRight;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCreated;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxPeople;
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTags;
        private System.Windows.Forms.Label label1;
    }
}