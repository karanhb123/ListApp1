using System;
using Foundation;
using System.ComponentModel;
using ListApp.Core.ViewModels.Main;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace ListApp.iOS.Views.Main
{
    public partial class FavListViewController : MvxViewController<FavListViewModel>
    {
        public FavListViewModel _model;
        public FavListViewController() : base("FavListViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ViewModel.GetFav.Execute(true);

            _model = (FavListViewModel)ViewModel;

            var datasource = new TableSource(FavTableView, _model);

            FavTableView.Source = datasource;

            ViewModel.GetFav.Execute(true);

            MvxFluentBindingDescriptionSet<FavListViewController, FavListViewModel> set = this.CreateBindingSet<FavListViewController, FavListViewModel>();
            set.Bind(datasource).To(vm => vm.FavList1);
            set.Apply();

            _model.PropertyChanged += _model_PropertyChanged;


            // Perform any additional setup after loading the view, typically from a nib.
        }

        private void _model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            FavTableView.ReloadData();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
        public class TableSource : MvxTableViewSource
        {

            FavListViewModel Viewmodel;
            public TableSource(UITableView tableView, FavListViewModel news2)
                : base(tableView)
            {
                UseAnimations = true;
                AddAnimation = UITableViewRowAnimation.Top;
                RemoveAnimation = UITableViewRowAnimation.Middle;
                Viewmodel = news2;
                tableView.RegisterNibForCellReuse(UINib.FromName(ListViewCell.Key, NSBundle.MainBundle), ListViewCell.Key);

            }

            protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath,
                                                                  object item)
            {

                Console.WriteLine("enterd fav table view source");
                return (UITableViewCell)tableView.DequeueReusableCell(ListViewCell.Key, indexPath);
            }
        }
    }
}


