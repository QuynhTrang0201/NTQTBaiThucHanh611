using System.Collections;
using NewApp .Models;
      ArrayList arrListPerson = new ArrayList();
            int i = Convert.ToInt16((Console.ReadLine()));
            for(i = 0; i<3; i++)
                {
                //Khai bao 1 doi tuong trong class Person 
                Person ps = new Student();
                //Nhap thong tin cho doi tương Person  
                ps.EnterData();
                //Add vao ArrayList
                arrListPerson.Add(ps);
                }
            foreach(Person ps in arrListPerson)
            {
                ps.Display();
            }
      //Sua thong tin 
            //Person ps1 = new Person ();
            //ps1.EnterData();
            //arrListPerson[1] =ps1;
            //foreach (Person ps in arrListPerson)
            //{
                //ps.Display();
            //}
            int intIndex = -1;
            while(intIndex < 0 || intIndex >= i)
            {
                System.Console.WriteLine("Nhap chi so cua phan tu muon sua: ");
                intIndex = Convert.ToInt32(Console.ReadLine());
            //khai bao mot phan tu Person moi 
            Person psUpdate = new Person();
            psUpdate.EnterData();
            //Gan phan tu moi vao phan tu co index = intIndex
            arrListPerson[intIndex] = psUpdate;
            }
    
         



//using NewApp.Models;   
   //GPT gpt = new GPT();
   // gpt.GPTBac1();
    //gpt.GPTBac2();

    //Fruit fr = new Fruit();
    //fr.InputFruit();
    //fr.DisplayFr();

    //Employee mpl = new Employee ();
   //mpl.Input();
   //mpl.Display();  
//public class Progarm
//{
    //private static void Main(string[] args)
    //{
        //khoi tao 2 doi tuong 
        //Person ps1 = new Person();
        //Person ps2 = new Person();
        //gan gia tri cho thuoc tinh ps1
        //ps1.FullName = "Nguyen Van A";
        //ps1.Address = "Ha Noi";
        //ps1.Age = 18;
        //goi phuong thuc hien thi thong tin
        //ps1.Display();
        //ps2.Display();
        //Person ps = new Person ();
        //string str = " Nguyen Van C";
        //int a =22; 
        //ps.Display2(str,a);
        //Console.WriteLine("{0} sinh nam {1}", str , ps.GetYearOfBirth(a));
       
    //}
    //private static void Main(string[] args) {
        
    //}

//}

          