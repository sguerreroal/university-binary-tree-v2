using System;

namespace BynaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "Rector";
            rectorPosition.Salary = 1000;
            rectorPosition.Tax = 0.3;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector Financiero";
            vicFinPosition.Salary = 750;
            vicFinPosition.Tax = 0.25;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;
            contadorPosition.Tax = 0.15;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;
            jefeFinPosition.Tax = 0.2;

            Position secreFin1Position = new Position();
            secreFin1Position.Name = "Secretaria Financiera 1";
            secreFin1Position.Salary = 350;
            secreFin1Position.Tax = 0.05;

            Position secreFin2Position = new Position();
            secreFin2Position.Name = "Secretaria Financiera 2";
            secreFin2Position.Salary = 310;
            secreFin2Position.Tax = 0.05;

            Position vicAcaPosition = new Position();
            vicAcaPosition.Name = "Vicerector Academico";
            vicAcaPosition.Salary = 780;
            vicAcaPosition.Tax = 0.25;


            Position jefRegistroPosition = new Position();
            jefRegistroPosition.Name = "Jefe de Registro";
            jefRegistroPosition.Salary = 640;
            jefRegistroPosition.Tax = 0.2;

            Position SecreRegistro1Position = new Position();
            SecreRegistro1Position.Name = "Secretaria de Registro 1";
            SecreRegistro1Position.Salary = 400;
            SecreRegistro1Position.Tax = 0.05;

            Position SecreRegistro2Position = new Position();
            SecreRegistro2Position.Name = "Secretaria de Registro 2";
            SecreRegistro2Position.Salary = 360;
            SecreRegistro2Position.Tax = 0.05;

            Position asistente1Position = new Position();
            asistente1Position.Name = "Asistente 1";
            asistente1Position.Salary = 250;
            asistente1Position.Tax = 0.03;

            Position asistente2Position = new Position();
            asistente2Position.Name = "Asistente 2";
            asistente2Position.Salary = 170;
            asistente2Position.Tax = 0.03;

            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;
            mensajeroPosition.Tax = 0.01;



            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreFin2Position, contadorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);

            universityTree.CreatePosition(universityTree.Root, vicAcaPosition, rectorPosition.Name);


            universityTree.CreatePosition(universityTree.Root, jefRegistroPosition, vicAcaPosition.Name);
            universityTree.CreatePosition(universityTree.Root, SecreRegistro2Position, jefRegistroPosition.Name);
            universityTree.CreatePosition(universityTree.Root, SecreRegistro1Position, jefRegistroPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asistente2Position, SecreRegistro1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asistente2Position.Name);
            universityTree.CreatePosition(universityTree.Root, asistente1Position, SecreRegistro1Position.Name);


            universityTree.PrintTree(universityTree.Root);

            float totalSalary = universityTree.addSalaries(universityTree.Root);
            Console.WriteLine($"Total Salaries: {totalSalary}");

            //Console.ReadLine();


            /* PART 2 */

            float averageSalary = universityTree.averageSalaries(universityTree.Root);
            Console.WriteLine($"Average Salaries: {averageSalary}");

            
            float taxTotal = universityTree.sumTax(universityTree.Root);
            Console.WriteLine($"The Total of Tax is: {taxTotal}");

            float salaryLongest = universityTree.salaryLongest(universityTree.Root);
            Console.WriteLine($"The Longest Salary Is: {salaryLongest}");


            Console.WriteLine("Enter a Name:");
            String searchName = Console.ReadLine();
            float salaryEmployee = universityTree.SalaryEmployee(universityTree.Root, searchName);
            Console.WriteLine($"The Salary {searchName} is: {salaryEmployee}");
        }
    }
}
