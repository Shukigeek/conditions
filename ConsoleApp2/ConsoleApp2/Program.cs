//שאלה 26
//Console.WriteLine("enter first number ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("enter second number");
//int b = int.Parse(Console.ReadLine());
//int div = a / b;
//int remainder = a % b;
//double realDivision = (double)a / b;
//using System.ComponentModel.DataAnnotations;

//int x = 5;

//שאלה 27
//string name;
//Console.WriteLine("enter your name");
//name = Console.ReadLine();
//Console.WriteLine("Hello " + name);

//שאלה 28
//int y = 6;
//Console.WriteLine(x + y);

//שאלה 29
//double a = 7.5;
//double b = 3.2;
//Console.WriteLine((a + b)/2);

//using System.ComponentModel.DataAnnotations;

//שאלה 30
//Console.WriteLine("write a birthday blessing");
//string bless = Console.ReadLine();
//Console.WriteLine(bless.Length);

//שאלה 31
//Console.WriteLine("write your name");
//string name = Console.ReadLine();
//Console.WriteLine("enter your age");
//int age;
//bool res = int.TryParse(Console.ReadLine(), out age);
//if (res)
//{
//    Console.WriteLine("Hello " + name + " in 5 years you would be " + (age + 5));
//}
//else
//{
//    Console.WriteLine("you did not enter a llegal number");
//}

//שאלה 32
//Console.WriteLine("enter string");
//string sentence = Console.ReadLine();
//Console.WriteLine("enter number");
//int number = int.Parse(Console.ReadLine());
//for (int i = 0; i < number; i++)
//{
//    Console.WriteLine(sentence);
//}

//שאלה 33
//int a = 1;
//int b = 2;
//int c = 4;
//Console.WriteLine((a + b + c)/3);

//שאלה 34 
//Console.WriteLine("enter word");
//string word = Console.ReadLine();
//Console.WriteLine(word.ToUpper());

//שאלה 35
//Console.WriteLine("enter age");
//int age = Convert.ToInt32(Console.ReadLine());
//if (age > 18)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}


//שאלה 36
//string a = "3";
//Console.WriteLine(Convert.ToInt32(a));

//שאלה 37
//Console.WriteLine("enter word");
//string a = Console.ReadLine();
//Console.WriteLine("enter word");
//string b = Console.ReadLine();
//Console.WriteLine(a == b);

////שאלה 38
//int a;
//Console.WriteLine("enter number");
//a = Convert.ToInt32(Console.ReadLine());
//if (a%2 == 0) {
//    Console.WriteLine($"{a} is even");
//}
//else
//{
//    Console.WriteLine($"{a} is un even");
//}

////שאלה 39
//Console.WriteLine("enter word");
//string a = Console.ReadLine();
//Console.WriteLine(a.Substring(0,1) == "A");


//שאלה 40
//Console.WriteLine("enter number");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num * num);


//שאלה 41
//Console.WriteLine("enter your hight in sentimaters");
//double hight = int.Parse(Console.ReadLine());
//Console.WriteLine($"you hight is {hight / 100} maters and it {hight / 2.54} inchs");


//שאלה 42 
//Console.WriteLine("enter number");
//bool a = int.TryParse(Console.ReadLine(),out int b);
//Console.WriteLine(a);


//שאלה 43
//Console.WriteLine("enter num1");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("enter num2");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("choose triangle or square");
//string shape = Console.ReadLine();
//if (shape == "triangle")
//{
//    Console.WriteLine($"the triangle size is: {(a * b) / 2}");
//}
//else if (shape == "square")
//{
//    Console.WriteLine($"the square size is: {a * b}");
//}


//שאלה 44
//Console.WriteLine("enter your full name");
//string name = Console.ReadLine();
//Console.WriteLine(name.Substring(name.IndexOf(" "), (name.Length)- name.IndexOf(" ")));

//שאלה 45

Console.WriteLine("enter num");
int a = Convert.ToInt32(Console.ReadLine());
bool res = false;
int b = 0;
if (a > 0)
{
    for (int i = 0; i < a; i++)
    {
        if (i * i == a)
        {
            res = true;
            b = i;
            break;
        }
        else if (i * i > a)
        {
            res = false;
            break;
        }
    }
    if (res)
        Console.WriteLine($"{a} is a squre number of {b}");
    else
        Console.WriteLine($"{a} is not a squre number");
}
else
{
    Console.WriteLine("negative numbers dosn't have squre");
}


    