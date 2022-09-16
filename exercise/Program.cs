Console.WriteLine("введите текст");
string text = Console.ReadLine();

void FindLessThanThreeCharacters(string verifiable)
{
    char[] separators = new char[] { ' ', ',' };
    string[] array = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[i] = array[i];
        }

    }

    for (int i = 0; i < result.Length; i++)
    {

        Console.Write($"{result[i]} ");
    }
}

FindLessThanThreeCharacters(text);