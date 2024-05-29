using System;
namespace Auditories
{
    internal class Menu
    {
        public static void StartMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Fill list\n" +
                    "2. Input auditorium\n" +
                    "3. Change floor or number\n" +
                    "4. Sort auditories\n" +
                    "5. Exit");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        FillListAuditories(); break;
                    case 2:
                        FillAuditorium(); break;
                    case 3:
                        ChangeData(); break;
                    case 4:
                        SortAud(); break;
                    case 5:
                        Exit(); break;
                    default:
                        break;
                }
            }
        }
        public static void Wait() 
        {
            Console.WriteLine("Press 'enter' to continue");
            Console.ReadKey();
        }
        private static void FillAuditorium()
        {
            Console.Clear();
            Console.Write("Input:\n".PadLeft(6, ' ') + "\tfloor: ");
            byte floor = byte.Parse(Console.ReadLine());
            Console.Write("\tauditorium number: ");
            byte auditorium = byte.Parse(Console.ReadLine());
            Console.Write("\tnumber of seats: ");
            byte countSeats = byte.Parse(Console.ReadLine());
            Console.Write("\tpresence of projector(0 or 1): ");
            bool projector = Convert.ToBoolean(byte.Parse(Console.ReadLine()));
            Console.Write("\tpresence of computers(0 or 1): ");
            bool computers = Convert.ToBoolean(byte.Parse(Console.ReadLine()));
            Auditories.AddAud(floor, auditorium, countSeats, projector, computers);
        }
        private static void FillListAuditories()
        {
            Console.Clear();
            while(true) 
            {
                FillAuditorium();
                Console.Write("Do you want to go to the menu? (enter 'yes' to exit the filling, press 'enter' to continue): ");
                if (Console.ReadLine() == "yes") break;
            }
        }
        private static void ChangeData()
        {
            Console.Clear();
            Auditories.FullListAuditories();
            Console.Write("\nSelect number of auditorium: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("\nSelect parameter for change ('floor' or 'number'): ");
            switch (Console.ReadLine())
            {
                case "floor":
                    Console.Write("Input new value: ");
                    Auditories.ChangeFloor(number, byte.Parse(Console.ReadLine()));
                    break;
                case "number":
                    Console.Write("Input new value: ");
                    Auditories.ChangeNumber(number, byte.Parse(Console.ReadLine()));
                    break;
            }
        }
        private static void SortAud()
        {
            Console.Clear();
            Console.WriteLine("1. Sort by the number of seats\n" +
                "2. Sorted by the number of seats and the availability of a projector\n" +
                "3. Sorted by the number of seats and the availability of a computer\n" +
                "4. Sort by floor\n" +
                "5. All info\n" +
                "6. Back to menu");
            int input = int.Parse(Console.ReadLine());
            byte newValue = 0;
            Console.Clear();
            if (input < 5)
            {
                Console.Write("Input value for sort: ");
                newValue = byte.Parse(Console.ReadLine());
            }
            switch (input)
            {
                case 1:
                    Auditories.SortBySeats(newValue);
                    Menu.Wait(); break;
                case 2:
                    Auditories.SortBySeatsAndProjector(newValue);
                    Menu.Wait(); break;
                case 3:
                    Auditories.SortBySeatsAndComputers(newValue);
                    Menu.Wait(); break;
                case 4:
                    Auditories.SortByFloor(newValue);
                    Menu.Wait(); break;
                case 5:
                    Auditories.FullListAuditories();
                    Menu.Wait(); break;
                default:
                    break;
            }
        }
        private static void Exit() { Environment.Exit(0); }
    }
}