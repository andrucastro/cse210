class WordsHandler{
    private List<string> _words = new List<string>();
    private List<int> _hidenW = new List<int>();

    public int getWordsCount(){
      return _words.Count;
    }
    public int getHidenWCount(){
      return _hidenW.Count;
    }

    public List<string> getWords(){
      return _words;
    }

    public WordsHandler(string text){
      // Divide the text of the scripture in words and store them in an array
      foreach(string word in text.Split(" ")){
          _words.Add(word);
      }
    }

    public void DisplayScripture(string reference){
      Console.WriteLine(reference);
      // Display all the words from the list in order 
      foreach(string word in _words){
      Console.Write(word + " ");
      }
    }

    public void HideWord(){
      // Create a random number   
        Random numGenerator = new Random();
        int index = numGenerator.Next(-1,_words.Count);

      // If the index already exist in the list update the random number 
        while(_hidenW.Contains(index)){
        index = numGenerator.Next(-1,_words.Count);
        }

      // loop through the array and hide the word
        for(int i = 0; i < _words.Count; i++){
          if( i == index){

           // store the lenght of the variable 
           int length = _words[i].Length;
           // remove all the letters from the word 
           _words[i] ="";

           // replace the words by dashes
           for(int it = 0; it < length ; it++){
              _words[i] +="_";
           }
          }

      //add to a list the index of each hidden word
        _hidenW.Add(index);

      }
    }
}


