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
            ShakeIt(BuyPrice);
            CustomAnimations.Pop(SellPrice,3,2,3);
            CreateLabelAnimation(NameValue);

            btnBuy.TouchUpInside -= BuyTouch;
            btnBuy.TouchUpInside += BuyTouch;

            btnSell.TouchUpInside -= SellTouch;
            btnSell.TouchUpInside += SellTouch;
        }

        void BuyTouch(object sender, EventArgs args)
        {
            float userInputFloat = 0;
            //ShakeIt(btnBuy);

            CustomAnimations.RotateToAngle(btnBuy,30,3,CustomAnimations.UIViewAnimationRotationDirection.Right,1,true);

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
            CustomAnimations.FlipWithDuration(btnSell,5.5,CustomAnimations.UIViewAnimationFlipDirection.Bottom,1,false);
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
        public static void ShakeIt(UIView label, float Duration = 0.05f, int RepeatCount = 60, float MovementDistance = 2f, string AnimationKey = "position")
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
            //CABasicAnimation theAnimation = new CABasicAnimation();
            CABasicAnimation[] theAnimation = new CABasicAnimation[2];
            
             var position = new CABasicAnimation();
            position.KeyPath = animationPositionKey;
             position.SetFrom(NSValue.FromCGPoint(new CGPoint(182, 342)));
             position.SetTo(NSValue.FromCGPoint(new CGPoint(182, 400)));
             position.Duration = 1.0;
             position.BeginTime = 0.1;
             position.AutoReverses = true;
            resultValue.TextColor = UIColor.White;
            resultValue.TextAlignment = UITextAlignment.Center;       
            theAnimation.Append(position);
            //resultValue.Layer.AddAnimation(position, animationPositionKey);

            CABasicAnimation heightAnimation = new CABasicAnimation();
            heightAnimation.KeyPath = animationSizeKey1;
            heightAnimation.AutoReverses = true;          
            heightAnimation.SetFrom(NSValue.FromCGSize(new CGSize(97, 30)));
            heightAnimation.SetTo(NSValue.FromCGSize(new CGSize(97, 80)));
            heightAnimation.Duration = 10.0;
            resultValue.TextColor = UIColor.Red;
            resultValue.TextAlignment = UITextAlignment.Center;
            heightAnimation.BeginTime = 5.0;
            theAnimation.Append(heightAnimation);
            //resultValue.Layer.AddAnimation(heightAnimation, animationSizeKey1);

              CAAnimationGroup group = new CAAnimationGroup();
              group.Duration = 10.0;
              group.Animations = theAnimation;
              resultValue.Layer.AddAnimation(group, null); 
        }
        // _animationButton.frame.size.height
        public override CAAnimation AnimationForSeries(TKChart chart, TKChartSeries series, TKChartSeriesRenderState state, CGRect rect)
        {
            double duration = 0;
            List<CAAnimation> animations = new List<CAAnimation>();
            for (int i = 0; i < (int)state.Points.Count; i++)
            {
                string pointKeyPath = state.AnimationKeyPathForPointAtIndex((uint)i);

                string keyPath = string.Format("{0}.distanceFromCenter", pointKeyPath);
                CAKeyFrameAnimation a = CAKeyFrameAnimation.GetFromKeyPath(keyPath);
                a.Values = new NSNumber[] { new NSNumber(50), new NSNumber(50), new NSNumber(0) };
                a.KeyTimes = new NSNumber[] { new NSNumber(0), new NSNumber(i / (i + 1.0)), new NSNumber(1) };
                a.Duration = 0.3 * (i + 1.1);
                animations.Add(a);

                keyPath = string.Format("{0}.opacity", pointKeyPath);
                a = CAKeyFrameAnimation.GetFromKeyPath(keyPath);
                a.Values = new NSNumber[] { new NSNumber(0), new NSNumber(0), new NSNumber(1) };
                a.KeyTimes = new NSNumber[] { new NSNumber(0), new NSNumber(i / (i + 1.0)), new NSNumber(1) };
                a.Duration = 0.3 * (i + 1.1);
                animations.Add(a);

                duration = a.Duration;
            }
            CAAnimationGroup g = new CAAnimationGroup();
            g.Duration = duration;
            g.Animations = animations.ToArray();
            return g;
        }

    }
}