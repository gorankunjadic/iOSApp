// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace App1
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Dugme { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Napisano { get; set; }

        [Action ("Dugme_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Dugme_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Dugme != null) {
                Dugme.Dispose ();
                Dugme = null;
            }

            if (Napisano != null) {
                Napisano.Dispose ();
                Napisano = null;
            }
        }
    }
}