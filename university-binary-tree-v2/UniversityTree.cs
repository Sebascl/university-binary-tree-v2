using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeUniversity
{
    class UniversityTree
    {
        public PositionNode Root;
        public int count = 0;
        public float countLongestSalary = 0;

        public void CreatePosition(PositionNode parent, Position positionToCreate, string parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;


            if (Root == null)
            {
                Root = newNode;
                return;
            }

            if (parent == null)
            {
                return;
            }

            if (parent.Position.Name == parentPositionName)
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
        public float AddSalaries(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }

            return from.Position.Salary + AddSalaries(from.Left) + AddSalaries(from.Right);

        }




        //2,1
        public void LongestSalary(PositionNode from)
        {
            if (from == null)
            {
                return;
            }
            if (from.Position != Root.Position && from.Position.Salary > countLongestSalary)
            {
                countLongestSalary = from.Position.Salary;
            }
            LongestSalary(from.Left);
            LongestSalary(from.Right);
        }

        //2,2

        public float CountEmployees(PositionNode from)
        {
            if (from == null)
            {
                return count;
            }
            count++;
            CountEmployees(from.Left);
            return CountEmployees(from.Right);
        }

        public float SalaryAverage()
        {
            return AddSalaries(Root) / CountEmployees(Root);
        }

        //2,3 
        public float SalaryForPosition(PositionNode from, string name)
        {
            if (from == null)
            {
                return 0;
            }
            if (from.Position.Name == name)
            {
                return from.Position.Salary;
            }
            return SalaryForPosition(from.Left, name) + SalaryForPosition(from.Right, name);
        }


        //2,4

        public double TotalTaxes(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return (from.Position.Salary * from.Position.tax) + TotalTaxes(from.Left) + TotalTaxes(from.Right);
        }
    }
}
