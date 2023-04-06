using System;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    ///     Форма добавления работника
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        ///     Выбранный тип зарплаты.
        /// </summary>
        private SalaryType _selectedType;

        /// <summary>
        ///     Конструктор формы добавления работника
        /// </summary>
        public AddForm()
        {
            InitializeComponent();

            SetSelectedSalaryType(SalaryType.Salary);

            InitValidation();
        }

        /// <summary>
        ///     Работник
        /// </summary>
        public IEmployee Employee;

        /// <summary>
        ///     Инициализирует валидацию полей ввода
        /// </summary>
        private void InitValidation()
        {
            _salaryInput.ValidatingType = typeof(decimal);
            _workingDaysInput.ValidatingType = typeof(int);
            _workedDaysInput.ValidatingType = typeof(int);
            _rateInput.ValidatingType = typeof(decimal);
            _volumeInput.ValidatingType = typeof(decimal);
            _hourRateInput.ValidatingType = typeof(decimal);
            _hoursWorkedInput.ValidatingType = typeof(decimal);

        }

        /// <summary>
        ///     Обработчик нажатия кнопки Отмена
        /// </summary>
        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     Обработчик нажатия кнопки Добавить
        /// </summary>
        private void OnAddButtonClick(object sender, EventArgs e)
        {
            try
            {
                switch (_selectedType)
                {
                    case SalaryType.Salary:
                        if (int.Parse(_workedDaysInput.Text) > int.Parse(_workingDaysInput.Text))
                        {
                            MessageBox.Show("Отработанных дней не может быть больше чем рабочих", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var salary = decimal.Parse(_salaryInput.Text);
                        var workedDays = int.Parse(_workedDaysInput.Text);
                        var workingDays = int.Parse(_workingDaysInput.Text);

                        Employee = EmployeeFactory.Create(_selectedType, salary,
                            workingDays, workedDays);
                        break;
                    case SalaryType.Rate:
                        var rate = decimal.Parse(_rateInput.Text);
                        var volume = decimal.Parse(_volumeInput.Text);

                        Employee = EmployeeFactory.Create(_selectedType, rate,
                            volume);
                        break;
                    case SalaryType.Hour:
                        var hourRate = decimal.Parse(_hourRateInput.Text);
                        var hoursWorked = decimal.Parse(_hoursWorkedInput.Text);

                        Employee = EmployeeFactory.Create(_selectedType,
                            hourRate, hoursWorked);
                        break;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Обработчик изменения выбранного типа зарплаты
        /// </summary>
        private void OnCheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radio)
            {
                SetSelectedSalaryType((SalaryType)radio.TabIndex);
            }
        }

        /// <summary>
        ///     Задаёт выбранный тип зарплаты
        /// </summary>
        /// <param name="type">Тип зарплаты</param>
        private void SetSelectedSalaryType(SalaryType type)
        {
            _selectedType = type;
            _paramsTabControl.SelectedIndex = (int)type;
        }

        /// <summary>
        ///     Обработчик ошибок MaskedTextBox
        /// </summary>
        private void MaskedTextBox_Exceptions(object sender, EventArgs e)
        {
            if (sender is MaskedTextBox box)
            {

                try
                {
                    var test = int.Parse(box.Text);
                }
                catch (Exception ex)
                {
                    box.Focus();
                    box.SelectAll();
                    if (ex.Message.Length == 66)
                    {
                        MessageBox.Show("Максимальное значение " + Int32.MaxValue, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        box.Text = Int32.MaxValue.ToString();
                        return;
                    }
                    MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    box.Text = "0";
                }

            }
        }
    }
}