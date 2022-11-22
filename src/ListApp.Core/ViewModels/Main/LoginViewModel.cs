using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace ListApp.Core.ViewModels.Main
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;//= Preferences.Get(Constant.Constant.Username, "");
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }
        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private readonly IMvxNavigationService mvxNavigationService;
        public LoginViewModel(IMvxNavigationService navigationService)
        {
            mvxNavigationService = navigationService;
        }

        public ICommand LogIn => new MvxCommand<bool>(async (fromLoginInButton) =>
        {
            navigatehome();
        });
        public void navigatehome()
        {
            

            Console.WriteLine("enterd login view model " + Username);
            mvxNavigationService.Navigate<HomeViewModel>();



        }
    }
}
