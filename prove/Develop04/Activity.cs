public class Activity{

    protected string _activityName;
    protected int _activityTime;
   

    public Activity( int activityTime, string activityName){
        _activityTime = activityTime;
        _activityName = activityName;
    }


    public void WelcomMesage(){
        Console.WriteLine($"Wlcome to the {_activityName} activity\n");
        
    }

    public int getDuration(){
        Console.Write("How long, in seconds, would you like  for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _activityTime = userSeconds; 
        return userSeconds;
    }

    public void pauseProgram(int seconds){
        Console.Clear();
        SandWatch aniamtion = new SandWatch();
        aniamtion.RunAnimation();
    }

}

