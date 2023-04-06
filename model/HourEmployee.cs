using System;

namespace Model
{
    /// <summary>
    ///     Работник, зп которого рассчитывается, исходя из почасовой ставки
    ///     и количества отработанных часов
    /// </summary>
    [Serializable]
    public class HourEmployee : IEmployee
    {
        /// <summary>
        ///     Почасовая ставка
        /// </summary>
        private decimal _hourRate;

        /// <summary>
        ///     Количество отработанных часов
        /// </summary>
        private decimal _hoursWorked;

        /// <summary>
        ///     Почасовая ставка
        /// </summary>
        public decimal HourRate
        {
            get => _hourRate;
            set => _hourRate = ValueChecker.CheckNotNegative(value,
                "Почасовая ставка не может быть меньше нуля!", "HourRate");
        }

        /// <summary>
        ///     Количество отработанных часов
        /// </summary>
        public decimal HoursWorked
        {
            get => _hoursWorked;
            set => _hoursWorked = ValueChecker.CheckNotNegative(value,
                "Количество отработанных часов не может быть меньше нуля!", "HoursWorked");
        }

        /// <summary>
        ///     Тип зарплаты
        /// </summary>
        public SalaryType SalaryType => SalaryType.Hour;

        /// <summary>
        ///     Получает зарплату работника.
        /// </summary>
        /// <returns>Зарплата работника.</returns>
        public decimal GetSalary()
        {
            return Math.Round(HourRate + HoursWorked, 2);
        }

        /// <summary>
        ///     Получает описание параметров работника.
        /// </summary>
        /// <returns>Описание параметров работника.</returns>
        public string GetDescription()
        {
            return $"Почасовая ставка: {HourRate}, " +
                $"отработано часов: {HoursWorked}";
        }
    }
}