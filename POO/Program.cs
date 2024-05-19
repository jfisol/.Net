
using POO;

Console.WriteLine("Introduccion a OPP");


Sales sales = new Sales();//Se crea un nuevo Objeto
sales.total = 200;
sales.Customer = "Jose";

Sales sales2 = new Sales(300,"CR7");


Warer warer = new Warer();

warer.total = 10;
warer.Customer = "Messi";
warer.name = "Agua potable";

Warer warerHerencia = new Warer("Cafe","Sergio",11);


Console.WriteLine($"SALES 1 \n{sales.getInfo()}\n");
Console.WriteLine($"SALES 2 \n{sales2.getInfo()}\n");
Console.WriteLine($"Warer 1 :\n{warer.getInfo()}\n");
Console.WriteLine($"Warer 1 :\n{warerHerencia.getInfo()}");