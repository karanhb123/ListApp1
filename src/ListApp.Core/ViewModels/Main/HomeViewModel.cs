using System;
using MvvmCross.Navigation;

namespace ListApp.Core.ViewModels.Main
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService mvxNavigationService;
        public HomeViewModel(IMvxNavigationService navigationService)
        {
            mvxNavigationService = navigationService;
        }

    }
}

