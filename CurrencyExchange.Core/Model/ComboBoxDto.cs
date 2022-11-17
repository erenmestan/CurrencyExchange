using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange.Core.Model
{
    public class ComboBoxDto
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public ComboBoxDto(string code,string name)
        {
            this.Code = code;
            this.Name = name;
            
        }
    }
}
