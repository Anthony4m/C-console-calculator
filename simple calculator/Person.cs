using System;

namespace simple_calculator
{
   
        public class Person
        {
            private string Firstname { get; set; }
            private string Lastname { get; set; }
            private int Age { get; set; }

            public string Details
            {
                get
                {
                    var fullname = string.Format("{0} {1}", Firstname, Lastname);
                    return fullname;
                }
            }
            public Person(string firstname, string lastname, int age)
            {
                Firstname = firstname;
                Lastname = lastname;
                Age = age;
            }


            public virtual string Details1()
            {
                return string.Format("{0} {1} {2}", Firstname,Lastname,Age);
            }
        }
    }
