using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Website.Models;

namespace Website.Controllers {
    //Здесь мы описываем контроллер который взаимодействует уже с сайтом
    public class GenresController : Controller {
        private const string JSON_MEDIA_TYPE = "application/json";
        private const string AUTHORIZATION_HEADER_NAME = "Authorization";
        private readonly Uri tokenUri = new Uri("https://localhost:44378/api/login");
        private readonly Uri genresUri = new Uri("https://localhost:44378/api/Genres");

        // GET: Genres
        [HttpGet]
        public async Task<ActionResult> Index(string title = null) {
            using (var client = new HttpClient()) {
                var token = await GetAccessToken();
                client.DefaultRequestHeaders.Add(AUTHORIZATION_HEADER_NAME, token);

                HttpResponseMessage response = await client.GetAsync(genresUri);

                if (title != null) {
                    response = await client.GetAsync(new Uri("https://localhost:44378/api/Genres?title=" + title));
                }

                if (!response.IsSuccessStatusCode) {
                    return RedirectToAction(nameof(HomeController.Error), "Home");
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var responseData = JsonConvert.DeserializeObject<IEnumerable<GenreViewModel>>(jsonResponse);

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

                HttpResponseMessage response = await client.GetAsync($"{genresUri}/{id}");

                if (!response.IsSuccessStatusCode) {
                    return RedirectToAction(nameof(HomeController.Error), "Home");
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var responseData = JsonConvert.DeserializeObject<GenreViewModel>(jsonResponse);

                return View(responseData);
            }
        }

        // GET: Genres/Create
        [HttpGet]
        public ActionResult Create() {
            return View();
        }

        // POST: Genres/Create
        [HttpPost]
        public async Task<ActionResult> Create(GenreViewModel genre) {
            try {
                using (var client = new HttpClient()) {
                    var token = await GetAccessToken();
                    client.DefaultRequestHeaders.Add(AUTHORIZATION_HEADER_NAME, token);

                    var serializedContent = JsonConvert.SerializeObject(genre);
                    var stringContent = new StringContent(serializedContent, Encoding.UTF8, JSON_MEDIA_TYPE);

                    HttpResponseMessage response = await client.PostAsync(genresUri, stringContent);

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

                HttpResponseMessage response = await client.GetAsync($"{genresUri}/{id}");

                if (!response.IsSuccessStatusCode) {
                    return RedirectToAction(nameof(HomeController.Error), "Home");
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var responseData = JsonConvert.DeserializeObject<GenreViewModel>(jsonResponse);

                return View(responseData);
            }
        }

        // POST: Genres/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, GenreViewModel craftType) {
            craftType.Id = id;

            try {
                using (var client = new HttpClient()) {
                    var token = await GetAccessToken();
                    client.DefaultRequestHeaders.Add(AUTHORIZATION_HEADER_NAME, token);

                    var serializedContent = JsonConvert.SerializeObject(craftType);
                    var stringContent = new StringContent(serializedContent, Encoding.UTF8, JSON_MEDIA_TYPE);

                    HttpResponseMessage response = await client.PutAsync($"{genresUri}/{id}", stringContent);

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

                HttpResponseMessage response = await client.GetAsync($"{genresUri}/{id}");

                if (!response.IsSuccessStatusCode) {
                    return RedirectToAction(nameof(HomeController.Error), "Home");
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var responseData = JsonConvert.DeserializeObject<GenreViewModel>(jsonResponse);

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

                    HttpResponseMessage response = await client.DeleteAsync($"{genresUri}/{id}");

                    if (!response.IsSuccessStatusCode) {
                        return RedirectToAction(nameof(HomeController.Error), "Home");
                    }
                }

                return RedirectToAction(nameof(Index));
            } catch {
                return RedirectToAction(nameof(HomeController.Error), "Home");
            }
        }
    }
}