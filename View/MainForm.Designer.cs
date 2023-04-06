namespace View
{
    partial class MainForm
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
            System.Windows.Forms.GroupBox groupBox2;
            this._employeesGrid = new System.Windows.Forms.DataGridView();
            this._actionsGroupBox = new System.Windows.Forms.GroupBox();
            this._exitButton = new System.Windows.Forms.Button();
            this._loadButton = new System.Windows.Forms.Button();
            this._saveButton = new System.Windows.Forms.Button();
            this._searchButton = new System.Windows.Forms.Button();
            this._removeButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this._openDialog = new System.Windows.Forms.OpenFileDialog();
            this._saveDialog = new System.Windows.Forms.SaveFileDialog();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._employeesGrid)).BeginInit();
            this._actionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this._employeesGrid);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(205, 0);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox2.Size = new System.Drawing.Size(776, 427);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Работники";
            // 
            // _employeesGrid
            // 
            this._employeesGrid.AllowUserToAddRows = false;
            this._employeesGrid.AllowUserToDeleteRows = false;
            this._employeesGrid.AllowUserToResizeRows = false;
            this._employeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._employeesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._employeesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._employeesGrid.Location = new System.Drawing.Point(4, 19);
            this._employeesGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._employeesGrid.MultiSelect = false;
            this._employeesGrid.Name = "_employeesGrid";
            this._employeesGrid.ReadOnly = true;
            this._employeesGrid.RowHeadersVisible = false;
            this._employeesGrid.RowHeadersWidth = 51;
            this._employeesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._employeesGrid.Size = new System.Drawing.Size(768, 404);
            this._employeesGrid.TabIndex = 0;
            // 
            // _actionsGroupBox
            // 
            this._actionsGroupBox.Controls.Add(this._exitButton);
            this._actionsGroupBox.Controls.Add(this._loadButton);
            this._actionsGroupBox.Controls.Add(this._saveButton);
            this._actionsGroupBox.Controls.Add(this._searchButton);
            this._actionsGroupBox.Controls.Add(this._removeButton);
            this._actionsGroupBox.Controls.Add(this._addButton);
            this._actionsGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this._actionsGroupBox.Location = new System.Drawing.Point(0, 0);
            this._actionsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._actionsGroupBox.Name = "_actionsGroupBox";
            this._actionsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._actionsGroupBox.Size = new System.Drawing.Size(205, 427);
            this._actionsGroupBox.TabIndex = 0;
            this._actionsGroupBox.TabStop = false;
            this._actionsGroupBox.Text = "Действия";
            // 
            // _exitButton
            // 
            this._exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._exitButton.Location = new System.Drawing.Point(8, 384);
            this._exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(189, 28);
            this._exitButton.TabIndex = 5;
            this._exitButton.Text = "Выход";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.OnExitButtonClick);
            // 
            // _loadButton
            // 
            this._loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._loadButton.Location = new System.Drawing.Point(8, 348);
            this._loadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._loadButton.Name = "_loadButton";
            this._loadButton.Size = new System.Drawing.Size(189, 28);
            this._loadButton.TabIndex = 4;
            this._loadButton.Text = "Загрузить";
            this._loadButton.UseVisualStyleBackColor = true;
            this._loadButton.Click += new System.EventHandler(this.OnLoadButtonClick);
            // 
            // _saveButton
            // 
            this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._saveButton.Location = new System.Drawing.Point(8, 312);
            this._saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(189, 28);
            this._saveButton.TabIndex = 3;
            this._saveButton.Text = "Сохранить";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // _searchButton
            // 
            this._searchButton.Location = new System.Drawing.Point(8, 95);
            this._searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(189, 28);
            this._searchButton.TabIndex = 2;
            this._searchButton.Text = "Поиск";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this.OnSearchButtonClick);
            // 
            // _removeButton
            // 
            this._removeButton.Location = new System.Drawing.Point(8, 59);
            this._removeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._removeButton.Name = "_removeButton";
            this._removeButton.Size = new System.Drawing.Size(189, 28);
            this._removeButton.TabIndex = 1;
            this._removeButton.Text = "Удалить";
            this._removeButton.UseVisualStyleBackColor = true;
            this._removeButton.Click += new System.EventHandler(this.OnRemoveButtonClick);
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(8, 23);
            this._addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(189, 28);
            this._addButton.TabIndex = 0;
            this._addButton.Text = "Добавить";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // _openDialog
            // 
            this._openDialog.FileName = "openFileDialog1";
            this._openDialog.Filter = "Работники (*.emp)|*.emp";
            // 
            // _saveDialog
            // 
            this._saveDialog.Filter = "Работники (*.emp)|*.emp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 427);
            this.Controls.Add(groupBox2);
            this.Controls.Add(this._actionsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(666, 319);
            this.Name = "MainForm";
            this.Text = "View";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._employeesGrid)).EndInit();
            this._actionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _employeesGrid;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.Button _removeButton;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Button _loadButton;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.GroupBox _actionsGroupBox;
        private System.Windows.Forms.OpenFileDialog _openDialog;
        private System.Windows.Forms.SaveFileDialog _saveDialog;
    }
}

