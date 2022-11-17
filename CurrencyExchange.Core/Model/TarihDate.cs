using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurrencyExchange.Core.Model
{
    [XmlRoot(ElementName = "Tarih_Date" )]
    public class TarihDate
    {
        [XmlElement(ElementName = "Currency")]
        public List<CurrencyOutput> CurrencyList { get; set; }

        [XmlAttribute(AttributeName = "Tarih")]
        public string Tarih { get; set; }
        [XmlIgnore]
        [XmlAttribute(AttributeName = "Date")]
        public DateTime Date { get; set; }

        [XmlAttribute(AttributeName = "Bulten_No")]
        public string BultenNo { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
