using System.Collections.ObjectModel;

namespace ExpenseIT
{
    class ExpenseViewModel
    {
        public ObservableCollection<Person> People { get; set; }
        public ExpenseViewModel()
        {
            People = new ObservableCollection<Person>
            {
                new Person
                {
                    Name="Mike",
                    Department="Sales",
                    Expenses = new List<Expense>
                    {
                        new Expense {ExpenseType="Lunch", ExpenseAmount=50},
                        new Expense {ExpenseType="Hotel", ExpenseAmount=200}
                    }
                },

                new Person
                {
                    Name="Lisa",
                    Department="Marketing",
                    Expenses = new List<Expense>
                    {
                        new Expense{ExpenseType="Flight", ExpenseAmount=250},
                        new Expense{ExpenseType="Food", ExpenseAmount=500}
                    }
                }

            };
        }
    }
}
