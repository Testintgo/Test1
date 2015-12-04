using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Person
    {
        //fields
        public string name;
        public int age;
        public string email;
        
        //constructors
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {

        }
        //properties
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty or null.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Age must be in the range [1..100].");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (!string.IsNullOrEmpty(value) && !(value).Contains('@'))
                {
                    throw new ArgumentException("Invalid Email.");
                }

                this.email = value;
            }
        }

        //methods
        public override string ToString()
        {
            return Name+"\n"+Age+"\n"+Email;
        }

    }

