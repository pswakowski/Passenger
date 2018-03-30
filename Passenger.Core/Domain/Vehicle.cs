using System;

namespace Passenger.Core.Domain
{
    public class Vehicle
    {
        public string Brand { get; protected set; }
        public string Name { get; protected set; }
        public int Seats { get; protected set; }

        public Vehicle (string brand, string name, int seats)
        {
            
        }

        private void SetBrand(string brand)
        {
            if (string.IsNullOrWhiteSpace(brand))
            {
                throw new Exception("Plase provide valid data.");
            }
            if (Brand == brand)
            {
                return;
            }
            Brand = brand;
        }

        private void Setname(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                 throw new Exception("Plase provide valid data.");
            }
            if (Name == name)
            {
                return;
            }
            Name = name;
        }

        private void SetSeats(int seats)
        {
            if (seats < 0)
            {
                 throw new Exception("Seats must be greater than 0.");
            }
            if (seats > 9)
            {
                 throw new Exception("You cannot provide more than 9 seats.");
            }
            if (Seats == seats)
            {
                return;
            }
            Seats = seats;
        }
    }
}