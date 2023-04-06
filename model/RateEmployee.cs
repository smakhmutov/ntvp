using System;

namespace Model
{
    /// <summary>
    ///     Работник, зп которого рассчитывается, исходя из ставки
    ///     и объёма выполненной работы в долях ставки
    /// </summary>
    [Serializable]
    public class RateEmployee : IEmployee
    {
        /// <summary>
        ///     Ставка
        /// </summary>
        private decimal _rate;

        /// <summary>
        ///     Объём выполненной работы в долях ставки
        /// </summary>
        private decimal _volume;

        /// <summary>
        ///     Ставка
        /// </summary>
        public decimal Rate
        {
            get => _rate;
            set => _rate = ValueChecker.CheckNotNegative(value,
                "Ставка не может быть меньше нуля!", "Rate");
        }

        /// <summary>
        ///     Объём выполненной работы в долях ставки
        /// </summary>
        public decimal Volume
        {
            get => _volume;
            set => _volume = ValueChecker.CheckNotNegative(value,
                "Объём выполненной работы не может быть меньше нуля!", "Volume");
        }

        /// <summary>
        ///     Тип зарплаты
        /// </summary>
        public SalaryType SalaryType => SalaryType.Rate;

        /// <summary>
        ///     Получает зарплату работника.
        /// </summary>
        /// <returns>Зарплата работника.</returns>
        public decimal GetSalary()
        {
            return Math.Round(Rate * Volume, 2);
        }

        /// <summary>
        ///     Получает описание параметров работника.
        /// </summary>
        /// <returns>Описание параметров работника.</returns>
        public string GetDescription()
        {
            return $"Ставка: {Rate}, объём: {Volume}";
        }
    }
}