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
            //homelbl.Text = "welcome to home page " + Constant.Username + ".";
        }
        public void homeprint()
        {
            Console.WriteLine("successfully Logged In");
        }
        //constructer parameter



    }
}


