namespace HomeWorkBank.Models;
public class Bank
{
    public int Id;
    public string Name = string.Empty;
    public DateTime FoundedDate;
    public string Address = string.Empty;
    public string PhoneNumber = string.Empty;

    public Bank(int id, string name, DateTime foundeddate, string address, string phonenumber) =>
        (Id, Name, FoundedDate, Address, PhoneNumber) = (id, name, foundeddate, address, phonenumber);
}
