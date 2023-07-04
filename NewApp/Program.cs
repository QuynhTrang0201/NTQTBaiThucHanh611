// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("PTPMQL_Nhom_01");
//Console.WriteLine("Nhap ten cua ban: ");
//string name = Console.ReadLine();
//Console.WriteLine("Nhap tuoi cua ban: ");
//string tuoi = Console.ReadLine();
//Console.WriteLine("Hoc sinh :" + name + "," + "Tuoi :" + tuoi); 

//BTVN 
//Console.WriteLine("Danh Sach Khach Hang");
//Console.WriteLine("Nhap Ten Khach Hang : ");
//string Customer_Name = Console.ReadLine();
//Console.WriteLine("Nhap dia chi :");
//string Customer_Address = Console.ReadLine();
//Console.WriteLine("Khach hang :" + Customer_Name + "," + "Dia chi :" + Customer_Address);

internal class Program 
{
    private static void Main(string[] args)
    {
        //Khai bao bien kieu string va gan gia tri = Nguyen Van A 
        string hoTen = "Nguyen Van A";
        //Khai bao kieu in va gan gia tri =18 
        int tuoi = 18;
        Console.WriteLine("Sinh vien {0} - {1}toui",hoTen,tuoi);
    }
} 
    
    internal class Pro 
    {
        private static void Main(string[] args)
        {
            int a = 10;
            float b = a;
            System.Console.WriteLine("b =" +b);
        }
    } 
    internal class Change
{
    private static void Main(string[] args)
    {
        string str = "123";
        int a = int.Parse(str);
        System.Console.WriteLine("a = " + a);

    }
}
internal class Data
{
    private static void Main(string[] args)
    {
        string str = "123";//gia tri dau vao de chuyển đổi 
        int KetQua;// bien luu ket qua sau khi cuyển đổi 
        //bien kien tra chuyển đổi có thành công hay không 
        bool KiemTra = false;
        //Chuyển đổi kiểu dữ liệu 
        KiemTra = int.TryParse(str,out(KetQua));
        System.Console.WriteLine("Ket Qua = " + KetQua);
        
    }
} 

