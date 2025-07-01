using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class APIMovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<APIMovieViewModel> apiMovies = new List<APIMovieViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
                {
                     { "x-rapidapi-key", "0424ef6775msh081bb046a0b4883p1a6b6bjsne8607496027d" },
                     { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMovies = JsonConvert.DeserializeObject<List<APIMovieViewModel>>(body);
                
                return View(apiMovies);
            }
        }
    }
}
