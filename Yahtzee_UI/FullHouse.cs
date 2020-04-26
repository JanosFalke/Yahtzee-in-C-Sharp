using System;
using System.Collections.Generic;
using System.Text;

namespace Yahtzee_UI
{
    class FullHouse
    {
        private int _value = 25;
        private bool _obtained = false;

        public bool obtained
        {
            get { return _obtained; }
            set { _obtained = value; }
        }

        public int value
        {
            get { return _value; }
            set { _value = value; }
        }

        public override string ToString()
        {
            if (obtained)
            {
                if (value == -2)
                {
                    return "-";
                }

                return "" + value;
            }

            return " ";
        }
    }
}
