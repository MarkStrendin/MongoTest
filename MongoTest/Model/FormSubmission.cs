namespace MongoTest.Model
{
    public class FormSubmission
    {
        public FormSubmitter SubmittedBy {get;set;}
        public ContactInfo Contacts { get; set; }
        public Student Student { get; set; }

        public FormSubmission()
        {
        }

    }
}
