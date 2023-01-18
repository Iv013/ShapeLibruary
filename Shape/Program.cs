
using ShapeLibruary;

class programm
{
    public static void Main()
    {
        


        AbstactShape[] shape = 
            {new Triangle(14,25,31),
             new Circle(4),
             new Triangle(3,1,1)};


        foreach (var s in shape)
        {
            Console.WriteLine(s.GetArea());

            if (s is Triangle)
            {
                var f =  s as Triangle;
                Console.WriteLine(f.IsRight); 
            }
        }


        var t = new Triangle(4,5,2);
  
        Console.WriteLine(t.GetArea());

        var t2 = new Triangle(4, 2, 3);
      
        Console.WriteLine(t2.GetArea());
        var C = new Circle(2);

        Console.WriteLine(C.GetArea());



    }
}
