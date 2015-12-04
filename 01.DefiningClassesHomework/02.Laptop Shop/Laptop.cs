using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


public class Laptop
{
    private string model;
    private decimal price;

    public Laptop(string model, string manufacturer, string processor,
        string ram, string graphicsCard, string hdd, string screen, Battery laptopBattery, decimal price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.LaptopBattery = laptopBattery;
        this.Price = price;
    }

    public Laptop(string model, string manufacturer, string processor,
        string ram, string graphicsCard, string hdd, decimal price):
        this(model, manufacturer, processor, ram, graphicsCard,hdd,null,null,price)
    {

    }

    public Laptop(string model, decimal price)
        : this(model, null, null, null, null, null, null, null, price)
    {
   
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Model cannot be empty");
            }
            this.model = (value);
        } 
    }

    public string Manufacturer { get; set; }

    public string Processor { get; set; }

    public string Ram { get; set; }

    public string GraphicCard { get; set; }

    public string Hdd { get; set; }

    public string Screen { get; set; }

    public Battery LaptopBattery { get; set; }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0.0m)
            {
                throw new ArgumentOutOfRangeException("The price cannot be negative number");
            }
            this.price = value;
        }
    }
    public override string ToString()
    {
        var description = new string('-', 87) + "\n";
        description += string.Format("{0, -18}| {1, -66} |\n", "| model", this.Model);
        description += new string('-', 87) + "\n";

            if (!string.IsNullOrWhiteSpace(this.Manufacturer))
            {
                description += string.Format("{0, -18}| {1, -66} |\n", "| manufacturer", this.Manufacturer);
                description += new string('-', 87) + "\n";
            }

            if (!string.IsNullOrWhiteSpace(this.Processor))
            {
                description += string.Format("{0, -18}| {1, -66} |\n", "| processor", this.Processor);
                description += new string('-', 87) + "\n";
            }

            if (!string.IsNullOrWhiteSpace(this.Ram))
            {
                description += string.Format("{0, -18}| {1, -66} |\n", "| RAM", this.Ram);
                description += new string('-', 87) + "\n";
            }

            if (!string.IsNullOrWhiteSpace(this.GraphicCard))
            {
                description += string.Format("{0, -18}| {1, -66} |\n", "| graphics card", this.GraphicCard);
                description += new string('-', 87) + "\n";
            }

            if (!string.IsNullOrWhiteSpace(this.Hdd))
            {
                description += string.Format("{0, -18}| {1, -66} |\n", "| HDD", this.Hdd);
                description += new string('-', 87) + "\n";
            }

            if (!string.IsNullOrWhiteSpace(this.Screen))
            {
                description += string.Format("{0, -18}| {1, -66} |\n", "| screen", this.Screen);
                description += new string('-', 87) + "\n";
            }

            if (this.LaptopBattery != null)
            {
                description += string.Format("{0, -18}| {1, -66} |\n", "| battery", this.LaptopBattery);
                description += new string('-', 87) + "\n";
                description += string.Format("{0, -18}| {1:f1} hours{2}|\n", "| battery life", LaptopBattery.LifeSpan,new string(' ',58));
                description += new string('-', 87) + "\n";
            }

            description += string.Format("{0, -18}| {1, -66:c2} |\n", "| price", this.Price);
            description += new string('-', 87) + "\n\n\n";

            return description;
        }
}

