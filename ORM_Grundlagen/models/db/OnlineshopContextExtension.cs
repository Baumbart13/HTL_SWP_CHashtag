using System;
using Microsoft.EntityFrameworkCore;

namespace ORM_Grundlagen.db
{
    public static class OnlineshopContextExtension
    {
        public static bool SaveToDb(this OnlineshopContext ctx)
        {
            var success = true;
            try
            {
                // Personen in die DB-Tabelle eintragen
                // hier werden neue Einträge hinzugefügt, bzw. geänderte/gelöschte Einträge bearbeitet
                ctx.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                success = false;
                Console.WriteLine($"Mehrfacher gleichzeitiger Zugriff nicht möglich!");
            }
            catch (DbUpdateException e)
            {
                success = false;
                Console.WriteLine($"Daten konnten nicht geändert/hinzugefügt/entfernt werden!");
            }

            return success;
        }
    }
}