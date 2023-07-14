namespace NewApp.Models
{
    public class Student : Person
    {
        public string StudentCode {get;set;}
        public void EnterData()
    {
        //Ke thua lai phương thuc o Person
        base.EnterData();
        //Phat trien them nhap thông tin Student Code 
        System.Console.Write("Student Code = ");
        StudentCode = Console .ReadLine();
        
    }
    public void Display ()
    {
        // ke thua lai phương thuc o Person 
        base.Display();
        //phat trien hien thi thong tin Studen 
        System.Console.Write("-Ma sinh vien : {0}", StudentCode);
    }
    public void Mang()
    {
        System.Console.Write("Nhap so hoc sinh cua mot lop : ");
        int n = Convert.ToInt32(Console.ReadLine());
        
    }
    
    }

  
    }
