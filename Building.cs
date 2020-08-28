using System;

namespace Planner
{
    public class Building
    {
        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public Building(string address)
        {
            _address = address;
            _designer = "Steve Brownlee";
        }
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string person)
        {
            _owner = person;
        }
        public void Message()
        {
            Console.WriteLine($@"
{_address}
---------------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space
            ");
        }
    }
}