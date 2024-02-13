using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkToSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                /*IReadOnlyList<song> songs = (from song in db.songs
                                             where song.rating >=3
                                             orderby song.title
                                             select song).ToList();*/

                /*IReadOnlyList<song> songs = (from song in db.songs
                                             where song.rating >=3
                                             orderby song.rating descending
                                             select song).ToList();*/

                /* IReadOnlyList<song> songs = (from song in db.songs
                                              where song.rating >= 3
                                              orderby song.title
                                              select song).ToList();*/

                /*IReadOnlyList<song> songs = (from song in db.songs
                                             where song.rating == 5
                                             orderby song.title
                                             select song).ToList();

                IReadOnlyList<artist> artists = (from artist in db.artists
                                             orderby artist.Name
                                             select artist)
                                             .ToList();
*/
                /*foreach (var item in songs)
                {
                    Console.WriteLine(item);
                }*/

                /*foreach (var item in artists)
                {
                    Console.WriteLine(item);
                }*/

                int? sumDur = db.songs
                    .Sum(song => song.duration);

                int? sumWeigh = db.songs
                    .Sum(song => song.weight);

                Console.WriteLine($"{sumDur} {sumWeigh}");

                var songAmount = db.songs
                    .GroupBy(song => song.rating)
                    .Select(group => new
                    {
                        Rating = group.Key,
                        Count = group.Count()
                    });
                foreach (var item in songAmount)
                {
                    Console.WriteLine(item);
                }

            }

           
        }
    }
}
