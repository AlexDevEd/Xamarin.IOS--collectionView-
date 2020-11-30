using CoreAnimation;
using CoreGraphics;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;

namespace CurrencyValueApp
{
    public partial class ChangeValueController : UIViewController
    {
        public string CurrencyNameValue = "";
        public float SellingPriceValue = 0;
        public float PurchasePriceValue = 0;
        
        public ChangeValueController(IntPtr handle) : base(handle)
        {

        }     

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            NameValue.Text = CurrencyNameValue;
            SellPrice.Text = SellingPriceValue.ToString();
            BuyPrice.Text = PurchasePriceValue.ToString();
            CreateLabelAnimation(BuyPrice);
            CreateLabelAnimation(SellPrice);

            btnBuy.TouchUpInside -= BuyTouch;
            btnBuy.TouchUpInside += BuyTouch;

            btnSell.TouchUpInside -= SellTouch;
            btnSell.TouchUpInside += SellTouch;
        }

        void BuyTouch(object sender, EventArgs args)
        {
            float userInputFloat = 0;
            ShakeIt(btnBuy);
            try
            {
                userInputFloat = Convert.ToSingle(UserValue.Text);
            }
            catch (Exception ex)
            {
            }

            var result = userInputFloat * PurchasePriceValue;

            ResultValue.Text = result.ToString();
            CreateResultPositionAndSizeAnimation(ResultValue);
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
            CreateResultAnimation(ResultValue);
           
        }
        /* public void CreateResultAnimation(UITextField resultValue)
         {

             UIView.Animate(1.5, 0.5, UIViewAnimationOptions.Autoreverse,
                         () =>
                         {
                             resultValue.Frame = new CGRect(x: 0, y: 0, width: 250, height: 80);                         
                             //resultValue.Center = View.Center;
                             resultValue.TextColor = UIColor.White;
                             resultValue.Transform = CGAffineTransform.MakeRotation(360);
                         }, ()=>
                         {
                             resultValue.Frame = 
                             resultValue.Frame = new CGRect(x: 134, y: 319, width: 97, height: 30);
                             //resultValue.Center = View.Center;
                             resultValue.TextColor = UIColor.Red;
                            // resultValue.Transform = CGAffineTransform.MakeRotation(0);

                         }
                         );         
         }  */


        public static void CreateLabelAnimation(UILabel label)
        {
            UIView.Animate(1.5, 0.5, UIViewAnimationOptions.Repeat,
            () =>
            {
                label.Transform = CGAffineTransform.MakeScale(1f, 1f);
            }, null);

            UIView.Animate(1.5, 1, UIViewAnimationOptions.Repeat,
            () =>
            {
                label.Transform = CGAffineTransform.MakeScale(2f, 2f);
            }, null);
            UIView.Animate(1.5, 0.5, UIViewAnimationOptions.Repeat,
            () =>
            {
                label.Transform = CGAffineTransform.MakeScale(1f, 1f);
            }, null);



        }
        public static void ShakeIt(UIButton label, float Duration = 0.05f, int RepeatCount = 60, float MovementDistance = 2f, string AnimationKey = "position")
        {
            CABasicAnimation animation = new CABasicAnimation();
            animation.Duration = Duration;
            animation.RepeatCount = RepeatCount;
            animation.AutoReverses = true;
            animation.SetFrom(NSValue.FromCGPoint(new CGPoint(label.Center.X - MovementDistance, label.Center.Y - MovementDistance)));
            animation.SetTo(NSValue.FromCGPoint(new CGPoint(label.Center.X + MovementDistance, label.Center.Y + MovementDistance)));
            label.Layer.AddAnimation(animation, AnimationKey);
        }
        public void CreateResultAnimation(UITextField resultValue, string AnimationKey = "position")
        {           
            var theAnimation = new CABasicAnimation();
            theAnimation.Duration = 3.0;
            theAnimation.SetFrom(NSValue.FromCGPoint(new CGPoint(182, 342)));
            theAnimation.SetTo(NSValue.FromCGPoint(new CGPoint(182, 400)));
            theAnimation.AutoReverses = true;
            resultValue.Layer.AddAnimation(theAnimation, AnimationKey);
        }

        public void CreateResultPositionAndSizeAnimation(UITextField resultValue,string animationPositionKey = "position", string animationSizeKey1 = "bounds.size")
        {
            CABasicAnimation theAnimation = new CABasicAnimation();
            //CABasicAnimation[] theAnimation = new CABasicAnimation[2];
            
             var position = new CABasicAnimation();
             position.SetFrom(NSValue.FromCGPoint(new CGPoint(182, 342)));
             position.SetTo(NSValue.FromCGPoint(new CGPoint(182, 400)));
             position.Duration = 5.0;
             //position.BeginTime = 0.0;
             position.AutoReverses = true;
            resultValue.TextColor = UIColor.White;
            resultValue.TextAlignment = UITextAlignment.Center;       
            //theAnimation.Append(position);
            resultValue.Layer.AddAnimation(position, animationPositionKey);

            CABasicAnimation heightAnimation = new CABasicAnimation();
            heightAnimation.AutoReverses = true;          
            heightAnimation.SetFrom(NSValue.FromCGSize(new CGSize(97, 30)));
            heightAnimation.SetTo(NSValue.FromCGSize(new CGSize(97, 80)));
            heightAnimation.Duration = 5.0;
            resultValue.TextColor = UIColor.Red;
            resultValue.TextAlignment = UITextAlignment.Center;
            //heightAnimation.BeginTime = 5.0;
            //theAnimation.Append(heightAnimation);
            resultValue.Layer.AddAnimation(heightAnimation, animationSizeKey1);

            /*  CAAnimationGroup group = new CAAnimationGroup();
              group.Duration = 10.0;
              group.Animations = theAnimation;
              resultValue.Layer.AddAnimation(group, null); */
        }
        // _animationButton.frame.size.height
       
     
    }
}