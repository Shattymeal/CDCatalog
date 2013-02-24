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

        public int AlbumCheck(string albumTitle)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                List<Album> albumToFind = new List<Album>();
                albumToFind = context.Albums.Where(al => al.Title == albumTitle).ToList();

                if (albumToFind.Count < 1)
                    return -1;
                else
                    return albumToFind[0].AlbumID;

            }
        }

        public List<Album> Search(string choice, string filter, string lowRating, string highRating, bool rating)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                int id = 0;
                List<Album> albumSearch = new List<Album>();
                int albumLowRating = 0;
                int albumHighRating = 5;

                if (rating)
                {
                    int.TryParse(lowRating, out albumLowRating);
                    int.TryParse(highRating, out albumHighRating);
                }
                switch (choice)
                {
                    case "Album":
                        if (filter == "All")
                            albumSearch = context.Albums.Where(al => (al.Rating >= albumLowRating && al.Rating <= albumHighRating)).ToList();
                        else
                            albumSearch = context.Albums.Where(al => al.Title == filter && (al.Rating >= albumLowRating && al.Rating <= albumHighRating)).ToList();
                        break;
                    case "Artist":
                        id = new Artist().ArtistCheck(filter);
                        albumSearch = context.Albums.Where(al => al.ArtistID == id && (al.Rating >= albumLowRating && al.Rating <= albumHighRating)).ToList();
                        break;
                    case "Genre":
                        id = new Genre().GenreCheck(filter);
                        albumSearch = context.Albums.Where(al => al.GenreID == id && (al.Rating >= albumLowRating && al.Rating <= albumHighRating)).ToList();
                        break;
                    default:
                        break;
                }

                return albumSearch;
            }
        }
    }
}
