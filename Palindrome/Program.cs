//Напишите метод, который проверяет является ли
//переданное число «палиндромом». Число передаётся в
//качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
//Палиндром — число, которое читается одинаково как
//справа налево, так и слева направо. Например:
//1221 — палиндром;
//3443 — палиндром;
//7854 — не палиндром.

bool palindrom(string n)
{
    for (int i = 0, j = n.Length-1; i < n.Length / 2; i++, j--)
    {
        if (n [i] != n [j])
            return false;
    }
    return true;
}

Console.WriteLine("Input number");
string n =  Console.ReadLine();
if (palindrom(n))
    Console.WriteLine($"{n} - Palindrom");
else
    Console.WriteLine($"{n} - is not Palindrom");