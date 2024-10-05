// See https://aka.ms/new-console-template for more information
using BuilderPattern;

Console.WriteLine("Hello, World!");
HouseBuilder houseBuilder = new HouseBuilder();
Console.WriteLine("Do you want AC (Y/N)");
char choice = char.Parse(Console.ReadLine().ToUpper());
if(choice ==  'Y')
{
    houseBuilder = houseBuilder.InstallAc();
}
Console.WriteLine("Do you want jacuzzi (Y/N)");
char choice1 = char.Parse(Console.ReadLine().ToUpper());
if (choice1 == 'Y')
{
    houseBuilder = houseBuilder.InstallJacuzzi();
}
Console.WriteLine("Do you want smart door (Y/N)");
char choice3 = char.Parse(Console.ReadLine().ToUpper());
if (choice3 == 'Y')
{
    houseBuilder = houseBuilder.AddSmartDoor();
}

House basicHouse = houseBuilder.Build();
Console.WriteLine($"Does this house has Ac? {basicHouse.HasAc}");
Console.WriteLine($"Does this house has Jacuzzi? {basicHouse.HasJacuzzi}");
Console.WriteLine($"Does this house has Smart Door? {basicHouse.HasSmartDoor}");

