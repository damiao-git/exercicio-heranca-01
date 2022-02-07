using System.Globalization;

namespace Exercicio131.Entities {
    class OutsourcedEmployee : Employee {
        public double AddictionalCharge  { get; set; }

        public OutsourcedEmployee() {
            }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addictionalCharge) 
            : base(name, hours, valuePerHour)
            {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
            AddictionalCharge = addictionalCharge;
            }
        public override double Payment() {
            return base.Payment() + (1.1 * AddictionalCharge);
            }
        public override string ToString()
            {
            return Name
                + " - $ "
                + Payment().ToString("f2", CultureInfo.InvariantCulture);
            }
        }
    }
