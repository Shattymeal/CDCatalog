﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDCatalogConnection;
using System.Windows.Forms;

namespace CDCatalog
{
    public partial class formCDCatalog : Form
    {
        int trackNumber = 1;

        public formCDCatalog()
        {
            InitializeComponent();
        }

        public void addAlbumToDB(string albumTitle, string albumArtist, int albumYear, string albumGenre, int albumRating)
        {
            Album newAlbum = new Album();
            int ID = newAlbum.AlbumCheck(albumTitle, albumArtist, albumYear, albumGenre, albumRating);
            MessageBox.Show("The Following Album " + cmbAlbumTitle.Text + " was added with ID " + ID);
        }

        public void addSongToDB(string songTitle, string songArtist, string songAlbum, string songGenre, int songTrackNumber, int songTrackLength, int songRating)
        {
            Songs newSong = new Songs();
            int ID = newSong.SongCheck(songTitle, songArtist, songAlbum, songGenre, songTrackNumber, songTrackLength, songRating);
            MessageBox.Show("The Following Song " + txtSongTitle.Text + " was added with ID " + ID);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region Member Variables
            int songTrackLength;
            int songRating;
            int albumRating;
            int year;
            #endregion

            #region Validating Blocks
            if (!(int.TryParse(txtYear.Text, out year)))
            {
                MessageBox.Show("The Year " + txtYear.Text + " was not a valid, please try again");
                return;
            }

            if(!(int.TryParse(txtLength.Text, out songTrackLength)))
            {
                MessageBox.Show("The Length " + txtLength.Text + " was not valid, please try again");
                return;
            }

            int.TryParse(txtSongRating.Text, out songRating);
            if(songRating < 0 || songRating >= 5)
            {
                MessageBox.Show("The song rating of " + txtSongRating.Text + " was not valid or out of range, please try again");
                return;
            }

            int.TryParse(txtAlbumRating.Text, out albumRating);
            if (albumRating < 0 || songRating >= 5)
            {
                MessageBox.Show("The album rating of " + txtAlbumRating.Text + " was not valid or out of range, please try again");
                return;
            }

            if (!(int.TryParse(txtTrackNumber.Text, out trackNumber)))
            {
                MessageBox.Show("The track number of " + txtTrackNumber.Text + " is not valid, please try again");
                return;
            }

            #endregion 

            if (chkAlbum.Checked)
            {
                addAlbumToDB(cmbAlbumTitle.Text, cmbArtist.Text, year, cmbAlbumGenre.Text, albumRating);
            }

            addSongToDB(txtSongTitle.Text, cmbArtist.Text, cmbAlbumTitle.Text, cmbSongGenre.Text, trackNumber, songTrackLength, songRating);

            if(chkAlbum.Checked)
                trackNumber++;

            txtTrackNumber.Text = trackNumber.ToString();
            initialLoad();


            MessageBox.Show("Your song has been successfully added");
        }

