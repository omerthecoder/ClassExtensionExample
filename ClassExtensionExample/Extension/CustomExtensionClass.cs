using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExtensionExample.Extension
{
    public static class CustomExtensionClass
    {
        public static string HarfDegistir(this string str,string charactersToChange)
        {
            char[] cd = str.ToCharArray();
            string ss = "";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    cd[i]= str[i];
            //}
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < charactersToChange.Length; j++)
                {
                    if (str[i] == charactersToChange[j]) cd[i] = '*'; 
                }
                
            }
            for (int i = 0; i < str.Length; i++)
            {
                ss += cd[i];
            }
           
            return ss;
        }
    }
}
