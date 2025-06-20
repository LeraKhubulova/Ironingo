using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ironingo
{
    public class Word
    {
        public string Ossetian { get; set; }
        public string Translation { get; set; }

        public override string ToString()
        {
            return $"{Ossetian} - {Translation}";
        }
    }
}
