using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesel_MikitaRakovich
{
    class randomizer
    {
        public static int RandomNumberEven(int min, int max)
        {
            Random random = new Random();
            int ans = random.Next(min, max);
            if (ans % 2 == 0) return ans;
            else
            {
                if (ans + 1 <= max)
                    return ans + 1;
                else if (ans - 1 >= min)
                    return ans - 1;
                else return 0;
            }
        }

        public static int RandomNumberOdd(int min, int max)
        {
            Random random = new Random();
            int ans = random.Next(min, max);
            if (ans % 2 == 1) return ans;
            else
            {
                if (ans + 1 <= max)
                    return ans + 1;
                else if (ans - 1 >= min)
                    return ans - 1;
                else return 0;
            }
        }
    }
}
