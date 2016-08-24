using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class CardPage : Page
    {
        public BitmapImage img = new BitmapImage();
        public string value="";
        public string suit="";
        bool set_def_img = true;
        public CardPage()
        {
            this.InitializeComponent();
            
        }

        private void ladybutton_Click(object sender, RoutedEventArgs e)
        {
            
            value = "lady";
        }

        private void jackbutton_Click(object sender, RoutedEventArgs e)
        {
            value = "jack";
        }

        private void Kingbutton_Click(object sender, RoutedEventArgs e)
        {
            value = "king";
        }

        private void Abutton_Click(object sender, RoutedEventArgs e)
        {
            value = "ace";
        }

        private void Bbutton_Click(object sender, RoutedEventArgs e)
        {
            suit = "b";
        }

        private void Pbutton_Click(object sender, RoutedEventArgs e)
        {
            suit = "p";
        }

        private void Cbutton_Click(object sender, RoutedEventArgs e)
        {
            suit = "c";
        }

        private void Tbutton_Click(object sender, RoutedEventArgs e)
        {
            suit = "t";
        }

        private void Showbutton_Click(object sender, RoutedEventArgs e)
        {
            if (set_def_img && value!="" && suit!="")
            {
                switch (value)
                {
                    case "lady":
                        {
                            switch (suit)
                            {
                                case "b":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/QD.png");
                                        break;
                                    }
                                case "p":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/QS.png");
                                        break;
                                    }
                                case "c":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/QH.png");
                                        break;
                                    }
                                case "t":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/QC.png");
                                        break;
                                    }

                            }
                            break;
                        }
                    case "king":
                        {
                            switch (suit)
                            {
                                case "b":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/KD.png");
                                        break;
                                    }
                                case "p":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/KS.png");
                                        break;
                                    }
                                case "c":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/KH.png");
                                        break;
                                    }
                                case "t":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/KC.png");
                                        break;
                                    }
                            }
                            break;
                        }
                    case "jack":
                        {
                            switch (suit)
                            {
                                case "b":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/JD.png");
                                        break;
                                    }
                                case "p":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/JS.png");
                                        break;
                                    }
                                case "c":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/JH.png");
                                        break;
                                    }
                                case "t":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/JC.png");
                                        break;
                                    }
                            }
                            break;
                        }
                    case "ace":
                        {
                            switch (suit)
                            {
                                case "b":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/AD.png");
                                        break;
                                    }
                                case "p":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/AS.png");
                                        break;
                                    }
                                case "c":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/AH.png");
                                        break;
                                    }
                                case "t":
                                    {
                                        img.UriSource = new Uri("ms-appx:///Assets/CardFolder/AC.png");
                                        break;
                                    }
                            }
                            break;
                        }
                    default: break;
                }
                CardImage.Source = img;
                set_def_img = false;
            }
            else
            {
                set_def_img = true;
                img.UriSource = new Uri("ms-appx:///Assets/CardFolder/2.png");
                suit = "";
                value = "";

            }
        }
    }
}
