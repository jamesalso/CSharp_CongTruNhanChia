internal class Program
{
    ///
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Hello Word!");
        Console.WriteLine("Chuong Trinh Tong 2 So");
        int so1, so2;
        Console.Write("Nhap so 1: ");
        so1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so 2: ");
        so2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Tong cua 2 so " + so1 + " và " + so2 + " la: " + tinhTong(so1, so2));
        Console.WriteLine("Hieu cua 2 so " + so1 + " và " + so2 + " la: " + tinhHieu(so1, so2));
        Console.WriteLine("Tich cua 2 so " + so1 + " và " + so2 + " la: " + tinhTich(so1, so2));

        try
        {
            Console.WriteLine("Thuong cua 2 so " + so1 + " và " + so2 + " la: " + tinhThuong(so1, so2));
        }
        catch {
            Console.WriteLine("Khong the chia cho 0");
        }
    }

    private static int tinhTong(int a, int b)
    {
        return a + b;
    }

    private static int tinhHieu(int a, int b)
    {
        return a - b;
    }

    private static int tinhTich(int a, int b)
    {
        return a * b;
    }

    private static double tinhThuong(double a, double b)
    {
        return a / b;
    }
}