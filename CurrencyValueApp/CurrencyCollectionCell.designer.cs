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

namespace CurrencyValueApp
{
    [Register ("CurrencyCollectionCell")]
    partial class CurrencyCollectionCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Buy { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Sell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TextLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Buy != null) {
                Buy.Dispose ();
                Buy = null;
            }

            if (Sell != null) {
                Sell.Dispose ();
                Sell = null;
            }

            if (TextLabel != null) {
                TextLabel.Dispose ();
                TextLabel = null;
            }
        }
    }
}