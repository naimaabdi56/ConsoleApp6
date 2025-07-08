using System; 

class Program
{
    static void Main() 
    {
        
        Console.Write("Gali magaca: ");
        string name = Console.ReadLine(); 

      
        Console.Write("Gali ID-ga ardayga: ");
        int id = Convert.ToInt32(Console.ReadLine()); 

       
        Random quiz = new Random(); 

        int sax = 0;      
        int khalad = 0;   

       
        for (int i = 1; i <= 3; i++)
        {
            int a = quiz.Next(1, 20); 
            int b = quiz.Next(1, 20); 
            int result = a + b;    

            Console.Write($"Q{i}: {a} + {b} = ");
            int answer = Convert.ToInt32(Console.ReadLine()); 

            if (answer == result) 
            {
                Console.WriteLine("Sax!");
                sax++;
            }
            else 
            {
                Console.WriteLine("Khalad!");
                khalad++;
            }
        }

        
        int boqolley = sax * 100 / 3;

        
        Console.WriteLine("\nOutput");
        Console.WriteLine("Magaca\tID\tT.Sax\tT.Khalad\tBoqolley");
        Console.WriteLine($"{name}\t({id})\t{sax}\t{khalad}\t\t{boqolley}");
    }
}