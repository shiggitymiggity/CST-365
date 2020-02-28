using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
/*        public static List<Student> Students = new List<Student> {
            new Student {
                Id = 1,
                StudentId = "356785",
                EmailAddress = "Thisoneemail@gmal.com"
            },
            new Student {
                Id = 2,
                StudentId = "164857",
                EmailAddress = "Anotherstudent@hotmail.com"
            },
            new Student {
                Id = 3,
                StudentId = "201385",
                EmailAddress = "Emailemail@email.com"
            },
            new Student {
                Id = 4,
                StudentId = "972035",
                EmailAddress = "MyInbox@protonmail.com"
            },
            new Student {
                Id = 5,
                StudentId = "701803",
                EmailAddress = "Lastone@gmail.com"
            }
        }; 
        */
            public static List<Instructor> Instructors = new List<Instructor> {
            new Instructor {
                Id = 1,
                First = "Kajetan",
                Middle = "A.",
                Last = "Savage"
            },
            new Instructor {
                Id = 2,
                First = "Evelina",
                Middle = "T.",
                Last = "Almond"
            },
            new Instructor {
                Id = 3,
                First = "Orlaith",
                Middle = "L.",
                Last = "Wilde"
            },
            new Instructor {
                Id = 4,
                First = "Alfie",
                Middle = "Q.",
                Last = "Santiago"
            },
            new Instructor {
                Id = 5,
                First = "Gail",
                Middle = "U.",
                Last = "Stark"
            }
        };
    }
}