namespace Model
{
    /// <summary>
    ///     Методы расширения для класса <see cref="SalaryType" />
    /// </summary>
    public static class SalaryTypeExtensions
    {
        /// <summary>
        ///     Получает название типа зарплаты
        /// </summary>
        /// <param name="type">Тип зарплаты</param>
        /// <returns>Название типа зарплаты</returns>
        public static string GetTitle(this SalaryType type)
        {
            switch (type)
            {
                case SalaryType.Salary:
                    return "Оклад";
                case SalaryType.Rate:
                    return "Ставка";
                case SalaryType.Hour:
                    return "Почасовая ставка";
                default:
                    return string.Empty;
            }
        }
    }
}