//1.
//Console.WriteLine("Ededi daxil edin: ");
//int eded = int.Parse(Console.ReadLine());
//int cem = 0;
//int baslangic = 0;
//while (baslangic < eded)
//{
//    cem += baslangic;
//    baslangic++;
//}
//Console.WriteLine($"Cem:{cem}");
//Console.ReadLine();

//------------------------------------

//2.

//Console.WriteLine("Ededi daxil edin: ");
//int eded=int.Parse(Console.ReadLine());
//int faktoriyal = 1;
//int i = 1;
//while (i <= eded)
//{
//    faktoriyal *= i;
//    i++;
//}
//Console.WriteLine($"Faktorial:{faktoriyal}");
//Console.ReadLine();

//-------------------------------------------------

//3.
//Console.WriteLine("n-ni daxil edin: ");
//int n=int.Parse(Console.ReadLine());
//Console.WriteLine("m-i daxil edin: ");
//int m=int.Parse(Console.ReadLine());
//int sum = 0;
//while (n < m)
//{
//    if (n%10== 0)
//        { sum+=n; }
//    n++;
//}
//Console.WriteLine($"Cem:{sum}");
//Console.ReadKey();

//----------------------------------------------------------------

//4
//Console.WriteLine("Ededi daxil edin: ");
//int eded=int.Parse(Console.ReadLine());
//int reqemSay = 0;
//while (eded > 0)
//{
//    reqemSay++;
//    eded /= 10;
//}
//Console.WriteLine($"Reqem sayi:{reqemSay}");
//Console.ReadLine(); 

//--------------------------------------------------------------------

//5
//Console.WriteLine("qiymeti daxil edin: ");
//int qiymet = int.Parse(Console.ReadLine());
//switch (qiymet)
//{
//    case 2:
//        Console.WriteLine("Pis");
//        break;

//    case 3:
//        Console.WriteLine("Kafi");
//        break;

//    case 4:
//        Console.WriteLine("Yaxsi");
//        break;

//    case 5:
//        Console.WriteLine("Ela");
//        break;

//    default:
//        Console.WriteLine("2-5 arasi eded");
//        break;
//}
//Console.ReadLine();

//-------------------------------------------------------

//6.
//Console.WriteLine("M-i daxil edin");
//int M=int.Parse(Console.ReadLine());
//int start = 1;
//int say = 0;
//while (start < M)
//{
//    if (start % 3 == 0)
//    {
//        say++;
//    }
//    start++;
//}
//Console.WriteLine($"Say:{say}");
//Console.ReadLine();

//-------------------------------------------------------

//7.
//Console.WriteLine("M-i daxil edin");
//int M = int.Parse(Console.ReadLine());
//int start = 1;
//int say = 0;
//int sum = 0;
//while (start < M)
//{
//    if (start % 5 == 0)
//    {
//        say++;
//        sum += start;
//    }
//    start++;
//}
//int edediOrta = sum / say;
//Console.WriteLine($"Ededi orta:{edediOrta}");
//Console.ReadLine();

//8.
//Console.WriteLine("n-i daxil edin: ");
//int n=int.Parse(Console.ReadLine());
//Console.WriteLine("m-i daxil edin: ");
//int m=int.Parse(Console.ReadLine());
//int sum = 0;
//while (n < m)
//{
//    if (n % 2 == 1)
//        sum += n;
//    n++;
//}
//Console.WriteLine($"Tek ededlerin cemi:{sum} ");
//Console.ReadLine();

//9.
//Console.WriteLine("Eded sayini daxil edin: ");
//int ededSayi=int.Parse(Console.ReadLine());
//int eded;
//int sum = 0;
//for (int i = 1; i <= ededSayi; i++)
//{
//    Console.WriteLine($"{i}-ci ededi daxil edin: ");
//    eded = int.Parse(Console.ReadLine());
//    sum += eded;
//}
//Console.WriteLine($"Cem:{sum}");
//Console.ReadLine();

//--------------------------------------------------------

//10.
//Console.WriteLine("X-i daxil edin: ");
//int x=int.Parse(Console.ReadLine());
//Console.WriteLine("Y-i daxil edin:");
//int y=int.Parse(Console.ReadLine());
//int i = 1;
//int hasil = 1;
//while(i<=y)
//{
//    hasil *= x;
//    i++;
//}
//Console.WriteLine($"Netice;{hasil}");
//Console.ReadLine();

//-----------------------------------------------

//11
//bool sifir = true;
//int hasil = 1;
//int eded;
//while (sifir)
//{
//    Console.WriteLine("Ededi daxil edin: ");
//    eded = int.Parse(Console.ReadLine());
//    if (eded == 0)
//    {
//        Console.WriteLine("Proqram dayanir");
//        sifir = false;
//    }
//    else
//    {
//        hasil *= eded;
//    }
//}
//Console.WriteLine($"Hasil:{hasil}");
//Console.ReadLine();

//----------------------------------------------------

//12.
//Console.WriteLine("Parolu teyin edin: ");
//string password=Console.ReadLine();
//string newPassword;
//bool assign = true;
//while (assign)
//{
//    Console.WriteLine("Parolu daxil edin");
//    newPassword = Console.ReadLine();   
//     if (newPassword == password)
//        assign = false;
//}
//Console.WriteLine("Proqram sonlandi.");
//Console.ReadLine();

//-------------------------------------------------------

//13.
//Console.WriteLine("X-i daxil edin:");
//double x = double.Parse(Console.ReadLine());
//Console.WriteLine("Y-i daxil edin: ");
//double y = double.Parse(Console.ReadLine());
//int start = 0;
//int boyukEded = 1;
//while (start <= x)
//{
//    if (start % y == 0)
//    {
//        if (start > boyukEded)
//        {
//            boyukEded = start;
//        }
//    }
//    else
//    {
//        boyukEded = -1;
//    }

//        start++;
//}
//Console.WriteLine($"Boyuk eded:{boyukEded}");
//Console.ReadLine();