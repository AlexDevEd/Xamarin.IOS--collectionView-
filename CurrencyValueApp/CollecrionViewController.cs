using System;
using Foundation;
using UIKit;
using System.Collections.Generic;
using CoreGraphics;

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
               // TransitionAnimator transitionAnimator = new TransitionAnimator(controller, this);
                //controller.TransitioningDelegate = (IUIViewControllerTransitioningDelegate)transitionAnimator;

               // controller = (ChangeValueController)Storyboard.InstantiateViewController("ChangeController");
                // controller.ModalTransitionStyle = UIModalTransitionStyle.PartialCurl;
               // PresentViewController(controller, true, null);

                if (controller == null || cell == null)
                {
                    return;
                }
                
                controller.CurrencyNameValue = cell.CurrencyModel.TitleLeft;
                controller.SellingPriceValue = cell.CurrencyModel.TitleSell;
                controller.PurchasePriceValue = cell.CurrencyModel.TitleBuy;
             
               // PresentViewController(controller, true, null);

            }
        
    }
       
    }
}