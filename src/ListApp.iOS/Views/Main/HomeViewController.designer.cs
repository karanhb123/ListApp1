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
	[Register ("HomeViewController")]
	partial class HomeViewController
	{
		[Outlet]
		UIKit.UIButton FavoritesBtn { get; set; }

		[Outlet]
		UIKit.UILabel Homelbl { get; set; }

		[Outlet]
		UIKit.UIButton ListViewBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ListViewBtn != null) {
				ListViewBtn.Dispose ();
				ListViewBtn = null;
			}

			if (FavoritesBtn != null) {
				FavoritesBtn.Dispose ();
				FavoritesBtn = null;
			}

			if (Homelbl != null) {
				Homelbl.Dispose ();
				Homelbl = null;
			}
		}
	}
}
