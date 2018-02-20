using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcersice
{
    public class Singer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Concert
    {
        public int SingerId { get; set; }
        public int ConcertCount { get; set; }
        public int Year { get; set; }
    }
    class SelectManyExcercise
    {
       

        public static IEnumerable<Singer> GetSingers()
        {
            return new List<Singer>()
            {
                new Singer(){Id = 1, FirstName = "Freddie", LastName = "Mercury"}
                , new Singer(){Id = 2, FirstName = "Elvis", LastName = "Presley"}
                , new Singer(){Id = 3, FirstName = "Chuck", LastName = "Berry"}
                , new Singer(){Id = 4, FirstName = "Ray", LastName = "Charles"}
                , new Singer(){Id = 5, FirstName = "David", LastName = "Bowie"}
            };
        }


        public static IEnumerable<Concert> GetConcerts()
        {
            return new List<Concert>()
            {
                new Concert(){SingerId = 1, ConcertCount = 53, Year = 1979}
                , new Concert(){SingerId = 1, ConcertCount = 74, Year = 1980}
                , new Concert(){SingerId = 1, ConcertCount = 38, Year = 1981}
                , new Concert(){SingerId = 2, ConcertCount = 43, Year = 1970}
                , new Concert(){SingerId = 2, ConcertCount = 64, Year = 1968}
                , new Concert(){SingerId = 3, ConcertCount = 32, Year = 1960}
                , new Concert(){SingerId = 3, ConcertCount = 51, Year = 1961}
                , new Concert(){SingerId = 3, ConcertCount = 95, Year = 1962}
                , new Concert(){SingerId = 4, ConcertCount = 42, Year = 1950}
                , new Concert(){SingerId = 4, ConcertCount = 12, Year = 1951}
                , new Concert(){SingerId = 5, ConcertCount = 53, Year = 1983}
            };
        }

        public static void RunExcercise()
        {
            //https://dotnetcodr.com/2014/05/16/projection-in-linq-c-with-the-selectmany-operator/
            IEnumerable<Singer> singers = GetSingers();
            IEnumerable<Concert> concerts = GetConcerts();

            // found how many Concert every singer gave in all years
            // example: SingerId:1   Count:53+74+38 = 165
            // answer below






















            /*    var singerConcerts = singers.SelectMany(s => concerts.Where(c => c.SingerId == s.Id)
             *       .Select(c => new { Year = c.Year, ConcertCount = c.ConcertCount, Name = string.Concat(s.FirstName, " ", s.LastName) }));

                foreach (var item in singerConcerts)
                {
                    Console.WriteLine(string.Concat(item.Name, ", ", item.Year, ", ", item.ConcertCount));
                }
            }*/
        }
    }
}
