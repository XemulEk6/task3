//  Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int Nember = Convert.ToInt32(Console.ReadLine());


            if (Nember % 2 == 1)
            {
                Console.WriteLine($"Число {Nember} является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число {Nember}является: ЧЁТНЫМ");
            }