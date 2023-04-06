namespace View
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this._hourRateRadioButton = new System.Windows.Forms.RadioButton();
            this._rateRadioButton = new System.Windows.Forms.RadioButton();
            this._salaryRadioButton = new System.Windows.Forms.RadioButton();
            this._paramsTabControl = new System.Windows.Forms.TabControl();
            this._salaryPage = new System.Windows.Forms.TabPage();
            this._workedDaysInput = new System.Windows.Forms.MaskedTextBox();
            this._workingDaysInput = new System.Windows.Forms.MaskedTextBox();
            this._salaryInput = new System.Windows.Forms.MaskedTextBox();
            this._ratePage = new System.Windows.Forms.TabPage();
            this._volumeInput = new System.Windows.Forms.MaskedTextBox();
            this._rateInput = new System.Windows.Forms.MaskedTextBox();
            this._hourRatePage = new System.Windows.Forms.TabPage();
            this._hoursWorkedInput = new System.Windows.Forms.MaskedTextBox();
            this._hourRateInput = new System.Windows.Forms.MaskedTextBox();
            this._addButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            this._paramsTabControl.SuspendLayout();
            this._salaryPage.SuspendLayout();
            this._ratePage.SuspendLayout();
            this._hourRatePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this._hourRateRadioButton);
            groupBox1.Controls.Add(this._rateRadioButton);
            groupBox1.Controls.Add(this._salaryRadioButton);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(179, 97);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип зарплаты";
            // 
            // _hourRateRadioButton
            // 
            this._hourRateRadioButton.AutoSize = true;
            this._hourRateRadioButton.Location = new System.Drawing.Point(13, 66);
            this._hourRateRadioButton.Name = "_hourRateRadioButton";
            this._hourRateRadioButton.Size = new System.Drawing.Size(118, 17);
            this._hourRateRadioButton.TabIndex = 2;
            this._hourRateRadioButton.Text = "Почасовая ставка";
            this._hourRateRadioButton.UseVisualStyleBackColor = true;
            this._hourRateRadioButton.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // _rateRadioButton
            // 
            this._rateRadioButton.AutoSize = true;
            this._rateRadioButton.Location = new System.Drawing.Point(13, 43);
            this._rateRadioButton.Name = "_rateRadioButton";
            this._rateRadioButton.Size = new System.Drawing.Size(61, 17);
            this._rateRadioButton.TabIndex = 1;
            this._rateRadioButton.Text = "Ставка";
            this._rateRadioButton.UseVisualStyleBackColor = true;
            this._rateRadioButton.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // _salaryRadioButton
            // 
            this._salaryRadioButton.AutoSize = true;
            this._salaryRadioButton.Checked = true;
            this._salaryRadioButton.Location = new System.Drawing.Point(13, 20);
            this._salaryRadioButton.Name = "_salaryRadioButton";
            this._salaryRadioButton.Size = new System.Drawing.Size(57, 17);
            this._salaryRadioButton.TabIndex = 0;
            this._salaryRadioButton.TabStop = true;
            this._salaryRadioButton.Text = "Оклад";
            this._salaryRadioButton.UseVisualStyleBackColor = true;
            this._salaryRadioButton.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this._paramsTabControl);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox2.Location = new System.Drawing.Point(0, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(179, 109);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Параметры";
            // 
            // _paramsTabControl
            // 
            this._paramsTabControl.Controls.Add(this._salaryPage);
            this._paramsTabControl.Controls.Add(this._ratePage);
            this._paramsTabControl.Controls.Add(this._hourRatePage);
            this._paramsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._paramsTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this._paramsTabControl.Location = new System.Drawing.Point(3, 16);
            this._paramsTabControl.Name = "_paramsTabControl";
            this._paramsTabControl.SelectedIndex = 0;
            this._paramsTabControl.Size = new System.Drawing.Size(173, 90);
            this._paramsTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this._paramsTabControl.TabIndex = 0;
            // 
            // _salaryPage
            // 
            this._salaryPage.Controls.Add(this._workedDaysInput);
            this._salaryPage.Controls.Add(label3);
            this._salaryPage.Controls.Add(this._workingDaysInput);
            this._salaryPage.Controls.Add(label2);
            this._salaryPage.Controls.Add(this._salaryInput);
            this._salaryPage.Controls.Add(label1);
            this._salaryPage.Location = new System.Drawing.Point(4, 5);
            this._salaryPage.Name = "_salaryPage";
            this._salaryPage.Padding = new System.Windows.Forms.Padding(3);
            this._salaryPage.Size = new System.Drawing.Size(165, 81);
            this._salaryPage.TabIndex = 0;
            this._salaryPage.Text = "tabPage1";
            this._salaryPage.UseVisualStyleBackColor = true;
            // 
            // _workedDaysInput
            // 
            this._workedDaysInput.Location = new System.Drawing.Point(113, 55);
            this._workedDaysInput.Name = "_workedDaysInput";
            this._workedDaysInput.Size = new System.Drawing.Size(45, 20);
            this._workedDaysInput.TabIndex = 5;
            this._workedDaysInput.Text = "20";
            this._workedDaysInput.Leave += new System.EventHandler(this.MaskedTextBox_Exceptions);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 58);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(100, 13);
            label3.TabIndex = 4;
            label3.Text = "Отработано дней: ";
            // 
            // _workingDaysInput
            // 
            this._workingDaysInput.Location = new System.Drawing.Point(113, 29);
            this._workingDaysInput.Name = "_workingDaysInput";
            this._workingDaysInput.Size = new System.Drawing.Size(45, 20);
            this._workingDaysInput.TabIndex = 3;
            this._workingDaysInput.Text = "20";
            this._workingDaysInput.Leave += new System.EventHandler(this.MaskedTextBox_Exceptions);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 13);
            label2.TabIndex = 2;
            label2.Text = "Рабочих дней: ";
            // 
            // _salaryInput
            // 
            this._salaryInput.Location = new System.Drawing.Point(113, 3);
            this._salaryInput.Name = "_salaryInput";
            this._salaryInput.Size = new System.Drawing.Size(45, 20);
            this._salaryInput.TabIndex = 1;
            this._salaryInput.Text = "50000";
            this._salaryInput.Leave += new System.EventHandler(this.MaskedTextBox_Exceptions);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 13);
            label1.TabIndex = 0;
            label1.Text = "Оклад: ";
            // 
            // _ratePage
            // 
            this._ratePage.Controls.Add(this._volumeInput);
            this._ratePage.Controls.Add(label4);
            this._ratePage.Controls.Add(this._rateInput);
            this._ratePage.Controls.Add(label5);
            this._ratePage.Location = new System.Drawing.Point(4, 5);
            this._ratePage.Name = "_ratePage";
            this._ratePage.Padding = new System.Windows.Forms.Padding(3);
            this._ratePage.Size = new System.Drawing.Size(165, 81);
            this._ratePage.TabIndex = 1;
            this._ratePage.Text = "tabPage2";
            this._ratePage.UseVisualStyleBackColor = true;
            // 
            // _volumeInput
            // 
            this._volumeInput.Location = new System.Drawing.Point(113, 29);
            this._volumeInput.Name = "_volumeInput";
            this._volumeInput.Size = new System.Drawing.Size(45, 20);
            this._volumeInput.TabIndex = 7;
            this._volumeInput.Text = "1,00";
            this._volumeInput.Leave += new System.EventHandler(this.MaskedTextBox_Exceptions);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 32);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 13);
            label4.TabIndex = 6;
            label4.Text = "Объём: ";
            // 
            // _rateInput
            // 
            this._rateInput.Location = new System.Drawing.Point(113, 3);
            this._rateInput.Name = "_rateInput";
            this._rateInput.Size = new System.Drawing.Size(45, 20);
            this._rateInput.TabIndex = 5;
            this._rateInput.Text = "25000";
            this._rateInput.Leave += new System.EventHandler(this.MaskedTextBox_Exceptions);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 6);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 13);
            label5.TabIndex = 4;
            label5.Text = "Ставка: ";
            // 
            // _hourRatePage
            // 
            this._hourRatePage.Controls.Add(this._hoursWorkedInput);
            this._hourRatePage.Controls.Add(label6);
            this._hourRatePage.Controls.Add(this._hourRateInput);
            this._hourRatePage.Controls.Add(label7);
            this._hourRatePage.Location = new System.Drawing.Point(4, 5);
            this._hourRatePage.Name = "_hourRatePage";
            this._hourRatePage.Size = new System.Drawing.Size(165, 81);
            this._hourRatePage.TabIndex = 2;
            this._hourRatePage.Text = "_hourRatePage";
            this._hourRatePage.UseVisualStyleBackColor = true;
            // 
            // _hoursWorkedInput
            // 
            this._hoursWorkedInput.Location = new System.Drawing.Point(113, 29);
            this._hoursWorkedInput.Name = "_hoursWorkedInput";
            this._hoursWorkedInput.Size = new System.Drawing.Size(45, 20);
            this._hoursWorkedInput.TabIndex = 11;
            this._hoursWorkedInput.Text = "160";
            this._hoursWorkedInput.Leave += new System.EventHandler(this.MaskedTextBox_Exceptions);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 32);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(105, 13);
            label6.TabIndex = 10;
            label6.Text = "Отработано часов: ";
            // 
            // _hourRateInput
            // 
            this._hourRateInput.Location = new System.Drawing.Point(113, 3);
            this._hourRateInput.Name = "_hourRateInput";
            this._hourRateInput.Size = new System.Drawing.Size(45, 20);
            this._hourRateInput.TabIndex = 9;
            this._hourRateInput.Text = "350";
            this._hourRateInput.Leave += new System.EventHandler(this.MaskedTextBox_Exceptions);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(7, 6);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(106, 13);
            label7.TabIndex = 8;
            label7.Text = "Почасовая ставка: ";
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(7, 213);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(165, 23);
            this._addButton.TabIndex = 2;
            this._addButton.Text = "Добавить";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(7, 242);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(165, 23);
            this._cancelButton.TabIndex = 3;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.OnCancelButtonClick);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 272);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._addButton);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "Новый работник";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            this._paramsTabControl.ResumeLayout(false);
            this._salaryPage.ResumeLayout(false);
            this._salaryPage.PerformLayout();
            this._ratePage.ResumeLayout(false);
            this._ratePage.PerformLayout();
            this._hourRatePage.ResumeLayout(false);
            this._hourRatePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton _hourRateRadioButton;
        private System.Windows.Forms.RadioButton _rateRadioButton;
        private System.Windows.Forms.RadioButton _salaryRadioButton;
        private System.Windows.Forms.TabControl _paramsTabControl;
        private System.Windows.Forms.TabPage _hourRatePage;
        private System.Windows.Forms.MaskedTextBox _hoursWorkedInput;
        private System.Windows.Forms.MaskedTextBox _hourRateInput;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.TabPage _ratePage;
        private System.Windows.Forms.MaskedTextBox _volumeInput;
        private System.Windows.Forms.MaskedTextBox _rateInput;
        private System.Windows.Forms.TabPage _salaryPage;
        private System.Windows.Forms.MaskedTextBox _workedDaysInput;
        private System.Windows.Forms.MaskedTextBox _workingDaysInput;
        private System.Windows.Forms.MaskedTextBox _salaryInput;
    }
}