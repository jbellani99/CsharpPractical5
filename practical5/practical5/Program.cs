using System;

public class MyClass
{

    public int[] arr =new int[] {1,2,3,4,5};
    public static void Main() {
       

        MyClass obj=new MyClass();
        try
        {
            for (int i = 0; i <= 5; i++)
            {

                Console.WriteLine($"{i}:{obj.arr[i]}");

            }



        }
        catch (IndexOutOfRangeException e)
        {


            Console.WriteLine(e.Message);
          

        }
        catch (Exception ex) {

            Console.WriteLine(ex.Message);
        
        }
        finally { 
            Console.WriteLine("Finally Block");
        }
    }
}