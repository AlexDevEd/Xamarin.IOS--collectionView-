using System;
namespace CurrencyValueApp
{
    public class CurrencyModel 
    {
       /* public string TitleLeft
        {
            get;
            set;
        }
        public string TitleRigth
        {
            get;
            set;
        }
        public string TitleSell
        {
            get;
            set;
        }

        public string TitleBuy
        {
            get;
            set;
        }*/

        public CurrencyModel(string name, float sell, float buy)
        {
            TitleLeft = name;           
            TitleSell = sell;
            TitleBuy = buy;
        }

        public string TitleLeft { get; }       
        public float TitleSell { get; }
        public float TitleBuy { get; }
    }
}
