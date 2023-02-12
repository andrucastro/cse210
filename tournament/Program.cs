// See https://aka.ms/new-console-template for more information

Team firebirds = new Team("Firebirds");

Player john = new Player("john Andrsen", 12);
Player tim = new Player("Tim Nunn", 13);

firebirds.AddPlayer(john);

firebirds.AddPlayer(tim);

firebirds.DisplayRoster();


Team goodguys = new Team("Goodguys");

Player andres = new Player("Andres Castro", 01);
Player felipe = new Player("felipe Guevara",99);

goodguys.DisplayRoster();