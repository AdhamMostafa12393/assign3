using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assign3
{
    internal class Program
    {
        /*
        //1
        static void passvalue(int x)
        {
            x = 2;
        }
        static void passrefrance(ref int y)
        {
            y = 2;
        }


        //2
        class MyClass
        {
            public int Value;
        }
        static void ObjectByValue(MyClass obj)
        {
            obj.Value = 100;
            obj = new MyClass();    
            obj.Value = 200;
        }

        static void ObjectByReference(ref MyClass obj)
        {
            obj = new MyClass();
            obj.Value = 300;
        }
        

        //3

        static void sumSubtract(int s1,int s2, int s3 , int s4 ,ref int sum , ref int subrct)
        {

            sum = s1 + s2;
            subrct = s3 - s4;
        }

        //4
        
        
        static void sumdigits(int n,ref int res)
        {
            while (n!=0)
            {
                res += n % 10;
                n = n / 10;
            }
        }
        
        //5

        static bool IsPrime(int n) 
        {
            
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;

        }
        

        //6
        static void maxMin( int []x,int len, ref int max, ref int min)
        {
            for (int i = 0; i < len; i++) { 
                if (x[i] > max) 
                    max = x[i];
                if (x[i] < min) 
                    min = x[i];
            
            }
        }

        

        //7

        static void factorial(int f) 
        {
            int s = 1,m=f;
            while (f > 0) {
                s *= f;
                f--;
            }
            Console.WriteLine($"the factorial of {m} is {s}");
        }
        
        //8

        static string ChangeChar(string original, int index, char newChar)
        {
            if (index < 0 || index >= original.Length)
            {
                return original;
            }

            char[] chars = original.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }
        */
        static void Main(string[] args)
        {
            /*
            #region 1
            // call by value we change the value in the scope of the function , call by refrance we edit in the memory the value with our hand
            int x = 1;
            Console.WriteLine($"the value is {x}");
            passvalue(x);
            Console.WriteLine($"the value after call by value :{x}");
            passrefrance(ref x);
            Console.WriteLine($"the value after call by refrance :{x}");
            #endregion 
            #region 2
            //We change the value only inside the scope of the function,We go directly into memory and change the original value with our hands.

            MyClass myObj = new MyClass();
            myObj.Value = 10;

            ObjectByValue(myObj);
            Console.WriteLine("After ChangeObjectByValue: " + myObj.Value);  

            ObjectByReference(ref myObj);
            Console.WriteLine("After ChangeObjectByReference: " + myObj.Value);  
            #endregion
            

            #region 3
            int num1,num2,num3,num4,sum=0,subtract=0;
            Console.WriteLine("enter number for num1");
            num1= int.Parse(Console.ReadLine());
            Console.WriteLine("enter number for num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number for num3");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number for num4");
            num4 = int.Parse(Console.ReadLine());
            sumSubtract(num1, num2, num3, num4,ref sum,ref subtract);
            Console.WriteLine($"the sum of num1 and num 2 is {sum} \nthe subtract of num3 and mum4 is {subtract}");
            #endregion
            
            #region 4
            int sumDigits = 0, num;
            Console.WriteLine("enter number to sum digits");
            num=int.Parse(Console.ReadLine());
            sumdigits(num,ref sumDigits);
            Console.WriteLine($"the sum of digits is {sumDigits}");
            #endregion

            
            #region 5

            int  num;
            Console.WriteLine("enter number to check if prime");
            num = int.Parse(Console.ReadLine());
            if (IsPrime(num))
                Console.WriteLine("is prime");
            else 
                Console.WriteLine("is not prime");

            #endregion


            

            #region 6
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int max=int.MinValue;
            int min=int.MaxValue;
            maxMin(x,x.Length,ref max,ref min);
            Console.WriteLine($"the max is {max} the min is {min}");
            #endregion

            

            #region 7
            int num;
            Console.WriteLine("enter number to get factorial");
            num = int.Parse(Console.ReadLine());
            factorial(num);
            #endregion

            
            


            #region 8

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            Console.Write("Enter index to change: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Enter new character: ");
            char newChar = char.Parse(Console.ReadLine());
            string result = ChangeChar(word, index, newChar);
            Console.WriteLine("Modified word: " + result);


            #endregion
            */

        }
    }
}
