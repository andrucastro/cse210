public class Lonable{
     bool _isCheckedIn = true;

     public void CheckOut(){
        _isCheckedIn = false;
     }
     public void CheckIn(){
        _isCheckedIn = true;
     }

     public void Display(){
        Console.WriteLine($"Avaiable: {_isCheckedIn}");
    }

    
}