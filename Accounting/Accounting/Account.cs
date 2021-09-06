using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    class Account
    {
        // Attribute
        private string countryCode; // Maximale/Minimale Länge 2 // Nur Buchstaben
        private int bankCode;       // Minimale Länge 10
        private int number;         // if < 10 stelle, füllen mit 0
        private double balance;
        private static int accountAmount = 1000000000;

        // Konstruktoren
        public Account(string countryCode, int bankCode)
        {
            this.bankCode = bankCode;
            this.countryCode = countryCode;
            number = accountAmount;
            balance = 0;
            accountAmount++;
        }

        public Account(string countryCode, int bankCode, int number)
        {
            this.bankCode = bankCode;
            this.countryCode = countryCode;
            this.number = number;
            balance = 0;
        }

        public Account(string countryCode, int bankCode, int number, double balance)
        {
            this.bankCode = bankCode;
            this.countryCode = countryCode;
            this.number = number;
            this.balance = balance;
        }

        // Eigenschaften
        public string CountryCode
        {
            get
            {
                return countryCode;
            }
        }

        public int BankCode
        {
            get
            {
                return bankCode;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }
        }

        public string IBAN
        {
            get
            {
                return null;
            }
        }

        // Methoden
        public void Deposit(double amount)
        {
            balance = balance + amount; // Hier Check einbauen if amount is (-)
        }

        public void Debit(double amount)
        {
            balance = balance - amount; // Hier Check einbauen if amount is (-) oder if amount < balance
        }

        private int CalcCheckDigit()
        {
            string temp;
            if(countryCode == "DE")
            {
                temp = bankCode + "" + number + "" + 131400;
            }
            return null;
        }
    }
}
