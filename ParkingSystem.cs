using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_4
{
    public class ParkingSystem
    {
        private Dictionary<int, int> parkingSpaces;
               
        public ParkingSystem(int big, int medium, int small)
        {
            parkingSpaces = new Dictionary<int, int>
            {
                {1, big},
                {2, medium},
                {3, small}
            };

        }
              
        public bool AddCar(int carType)
        {
            if (parkingSpaces.ContainsKey(carType) && parkingSpaces[carType] > 0)
            {
                parkingSpaces[carType]--;
                return true;
            }
            return false; 
        }
    }
}