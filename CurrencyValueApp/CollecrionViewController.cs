using System;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace CurrencyValueApp
{
    public partial class CollecrionViewController : UICollectionViewController
    {
        
        public CollecrionViewController(IntPtr handle) : base(handle)
        {
        }
       
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
           
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
      
        public override void PrepareForSegue(UIStoryboardSegue segue,
            Foundation.NSObject sender)              
        {
            base.PrepareForSegue(segue, sender);

            if (segue.Identifier == "toSecondView")
            {
                var controller = segue.DestinationViewController as ChangeValueController;
                var cell = sender as CurrencyCollectionCell;

                if (controller == null || cell == null)
                {
                    return;
                }
                
                controller.CurrencyNameValue = cell.CurrencyModel.TitleLeft;
                controller.SellingPriceValue = cell.CurrencyModel.TitleSell;
                controller.PurchasePriceValue = cell.CurrencyModel.TitleBuy;
            }
            if (segue.Identifier == "toSecondView")
            {
                ChangeValueController callMVController = segue.DestinationViewController as ChangeValueController;
            }
        }
    }
}