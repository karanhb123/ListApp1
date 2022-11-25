using System;
using System.ComponentModel;
using Foundation;
using ListApp.Core.ViewModels.Main;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace ListApp.iOS.Views.Main
{
    public partial class ListViewController : MvxViewController<ListViewModel>
    {
        public ListViewModel _model;
        public ListViewController () : base ("ListViewController", null)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            ViewModel.getnews.Execute(true);
            _model = (ListViewModel)ViewModel;
            var datasource = new TableSource(ListTableView, _model);
            ListTableView.Source = datasource;
            ViewModel.getnews.Execute(true);
            MvxFluentBindingDescriptionSet<ListViewController, ListViewModel> set = this.CreateBindingSet<ListViewController, ListViewModel>();
            set.Bind(datasource).To(vm => vm.NewsList);
            set.Apply();


            _model.PropertyChanged += _model_PropertyChanged;

            
            // Perform any additional setup after loading the view, typically from a nib.
        }

        private void _model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            ListTableView.ReloadData();

        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
        public class TableSource : MvxTableViewSource
        {

            ListViewModel Viewmodel;
            public TableSource(UITableView tableView, ListViewModel news2)
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

                Console.WriteLine("enterd table view source");
                return (UITableViewCell)tableView.DequeueReusableCell(ListViewCell.Key, indexPath);
            }
        }
    }
}


