using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIBM_GUI_Project.Properties
{
    internal class TotalAmountCalc
    {
        private int quantity;
        private double selling_price;
        private double tot;
        private int totQty;
        private int itemQty;

        public int Quantity { get => quantity; set => quantity = value; }
        public double Selling_price { get => selling_price; set => selling_price = value; }
        public double Tot { get => tot; set => tot = value; }
        public int TotQty { get => totQty; set => totQty = value; }
        public int ItemQty { get => itemQty; set => itemQty = value; }

        public TotalAmountCalc()
        {
            quantity = 0;
            selling_price = 0;
            tot = 0;
            itemQty = 0;
            totQty = 0;
        }

        public void totCal()
        {
            tot = selling_price * quantity;
        }

        public void calcQty()
        {

            totQty = itemQty - quantity;
        }
    }
}
