namespace English_word
{
    partial class New_note
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
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_note));
            this.TCNote = new System.Windows.Forms.TabControl();
            this.tpNote = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.rtxtNoteMore = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNoteID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpNote = new System.Windows.Forms.DateTimePicker();
            this.txtNoteSubject = new System.Windows.Forms.RichTextBox();
            this.tpNotePic = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.rtxtNotePicCom = new System.Windows.Forms.RichTextBox();
            this.txtNoteSearch = new System.Windows.Forms.TextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.txtNotePosition = new System.Windows.Forms.ToolStripTextBox();
            this.lblNotesTotalItems = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnNoteMoveFirst = new System.Windows.Forms.ToolStripButton();
            this.btnNoteMovePrev = new System.Windows.Forms.ToolStripButton();
            this.btnNoteMoveNex = new System.Windows.Forms.ToolStripButton();
            this.btnNoteMoveLast = new System.Windows.Forms.ToolStripButton();
            this.btnAddNew = new System.Windows.Forms.ToolStripButton();
            this.btnSaveData = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pbNotes = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            this.TCNote.SuspendLayout();
            this.tpNote.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tpNotePic.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.White;
            label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(526, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 19);
            label6.TabIndex = 85;
            label6.Text = "Notes";
            // 
            // TCNote
            // 
            this.TCNote.Controls.Add(this.tpNote);
            this.TCNote.Controls.Add(this.tpNotePic);
            this.TCNote.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCNote.Location = new System.Drawing.Point(-4, 37);
            this.TCNote.Name = "TCNote";
            this.TCNote.SelectedIndex = 0;
            this.TCNote.Size = new System.Drawing.Size(1134, 458);
            this.TCNote.TabIndex = 1;
            // 
            // tpNote
            // 
            this.tpNote.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpNote.Controls.Add(this.label20);
            this.tpNote.Controls.Add(this.rtxtNoteMore);
            this.tpNote.Controls.Add(this.label16);
            this.tpNote.Controls.Add(this.rtxtNote);
            this.tpNote.Controls.Add(this.groupBox4);
            this.tpNote.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpNote.Location = new System.Drawing.Point(4, 25);
            this.tpNote.Name = "tpNote";
            this.tpNote.Padding = new System.Windows.Forms.Padding(3);
            this.tpNote.Size = new System.Drawing.Size(1126, 429);
            this.tpNote.TabIndex = 0;
            this.tpNote.Text = "Note";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(760, 87);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 16);
            this.label20.TabIndex = 81;
            this.label20.Text = "Examples:";
            // 
            // rtxtNoteMore
            // 
            this.rtxtNoteMore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtxtNoteMore.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNoteMore.Location = new System.Drawing.Point(760, 107);
            this.rtxtNoteMore.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rtxtNoteMore.Name = "rtxtNoteMore";
            this.rtxtNoteMore.Size = new System.Drawing.Size(292, 136);
            this.rtxtNoteMore.TabIndex = 80;
            this.rtxtNoteMore.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 88);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 16);
            this.label16.TabIndex = 78;
            this.label16.Text = "Explanation:";
            // 
            // rtxtNote
            // 
            this.rtxtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rtxtNote.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNote.Location = new System.Drawing.Point(34, 112);
            this.rtxtNote.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(650, 283);
            this.rtxtNote.TabIndex = 77;
            this.rtxtNote.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtNoteID);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.dtpNote);
            this.groupBox4.Controls.Add(this.txtNoteSubject);
            this.groupBox4.Location = new System.Drawing.Point(2, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Size = new System.Drawing.Size(1033, 63);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(164, 27);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 16);
            this.label17.TabIndex = 62;
            this.label17.Text = "Subject  :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 31);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 16);
            this.label18.TabIndex = 7;
            this.label18.Text = "ID :";
            // 
            // txtNoteID
            // 
            this.txtNoteID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNoteID.Enabled = false;
            this.txtNoteID.Location = new System.Drawing.Point(60, 23);
            this.txtNoteID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNoteID.Multiline = true;
            this.txtNoteID.Name = "txtNoteID";
            this.txtNoteID.Size = new System.Drawing.Size(75, 24);
            this.txtNoteID.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(682, 25);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 16);
            this.label19.TabIndex = 65;
            this.label19.Text = "Date  :";
            // 
            // dtpNote
            // 
            this.dtpNote.Location = new System.Drawing.Point(733, 20);
            this.dtpNote.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpNote.Name = "dtpNote";
            this.dtpNote.Size = new System.Drawing.Size(203, 23);
            this.dtpNote.TabIndex = 59;
            // 
            // txtNoteSubject
            // 
            this.txtNoteSubject.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNoteSubject.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteSubject.ForeColor = System.Drawing.Color.Purple;
            this.txtNoteSubject.Location = new System.Drawing.Point(239, 17);
            this.txtNoteSubject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNoteSubject.Name = "txtNoteSubject";
            this.txtNoteSubject.Size = new System.Drawing.Size(437, 32);
            this.txtNoteSubject.TabIndex = 61;
            this.txtNoteSubject.Text = "";
            // 
            // tpNotePic
            // 
            this.tpNotePic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpNotePic.Controls.Add(this.label21);
            this.tpNotePic.Controls.Add(this.rtxtNotePicCom);
            this.tpNotePic.Controls.Add(this.button1);
            this.tpNotePic.Controls.Add(this.pbNotes);
            this.tpNotePic.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpNotePic.Location = new System.Drawing.Point(4, 25);
            this.tpNotePic.Name = "tpNotePic";
            this.tpNotePic.Padding = new System.Windows.Forms.Padding(3);
            this.tpNotePic.Size = new System.Drawing.Size(1126, 429);
            this.tpNotePic.TabIndex = 1;
            this.tpNotePic.Text = "Note picture";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 236);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(126, 16);
            this.label21.TabIndex = 38;
            this.label21.Text = "Picture comment :";
            // 
            // rtxtNotePicCom
            // 
            this.rtxtNotePicCom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtxtNotePicCom.Location = new System.Drawing.Point(16, 254);
            this.rtxtNotePicCom.Name = "rtxtNotePicCom";
            this.rtxtNotePicCom.Size = new System.Drawing.Size(457, 96);
            this.rtxtNotePicCom.TabIndex = 37;
            this.rtxtNotePicCom.Text = "";
            // 
            // txtNoteSearch
            // 
            this.txtNoteSearch.Location = new System.Drawing.Point(807, 4);
            this.txtNoteSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNoteSearch.Multiline = true;
            this.txtNoteSearch.Name = "txtNoteSearch";
            this.txtNoteSearch.Size = new System.Drawing.Size(216, 22);
            this.txtNoteSearch.TabIndex = 82;
            this.txtNoteSearch.TextChanged += new System.EventHandler(this.txtNoteSearch_TextChanged);
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.BackColor = System.Drawing.Color.White;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNoteMoveFirst,
            this.btnNoteMovePrev,
            this.toolStripSeparator4,
            this.txtNotePosition,
            this.lblNotesTotalItems,
            this.toolStripSeparator5,
            this.btnNoteMoveNex,
            this.btnNoteMoveLast,
            this.toolStripSeparator6,
            this.btnAddNew,
            this.btnSaveData,
            this.btnDelete,
            this.btnPreviousPage,
            this.btnNextPage});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1126, 34);
            this.toolStrip3.Stretch = true;
            this.toolStrip3.TabIndex = 80;
            this.toolStrip3.Text = "toolStrip3";
            this.toolStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip3_ItemClicked);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // txtNotePosition
            // 
            this.txtNotePosition.AccessibleName = "Position";
            this.txtNotePosition.AutoSize = false;
            this.txtNotePosition.Name = "txtNotePosition";
            this.txtNotePosition.Size = new System.Drawing.Size(57, 21);
            this.txtNotePosition.Text = "0";
            this.txtNotePosition.ToolTipText = "Current position";
            this.txtNotePosition.Click += new System.EventHandler(this.txtNotePosition_Click);
            this.txtNotePosition.TextChanged += new System.EventHandler(this.txtNotePosition_TextChanged);
            // 
            // lblNotesTotalItems
            // 
            this.lblNotesTotalItems.Name = "lblNotesTotalItems";
            this.lblNotesTotalItems.Size = new System.Drawing.Size(36, 31);
            this.lblNotesTotalItems.Text = "of {0}";
            this.lblNotesTotalItems.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 34);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(1085, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 22);
            this.button2.TabIndex = 84;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::English_word.Properties.Resources.Untit44led_8;
            this.pictureBox9.Location = new System.Drawing.Point(746, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(45, 22);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 83;
            this.pictureBox9.TabStop = false;
            // 
            // btnNoteMoveFirst
            // 
            this.btnNoteMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNoteMoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnNoteMoveFirst.Image")));
            this.btnNoteMoveFirst.Name = "btnNoteMoveFirst";
            this.btnNoteMoveFirst.RightToLeftAutoMirrorImage = true;
            this.btnNoteMoveFirst.Size = new System.Drawing.Size(23, 31);
            this.btnNoteMoveFirst.Text = "Move first";
            this.btnNoteMoveFirst.Click += new System.EventHandler(this.btnNoteMoveFirst_Click);
            // 
            // btnNoteMovePrev
            // 
            this.btnNoteMovePrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNoteMovePrev.Image = ((System.Drawing.Image)(resources.GetObject("btnNoteMovePrev.Image")));
            this.btnNoteMovePrev.Name = "btnNoteMovePrev";
            this.btnNoteMovePrev.RightToLeftAutoMirrorImage = true;
            this.btnNoteMovePrev.Size = new System.Drawing.Size(23, 31);
            this.btnNoteMovePrev.Text = "Move previous";
            this.btnNoteMovePrev.Click += new System.EventHandler(this.btnNoteMovePrev_Click);
            // 
            // btnNoteMoveNex
            // 
            this.btnNoteMoveNex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNoteMoveNex.Image = ((System.Drawing.Image)(resources.GetObject("btnNoteMoveNex.Image")));
            this.btnNoteMoveNex.Name = "btnNoteMoveNex";
            this.btnNoteMoveNex.RightToLeftAutoMirrorImage = true;
            this.btnNoteMoveNex.Size = new System.Drawing.Size(23, 31);
            this.btnNoteMoveNex.Text = "Move next";
            this.btnNoteMoveNex.Click += new System.EventHandler(this.btnNoteMoveNex_Click);
            // 
            // btnNoteMoveLast
            // 
            this.btnNoteMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNoteMoveLast.Image = ((System.Drawing.Image)(resources.GetObject("btnNoteMoveLast.Image")));
            this.btnNoteMoveLast.Name = "btnNoteMoveLast";
            this.btnNoteMoveLast.RightToLeftAutoMirrorImage = true;
            this.btnNoteMoveLast.Size = new System.Drawing.Size(23, 31);
            this.btnNoteMoveLast.Text = "Move last";
            this.btnNoteMoveLast.Click += new System.EventHandler(this.btnNoteMoveLast_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddNew.Image = global::English_word.Properties.Resources.Untitled_438;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.RightToLeftAutoMirrorImage = true;
            this.btnAddNew.Size = new System.Drawing.Size(23, 31);
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveData.Image = global::English_word.Properties.Resources.save;
            this.btnSaveData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(23, 31);
            this.btnSaveData.Text = "toolStripButton2";
            this.btnSaveData.ToolTipText = "Save date Ctrl+Alt+P";
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(23, 31);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreviousPage.Image = global::English_word.Properties.Resources.Untitled_631;
            this.btnPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(23, 31);
            this.btnPreviousPage.Text = "toolStripButton5";
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextPage.Image = global::English_word.Properties.Resources.Untitled_70;
            this.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(23, 31);
            this.btnNextPage.Text = "toolStripButton6";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::English_word.Properties.Resources.Pic;
            this.button1.Location = new System.Drawing.Point(282, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 44);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbNotes
            // 
            this.pbNotes.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbNotes.InitialImage")));
            this.pbNotes.Location = new System.Drawing.Point(16, 21);
            this.pbNotes.Name = "pbNotes";
            this.pbNotes.Size = new System.Drawing.Size(457, 201);
            this.pbNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes.TabIndex = 35;
            this.pbNotes.TabStop = false;
            this.pbNotes.Click += new System.EventHandler(this.pbNotes_Click);
            this.pbNotes.DoubleClick += new System.EventHandler(this.pbNotes_DoubleClick);
            // 
            // New_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 496);
            this.Controls.Add(label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.txtNoteSearch);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.TCNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_note";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.New_note_Load);
            this.TCNote.ResumeLayout(false);
            this.tpNote.ResumeLayout(false);
            this.tpNote.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tpNotePic.ResumeLayout(false);
            this.tpNotePic.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TCNote;
        private System.Windows.Forms.TabPage tpNote;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RichTextBox rtxtNoteMore;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox rtxtNote;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNoteID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpNote;
        private System.Windows.Forms.RichTextBox txtNoteSubject;
        private System.Windows.Forms.TabPage tpNotePic;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox rtxtNotePicCom;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.PictureBox pbNotes;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox txtNoteSearch;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnNoteMoveFirst;
        private System.Windows.Forms.ToolStripButton btnNoteMovePrev;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox txtNotePosition;
        private System.Windows.Forms.ToolStripLabel lblNotesTotalItems;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnNoteMoveNex;
        private System.Windows.Forms.ToolStripButton btnNoteMoveLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        public System.Windows.Forms.ToolStripButton btnAddNew;
        public System.Windows.Forms.ToolStripButton btnSaveData;
        public System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnPreviousPage;
        private System.Windows.Forms.ToolStripButton btnNextPage;
        internal System.Windows.Forms.Button button2;
    }
}