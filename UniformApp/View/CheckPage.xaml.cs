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
    public sealed partial class CheckPage : Page
    {
        public static string ProcessOrderChoice { get; set; }

        public CheckPage()
        {
            this.InitializeComponent();
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            CheckPagePivot.SelectedIndex = 0;
        }

        private void WeightCheck_OnClick(object sender, RoutedEventArgs e)
        {
            CheckPagePivot.SelectedIndex = 1;
        }

        private void TasteCheck_OnClick(object sender, RoutedEventArgs e)
        {
            CheckPagePivot.SelectedIndex = 2;
        }

        private void LabelCheck_OnClick(object sender, RoutedEventArgs e)
        {
            CheckPagePivot.SelectedIndex = 3;
        }

        private void SampleCheck_OnClick(object sender, RoutedEventArgs e)
        {
            CheckPagePivot.SelectedIndex = 4;
        }

        private void ShiftCheck_OnClick(object sender, RoutedEventArgs e)
        {
            CheckPagePivot.SelectedIndex = 5;
        }

        private void TorqueCheck_OnClick(object sender, RoutedEventArgs e)
        {
            CheckPagePivot.SelectedIndex = 6;
        }

        private void PressureCheck_OnClick(object sender, RoutedEventArgs e)
        {
            CheckPagePivot.SelectedIndex = 7;
        }

        private void PETCheck_OnClick(object sender, RoutedEventArgs e)
        {
            CheckPagePivot.SelectedIndex = 8;
        }

        private void CompleteCheckButton_OnClick(object sender, RoutedEventArgs e)
        {
            CheckPagePivot.SelectedIndex = 9;
        }

        private void OpretKnap_OnClick_(object sender, RoutedEventArgs e)
        {
            CheckPagePivot.SelectedIndex = 0;
        }
    }
}
