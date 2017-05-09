using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace SquareRt.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            
            Mvx.ConstructAndRegisterSingleton<ISquareRtCalculator, SquareRtCalculator>();

            RegisterAppStart<ViewModels.SquareRtViewModel>();
        }
    }
}
