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
        private int bankCode;       // Minimale Länge 10 (8 mit Prüfcode 10)
        private string number;         // if < 10 stelle, füllen mit 0
        private double balance;


        // Konstruktoren
        public Account(string countryCode, int bankCode, double number)
        {
            if (countryCode.Length != 2) throw new Exception("Der Länder-Code kann nur 2 Zeichen enthalten.", new ArgumentException("Bitte geben sie max. 2 Zeichen an."));
            if (Convert.ToString(bankCode).Length != 8) throw new Exception("Die Bankleitzahl muss 8 Ziffern beinhalten und darf nicht mit einer 0 beginnen.", new ArgumentException("Bitte geben sie max. 8 Zeichen an."));
            if (number < 1) throw new Exception("Die Kontonummer darf nicht unter 1 sein.", new ArgumentException("Bitte geben sie max. 8 Zeichen an."));
            if (number > 9999999999) throw new Exception("Die Kontonummer darf nicht mehr wie 10 Stellen besitzen.", new ArgumentException("Bitte nutzen sie max. 10 Zeichen für die Kontonummer."));
            if (Convert.ToString(number).Length < 10)
            {
                int missing = 8 - Convert.ToString(number).Length;
                string bankNumber = Convert.ToString(number);
                string newNumber = "0";
                for(int i = 1; i < missing; i++)
                {
                    newNumber += 0;
                }
                newNumber += bankNumber;
                this.number = newNumber;

            } else {
                this.number = Convert.ToString(number);
            }
            this.countryCode = countryCode;
            this.bankCode = bankCode;
            balance = 0;
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

        public string Number
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
                return countryCode + CalcCheckDigit() + bankCode + number;
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

        private string CalcCheckDigit()
        {
            string temp = null;
            string[] res = null;
            if (countryCode == "DE")
            {
                temp = bankCode + "" + number + "" + 131400;
                Console.WriteLine(temp);
                temp = Convert.ToString(Convert.ToDecimal(temp) / 97);
                Console.WriteLine(temp);
                res = temp.Split(',');
                res[1] = res[1].Remove(2);
                res[1] = Convert.ToString(98 - Convert.ToDouble(res[1]));
                // Prüfziffer wird falsch ausgerechnet!!!!
            }
            return res[1];
        }
    }
}
