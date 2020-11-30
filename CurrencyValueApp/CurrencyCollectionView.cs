using System;
using UIKit;
using System.Collections.Generic;
using Foundation;

namespace CurrencyValueApp
{
        public partial class CurrencyCollectionView : UICollectionView
        {
        
            public CurrencyCollectionView(IntPtr handle) : base(handle)
            {
            }

            public override void AwakeFromNib()
            {
                base.AwakeFromNib();

            // Initialize
            DataSource = new CollectionSource(this);           
            //Delegate = new CollectionDelegate(this);

        }
        }
    
}