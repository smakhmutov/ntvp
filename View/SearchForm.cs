using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    ///     Форма поиска
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        ///     Источник привязки данных
        /// </summary>
        private BindingSource _source;

        /// <summary>
        ///     Конструктор формы поиска
        /// </summary>
        public SearchForm(BindingSource source)
        {
            InitializeComponent();

            _source = source;
        }

        /// <summary>
        ///     Обработчик нажатия кнопки Сброс
        /// </summary>
        private void OnResetButtonClick(object sender, EventArgs e)
        {
            _searchPatternInput.Text = string.Empty;
            _source.Filter = string.Empty;
        }

        /// <summary>
        ///     Обработчик нажатия кнопки Поиск
        /// </summary>
        private void OnSearchButtonClick(object sender, EventArgs e)
        {
            var pattern = _searchPatternInput.Text;
            if (string.IsNullOrWhiteSpace(pattern))
            {
                _source.Filter = string.Empty;
                return;
            }

            _source.Filter = string.Format("{0} LIKE '%{3}%'" +
                "OR Convert({1}, 'System.String') LIKE '%{3}%'" +
                "OR Convert([{2}], 'System.String') LIKE '%{3}%'",
                "Тип", "Параметры", "Зарплата", pattern);
        }
    }
}