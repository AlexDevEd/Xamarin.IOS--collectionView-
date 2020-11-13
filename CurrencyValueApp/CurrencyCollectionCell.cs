using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace CurrencyValueApp
{

    public partial class CurrencyCollectionCell : UICollectionViewCell
    {
        public CurrencyModel CurrencyModel { get; private set; }

        public CurrencyCollectionCell(IntPtr handle) : base(handle)
        {
        }

        internal void UpdateCell(CurrencyModel currencyModel)
        {
            CurrencyModel = currencyModel;

            TextLabel.Text = currencyModel.TitleLeft;
            
            Sell.Text = currencyModel.TitleSell.ToString();
            Buy.Text = currencyModel.TitleBuy.ToString();
        }



        /*    public List<CurrencyModel> Items { get; private set; }
            public CurrencyCollectionCell(IntPtr handle) : base(handle)
            {
            }


            public void UpdateRow(List<CurrencyModel> items, NSIndexPath indexPath)
            {
                Items = items;
                TextLabel.Text = items[indexPath.Row].TitleLeft;
                TextLabel2.Text = items[indexPath.Row].TitleRigth;
                Sell.Text = items[indexPath.Row].TitleSell;
                Buy.Text = items[indexPath.Row].TitleBuy;
            }*/
    }
}