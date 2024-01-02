using System;

// Console.Clear();

// System.Console.WriteLine("Son kiriting : ");
// int son = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Soz kiriting : ");
// string soz = Console.ReadLine()!;

// int soz_uzunlik = soz.Length;
// Console.Clear();
// if (son > soz_uzunlik)
// {
//     System.Console.WriteLine(soz.ToUpper());
// }
// else
// {
//     System.Console.WriteLine(soz.ToLower());
// }


// System.Console.WriteLine("birinchi sonni kiriting ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("ikkinchi sonni kiriting ");
// int y = Convert.ToInt32(Console.ReadLine());


// string res;

// if (x > y){
//     res = "X katta Y dan";
//     }
// else if(x < y){
//     res = "Y katta X dan";
// }
// else{
//     res = "X va Y teng";
// }
// System.Console.WriteLine(res);

System.Console.WriteLine("Hafta kunini kiriting : ");
string kun = Console.ReadLine()!;
kun = kun.ToLower();
string translator = kun switch
{
    "dushanba" => "Monday",
    "seshanba" => "Tuesday",
    "chorshanba" => "Wednesday",
    "payshanba" => "Thursday",
    "juma" => "Friday",
    "shanba" => "Saturday",
    "yakshanba" => "Sunday",
    _ => "Bunday hafta kuni yo'q"
};
System.Console.WriteLine(translator);