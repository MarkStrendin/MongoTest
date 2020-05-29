using System;
using System.Collections.Generic;
using System.Text;

namespace MongoTest.Model
{
    public class ContactInfo
    {
        public List<Contact> Contacts { get; set; }

        public ContactInfo()
        {
            this.Contacts = new List<Contact>();
        }


    }
}
