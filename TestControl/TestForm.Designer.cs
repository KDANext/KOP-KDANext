namespace TestControl
{
    partial class TestForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.ButtonChange = new System.Windows.Forms.Button();
            this.buttonGetSelectedIndex = new System.Windows.Forms.Button();
            this.buttonSetCheck = new System.Windows.Forms.Button();
            this.controlComboBoxSelected = new ClassLibraryControlSelected.ControlComboBoxSelected();
            this.userControlInput = new Var35n6n18n27.UserControlInput();
            this.userControlSelect = new Var35n6n18n27.UserControlSelect();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.textBoxInpunSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonChange
            // 
            this.ButtonChange.Location = new System.Drawing.Point(12, 62);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(123, 23);
            this.ButtonChange.TabIndex = 1;
            this.ButtonChange.Text = "Сменить номер";
            this.ButtonChange.UseVisualStyleBackColor = true;
            this.ButtonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonGetSelectedIndex
            // 
            this.buttonGetSelectedIndex.Location = new System.Drawing.Point(29, 194);
            this.buttonGetSelectedIndex.Name = "buttonGetSelectedIndex";
            this.buttonGetSelectedIndex.Size = new System.Drawing.Size(215, 23);
            this.buttonGetSelectedIndex.TabIndex = 3;
            this.buttonGetSelectedIndex.Text = "Получить индексы выбранных";
            this.buttonGetSelectedIndex.UseVisualStyleBackColor = true;
            this.buttonGetSelectedIndex.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSetCheck
            // 
            this.buttonSetCheck.Location = new System.Drawing.Point(250, 194);
            this.buttonSetCheck.Name = "buttonSetCheck";
            this.buttonSetCheck.Size = new System.Drawing.Size(286, 23);
            this.buttonSetCheck.TabIndex = 4;
            this.buttonSetCheck.Text = "Установка индексов ";
            this.buttonSetCheck.UseVisualStyleBackColor = true;
            this.buttonSetCheck.Click += new System.EventHandler(this.button2_Click);
            // 
            // controlComboBoxSelected
            // 
            this.controlComboBoxSelected.Location = new System.Drawing.Point(12, 12);
            this.controlComboBoxSelected.Name = "controlComboBoxSelected";
            this.controlComboBoxSelected.SelectedIndex = 0;
            this.controlComboBoxSelected.Size = new System.Drawing.Size(150, 150);
            this.controlComboBoxSelected.TabIndex = 0;
            // 
            // userControlInput
            // 
            this.userControlInput.Location = new System.Drawing.Point(376, 13);
            this.userControlInput.Name = "userControlInput";
            this.userControlInput.Size = new System.Drawing.Size(150, 55);
            this.userControlInput.TabIndex = 5;
            // 
            // userControlSelect
            // 
            this.userControlSelect.CheckIndexs = ((System.Collections.Generic.List<int>)(resources.GetObject("userControlSelect.CheckIndexs")));
            this.userControlSelect.Location = new System.Drawing.Point(169, 13);
            this.userControlSelect.Name = "userControlSelect";
            this.userControlSelect.Size = new System.Drawing.Size(128, 106);
            this.userControlSelect.TabIndex = 2;
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(376, 96);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(66, 23);
            this.buttonMax.TabIndex = 6;
            this.buttonMax.Text = "buttonMax";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(448, 96);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(66, 23);
            this.buttonMin.TabIndex = 7;
            this.buttonMin.Text = "buttonMin";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // textBoxInpunSize
            // 
            this.textBoxInpunSize.Location = new System.Drawing.Point(376, 70);
            this.textBoxInpunSize.Name = "textBoxInpunSize";
            this.textBoxInpunSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxInpunSize.TabIndex = 8;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 227);
            this.Controls.Add(this.textBoxInpunSize);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.userControlInput);
            this.Controls.Add(this.buttonSetCheck);
            this.Controls.Add(this.buttonGetSelectedIndex);
            this.Controls.Add(this.userControlSelect);
            this.Controls.Add(this.ButtonChange);
            this.Controls.Add(this.controlComboBoxSelected);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibraryControlSelected.ControlComboBoxSelected controlComboBoxSelected;
        private System.Windows.Forms.Button ButtonChange;
        private Var35n6n18n27.UserControlSelect userControlSelect;
        private System.Windows.Forms.Button buttonGetSelectedIndex;
        private System.Windows.Forms.Button buttonSetCheck;
        private Var35n6n18n27.UserControlInput userControlInput;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.TextBox textBoxInpunSize;
    }
}

