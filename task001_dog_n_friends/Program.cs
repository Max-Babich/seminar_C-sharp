using System.Globalization;
 
IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };


Console.Write("Enter the speed of the first friend (meters per second):");
float ffs = float.Parse(Console.ReadLine(), formatter);  //ffs-fist friend speed
Console.Write("Enter the speed of the second friend (meters per second):");
float sfs = float.Parse(Console.ReadLine(), formatter); // sfs-second friend speed
Console.Write("Enter the speed of the dog (meters per second):");
float ds = float.Parse(Console.ReadLine(), formatter); //ds-dog speed
Console.Write("Enter the distance between friends (meters):");
float distance = float.Parse(Console.ReadLine(), formatter);
int friend = 2;
int count = 0;
float time =0;

while (distance >5)
{
    if (friend ==1) 
    {
        time = distance/(ffs+ds);
        friend = 2;
    }
    else 
    {
        time = distance/(sfs+ds);
        friend = 1;
    }
    distance = distance-(ffs+sfs)*time;
    count++;
}
Console.WriteLine("The dog will run "+count+ " times");