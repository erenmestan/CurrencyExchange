using CurrencyExchange.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CurrencyExchange.Core.Model;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

namespace CurrencyExchange.BusinessLayer.Service
{
    public class CurencyService : ICurrencyService
    {
        public TarihDate GeTarihDate()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TarihDate));
            WebClient webClient = new WebClient();
            string data =
                Encoding.Default.GetString(webClient.DownloadData("https://www.tcmb.gov.tr/kurlar/today.xml"));
            var startIndexOf = data.IndexOf("XDR")-30;
            string datalast = data.Substring(0, startIndexOf).Insert(startIndexOf, " </Tarih_Date>");
            Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(datalast));
            TarihDate tarihss = (TarihDate)serializer.Deserialize(stream);
            return tarihss;
        }

        public double cuurencyPriceCalc(string firstCurrency, string lastCuurency)
        {
            TarihDate tarihss = GeTarihDate();
            if (firstCurrency == "TRY" && lastCuurency == "TRY")
            {
                return 1;
            }
            else
            {
                if (lastCuurency == "TRY")
                {
                    return tarihss.CurrencyList.FirstOrDefault(p => p.Kod == firstCurrency).ForexBuying;
                }
                else if (firstCurrency == "TRY")
                {
                    return 1/tarihss.CurrencyList.FirstOrDefault(p => p.Kod == lastCuurency).ForexBuying;
                }
                else
                {
                    return tarihss.CurrencyList.FirstOrDefault(p => p.Kod == firstCurrency).ForexBuying /
                           tarihss.CurrencyList.FirstOrDefault(p => p.Kod == lastCuurency).ForexBuying;
                }
            }
        }

        public List<ComboBoxDto> getallCodes()
        {
            TarihDate tarihDate = GeTarihDate();
            List<ComboBoxDto> list = new List<ComboBoxDto>();
            foreach (var item in tarihDate.CurrencyList)
            {
                ComboBoxDto comboBoxDto = new ComboBoxDto(item.Kod, item.CurrencyName);
                list.Add(comboBoxDto);
            }
            list.Add(new ComboBoxDto("TRY", "Türk Lirası"));
            return list;
        }
    }
}
