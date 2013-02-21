using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCatalogConnection
{
    partial class Album
    {
        public int AlbumCheck(string albumTitle, string artistName, int year = 1990, string genreName = null, int rating = 0)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                List<Album> AlbumToFind = context.Albums.Where(al => al.Title.ToUpper() == albumTitle.ToUpper()).ToList();

                if (AlbumToFind.Count == 0)
                {
                    Album AlbumToAdd = new Album();
                    AlbumToAdd.Title = albumTitle;
                    AlbumToAdd.Year = year;
                    AlbumToAdd.Rating = rating;
                    AlbumToAdd.ArtistID = new Artist().ArtistCheck(artistName);
                    AlbumToAdd.GenreID = new Genre().GenreCheck(genreName);
                    context.Albums.Add(AlbumToAdd);
                    context.SaveChanges();

                    List<Album> AddedAlbum = context.Albums.Where(al => al.Title.ToUpper() == albumTitle.ToUpper()).ToList();
                    return AddedAlbum[0].AlbumID;
                }

                else if(AlbumToFind.Count > 1)
                {
                    List<Album> albumInList = AlbumToFind.Where(aa => aa.ArtistID == Artist.ArtistCheck(artistName)).ToList();
                    return albumInList[0].AlbumID;
                }

                else
                {
                    return AlbumToFind[0].AlbumID;
                }
                
            }
        }

    }
}
