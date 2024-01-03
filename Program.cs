using System;
using System.Diagnostics;

Console.Clear();


//1-misol 
// 1 dan 1000 gacha bo’lgan toq sonlarni yig’indisini ekranga chiqaradigan dastur tuzing. While loop dan foydalaning!
// int i = 1;
// int sum = 0;
// while(i <= 1000)
// {
//     if(i % 2 == 1)
//     {
//         sum += i;
//     }
//     i++;
// }
// System.Console.WriteLine(sum);

//2-misol
// Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasini ekranga chiqaradigan dastur tuzing. For loop dan foydalaning!

// int[] arr = {5,3,2,3,4,5,7,9};
// int min = arr[0];
// int max = arr[0];
// for(int i = 0;i < arr.Length;i++)
// {
//     if(min > arr[i]){
//         min = arr[i];
//     }
//     if(max < arr[i]){
//         max = arr[i];
//     }
// }
// System.Console.WriteLine($"Eng kichik son : {min} Eng katta son {max} Ko'paytmasi {min  * max}");

// 3-misol
// Consolga int tipidagi butun son kiritilgan => int x
// x! (x factorial) ni hisoblaydigan dastur tuzing.

System.Console.WriteLine("Nechi sonini factorialni topmoqchisiz :");
int x = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for(int i = 1;i <= x;i++){
    sum *= i;
}
System.Console.WriteLine(sum);