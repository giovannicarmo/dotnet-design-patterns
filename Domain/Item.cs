using System;

namespace Dotnet.Design.Patterns.Domain
{
    public class Item
    {
        public String Name { get; set; }
        public double Cost { get; set; }

        public Item(String name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}