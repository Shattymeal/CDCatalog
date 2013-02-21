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
        public Stack<Songs> playList = new Stack<Songs>();
        bool uniqueIndex = false;
        public List<int> playtime = new List<int>();
        List<int> usedSong = new List<int>();
        List<Songs> SongCatalog = new List<Songs>();
        public const int playtimeMin = 2520;
        public const int playtimeMax = 2820;

        public RandomPlayList()
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                this.SongCatalog = context.Songs1.ToList();
                CreatePlayList();
            }
        }

        public void CreatePlayList()
        {
            Random rndSong = new Random();
            int index = rndSong.Next(0, SongCatalog.Count);

            while (playtime.Sum() < playtimeMin || playtime.Sum() > playtimeMax)
            {
                uniqueIndex = false;

                if (playtime.Sum() < playtimeMin)
                {
                    playtime.Add(SongCatalog[index].TrackLength);
                    playList.Push(SongCatalog[index]);
                    usedSong.Add(index);
                }

                if (playtime.Sum() > playtimeMax)
                {
                    usedSong.Remove(index);
                    playList.Pop();
                    playtime.Remove(SongCatalog[index].TrackLength);
                }

                index = rndSong.Next(0, SongCatalog.Count);

                while (!uniqueIndex)
                {
                    if (usedSong.Contains(index))
                    {
                        index = rndSong.Next(0, SongCatalog.Count);
                    }
                    else
                    {
                        uniqueIndex = true;
                    }
                }
            }
        }
    }
}
