//1.
//Console.WriteLine("Ededi daxil edin: ");
//int num=int.Parse(Console.ReadLine());
//if (num > 0)
//{
//    Console.WriteLine("Musbet");
//}
//else if (num < 0)
//{
//    Console.WriteLine("Menfi");
//}
//else
//{
//    Console.WriteLine("menfi");
//}

//-------------------------------------------------

//2.
//Console.WriteLine("ededi daxil edin: ");
//int num=int.Parse(Console.ReadLine());
//if (num % 2 == 0)
//    Console.WriteLine("Cut");
//else
//    Console.WriteLine("Tek");

//-----------------------------------------------------

//3.
//Console.WriteLine("Yasinizi daxil edin: ");
//int age=int.Parse(Console.ReadLine());
//if (age > 0 && age <= 18)
//    Console.WriteLine("usag");
//else if (age > 18 && age < +65)
//    Console.WriteLine("yetiskin");
//else if (age > 65)
//    Console.WriteLine("Yasli");
//else
//    Console.WriteLine("Yas menfi ola bilmez");

//-------------------------------------------------------------

//4.
//Console.WriteLine("Meblegi daxil edin: ");
//double mebleg=double.Parse(Console.ReadLine());
//if (mebleg < 100)
//    Console.WriteLine(mebleg);
//else if (mebleg > 100 && mebleg <= 500)
//{
//    Console.WriteLine(mebleg-(mebleg * 0.1));
//}
//else
//{
//    Console.WriteLine(mebleg-(mebleg*0.2));
//}

//-----------------------------------------------------

//5
//Console.WriteLine("Maasi daxil edin: ");
//double maas=double.Parse(Console.ReadLine());
//Console.WriteLine("Tecrube ilini daxil edin: ");
//double tecrubeIli=int.Parse(Console.ReadLine());
//if (tecrubeIli > 0 && tecrubeIli <= 2)
//    Console.WriteLine("Bonus yoxdur");
//else if (tecrubeIli > 2 && tecrubeIli < 5)
//    Console.WriteLine($"Bonus:{maas + (maas * 0.1)}");
//else
//    Console.WriteLine($"Bonus:{maas + (maas * 0.2)}");

//-------------------------------------------------------------

//6
Console.WriteLine("Mesafeni daxil edin: ");
int mesafe=int.Parse(Console.ReadLine());
if (mesafe > 0 && mesafe <= 5)
    Console.WriteLine("5 manat");
else if (mesafe > 5 && mesafe <= 15)
    Console.WriteLine($"{5+(mesafe*0.8)} manat");
else
    Console.WriteLine($"{5+(mesafe*0.6)} manat");
