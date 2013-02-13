namespace CDCatalog
{
    partial class frmCDCatalog
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
            this.components = new System.ComponentModel.Container();
            this.grpSongAdd = new System.Windows.Forms.GroupBox();
            this.numAlbumRating = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAlbum = new System.Windows.Forms.ListBox();
            this.chkAlbum = new System.Windows.Forms.CheckBox();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.numTrack = new System.Windows.Forms.NumericUpDown();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.cmbArtist = new System.Windows.Forms.ComboBox();
            this.artistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDCatalogDataSet1 = new CDCatalog.CDCatalogDataSet1();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.genreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cDCatalogDataSet = new CDCatalog.CDCatalogDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSongAlbumToDB = new System.Windows.Forms.Button();
            this.btnAddSongToAlbum = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.genreTableAdapter = new CDCatalog.CDCatalogDataSetTableAdapters.GenreTableAdapter();
            this.artistTableAdapter = new CDCatalog.CDCatalogDataSet1TableAdapters.ArtistTableAdapter();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpSongAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlbumRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSongAdd
            // 
            this.grpSongAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpSongAdd.Controls.Add(this.numAlbumRating);
            this.grpSongAdd.Controls.Add(this.label9);
            this.grpSongAdd.Controls.Add(this.txtYear);
            this.grpSongAdd.Controls.Add(this.label1);
            this.grpSongAdd.Controls.Add(this.lstAlbum);
            this.grpSongAdd.Controls.Add(this.chkAlbum);
            this.grpSongAdd.Controls.Add(this.numRating);
            this.grpSongAdd.Controls.Add(this.txtLength);
            this.grpSongAdd.Controls.Add(this.numTrack);
            this.grpSongAdd.Controls.Add(this.txtAlbum);
            this.grpSongAdd.Controls.Add(this.txtSongTitle);
            this.grpSongAdd.Controls.Add(this.cmbArtist);
            this.grpSongAdd.Controls.Add(this.cmbGenre);
            this.grpSongAdd.Controls.Add(this.label8);
            this.grpSongAdd.Controls.Add(this.label7);
            this.grpSongAdd.Controls.Add(this.label6);
            this.grpSongAdd.Controls.Add(this.label5);
            this.grpSongAdd.Controls.Add(this.label4);
            this.grpSongAdd.Controls.Add(this.label3);
            this.grpSongAdd.Controls.Add(this.label2);
            this.grpSongAdd.Controls.Add(this.btnAddSongAlbumToDB);
            this.grpSongAdd.Controls.Add(this.btnAddSongToAlbum);
            this.grpSongAdd.Location = new System.Drawing.Point(12, 12);
            this.grpSongAdd.Name = "grpSongAdd";
            this.grpSongAdd.Size = new System.Drawing.Size(205, 328);
            this.grpSongAdd.TabIndex = 0;
            this.grpSongAdd.TabStop = false;
            this.grpSongAdd.Text = "Add New Song or CD";
            // 
            // numAlbumRating
            // 
            this.numAlbumRating.Location = new System.Drawing.Point(476, 34);
            this.numAlbumRating.Name = "numAlbumRating";
            this.numAlbumRating.Size = new System.Drawing.Size(74, 20);
            this.numAlbumRating.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(460, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Album Rating";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(375, 33);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(65, 20);
            this.txtYear.TabIndex = 19;
            this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtYear_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Album Year";
            // 
            // lstAlbum
            // 
            this.lstAlbum.DisplayMember = "Song.Title";
            this.lstAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAlbum.FormattingEnabled = true;
            this.lstAlbum.ItemHeight = 24;
            this.lstAlbum.Location = new System.Drawing.Point(237, 59);
            this.lstAlbum.Name = "lstAlbum";
            this.lstAlbum.Size = new System.Drawing.Size(330, 196);
            this.lstAlbum.TabIndex = 15;
            // 
            // chkAlbum
            // 
            this.chkAlbum.AutoSize = true;
            this.chkAlbum.Location = new System.Drawing.Point(8, 31);
            this.chkAlbum.Name = "chkAlbum";
            this.chkAlbum.Size = new System.Drawing.Size(123, 17);
            this.chkAlbum.TabIndex = 14;
            this.chkAlbum.Text = "Check to Add Album";
            this.chkAlbum.UseVisualStyleBackColor = true;
            this.chkAlbum.CheckedChanged += new System.EventHandler(this.chkAlbum_CheckedChanged);
            // 
            // numRating
            // 
            this.numRating.Location = new System.Drawing.Point(64, 228);
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(120, 20);
            this.numRating.TabIndex = 13;
            this.numRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Validating += new System.ComponentModel.CancelEventHandler(this.numRating_Validating);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(64, 195);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(120, 20);
            this.txtLength.TabIndex = 12;
            this.txtLength.Text = "0";
            // 
            // numTrack
            // 
            this.numTrack.Location = new System.Drawing.Point(64, 129);
            this.numTrack.Name = "numTrack";
            this.numTrack.Size = new System.Drawing.Size(120, 20);
            this.numTrack.TabIndex = 11;
            this.numTrack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(237, 33);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(110, 20);
            this.txtAlbum.TabIndex = 10;
            this.txtAlbum.Visible = false;
            this.txtAlbum.Validating += new System.ComponentModel.CancelEventHandler(this.txtAlbum_Validating);
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Location = new System.Drawing.Point(61, 66);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(121, 20);
            this.txtSongTitle.TabIndex = 9;
            // 
            // cmbArtist
            // 
            this.cmbArtist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbArtist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArtist.DataSource = this.artistBindingSource;
            this.cmbArtist.DisplayMember = "Artist";
            this.cmbArtist.FormattingEnabled = true;
            this.cmbArtist.Location = new System.Drawing.Point(61, 96);
            this.cmbArtist.Name = "cmbArtist";
            this.cmbArtist.Size = new System.Drawing.Size(121, 21);
            this.cmbArtist.TabIndex = 8;
            this.cmbArtist.Validating += new System.ComponentModel.CancelEventHandler(this.cmbArtist_Validating);
            // 
            // artistBindingSource
            // 
            this.artistBindingSource.DataMember = "Artist";
            this.artistBindingSource.DataSource = this.cDCatalogDataSet1;
            // 
            // cDCatalogDataSet1
            // 
            this.cDCatalogDataSet1.DataSetName = "CDCatalogDataSet1";
            this.cDCatalogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbGenre
            // 
            this.cmbGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGenre.DataSource = this.genreBindingSource1;
            this.cmbGenre.DisplayMember = "Genre";
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(63, 159);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(121, 21);
            this.cmbGenre.TabIndex = 7;
            this.cmbGenre.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGenre_Validating);
            // 
            // genreBindingSource1
            // 
            this.genreBindingSource1.DataMember = "Genre";
            this.genreBindingSource1.DataSource = this.cDCatalogDataSet;
            // 
            // cDCatalogDataSet
            // 
            this.cDCatalogDataSet.DataSetName = "CDCatalogDataSet";
            this.cDCatalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Rating:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Length (s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Track #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Album Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Artist: ";
            // 
            // btnAddSongAlbumToDB
            // 
            this.btnAddSongAlbumToDB.Location = new System.Drawing.Point(64, 290);
            this.btnAddSongAlbumToDB.Name = "btnAddSongAlbumToDB";
            this.btnAddSongAlbumToDB.Size = new System.Drawing.Size(120, 23);
            this.btnAddSongAlbumToDB.TabIndex = 16;
            this.btnAddSongAlbumToDB.Text = "Add Song to Catalog";
            this.btnAddSongAlbumToDB.UseVisualStyleBackColor = true;
            this.btnAddSongAlbumToDB.Click += new System.EventHandler(this.btnAddSongAlbumToDB_Click);
            // 
            // btnAddSongToAlbum
            // 
            this.btnAddSongToAlbum.Location = new System.Drawing.Point(64, 261);
            this.btnAddSongToAlbum.Name = "btnAddSongToAlbum";
            this.btnAddSongToAlbum.Size = new System.Drawing.Size(120, 23);
            this.btnAddSongToAlbum.TabIndex = 17;
            this.btnAddSongToAlbum.Text = "Add Song to Album";
            this.btnAddSongToAlbum.UseVisualStyleBackColor = true;
            this.btnAddSongToAlbum.Visible = false;
            this.btnAddSongToAlbum.Click += new System.EventHandler(this.btnAddSongToAlbum_Click);
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // artistTableAdapter
            // 
            this.artistTableAdapter.ClearBeforeFill = true;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(CDCatalog.Genre);
            // 
            // frmCDCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 603);
            this.Controls.Add(this.grpSongAdd);
            this.Name = "frmCDCatalog";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCDCatalog_Load);
            this.grpSongAdd.ResumeLayout(false);
            this.grpSongAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlbumRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDCatalogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSongAdd;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTrack;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.ComboBox cmbArtist;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnAddSongAlbumToDB;
        private System.Windows.Forms.ListBox lstAlbum;
        private System.Windows.Forms.CheckBox chkAlbum;
        private System.Windows.Forms.Button btnAddSongToAlbum;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private CDCatalogDataSet cDCatalogDataSet;
        private System.Windows.Forms.BindingSource genreBindingSource1;
        private CDCatalogDataSetTableAdapters.GenreTableAdapter genreTableAdapter;
        private CDCatalogDataSet1 cDCatalogDataSet1;
        private System.Windows.Forms.BindingSource artistBindingSource;
        private CDCatalogDataSet1TableAdapters.ArtistTableAdapter artistTableAdapter;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAlbumRating;
        private System.Windows.Forms.Label label9;
    }
}

