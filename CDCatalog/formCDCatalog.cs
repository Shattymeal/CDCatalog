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
        public formCDCatalog()
        {
            InitializeComponent();
            addGenreToDB();
            addArtistToDB();
            addAlbumToDB();
            addSongToDB();
        }

        public void addGenreToDB()
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                string genre = "Trap";
                Genre newGenre = new Genre();
                int ID = newGenre.GenreCheck(genre);
                MessageBox.Show("The following Genre Trap was added with ID " + ID);
            }
        }

        public void addArtistToDB()
        {
            string artist = "Diplo";
            Artist newArtist = new Artist();
            int ID = newArtist.ArtistCheck(artist);
            MessageBox.Show("The Following Artist Diplo was added with ID " + ID);
        }

        public void addAlbumToDB()
        {
            string albumTitle = "Trapity Trap";
            string albumArtist = "Diplo";
            int albumYear = 2000;
            string albumGenre = "Trap";
            int albumRating = 5;
            Album newAlbum = new Album();
            int ID = newAlbum.AlbumCheck(albumTitle, albumArtist, albumYear, albumGenre, albumRating);
            MessageBox.Show("The Following Album Trapity Trap was added with ID " + ID);

        }

        public void addSongToDB()
        {
            string songTitle = "Original Don";
            string songArtist = "Diplo";
            string songAlbum = "Trapity Trap";
            string songGenre = "Trap";
            int songTrackNumber = 1;
            int songTrackLength = 300;
            int songRating = 5;
            Songs newSong = new Songs();
            int ID = newSong.SongCheck(songTitle, songArtist, songAlbum, songGenre, songTrackNumber, songTrackLength, songRating);
            MessageBox.Show("The Following Song Original Don was added with ID " + ID);
        }
    }
}
