namespace NewApp.Models
{
    public class Fruit
    {

        public string FruitName { get; set;}
        public float Gia { get; set; }
        public void InputFruit()
        {
            
            System.Console.WriteLine("Nhap vao ten :");
            FruitName = Console.ReadLine();
            System.Console.WriteLine("Gia la :");
            Gia = Convert.ToSingle(Console.ReadLine());

        }
        public void DisplayFr()
        {
            
            System.Console.WriteLine("Ten qua {0} - Gia {1} ",FruitName,Gia);
        }
    }
}