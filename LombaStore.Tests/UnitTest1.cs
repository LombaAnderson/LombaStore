using LombaStore.Domain.StoreContext.Entities;
using LombaStore.Domain.StoreContext.ValueObjects;

namespace LombaStore.Tests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("Anderson", "Lomba");

            var document = new Document("0789324912");

            var email = new Email("lomba@gmail.com");

            var c = new Customer(name,document,email,"71989453233");

            var caneta = new Product("Caneta", "Bic", "image.png", 1.50M, 10);
            var lapis = new Product("Lápis", "Lápis", "image.png", 1.40M, 10);
            var borracha = new Product("Borracha", "Borracha", "image.png", 1.20M, 10);
            var regua = new Product("Régua", "Régua", "image.png", 1.10M, 10);


            var order = new Order(c);
            order.AddItem(new OrderItem(caneta, 5));
            order.AddItem(new OrderItem(lapis, 5));
            order.AddItem(new OrderItem(borracha, 5));
            order.AddItem(new OrderItem(regua, 5));

            // Pedido realizado
            order.Place();

            // Simulação de pagamento
            order.Pay();

            // Simulação do envio
            order.Ship();

            // Simulação do cancelamento
            order.Cancel();


        }
    }
}