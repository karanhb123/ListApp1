using System;
using MvvmCross.Commands;
using System.Windows.Input;
using MvvmCross.Navigation;
using Xamarin.Essentials;
using MvvmCross.Plugin.Messenger;
using ListApp.Core.Models;
using ListApp.Core.Service;

namespace ListApp.Core.ViewModels.Main
{
    public class HomeViewModel : BaseViewModel
    {
        public Action<Messaging> UpdatePopOverIOS { get; set; }
        private readonly IMvxMessenger mvxMessenger;
        private readonly IMvxNavigationService mvxNavigationService;
        private bool isOnline;
        public bool IsOnline
        {
            get => isOnline;
            set
            {
                isOnline = value;
                RaisePropertyChanged();
            }
        }


       
        public HomeViewModel(IMvxNavigationService navigationService, IMvxMessenger _mvxMessenger)
        {

            mvxNavigationService = navigationService;
            mvxMessenger = _mvxMessenger;

            Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;

        }

       

        public ICommand ListView => new MvxCommand<bool>(async (ListViewButtonClicked) =>
        {
            await mvxNavigationService.Navigate<ListViewModel>();


        });
        public ICommand FavListView => new MvxCommand<bool>(async (ListViewButtonClicked) =>
        {
            await mvxNavigationService.Navigate<FavListViewModel>();


        });
        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (e.NetworkAccess == NetworkAccess.Internet)
            {
                IsOnline = true;
                mvxMessenger.Publish<Messaging>(new Messaging(this) { Errormsg = "You are Online!!" });
                UpdatePopOverIOS?.Invoke(new Messaging(this) { Errormsg = "You are Online!!" });

            }
            else
            {
                IsOnline = false;
                mvxMessenger.Publish<Messaging>(new Messaging(this) { Errormsg = "You are Offline!!" });
                UpdatePopOverIOS?.Invoke(new Messaging(this) { Errormsg = "You are Offline!!" });


            }
        }
    }
}

