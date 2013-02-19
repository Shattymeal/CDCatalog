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
        }

        public void addGenreToDB()
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                Genre newGenre = new Genre();
                int ID = newGenre.GenreCheck("Trap");
                MessageBox.Show("The following Genre Trap was added with ID " + ID);
            }
        }

        public void addArtistToDB()
        {
            Artist newArtist = new Artist();
            int ID = newArtist.ArtistCheck("Diplo");
            MessageBox.Show("The Following Artist Diplo was added with ID " + ID);
        }
    }
}
