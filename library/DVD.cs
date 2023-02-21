public class DVD : Lonable{
    private string _dvdName;
    private int _id;
    private int _duration;



       public void ShowDVD(){
        Console.WriteLine($" {_dvdName} {_duration} {_id}");
    }
}