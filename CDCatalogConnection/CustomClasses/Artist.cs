using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCatalogConnection
{
    partial class Artist
    {
        public int ArtistCheck(string artistName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                List<Artist> ArtistToFind = context.Artists.Where(a => a.Artist1 == artistName).ToList();

                if (ArtistToFind.Count == 0)
                {
                    Artist artist = new Artist();
                    artist.Artist1 = artistName;
                    context.Artists.Add(artist);
                    context.SaveChanges();

                    List<Artist> AddedArtist = context.Artists.Where(a => a.Artist1 == artistName).ToList();
                    return AddedArtist[0].ArtistID;
                }

                else
                {
                    return ArtistToFind[0].ArtistID;
                }
            }
        }
    }
}
