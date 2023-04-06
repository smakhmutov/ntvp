using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    ///     Основная форма.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        ///     Список работников.
        /// </summary>
        private List<IEmployee> _employeesList;

        /// <summary>
        ///     Таблица работников.
        /// </summary>
        private DataTable _employeesTable;

        /// <summary>
        ///     Источник привязки данных для таблицы.
        /// </summary>
        private BindingSource _bindingSource;

        /// <summary>
        ///     Конструктор основной формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _employeesList = new List<IEmployee>();
            _employeesTable = new DataTable();
            _employeesTable.Columns.Add("Тип", typeof(string));
            _employeesTable.Columns.Add("Параметры", typeof(string));
            _employeesTable.Columns.Add("Зарплата", typeof(decimal));
            _bindingSource = new BindingSource(_employeesTable, string.Empty);
            _employeesGrid.DataSource = _bindingSource;
            
#if DEBUG
            var button = new Button
            {
                Size = _addButton.Size,
                Location = new Point(_saveButton.Location.X,
                    106),
                Text = "Create Random Data"
            };

            var random = new Random();
            button.Click += (_, __) =>
            {
                for (var i = 0; i < 10; i++)
                {
                    var type = (SalaryType) random.Next(3);

                    switch (type)
                    {
                        case SalaryType.Salary:
                            var salary = 25000 + random.Next(50000);
                            var workingDays = 19 + random.Next(3);
                            var workedDays = workingDays - 2 
                                + random.Next(5);

                            AddEmployee(EmployeeFactory.Create(type, salary, 
                                workingDays, workedDays));
                            break;
                        case SalaryType.Rate:
                            var rate = 18000 + random.Next(10000);
                            var volume = (decimal) (random.NextDouble() * 2);

                            AddEmployee(EmployeeFactory.Create(type, rate, 
                                Math.Round(volume, 2)));
                            break;
                        case SalaryType.Hour:
                            var hourRate = 200 + random.Next(300);
                            var hoursWorked = 140 + random.Next(40);

                            AddEmployee(EmployeeFactory.Create(type, 
                                hourRate, hoursWorked));
                            break;
                    }
                }
            };

            _actionsGroupBox.Controls.Add(button);
#endif
        }

        /// <summary>
        ///     Добавляет работника.
        /// </summary>
        /// <param name="employee">Работник.</param>
        private void AddEmployee(IEmployee employee)
        {
            _employeesList.Add(employee);

            var type = employee.SalaryType.GetTitle();
            var description = employee.GetDescription();
            var salary = employee.GetSalary();

            _employeesTable.Rows.Add(type, description, salary);
        }

        /// <summary>
        ///     Обработчик нажатия кнопки Выход
        /// </summary>
        private void OnExitButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     Обработчик нажатия кнопки Добавить
        /// </summary>
        private void OnAddButtonClick(object sender, EventArgs e)
        {
            using (var addForm = new AddForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    AddEmployee(addForm.Employee);
                }
            }
        }

        /// <summary>
        ///     Обработчик нажатия кнопки Удалить
        /// </summary>
        private void OnRemoveButtonClick(object sender, EventArgs e)
        {
            if (_employeesGrid.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedRow = _employeesGrid.SelectedRows[0].Index;

            _employeesList.RemoveAt(selectedRow);
            _employeesTable.Rows.RemoveAt(selectedRow);
        }

        /// <summary>
        ///     Обработчик нажатия кнопки Поиск
        /// </summary>
        private void OnSearchButtonClick(object sender, EventArgs e)
        {
            var form = new SearchForm(_bindingSource);

            form.Show();

            form.Closed += (_, __) => form.Dispose();
        }

        /// <summary>
        ///     Обработчик нажатия кнопки Сохранить
        /// </summary>
        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            if (_saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.OpenWrite(_saveDialog.FileName))
                {
                    var serializer = new BinaryFormatter();
                    serializer.Serialize(stream, _employeesList);
                }
            }
        }

        /// <summary>
        ///     Обработчик нажатия кнопки Загрузить
        /// </summary>
        private void OnLoadButtonClick(object sender, EventArgs e)
        {
            if (_openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var stream = File.OpenRead(_openDialog.FileName))
                    {
                   
                        var serializer = new BinaryFormatter();
                        var graph = serializer.Deserialize(stream);

                        if (graph is IEnumerable<IEmployee> employees)
                        {
                            _employeesList.Clear();
                            _employeesTable.Rows.Clear();

                            foreach (var employee in employees)
                            {
                                AddEmployee(employee);
                            }

                            return;
                        }
                    }
                    
                    }
                catch
                {
                    // Ничего не делаем в этом блоке, чтобы избежать
                    // дублирования кода.
                }

                    MessageBox.Show("Не удалось загрузить файл",
                        "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}