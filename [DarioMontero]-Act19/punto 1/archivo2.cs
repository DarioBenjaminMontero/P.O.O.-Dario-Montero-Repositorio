using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    partial class ReservaHotel
    {
        private int total;

        public int Total
        {
            set { total = value; }
            get { return total; }
        }

        public void totalAPagar() {
            if (TipoHabitacion == "simple") {
                total = CantidadNoches * 5000;
            }
            if (TipoHabitacion == "doble")
            {
                total = CantidadNoches * 8000;
            }
            if (TipoHabitacion == "suite")
            {
                total = CantidadNoches * 12000;
            }
        }
       
    }
}
