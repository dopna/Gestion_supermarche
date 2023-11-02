using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

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
    private void btnEnregistrer_Click(object sender, RoutedEventArgs e)
    {
        // Code pour gérer l'action d'enregistrement ici
        // Vous pouvez enregistrer les données ou effectuer d'autres actions en conséquence
    }
}