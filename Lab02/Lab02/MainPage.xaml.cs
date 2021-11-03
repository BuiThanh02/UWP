using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Lab02.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab02
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Pages.Home));
            var item1 = new MenuItem() { Name = "Home", MenuPage = "homepage", Icon = "\uE80F" };
            var item2 = new MenuItem() { Name = "Contact", MenuPage = "contact", Icon = "\uE946" };
            var item3 = new MenuItem() { Name = "Customer", MenuPage = "customer", Icon = "\uE946" };
            var item4 = new MenuItem() { Name = "Mail", MenuPage = "mail", Icon = "\uE946" };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            Menu.Items.Add(item4);
        }
        private void IconClick_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)Menu.SelectedItem;// item mà được chọn để nhấn vào
            switch (selected.MenuPage)
            {
                case "homepage": MainFrame.Navigate(typeof(Pages.Home)); break;
                case "contact": MainFrame.Navigate(typeof(Pages.Contact)); break;
                case "customer": MainFrame.Navigate(typeof(Pages.Customer)); break;
                case "mail": MainFrame.Navigate(typeof(Pages.Mail)); break;
            }
        }
    }
}
