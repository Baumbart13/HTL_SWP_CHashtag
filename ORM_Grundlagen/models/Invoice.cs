using System;
using System.Collections.Generic;

namespace ORM_Grundlagen.models
{
    public class Invoice
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

        public int InvoiceId { get; set; } = 0;
        public DateTime Date { get; set; } = DateTime.Today;
        
        // NavigationsProperties
        public List<Article> Articles{ get; set; }
        
        public Invoice(){}

        public Invoice(int id, DateTime date)
        {
            InvoiceId = id;
            Date = date;
        }

        public override string ToString()
        {
            return $"{InvoiceId} {Date.ToString()}";
        }
    }
}