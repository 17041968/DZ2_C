//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходны
int value = new Random().Next(1, 7);
Console.Write("Выходной? " + " " + value);
switch (value)
{
	case 1:
		Console.WriteLine("Нет");
		break;
	case 2:
		Console.WriteLine("Нет");
		break;
	case 3:
		Console.WriteLine("Нет");
		break;
	case 4:
		Console.WriteLine("Нет");
		break;
	case 5:
		Console.WriteLine("Нет");
		break;
	case 6:
		Console.WriteLine("Да");
		break;
	case 7:
		Console.WriteLine("Да");
		break;
}
