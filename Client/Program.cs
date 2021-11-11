using Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client {
	class Program {

		private static HttpClient _client = new HttpClient();

		static async Task Main(string[] args) {
			Console.WriteLine("alle Artikel von unserem Web-API-Server");
			var articles = await GetAllArticlesFromWebAPIAsync();
			if (articles != null) {
				// alle Artikel ausgeben
				articles.ForEach(a => Console.WriteLine(a));
			} else {
				Console.WriteLine("WEB-API-Fehler: Artikel konnten nicht geladen werden!");
			}


			Console.WriteLine("Den Artikel mit der ID=2 von unserem Web-API-Server laden");
		}

		public static async Task<List<Article>> GetAllArticlesFromWebAPIAsync() {
			var response = await _client.GetAsync("http://localhost:8389/api/articles");

			if (response.IsSuccessStatusCode) {
				// als JSON auslesen
				var responseJson = await response.Content.ReadAsStringAsync();

				// in eine List<Article> konvertieren
				return JsonConvert.DeserializeObject<List<Article>>(responseJson);
			}
			// Fehler vom WEB_API_Server
			return null;
		}
	}
}
