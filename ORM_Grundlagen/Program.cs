using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ORM_Grundlagen.db;
using ORM_Grundlagen.models;

namespace ORM_Grundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlineshopContext ctx;
            var p1 = new Person(0, "Thomas", "Kefer", new DateTime(2002, 9, 1), 19999.132m, Gender.Male, 's');
            var p2 = new Person(0, "Torben", "Baumgartner", new DateTime(2003, 9, 1), 20000.132m, Gender.Male, 's');
            var p3 = new Person(0, "Tobias", "Laser", new DateTime(2001, 9, 1), 20001.132m, Gender.Male, 's');


            // Personen der DB-Tabelle hinzufügen
            using (ctx = new OnlineshopContext())
            {
                // dem Kontext hinzufügen - die Personen befinden sich nur im RAM
                // sie werden noch nicht in die DB-Tabelle übertragen
                ctx.People.Add(p1);
                ctx.People.Add(p2);
                ctx.People.Add(p3);

                ctx.SaveToDb();
            }

            // alle Personen ausgeben
            using (ctx = new OnlineshopContext())
            {
                foreach (var person in ctx.People)
                {
                    Console.WriteLine(person);
                }
            }

// LINQ-Abfrage alle Personen mit einem Gehalt unter 20000
            using (ctx = new OnlineshopContext())
            {
                var result = from p in ctx.People where p.Salary < 20000 select p;

                foreach (var p in result)
                {
                    Console.WriteLine(p);
                }
            }

// suche nach Tobias Laser und dann löschen + alle Personen ausgeben
            using (ctx = new OnlineshopContext())
            {
                var result = from p in ctx.People where p.FirstName == "Tobias" && p.LastName == "Laser" select p;

                foreach (var p in result)
                {
                    Console.WriteLine(p);
                }
            }

            var gesuchteId = 2;
// suche nach einer Person per PersonId + Daten ändern + alle Personen ausgeben
            using (ctx = new OnlineshopContext())
            {
                var result = from p in ctx.People where p.Id == gesuchteId select p;

                foreach (var p in result)
                {
                    p.Gender = Gender.NotSpecified;
                    Console.WriteLine(p);
                }

                ctx.SaveToDb();
            }

            // eine Person erzeugen inkl. 2 Adressen und in die DB-TAbllen eintragen
            var pMaxWithAddress = new Person(0, "Mox", "Neuna", DateTime.UtcNow, 254631m, Gender.Male, 'w');
            var a1 = new Address(0, "6020", "Innsbruck", "Anichstraße", "12c");
            var a2 = new Address(0, "6290", "Mayrhofen", "Brandbergstraße", "412");
            pMaxWithAddress.Addresses = new List<Address>() { a1, a2 };

            using (ctx = new OnlineshopContext())
            {
                ctx.People.Add(pMaxWithAddress);
                ctx.SaveToDb();
            }
        }
    }
}