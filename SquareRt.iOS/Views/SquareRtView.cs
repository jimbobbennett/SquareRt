using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using SquareRt.Core.ViewModels;

namespace SquareRt.iOS.Views
{
   [MvxFromStoryboard]
   public partial class SquareRtView : MvxViewController
   {
      public SquareRtView(IntPtr handle) : base(handle)
      {
      }

      public override void ViewDidLoad()
      {
         base.ViewDidLoad();

         var set = this.CreateBindingSet<SquareRtView, SquareRtViewModel>();
         set.Bind(ResultLabel).To(vm => vm.Result).WithConversion("DoubleToString");
         set.Bind(NumberEntry).To(vm => vm.Number).WithConversion("DoubleToString");
         set.Apply();
      }
   }
}
