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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Autofac;
using MdevconUniversal.Common.Domain;

namespace MdevconUniversal.ViewModels
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageViewModel _mainPageViewModel;

        public MainPage()
        {
            var container = App.Container;
            _mainPageViewModel = container.Resolve<MainPageViewModel>();
            DataContext = _mainPageViewModel;
            Loaded += (_, __) => _mainPageViewModel.ViewLoaded();
            this.InitializeComponent();
        }


        private void OnLectureItemTapped(object sender, TappedRoutedEventArgs e)
        {
            _mainPageViewModel.OpenLecture((sender as FrameworkElement).DataContext as Lecture);
        }
    }
}
