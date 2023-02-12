public class Fraction{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
         _top = top;
        _bottom = bottom;
    }
    public int SetTop(int top){
        _top = top;
        return top;
    }

    public int GetTop(){
        return _top;
    }

    public int SetBottom(int bottom){
        return _bottom;
    }

    public int GetBottom(){
        return _bottom;
    }

    public string GetFractionString(){
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public double GetDecimalValue(){
        float result = _top /_bottom;
        return result;

    }
}