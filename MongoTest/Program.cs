using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using MongoTest.Model;

namespace MongoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connecting...");
            MongoClient dbClient = new MongoClient("mongodb://10.0.0.120");

            Console.WriteLine("Connecting to database...");
            IMongoDatabase database = dbClient.GetDatabase("Registration");

            Console.WriteLine("Connecting to collection...");
            IMongoCollection<FormSubmission> collection = database.GetCollection<FormSubmission>("GeneralRegistrationForms");

            //Console.WriteLine("Inserting test data");
            //collection.InsertOne(getTestData());
            List<FormSubmission> allSubmissions = collection.Find(_ => true).ToList();

            Console.WriteLine("-------------------");
            foreach(FormSubmission form in allSubmissions)
            {
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(form));

            }
            Console.WriteLine("-------------------");

        }



        private static FormSubmission getTestData()
        {
            return new FormSubmission()
            {
                Id = 0,
                SubmittedBy = new FormSubmitter()
                {
                    FirstName = "Harvey",
                    LastName = "Birdman",
                    ContactDetails = "Twitter: @harveybirdman"
                },
                Contacts = new ContactInfo()
                {
                    Contacts = new List<Contact>()
                    {
                        new Contact()
                        {
                            FirstName = "Harvey",
                            LastName = "Birdman",
                            RelationshipToStudent = "Father",
                            ContactPriority = 1,
                            LivesWithStudent = true,
                            SamePrimaryAddressAsStudent = true,
                            SameMailingAddressAsStudent = true,
                            ShouldRecieveMailAboutStudent = true,
                            PrimaryAddress = new Address()
                            {
                                Line1 = "123 Fake St",
                                City = "Cake Town",
                                Province = "Cake Province",
                                PostalCode = "H0H0H0",
                                Country = "Canada"

                            },
                            MailingAddress = new Address()
                            {
                                Line1 = "123 Fake St",
                                City = "Cake Town",
                                Province = "Cake Province",
                                PostalCode = "H0H0H0",
                                Country = "Canada"
                            },
                            HomePhone = "1234567890",
                            WorkPhone = "3216540987",
                            CellPhone = "3126450789",
                            AlternateContactInfo = "Twitter: @harveybirdman",
                            Employer = "Sebben and Sebben",
                            EmailAddress = "harvey@sebbenandsebben.fake",
                        },

                        new Contact()
                        {
                            FirstName = "Judy",
                            LastName = "Sebben",
                            RelationshipToStudent = "Mother",
                            ContactPriority = 1,
                            LivesWithStudent = true,
                            SamePrimaryAddressAsStudent = true,
                            SameMailingAddressAsStudent = true,
                            ShouldRecieveMailAboutStudent = true,
                            PrimaryAddress = new Address()
                            {
                                Line1 = "123 Fake St",
                                City = "Cake Town",
                                Province = "Cake Province",
                                PostalCode = "H0H0H0",
                                Country = "Canada"

                            },
                            MailingAddress = new Address()
                            {
                                Line1 = "123 Fake St",
                                City = "Cake Town",
                                Province = "Cake Province",
                                PostalCode = "H0H0H0",
                                Country = "Canada"
                            },
                            HomePhone = "1234567890",
                            WorkPhone = "3216540987",
                            CellPhone = "3126450789",
                            AlternateContactInfo = "Twitter: @harveybirdman",
                            Employer = "Sebben and Sebben",
                            EmailAddress = "harvey@sebbenandsebben.fake",
                        },
                    }
                },
                Student = new Student()
                {
                    FirstName = "Herp",
                    LastName = "Derpson",
                    LegalFirstName = "Herp",
                    LegalLastName = "Derpson",
                    Gender = "Unspecified",
                    DateOfBirth = new DateTime(2000, 01, 01),
                    PrimaryAddress = new Address()
                    {
                        Line1 = "123 Fake St",
                        City = "Cake Town",
                        Province = "Cake Province",
                        PostalCode = "H0H0H0",
                        Country = "Canada"
                    },
                    MailingAddress = new Address()
                    {
                        Line1 = "123 Fake St",
                        City = "Cake Town",
                        Province = "Cake Province",
                        PostalCode = "H0H0H0",
                        Country = "Canada"
                    },
                    PreviousSchools = "Cake Town Preschool",
                    MedicalNotes = "Allergic to cheese poofs"
                }
            };
        }
    }
}
