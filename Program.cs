using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task2, string> TaskSolver = task =>
            {
                string decorativePadding = new string(task.DecorativeSign, Task2.Padding / 2);

                FormattableString balanceString = $"${task.Balance:N2}";
                string balanceStringFormatted = FormattableString.Invariant(balanceString);

                string result = $"{decorativePadding, -Task2.Padding }"
                    + balanceStringFormatted
                    + $"{decorativePadding, Task2.Padding }";

                return result;
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
