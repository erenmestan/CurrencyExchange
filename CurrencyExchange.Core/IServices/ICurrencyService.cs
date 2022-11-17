using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyExchange.Core.Model;

namespace CurrencyExchange.Core.Service
{
    public interface ICurrencyService
    {
        TarihDate GeTarihDate();

        double cuurencyPriceCalc(string firstCurrency, string lastCuurency);
        List<ComboBoxDto> getallCodes();

    }
}
