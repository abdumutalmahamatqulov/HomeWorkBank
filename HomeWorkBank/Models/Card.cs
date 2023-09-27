namespace HomeWorkBank.Models;

public class Card
{
    public int Number;
    public string Holder = string.Empty;
    public string ValidDate = string.Empty;
    public string? Type;
    public string? Balance;
    public Card(int number, string holder, string validDAte, string type, string balance) =>
        (Number, Holder, ValidDate, Type, Balance) = (number, holder, validDAte, type, balance);

}
