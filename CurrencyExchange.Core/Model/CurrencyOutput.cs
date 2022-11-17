using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(TarihDate));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (TarihDate)serializer.Deserialize(reader);
// }

namespace CurrencyExchange.Core.Model
{
    [XmlRoot(ElementName = "Currency")]
    public class CurrencyOutput
    {
        [XmlElement(ElementName = "Unit")]
        public int Unit { get; set; }

        [XmlElement(ElementName = "Isim")]
        public string? Isim { get; set; }

        [XmlElement(ElementName = "CurrencyName")]
        public string? CurrencyName { get; set; }

        [XmlElement(ElementName = "ForexBuying")]
        public double ForexBuying { get; set; }

        [XmlElement(ElementName = "ForexSelling")]
        public double? ForexSelling { get; set; }

        


        [XmlIgnore]

        [XmlElement(ElementName = "BanknoteBuying")]
        public double? BanknoteBuying { get; set; }
        [XmlIgnore]
        [XmlElement(ElementName = "BanknoteSelling")]
        public double BanknoteSelling { get; set; }

        [XmlElement(ElementName = "CrossRateUSD")]
        public object? CrossRateUSD { get; set; }

        [XmlElement(ElementName = "CrossRateOther")]
        public object? CrossRateOther { get; set; }

        [XmlAttribute(AttributeName = "" +
                                      "CrossOrder" +
                                      "")]
        public int CrossOrder { get; set; }

        [XmlAttribute(AttributeName = "Kod")]
        public string? Kod { get; set; }

        [XmlAttribute(AttributeName = "CurrencyCode")]
        public string? CurrencyCode { get; set; }

        [XmlText]
        public string? Text { get; set; }
    }

    
}
