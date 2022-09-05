using LombaStore.Domain.StoreContext.Entities;
using LombaStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LombaStore.Tests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var c = new Customer(
                "Anderson",

                "0798434911",
                "lomba@gmail.com",
                "071987579877",
                "Rua Dto Newton Moura, 204");

            var order = new Order(c);
            order.AddItem();

      
        }
    }
}