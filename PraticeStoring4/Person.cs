using System;
namespace PraticeStoring4
    
{
    public class Person
    {
        public Person()
        {
        }
        public string _name { get; set; }
        public string _phoneNumber { get; set; }
        public int _id { get; set; }

        public Person(string name, string phoneNumber, int id)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _id = id;
        }
       
      
    }
}
