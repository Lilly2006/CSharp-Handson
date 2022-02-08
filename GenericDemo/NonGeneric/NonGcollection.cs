using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric
{
    class NonGcollection
    {
        int[] values = new int[5];
        string[] strvalues = new string[5];
        double[] dblvalues = new double[5];
        int count = 0;
        #region inttype
        public void Data(int item)
        {
            if(count + 1 < 6)
            {
                values[count] = item;
            }
            count++;
            Console.WriteLine(item);
        }
        #endregion

        #region stringType
        public void Data(string item)
        {
            if (count + 1 < 6)
            {
                strvalues[count] = item;
            }
            count++;
            Console.WriteLine(item);
        }
        #endregion

        #region doubleType
        public void Data(double item)
        {
            if (count + 1 < 6)
            {
                dblvalues[count] = item;
            }
            count++;
            Console.WriteLine(item);
        }
        #endregion

    }
}
