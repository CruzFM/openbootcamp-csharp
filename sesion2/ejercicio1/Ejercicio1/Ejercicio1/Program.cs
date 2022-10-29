Console.WriteLine("Escriba por favor su nombre.");
string name = Console.ReadLine();
Console.WriteLine("Escriba su Apellido");
string lastName = Console.ReadLine();
Console.WriteLine("Ahora indique su edad.");
string age = Console.ReadLine();
Console.WriteLine("Usted sabe programar?");
string canCode = Console.ReadLine();

string answer = name + " " + lastName + ", " + age + " de edad, " + canCode;
Console.WriteLine(answer);