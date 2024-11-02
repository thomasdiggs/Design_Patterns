global using Factory;
global using Factory.Interfaces;


IFactory factoryA = new FactoryA();
IProduct productA = factoryA.CreateProduct();
Console.WriteLine(productA.GetDetails());

IFactory factoryB = new FactoryB();
IProduct productB = factoryB.CreateProduct();
Console.WriteLine(productB.GetDetails());


IConnectionFactory connectionFactory = new ConnectionFactory();

IConnection sqlServerConnection = connectionFactory.CreateConnection("SqlServer");
Console.WriteLine(sqlServerConnection.GetDescription());

IConnection oracleConnection = connectionFactory.CreateConnection("Oracle");
Console.WriteLine(oracleConnection.GetDescription());