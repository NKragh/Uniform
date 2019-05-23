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
using UniformApp.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UniformApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProcessOrderPage : Page
    {
        public static int ColumnChoice { get; set; }
        
        public ProcessOrderPage()
        {
            this.InitializeComponent();
            ContentPivot.SelectedIndex = 0;
        }
        
        private void NewButton_OnClick(object sender, RoutedEventArgs e)
        {
            ContentPivot.SelectedIndex = 1;
        }

        private void ExistingButton_OnClick(object sender, RoutedEventArgs e)
        {
            ContentPivot.SelectedIndex = 2;
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            ContentPivot.SelectedIndex = 0;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(CheckPage));
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string choiceStr = e.Parameter as string;
            ColumnChoice = int.Parse(choiceStr);
            base.OnNavigatedTo(e);
        }
    }
}
