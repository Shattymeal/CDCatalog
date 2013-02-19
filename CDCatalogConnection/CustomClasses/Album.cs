using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCatalogConnection
{
    partial class Album
    {
        public int AlbumCheck(string albumTitle)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                List<Album> AlbumToFind = context.Albums.Where(al => al.Title == albumTitle).ToList();

                
                return 0;
            }
        }

    }
}
