using System;
using System.Collections.Generic;
using System.Linq;
namespace Auditories
{
    internal class Auditories
    {
        private byte auditorium;
        private byte countSeats;
        private byte floor;
        private dynamic number;
        private bool projector;
        private bool computers;
        private static List<Auditories> auditories = new List<Auditories>();
        private Auditories(byte floor, byte auditorium, byte countSeats, bool projector, bool computers)
        {
            this.floor = floor;
            this.auditorium = auditorium;
            this.countSeats = countSeats;
            this.projector = projector;
            this.computers = computers;
            number = floor * 100 + auditorium;
        }
        public static void AddAud(byte floor, byte auditorium, byte countSeats, bool projector, bool computers)
        {
            Auditories.auditories.Add(new Auditories(floor, auditorium, countSeats, projector, computers));
        }
        public void WriteAll()
        {
            Console.WriteLine($"Aud. №{number}:\n" +
                $"\tFloor: {floor}\n" +
                $"\tNumber: {auditorium}\n" +
                $"\tCount of seats: {countSeats}\n" +
                $"\tProjector: {(projector ? "yes" : "no")}\n" +
                $"\tComputers: {(computers ? "yes" : "no")}\n");
        }
        private void TakeBySeats(byte seats)
        {
            if (countSeats >= seats) Console.WriteLine($"\taud №{number}\t{countSeats} seats");
        }
        public static void SortBySeats(byte seats)
        {
            Console.WriteLine($"List auditories with {seats} seats:");
            foreach (Auditories item in auditories) { item.TakeBySeats(seats); }
        }
        public static void SortBySeatsAndProjector(byte seats)
        {
            Console.WriteLine($"List auditories with {seats} seats and projector:");
            foreach (Auditories item in auditories) { if (item.projector) item.TakeBySeats(seats); }
        }
        public static void SortBySeatsAndComputers(byte seats)
        {
            Console.WriteLine($"List auditories with {seats} seats and computers:");
            foreach (Auditories item in auditories) { if (item.computers) item.TakeBySeats(seats); }
        }
        public static void SortByFloor(byte floor)
        {
            Console.WriteLine($"List auditories on {floor} floor:");
            foreach (Auditories item in auditories) { if (item.floor == floor) Console.WriteLine($"\t{item.number}"); }
        }
        public static void ListByAllNumbers()
        {
            Console.WriteLine($"List auditories:");
            foreach (Auditories item in auditories) { Console.WriteLine($"\t{item.number}"); }
        }
        public static void FullListAuditories() 
        {
            Console.WriteLine("All info:\n");
            foreach(Auditories auditories in auditories) { auditories.WriteAll(); }
        }
        public static void ChangeFloor(int number, byte newFloor)
        {
            Auditories aud = Auditories.auditories.Find(audit => audit.number == number);
            aud.floor = newFloor;
            aud.number = newFloor * 100 + aud.auditorium;
        }
        public static void ChangeNumber(int number, byte newNumber)
        {
            Auditories aud = Auditories.auditories.Find(audit => audit.number == number);
            aud.auditorium = newNumber;
            aud.number = aud.floor * 100 + newNumber;
        }
    }
}