class Logic{

public Logic(){

}

public Scripture getScripture(){

    Console.WriteLine("Enter the scripture you wnat to memorize");
    Console.Write("Book: ");
    string book = Console.ReadLine();
    Console.Write("Chapter: ");
    string chapter = Console.ReadLine();
    Console.Write("verses: ");
    string verses = Console.ReadLine();
    Console.Write("Type the scripture here: ");
    string _text = Console.ReadLine();

    Scripture scripture = new Scripture(book,chapter,verses,_text);
    return scripture;
}

   public void hideWords(Scripture userScripture){
            WordsHandler handler = new WordsHandler(userScripture.getText());
            string input = "";
            int counter = 0;
            while(input != "quit"){
                handler.DisplayScripture(userScripture.getReference());
                handler.HideWord();
                Console.WriteLine();
                input = Console.ReadLine();
                counter += 1;
                Console.Clear();
                // compare number of hiden words attempts with the number of words of the scripture 
                  if (counter > handler.getWordsCount()){
                    // kill the program
                    input ="quit";  
                }
                }
                Console.WriteLine("Program is over");
        }

}