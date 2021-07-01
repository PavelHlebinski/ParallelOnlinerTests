using NUnit.Framework;

namespace ParallelOnlinerTests.Test
{
    [TestFixture]
    [Parallelizable]
    public class ServiceTests : BaseTest
    {
        [TestCase("Перевозки", "Грузоперевозки", TestName = "Find Cargo Move services")]
        public void FindCargoMoveServicesTest(string serviceName, string serviceType)
        {
            MainPage.OpenServices();
            ServicesPage.SelectService(serviceName, serviceType);
            ServicesPage.CheckServiceType(serviceType);
        }

        [TestCase("Перевозки", "Эвакуаторы", TestName = "Find Tow trucks services")]
        public void FindTowTrucksTest(string serviceName, string serviceType)
        {
            MainPage.OpenServices();
            ServicesPage.SelectService(serviceName, serviceType);
            ServicesPage.CheckServiceType(serviceType);
        }

        [TestCase("Уборка", "Поддерживающая уборка", TestName = "Find Clining services")]
        public void FindRepairServicesTest(string serviceName, string serviceType)
        {
            MainPage.OpenServices();
            ServicesPage.SelectService(serviceName, serviceType);
            ServicesPage.CheckServiceType(serviceType);
        }
    }
}
