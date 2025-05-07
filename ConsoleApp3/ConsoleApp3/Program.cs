//שטח של היקף ושל של מלבן
//Console.WriteLine("enter my_length off the rectangle");
//int my_length = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter enter width off rectangle");
//int width = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("the area off the rectangle is: " + my_length * width);
//Console.WriteLine("the primeter off the rectangle: " + (2 * (my_length + width)));


//ממוצע של ערכים מתמטיים
//Console.WriteLine("enter first number");
//double num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter second number");
//double num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter third number");
//double num3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine((num1 + num2 + num3) / 3);
//Console.WriteLine("the low number is: " + Math.Min(Math.Min(num1, num2), num3));
//Console.WriteLine("the high number is: " + Math.Max(Math.Max(num1, num2), num3));

//ניתוח מחרוזת 
//Console.WriteLine("enter sentence");
//string sentence = Console.ReadLine();   
//Console.WriteLine(sentence.Length);
//Console.WriteLine(sentence.Contains("admin"));
//Console.WriteLine(sentence.StartsWith("user"));
//Console.WriteLine(sentence.ToUpper());


//מיון שלושה מספרים
//Console.WriteLine("enter first number");
//double num1 = double.Parse(Console.ReadLine());
//Console.WriteLine("enter second number");
//double num2 = double.Parse(Console.ReadLine());
//Console.WriteLine("enter third number");
//double num3 = double.Parse(Console.ReadLine());
//double max = Math.Max(num1,Math.Max(num2,num3));
//double min = Math.Min(num1,Math.Min(num2,num3));
//double middle = (num1 + num2 + num3) - max - min;
//Console.WriteLine($"max = {max} middle = {middle} max = {min}");


////תנאים
//string person = "person";
//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"enter {person} {i + 1} age");
//    int age = Convert.ToInt32(Console.ReadLine());
//    bool q1 = (age >= 25 && age <= 50);
//    if (q1)
//    {
//        Console.WriteLine($"enter {person} {i + 1} hair color");
//        string hair = Console.ReadLine();
//        bool q2 = ((hair == "brown") || (hair == "black"));
//        if (q2)
//        {
//            Console.WriteLine($"enter {person} {i + 1} hight");
//            int hight = Convert.ToInt32(Console.ReadLine());
//            bool q3 = ((hight >= 170) || (hight <= 185));
//            if (q3)
//            {
//                Console.WriteLine($"enter {person} {i + 1} job");
//                string job = Console.ReadLine();
//                bool q4 = ((job == "doctor") || (job == "hospitul manager"));
//                if ((q1) && (q2) && (q3) && (q4))
//                {
//                    Console.WriteLine($"{person} {i} is the Iranian say");
//                    break;
//                }
//            }

//        }
//    }
//}


//int a = 31;
//switch (a)
//{
//    case 0:
//        Console.WriteLine("no");
//        break;
//    case 30:
//        Console.WriteLine("yes");
//        break;
//    default:
//        Console.WriteLine("jhjh");
//        break;


//}


string file = "C:\\Users\\shuki\\creds.txt";
string content = File.ReadAllText(file);
Console.WriteLine(content);