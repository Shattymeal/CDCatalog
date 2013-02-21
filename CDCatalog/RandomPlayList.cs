using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CDCatalogConnection;
using System.Threading.Tasks;

namespace CDCatalog
{
    public class RandomPlayList
    {
        Stack<Songs> playList;
        List<int> playtime;
        List<int> usedSong;
        List<Songs> SongCatalog;
        public const int playtimeMin = 2520;
        public const int playtimeMax = 2820;

        public RandomPlayList()
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                SongCatalog = context.Songs1.ToList();
                CreatePlayList();
            }
        }

        public void CreatePlayList()
        {
            Random rndSong = new Random();
            int index = rndSong.Next(0, SongCatalog.Count);

            while (playtime.Sum() > 2520 && playtime.Sum() < 2820)
            {
                

                if (playtime.Sum() > 2520)
                {
                    playtime.Add(SongCatalog[index].TrackLength);
                    playList.Push(SongCatalog[index]);
                    usedSong.Add(index);
                }

                if (playtime.Sum() > 2820)
                {
                    usedSong.Remove(index);
                    playList.Pop();
                    playtime.Remove(SongCatalog[index].TrackLength);
                }

                index = rndSong.Next(0, SongCatalog.Count);
            }
        }
    }
}
