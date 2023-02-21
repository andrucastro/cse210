public class Breathing : Activity{
    
    public Breathing(int activityTime, string activityName) : base(activityTime, activityName){

    }   

    public void displayDescription(){
        Console.WriteLine("This activity will help you to relax by walking your thorught in and out solowly. Clear your mind  and focus on your breathing\n");
    }

    public void Breath(int seconds){  

        int mutiple = 2;
        while(seconds % mutiple != 0 ){
        Console.Write(mutiple);
        mutiple += 1; 
        }
        int iterations = seconds/mutiple;
        
        for(int i = 0; i < iterations; i++){
            Console.Write($"Breath in...{i}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b"); 
        }
       
    }

}
