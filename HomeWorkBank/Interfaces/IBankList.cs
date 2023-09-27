
using HomeWorkBank.Models;

namespace HomeWorkBank.Interfaces
{
    public interface IBankList
    {
        void CreateBank(Bank newBank);
        void UpdateBank(Bank bank);
        void RemoveBank(Bank bank);

        void GetAllBanks();

    }
}
