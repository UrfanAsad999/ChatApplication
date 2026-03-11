//1.metod - a n dəyəri göndəriləcək. Metod həmin ədədin kvadratını qaytaracaq
//Console.WriteLine("Ededi daxil edin: ");
//int Eded=int.Parse(Console.ReadLine());
//Kvadrat(Eded);
//Console.ReadLine();
//static void Kvadrat(int eded)
//{
//    int kvadrat = eded * eded;
//    Console.WriteLine(kvadrat);
//}

//-----------------------------------------------------------------------------------

//2.Metod-a n dəyəri göndəriləcək. metod 1-dən n-dək olan cüt ədədlərin cəmini qaytaracaq

//Console.WriteLine("N-ni daxil edin: ");
//int N=int.Parse(Console.ReadLine());
//CutEdedCem(N);
//Console.ReadLine();


//static void CutEdedCem(int n)
//{
//    int i = 1;
//    int sum=0;
//    while (i<=n)
//    {
//        if (i % 2 == 0)
//        { 
//        sum+=i;
//        }
//        i++;
//    }
//    Console.WriteLine($"Cut ededlerin cemi: {sum}");
//}

//-------------------------------------------------------------------------

//3.metod-a ədədlər massiv göndəriləcək. Həmin massivdəki, ən kiçik elementi tapıb geri qaytaracaq

//static void KicikEded(int[] ededler)
//{
//    int min = ededler[0];
//    for (int i = 1; i < ededler.Length; i++)
//    {
//        if (ededler[i] < min) { min = ededler[i]; }
//    }
//    Console.WriteLine($"Massivin kicik ededi:{min}");
//}

//Console.WriteLine("Massivin olcusun daxil edin: ");
//int massivOlcu = int.Parse(Console.ReadLine());
//int[] EdedArr = new int[massivOlcu];
//int eded;
//for (int i = 0; i < EdedArr.Length; i++)
//{
//    Console.WriteLine($"Massivin {i}-ci elementini daxil edin");
//    eded = int.Parse(Console.ReadLine());
//    EdedArr[i] = eded;
//}
//KicikEded(EdedArr);
//Console.ReadLine();

//-----------------------------------------------------------------------------

//4.Metod-a söz və hərf göndəriləcək.
//Həmin sözdə verilən hərfdən neçə ədəd olduğunu qaytaracaq metod.

//static int HerfCemi(string soz, char herf)
//{
//    int sum = 0;
//    for (int i = 0; i < soz.Length; i++)
//    {
//        if (soz[i] == herf)
//        {
//            sum++;
//        }
//    }
//    return sum;
//}

//Console.WriteLine("Sozu daxil edin: ");
//string Soz = Console.ReadLine();
//Console.WriteLine("Herfi daxil edin: ");
//char Herf = char.Parse(Console.ReadLine());
//int result=HerfCemi(Soz, Herf);
//Console.WriteLine($"Teyin olunan herfin sozdeki sayi:{result}");
//Console.ReadLine();

//-------------------------------------------------------------------------

//5.Metod-a n və m ədədləri göndəriləcək.
//Həmin n və m ededleri arasindaki tek ededlerin sayini tapin.

//static int TekEdedSay(int n, int m)
//{
//    int sum = 0;
//    while (n <= m)
//    {
//        if (n % 2 == 1)
//        {
//            sum++;
//        }
//        n++;
//    }
//    return sum;
//}

//Console.WriteLine("N-i daxil edin:");
//int N=int.Parse(Console.ReadLine());
//Console.WriteLine("M-i daxil edin:");
//int M=int.Parse(Console.ReadLine());
//int result = TekEdedSay(N, M);
//Console.WriteLine($"Tek ededlerin sayi:{result}");
//Console.ReadLine();

//--------------------------------------------------------------------

//6.Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.
//Misal olaraq, name = " Hikmet  Abbasov " deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə
//variable-daki dəyər "HikmətAbbasov" olmalıdır.

//static string BosluqlariSil(string text)
//{
//    return text.Replace(" ", "");
//}
//string name = " Hikmet  Abbasov ";
//string netice = BosluqlariSil(name);

//Console.WriteLine(netice);
//Console.ReadLine();
