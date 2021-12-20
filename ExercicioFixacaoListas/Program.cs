using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 10;

            List<Employee> employeeList = new List<Employee>();

            while (opt != 0)
            {
                Console.Clear();
                Console.WriteLine("WORKER REGISTRATION MENU");
                Console.WriteLine();
                Console.WriteLine("-------------------");
                Console.WriteLine("1. REGISTRATION");
                Console.WriteLine("2. FIND BY ID");
                Console.WriteLine("3. SALARY ALTERATION");
                Console.WriteLine("4. ERASE EMPLOYEE");
                Console.WriteLine("5. LIST OF EMPLOYEES");
                Console.WriteLine("0. QUIT");
                Console.WriteLine();
                Console.Write("SELECT AN OPTION: ");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("-----------REGISTRATION-----------");
                        Console.WriteLine();
                        Console.Write("NAME: ");
                        string nameStr = Console.ReadLine().ToUpper(); ;
                        Employee emp = employeeList.Find(x => x.Name == nameStr);
                        foreach (Employee obj in employeeList)
                        {
                            if (emp.Name == nameStr)
                                while (emp.Name == nameStr)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("This NAME already exist");
                                    Console.Write("Please enter another NAME: ");
                                    nameStr = Console.ReadLine().ToUpper();
                                }
                        }
                        Console.WriteLine();
                        Console.Write("ID: ");
                        int idInt = int.Parse(Console.ReadLine());
                        emp = employeeList.Find(x => x.Id == idInt);
                        foreach(Employee obj in employeeList)
                        {
                            if(emp.Id == idInt)
                                while(emp.Id == idInt)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("This ID already exist");
                                    Console.Write("Please enter another ID: ");
                                    idInt = int.Parse(Console.ReadLine());
                                }
                        }
                        Console.WriteLine();
                        Console.Write("SALARY: ");
                        double salaryDouble = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        employeeList.Add(new Employee(nameStr, idInt, salaryDouble));

                        Console.Clear();
                        Console.WriteLine("Updated list of employees:");
                        Console.WriteLine();
                        foreach (Employee obj in employeeList)
                        {
                            Console.WriteLine(obj);
                            Console.WriteLine();
                        }
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Press any key to return to MENU");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("-----------FIND BY ID-----------");
                        Console.WriteLine();
                        Console.Write("ID TO BE FOUND: ");
                        idInt = int.Parse(Console.ReadLine());

                        emp = employeeList.Find(x => x.Id == idInt);
                        if (emp != null)
                        {
                            Console.WriteLine(emp);
                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine("Press any key to return to MENU");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("This ID does not exist");
                            Console.WriteLine();
                            Console.Write("Try again? (s/n): ");
                            char tryAgain = char.Parse(Console.ReadLine().ToUpper());
                            if (tryAgain.Equals('S'))
                                goto case 2;
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("-----------SALARY ALTERATION-----------");
                        Console.WriteLine();
                        Console.Write("ID TO BE FOUND: ");
                        idInt = int.Parse(Console.ReadLine());

                        emp = employeeList.Find(x => x.Id == idInt);
                        if (emp != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine(emp);
                            Console.Write("Is this the right result? (s/n): ");
                            char rightResult = char.Parse(Console.ReadLine().ToUpper());

                            if (rightResult.Equals('S'))
                            {
                                emp.SalaryAlteration();
                                Console.WriteLine("Slary alteration successful");
                                Console.WriteLine();
                                Console.WriteLine(emp);
                                Console.WriteLine("-------------------------------------------");
                                Console.WriteLine("Press any key to return to MENU");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.Write("Try again? (s/n): ");
                                char tryAgain = char.Parse(Console.ReadLine().ToUpper());

                                if(tryAgain.Equals('S'))
                                    goto case 3;
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("This ID does not exist");
                            Console.WriteLine();
                            Console.Write("Try again? (s/n): ");
                            char tryAgain = char.Parse(Console.ReadLine().ToUpper());
                            if (tryAgain.Equals('S'))
                                goto case 3;
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("-----------ERASE EMPLOYEE-----------");
                        Console.WriteLine();
                        Console.Write("ID TO BE FOUND: ");
                        idInt = int.Parse(Console.ReadLine());

                        emp = employeeList.Find(x => x.Id == idInt);
                        if(emp != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine(emp);
                            Console.Write("Is this the right result? (s/n): ");
                            char rightResult = char.Parse(Console.ReadLine().ToUpper());

                            if (rightResult.Equals('S'))
                            {
                                employeeList.Remove(emp);

                                Console.WriteLine("Updated list of employees:");
                                Console.WriteLine();
                                foreach (Employee obj in employeeList)
                                {
                                    Console.WriteLine(obj);
                                    Console.WriteLine();
                                }
                                Console.WriteLine("-------------------------------------------");
                                Console.WriteLine("Press any key to return to MENU");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("This ID does not exist");
                            Console.WriteLine();
                            Console.Write("Try again? (s/n): ");
                            char tryAgain = char.Parse(Console.ReadLine().ToUpper());
                            if (tryAgain.Equals('S'))
                                goto case 4;
                        }
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("-----------LIST OF EMPLOYEES-----------");
                        Console.WriteLine();
                        foreach (Employee obj in employeeList)
                        {
                            Console.WriteLine(obj);
                            Console.WriteLine();
                        }
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Press any key to return to MENU");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
