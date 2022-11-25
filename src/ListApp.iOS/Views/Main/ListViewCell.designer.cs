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
	[Register ("ListViewCell")]
	partial class ListViewCell
	{
		[Outlet]
		UIKit.UISwitch FavSwitch { get; set; }

		[Outlet]
        FFImageLoading.Cross.MvxCachedImageView ListImg { get; set; }

		[Outlet]
		UIKit.UITextView NewsDisc { get; set; }

		[Outlet]
		UIKit.UILabel Newstitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ListImg != null) {
				ListImg.Dispose ();
				ListImg = null;
			}

			if (NewsDisc != null) {
				NewsDisc.Dispose ();
				NewsDisc = null;
			}

			if (Newstitle != null) {
				Newstitle.Dispose ();
				Newstitle = null;
			}

			if (FavSwitch != null) {
				FavSwitch.Dispose ();
				FavSwitch = null;
			}
		}
	}
}
