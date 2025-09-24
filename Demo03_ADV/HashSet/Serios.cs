using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_ADV.HashSet
{
    internal class Serios : IEquatable<Serios>

    {

        public int Id { get; set; }
        public String? Titel { get; set; }
        public decimal price { get; set; }
        public Serios(int id, string? titel, decimal price)
        {
            Id = id;
            Titel = titel;
            this.price = price;
        }
        public override string ToString()
        {
            return $"Id :{Id} ,Titel :{Titel} ,price :{price}";
        }

        public bool Equals(Serios? other)
        {
            return this.Id == other?.Id && this.Titel == other?.Titel && this.price == other?.price;
        }

        override public int GetHashCode()
        {
            return HashCode.Combine(Id, Titel, price);
        }
    }
}
