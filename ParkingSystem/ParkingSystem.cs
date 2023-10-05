using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystemApp
{
	public class ParkingSystem
	{
		private int[] availableSlots = default;
		public ParkingSystem(int big, int medium, int small)
		{
			availableSlots = new int[] { big, medium, small };
		}

		public bool AddCar(int carType)
		{
			const int minCarType = 1;
			const int maxCarType = 3;
			if (carType < minCarType || carType > maxCarType) {
				return false;
			}
			int index = carType - 1; // let say if carType = 3; which is small. Small stored at index 2. now we will check if there is any space available.
			if (availableSlots[index] > 0) 
			{
				availableSlots[index]--; // one more slot occupied so will minus it.
				return true;
			}

			return false; // No space available for this size.
		}
	}

	/**
	 * Your ParkingSystem object will be instantiated and called as such:
	 * ParkingSystem obj = new ParkingSystem(big, medium, small);
	 * bool param_1 = obj.AddCar(carType);
	 */
}
