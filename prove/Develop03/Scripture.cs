class Scripture{
    private string _book;
    private string _chapter;
    private string _verses;
    private string _text;

    public Scripture(){
        _book = "Proverbs";
        _chapter = "3";
        _verses = "5-6";
        _text = "5: Trust in the Lord with all thine heart; and lean not unto thine own understanding. \n6: In all thy ways acknowledge him, and he shall direct thy paths.";
    }

    public Scripture(string book, string chapter, string verses, string text){
        _book = book;
        _chapter = chapter;
        _verses = verses;
        _text = text;
    }

    public string getText(){
        return _text;
    }

    public string getReference(){
        return $"{_book} {_chapter}:{_verses}";
    }

    }

    

    
