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
                List<Songs> SongToFind = context.Songs1.Where(s => s.Title.ToUpper() == songTitle.ToUpper()).ToList();

                if (SongToFind.Count == 0)
                {
                    Songs SongToAdd = new Songs();
                    SongToAdd.Title = songTitle;
                    SongToAdd.ArtistID = new Artist().ArtistCheck(songArtist);
                    SongToAdd.AlbumID = new Album().AlbumCheck(songAlbum, songArtist);
                    SongToAdd.GenreID = new Genre().GenreCheck(songGenre);
                    SongToAdd.TrackNumber = songTrackNumer;
                    SongToAdd.TrackLength = songTrackLength;
                    SongToAdd.Rating = songRating;
                    context.Songs1.Add(SongToAdd);
                    context.SaveChanges();

                    List<Songs> AddedSong = context.Songs1.Where(s => s.Title.ToUpper() == songTitle.ToUpper()).ToList();
                    return AddedSong[0].SongID;
                }

                else if (SongToFind.Count > 1)
                {
                    List<Songs> SongsInList = SongToFind.Where(sa => sa.ArtistID == Artist.ArtistCheck(songArtist)).ToList();
                    return SongsInList[0].SongID;
                }

                else
                {
                    return SongToFind[0].SongID;
                }
                
            }
        }

        public List<Songs> Search(string choice, string filter, string lowRating, string highRating, bool rating)
        {
            List<Songs> searchList = new List<Songs>();
            int id = 0;
            int lowSongRating = 0;
            int highSongRating = 5;

            if (rating)
            {
                int.TryParse(lowRating, out lowSongRating);
                int.TryParse(highRating, out highSongRating);
            }

            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                switch (choice)
                {
                    case "Song":
                        if (filter == "All")
                            searchList = context.Songs1.Where(s => (s.Rating <= highSongRating && s.Rating >= lowSongRating)).ToList();
                        else
                            searchList = context.Songs1.Where(s => s.Title == filter && (s.Rating >= lowSongRating && s.Rating <= highSongRating)).ToList();
                        break;
                    case "Artist":
                        id = new Artist().ArtistCheck(filter);
                        searchList = context.Songs1.Where(s => s.ArtistID == id && (s.Rating >= lowSongRating && s.Rating <= highSongRating)).ToList();
                        break;
                    case "Album":
                        id = new Album().AlbumCheck(filter);
                        searchList = context.Songs1.Where(s => s.AlbumID == id && (s.Rating >= lowSongRating && s.Rating <= highSongRating)).ToList();
                        break;
                    case "Genre":
                        id = new Genre().GenreCheck(filter);
                        searchList = context.Songs1.Where(s => s.GenreID == id && (s.Rating >= lowSongRating && s.Rating <= highSongRating)).ToList();
                        break;
                    default:
                        break;
                }

                return searchList;
            }
        }
    }
}
