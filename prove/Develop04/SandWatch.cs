public class SandWatch{

public void frame1(){
    Console.WriteLine("Get Redy");
    Console.WriteLine(".......");
    Console.WriteLine(".*****.");
    Console.WriteLine(" .***. ");
    Console.WriteLine("  .*. ");
    Console.WriteLine(" .   . ");
    Console.WriteLine(".     .");
    Console.WriteLine(".......");
   
}

public void frame2(){
    Console.WriteLine("Get Redy");
    Console.WriteLine(".......");
    Console.WriteLine(".     .");
    Console.WriteLine(" .***. ");
    Console.WriteLine("  .*. ");
    Console.WriteLine(" .***. ");
    Console.WriteLine(".     .");
    Console.WriteLine(".......");
   
}

public void frame3(){
    Console.WriteLine("Get Redy");
    Console.WriteLine(".......");
    Console.WriteLine(".     .");
    Console.WriteLine(" .   . ");
    Console.WriteLine("  .*. ");
    Console.WriteLine(" .***. ");
    Console.WriteLine(".*****.");
    Console.WriteLine(".......");
   
}

public void frame4(){
    Console.WriteLine(" ");
    Console.WriteLine(".......");
    Console.WriteLine(".     .");
    Console.WriteLine(" .   . ");
    Console.WriteLine("  . . ");
    Console.WriteLine(" .   . ");
    Console.WriteLine(".     .");
    Console.WriteLine(".......");
   
}

public void RunAnimation(){
    for(int i = 0; i <=3; i++){
            frame1();
            Thread.Sleep(1000);
            Console.Clear();

            frame2();
            Thread.Sleep(1000);
            Console.Clear();

            frame3();
            Thread.Sleep(1000);
            Console.Clear();

            frame4();
            Thread.Sleep(1000);
            Console.Clear();
       }

  } 
}