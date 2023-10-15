using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer rigo= new Customer("Rigó János", 18, "2100 Gödöllő", "rj@gmail.com", "30/555 1545");
            Customer sas = new Customer("Sas József", 53, "2146 Mogyoród", "sj@gmail.com", "20/555 4145");
            Customer solyom= new Customer("Sólyom Sára", 42, "2025 Visegrád", "ss@gmail.com", "70/555 7789");
            Customer roka = new Customer("Róka Rudolf", 27, "2040 Budaőrs", "rr@gmail.com", "50/555 1256");
            Customer varju = new Customer("Varjú Viola", 35, "1131 Budapest", "vs@gmail.com", "28/555 444");

            BankAccount rigojanos = new BankAccount("Rigó János", 153246, "124-445", "lakossági", new DateTime(2021, 11, 27), true);
            BankAccount sasjozsef = new BankAccount("Sas József", 3415800, "123-778", "üzleti", new DateTime(2022, 04, 30), true);
            BankAccount solyomsara = new BankAccount("Sólyom Sára", 52700, "126-778", "lakossági", new DateTime(2022, 12, 07), true);
            BankAccount rokarudolf = new BankAccount("Róka Rudolf", 0, "124-588", "lakossági", new DateTime(2023, 01, 03), false);
            BankAccount varjuviola = new BankAccount("Varjú Viola", 812456, "123-145", "üzleti", new DateTime(2020, 05, 13), true);


            Console.WriteLine("***** Ügyfél műveletek *****");
            Console.WriteLine("\nÜgyfél adatok: ");
            Console.WriteLine();
           
            rigo.PrintCustomerInfo();
            sas.PrintCustomerInfo();
            solyom.PrintCustomerInfo();
            roka.PrintCustomerInfo();
            varju.PrintCustomerInfo();

            Console.WriteLine();
            Console.WriteLine("Frissítések: ");
            Console.WriteLine();

            varju.UpdateCustomerInfo("Kovácsné Varjú Viola", 35, "1131 Budapest", "vs@gmail.com", "28 / 555 444");
            varju.PrintCustomerInfo();

            roka.UpdateCustomerInfo("Róka Rudolf", 27, "2100 Gödöllő", "rokar@gmail.com", "50/555 1256");
            roka.PrintCustomerInfo();

            Console.WriteLine();
            Console.WriteLine("Vásárlások:");
            Console.WriteLine();

            rigo.PlaceOrder("igazolás", 2);
            sas.PlaceOrder("pénzváltás", 1);
           
            Console.WriteLine();
            Console.WriteLine("Támogatási kérés:");
            Console.WriteLine();

            solyom.RequestSupport("Hitelt szeretnék felvenni, 2 millió FT összegben, 10 éves futamidőre.");
            rigo.RequestSupport("Hitel visszafizetési halasztást szertnék. 3 hónapra.");

            Console.WriteLine();
            Console.WriteLine("Visszajelzés:");
            Console.WriteLine();

            solyom.SendFeedback("Kérelemhez hiánypótlást kérünk!");
            rigo.SendFeedback("Halasztás elfogadva!");

            Console.WriteLine();
            Console.WriteLine("***** Bankszámla műveletek *****");
            Console.WriteLine("\nBankszámla tulajdonosok listája:");
            Console.WriteLine();
            
            rigojanos.PrintAccountInfo();
            sasjozsef.PrintAccountInfo();
            solyomsara.PrintAccountInfo();
            rokarudolf.PrintAccountInfo();
            varjuviola.PrintAccountInfo();

            Console.WriteLine();
            Console.WriteLine("Számla lezárás:");
            Console.WriteLine();

            sasjozsef.CloseAccount();
            sasjozsef.CloseAccount();

            Console.WriteLine();
            Console.WriteLine("Átutalás:");
            Console.WriteLine();

            solyomsara.TransferFundsTo(rokarudolf, 10000);
            solyomsara.TransferFundsTo(varjuviola, 10000);
           

            Console.WriteLine();
            Console.WriteLine("Típusváltás:");
            Console.WriteLine();

            varjuviola.UpdateAccountType("lakossági");


            Console.ReadLine();
        }
    }
}
