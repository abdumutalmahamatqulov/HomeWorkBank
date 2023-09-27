namespace HomeWorkBank.Models;

public class Account : User
{
    public int AccountNumber;
    public string? CreatedDate;
    public string Cards = string.Empty;
    public string TotalBalance = string.Empty;

    public Account(int id, string firstName, string lastName, DateTime birthDAte, string phoneNumber) :
        base(id, firstName, lastName, birthDAte, phoneNumber)
    {

    }
}
