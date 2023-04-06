namespace View
{
    partial class SearchForm
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
            System.Windows.Forms.Label label1;
            this._searchPatternInput = new System.Windows.Forms.TextBox();
            this._searchButton = new System.Windows.Forms.Button();
            this._resetButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
            label1.TabIndex = 0;
            label1.Text = "Шаблон: ";
            // 
            // _searchPatternInput
            // 
            this._searchPatternInput.Location = new System.Drawing.Point(71, 10);
            this._searchPatternInput.Name = "_searchPatternInput";
            this._searchPatternInput.Size = new System.Drawing.Size(243, 20);
            this._searchPatternInput.TabIndex = 1;
            // 
            // _searchButton
            // 
            this._searchButton.Location = new System.Drawing.Point(12, 46);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(116, 23);
            this._searchButton.TabIndex = 2;
            this._searchButton.Text = "Поиск";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this.OnSearchButtonClick);
            // 
            // _resetButton
            // 
            this._resetButton.Location = new System.Drawing.Point(198, 46);
            this._resetButton.Name = "_resetButton";
            this._resetButton.Size = new System.Drawing.Size(116, 23);
            this._resetButton.TabIndex = 3;
            this._resetButton.Text = "Сброс";
            this._resetButton.UseVisualStyleBackColor = true;
            this._resetButton.Click += new System.EventHandler(this.OnResetButtonClick);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 81);
            this.Controls.Add(this._resetButton);
            this.Controls.Add(this._searchButton);
            this.Controls.Add(this._searchPatternInput);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchForm";
            this.Text = "Поиск";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _searchPatternInput;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.Button _resetButton;
    }
}