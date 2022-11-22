using System;
using ListApp.Core.ViewModels.Main;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace ListApp.iOS.Views.Main
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class LoginViewController : MvxViewController<LoginViewModel>
    {
        [Obsolete]
        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            Usernametxt.LeftViewMode = UITextFieldViewMode.Always;
            //UsernameField.LeftView = DesignEdgeViewForTextFields("UserNameIcon", false, false);
            //UsernameField.ShouldReturn += TextFieldShouldReturn;
            //Usernametxt.Placeholder = Constant.Username;

            Passwordtxt.LeftViewMode = UITextFieldViewMode.Always;
            //UsernameField.LeftView = DesignEdgeViewForTextFields("UserNameIcon", false, false);
            //UsernameField.ShouldReturn += TextFieldShouldReturn;
            //Passwordtxt.Placeholder = Constant.Password;

            MvxFluentBindingDescriptionSet<LoginViewController, LoginViewModel> set = this.CreateBindingSet<LoginViewController, LoginViewModel>();
            set.Bind(Usernametxt).To(t => t.Username);
            set.Bind(Usernametxt).To(t => t.Password);

            set.Apply();

            Loginbtn.AddTarget(LogInButtonClicked, UIControlEvent.TouchUpInside);

            // Perform any additional setup after loading the view, typically from a nib.
        }

        [Obsolete]
        private void LogInButtonClicked(object sender, EventArgs e)
        {
            View.EndEditing(true);
            if (Usernametxt.Text == "Karan" && Passwordtxt.Text == "1234")
            {
                ViewModel.LogIn.Execute(true);

            }
            else
            {
                var avAlert = new UIAlertView("Incorrect Credentials", "", null, "OK", null);
                avAlert.Show();
            }
        }
        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


