using Foundation;
using MvvmCross.Platforms.Ios.Core;
using ListApp.Core;

namespace ListApp.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
