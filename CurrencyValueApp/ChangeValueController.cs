using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace CurrencyValueApp
{
    public partial class ChangeValueController : UIViewController
    {
        public string CurrencyNameValue = "";
        public float SellingPriceValue = 0;
        public float PurchasePriceValue = 0;

        public ChangeValueController (IntPtr handle) : base (handle)
        {
           
        }
        
            
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            NameValue.Text = CurrencyNameValue;
            SellPrice.Text = SellingPriceValue.ToString();
            BuyPrice.Text = PurchasePriceValue.ToString();

            btnBuy.TouchUpInside -= BuyTouch;
            btnBuy.TouchUpInside += BuyTouch;

            btnSell.TouchUpInside -= SellTouch;
            btnSell.TouchUpInside += SellTouch;
        }

        void BuyTouch(object sender, EventArgs args)
        {
            float userInputFloat = 0;

            try
            {
                userInputFloat = Convert.ToSingle(UserValue.Text);
            }
            catch (Exception ex)
            {
            }

            var result = userInputFloat * PurchasePriceValue;

            ResultValue.Text = result.ToString();
        }

        void SellTouch(object sender, EventArgs args)
        {
            float userInputFloat = 0;

            try
            {
                userInputFloat = Convert.ToSingle(UserValue.Text);
            }
            catch (Exception ex)
            {
            }

            var result = userInputFloat * SellingPriceValue;

            ResultValue.Text = result.ToString();
        }


    }
}