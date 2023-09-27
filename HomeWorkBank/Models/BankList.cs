using HomeWorkBank.Interfaces;

namespace HomeWorkBank.Models;

public class BankList :IBankList 
{
    List<Bank> banks = new List<Bank>();
   int TotalCount { get => banks.Count; }

    public void CreateBank(Bank newBank)
    {
        throw new NotImplementedException();
    }

    public void GetAllBanks()
    {
        throw new NotImplementedException();
    }

    public void RemoveBank(Bank bank)
    {
        throw new NotImplementedException();
    }

    public void UpdateBank(Bank bank)
    {
        throw new NotImplementedException();
    }
}
