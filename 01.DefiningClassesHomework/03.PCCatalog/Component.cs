using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Component
{
    private string name;
    private decimal price;

    public Component(string name, decimal price, string details)
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
    }

    public Component(string name, decimal price)
        : this(name, price, null)
    {           
    }

    public string Name
    {
        get
        { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Name cannot be empty");
            }
            this.name = value;
        }
    }

    public string Details { get; set; }

    public decimal Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value < 0.0m)
            {
                throw new ArgumentOutOfRangeException("Price cannot be negative.");
            }
            this.price = value;
        }
    }
}

