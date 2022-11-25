using System;
using ListApp.Core.Models;
using System.Collections.Generic;
using MvvmCross.Commands;
using System.Windows.Input;
using ListApp.Core.Service;
using System.Linq;

namespace ListApp.Core.ViewModels.Main
{
    public class FavListViewModel:BaseViewModel
    {
        public FavListViewModel()
        {
        }
        private List<FavListModel> _FavList1;
        public List<FavListModel> FavList1
        {
            get => _FavList1;
            set => SetProperty(ref _FavList1, value);
        }
        public ICommand GetFav => new MvxCommand<bool>(async (fromSignInButton) =>
        {
            GetFavList();

        });

        public  void  GetFavList()
        {
            var ret = new ListViewModel();
            var NewsList = ret.FavList;
            var item = new FavListModel();
            
            FavList1 = NewsList.Where(t => t.IsFav == true).ToList();
        }
    }
}

