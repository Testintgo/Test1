using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;


public class Battery
{
    private string type;
    private int numbOfCells;
    private int capacity;
    private double lifeSpan;

    public Battery(string type, int numbOfCells, int capacity, double lifeSpan )
    {
        this.Type = type;
        this.NumbOfCells = numbOfCells;
        this.Capacity = capacity;
        this.LifeSpan = lifeSpan;
    }

    public string Type
    {
        get { return this.type; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Type cannot be empty");
            }
            this.type = value;
        }
    }

    public int NumbOfCells
    {
        get { return this.numbOfCells; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Number of cells cannot be negative");
            }
            this.numbOfCells = value;
        }
    }

    public int Capacity
    {
        get {return this.capacity;}
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Capacity cannot be negative");
            }
            this.capacity = value;
        } 
    }

    public double LifeSpan
    {
        get { return this.lifeSpan; }
        set
        {
            if (value < 0.0)
            {
                throw new ArgumentOutOfRangeException("Life span cannot be negative");
            }
            this.lifeSpan = value;
        }
    }

    public override string ToString()
    {
        return string.Format("{0}, {1}-cell, {2} mAh", this.type, this.numbOfCells, this.capacity);
    }
}

