using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Class1
    {
        public void Test(bool p_blTest )
        {
            try
            {
                string a = "s";
               Convert.ToInt32(a);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
