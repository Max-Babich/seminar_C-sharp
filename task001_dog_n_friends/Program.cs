Console.Write("Enter the speed of the first friend (meters per second):");
string oper = Console.ReadLine();
float ffs = float.Parse(oper);  //ffs-fist friend speed
Console.Write("Enter the speed of the second friend (meters per second):");
string oper1 = Console.ReadLine();
float sfs = float.Parse(oper1); // sfs-second friend speed
Console.Write("Enter the speed of the dog (meters per second):");
string oper2 = Console.ReadLine();
float ds = float.Parse(oper2); //ds-dog speed
Console.Write("Enter the distance between friends (meters):");
string oper3 = Console.ReadLine();
float distance = float.Parse(oper3);
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