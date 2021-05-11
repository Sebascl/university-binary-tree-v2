using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {

            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;
            rectorPosition.tax = 0.28;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector financiero";
            vicFinPosition.Salary = 750;
            vicFinPosition.tax = 0.24;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;
            contadorPosition.tax = 0.15;

            Position JefeFinPosition = new Position();
            JefeFinPosition.Name = "Jefe financiero";
            JefeFinPosition.Salary = 610;
            JefeFinPosition.tax = 0.21;

            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria financiera 1";
            secFin1Position.Salary = 350;
            secFin1Position.tax = 0.1;

            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria financiera 2";
            secFin2Position.Salary = 310;
            secFin2Position.tax = 0.08;

            Position vicAcadPosition = new Position();
            vicAcadPosition.Name = "Vicerector académico";
            vicAcadPosition.Salary = 780;
            vicAcadPosition.tax = 0.18;

            Position jefereg = new Position();
            jefereg.Name = "Jefe reg ";
            jefereg.Salary = 640;
            jefereg.tax = 0.21;

            Position sectreg2 = new Position();
            sectreg2.Name = "Secretaria reg 2";
            sectreg2.Salary = 360;
            sectreg2.tax = 0.04;

            Position sectreg1 = new Position();
            sectreg1.Name = "Secretaria reg 1";
            sectreg1.Salary = 400;
            sectreg1.tax = 0.06;

            Position asist2 = new Position();
            asist2.Name = "Asistente 2";
            asist2.Salary = 170;
            asist2.tax = 0.02;

            Position mensajero = new Position();
            mensajero.Name = "Mensajero";
            mensajero.Salary = 90;
            mensajero.tax = 0.01;

            Position asist1 = new Position();
            asist1.Name = "Asistente 1";
            asist1.Salary = 250;
            asist1.tax = 0.03;


            UniversityTree universityTree = new UniversityTree();

            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, JefeFinPosition, vicFinPosition.Name);

            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefereg, vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, sectreg2, jefereg.Name);

            universityTree.CreatePosition(universityTree.Root, sectreg1, jefereg.Name);
            universityTree.CreatePosition(universityTree.Root, asist2, sectreg1.Name);
            universityTree.CreatePosition(universityTree.Root, mensajero, asist2.Name);

            universityTree.CreatePosition(universityTree.Root, asist1, sectreg1.Name);


            universityTree.PrintTree(universityTree.Root);

            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salaries: {totalSalary}");

            universityTree.LongestSalary(universityTree.Root);
            Console.WriteLine($"The best salary is: {universityTree.countLongestSalary}");

            float SalaryAverage = universityTree.SalaryAverage();
            Console.WriteLine($" the salary average is: {SalaryAverage}");



            Console.WriteLine("whose salary do you want to know?");
            String find = Console.ReadLine();
            float salaryForPosition = universityTree.SalaryForPosition(universityTree.Root, find); 
            if (salaryForPosition == 0)
            {
                Console.WriteLine("the name is not valid");
            }
            else { 
            Console.WriteLine($"this person's salary is: {salaryForPosition}");
            }

            double totalTaxes = universityTree.TotalTaxes(universityTree.Root);
            Console.WriteLine($"Total Taxes: {totalTaxes}");

        }
    }
}
