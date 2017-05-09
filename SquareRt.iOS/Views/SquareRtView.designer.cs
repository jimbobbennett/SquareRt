// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace SquareRt.iOS.Views
{
    [Register ("SquareRtView")]
    partial class SquareRtView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NumberEntry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ResultLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (NumberEntry != null) {
                NumberEntry.Dispose ();
                NumberEntry = null;
            }

            if (ResultLabel != null) {
                ResultLabel.Dispose ();
                ResultLabel = null;
            }
        }
    }
}