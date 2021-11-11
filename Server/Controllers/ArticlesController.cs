using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        /*
         * HTTP-Verben
         *  GET     ... um Daten vom Server zu holen  
         *  POST    ... um "neue" Daten am Server abzuspeichern
         *  DELETE  ... um Daten am Server zu löschen
         *  PUT     ... um DAten am Server zu "aktualisieren"
         */

        /*
         * Unsere Datenbankmanager-Klasse
         */
        private ArticlesContext ctx = new ArticlesContext();

        [HttpGet]
        public List<Article> GetAllArticlesFromDB()
        {
            /*
             * diese Methode wird aufgerufen, wenn die folgende URL verwendet wird
             *      https://localhost:8389/api/articles
             * wichtig: es muss natürlich GET verwendet worden sein (Client)
             */
            return ctx.Articles.ToList();
            /*
             * Das Ergebniss wird automatisch nach JSON konvertiert
             */
        }

        [HttpGet]
        [Route("{id}")]
        public Article GetArticlesFromDB(int id)
        {
            /*
             * diese Methode wird aufgerufen, wenn die folgende URL verwendet wird
             *      https://localhost:8389/api/articles/2
             * wichtig: es muss natürlich GET verwendet worden sein (Client)
             */
            return ctx.Articles.Find(id);
        }

        /*
         * weitere HTTP-Verben
         * [HttpDelete], [HttpsPost], [HttpPut]
         */

        [HttpDelete]
        [Route("{id}")]
        public void DeleteArticleFrmoDB(int id)
        { 
            ctx.Articles.Remove(ctx.Articles.Find(id));
        }

        [HttpPut]
        [Route("/put{a}")]
        public void AddArticleToDB(Article a)
        {
            ctx.Articles.Add(a);
        }
    }
}
