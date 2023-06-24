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

        private void createNewItembox(ListBoxItem itemBox, string name)
        {
            toCoppyListBoXItem.Content = name;
            toCoppyListBoXItem.HorizontalAlignment = HorizontalAlignment.Center;
            toCoppyListBoXItem.VerticalAlignment = VerticalAlignment.Top;
            toCoppyListBoXItem.MouseDoubleClick += ListBoxItem_DoubleClicked;
        }
        public MainWindow()
        {
            InitializeComponent();
            var counti  = Enum.GetValues(typeof(ESuit)).Length;
            var countj = Enum.GetValues(typeof(EValue)).Length;
            
            for (int i = 0; i < counti; i++)
            {
                for(int j = 0;j < countj; j++)
                {
                    fullDeck.Add(new Card((EValue)j, (ESuit)i));
                }
            }
            //createNewItembox(toCoppyListBoXItem,"Karta_2");
            //Deck_1.Items.Add(toCoppyListBoXItem);
            
            this.Deck_1.ItemsSource = fullDeck;
            
                //.DisplayMember = "Name";


        }

        private void ListBoxItem_DoubleClicked(object sender, MouseButtonEventArgs e)
        {
            
            
                Debug.WriteLine("DubleClicked!!");
            
            
        }

        

        private void ButonShuffle_Clicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ButonReset_Clicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ButonEmpty_Clicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ButonSort_Clicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    /*
    void function()
    {
        throw new NotImplementedException();
    }
    */
}

