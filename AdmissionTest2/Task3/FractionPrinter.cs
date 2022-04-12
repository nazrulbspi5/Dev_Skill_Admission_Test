using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FractionPrinter
    {
        public string Print(int numerator, int denominator, int count)
        {
            var data = (decimal)numerator / denominator;

            string fff = @"{0:0.";

            for (int i = 0; i < count; i++)
            {
                fff += '0';
            }

            fff += '}';

            var ans = String.Format(fff, data);

            return ans;


        }
    }
}
