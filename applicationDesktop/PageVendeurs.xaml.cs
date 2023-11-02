using System.Windows;
using System.Windows.Controls;


namespace applicationDesktop;

public partial class PageVendeurs : Window
{
    public PageVendeurs()
    {
        InitializeComponent();
    }
    private void VendeursListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // Gérez l'événement de sélection ici
    }
}
