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
	[Register ("ListViewController")]
	partial class ListViewController
	{
		[Outlet]
		UIKit.UITableView ListTableView { get; set; }

		[Outlet]
		UIKit.UILabel ListViewlbl { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ListViewlbl != null) {
				ListViewlbl.Dispose ();
				ListViewlbl = null;
			}

			if (ListTableView != null) {
				ListTableView.Dispose ();
				ListTableView = null;
			}
		}
	}
}
