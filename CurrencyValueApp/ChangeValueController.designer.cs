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
    [Register ("ChangeValueController")]
    partial class ChangeValueController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnBuy { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BuyPrice { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        CurrencyValueApp.ChangeValueView ChangeValueView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NameValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ResultValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SellPrice { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField UserValue { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnBuy != null) {
                btnBuy.Dispose ();
                btnBuy = null;
            }

            if (btnSell != null) {
                btnSell.Dispose ();
                btnSell = null;
            }

            if (BuyPrice != null) {
                BuyPrice.Dispose ();
                BuyPrice = null;
            }

            if (ChangeValueView != null) {
                ChangeValueView.Dispose ();
                ChangeValueView = null;
            }

            if (NameValue != null) {
                NameValue.Dispose ();
                NameValue = null;
            }

            if (ResultValue != null) {
                ResultValue.Dispose ();
                ResultValue = null;
            }

            if (SellPrice != null) {
                SellPrice.Dispose ();
                SellPrice = null;
            }

            if (UserValue != null) {
                UserValue.Dispose ();
                UserValue = null;
            }
        }
    }
}