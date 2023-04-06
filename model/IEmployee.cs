namespace Model
{
    /// <summary>
    ///     Работник
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        ///     Тип зарплаты
        /// </summary>
        SalaryType SalaryType { get; }

        /// <summary>
        ///     Получает зарплату работника.
        /// </summary>
        /// <returns>Зарплата работника.</returns>
        decimal GetSalary();

        /// <summary>
        ///     Получает описание параметров работника.
        /// </summary>
        /// <returns>Описание параметров работника.</returns>
        string GetDescription();
    }
}