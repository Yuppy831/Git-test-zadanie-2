Console.WriteLine("Меню:");
Console.WriteLine("===================");
Console.WriteLine("1.ВЫБОР А");
Console.WriteLine("1.ВЫБОР Б");
Console.WriteLine("1.ВЫБОР В");
Console.WriteLine("===================");
Console.Write("Ваш выбор:");
var a=int.Parse(Console.ReadLine());
if(a==1)
{
    Console.WriteLine("Вы выбрали А");
}
else if(a==2)
{
    Console.WriteLine("Вы выбрали Б");
}
else if(a==3)
{
    Console.WriteLine("Вы выбрали В");
}
else
{
    Console.WriteLine("Вы ввели неверное значение");
}




