using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stavka1._0
{
    public class Rates
    {
        public static decimal Easy(decimal i, decimal n, decimal P)
        {
            return (decimal)Math.Pow((double)(1 + i), (double)n) * P; //простая процентная ставка
        }

        public static decimal Hard(decimal j, decimal m, decimal n, decimal P)
        {
            return (decimal)Math.Pow((double)(1 + (j/100) / m), (double)n) * P; //сложная процентная ставка
        }
        
        public static decimal Compound(decimal b, decimal n, decimal P)
        {
            return (decimal)Math.Exp((double)b/100 * (double)n) * P; //непрерывно начисляемые проценты
        }
     
    }
}
