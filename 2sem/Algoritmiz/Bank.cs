using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank
{
    class Account
    {
        public int Id;
        public string Name;
        public double Income;
        public double Outcome;
        public double Tax;

        public Account(int id, string name, double income, double outcome)
        {
            Id = id;
            Name = name;
            Income = income;
            Outcome = outcome;
            Tax = Math.Round(Income * 0.05, 2);
        }
        public void WriteAccountnfo()
        {
            Console.WriteLine($"Cчет: {Id}\n\tБаланс: {Income - Outcome - Tax}\n\tХозяин счета: {Name}\n\tДоходы: {Income}\n\tРасходы: {Outcome}\n\tНалог: {Tax}");
        }
    }
    class Bank
    {
        List<Account> Accounts;
        public Bank()
        {
            Accounts = new List<Account>();
        }
        public void FillBase()
        {
            for (int i = 0; i < 10; i++)
            {
                Accounts.Add(GenerateAccount(i));
                Thread.Sleep(1);
            }
        }
        string[] firstNames = { "Третьяков", "Лебедев", "Егоров", "Кузнецов", "Логинов", "Гаврилов", "Семенов", "Буров", "Крылов", "Григорьев" };
        string[] secondNames = { "Даниил", "Максим", "Сергей", "Марк", "Игорь", "Давид", "Михаил", "Дмитрий", "Роман", "Денис" };
        string[] thirdNames = { "Олегович", "Ильич", "Георгиевич", "Петрович", "Даниилович", "Александрович", "Сергеевич", "Артемович", "Андреевич", "Федорович" };
        public Account GenerateAccount(int id)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            return new Account(id, $"{firstNames[random.Next(0, 9)]} {secondNames[random.Next(0, 9)]} {thirdNames[random.Next(0, 9)]}", random.Next(0, 200) * 1000, random.Next(0, 200) * 1000);
        }
        public void WriteAll()
        {
            foreach (Account account in Accounts)
            {
                account.WriteAccountnfo();
            }
        }
        public void NegativeBalanceAccounts()
        {
            Console.WriteLine("Счета с отрицательным Балансом:");
            Accounts.Where(account => (account.Income - account.Outcome - account.Tax) < 0).ToList().ForEach(account => Console.WriteLine($"Cчет: {account.Id} ФИО владельца: {account.Name}\n\tБаланс: {account.Income - account.Outcome - account.Tax}"));
        }
        public void CountPositivBalanceAccounts()
        {
            Console.WriteLine("Колличество счетов с положительным балансом:");
            Console.WriteLine(Accounts.Where(account => (account.Income - account.Outcome - account.Tax) > 0).ToList().Count());
        }
        public void ClientsWithMaxIncome()
        {
            Console.WriteLine("Клиенты с максимальным доходом");
            double maxIncome = Accounts.OrderByDescending(account => account.Income).First().Income;
            Accounts.Where(account => account.Income == maxIncome).ToList().ForEach(account => Console.WriteLine($"Счет: {account.Id} ФИО владельца: {account.Name}\n\tДоход: {account.Income}"));
        }
        public void TaxSum()
        {
            Console.Write("Сумма налогов: ");
            double sum = Accounts.Select(account => account.Tax).ToList().Sum();
            Console.WriteLine(sum);
        }
    }
    class Program
    {
        public static void Main()
        {
            Bank bank = new Bank();
            bank.WriteAll();
            bank.FillBase();
            bank.NegativeBalanceAccounts();
            bank.CountPositivBalanceAccounts();
            bank.ClientsWithMaxIncome();
            bank.TaxSum();
            Console.ReadKey();
        }
    }
}