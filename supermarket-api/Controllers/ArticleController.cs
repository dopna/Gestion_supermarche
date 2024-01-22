
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Net;
using System.Collections.Generic;

namespace SupermarketApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticlesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            var connectionStringBuilder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "supermarchébd",
                UserID = "",
                Password = "",
            };

            var articles = GetArticlesFromMySQL(connectionStringBuilder)
            static List<Article> GetArticlesFromMySQL(MySqlConnectionStringBuilder connectionStringBuilder)
            {
                using (var connection = new MySqlConnection(connectionStringBuilder.ConnectionString))
                {
                    connection.Open();

                    var selectCmd = connection.CreateCommand();
                    selectCmd.CommandText = "SELECT * FROM Article;";

                    using (var reader = selectCmd.ExecuteReader())
                    {
                        var articles = new List<Article>();
                        while (reader.Read())
                        {
                            articles.Add(new Article()
                            {
                                Id = reader.GetInt32(0),
                                Nom = reader.GetString(1),
                                Prix = reader.GetDecimal(2),
                                Categorie = reader.GetString(3),
                                Stock = reader.GetInt32(4),
                                DateExpiration = reader.GetDateTime(5)
                            });
                        }
                        return articles;
                    }
                }
            }





        }

    }


}
