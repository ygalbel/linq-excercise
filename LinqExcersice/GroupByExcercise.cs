using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcersice
{
    class GroupByExcercise
    {
        IEnumerable<Singer> singers = new List<Singer>()
        {
            new Singer(){Id = 1, FirstName = "Freddie", LastName = "Mercury"}
            , new Singer(){Id = 2, FirstName = "Elvis", LastName = "Presley"}
            , new Singer(){Id = 3, FirstName = "Chuck", LastName = "Berry"}
            , new Singer(){Id = 4, FirstName = "Ray", LastName = "Charles"}
            , new Singer(){Id = 5, FirstName = "David", LastName = "Bowie"}
        };
        IEnumerable<Concert> concerts = new List<Concert>()
        {
            new Concert(){SingerId = 1, ConcertCount = 53, Year = 1980}
            , new Concert(){SingerId = 1, ConcertCount = 74, Year = 1980}
            , new Concert(){SingerId = 1, ConcertCount = 38, Year = 1981}
            , new Concert(){SingerId = 2, ConcertCount = 43, Year = 1970}
            , new Concert(){SingerId = 2, ConcertCount = 64, Year = 1968}
            , new Concert(){SingerId = 3, ConcertCount = 32, Year = 1960}
            , new Concert(){SingerId = 5, ConcertCount = 32, Year = 1960}
            , new Concert(){SingerId = 3, ConcertCount = 51, Year = 1962}
            , new Concert(){SingerId = 3, ConcertCount = 95, Year = 1962}
            , new Concert(){SingerId = 4, ConcertCount = 42, Year = 1950}
            , new Concert(){SingerId = 4, ConcertCount = 12, Year = 1980}
            , new Concert(){SingerId = 5, ConcertCount = 53, Year = 1968}
        };

        public static void RunExcercise()
        {
            // print how many singers performed by Year
            // example: Year: 1960 Count: 64

            
        }
    }
}
