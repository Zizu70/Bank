using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank
{
    internal class Customer
    {
        public string CustomerName { get; set; }
        public int CustomerAge { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }


        public List<string> Order { get; set; }
        public List<string> SupportRequests { get; set; }
        public List<string> SendFeedbacks { get; set; }

        //konstruktor
        public Customer(string customerName, int customerAge, string customerAddress, string customerEmail, string customerPhoneNumber)
        {
            CustomerName = customerName;
            CustomerAge = customerAge;
            CustomerAddress = customerAddress;
            CustomerEmail = customerEmail;
            CustomerPhoneNumber = customerPhoneNumber;

            Order = new List<string>();
            SupportRequests = new List<string>();
            SendFeedbacks = new List<string>();
        }

        // Ügyfél adatok kiíratása:
        public void PrintCustomerInfo() 
        {
            Console.WriteLine("Az ügyfél adatai: ");
            Console.WriteLine($" \tNév: {CustomerName}, \n\tKor: {CustomerAge},\n\tCím: {CustomerAddress}, \n\tEmail: {CustomerEmail}, \n\tTelefonszáma: {CustomerPhoneNumber}");
          
        }
       
        public override string ToString()
        {
            return $"2Az ügyfél adatai: neve: {CustomerName}, kora: {CustomerAge}, címe: {CustomerAddress}, email: {CustomerEmail}, telefonszáma: {CustomerPhoneNumber}";
        }

        // Ügyfél adatainak frissítése az új adatokkal 

        public void UpdateCustomerInfo(string newName, int newAge, string newAddress, string newEmail, string newPhoneNumber)
        {
           
            CustomerName = newName;
            CustomerAge = newAge;
            CustomerAddress = newAddress;
            CustomerEmail = newEmail;
            CustomerPhoneNumber = newPhoneNumber; 
        }

        //Termékrendelés:

        public void PlaceOrder(string product, int quantity) 
        {
             Console.WriteLine($"{CustomerName} ügyfél rendelése: {product} szolgáltatásból {quantity} darab.");
        }
        
        // Ügyfél támogatási kérés rögzítés:

        public void RequestSupport(string supportRequest) 
        {
            SupportRequests.Add(supportRequest);
            Console.WriteLine($"{CustomerName} ügyféltámogatás kérelem:  *** {supportRequest}");
        }

        // Ügyfél visszajelzés rögzítése:

        public void SendFeedback(string feedback) 
        {
            SendFeedbacks.Add(feedback);
            
            Console.WriteLine($"{CustomerName} ügyfél visszajelzése: *** {feedback}");
        }
    }
}
