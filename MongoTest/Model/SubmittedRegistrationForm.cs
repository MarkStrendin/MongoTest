using MongoDB.Bson;
using System;

namespace MongoTest.Model
{
    public class SubmittedRegistrationForm
    {
        public ObjectId _id { get; private set; }
        public FormSubmission Form { get; set; }
        public DateTime Submitted { get; set; }
        public bool Read { get; set; }
        public bool Processed { get; set; }
        public bool Deleted { get; set; }
    }
}
