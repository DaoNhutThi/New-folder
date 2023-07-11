//bai1
//Console.WriteLine("Nhap ho va ten: ");
//string input = Console.ReadLine();
//Console.WriteLine("Nhap tuoi cua ban: ");
//int length = int.Parse(Console.ReadLine());
//Console.WriteLine("Ho va Ten: " + input);
//Console.WriteLine("Tuoi: " + input1);
//Console.WriteLine("Xin chao: " + input + " " + input1);

//bai2
//Console.WriteLine("Enter Length= ");
//int length = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter Width= ");
//int width = int.Parse(Console.ReadLine());
//int result = length* width;
//Console.WriteLine("Area= "+ result);

//PI & Abs
//double r;
//double P = Math.PI;
//Console.WriteLine("enter  = ");
//r = Convert.ToDouble(Console.ReadLine());
//P = P * r * r;
//Console.WriteLine("Dien tich la: " + P); ;

//Floor & Ceiling
//double f = 0.33;
//double c = 3.55;

//double floor = Math.Floor(f);
//double ceiling = Math.Ceiling(c);

//Console.WriteLine("value " + f);
//Console.WriteLine("value1 " + floor);
//Console.WriteLine("values " + c);
//Console.WriteLine("values1 " + ceiling);

//Round
//double a = 3.12345;

//double two = Math.Round(a, 2);
//Console.WriteLine("value " + two);

//double three = Math.Round(a, 3);
//Console.WriteLine("value " + three);

//double four = Math.Round(a, 4);
//Console.WriteLine("value " + four);

//Max & Min
//int a = 10;
//int b = 15;
//int c = 36;

//int max = Math.Max(a, b);
//Console.WriteLine("Max " + max);
//int max1 = Math.Max(b, c);
//Console.WriteLine("Max " + max1);
//int max2 = Math.Max(c, a);
//Console.WriteLine("Max " + max2);

//int min = Math.Min(a, b);
//Console.WriteLine("Min " + min);
//int min1 = Math.Min(b, c);
//Console.WriteLine("Min " + min1);
//int min2 = Math.Min(c, a);
//Console.WriteLine("Min " + min2);

//Console.WriteLine("Max is: " + max1);
//Console.WriteLine("Min is: " + min2);

//Pow & Sqrt
//int x = 81;
//Console.WriteLine(Math.Sqrt(x));

//float y = 8, z = 3;
//Console.WriteLine(Math.Pow(8,3));

//GAME
/*
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so quang: ");

        int ornPieces = int.Parse(Console.ReadLine());

        int goldCoins = CaculateGoldCoins(ornPieces);

        Console.WriteLine("So vang nhan duoc: "+ goldCoins);
    }
    static int CaculateGoldCoins(int ornPieces)
    {
        int coins = 0;

        int firstPieces = Math.Min(ornPieces, 10);
        coins += firstPieces*10;
        coins -= firstPieces;

        int secondPieces = Math.Min(ornPieces, 5);
        coins += firstPieces*5;
        coins += secondPieces*5;

        int thirdPieces = Math.Min(ornPieces, 3);
        coins += thirdPieces*3;
        coins -= thirdPieces;

        coins += ornPieces;
        return coins;
    }
}*/
//BAI TAP VE NHA
//BAI 1
/*int num1 = 10;
int num2 = 3;

Console.WriteLine("num1 " + num1);
Console.WriteLine("num2 " + num2);

int sum = num1 + num2;
Console.WriteLine("Sum " + sum);

int different = num1 - num2;
Console.WriteLine("Different " +  different);

int product = num1 * num2;
Console.WriteLine("Product " +  product);

int quotient  = num1 / num2;
Console.WriteLine("Quotient " +  quotient);

int remainder  = num1 % num2;
Console.WriteLine("Remainder " +  remainder);*/

/*BAI 2
int num = 10;
int add = 5;

Console.WriteLine("Num is: " + num);
num += add;
Console.WriteLine("Num is: " + num);

int sub = 3;
Console.WriteLine("Num is: " + num);
num -= sub;
Console.WriteLine("Num is: " + num);

int mult = 2;
Console.WriteLine("Num is: " + num);
num *= mult;
Console.WriteLine("Num is: " + num);

int div = 4;
Console.WriteLine("Num is: " + num);
num /= div;
Console.WriteLine("Num is: " + num);

int mod = 3;
Console.WriteLine("Num is: " + num);
num /= mod;
Console.WriteLine("Num is: " + num);*/

/*BAI 3
int count = 5;
count++;
Console.WriteLine("Count is: " + count);
count--;
Console.WriteLine("Count is: " + count);

Console.WriteLine("Count is: " + count);
++count;
Console.WriteLine("Count is: " + count);

Console.WriteLine("Count is: " + count);
--count;
Console.WriteLine("Count is: " + count);
*/
/*
BAI 4
int a = 4;
int b = 10;

Console.WriteLine(a==b);
Console.WriteLine(a!=b);
Console.WriteLine(a>b);
Console.WriteLine(a<b);
Console.WriteLine(a>=b);
Console.WriteLine(a<=b);*/

//BAI 5
/*//1
bool a = true, b = false, c = true;
Console.WriteLine(a&&(b||!c));*/
/*//2
bool a = true, b = false, c = true;
Console.WriteLine(!a || (b && c));*/
/*//3
bool a = false, b = true, c = true;
Console.WriteLine(a && (b || !c));*/
/*//4
bool a = false, b = true, c = true;
Console.WriteLine(!a || (b && c));*/
/*//5
bool a = true, b = false, c = false;
Console.WriteLine(!a && (b || c));*/
/*//6
bool a = true, b = true, c = false;
Console.WriteLine(a && (b || c));*/
/*//7
bool a = false, b = false, c = true;
Console.WriteLine(!a || (b && c));*/
/*//8
bool a = false, b = true, c = false;
Console.WriteLine(a || (b && !c));*/
/*//9
bool a = true, b = false, c = false;
Console.WriteLine(!a || (b && !c));*/
/*//10
bool a = false, b = true, c = true;
Console.WriteLine(!a && (b || !c));*/

//BAI 6
/*//Hinh chu nhat
Console.WriteLine("Length is :");
double length = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Width is :");
double width = Convert.ToDouble(Console.ReadLine());
double per = (length + width) * 2;
double acr = length * width;
Console.WriteLine("Per is: " + per);
Console.WriteLine("Acr is: " +  acr);*/

/*//Hinh tron
Console.WriteLine("Radius is: ");
double r = Convert.ToDouble(Console.ReadLine());
double per = 2 * Math.PI * r;
double acr = Math.PI * r * r;
Console.WriteLine("Per is: " +  per);
Console.WriteLine("Acr is: " +  acr);*/

/*//Hinh vuong
Console.WriteLine("R is: ");
double a = Convert.ToDouble(Console.ReadLine());
double per = a * 4;
double acr = a * 2;
Console.WriteLine("Per is: " + per);
Console.WriteLine("Acr is: " + acr);*/

/*//Hinh tam giac
Console.WriteLine("a is: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b is: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b is: ");
double c = Convert.ToDouble(Console.ReadLine());

double per = a + b + c;
double acr = Math.Sqrt(per * (per - a) * (per - b) * (per - c));
Console.WriteLine("Per is: " +  per);
Console.WriteLine("Acr is: " + acr);*/

/*//Hinh binh hanh
Console.WriteLine("a is: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b is: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("h is: ");
double h = Convert.ToDouble(Console.ReadLine());
double per = 2 * a * b;
double acr = a * h;
Console.WriteLine("Per is: " + per);
Console.WriteLine("Acr is: " +  acr);*/



