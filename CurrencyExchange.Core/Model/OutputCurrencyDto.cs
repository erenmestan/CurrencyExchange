using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange.Core.Model
{
    public class OutputCurrencyDto
    {
        public string FirstCurrency { get; set; }
        public double FirstAmount { get; set; }
        public string LastCurrency { get; set; }
        public double LastAmount { get; set; }

        public List<ComboBoxDto> ComboBoxItems { get; set; }

        public OutputCurrencyDto()
        {
            FirstCurrency = "USD";
            LastCurrency = "TRY";
            FirstAmount = 0;
            LastAmount = 0;
        }
    }
}
