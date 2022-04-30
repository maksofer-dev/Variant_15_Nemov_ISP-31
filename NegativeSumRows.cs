using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant_15
{
    public class NegativeSumRows
    {

        public string NegativeSum(int [,] arr)
        {
            bool searchNegativeNumbers = false;
            int total = 0;
            string result = "";
            int count = 0; 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                total = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < 0 && searchNegativeNumbers == false)
                    {
                        count++;
                        searchNegativeNumbers = true;
                        j = -1;
                    }
                    else if (searchNegativeNumbers == true)
                    {
                        total += arr[i, j];
                    }
                }
                if (searchNegativeNumbers == false)
                    result += ("\n В строке " + (i + 1) + " нет орицательных чисел.");
                else
                {
                    result += ("\n Сумма чисел в строке " + (i + 1) + " равна " + total);
                    total = 0;
                    searchNegativeNumbers = false;
                }
                
            }            
            return result;
        }
    }
}
