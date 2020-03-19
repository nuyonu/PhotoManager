namespace PhotoManager.Forms
{
    partial class MyPhotosForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxByDescription = new System.Windows.Forms.CheckBox();
            this.checkBoxByTags = new System.Windows.Forms.CheckBox();
            this.checkBoxByPeople = new System.Windows.Forms.CheckBox();
            this.checkBoxByEvent = new System.Windows.Forms.CheckBox();
            this.checkBoxByDate = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.flowLayoutPanelMyPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.checkBoxByLocation = new System.Windows.Forms.CheckBox();
            this.panelTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel3);
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panelTop.Size = new System.Drawing.Size(568, 85);
            this.panelTop.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBoxByLocation);
            this.panel3.Controls.Add(this.checkBoxByDescription);
            this.panel3.Controls.Add(this.checkBoxByTags);
            this.panel3.Controls.Add(this.checkBoxByPeople);
            this.panel3.Controls.Add(this.checkBoxByEvent);
            this.panel3.Controls.Add(this.checkBoxByDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(6, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 32);
            this.panel3.TabIndex = 1;
            // 
            // checkBoxByDescription
            // 
            this.checkBoxByDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxByDescription.AutoSize = true;
            this.checkBoxByDescription.Location = new System.Drawing.Point(427, 0);
            this.checkBoxByDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxByDescription.Name = "checkBoxByDescription";
            this.checkBoxByDescription.Size = new System.Drawing.Size(106, 22);
            this.checkBoxByDescription.TabIndex = 7;
            this.checkBoxByDescription.Text = "by description";
            this.checkBoxByDescription.UseVisualStyleBackColor = true;
            // 
            // checkBoxByTags
            // 
            this.checkBoxByTags.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxByTags.AutoSize = true;
            this.checkBoxByTags.Location = new System.Drawing.Point(353, 0);
            this.checkBoxByTags.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxByTags.Name = "checkBoxByTags";
            this.checkBoxByTags.Size = new System.Drawing.Size(68, 22);
            this.checkBoxByTags.TabIndex = 6;
            this.checkBoxByTags.Text = "by tags";
            this.checkBoxByTags.UseVisualStyleBackColor = true;
            // 
            // checkBoxByPeople
            // 
            this.checkBoxByPeople.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxByPeople.AutoSize = true;
            this.checkBoxByPeople.Location = new System.Drawing.Point(173, 0);
            this.checkBoxByPeople.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxByPeople.Name = "checkBoxByPeople";
            this.checkBoxByPeople.Size = new System.Drawing.Size(81, 22);
            this.checkBoxByPeople.TabIndex = 5;
            this.checkBoxByPeople.Text = "by people";
            this.checkBoxByPeople.UseVisualStyleBackColor = true;
            // 
            // checkBoxByEvent
            // 
            this.checkBoxByEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxByEvent.AutoSize = true;
            this.checkBoxByEvent.Location = new System.Drawing.Point(93, 0);
            this.checkBoxByEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxByEvent.Name = "checkBoxByEvent";
            this.checkBoxByEvent.Size = new System.Drawing.Size(74, 22);
            this.checkBoxByEvent.TabIndex = 4;
            this.checkBoxByEvent.Text = "by event";
            this.checkBoxByEvent.UseVisualStyleBackColor = true;
            // 
            // checkBoxByDate
            // 
            this.checkBoxByDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxByDate.AutoSize = true;
            this.checkBoxByDate.Location = new System.Drawing.Point(25, 0);
            this.checkBoxByDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxByDate.Name = "checkBoxByDate";
            this.checkBoxByDate.Size = new System.Drawing.Size(68, 22);
            this.checkBoxByDate.TabIndex = 3;
            this.checkBoxByDate.Text = "by date";
            this.checkBoxByDate.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(6, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panel2.Size = new System.Drawing.Size(556, 39);
            this.panel2.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Location = new System.Drawing.Point(85, 7);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(465, 25);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(6, 7);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(79, 25);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonArchive);
            this.panelBottom.Controls.Add(this.buttonSelectAll);
            this.panelBottom.Controls.Add(this.buttonDeleteSelected);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 472);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(568, 50);
            this.panelBottom.TabIndex = 2;
            // 
            // buttonArchive
            // 
            this.buttonArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.buttonArchive.FlatAppearance.BorderSize = 0;
            this.buttonArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArchive.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonArchive.Location = new System.Drawing.Point(351, 15);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(156, 23);
            this.buttonArchive.TabIndex = 3;
            this.buttonArchive.Text = "Archive selected media";
            this.buttonArchive.UseVisualStyleBackColor = false;
            this.buttonArchive.Click += new System.EventHandler(this.ButtonArchive_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.buttonSelectAll.FlatAppearance.BorderSize = 0;
            this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSelectAll.Location = new System.Drawing.Point(78, 15);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(105, 23);
            this.buttonSelectAll.TabIndex = 2;
            this.buttonSelectAll.Text = "Select all";
            this.buttonSelectAll.UseVisualStyleBackColor = false;
            this.buttonSelectAll.Click += new System.EventHandler(this.ButtonSelectAll_Click);
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.buttonDeleteSelected.FlatAppearance.BorderSize = 0;
            this.buttonDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSelected.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteSelected.Location = new System.Drawing.Point(189, 15);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(156, 23);
            this.buttonDeleteSelected.TabIndex = 1;
            this.buttonDeleteSelected.Text = "Delete selected media";
            this.buttonDeleteSelected.UseVisualStyleBackColor = false;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.ButtonDeleteSelected_Click);
            // 
            // flowLayoutPanelMyPhotos
            // 
            this.flowLayoutPanelMyPhotos.AutoScroll = true;
            this.flowLayoutPanelMyPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMyPhotos.Location = new System.Drawing.Point(0, 85);
            this.flowLayoutPanelMyPhotos.Name = "flowLayoutPanelMyPhotos";
            this.flowLayoutPanelMyPhotos.Size = new System.Drawing.Size(568, 387);
            this.flowLayoutPanelMyPhotos.TabIndex = 3;
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLoading.Image = global::PhotoManager.Properties.Resources.Loading;
            this.pictureBoxLoading.Location = new System.Drawing.Point(150, 165);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(264, 201);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoading.TabIndex = 4;
            this.pictureBoxLoading.TabStop = false;
            // 
            // checkBoxByLocation
            // 
            this.checkBoxByLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxByLocation.AutoSize = true;
            this.checkBoxByLocation.Location = new System.Drawing.Point(259, 0);
            this.checkBoxByLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxByLocation.Name = "checkBoxByLocation";
            this.checkBoxByLocation.Size = new System.Drawing.Size(88, 22);
            this.checkBoxByLocation.TabIndex = 8;
            this.checkBoxByLocation.Text = "by location";
            this.checkBoxByLocation.UseVisualStyleBackColor = true;
            // 
            // MyPhotosForm
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(568, 522);
            this.Controls.Add(this.pictureBoxLoading);
            this.Controls.Add(this.flowLayoutPanelMyPhotos);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MyPhotosForm";
            this.Text = "PhotoManager";
            this.panelTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxByEvent;
        private System.Windows.Forms.CheckBox checkBoxByDate;
        private System.Windows.Forms.CheckBox checkBoxByPeople;
        private System.Windows.Forms.CheckBox checkBoxByDescription;
        private System.Windows.Forms.CheckBox checkBoxByTags;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMyPhotos;
        private System.Windows.Forms.Button buttonArchive;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.CheckBox checkBoxByLocation;
    }
}