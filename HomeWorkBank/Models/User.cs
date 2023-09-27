namespace HomeWorkBank.Models;

public class User
{
    public int Id;
    public string FirstName = string.Empty;
    public string LastName = string.Empty;
    public DateTime BirthDate;
    public string? PhoneNumber;
    public User(int id, string firstName, string lastName, DateTime birthDAte, string phoneNumber) =>
        (Id, FirstName, LastName, BirthDate, PhoneNumber) = (id, firstName, lastName, birthDAte, phoneNumber); 
}
