// *,/,+,-,^, sqrt, sin, cos, tan, ctan
double a, b, c, d;
string str;
Console.WriteLine("Enter operand: +,-,*,/,^,sqrt,sin,cos,tan,ctan ");
str = Console.ReadLine();
if(str == "sqrt"){
Console.WriteLine("Enter c: ");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Sqrt(c));}

else if(str == "sin"){
    Console.WriteLine("Enter d: ");
    d = Convert.ToDouble(Console.ReadLine());
    double radian = d * Math.PI / 180;
    Console.WriteLine(Math.Sin(radian));
}
else if(str == "cos"){
    Console.WriteLine("Enter d: ");
    d = Convert.ToDouble(Console.ReadLine());
    double radian = d * Math.PI / 180;
    Console.WriteLine(Math.Cos(radian));
}
else if(str == "tan"){
    Console.WriteLine("Enter d: ");
    d = Convert.ToDouble(Console.ReadLine());
    double radian = d * Math.PI / 180;
    Console.WriteLine(Math.Tan(radian));
}
else if(str == "ctan"){
    Console.WriteLine("Enter d: ");
    d = Convert.ToDouble(Console.ReadLine());
    double radian = d * Math.PI / 180;
    Console.WriteLine(1/Math.Tan(radian));
}
else if(str == "+"){
    Console.WriteLine("Enter a: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter b: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(a + b);
}
else if(str == "-"){
    Console.WriteLine("Enter a: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter b: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(a - b);
}
else if(str == "*"){
    Console.WriteLine("Enter a: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter b: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(a * b);
}
else if(str == "/"){
    Console.WriteLine("Enter a: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter b: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(a / b);
}
else if(str == "^"){
    Console.WriteLine("Enter a: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter b: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(Math.Pow(a,b));
}
