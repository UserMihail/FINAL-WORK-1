// Вывести слова меньше либо равные трем символам.

Console.Clear();

Console.WriteLine("Enter words: ");
string? array = Console.ReadLine();

string[] word = array.Split(' '); 

for(int i = 0; i < word.Length; i++)
{
    if(word[i].Length < 4)
    {
        Console.WriteLine($"[{word[i]}]");
    }

}    