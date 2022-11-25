using System;

using Foundation;
using ListApp.Core.Models;
using ListApp.Core.ViewModels.Main;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace ListApp.iOS.Views.Main
{
    public partial class ListViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString ("ListViewCell");
        public static readonly UINib Nib;

        static ListViewCell ()
        {
            Nib = UINib.FromName ("ListViewCell", NSBundle.MainBundle);

        }

        protected ListViewCell (IntPtr handle) : base (handle)
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<ListViewCell, FavListModel>();
                set.Bind(Newstitle).To(vm => vm.title);
                set.Bind(NewsDisc).To(vm => vm.description);
                set.Bind(ListImg).For(v => v.ImagePath).To(vm => vm.image_url);
                set.Bind(FavSwitch).To(t => t.IsFav);
                set.Apply();

                FavSwitch.ValueChanged += delegate
                {
                    if (FavSwitch.On)
                    {
                        Console.WriteLine("TRUE" );
                        

                    }
                    else
                    {
                        Console.WriteLine("FALSE");
                    }
                };
            });
            


        }

        
        
    }
}

