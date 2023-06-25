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
        Random random = new Random();
        List<Card> fullDeck = new List<Card>();
        List<Card> List_Hand = new List<Card>();

        public MainWindow()
        {
            InitializeComponent();
            fullDeck = MakeFullDeck();
            this.Deck_1.ItemsSource= fullDeck;
            this.Deck_2.ItemsSource = List_Hand;

        }

        private void ListBoxItem_DoubleClicked(object sender, MouseButtonEventArgs e)
        {
            ListBox Sender = sender as ListBox;
            if(Sender.Name == "Deck_1")
            {
                string Name = "";
                Name = Sender.SelectedValue.ToString();
                var toRemove = fullDeck.Find(x => x.Name.Contains(Name));
                List_Hand.Add(toRemove);
                fullDeck.Remove(toRemove);
                this.Deck_1.ItemsSource = new List<Card>();
                this.Deck_1.ItemsSource = fullDeck;
                this.Deck_2.ItemsSource = new List<Card>();
                this.Deck_2.ItemsSource = List_Hand;
            }
            else if(Sender.Name =="Deck_2")
            {
                string Name = "";
                Name = Sender.SelectedValue.ToString();
                var toRemove = List_Hand.Find(x => x.Name.Contains(Name));
                fullDeck.Add(toRemove);
                List_Hand.Remove(toRemove);
                this.Deck_1.ItemsSource = new List<Card>();
                this.Deck_1.ItemsSource = fullDeck;
                this.Deck_2.ItemsSource = new List<Card>();
                this.Deck_2.ItemsSource = List_Hand;
            }
        }

        

        private void ButonShuffle_Clicked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < fullDeck.Count; i++)
            {
                int raddom = random.Next(fullDeck.Count);
                Card temp = fullDeck.ElementAt(raddom);
                fullDeck[raddom] = fullDeck[i];
                fullDeck[i] = temp;
            }
            this.Deck_1.ItemsSource = new List<Card>();
            this.Deck_1.ItemsSource = fullDeck;

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

