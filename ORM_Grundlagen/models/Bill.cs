using System;
using System.Collections.Generic;

namespace ORM_Grundlagen.models
{
    public class Bill
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

        public int BillId = 0;
        public DateTime Date = DateTime.Today;
        public List<Person> Customer = new List<Person>();
        public List<Article> Articles = new List<Article>();

        public Bill(int id, DateTime date)
        {
            BillId = id;
            Date = date;
        }
    }
}