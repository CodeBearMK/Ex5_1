namespace Ex5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Rectangle rectangle = new Rectangle();
            Diamond diamond = new Diamond();
            Parallelogram parallelogram = new Parallelogram();
            int item = 0;
            while (true)
            {
                Console.Write("請選擇形狀 (1.三角形  2.矩形  3.菱形  4.平行四邊形  0.離開)--->");
                item = int.Parse(Console.ReadLine());

                if (item == 1)
                {
                    Console.Write("請輸入 底 -->");
                    triangle.Num1 = int.Parse(Console.ReadLine());
                    Console.Write("請輸入 高 -->");
                    triangle.Num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("三角形： 底 = {0}，高 = {1}，面積為 {2}", triangle.Num1, triangle.Num2, triangle.CalArea());
                    Console.WriteLine("\n");
                }
                else if (item == 2)
                {
                    Console.Write("請輸入 長 -->");
                    rectangle.Num1 = int.Parse(Console.ReadLine());
                    Console.Write("請輸入 寬 -->");
                    rectangle.Num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("矩形： 長 = {0}，寬 = {1}，面積為 {2}", rectangle.Num1, rectangle.Num2, rectangle.CalArea());
                    Console.WriteLine("\n");
                }
                else if (item == 3)
                {
                    Console.Write("請輸入 對角線1 -->");
                    diamond.Num1 = int.Parse(Console.ReadLine());
                    Console.Write("請輸入 對角線2 -->");
                    diamond.Num2 = int.Parse(Console.ReadLine());
                    Console.Write("菱形： 對角線1 = {0}，對角線2 = {1}，面積為 {2}", diamond.Num1, diamond.Num2, diamond.CalArea());
                    Console.WriteLine("\n");

                }
                else if (item == 4)
                {
                    Console.Write("請輸入 底 -->");
                    parallelogram.Num1 = int.Parse(Console.ReadLine());
                    Console.Write("請輸入 高 -->");
                    parallelogram.Num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("平行四邊形： 底 = {0}，高 = {1}，面積為 {2}", parallelogram.Num1, parallelogram.Num2, parallelogram.CalArea());
                    Console.WriteLine("\n");
                }
                else
                {
                    break;
                }
            }
            Console.Read();
        }
    }
}