// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ListApp.iOS.Views.Main
{
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		UIKit.UIButton Loginbtn { get; set; }

		[Outlet]
		UIKit.UILabel Passwordlbl { get; set; }

		[Outlet]
		UIKit.UITextField Passwordtxt { get; set; }

		[Outlet]
		UIKit.UILabel Usernamelbl { get; set; }

		[Outlet]
		UIKit.UITextField Usernametxt { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Usernamelbl != null) {
				Usernamelbl.Dispose ();
				Usernamelbl = null;
			}

			if (Passwordlbl != null) {
				Passwordlbl.Dispose ();
				Passwordlbl = null;
			}

			if (Usernametxt != null) {
				Usernametxt.Dispose ();
				Usernametxt = null;
			}

			if (Passwordtxt != null) {
				Passwordtxt.Dispose ();
				Passwordtxt = null;
			}

			if (Loginbtn != null) {
				Loginbtn.Dispose ();
				Loginbtn = null;
			}
		}
	}
}
