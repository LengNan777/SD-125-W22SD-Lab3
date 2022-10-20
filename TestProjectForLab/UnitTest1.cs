namespace TestProjectForLab
{
    [TestClass]
    public class UnitTest1
    {
        VehicleTracker vehicleTracker;
        int capacity = 10;

        [TestInitialize]
        public void Initialize()
        {
            vehicleTracker = new VehicleTracker(10, "123 Fake St");
        }

        [TestMethod]
        public void GenerateSlotesOfTen()
        {
            Assert.AreEqual(capacity, vehicleTracker.VehicleList.Count);
        }

        [TestMethod]
        public void AddVehicleToVehicleTracker()
        {
            Vehicle vehicle1 = new Vehicle("license 1", false);
            vehicleTracker.AddVehicle(vehicle1);
            Assert.AreEqual(vehicle1, vehicleTracker.VehicleList[1]);
        }

        [TestMethod]
        public void RemoveVehicleFromVehicleTracker()
        {
            Vehicle vehicle1 = new Vehicle("license 1", false);
            vehicleTracker.AddVehicle(vehicle1);
            vehicleTracker.RemoveVehicle(1);
            
            Assert.AreEqual(null, vehicleTracker.VehicleList[1]);
        }
    }
}