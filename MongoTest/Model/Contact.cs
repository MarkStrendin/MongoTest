using System;
using System.Collections.Generic;
using System.Text;

namespace MongoTest.Model
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RelationshipToStudent { get; set; }
        public int ContactPriority { get; set; }
        public bool LivesWithStudent { get; set; }
        public bool SamePrimaryAddressAsStudent { get; set; }
        public bool SameMailingAddressAsStudent { get; set; }
        public bool ShouldRecieveMailAboutStudent { get; set; }
        public Address PrimaryAddress { get; set; }
        public Address MailingAddress { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }
        public string AlternateContactInfo { get; set; }
        public string Employer { get; set; }
        public string EmailAddress { get; set; }

        public Contact()
        {
            this.ContactPriority = 1;
            this.PrimaryAddress = new Address();
            this.MailingAddress = new Address();
        }
    }
}
