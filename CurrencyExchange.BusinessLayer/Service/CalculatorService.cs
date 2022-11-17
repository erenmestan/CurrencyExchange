using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyExchange.Core.Model;
using CurrencyExchange.Core.Service;

namespace CurrencyExchange.BusinessLayer.Service
{

    public class CalculatorService:ICalculatorService
    {
        private readonly ICurrencyService _currencyService;

        public CalculatorService(ICurrencyService currencyService)
        {
            _currencyService=currencyService;
        }
        //inputu output yaptım.
        public OutputCurrencyDto CalculateName(OutputCurrencyDto outputCurrencyDto)
        {
            double ss = _currencyService.cuurencyPriceCalc(outputCurrencyDto.FirstCurrency, outputCurrencyDto.LastCurrency);
             //outputCurrencyDto.FirstAmount = outputCurrencyDto.FirstAmount;
             //outputCurrencyDto.FirstCurrency = outputCurrencyDto.FirstCurrency;
             //outputCurrencyDto.LastCurrency = outputCurrencyDto.LastCurrency;
             outputCurrencyDto.LastAmount = outputCurrencyDto.FirstAmount * ss;
             return outputCurrencyDto;
        }
    }
}
