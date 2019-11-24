using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WpfApp1
{
    class BarberModel
    {
        private dbEntities db = new dbEntities();

        public List<Barber> GetBarbers()
        {
            return db.Barber.ToList();
        }

        public bool ValidateBarberInfo(Barber barber)
        {
            return Regex.IsMatch(barber.name, "^[a-zA-Z0-9]*$");
        }

        public void AddBarber(Barber barber)
        {
            db.Barber.Add(barber);
            db.SaveChanges();
        }
    }
}