        private void chkAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlbum.Checked == false)
            {
                cmbAlbumTitle.Enabled = false;
                txtTrackNumber.Enabled = false;
                txtTrackNumber.Text = trackNumber.ToString();
                txtYear.Enabled = false;
                cmbAlbumGenre.Enabled = false;
                txtAlbumRating.Enabled = false;
            }
            else if(chkAlbum.Checked)
            {
                cmbAlbumTitle.Enabled = true;
                txtTrackNumber.Enabled = true;
                txtTrackNumber.Text = trackNumber.ToString();
                txtYear.Enabled = true;
                cmbAlbumGenre.Enabled = true;
                txtAlbumRating.Enabled = true;
            }
        }

        private void formCDCatalog_Load(object sender, EventArgs e)
        {
            initialLoad();
            cmbLowRating.SelectedIndex = 0;
            cmbAlbumLowRating.SelectedIndex = 0;
            cmbHighRating.SelectedIndex = 5;
            cmbAlbumHighRating.SelectedIndex = 5;
            fillComboSwitch(ref cmbChoiceList, ref cmbChoice, true);
        }

        private void initialLoad()
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                loadComboBox<Artist>(ref cmbArtist, context.Artists.ToList());
                loadComboBox<Genre>(ref cmbSongGenre, context.Genres.ToList());
                loadComboBox<Genre>(ref cmbAlbumGenre, context.Genres.ToList());
                loadComboBox<Album>(ref cmbAlbumTitle, context.Albums.ToList());
            }
        }

        private void loadComboBox<T>(ref ComboBox cmb, List<T> list, bool allFlag = false)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                cmb.Items.Clear();
                if (allFlag)
                    cmb.Items.Add("All");

                foreach (T i in list)
                {
                    cmb.Items.Add(i);
                }
            }
        }

        private void loadListBox<T>(ref ListBox lst, List<T> list, bool rating = false)
        {
            lst.Items.Clear();

            foreach (T i in list)
            {
                lst.Items.Add(i);
            }
        }

        private void btnPlayList_Click(object sender, EventArgs e)
        {
            lstPlayList.Items.Clear();
            RandomPlayList pl = new RandomPlayList();
            
            while (pl.playList.Count > 0)
            {
                Songs songToAdd = pl.playList.Pop();
                int minutes = songToAdd.TrackLength / 60;
                int seconds = songToAdd.TrackLength - 60 * minutes;
                
                lstPlayList.Items.Add(songToAdd.Title + " " + minutes + ":" + seconds);
            }

            int totalMinutes = pl.playtime.Sum() / 60;
            int totalSeconds = pl.playtime.Sum() - 60 * totalMinutes;

            lstPlayList.Items.Add("Total Time: " + totalMinutes + ":" + totalSeconds);
        }

        private void cmbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool allFlag = false;
            if(cmbChoice.Text == "Song")
                allFlag = true;

            fillComboSwitch(ref cmbChoiceList, ref cmbChoice, allFlag);

            switch (cmbChoice.Text)
            {
                case "Song":
                btnSearch.Text = "Find Songs by Title";
                    break;
                case "Artist":
                btnSearch.Text = "Find Songs by Artist";
                    break;
                case "Album":
                btnSearch.Text = "Find Songs by Album";
                    break;
                case "Genre":
                btnSearch.Text = "Find Songs by Genre";
                    break;
                default:
                    break;
            }

        }

        private void chkRating_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRating.Checked)
            {
                cmbLowRating.Enabled = true;
                cmbHighRating.Enabled = true;
            }
            else if (chkRating.Checked == false)
            {
                cmbLowRating.Enabled = false;
                cmbHighRating.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = 0;

            using(CDCatalogEntities context = new CDCatalogEntities())
            {
            switch(cmbChoice.Text)
            {
                    case "Song":
                    if (cmbChoiceList.Text == "All")
                        loadListBox<Songs>(ref lstSongSearch, context.Songs1.ToList());
                    else
                        loadListBox<Songs>(ref lstSongSearch, context.Songs1.Where(s => s.Title == cmbChoiceList.Text).ToList());
                        break;
                    case "Artist":
                        id = new Artist().ArtistCheck(cmbChoiceList.Text);
                        loadListBox<Songs>(ref lstSongSearch, context.Songs1.Where(s => s.ArtistID == id).ToList());
                        break;
                    case"Album":
                        id = new Album().AlbumCheck(cmbChoiceList.Text);
                        loadListBox<Songs>(ref lstSongSearch, context.Songs1.Where(s => s.AlbumID == id).ToList());
                        break;
                    case "Genre":
                        id = new Genre().GenreCheck(cmbChoiceList.Text);
                        loadListBox<Songs>(ref lstSongSearch, context.Songs1.Where(s => s.GenreID == id).ToList());
                        break;
                    default:
                        break;
                }
            }
        }

        private void fillComboSwitch(ref ComboBox cmbList, ref ComboBox cmbChoice, bool allFlag = false)
        {
            cmbList.Items.Clear();
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                switch (cmbChoice.Text)
                {
                    case "Song":
                        loadComboBox<Songs>(ref cmbList, context.Songs1.ToList(), allFlag);
                        cmbList.DisplayMember = "Title";
                        break;
                    case "Artist":
                        loadComboBox<Artist>(ref cmbList, context.Artists.ToList(), allFlag);
                        cmbList.DisplayMember = "Artist1";
                        break;
                    case "Album":
                        loadComboBox<Album>(ref cmbList, context.Albums.ToList(), allFlag);
                        cmbList.DisplayMember = "Title";
                        break;
                    case "Genre":
                        loadComboBox<Genre>(ref cmbList, context.Genres.ToList(), allFlag);
                        cmbList.DisplayMember = "Genre1";
                        break;
                    default:
                        break;
                }
            }

            cmbList.SelectedIndex = 0;
        }

        private void cmbAlbumSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool allFlag = false;
            if (cmbAlbumSearch.Text == "Album")
                allFlag = true;

            fillComboSwitch(ref cmbAlbumChoice, ref cmbAlbumSearch, allFlag);

            switch (cmbAlbumSearch.Text)
            {
                case "Artist":
                    if (cmbAlbumChoice.Text == "All")
                        btnAlbumSearch.Text = "Find Albums by Rating";
                    else
                        btnAlbumSearch.Text = "Find Albums by Artist";
                    break;
                case "Album":
                    btnAlbumSearch.Text = "Find Albums by Album";
                    break;
                case "Genre":
                    btnAlbumSearch.Text = "Find Albums by Genre";
                    break;
                default:
                    break;
            }
        }

        private void chkAlbumRating_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlbumRating.Checked)
            {
                cmbAlbumHighRating.Enabled = true;
                cmbAlbumLowRating.Enabled = true;
            }
            else if(chkAlbumRating.Checked == false)
            {
                cmbAlbumHighRating.Enabled = false;
                cmbAlbumLowRating.Enabled = false;
            }
        }

        private void btnAlbumSearch_Click(object sender, EventArgs e)
        {
            using(CDCatalogEntities context = new CDCatalogEntities())
            {
                int id = 0;
                switch (cmbAlbumSearch.Text)
                {
                    case "Album":
                        loadListBox<Album>(ref lstAlbumSearch, context.Albums.Where(al => al.Title == cmbAlbumChoice.Text).ToList());
                        break;
                    case "Artist":
                        id = new Artist().ArtistCheck(cmbAlbumChoice.Text);
                        loadListBox<Album>(ref lstAlbumSearch, context.Albums.Where(al => al.ArtistID == id).ToList());
                        break;
                    case "Genre":
                        id = new Genre().GenreCheck(cmbAlbumChoice.Text);
                        loadListBox<Album>(ref lstAlbumSearch, context.Albums.Where(al => al.GenreID == id).ToList());
                        break;
                    default:
                        break;
                }
            }
        }


    }
}
