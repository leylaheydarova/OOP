using OOP.Models;
using System.Text;

string name = "Najiba";
name = "Leyla"; //mutable
//Console.WriteLine(name);

StringBuilder surname = new StringBuilder(); //immutable
surname.AppendLine("Valiyeva");
surname.Append("Heydarova");
//Console.WriteLine(surname.ToString());


//ikilik say sistemi (binary): 0, 1, meselen 100111001110010101010, 1 simvol 1 bitdir.
//8-lik say sistemi (octal) : 0, 1, 2, 3, 4, 5, 6, 7, meselen, 1 simvol 
//10-luq say sistemi (decimal) : 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, bizim istifade etdiyimiz
//16-liq say sistemi (hexadecimal) : 0, 1, 2, 3, 4, 5, 6, 7, 8 , 9, A, B, C, D, E, F, meselen F2A
//Console.WriteLine(Guid.NewGuid()); //Global Unique Identificator
                                   //b170873b-3465-433f-983f-24add1f2222eNacibaValiyeva-Cv.pdf
                                   //c270873b-3465-433f-983f-24add1f2222eNacibaValiyeva-Cv.pdf
                                   //1170873b-3465-433f-983f-24add1f2222eNacibaValiyeva-Cv.pdf
