
//BTVN : Xd chuong trinh cho phép người dùng nhập thông tin sv , điểm môn học rồi tính điểm trung bình các môn học 
 public class SinhVien
{
       public static void Main (string[] args )
    {
        System.Console.WriteLine("Nhap ten sinh vien:   ");
        string Name = Console.ReadLine()!;
        System.Console.WriteLine("Nhap ma so sinh vien:   ");
        string ID = Console.ReadLine()!;
            double a,b,c;
            System.Console.Write("Điem Toan =  ");
            a = Double.Parse(Console.ReadLine()!);
            System.Console.Write("Điem Anh =  ");
            b = Double.Parse(Console.ReadLine()!);
            System.Console.Write("Diem Hóa =  ");
            c = Double.Parse(Console.ReadLine()!);
            double ĐTB = (a + b + c ) /3;
            System.Console.WriteLine("Điem Trung Binh La = {0}",ĐTB);
    }
}
