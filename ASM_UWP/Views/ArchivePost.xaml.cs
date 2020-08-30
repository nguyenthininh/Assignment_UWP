using ASM_UWP.Models;
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

namespace ASM_UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ArchivePost : Page
    {
        public ArchivePostViewModel ViewModel;
        public ArchivePost()
        {
            this.InitializeComponent();
            ViewModel = new ArchivePostViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var categoryID = e.Parameter;
            gridViewPost.ItemsSource = ViewModel.GetPostsCollection((int)categoryID);
        }

        private void gridViewPost_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(SinglePost), (e.ClickedItem as Post).ID);
        }
    }
}
