               //..........  finding the shortest in the string array.........//

Console.WriteLine("Enter no.of words:");
int n= Convert.ToInt32(Console.ReadLine());
string[] str = new string[n];

Console.WriteLine("Enter words:");
for (int i = 0; i < n; i++)
{
    str[i]= Console.ReadLine();
}
string shortest = str[0];
for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length < shortest.Length)
    {
        shortest = str[i];
    }
}

Console.WriteLine($"The shortest word is: { shortest}");




                    //.........finding the word is present in list or not........//



Console.WriteLine("Enter a word to search:");
string word=Console.ReadLine();
bool b = false;
foreach (string s in str)
{
    
    if(s==word)
    {
        b = true;
    }
    
}
if (b)
{
    Console.WriteLine("The word is in the list");
}
else
{
    Console.WriteLine("......sorry!the word is not found..........");
}



              //.............    To sort the array in alphabetical order ...............//



Array.Sort(str);

Console.WriteLine("Sorted words are:");
foreach (string s in str)
{
    Console.WriteLine(s);
}

                           //........To find a palindrome word.............//





int count = 0;
foreach (string pal in str)
{
    int i = 0, j = pal.Length - 1;
    while (i < j)
    {
        if (pal[i] != pal[j])
            break;
        i++;
        j--;
    }

    if (i >= j)
    {
        count++;

        Console.WriteLine($"The palindrome word is {pal}");
    }
}

Console.WriteLine($"The palindrome count in the array is {count}");






