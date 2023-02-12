public class Team {
private string _name;
private List<Player> _roster = new List<Player>();
private int _wins = 0;
private int _loses = 0;

public Team(string name){
    _name = name;
}
public void AddPlayer(Player p){
    _roster.Add(p);
}

public void DisplayRoster(){
    Console.WriteLine();
    Console.WriteLine(_name);
    foreach (Player p in _roster){
        Console.WriteLine("---------------------------");
    }
    Console.WriteLine();
}  
    public void GetName(){  
        
    }
       
};