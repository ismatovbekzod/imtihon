using System;
using System.Net.NetworkInformation;
// Console.Clear();

// Console dan raduisni qiymatini oling va erkanga doiraning yuzi (S=pi*radius^2) va 
// aylana uzunligini (L=2*pi*radius) erkanga chiqaring.
// Input: radius=3
// Output: S=28.2743338823081, L=18.8495559215388
// 1-vazifa
// System.Console.Write("Radiusni kiriting : ");
// string radius = Console.ReadLine()!;
// int r = Convert.ToInt32(radius);
// const double pi = 3.14;

// double s = pi*Math.Pow(r,2);
// double l = 2*pi*r;
// System.Console.WriteLine("Yuzi : " + s);
// System.Console.WriteLine("Aylana uzunligi : " + l);


//2-vazifa
// Bir valyutadagi summani sumga aylantiruvchi dastur tuzing. Summa va valyuta kursini 
// e’lon qiling va konvertatsiya qilingan summani hisoblang. Natijani ekranga chiqaring.
// Input: qiymat=2, kurs=12400 so’m
// Output: 24800 so’m
// ----------------
// Input: qiymat=7.6, kurs=12400 so’m
// Output: 94240 so’m
// System.Console.WriteLine("Dollarni so'mda hisoblab beramiz. ");
// System.Console.Write("Nechi dollarni hisoblatmoqchisiz : ");
// string dol = Console.ReadLine()!;
// double dollar = Convert.ToInt32(dol);

// int kurs = 12400;
// System.Console.WriteLine($"Xozirda kurs {kurs} shunca. KURS O'ZGARIB TURISHI MUMKIN !!!");
// double som = dollar*kurs;
// System.Console.WriteLine(som);



// 3-vazifa
// Foydalanuvchining tug’ilgan yilini (int x) consoledan oling. Uning yoshini kunlarda 
// ifodalang. Kabisa yilini hisobga olmang
// Input: x=2004
// Output: 6935
// -----------------
// Input: x= 1996
// Output: 9855

System.Console.Write("yilni kiriting : ");
string yil = Console.ReadLine()!;
int yosh = Convert.ToInt32(yil);
System.Console.WriteLine((2023-yosh)*365);