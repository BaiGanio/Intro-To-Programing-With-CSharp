using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieTitles
{
    internal class Program
    {
        private static readonly HttpClient _client = new();
        private static readonly string _url = "https://jsonmock.hackerrank.com/api/movies/search/";
        private static int _pages = 0;
        static async Task Main()
        {
            try
            {
                Console.Write("Enter title: ");
                string title = Console.ReadLine();
                Console.WriteLine("-------");
                List<MovieInfo> movies = await GetMovieInfo(title, 0);
                if (_pages > 1)
                {
                    for (int page = 2; page <= _pages; page++)
                    {
                        movies.AddRange(await GetMovieInfo(title, page));
                    }
                }

                Console.WriteLine($"Total pages: {_pages}");
                Console.WriteLine($"Total titles: {movies.Count}");
                Console.WriteLine(new string('-', 87));
                PrintTitles(movies);
                Console.WriteLine(new string('-', 87));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintTitles(List<MovieInfo> movies)
        {
            movies = movies.OrderByDescending(x => x.Title).ToList();
            Console.WriteLine($"{" #",-3} | {"Title", -60} | Year | {"IMDbId", -9} |");
            Console.WriteLine(new string('-', 87));
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($" {i + 1, -2} {movies[i]}");
            }
        }

        private static async Task<List<MovieInfo>> GetMovieInfo(string title, int? page = null)
        {
            var stringTask = _client.GetStringAsync($"{_url}?Title={title}&page={page}");
            var msg = await stringTask;
            JavaScriptSerializer serializer = new();
            dynamic item = serializer.Deserialize<object>(msg);
            _pages = Convert.ToInt32(item.total_pages);
            var arr = JsonConvert.DeserializeObject<List<MovieInfo>>(Convert.ToString(item.data));
            return arr;
        }
    }
}
