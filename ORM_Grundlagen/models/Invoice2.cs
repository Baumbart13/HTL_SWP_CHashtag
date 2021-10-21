using System;
using System.Collections.Generic;

namespace ORM_Grundlagen.models
{
    public class Invoice2
    {
        /*
         * this has...
         *
         * articles
         * person
         * further fields
         */
        /*
         * Relations are...
         *
         * Bill - Person <-> n:1
         * Bill - Article <-> n:m
         */

        public int Invoice2Id { get; set; } = 0;
        public DateTime Date { get; set; } = DateTime.Today;
        
        // NavigationsProperties - TODO
        public List<Invoices2Articles2> Invoices2Articles2s { get; set; }

        public Invoice2(){}

        public Invoice2(int id, DateTime date)
        {
            Invoice2Id = id;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Invoice2Id} {Date.ToString()}";
        }
    }
}