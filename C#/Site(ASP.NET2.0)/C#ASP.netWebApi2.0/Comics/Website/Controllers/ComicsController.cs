using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Website.Models;

namespace Website.Controllers {
    //Здесь мы описываем контроллер который взаимодействует уже с сайтом
    public class ComicsController : Controller {
        private const string JSON_MEDIA_TYPE = "application/json";
        private const string AUTHORIZATION_HEADER_NAME = "Authorization";
        private readonly Uri tokenUri = new Uri("https://localhost:44378/api/login");
        private readonly Uri comicasUri = new Uri("https://localhost:44378/api/Comics");
        private readonly Uri genresUri = new Uri("https://localhost:44378/api/Genres");
        private readonly Uri studiosUri = new Uri("https://localhost:44378/api/Studios");

        // GET: Genres
        [HttpGet]
        public async Task<ActionResult> Index(string title = null) {
            using (var client = new HttpClient()) {
                var token = await GetAccessToken();
                client.DefaultRequestHeaders.Add(AUTHORIZATION_HEADER_NAME, token);

                HttpResponseMessage response = await client.GetAsync(comicasUri);

                if (title != null) {
                    response = await client.GetAsync(new Uri("https://localhost:44378/api/Comics?title=" + title));
                }

                if (!response.IsSuccessStatusCode) {
                    return RedirectToAction(nameof(HomeController.Error), "Home");
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var responseData = JsonConvert.DeserializeObject<IEnumerable<ComicsViewModel>>(jsonResponse);

                return View(responseData);
            }
        }

        private async Task<string> GetAccessToken() {
            using (var client = new HttpClient()) {
                var serializedContent = JsonConvert.SerializeObject(new { Username = "test1Username", Password = "test1Password" });
                var stringContent = new StringContent(serializedContent, Encoding.UTF8, JSON_MEDIA_TYPE);

                HttpResponseMessage response = await client.PostAsync(tokenUri, stringContent);

                if (!response.IsSuccessStatusCode) {
                    return null;
                }

                return $"Bearer {await response.Content.ReadAsStringAsync()}";
            }
        }

        // GET: Genres/Details/5
        [HttpGet]
        public async Task<ActionResult> Details(int id) {
            using (var client = new HttpClient()) {
                var token = await GetAccessToken();
                client.DefaultRequestHeaders.Add(AUTHORIZATION_HEADER_NAME, token);

                HttpResponseMessage response = await client.GetAsync($"{comicasUri}/{id}");

                if (!response.IsSuccessStatusCode) {
                    return RedirectToAction(nameof(HomeController.Error), "Home");
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var responseData = JsonConvert.DeserializeObject<ComicsViewModel>(jsonResponse);

                return View(responseData);
            }
        }

        // GET: Genres/Create
        [HttpGet]
        public async Task<ActionResult> Create() {
            ViewBag.Genres = await GetGenresDropdownItemsAsync();
            ViewBag.Studios = await GetStudiosDropdownItemsAsync();

            return View();
        }

        // POST: Genres/Create
        [HttpPost]
        public async Task<ActionResult> Create(ComicsViewModel comics) {
            try {
                using (var client = new HttpClient()) {
                    var token = await GetAccessToken();
                    client.DefaultRequestHeaders.Add(AUTHORIZATION_HEADER_NAME, token);

                    var serializedContent = JsonConvert.SerializeObject(comics);
                    var stringContent = new StringContent(serializedContent, Encoding.UTF8, JSON_MEDIA_TYPE);

                    HttpResponseMessage response = await client.PostAsync(comicasUri, stringContent);

                    if (!response.IsSuccessStatusCode) {
                        return RedirectToAction(nameof(HomeController.Error), "Home");
                    }

                    return RedirectToAction(nameof(Index));
                }
            } catch {
                return RedirectToAction(nameof(HomeController.Error), "Home");
            }
        }

        // GET: Genres/Edit/5
        [HttpGet]
        public async Task<ActionResult> Edit(int id) {
            using (var client = new HttpClient()) {
                var token = await GetAccessToken();
                client.DefaultRequestHeaders.Add(AUTHORIZATION_HEADER_NAME, token);

                HttpResponseMessage response = await client.GetAsync($"{comicasUri}/{id}");

                if (!response.IsSuccessStatusCode) {
                    return RedirectToAction(nameof(HomeController.Error), "Home");
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var responseData = JsonConvert.DeserializeObject<ComicsViewModel>(jsonResponse);
                
                ViewBag.Genres = await GetGenresDropdownItemsAsync();
                ViewBag.Studios = await GetStudiosDropdownItemsAsync();

                return View(responseData);
            }
        }

        // POST: Genres/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ComicsViewModel comics) {
            comics.Id = id;

            try {
                using (var client = new HttpClient()) {
                    var token = await GetAccessToken();
                    client.DefaultRequestHeaders.Add(AUTHORIZATION_HEADER_NAME, token);

                    var serializedContent = JsonConvert.SerializeObject(comics);
                    var stringContent = new StringContent(serializedContent, Encoding.UTF8, JSON_MEDIA_TYPE);

                    HttpResponseMessage response = await client.PutAsync($"{comicasUri}/{id}", stringContent);

                    if (!response.IsSuccessStatusCode) {
                        return RedirectToAction(nameof(HomeController.Error), "Home");
                    }

                    return RedirectToAction(nameof(Index));
                }
            } catch {
                return RedirectToAction(nameof(HomeController.Error), "Home");
            }
        }

        // GET: Genres/Delete/5
        [HttpGet]
        public async Task<ActionResult> Delete(int id) {
            using (var client = new HttpClient()) {
                var token = await GetAccessToken();
                client.DefaultRequestHeaders.Add(AUTHORIZATION_HEADER_NAME, token);

                HttpResponseMessage response = await client.GetAsync($"{comicasUri}/{id}");

                if (!response.IsSuccessStatusCode) {
                    return RedirectToAction(nameof(HomeController.Error), "Home");
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var responseData = JsonConvert.DeserializeObject<ComicsViewModel>(jsonResponse);

                return View(responseData);
            }
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int id) {
            try {
                using (var client = new HttpClient()) {
                    var token = await GetAccessToken();
                    client.DefaultRequestHeaders.Add(AUTHORIZATION_HEADER_NAME, token);

                    HttpResponseMessage response = await client.DeleteAsync($"{comicasUri}/{id}");

                    if (!response.IsSuccessStatusCode) {
                        return RedirectToAction(nameof(HomeController.Error), "Home");
                    }
                }

                return RedirectToAction(nameof(Index));
            } catch {
                return RedirectToAction(nameof(HomeController.Error), "Home");
            }
        }

        private async Task<IEnumerable<SelectListItem>> GetGenresDropdownItemsAsync() {
            using (var client = new HttpClient()) {
                var token = await GetAccessToken();
                client.DefaultRequestHeaders.Add(AUTHORIZATION_HEADER_NAME, token);

                HttpResponseMessage genresResponse = await client.GetAsync(genresUri);

                if (!genresResponse.IsSuccessStatusCode) {
                    return Enumerable.Empty<SelectListItem>();
                }

                string genresJsonResponse = await genresResponse.Content.ReadAsStringAsync();

                var genres = JsonConvert.DeserializeObject<IEnumerable<GenreViewModel>>(genresJsonResponse);

                return genres.Select(genre => new SelectListItem(genre.Title, genre.Id.ToString()));
            }
        }

        private async Task<IEnumerable<SelectListItem>> GetStudiosDropdownItemsAsync() {
            using (var client = new HttpClient()) {
                var token = await GetAccessToken();
                client.DefaultRequestHeaders.Add(AUTHORIZATION_HEADER_NAME, token);

                HttpResponseMessage studiosResponse = await client.GetAsync(studiosUri);

                if (!studiosResponse.IsSuccessStatusCode) {
                    return Enumerable.Empty<SelectListItem>();
                }

                string studiosJsonResponse = await studiosResponse.Content.ReadAsStringAsync();

                var studios = JsonConvert.DeserializeObject<IEnumerable<StudioViewModel>>(studiosJsonResponse);

                return studios.Select(studio => new SelectListItem(studio.Title, studio.Id.ToString()));
            }
        }
    }
}