
namespace Session2
{
    internal class DangNgocMinhDung
    {
        public static void Main()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            Question_10();
        }
        /// <summary>
        /// to Add / Sum Two Numbers.
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Nhap so a =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b =");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
        }

        /// <summary>
        /// to Swap Values of Two Variables.
        /// </summary>
        public static void Question_02()
        {
            Console.Write("Nhap so a =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b =");
            int b = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine($"Gia tri moi cua a la {b}");
            Console.WriteLine($"Gia tri moi cua b la {a}");
        }


        /// <summary>
        /// to Multiply two Floating Point Numbers
        /// </summary>
        public static void Question_03()
        {
            Console.Write("Nhap so a =");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so b =");
            double b = double.Parse(Console.ReadLine());
            double tich = a * b;
            Console.WriteLine($"{a} * {b} = {tich}");
        }


        /// <summary>
        /// to convert feet to meter
        /// </summary>
        public static void Question_04()
        {
            Console.Write("Nhap so feet =");
            int a = int.Parse(Console.ReadLine());
            double b = a * 0.305;
            Console.WriteLine($"So {a} feet = {b} meter");
        }

        /// <summary>
        /// to convert Celsius to Fahrenheit and vice versa
        /// </summary>
        public static void Question_05()
        {
            Console.Write("Nhap so do =");
            float a = float.Parse(Console.ReadLine());
            double F = ((a * 9) / 5) + 32;
            double C = ((a - 32) * 5) / 9;
            Console.WriteLine($"{a} do Celcius = {F} do Fahreinheit ");
            Console.WriteLine($"{a} do Fahreinheit = {C} do Celcius ");
        }

        /// <summary>
        /// to find the Size of data types
        /// </summary>
        public static void Question_06()
        {
            Console.WriteLine("Size of int: " + sizeof(int));
            Console.WriteLine("Size of float: " + sizeof(float));
            Console.WriteLine("Size of double: " + sizeof(double));
            Console.WriteLine("Size of deciaml: " + sizeof(decimal));
            Console.WriteLine("Size of long: " + sizeof(long));
            Console.WriteLine("Size of short: " + sizeof(short));
        }

        /// <summary>
        /// to Print ASCII Value (tip: read character, print number of this char)
        /// </summary>
        public static void Question_07()
        {
            Console.WriteLine("Input the character: ");
            char character = char.Parse(Console.ReadLine());
            int ASCII = (int)character;
            Console.WriteLine("ASCII value: " + ASCII);
        }

        /// <summary>
        /// to Calculate Area of Circle
        /// </summary>
        public static void Question_08()
        {
            Console.Write("Nhap ban kinh =");
            double a = double.Parse(Console.ReadLine());
            const double Pi = 3.14;
            double Area = a * a * Pi;
            Console.WriteLine($"Dien tich hinh tron la {Area}");
        }

        /// <summary>
        /// to Calculate Area of Square
        /// </summary>
        public static void Question_09()
        {
            Console.Write("Nhap canh hinh vuong =");
            double a = double.Parse(Console.ReadLine());
            double Area = a * a;
            Console.WriteLine($"Dien tich hinh vuong la {Area}");

        }


        /// <summary>
        /// to convert days to years, weeks and days
        /// </summary>
        public static void Question_10()
        {
            Console.Write("Nhap so ngay: ");
            int numbDays = int.Parse(Console.ReadLine());
            int year = numbDays / 365;
            int week = (numbDays % 365) / 7;
            int day = (numbDays % 365) % 7;
            Console.WriteLine($"kq: {year} nam {week} tuan {day} ngay ");
        }
    }
}


