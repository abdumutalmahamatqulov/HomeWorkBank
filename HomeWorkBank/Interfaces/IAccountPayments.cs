using HomeWorkBank.Models;

namespace HomeWorkBank.Interfaces;

public interface IAccountPayments
{
    void Withdraw(Account account, Card card, double ammount);
    void Deposit(Account account, Card card, double ammount);
    void CreateCard(Account account, Card card);
    void RemoveCard(Account account, Card card);

}
