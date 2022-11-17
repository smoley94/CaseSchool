using CaseSchool.Codes;

internal class Program {
    private static void Main(string[] args) {
        Teacher teacher = new Teacher();
        Student student = new Student();
        Subject subject = new Subject();

        bool isRunning = false;

        do {
            Console.WriteLine("Hvad vil du gerne søge efter? Vælg 1, 2, 3 eller 4 og tryk enter.");
            Console.WriteLine();
            Console.WriteLine("1. Lærer");
            Console.WriteLine("2. Elev");
            Console.WriteLine("3. Fag");
            Console.WriteLine("4. Afslut");
            Console.WriteLine();

            int? userInput = int.Parse(Console.ReadLine());

            switch(userInput) {
                case (int)Enums.Teacher:
                    teacher.Teachers();
                    break;
                case (int)Enums.Student:
                    student.Students();
                    break;
                case (int)Enums.Subject:
                    subject.Subjects();
                    break;
                case (int)Enums.Exit:
                    Console.WriteLine();
                    Console.WriteLine("Du kan nu lukke vinduet.");
                    isRunning = true;
                    break;
                default:
                    Console.WriteLine("Ukendt valg, prøv igen.");
                    break;
            }
        } while(isRunning == false);
    }
}