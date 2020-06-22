using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace naloga2.Utilities
{
    public class PreveriEmso : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int stevilka = int.Parse(value.ToString());
            int zmnzek = 7;

            int sestevek = 0;

            for (int i = 0; i < value.ToString().Length; i++)
            {
                if (zmnzek == 1)
                {
                    zmnzek = 7;
                }
                else
                {
                    sestevek = sestevek + (value.ToString()[i] * zmnzek);
                    zmnzek--;
                }
                
            }


            var kontrolna = sestevek % 11;
            var kontrolna2 = kontrolna - 11;
            if (kontrolna2>=0 || kontrolna2<=9)
            {
               
                return true;
            }
            else
            {
                return false;
            }





            
        }
    }
}
