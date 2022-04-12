using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FrequencyCounter
    {
        public string Count(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;
            text = text.ToLower();
            var data = from c in text
                       group c by c
                into g
                       select $"{g.Key}-{g.Count()}";

            var ans = new StringBuilder();
            foreach (var t in data)
            {
                ans.Append($"{t},");
            }
            ans.Remove(ans.Length - 1, 1);

            return ans.ToString();
        }
    }
}
