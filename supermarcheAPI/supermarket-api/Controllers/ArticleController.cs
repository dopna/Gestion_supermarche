using System;
using Microsoft.AspNetCore.Mvc;
namespace SupermarketApi.Controllers
[ApiController]
[Route("api/controller")]
public class ArticlesController 

{
	public IEnumerable<ArticlesController>Get()
	{
        var connectionStringBuilder = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            Database = "supermarchébd",
            UserID = "",
            Password = "",
        };

        var article = GetArticleFromMySQL(connectionStringBuilder);

        // Utilisez entreesDuJour comme nécessaire...
    }

    static List<ArticlesController> GetEntreesDuJourFromMySQL(MySqlConnectionStringBuilder connectionStringBuilder)
    {
        using (var connection = new MySqlConnection(connectionStringBuilder.ConnectionString))
        {
            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT * FROM Article;";

            using (var reader = selectCmd.ExecuteReader())
            {
                var article = new List<ArticlesController>();
                while (reader.Read())
                {
                    articles.Add(new Article()
                    {
                        Id = reader.GetInt32(0), // Assurez-vous que votre colonne ID est un entier, ajustez si nécessaire
                        Nom = reader.GetString(1),
                        Prix = reader.GetDecimal(2), // Assurez-vous que votre colonne Prix est un décimal, ajustez si nécessaire
                        Categorie = reader.GetString(3),
                        Stock = reader.GetInt32(4), // Assurez-vous que votre colonne Stock est un entier, ajustez si nécessaire
                        DateExpiration = reader.GetDateTime(5) // Assurez-vous que votre colonne DateExpiration est une date, ajustez si nécessaire
                    });
                }
                return article;
            }
        }
    }
}
