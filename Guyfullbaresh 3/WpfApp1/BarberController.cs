using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class BarberController
    {
        private BarberModel model = new BarberModel();
        public void AddBarber(Barber barber)
        {
            model.AddBarber(barber);
        }

        public List<Barber> GetBarber()
        {
            return model.GetBarbers();
        }
    }
}
