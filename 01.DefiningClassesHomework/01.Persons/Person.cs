using System;

public class Person
{
    public string name;
    public int age;
    public string email;

    public Person(string name, int age)
        : this(name, age, null)
    {

    }

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public string Name 
    {
        get { return this.name; } 
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Name can't be empty");
            } 
            this.name = value;
        } 
       
    }

    public int Age 
    {
        get { return this.age; }
        set
        {
            
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Value out of range");
            } 
            this.age = value;
        }
    }

    public string Email 
    {
        get { return this.email; }
        set
        {
            if (value!=null && !value.Contains("@"))
            {
                throw new ArgumentException("Invalid email");
            }
            this.email = value;
        }
    }
    public override string ToString()
    {
        return string.Format("Name: {0}\nAge: {1}\nEmail: {2}\n",this.name,this.age,this.email??"No email");
    }
}

