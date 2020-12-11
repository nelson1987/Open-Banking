using System.ComponentModel;

namespace BGB.OpenBanking.Api.Models
{
    public class AmountString
    {
        public AmountString(string key)
        {
            Key = key;
        }

        public string Key { get; private set; }
        public decimal Valor { get { return decimal.Parse(Key); } }
    }
    public enum CurrencyString
    {
        [Description("BRL")]
        Real_Brasileiro = 1,
        [Description("USD")]
        Dollar_Americano = 2,
        [Description("EUR")]
        Euro = 3
    }
}
