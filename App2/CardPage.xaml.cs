using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class CardPage : Page
    {
        public CardPage()
        {
            this.InitializeComponent();
        }

        private async void Damabutton_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Дама", "Внимание");
            await msgbox.ShowAsync();
        }

        private async void Valetbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Валет", "Внимание");
            await msgbox.ShowAsync();
        }

        private async void Kingbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Король", "Внимание");
            await msgbox.ShowAsync();
        }

        private async void Abutton_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Туз", "Внимание");
            await msgbox.ShowAsync();
        }

        private async void Bbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Бубны", "Внимание");
            await msgbox.ShowAsync();
        }

        private async void Pbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Пики", "Внимание");
            await msgbox.ShowAsync();
        }

        private async void Cbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Чирвы", "Внимание");
            await msgbox.ShowAsync();
        }

        private async void Tbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msgbox = new MessageDialog("Трефы", "Внимание");
            await msgbox.ShowAsync();
        }
    }
}
