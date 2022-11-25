using System;
using ListApp.Core.ViewModels.Main;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace ListApp.iOS.Views.Main
{
    public partial class HomeViewController : MvxViewController<HomeViewModel>
    {
        public override void ViewDidLoad()
        {

            base.ViewDidLoad();
            homeprint();
            Console.WriteLine("entred Home view");
            ListViewBtn.AddTarget(ListViewButtonClicked, UIControlEvent.TouchUpInside);
            FavoritesBtn.AddTarget(FavoritesButtonClicked, UIControlEvent.TouchUpInside);
           


            //homelbl.Text = "welcome to home page " + Constant.Username + ".";
        }

        private void FavoritesButtonClicked(object sender, EventArgs e)
        {
            ViewModel.FavListView.Execute(true);
        }
        private void ListViewButtonClicked(object sender, EventArgs e)
        {
            ViewModel.ListView.Execute(true);
        }

        public void homeprint()
        {
            Console.WriteLine("successfully Logged In");
        }
        //constructer parameter



    }
}


