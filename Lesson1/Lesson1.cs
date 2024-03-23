using System ;
namespace Lesson1{
   class Program {
          static void Main(){
             int a;
             Console.WriteLine("Enter the number:");
             a=Convert.ToInt32(Console.ReadLine());
              for(int i=1;i<=a;i++)
               {
                      if((i)%10==0)
                       {
                            Console.WriteLine(i);
                        }
                         Console.Write(i+"       ");
                }
            Console.ReadLine();
         }
    }
}