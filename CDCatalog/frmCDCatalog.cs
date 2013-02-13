using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDCatalog
{
    public partial class frmCDCatalog : Form
    {
        public frmCDCatalog()
        {
            CDCatalogEntities entity = new CDCatalogEntities();
            InitializeComponent();
        }

        private void chkAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlbum.Checked)
            {
                
                chkAlbum.Text = "Uncheck to add single song";
                txtAlbum.Visible = true;
                lstAlbum.Visible = true;
                grpSongAdd.Size = new Size(598, 328);
                btnAddSongAlbumToDB.Text = "Add Album to Catalog";
                btnAddSongToAlbum.Visible = true;
            }
            else
            {
                chkAlbum.Text = "Check to Add Album";
                txtAlbum.Visible = false;
                lstAlbum.Visible = false;
                grpSongAdd.Size = new Size(215, 328);
                btnAddSongAlbumToDB.Text = "Add Song to Catalog";
                btnAddSongToAlbum.Visible = false;
            }
        }

        private void frmCDCatalog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDCatalogDataSet1.Artist' table. You can move, or remove it, as needed.
            this.artistTableAdapter.Fill(this.cDCatalogDataSet1.Artist);
            cmbArtist.SelectedIndex = 0;
            // TODO: This line of code loads data into the 'cDCatalogDataSet.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.cDCatalogDataSet.Genre);
            cmbGenre.SelectedIndex = 0;

        }

        private void btnAddSongAlbumToDB_Click(object sender, EventArgs e)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                if (!chkAlbum.Checked)
                {
                    Song song = CreateSong(txtSongTitle.Text, null, context.Artists.First(c => c.Artist1 == cmbArtist.Text), (int)numTrack.Value, context.Genres.First(c => c.Genre1 == cmbGenre.Text), int.Parse(txtLength.Text), (int)numRating.Value);
                    if (!context.Songs.Any(c => c.Title == song.Title))
                    {
                        context.Songs.Add(song);
                        context.SaveChanges();
                        SubmissionComplete();
                    }
                }
                else
                {
                    foreach (Song s in lstAlbum.Items)
                    {
                        if (!context.Songs.Any(c => c.Title == s.Title && c.Album.Title == s.Album.Title))
                        {
                            context.Songs.Add(s);
                            context.SaveChanges();
                        }
                    }
                    SubmissionComplete();
                }
            }
        }

        private void btnAddSongToAlbum_Click(object sender, EventArgs e)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                AlbumCheck(txtAlbum.Text);
                Album album = context.Albums.First(c => c.Title == txtAlbum.Text);
                Song song = CreateSong(txtSongTitle.Text, album, context.Artists.First(c => c.Artist1 == cmbArtist.Text) , (int)numTrack.Value, context.Genres.First(c => c.Genre1 == cmbGenre.Text) , int.Parse(txtLength.Text), (int)numRating.Value);
                lstAlbum.Items.Add(song);
                lstAlbum.DisplayMember = "Title";
                lstAlbum.Refresh();
                numTrack.Value++;
            }


        }

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            int result = 0;
            int.TryParse(txtYear.Text, out result);
            if (result == 0)
                e.Cancel = true;
        }

        private void numRating_Validating(object sender, CancelEventArgs e)
        {
            if (numRating.Value > 5)
                e.Cancel = true;
        }

        private void numAlbumRating_Validating(object sender, CancelEventArgs e)
        {
            if (numAlbumRating.Value > 5)
                e.Cancel = true;
        }

        #region Form Methods
        private bool GenreCheck(string GenreToCheck)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                Genre genre = new Genre();
                genre.Genre1 = GenreToCheck;
                //Checks to see if Genre is already in DB

                if (!context.Genres.Any(c => c.Genre1 == genre.Genre1)) //Checks to see if Genre is already in the database
                {
                    //Adds Genre to genre entity, saves changes, and informs user of success
                    context.Genres.Add(genre);
                    context.SaveChanges();
                    return false;
                }
                else
                    return true;
            }
        }

        private bool ArtistCheck(string ArtistToFind)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                //Creates new artist object and populates attributes
                Artist artist = new Artist();
                artist.Artist1 = ArtistToFind;

                //Checks to see if the Artist is already in the Database
                if (!context.Artists.Any(c => c.Artist1 == artist.Artist1))
                {
                    //Adds Artist to artist entity, saves changes, and informs user of success
                    context.Artists.Add(artist);
                    context.SaveChanges();
                    return false;
                }
                else
                    return true;
            }
        }

        private bool AlbumCheck(string AlbumToFind)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                Album album = new Album();
                album.Title = txtAlbum.Text;
                album.Year = int.Parse(txtYear.Text);
                album.Artist = context.Artists.First(c => c.Artist1 == cmbArtist.Text);
                album.Rating = (int)numAlbumRating.Value;

                if (!context.Albums.Any(c => c.Title == album.Title))
                {
                    context.Albums.Add(album);
                    context.SaveChanges();
                    return false;
                }

                else
                    return true;
            }
        }

        private Song CreateSong(string Title, Album Album, Artist Artist, int TrackNumber, Genre Genre, int TrackLength, int Rating)
        {
            Song song = new Song();
            song.Title = Title;
            song.Album = Album;
            song.Artist = Artist;
            song.TrackNumber = TrackNumber;
            song.Genre = Genre;
            song.TrackLength = TrackLength;
            song.Rating = Rating;
            return song;
        }

        private void SubmissionComplete()
        {
            MessageBox.Show("Your submission has been completed");
            txtSongTitle.ResetText();
            cmbArtist.ResetText();
            numTrack.ResetText();
            cmbGenre.ResetText();
            txtLength.ResetText();
            numRating.ResetText();
            numAlbumRating.ResetText();
            txtAlbum.ResetText();
            txtYear.ResetText();
            lstAlbum.ResetText();
            cmbGenre.Refresh();
            cmbArtist.Refresh();

        }

        #endregion

        private void cmbGenre_Validating(object sender, CancelEventArgs e)
        {
            if (cmbGenre.Text != "")
            {
                if (GenreCheck(cmbGenre.Text))
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        private void cmbArtist_Validating(object sender, CancelEventArgs e)
        {
            if (cmbArtist.Text != "")
            {
                if (ArtistCheck(cmbArtist.Text))
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        private void txtAlbum_Validating(object sender, CancelEventArgs e)
        {
            if (txtAlbum.Text != "")
            {
                if(AlbumCheck(txtAlbum.Text))
                    e.Cancel = true;
            }

            else
                e.Cancel = true;
        }
    }
}
