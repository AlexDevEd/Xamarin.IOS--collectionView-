using System;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace CurrencyValueApp
{
    public class CollectionSource : UICollectionViewDataSource
    {
        private CurrencyCollectionView currencyCollectionView;

        public CollectionSource(CurrencyCollectionView currencyCollectionView)
        {
            this.currencyCollectionView = currencyCollectionView;
        }

        CurrencyModel[] data =
        {
            new CurrencyModel("RUB/USD", 78.94f, 78.35f),
            new CurrencyModel("RUB/EUR", 92.52f, 91.94f),
            new CurrencyModel("RUB/UAH", 78.94f, 78.35f),
            new CurrencyModel("RUB/BYN", 78.94f, 78.35f)
        };
        /* List<CurrencyModel> _Items;
         public CurrencyCollectionView CurrencyCollectionView { get; set; }

         public CollectionSource(CurrencyCollectionView currencyCollectionView)
         {
             CurrencyCollectionView = currencyCollectionView;

             _Items = new List<CurrencyModel>
             {
                 new CurrencyModel
                 {
                     TitleLeft = "RUB",
                     TitleRigth = "USD",
                     TitleSell = "70",
                     TitleBuy = "90"
                 },

                 new CurrencyModel
                 {
                     TitleLeft = "RUB",
                     TitleRigth = "EUR",
                     TitleSell = "83",
                     TitleBuy = "85"
                 },
                 new CurrencyModel
                 {
                     TitleLeft = "RUB",
                     TitleRigth = "UAH",
                     TitleSell = "$90",
                     TitleBuy = "100"
                 },
                 new CurrencyModel
                 {
                     TitleLeft = "EUR",
                     TitleRigth = "USD",
                     TitleSell = "15",
                     TitleBuy = "20"
                 },
         };
         }*/

        public override nint NumberOfSections(UICollectionView currencyCollectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView currencyCollectionView, nint section)
        {
             return data.Length;
            // return _Items.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView currencyCollectionView, NSIndexPath indexPath)
        {

            var cell = (CurrencyCollectionCell)currencyCollectionView.DequeueReusableCell("Cell", indexPath);
            var currencyRate = data[indexPath.Row];

            cell.UpdateCell(currencyRate);

           
            //cell.UpdateRow(_Items, indexPath);

            return cell;
        }

       

    }
}
