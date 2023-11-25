using System;

public class Library
{
    private string adress { set; get; }
    private int countBooks { set; get; }
    private int countPeople { set; get; }
    private string nameMain { set; get; }
    private string kvartal { set; get; }
    public Library(string adress, int countBooks, int countPeople, string nameMain, string kvartal)
    {
        this.adress = adress;
        this.countBooks = countBooks;
        this.countPeople = countPeople;
        this.nameMain = nameMain;
        this.kvartal = kvartal;
    }
    public string GetAdress()
    {
        return adress;
    }
    public int SetAdress(string adress)
    {
        this.adress = adress;
        return 1;
    }
    public int GetCountBooks()
    {
        return countBooks;
    }
    public int SetCountBooks(int countBooks)
    {
        this.countBooks = countBooks;
        return 1;
    }
    public int GetCountPeople()
    {
        return countPeople;
    }
    public int SetCountPeople(int countPeople)
    {
        this.countPeople = countPeople;
        return 1;
    }
    public string GetNameMain()
    {
        return nameMain;
    }
    public int SetNameMain(string nameMain)
    {
        this.nameMain = nameMain;
        return 1;
    }
    public string GetKvartal()
    {
        return kvartal;
    }
    public int SetKvartal(string kvartal)
    {
        this.kvartal = kvartal;
        return 1;
    }
    public void SearchKvartal(string kvartal)
    {
        if (this.kvartal == kvartal)
        {
            Console.WriteLine($"{this.adress}");
        }
    }
    public void SearchCountPeople(int countPeople)
    {
        if (this.countPeople >= countPeople)
        {
            Console.WriteLine($"{this.adress}");
        }
    }
    public void SearchCountBooks(int countBooks)
    {
        if (this.countBooks >= countBooks)
        {
            Console.WriteLine($"{this.adress}");
        }
    }
    public void SearchNameMain(string nameMain)
    {
        if (this.nameMain == nameMain)
        {
            Console.WriteLine($"{this.adress}");
        }
    }
    class program
    {
        public static void Main()
        {
            Library[] libraries = new Library[3] { new Library("Omskiy omsk, 51", 100000, 13400, "Rukovodilov Imen Imenovich", "Omskiy"), new Library("Moskovsiy omsk, 532", 7762282, 3848, "Markov Vasya Krasavech", "Amur"), new Library("Kirgizkiy omsk, 123", 143, 7623, "Danilov Egor Egorovich", "Amur") };
            Console.Write("Paйон: ");
            string SearchingKvartal = Console.ReadLine();
            for (int i = 0; i < libraries.Length; i++) { libraries[i].SearchKvartal(SearchingKvartal); }
            Console.Write("Кол-во поситителей: ");
            int SearchingCountPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < libraries.Length; i++) { libraries[i].SearchCountPeople(SearchingCountPeople); }
            Console.Write("Кол-во книг: ");
            int SearchingCountBooks = int.Parse(Console.ReadLine());
            for (int i = 0; i < libraries.Length; i++) { libraries[i].SearchCountBooks(SearchingCountBooks); }
            Console.Write("ФИО Рук-я: ");
            string SearchingNameMain = Console.ReadLine();
            for (int i = 0; i < libraries.Length; i++) { libraries[i].SearchNameMain(SearchingNameMain); }
            Console.ReadKey();
        }
    }
}
