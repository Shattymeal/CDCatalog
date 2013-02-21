using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCatalogConnection
{
    partial class Genre
    {
        public int GenreCheck(string genreName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                //Genre Where clause that finds any genre with the name
                List<Genre> GenreToFind = context.Genres.Where(g => g.Genre1.ToUpper() == genreName.ToUpper()).ToList();

                //If nothing in GenreToFind list then add the genre to the database
                if (GenreToFind.Count == 0)
                {
                    //Create, Add Genre name, add to the context then save DB changes
                    Genre GenreToAdd = new Genre();
                    GenreToAdd.Genre1 = genreName;
                    context.Genres.Add(GenreToAdd);
                    context.SaveChanges();

                    //Once the Genre has been added find it again in the DB and return its ID value
                    List<Genre> GenreAdded = context.Genres.Where(g => g.Genre1 == genreName).ToList();
                    return GenreAdded[0].GenreID;
                }

                else
                {
                    //The Genre is in the DB and returning its ID value
                    return GenreToFind[0].GenreID;
                }
            }
        }
    }
}
