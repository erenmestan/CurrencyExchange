using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyExchange.Core.Model;

namespace CurrencyExchange.Core.Service
{
    public interface ICalculatorService
    {
        OutputCurrencyDto CalculateName(OutputCurrencyDto outputCurrencyDto);

    }
}
