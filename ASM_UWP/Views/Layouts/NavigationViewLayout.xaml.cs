using ASM_UWP.ViewModels;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ASM_UWP.Views.Layout
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NavigationViewLayout : Page
    {
        public NavigationViewLayoutViewModel ViewModel;
        public NavigationViewLayout()
        {
            ViewModel = new NavigationViewLayoutViewModel();
            this.InitializeComponent();
        }

        private void BodyWrapper_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            bodyContent.Navigate(typeof(ArchivePost), args.InvokedItemContainer.Tag);
            titleArchivePost.Text = args.InvokedItemContainer.Content.ToString();
        }

        private void inputSearchBox_Submitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
        }

        private void BodyWrapper_Loaded(object sender, RoutedEventArgs e)
        {
            bodyContent.Navigate(typeof(ArchivePost), -1);
            titleArchivePost.Text = "Home";
        }
    }
}
