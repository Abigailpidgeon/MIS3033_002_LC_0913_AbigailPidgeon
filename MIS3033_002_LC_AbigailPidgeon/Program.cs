// MIS 3033 002
// september 13, 2023
// Abigail Pidgeon
using a;

Console.WriteLine("Entity Framework 2");

OrderDB orderdb;
orderdb = new OrderDB();

Order order = new Order() { Id=123, QtyApple = 3.5, QtyBanana = 4.6};

orderdb.ordersTbl.Add(order);
orderdb.SaveChanges();

