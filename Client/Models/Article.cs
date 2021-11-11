using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models {
	class Article {

        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";
        public decimal Price { get; set; } = 0.0m;
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

		// CTors

		public override string ToString() {
			return $"{Id} {Name} {Brand} {Price} {ReleaseDate.ToLongDateString()}";
		}
	}
}
