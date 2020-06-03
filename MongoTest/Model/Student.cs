using System;
using System.Collections.Generic;
using System.Text;

namespace MongoTest.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string LegalFirstName { get; set; }
        public string LegalLastName { get; set; }
        public string LegalMiddleName { get; set; }
        public bool HasPreferredName { get; set; }
        public bool HasLandLocation { get; set; }
        public bool MailingAddressSameAsPhysical { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Address PrimaryAddress { get; set; }
        public Address MailingAddress { get; set; }
        public string LandDescription { get; set; }
        public string PreviousSchools { get; set; }
        public string HealthServicesNumber { get; set; }
        public string MedicalNotes { get; set; }

        public Student()
        {
            this.PrimaryAddress = new Address();
            this.MailingAddress = new Address();
        }
    }
}
