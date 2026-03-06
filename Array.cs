//1.

//string letter = Console.ReadLine();
//bool var=false;
//for (int i = 0; i < letter.Length; i++)
//{
//    if (letter[i] == 'A' || letter[i] == 'a')
//    {
//       var=true;


//    }
//}
//if (var)
//    Console.WriteLine("Var");
//else
//    Console.WriteLine("yoxdur");
//Console.ReadLine();

//------------------------------------------------------------

//2.
//Console.WriteLine("Metni daxil edin: ");
//string metn=Console.ReadLine();
//int aSay = 0;
//for (int i = 0; i < metn.Length; i++)
//{
//    if (metn[i] == 'A' || metn[i] == 'a')
//    { aSay++; }
//}
//Console.WriteLine($"A herfinin sayi:{aSay}");
//Console.ReadLine();

//---------------------------------------------------------------

//3.
//Console.WriteLine("Massivin olcusun dxil edin: ");
//int massivOlcu = int.Parse(Console.ReadLine());
//int[] arr = new int[massivOlcu];
//int element;
//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine($"{i}-ci elementi daxil et: ");
//    element = int.Parse(Console.ReadLine());
//    arr[i] = element;
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        sum += arr[i];
//    }
//}
//Console.WriteLine($"Cutlerin cemi:{sum}");
//Console.ReadLine();

//----------------------------------------------------------------

////4.
//Console.WriteLine("Massivin olcusun daxil edin: ");
//int massivOlcu = int.Parse(Console.ReadLine());
//int[] arr = new int[massivOlcu];
//int element;
//int sum = 0;
//int factorial = 1;
//int baslangic = 1;
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine($"{i}-ci elementi daxil et: ");
//    element = int.Parse(Console.ReadLine());
//    arr[i] = element;
//}
//foreach (int res in arr)
//{
//    while (baslangic <= res)
//    {
//        factorial *= baslangic;
//        baslangic++;
//    }
//    Console.WriteLine(factorial);
//}
//Console.ReadLine();

//-----------------------------------------------------------------------------------------------

//5.
//Console.WriteLine("Massivin olcusun daxil edin: ");
//int massivOlcu = int.Parse(Console.ReadLine());
//int[] arr = new int[massivOlcu];
//int element;
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine($"{i}-ci elementi daxil et: ");
//    element = int.Parse(Console.ReadLine());
//    arr[i] = element;
//}
//int min = arr[0];
//for (int i = 0; i < massivOlcu; i++)
//{
//    if (arr[i] < min)
//    { 
//  min = arr[i];
//    }
//}
//Console.WriteLine($"Minimum eded:{min}");
//Console.ReadLine();

//-------------------------------------------------------------------

//6.
Console.Write("N ededini daxil et: ");
int n = int.Parse(Console.ReadLine());

Console.Write("M ededini daxil et: ");
int m = int.Parse(Console.ReadLine());

for (int i = n; i <= m; i++)
{
    int num = i;
    int reverse = 0;

    while (num > 0)
    {
        int digit = num % 10;
        reverse = reverse * 10 + digit;
        num /= 10;
    }

    if (i == reverse)
    {
        Console.WriteLine(i);
    }
}
Console.ReadLine();