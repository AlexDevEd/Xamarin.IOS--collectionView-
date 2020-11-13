using System;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace CurrencyValueApp
{
    public class CollectionDelegate : UICollectionViewDelegate
    {

        public CurrencyCollectionView CurrencyCollectionView { get; set; }

        public CollectionDelegate(CurrencyCollectionView currencyCollectionView)
        {
            CurrencyCollectionView = currencyCollectionView;
        }

       /* [Export("collectionView:didSelectItemAtIndexPath:")]
        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {
            
            var cell = collectionView.CellForItem(indexPath);

            
        }*/
    }
}
