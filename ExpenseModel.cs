using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseIT
{
    public class Expense
    {
        public string ExpenseType { get; set; }
        public decimal ExpenseAmount { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public List<Expense> Expenses { get; set; }
    }
}
