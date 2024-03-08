using System.Numerics;
using System.Text;
using Microsoft.VisualBasic;

namespace grpc.Helpers;

public class Helper
{
    public int Fact(int input){
        if(input == 0)
            return 1;
        else
            return input * Fact(input-1);
    }

    public int Raise(int a, int b){
        return (int)Math.Pow(a, b);
    }

    public int Fibo(int input){
        int num0 = 0;
        int num1 = 1;
        int num2;
		
        for(int i = 3; i <= input; i++){
            num2 = num0 + num1;

            num0 = num1;
            num1 = num2;
        }
        return num0;
    }

    public string RepeatLine(string line, int repeat){
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < repeat; i++)
        {
        
            stringBuilder.Append(line);
        }
        return stringBuilder.ToString();
    }

    public string Reverse(string s){
        return Strings.StrReverse(s);
    }

    public int Wordsnumber(string s){
        string[] sArr = s.Split(" ");
        return sArr.Length;
    }

    public int SumInBetween(int a, int b){
        int res = 0;
        int rep = b - a;
        for (int i = 0; i <= rep; i++)
        {
            res = res + a;
            a += 1;
        }

        return res;
    }

    public bool IsTriangleExist(int x1, int y1, int x2, int y2, int x3, int y3){

        var l1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        var l2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        var l3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

        return l1<l2+l3;
    }

    public int RectSqrt(int height, int width){
        return height * width;
    }
    public int RectPerimeter(int height, int width){
        return (height + width)*2;
    }
    public double RoundSqrt(int radius){
        return Math.PI * Math.Pow(radius,2);
    }

    public double SqrtToRadius(int width){
        return width / Math.Sqrt(2);
    }

    public double CelsiusToFahrenheit(int t){
        return  (t * 9)/5 + 32;
    }

    public Complex ComplexMulti(int real1, int imaginary1, int real2, int imaginary2){
        var a = new Complex(3, -1);
        var b = new Complex(5, -3);
        return a*b;
    }
    public Complex ComplexDivide(int real1, int imaginary1, int real2, int imaginary2){
        var a = new Complex(3, -1);
        var b = new Complex(5, -3);
        return a/b;
    }
    public bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));
          
        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;
    
        return true;        
    }
    public int GCF(int a, int b){
        int a1 = a;
        int b1 = b;
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }
        return (a1*b1)/a;
    
    }
    public int GCD(int a, int b)
    {
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    
    }
}