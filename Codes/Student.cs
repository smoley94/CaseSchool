using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSchool.Codes {
    internal class Student {

        private ArrayList StudentListCsp = new ArrayList() {
            "Amanda Gudmand",
            "Camilla Kløjgaard",
            "Dennis Paaske",
            "Iheb Boukthir",
            "Jakob Rasmussen",
            "Micki Olsen",
            "Mikkel Rantala",
            "Mikkel Kjærgaard",
            "Niclas Jensen",
            "Ozan Korkmaz",
            "Rasmus Wiell",
            "Rune Hansen",
            "Sanjit Poudel",
            "Silas Michelsen"
        };

        private ArrayList StudentListGp = new ArrayList() {
            "Amanda Gudmand",
            "Camilla Kløjgaard",
            "Dennis Paaske",
            "Iheb Boukthir",
            "Jakob Rasmussen",
            "Micki Olsen",
            "Mikkel Rantala",
            "Mikkel Kjærgaard",
            "Niclas Jensen",
            "Ozan Korkmaz",
            "Rasmus Wiell",
            "Rune Hansen",
            "Sanjit Poudel",
            "Silas Michelsen"
        };

        public ArrayList getStudentListCsp() {
            return StudentListCsp;
        }

        public ArrayList getStudentListGp() {
            return StudentListGp;
        }

        public void Students() {
            Console.Clear();
            Console.Write("Angiv elevens navn (For, og efternavn): ");

            Subject subject = new Subject();
            Teacher teacher = new Teacher();

            string? userInput = Console.ReadLine();

            bool isRunning = false;

            do {
                if(userInput.ToLower().Equals("amanda gudmand")
                || userInput.ToLower().Equals("camilla kløjgaard")
                || userInput.ToLower().Equals("dennis paaske")
                || userInput.ToLower().Equals("iheb boukthir")
                || userInput.ToLower().Equals("jakob rasmussen")
                || userInput.ToLower().Equals("micki olsen")
                || userInput.ToLower().Equals("mikkel rantala")
                || userInput.ToLower().Equals("mikkel kjærgaard")
                || userInput.ToLower().Equals("niclas jensen")
                || userInput.ToLower().Equals("ozan korkmaz")
                || userInput.ToLower().Equals("rasmus wiell")
                || userInput.ToLower().Equals("rune hansen")
                || userInput.ToLower().Equals("sanjit poudel")
                || userInput.ToLower().Equals("silas michelsen")) {

                    foreach(string subjects in subject.getSubjectListCsp()) {
                        Console.WriteLine();
                        Console.WriteLine("Fag: " + subjects);

                        foreach(string teachers in teacher.getTeacherListCsp()) {
                            Console.WriteLine("Lærer: " + teachers);
                            Console.WriteLine();
                        }
                    }
                    foreach(string subjects in subject.getSubjectListGp()) {
                        Console.WriteLine("Fag: " + subjects);

                        foreach(string teachers in teacher.getTeacherListGp()) {
                            Console.WriteLine("Lærer: " + teachers);
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                    }
                } else {
                    Console.WriteLine();
                    Console.WriteLine("Denne elev findes ikke. Prøv igen.");
                    userInput = Console.ReadLine();
                }
            } while(isRunning == false);
        }

    }
}
