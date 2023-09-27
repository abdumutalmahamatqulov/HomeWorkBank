using HomeWorkBank.Models;

namespace HomeWorkBank.Interfaces
{
    public interface IAccountSettings
    {
        void  CreateAccount(Account account);
        void UpdateAccount(Account account);
        void RemoveAccount(Account account);
        void GetAllAccounts();
    }
}
