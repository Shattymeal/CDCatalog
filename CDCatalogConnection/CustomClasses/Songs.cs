using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCatalogConnection
{
    partial class Songs
    {
        public int SongCheck(string songTitle, string songArtist, string songAlbum = null, string songGenre = null, int songTrackNumer = 1, int songTrackLength = 1, int songRating = 0)
        {
            using(CDCatalogEntities context = new CDCatalogEntities())
            {
                List<Songs> SongToFind = context.Songs1.Where(s => s.Title == songTitle).ToList();

                if (SongToFind.Count == 0)
                {
                    Songs SongToAdd = new Songs();
                    SongToAdd.Title = songTitle;
                    SongToAdd.ArtistID = Artist.ArtistCheck(songArtist);
                    //SongToAdd.AlbumID = Album.songAlbum;
                    SongToAdd.GenreID = Genre.GenreCheck(songGenre);
                    SongToAdd.TrackNumber = songTrackNumer;
                    SongToAdd.TrackLength = songTrackLength;
                    SongToAdd.Rating = songRating;
                }
                
            }
            return 0;
        }
    }
}
