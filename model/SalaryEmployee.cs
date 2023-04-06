using System;

namespace Model
{
    /// <summary>
    ///     Работник, зп которого рассчитывается, исходя из оклада
    ///     и выработанной нормы рабочих дней за месяц
    /// </summary>
    [Serializable]
    public class SalaryEmployee : IEmployee
    {
        /// <summary>
        ///     Зарплата работника
        /// </summary>
        private decimal _salary;

        /// <summary>
        ///     Количество отработанных дней за месяц
        /// </summary>
        private int _workedDays;

        /// <summary>
        ///     Количество рабочих дней за месяц
        /// </summary>
        private int _workingDays;

        /// <summary>
        ///     Зарплата работника
        /// </summary>
        public decimal Salary
        {
            get => _salary;
            set => _salary = ValueChecker.CheckNotNegative(value,
                "Оклад не может быть меньше нуля!", "Salary");
        }

        /// <summary>
        ///     Количество рабочих дней за месяц
        /// </summary>
        public int WorkingDays
        {
            get => _workingDays;
            set => _workingDays = ValueChecker.CheckPositive(value,
                "Количество рабочих дней должно быть больше нуля!", "WorkingDays");
        }

        /// <summary>
        ///     Количество отработанных дней за месяц
        /// </summary>
        public int WorkedDays
        {
            get => _workedDays;
            set => _workedDays = ValueChecker.CheckNotNegative(value,
                "Количество отработанных дней не может быть меньше нуля!", "WorkedDays");
        }

        /// <summary>
        ///     Тип зарплаты
        /// </summary>
        public SalaryType SalaryType => SalaryType.Salary;

        /// <summary>
        ///     Получает зарплату работника.
        /// </summary>
        /// <returns>Зарплата работника.</returns>
        public decimal GetSalary()
        {
            return Math.Round((decimal)WorkedDays / WorkingDays * Salary,
                2);
        }

        /// <summary>
        ///     Получает описание параметров работника.
        /// </summary>
        /// <returns>Описание параметров работника.</returns>
        public string GetDescription()
        {
            return $"Оклад: {Salary}, рабочих дней: {WorkingDays}, " +
                $"отработано дней: {WorkedDays}";
        }
    }
}