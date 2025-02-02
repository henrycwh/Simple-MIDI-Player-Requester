using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midi_palyer_simple_edition
{
    internal class Index_Controller
    {
        private int d_index;
        private int p_index;
        private object lockObject;
        public Index_Controller()
        {
            d_index = 0;
            p_index = 0;
            lockObject = new object();
        }

        public int Get_or_Increase_p_Index(char ch)
        {
            lock (lockObject)
            {
                if (ch == 'a')
                {
                    p_index++;
                    return 0;
                }
                else return p_index;
            }
        }
        public int Get_or_Increase_d_Index(char ch)
        {
            lock (lockObject)
            {
                if (ch == 'a')
                {
                    d_index++;
                    return 0;
                }
                else return d_index;
            }
        }
    }
}
