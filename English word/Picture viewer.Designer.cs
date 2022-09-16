namespace English_word
{
    partial class Picture_viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Picture_viewer));
            this.btnPasswordClose = new System.Windows.Forms.Button();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.btnRotRight = new System.Windows.Forms.Button();
            this.btnRotLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnMix = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.PicturePictureBox = new System.Windows.Forms.PictureBox();
            this.gbTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPasswordClose
            // 
            this.btnPasswordClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPasswordClose.BackgroundImage")));
            this.btnPasswordClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasswordClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPasswordClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPasswordClose.Location = new System.Drawing.Point(1085, 2);
            this.btnPasswordClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnPasswordClose.Name = "btnPasswordClose";
            this.btnPasswordClose.Size = new System.Drawing.Size(26, 22);
            this.btnPasswordClose.TabIndex = 58;
            this.btnPasswordClose.UseVisualStyleBackColor = true;
            this.btnPasswordClose.Click += new System.EventHandler(this.btnPasswordClose_Click);
            // 
            // gbTools
            // 
            this.gbTools.BackColor = System.Drawing.Color.Transparent;
            this.gbTools.BackgroundImage = global::English_word.Properties.Resources.Untitled_4;
            this.gbTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbTools.Controls.Add(this.btnRotRight);
            this.gbTools.Controls.Add(this.btnRotLeft);
            this.gbTools.Controls.Add(this.label1);
            this.gbTools.Controls.Add(this.btnPrev);
            this.gbTools.Controls.Add(this.btnNext);
            this.gbTools.Controls.Add(this.lblPosition);
            this.gbTools.Controls.Add(this.btnMix);
            this.gbTools.Controls.Add(this.btnMin);
            this.gbTools.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbTools.Location = new System.Drawing.Point(2, 611);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(1104, 49);
            this.gbTools.TabIndex = 6;
            this.gbTools.TabStop = false;
            // 
            // btnRotRight
            // 
            this.btnRotRight.FlatAppearance.BorderSize = 0;
            this.btnRotRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRotRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRotRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRotRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotRight.Location = new System.Drawing.Point(880, 21);
            this.btnRotRight.Name = "btnRotRight";
            this.btnRotRight.Size = new System.Drawing.Size(58, 23);
            this.btnRotRight.TabIndex = 59;
            this.btnRotRight.UseVisualStyleBackColor = true;
            this.btnRotRight.Click += new System.EventHandler(this.btnRotRight_Click);
            // 
            // btnRotLeft
            // 
            this.btnRotLeft.FlatAppearance.BorderSize = 0;
            this.btnRotLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRotLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRotLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRotLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotLeft.Location = new System.Drawing.Point(808, 21);
            this.btnRotLeft.Name = "btnRotLeft";
            this.btnRotLeft.Size = new System.Drawing.Size(58, 23);
            this.btnRotLeft.TabIndex = 58;
            this.btnRotLeft.UseVisualStyleBackColor = true;
            this.btnRotLeft.Click += new System.EventHandler(this.btnRotLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrev.Enabled = false;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(483, 19);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(57, 23);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(597, 18);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPosition.Location = new System.Drawing.Point(330, 26);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 13);
            this.lblPosition.TabIndex = 4;
            // 
            // btnMix
            // 
            this.btnMix.BackColor = System.Drawing.Color.Transparent;
            this.btnMix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMix.FlatAppearance.BorderSize = 0;
            this.btnMix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMix.Location = new System.Drawing.Point(29, 18);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(57, 23);
            this.btnMix.TabIndex = 3;
            this.btnMix.UseVisualStyleBackColor = false;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(94, 19);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(52, 23);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // PicturePictureBox
            // 
            this.PicturePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PicturePictureBox.Image")));
            this.PicturePictureBox.Location = new System.Drawing.Point(0, 5);
            this.PicturePictureBox.Name = "PicturePictureBox";
            this.PicturePictureBox.Size = new System.Drawing.Size(647, 314);
            this.PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePictureBox.TabIndex = 5;
            this.PicturePictureBox.TabStop = false;
            this.PicturePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicturePictureBox_MouseDown);
            this.PicturePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicturePictureBox_MouseUp);
            // 
            // Picture_viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1106, 665);
            this.ControlBox = false;
            this.Controls.Add(this.btnPasswordClose);
            this.Controls.Add(this.gbTools);
            this.Controls.Add(this.PicturePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Picture_viewer";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture_viewer";
            this.TopMost = true;
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.Button btnRotRight;
        private System.Windows.Forms.Button btnRotLeft;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnPrev;
        public System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnMin;
        public System.Windows.Forms.PictureBox PicturePictureBox;
        internal System.Windows.Forms.Button btnPasswordClose;
    }
}