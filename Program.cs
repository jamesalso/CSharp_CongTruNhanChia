internal class Program
{
    ///
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Hello Word!");
        Console.WriteLine("Chuong Trinh Tong 2 So");
        int so1, so2, tong, hieu, tich;
        Console.Write("Nhap so 1: ");
        so1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so 2: ");
        so2 = Convert.ToInt32(Console.ReadLine());

        tong = so1 + so2;
        Console.WriteLine("Tong cua 2 so " + so1 + " và " + so2 + " la: " + tong);

        hieu = so1 - so2;
        Console.WriteLine("Hieu cua 2 so " + so1 + " và " + so2 + " la: " + hieu);

        tich = so1 * so2;
        Console.WriteLine("Tich cua 2 so " + so1 + " và " + so2 + " la: " + tich);

        double thuong;
        try
        {
            thuong = so1 / so2;
            Console.WriteLine("Thuong cua 2 so " + so1 + " và " + so2 + " la: " + thuong);
        }
        catch {
            Console.WriteLine("Khong the chia cho 0");
        }
    }
}