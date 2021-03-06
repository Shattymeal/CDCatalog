﻿namespace CDCatalog
{
    partial class formCDCatalog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAlbumTitle = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAlbumRating = new System.Windows.Forms.TextBox();
            this.cmbAlbumGenre = new System.Windows.Forms.ComboBox();
            this.txtAlbumYear = new System.Windows.Forms.TextBox();
            this.txtTrackNumber = new System.Windows.Forms.TextBox();
            this.txtSongRating = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.cmbSongGenre = new System.Windows.Forms.ComboBox();
            this.cmbArtist = new System.Windows.Forms.ComboBox();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkAlbum = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPlayList = new System.Windows.Forms.ListBox();
            this.btnPlayList = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.cmbChoice = new System.Windows.Forms.ComboBox();
            this.lstSearch = new System.Windows.Forms.ListBox();
            this.cmbLowRating = new System.Windows.Forms.ComboBox();
            this.cmbHighRating = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkRating = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radSong = new System.Windows.Forms.RadioButton();
            this.radAlbum = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.cmbAlbumTitle);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtAlbumRating);
            this.groupBox1.Controls.Add(this.cmbAlbumGenre);
            this.groupBox1.Controls.Add(this.txtAlbumYear);
            this.groupBox1.Controls.Add(this.txtTrackNumber);
            this.groupBox1.Controls.Add(this.txtSongRating);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Controls.Add(this.cmbSongGenre);
            this.groupBox1.Controls.Add(this.cmbArtist);
            this.groupBox1.Controls.Add(this.txtSongTitle);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chkAlbum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Song / Album";
            // 
            // cmbAlbumTitle
            // 
            this.cmbAlbumTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAlbumTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlbumTitle.DisplayMember = "Title";
            this.cmbAlbumTitle.FormattingEnabled = true;
            this.cmbAlbumTitle.Location = new System.Drawing.Point(118, 264);
            this.cmbAlbumTitle.Name = "cmbAlbumTitle";
            this.cmbAlbumTitle.Size = new System.Drawing.Size(121, 24);
            this.cmbAlbumTitle.TabIndex = 23;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(72, 432);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 29);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Add To Catalog";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAlbumRating
            // 
            this.txtAlbumRating.Location = new System.Drawing.Point(118, 385);
            this.txtAlbumRating.Name = "txtAlbumRating";
            this.txtAlbumRating.Size = new System.Drawing.Size(100, 22);
            this.txtAlbumRating.TabIndex = 21;
            // 
            // cmbAlbumGenre
            // 
            this.cmbAlbumGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAlbumGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlbumGenre.DisplayMember = "Genre1";
            this.cmbAlbumGenre.FormattingEnabled = true;
            this.cmbAlbumGenre.Location = new System.Drawing.Point(118, 354);
            this.cmbAlbumGenre.Name = "cmbAlbumGenre";
            this.cmbAlbumGenre.Size = new System.Drawing.Size(121, 24);
            this.cmbAlbumGenre.TabIndex = 20;
            // 
            // txtAlbumYear
            // 
            this.txtAlbumYear.Location = new System.Drawing.Point(118, 325);
            this.txtAlbumYear.Name = "txtAlbumYear";
            this.txtAlbumYear.Size = new System.Drawing.Size(100, 22);
            this.txtAlbumYear.TabIndex = 19;
            // 
            // txtTrackNumber
            // 
            this.txtTrackNumber.Location = new System.Drawing.Point(118, 296);
            this.txtTrackNumber.Name = "txtTrackNumber";
            this.txtTrackNumber.Size = new System.Drawing.Size(100, 22);
            this.txtTrackNumber.TabIndex = 18;
            this.txtTrackNumber.Text = "1";
            // 
            // txtSongRating
            // 
            this.txtSongRating.Location = new System.Drawing.Point(119, 165);
            this.txtSongRating.Name = "txtSongRating";
            this.txtSongRating.Size = new System.Drawing.Size(100, 22);
            this.txtSongRating.TabIndex = 16;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(118, 130);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 15;
            // 
            // cmbSongGenre
            // 
            this.cmbSongGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSongGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSongGenre.DisplayMember = "Genre1";
            this.cmbSongGenre.FormattingEnabled = true;
            this.cmbSongGenre.Location = new System.Drawing.Point(118, 97);
            this.cmbSongGenre.Name = "cmbSongGenre";
            this.cmbSongGenre.Size = new System.Drawing.Size(121, 24);
            this.cmbSongGenre.TabIndex = 14;
            // 
            // cmbArtist
            // 
            this.cmbArtist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbArtist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArtist.DisplayMember = "Artist1";
            this.cmbArtist.FormattingEnabled = true;
            this.cmbArtist.Location = new System.Drawing.Point(118, 63);
            this.cmbArtist.Name = "cmbArtist";
            this.cmbArtist.Size = new System.Drawing.Size(124, 24);
            this.cmbArtist.TabIndex = 13;
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Location = new System.Drawing.Point(118, 30);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(100, 22);
            this.txtSongTitle.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Album Rating:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Album Genre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Album Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Album Title:";
            // 
            // chkAlbum
            // 
            this.chkAlbum.AutoSize = true;
            this.chkAlbum.Checked = true;
            this.chkAlbum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlbum.Location = new System.Drawing.Point(16, 236);
            this.chkAlbum.Name = "chkAlbum";
            this.chkAlbum.Size = new System.Drawing.Size(127, 21);
            this.chkAlbum.TabIndex = 7;
            this.chkAlbum.Text = "Part of Album? ";
            this.chkAlbum.UseVisualStyleBackColor = true;
            this.chkAlbum.CheckedChanged += new System.EventHandler(this.chkAlbum_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rating:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Length (s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Track #:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Song Title:";
            // 
            // lstPlayList
            // 
            this.lstPlayList.DisplayMember = "Title";
            this.lstPlayList.FormattingEnabled = true;
            this.lstPlayList.ItemHeight = 16;
            this.lstPlayList.Location = new System.Drawing.Point(33, 39);
            this.lstPlayList.MultiColumn = true;
            this.lstPlayList.Name = "lstPlayList";
            this.lstPlayList.Size = new System.Drawing.Size(238, 372);
            this.lstPlayList.TabIndex = 1;
            // 
            // btnPlayList
            // 
            this.btnPlayList.Location = new System.Drawing.Point(96, 432);
            this.btnPlayList.Name = "btnPlayList";
            this.btnPlayList.Size = new System.Drawing.Size(126, 29);
            this.btnPlayList.TabIndex = 2;
            this.btnPlayList.Text = "Create Playlist";
            this.btnPlayList.UseVisualStyleBackColor = true;
            this.btnPlayList.Click += new System.EventHandler(this.btnPlayList_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "All"});
            this.cmbFilter.Location = new System.Drawing.Point(77, 387);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbFilter.TabIndex = 3;
            this.cmbFilter.Text = "All";
            // 
            // cmbChoice
            // 
            this.cmbChoice.FormattingEnabled = true;
            this.cmbChoice.Location = new System.Drawing.Point(6, 386);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(65, 24);
            this.cmbChoice.TabIndex = 4;
            this.cmbChoice.SelectedIndexChanged += new System.EventHandler(this.cmbChoice_SelectedIndexChanged);
            // 
            // lstSearch
            // 
            this.lstSearch.DisplayMember = "Title";
            this.lstSearch.FormattingEnabled = true;
            this.lstSearch.ItemHeight = 16;
            this.lstSearch.Location = new System.Drawing.Point(50, 47);
            this.lstSearch.Name = "lstSearch";
            this.lstSearch.Size = new System.Drawing.Size(226, 308);
            this.lstSearch.TabIndex = 5;
            // 
            // cmbLowRating
            // 
            this.cmbLowRating.FormattingEnabled = true;
            this.cmbLowRating.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbLowRating.Location = new System.Drawing.Point(204, 386);
            this.cmbLowRating.Name = "cmbLowRating";
            this.cmbLowRating.Size = new System.Drawing.Size(46, 24);
            this.cmbLowRating.TabIndex = 6;
            // 
            // cmbHighRating
            // 
            this.cmbHighRating.FormattingEnabled = true;
            this.cmbHighRating.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbHighRating.Location = new System.Drawing.Point(261, 386);
            this.cmbHighRating.Name = "cmbHighRating";
            this.cmbHighRating.Size = new System.Drawing.Size(46, 24);
            this.cmbHighRating.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(86, 432);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(164, 29);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Find Songs by Title";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkRating
            // 
            this.chkRating.AutoSize = true;
            this.chkRating.Checked = true;
            this.chkRating.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRating.Location = new System.Drawing.Point(190, 360);
            this.chkRating.Name = "chkRating";
            this.chkRating.Size = new System.Drawing.Size(133, 21);
            this.chkRating.TabIndex = 9;
            this.chkRating.Text = "Filter by Rating?";
            this.chkRating.UseVisualStyleBackColor = true;
            this.chkRating.CheckedChanged += new System.EventHandler(this.chkRating_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Fuchsia;
            this.groupBox2.Controls.Add(this.radAlbum);
            this.groupBox2.Controls.Add(this.radSong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lstSearch);
            this.groupBox2.Controls.Add(this.chkRating);
            this.groupBox2.Controls.Add(this.cmbFilter);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.cmbChoice);
            this.groupBox2.Controls.Add(this.cmbHighRating);
            this.groupBox2.Controls.Add(this.cmbLowRating);
            this.groupBox2.Location = new System.Drawing.Point(292, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 474);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Song / Album Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search: ";
            // 
            // radSong
            // 
            this.radSong.AutoSize = true;
            this.radSong.Location = new System.Drawing.Point(104, 21);
            this.radSong.Name = "radSong";
            this.radSong.Size = new System.Drawing.Size(62, 21);
            this.radSong.TabIndex = 11;
            this.radSong.TabStop = true;
            this.radSong.Text = "Song";
            this.radSong.UseVisualStyleBackColor = true;
            this.radSong.CheckedChanged += new System.EventHandler(this.radSong_CheckedChanged);
            // 
            // radAlbum
            // 
            this.radAlbum.AutoSize = true;
            this.radAlbum.Location = new System.Drawing.Point(173, 21);
            this.radAlbum.Name = "radAlbum";
            this.radAlbum.Size = new System.Drawing.Size(68, 21);
            this.radAlbum.TabIndex = 12;
            this.radAlbum.TabStop = true;
            this.radAlbum.Text = "Album";
            this.radAlbum.UseVisualStyleBackColor = true;
            this.radAlbum.CheckedChanged += new System.EventHandler(this.radAlbum_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox3.Controls.Add(this.lstPlayList);
            this.groupBox3.Controls.Add(this.btnPlayList);
            this.groupBox3.Location = new System.Drawing.Point(648, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 472);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Random Playlist";
            // 
            // formCDCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 497);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formCDCatalog";
            this.Text = "formCDCatalog";
            this.Load += new System.EventHandler(this.formCDCatalog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkAlbum;
        private System.Windows.Forms.ComboBox cmbSongGenre;
        private System.Windows.Forms.ComboBox cmbArtist;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAlbumRating;
        private System.Windows.Forms.ComboBox cmbAlbumGenre;
        private System.Windows.Forms.TextBox txtAlbumYear;
        private System.Windows.Forms.TextBox txtTrackNumber;
        private System.Windows.Forms.TextBox txtSongRating;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbAlbumTitle;
        private System.Windows.Forms.ListBox lstPlayList;
        private System.Windows.Forms.Button btnPlayList;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ComboBox cmbChoice;
        private System.Windows.Forms.ListBox lstSearch;
        private System.Windows.Forms.ComboBox cmbLowRating;
        private System.Windows.Forms.ComboBox cmbHighRating;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkRating;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radAlbum;
        private System.Windows.Forms.RadioButton radSong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}