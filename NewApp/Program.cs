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
internal class Data2 
{
    private static void Main(string[] args)
    {
        string str = "123"; //gia tri dau vao de chuyển đổi 
        //chuyển đổi kiểu dữ liệu string (giá trị ="123")
        //sang kểu dữ liệu int ( giá trị sau khi chuyển đổi = 123 )
        int a = Convert.ToInt32(str);
        System.Console.WriteLine("a =" + a);
    }
}

internal class ToanTu
{
    private static void Main(string[] args)
    {
        int a,b; //Khai bao hai bien so a và b kieu int 
        //thong bao cho nguoi dung nhap vào a
        System.Console.Write(" a = ");
        //doc du lieu nhạp vào từ bàn phím chuyển sang kiểu int và gán cho a 
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write(" b = ");
        //doc du lieu nhạp vào từ bàn phím chuyển sang kiểu int và gán cho a 
        b = Convert.ToInt32(Console.ReadLine());
        // in tổng a + b ra ngoài màn hình 
        System.Console.WriteLine("{0} + {1} = {2}",a,b,a+b);
    

    }
}
internal class ReNhanh
{
    private static void Main(string[] args)
    {
        float a = 10;
        if(a>=8){
            System.Console.WriteLine("Hoc sinh hoc luc gioi");
        }
        else if (a>= 6.5){
              System.Console.WriteLine("Hoc sinh hoc luc kha");
        }
        else if(a>=5){
            System.Console.WriteLine("Hoc sinh hoc luc TB");

        }
         else if(a>=3.5){
           System.Console.WriteLine("Hoc sinh hoc luc yeu");  
        } else 
        {
            System.Console.WriteLine("Hoc sinh hoc luc kem");  
        }

}
}
internal class ReNhanh2
{
    private static void Main(string[] args)
    {
        int a = 10;
        if(a<0)
        {
            System.Console.WriteLine("{0} la so nguyen am", a);  
        }else {
            if(a % 2 == 0) {
            System.Console.WriteLine("{0} la so nguyen duong chan", a);  
            } else {
             System.Console.WriteLine("{0} la so nguyen duong le", a);  
            }
        }
    }
}
internal class ReNhanh3
{
    private static void Main(string[] args)
    {
        int day = 2;
        switch(day)
        {
            case 1:  System.Console.WriteLine("Chu nhat"); break;
            case 2:  System.Console.WriteLine("Thu 2"); break;
            case 3:  System.Console.WriteLine("Thu 3"); break;
            case 4:  System.Console.WriteLine("Thu 4"); break;
            case 5:  System.Console.WriteLine("Thu 5"); break;
            case 6:  System.Console.WriteLine("Thu 6"); break;
            case 7:  System.Console.WriteLine("Thu 7"); break;
            default :
            System.Console.WriteLine("Khong phai ngay trong tuan");
            break;


        }
    }
}
internal class VongLap
{
    private static void Main(string[] args)
    {
        for(int i = 0; i < 10; i++)
        {
            System.Console.WriteLine("Vong lap thu {0}",i);
        }
    }
}
internal class VongLap2
{
    private static void Main(string[] args)
    {
        int a = 1;
        while (a < 10)
       {
            System.Console.WriteLine("Vong lap thu {0}",a);
        // tang a len 1 don vi de dam bao co luc a>=10
        // a >=10 thi vong lap se ket thuc 
        a++;
        }
    }
}
internal class VongLap3
{
    private static void Main(string[] args)
    {
        int a = 1;
        do
       {
            System.Console.WriteLine("Vong lap thu {0}",a);
        // tang a len 1 don vi de dam bao co luc a>=10
        // a >=10 thi vong lap se ket thuc 
        a++;
        }while(a < 10);
    }
}
internal class BR
{
    private static void Main(string[] args)
    {
        for(int i = 0; i < 10; i++)
        {
            if(i==5) break;
            System.Console.WriteLine("Vong lap thu {0}",i);
        }
    }
}
internal class CTN
{
    private static void Main(string[] args)
    {
        for(int i = 0; i < 10; i++)
        {
            if(i==5) continue;
            System.Console.WriteLine("Vong lap thu {0}",i);
        }
    }
}



