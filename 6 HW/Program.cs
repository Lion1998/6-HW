bool b = true;
int[] array = new int[3];
Console.WriteLine("Please choose 3 numbers to create a palindrome ");
while (b)
{
    for (int i = 0; i < array.Length; i++) 
    {
        int.TryParse(Console.ReadLine(), out array[i]);
    }
    if (array[0] == array[2])
    {
        b = false;
        Console.WriteLine("true");
    }
    else 
    {
        b = true;
        Console.WriteLine("Try again");
    }
}


