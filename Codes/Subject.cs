using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSchool.Codes {
    internal class Subject {

        private ArrayList SubjectListCsp = new ArrayList() {
            "Clientside programmering"
        };

        private ArrayList SubjectListGp = new ArrayList() {
            "Grundlæggende programmering"
        };

        public ArrayList getSubjectListCsp() {
            return SubjectListCsp;
        }

        public ArrayList getSubjectListGp() {
            return SubjectListGp;
        }

        public void Subjects() {
            Console.Clear();
            Console.Write("Angiv fagets navn: ");

            Teacher teacher = new Teacher();
            Student student = new Student();

            string? userInput = Console.ReadLine();

            bool isRunning = false;

            do {
                if(userInput.ToLower().Equals("clientside programmering") || userInput.ToLower().Equals("clientside")) {

                    foreach(string teachers in teacher.getTeacherListCsp()) {
                        Console.WriteLine();
                        Console.WriteLine("Lærer: " + teachers);
                        Console.WriteLine();
                        Console.WriteLine("Elever:");
                        foreach(string students in student.getStudentListCsp()) {
                            Console.WriteLine(students);
                        }
                        Console.ReadLine();
                    }
                } else if(userInput.ToLower().Equals("grundlæggende programmering") || userInput.ToLower().Equals("grundlæggende")) {

                    foreach(string teachers in teacher.getTeacherListGp()) {
                        Console.WriteLine();
                        Console.WriteLine("Lærer: " + teachers);
                        Console.WriteLine();
                        Console.WriteLine("Elever:");
                        foreach(string students in student.getStudentListGp()) {
                            Console.WriteLine(students);
                        }
                        Console.ReadLine();
                    }
                } else {
                    Console.WriteLine();
                    Console.WriteLine("Dette fag findes ikke. Prøv igen.");
                    userInput = Console.ReadLine();
                }
            } while(isRunning == false);

        }
    }
}
