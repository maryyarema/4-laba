using System;
using System.Text;
using System.Reflection;


namespace ClassBox
{
    public class Startup
    {
        public class Box
        {
            public Box(double length, double width, double height)
            {
                this.Lenght = length;
                this.Width = width;
                this.Height = height;
            }

            public double Lenght { get; set; }

            public double Width { get; set; }

            public double Height { get; set; }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Surface Area - {((2 * this.Lenght * this.Width) + (2 * this.Lenght * this.Height) + (2 * Width * Height)):f2}");
                sb.AppendLine($"Lateral Surface Area - {((2 * this.Lenght * this.Height) + (2 * this.Width * this.Height)):f2}");
                sb.Append($"Volume - {(this.Lenght * this.Height * this.Width):f2}");

                return sb.ToString();
            }
        }
        public static void Main()
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            var box = new Box(length, width, height);
            Console.WriteLine(box);
        }
    }

}