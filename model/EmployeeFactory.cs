using System;

namespace Model
{
    /// <summary>
    ///     Фабрика работников
    /// </summary>
    public static class EmployeeFactory
    {
        /// <summary>
        ///     Создаёт работника
        /// </summary>
        /// <param name="salaryType">Тип зарплаты</param>
        /// <param name="args">Аргументы</param>
        /// <returns>
        ///     <see cref="IEmployee" />
        /// </returns>
        public static IEmployee Create(SalaryType salaryType,
            params dynamic[] args)
        {
            ValidateArgsCount(salaryType, args.Length);

            switch (salaryType)
            {
                case SalaryType.Salary:
                    return new SalaryEmployee
                    {
                        Salary = args[0],
                        WorkingDays = args[1],
                        WorkedDays = args[2]
                    };
                case SalaryType.Rate:
                    return new RateEmployee
                    {
                        Rate = args[0],
                        Volume = args[1]
                    };
                case SalaryType.Hour:
                    return new HourEmployee
                    {
                        HourRate = args[0],
                        HoursWorked = args[1]
                    };
                default:
                    return null;
            }
        }

        /// <summary>
        /// Выполняет проверку корректности количества переданных аргументов
        /// </summary>
        /// <param name="type">Тип зарплаты</param>
        /// <param name="count">Количество аргументов</param>
        private static void ValidateArgsCount(SalaryType type, int count)
        {
            switch (type)
            {
                case SalaryType.Salary:
                    ValueChecker.CheckAreEqual(count, 3,
                        "Должно быть три аргумента!", "Salary");
                    break;
                case SalaryType.Rate:
                    ValueChecker.CheckAreEqual(count, 2,
                        "Должно быть два аргумента!", "Rate");
                    break;
                case SalaryType.Hour:
                    ValueChecker.CheckAreEqual(count, 2,
                        "Должно быть два аргумента!", "Hour");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type),
                        type, null);
            }
        }
    }
}