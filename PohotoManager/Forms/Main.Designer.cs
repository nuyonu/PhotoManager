namespace PhotoManager.Forms
{
    partial class Main
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalMediaFromBegin = new System.Windows.Forms.Label();
            this.labelTotalMediaNow = new System.Windows.Forms.Label();
            this.labelTotalVideos = new System.Windows.Forms.Label();
            this.labelTotalPhotos = new System.Windows.Forms.Label();
            this.labelTotalMediaDeleted = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 181);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(92, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "Best for videos and photos\r\n             management";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelTotalMediaDeleted);
            this.panel1.Controls.Add(this.labelTotalPhotos);
            this.panel1.Controls.Add(this.labelTotalVideos);
            this.panel1.Controls.Add(this.labelTotalMediaNow);
            this.panel1.Controls.Add(this.labelTotalMediaFromBegin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(568, 341);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PhotoManager.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(190, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 68);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(558, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "Statistics";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalMediaFromBegin
            // 
            this.labelTotalMediaFromBegin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalMediaFromBegin.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTotalMediaFromBegin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMediaFromBegin.Location = new System.Drawing.Point(3, 60);
            this.labelTotalMediaFromBegin.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalMediaFromBegin.Name = "labelTotalMediaFromBegin";
            this.labelTotalMediaFromBegin.Padding = new System.Windows.Forms.Padding(5);
            this.labelTotalMediaFromBegin.Size = new System.Drawing.Size(558, 35);
            this.labelTotalMediaFromBegin.TabIndex = 1;
            this.labelTotalMediaFromBegin.Text = "Total media stored from begin: 4514";
            this.labelTotalMediaFromBegin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalMediaNow
            // 
            this.labelTotalMediaNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalMediaNow.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTotalMediaNow.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMediaNow.Location = new System.Drawing.Point(3, 95);
            this.labelTotalMediaNow.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalMediaNow.Name = "labelTotalMediaNow";
            this.labelTotalMediaNow.Padding = new System.Windows.Forms.Padding(5);
            this.labelTotalMediaNow.Size = new System.Drawing.Size(558, 35);
            this.labelTotalMediaNow.TabIndex = 2;
            this.labelTotalMediaNow.Text = "Total media now: 495";
            this.labelTotalMediaNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalVideos
            // 
            this.labelTotalVideos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalVideos.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTotalVideos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVideos.Location = new System.Drawing.Point(3, 130);
            this.labelTotalVideos.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalVideos.Name = "labelTotalVideos";
            this.labelTotalVideos.Padding = new System.Windows.Forms.Padding(5);
            this.labelTotalVideos.Size = new System.Drawing.Size(558, 35);
            this.labelTotalVideos.TabIndex = 3;
            this.labelTotalVideos.Text = "Total videos: 40";
            this.labelTotalVideos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalPhotos
            // 
            this.labelTotalPhotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalPhotos.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTotalPhotos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPhotos.Location = new System.Drawing.Point(3, 165);
            this.labelTotalPhotos.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalPhotos.Name = "labelTotalPhotos";
            this.labelTotalPhotos.Padding = new System.Windows.Forms.Padding(5);
            this.labelTotalPhotos.Size = new System.Drawing.Size(558, 35);
            this.labelTotalPhotos.TabIndex = 4;
            this.labelTotalPhotos.Text = "Total photos: 503";
            this.labelTotalPhotos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalMediaDeleted
            // 
            this.labelTotalMediaDeleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalMediaDeleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTotalMediaDeleted.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMediaDeleted.Location = new System.Drawing.Point(3, 200);
            this.labelTotalMediaDeleted.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalMediaDeleted.Name = "labelTotalMediaDeleted";
            this.labelTotalMediaDeleted.Padding = new System.Windows.Forms.Padding(5);
            this.labelTotalMediaDeleted.Size = new System.Drawing.Size(558, 35);
            this.labelTotalMediaDeleted.TabIndex = 5;
            this.labelTotalMediaDeleted.Text = "Total media deleted: 5042";
            this.labelTotalMediaDeleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(568, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalMediaFromBegin;
        private System.Windows.Forms.Label labelTotalPhotos;
        private System.Windows.Forms.Label labelTotalVideos;
        private System.Windows.Forms.Label labelTotalMediaNow;
        private System.Windows.Forms.Label labelTotalMediaDeleted;
    }
}