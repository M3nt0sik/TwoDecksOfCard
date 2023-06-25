using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Game_Card;

namespace TwoDecksOfCard
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListBoxItem toCoppyListBoXItem = new ListBoxItem();
        List<Card> fullDeck = new List<Card>();

        public MainWindow()
        {
            InitializeComponent();
            fullDeck = MakeFullDeck();
            

            this.Deck_1.ItemsSource= fullDeck;

        }

        private void ListBoxItem_DoubleClicked(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListBox)
            {
                string Name = "";
                var objSender = sender as ListBox;
                Name = objSender.SelectedValue.ToString();
                var toRemove = fullDeck.Find(x => x.Name.Contains(Name));
                fullDeck.Remove(toRemove);
                this.Deck_1.ItemsSource = new List<Card>();
                this.Deck_1.ItemsSource = fullDeck;
            }
        }

        

        private void ButonShuffle_Clicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
      
        private void ButonReset_Clicked(object sender, RoutedEventArgs e)
        {
            fullDeck = MakeFullDeck();
            this.Deck_1.ItemsSource = new List<Card>();
            this.Deck_1.ItemsSource = fullDeck;
        }
        private void ButonEmpty_Clicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ButonSort_Clicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        ///<summary>
        ///This function create List of object Card for each item in ESuit*Evalue
        ///</summary>
        private  List<Card> MakeFullDeck()
        {
            List<Card> fDeck = new List<Card>();
            var counti = Enum.GetValues(typeof(ESuit)).Length;
            var countj = Enum.GetValues(typeof(EValue)).Length;
            for (int i = 0; i < counti; i++)
            {
                for (int j = 1; j < countj + 1; j++)
                {
                    fDeck.Add(new Card((EValue)j, (ESuit)i));
                }
            }
            return fDeck;
            
        }
    }
    
 
}

