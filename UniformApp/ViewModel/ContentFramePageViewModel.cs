using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using GalaSoft.MvvmLight.Command;

namespace UniformApp.ViewModel
{
    class ContentFramePageViewModel
    {
        public ICommand NavigateColumnCommand { get; set; }

        public ContentFramePageViewModel()
        {
        }
        void ContentFrameNavigateColumn(object sender, RoutedEventArgs routedEventArgs)
        {
            if (sender is Button button)
            {
                var choice = button.Tag;

                switch (choice)
                {
                    case "1":
                        //ContentFrame.Navigate(typeof(FrontPage));
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    case "10":
                        break;
                    case "11":
                        break;
                    case "12":
                        break;
                    default:
                        throw new NullReferenceException();
                }
            }
        }
    }
}
