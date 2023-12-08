//Odd or even -> ungerade oder gerade

int a = 11;
 

int result = a % 2;             //% shows the remainder after divison with 2

Console.WriteLine(result);

//switch method
switch(result)
{
    case 0:
        Console.WriteLine($"{a} is an even number");
        break;
    case 1:
        Console.WriteLine($"{a} is an odd number");
        break;
    default:
        Console.WriteLine("Invalid value");
        break;
}


//if method

//if(result == 0)
//{
//    Console.WriteLine($"{a} is an even number");
//}
//else
//{
//    Console.WriteLine($"{a} is an odd number");
//}