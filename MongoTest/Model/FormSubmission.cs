using System;
using System.Collections.Generic;
using System.Text;

namespace MongoTest.Model
{
    public class FormSubmission
    {
        public int Id { get; set; }
        public FormSubmitter SubmittedBy {get;set;}
        public ContactInfo Contacts { get; set; }
        public Student Student { get; set; }

    }
}
