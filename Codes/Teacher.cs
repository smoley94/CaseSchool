using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaseSchool;

namespace CaseSchool.Codes {
    internal class Teacher {

        private ArrayList TeacherListCsp = new ArrayList() {
            "Peter Lindenskov"
        };

        private ArrayList TeacherListGp = new ArrayList() {
            "Niels Olesen"
        };

        public ArrayList getTeacherListCsp() {
            return TeacherListCsp;
        }

        public ArrayList getTeacherListGp() {
            return TeacherListGp;
        }

        public void Teachers() {
            Console.Clear();
            Console.Write("Angiv lærerens navn: ");

            Program program = new Program();
            Subject subject = new Subject();
            Student student = new Student();

            string? userInput = Console.ReadLine();

            bool isRunning = false;

            do {
                if(userInput.ToLower().Equals("peter lindenskov") || userInput.ToLower().Equals("peter")) {

                    foreach(string subjects in subject.getSubjectListCsp()) {
                        Console.WriteLine();
                        Console.WriteLine("Fag: " + subjects);
                        Console.WriteLine();
                        Console.WriteLine("Elever:");
                        foreach(string students in student.getStudentListCsp()) {
                            Console.WriteLine(students);
                        }
                        Console.ReadLine();
                    }
                } else if(userInput.ToLower().Equals("niels olesen") || userInput.ToLower().Equals("niels")) {

                    foreach(string subjects in subject.getSubjectListGp()) {
                        Console.WriteLine();
                        Console.WriteLine("Fag: " + subjects);
                        Console.WriteLine();
                        Console.WriteLine("Elever:");
                        foreach(string students in student.getStudentListGp()) {
                            Console.WriteLine(students);
                        }
                        Console.ReadLine();
                    }
                } else {
                    Console.WriteLine("Denne lærer findes ikke. Prøv igen.");
                    userInput = Console.ReadLine();
                }
            } while(!isRunning);
        }
    }
}
