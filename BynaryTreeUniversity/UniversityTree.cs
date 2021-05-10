using System;
using System.Collections.Generic;
using System.Text;

namespace BynaryTreeUniversity
{
    class UniversityTree
    {
        public PositionNode Root;

        public void CreatePosition(PositionNode parent, Position positionToCreate, String parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            if(parent == null)
            {
                return;
            }        

            if(parent.Position.Name == parentPositionName)
            {
                if (parent.Left == null)
                {
                    parent.Left = newNode;
                    return;
                }
                parent.Right = newNode;
                return;
            }
                
             CreatePosition(parent.Left, positionToCreate, parentPositionName);
             CreatePosition(parent.Right, positionToCreate, parentPositionName);              

         }

        public void PrintTree(PositionNode from)
        {
            if (from == null)
            {
                return;
            }
        
            Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary}");

            PrintTree(from.Left);
            PrintTree(from.Right);
        }

        public float addSalaries(PositionNode from)
                {
                    if (from == null)
                    {
                        return 0;
                    }

                    return from.Position.Salary + addSalaries(from.Left) + addSalaries(from.Right);


                    PrintTree(from.Left);
                    PrintTree(from.Right);
                }


        // Point 1  longest salary
        public float salaryLongest(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }

            if (from.Position.Name != "Rector")
            {
                if (salaryLongest(from.Right) > from.Position.Salary || salaryLongest(from.Left) > from.Position.Salary)
                {
                    if (salaryLongest(from.Right) > salaryLongest(from.Left))
                    {
                        return salaryLongest(from.Right);
                    }
                    else
                    {
                        return salaryLongest(from.Left);
                    }
                }
                else
                {
                    return from.Position.Salary;
                }
            }
            else
            {
                if (salaryLongest(from.Right) > salaryLongest(from.Left))
                {
                    return salaryLongest(from.Right);
                }
                else
                {
                    return salaryLongest(from.Left);
                }
            }
        }


        // Point 2 average salary

        public float amountPersonal(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }

            return 1 + amountPersonal(from.Left) + amountPersonal(from.Right);

            PrintTree(from.Left);
            PrintTree(from.Right);
        }
        public float averageSalaries(PositionNode from)
        {
            return addSalaries(from) / amountPersonal(from);
        }

        
        // Point 3 Salary Employee
        public float SalaryEmployee(PositionNode from, String name)
        {
            if (from == null)
            {
                return 0;
            }
            if (from.Position.Name == name)
            {
                return from.Position.Salary;
            }
            else
            {
                return SalaryEmployee(from.Left, name) + SalaryEmployee(from.Right, name);
            }
        }

        //^Point 4 Tax
        public float sumTax(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }

            return (from.Position.Salary * Convert.ToSingle(from.Position.Tax) ) + sumTax(from.Left) + sumTax(from.Right);
        }
    }
}
        