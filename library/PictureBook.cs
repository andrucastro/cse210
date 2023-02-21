public class PictureBook : Book {

public string _illustrator;

public string GetIllustrator(){
    return _illustrator;
}

public void SetIllustrator(string illustrator){
    _illustrator = illustrator;
}

 public string GetPictureInformation(){
        return $"{_title} by {_author} illustrated by {_illustrator}";
    }
}
