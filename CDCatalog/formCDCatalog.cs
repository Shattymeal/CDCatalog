using System;
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
        #region Constructor, Form Variables, and Load Event

        int trackNumber = 1;

        public formCDCatalog()
        {
            InitializeComponent();
        }

        private void formCDCatalog_Load(object sender, EventArgs e)
        {
            initialLoad();
        }

        #endregion

        #region Combobox and Radio Button Events

        private void cmbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radSong.Checked)
            {
                cmbFilter.Items.Clear();
                bool allFlag = false;
                if (cmbChoice.Text == "Song")
                    allFlag = true;

                fillComboSwitch(ref cmbFilter, ref cmbChoice, allFlag);
                SongSearchFormChange();
            }
            else if (radAlbum.Checked)
            {
                cmbFilter.Items.Clear();
                bool allFlag = false;
                if (cmbChoice.Text == "Album")
                    allFlag = true;

                fillComboSwitch(ref cmbFilter, ref cmbChoice, allFlag);
                AlbumSearchFormChange();
            }

        }

        private void radSong_CheckedChanged(object sender, EventArgs e)
        {
            cmbLowRating.SelectedIndex = 0;
            cmbHighRating.SelectedIndex = 5;

            if (radSong.Checked)
            {
                List<string> choices = new List<string> { "Song", "Artist", "Album", "Genre" };
                loadComboBox<string>(ref cmbChoice, choices, false);
                cmbChoice.SelectedIndex = 0;
                SongSearchFormChange();
            }

        }

        private void radAlbum_CheckedChanged(object sender, EventArgs e)
        {
            cmbLowRating.SelectedIndex = 0;
            cmbHighRating.SelectedIndex = 5;

            if (radAlbum.Checked)
            {
                List<string> choices = new List<string> { "Album", "Artist", "Genre" };
                loadComboBox<string>(ref cmbChoice, choices, false);
                cmbChoice.SelectedIndex = 0;
                AlbumSearchFormChange();
            }
        }

        #endregion

        #region Checkbox Events

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
            else if (chkAlbum.Checked)
            {
                cmbAlbumTitle.Enabled = true;
                txtTrackNumber.Enabled = true;
                txtTrackNumber.Text = trackNumber.ToString();
                txtYear.Enabled = true;
                cmbAlbumGenre.Enabled = true;
                txtAlbumRating.Enabled = true;
            }
        }

        #endregion

        #region Code for Buttons

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

            if (!(int.TryParse(txtLength.Text, out songTrackLength)))
            {
                MessageBox.Show("The Length " + txtLength.Text + " was not valid, please try again");
                return;
            }

            int.TryParse(txtSongRating.Text, out songRating);
            if (songRating < 0 || songRating >= 5)
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

            if (chkAlbum.Checked)
                trackNumber++;

            txtTrackNumber.Text = trackNumber.ToString();
            initialLoad();

            MessageBox.Show("Your song has been successfully added");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radSong.Checked)
            {
                List<Songs> songList = new Songs().Search(cmbChoice.Text, cmbFilter.Text, cmbLowRating.Text, cmbHighRating.Text, chkRating.Checked);
                loadListBox<Songs>(ref lstSearch, songList);
            }
            else if (radAlbum.Checked)
            {
                List<Album> albumList = new Album().Search(cmbChoice.Text, cmbFilter.Text, cmbLowRating.Text, cmbHighRating.Text, chkRating.Checked);
                loadListBox<Album>(ref lstSearch, albumList);
            }
        }

        private void btnPlayList_Click(object sender, EventArgs e)
        {
            RandomPlaylist();
        }

        #endregion

        #region Form Methods

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

        private void loadListBox<T>(ref ListBox lst, List<T> list)
        {
            lst.Items.Clear();

            foreach (T i in list)
            {
                lst.Items.Add(i);
            }
        }

        private void fillComboSwitch(ref ComboBox cmbFilter, ref ComboBox cmbChoice, bool allFlag = false)
        {
            cmbFilter.Items.Clear();
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                switch (cmbChoice.Text)
                {
                    case "Song":
                        loadComboBox<Songs>(ref cmbFilter, context.Songs1.ToList(), allFlag);
                        cmbFilter.DisplayMember = "Title";
                        break;
                    case "Artist":
                        loadComboBox<Artist>(ref cmbFilter, context.Artists.ToList(), allFlag);
                        cmbFilter.DisplayMember = "Artist1";
                        break;
                    case "Album":
                        loadComboBox<Album>(ref cmbFilter, context.Albums.ToList(), allFlag);
                        cmbFilter.DisplayMember = "Title";
                        break;
                    case "Genre":
                        loadComboBox<Genre>(ref cmbFilter, context.Genres.ToList(), allFlag);
                        cmbFilter.DisplayMember = "Genre1";
                        break;
                    default:
                        break;
                }
            }

            cmbFilter.SelectedIndex = 0;
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

        private void RandomPlaylist()
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

        private void AlbumSearchFormChange()
        {

            switch (cmbChoice.Text)
            {
                case "Album":
                    if (cmbFilter.Text == "All")
                        btnSearch.Text = "Find Albums by Rating";
                    else
                        btnSearch.Text = "Find Albums by Title";
                    break;
                case "Artist":
                    btnSearch.Text = "Find Albums by Artist";
                    break;
                case "Genre":
                    btnSearch.Text = "Find Albums by Genre";
                    break;
                default:
                    break;
            }
        }

        private void SongSearchFormChange()
        {

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

        #endregion
    }
}
