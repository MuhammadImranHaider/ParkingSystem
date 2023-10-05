using ParkingSystemApp;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ParkingSystemTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class ParkingSystemTests
	{
		[TestMethod]
		public void AddCar_BigCarWithAvailableSpace_ReturnsTrue()
		{
			ParkingSystem parkingSystem = new ParkingSystem(3, 5, 7);
			bool result = parkingSystem.AddCar(1); 
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void AddCar_MediumCarWithAvailableSpace_ReturnsTrue()
		{
			ParkingSystem parkingSystem = new ParkingSystem(3, 5, 7);
			bool result = parkingSystem.AddCar(2); 
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void AddCar_SmallCarWithAvailableSpace_ReturnsTrue()
		{
			ParkingSystem parkingSystem = new ParkingSystem(3, 5, 7);
			bool result = parkingSystem.AddCar(3); 
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void AddCar_BigCarWithNoSpace_ReturnsFalse()
		{
			ParkingSystem parkingSystem = new ParkingSystem(0, 5, 7);
			bool result = parkingSystem.AddCar(1); 
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void AddCar_InvalidCarType_ReturnsFalse()
		{
			ParkingSystem parkingSystem = new ParkingSystem(3, 5, 7);
			bool result = parkingSystem.AddCar(4);
			Assert.IsFalse(result);
		}
	}

}


