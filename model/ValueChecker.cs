using System;

namespace Model
{
    /// <summary>
    ///     Проверяет значения
    /// </summary>
    public static class ValueChecker
    {
        /// <summary>
        ///     Проверяет значение на то, что оно больше или равно нулю
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="message">Сообщение об ошибке</param>
        /// <returns>Значение</returns>
        public static decimal CheckNotNegative(decimal value, string message, string parameter)
        {
            if (value < 0m)
            {
                throw new ArgumentException(message, parameter);
            }

            return value;
        }

        /// <summary>
        ///     Проверяет значение на то, что оно больше или равно нулю
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="message">Сообщение об ошибке</param>
        /// <returns>Значение</returns>
        public static int CheckNotNegative(int value, string message, string parameter)
        {
            if (value < 0)
            {
                throw new ArgumentException(message, parameter);
            }

            return value;
        }

        /// <summary>
        ///     Проверяет значение на то, что оно больше нуля
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="message">Сообщение об ошибке</param>
        /// <returns>Значение</returns>
        public static int CheckPositive(int value, string message, string parameter)
        {
            if (value <= 0)
            {
                throw new ArgumentException(message, parameter);
            }

            return value;
        }

        /// <summary>
        ///     Проверяет два значения на равенство
        /// </summary>
        /// <typeparam name="T">Тип значения</typeparam>
        /// <param name="first">Первое значение</param>
        /// <param name="second">Второе значение</param>
        /// <param name="message">Сообщение об ошибке</param>
        public static void CheckAreEqual<T>(T first, T second,
            string message, string parameter)
        {
            if (!Equals(first, second))
            {
                throw new ArgumentException(message, parameter);
            }
        }
    }
}