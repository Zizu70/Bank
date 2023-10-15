using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        public string OwnerName { get; set;}
        public decimal Balance { get; set;}
        public string AccountNumber { get; set;}
        public string AccountType { get; set;}
        public DateTime AccountOpeningDate { get; set;}
        public bool IsAccountActive { get; set;}

        // konstruktor
        public BankAccount(string ownerName, decimal balance,  string accountNumber, string accountType, DateTime accountOpeningDate, bool isAccountActive)
        {
            OwnerName = ownerName;
            Balance = balance;
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountOpeningDate = accountOpeningDate;
            IsAccountActive = isAccountActive;
            
        }
       
        //OK//Kiírja a bankszámla adatait a konzolra.
        public void PrintAccountInfo()
        {
            Console.WriteLine("Számlatulajdonos adatai: "); 
            Console.WriteLine($"\tNév: {OwnerName}, \n\tSzámlaegyenleg: {Balance},  \n\tSzámlaszáma: {AccountNumber},  \n\tSzámla típus: {AccountType},  \n\tSzámla nyitás dátuma: {AccountOpeningDate},  \n\tSzámla állapota: {IsAccountActive} ");
        }

        // Lezárja a bankszámlát.
        
        public void CloseAccount()
        {
            if (IsAccountActive)
            {
                IsAccountActive = false;
                Console.WriteLine($"{OwnerName} ügyfél bankszámlája lezárva.");
                Console.WriteLine($"Számlán lévő {Balance} Ft pénztárban kifizetve.");
            }
            else
            {
                Console.WriteLine("Bankszámla már zárolva.");
            }
        }

        //ok//Pénzátutalást végez a jelenlegi számláról a célbankszámlára a megadott összeggel. //void TransferFundsTo(BankAccount destinationAccount, decimal amount) - Pénzátutalást végez a jelenlegi számláról a célbankszámlára a megadott összeggel.

        public void TransferFundsTo(BankAccount destinationAccount, decimal amount) 
        {
           if (Balance >= 0 && IsAccountActive && amount >0 && destinationAccount.IsAccountActive)
            {
                Balance -= amount;
                destinationAccount.Balance += amount;
                Console.WriteLine($"Tranzakció sikeres. A célszámlára {amount} Ft átutalásra került."); //
                Console.WriteLine($"{OwnerName} új egyenlege: {Balance} Ft.");
                
            }else 
            {
                Console.WriteLine($"Tranzakció sikertelen! Nincs elég fedezet vagy nem megfelelő a cél számla száma.");
            }
            
            
        }

        //ok//Frissíti a bankszámla típusát az új típussal. 
        //void UpdateAccountType(string newAccountType) - Frissíti a bankszámla típusát az új típussal.

        public void UpdateAccountType(string newAccountType)
        {
            AccountType = newAccountType;
            Console.WriteLine($"Típusváltás végrehajtva: {OwnerName} *** {newAccountType}");
        }
    }
}
