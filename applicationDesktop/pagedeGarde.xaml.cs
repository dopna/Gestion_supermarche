using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using applicationDesktop.models;
using Newtonsoft.Json;

namespace applicationDesktop;

public partial class pagedeGarde : Window
{
    public pagedeGarde()
    {
        InitializeComponent();
        
    }
    private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
    {
        // Utilisez une expression régulière pour permettre uniquement les chiffres
        Regex regex = new Regex("[^0-9]+");
        e.Handled = regex.IsMatch(e.Text);
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (datePicker.SelectedDate.HasValue)
        {
            MessageBox.Show("Date sélectionnée : " + datePicker.SelectedDate.Value.ToShortDateString());
        }
        else
        {
            MessageBox.Show("Aucune date sélectionnée.");
        }
    }
    private void btnCategories_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            // Créer une nouvelle instance de PageVendeurs
            pageCategories categories = new pageCategories();

            // Afficher la nouvelle interface
            categories.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}");
        }
    }
    private void btnEnregistrer_Click(object sender, RoutedEventArgs e)
    {
        // Code pour gérer l'action d'enregistrement ici
        // Vous pouvez enregistrer les données ou effectuer d'autres actions en conséquence
    }

    private void btnVendeurs_Click(object sender, RoutedEventArgs e)
    {
        PageVendeurs vendeurs = new PageVendeurs();

        // Afficher la nouvelle interface
        vendeurs.Show();

    }

    private async void btnActualiser_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                
                var response = await client.GetAsync("http://localhost:7107");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    List<Article> articles = JsonConvert.DeserializeObject<List<Article>>(content);
                    foreach (var article in articles)
                    {
                        // Afficher chaque article (exemple avec une MessageBox)
                        MessageBox.Show($"ID: {article.Id}, Nom: {article.Nom}, Prix: {article.Prix}, Catégorie: {article.Categorie}, Stock: {article.Stock}, DateExpiration: {article.DateExpiration}");
                    }

                }
                else
                {
                    Console.WriteLine(response.ToString());
                }
            }
        }
        catch (Exception)
        {

            // Gérer les exceptions si nécessaire
            Console.WriteLine("ex");
        }
       
    }

    private void btnModifier_Click(object sender, RoutedEventArgs e)
    {

    }

    private void btnSupprimer_Click(object sender, RoutedEventArgs e)
    {

    }
}