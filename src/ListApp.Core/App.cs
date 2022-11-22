using MvvmCross.IoC;
using MvvmCross.ViewModels;
using ListApp.Core.ViewModels.Main;

namespace ListApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<LoginViewModel>();
        }
    }
}
