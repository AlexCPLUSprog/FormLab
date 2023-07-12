namespace FormLab
{
    partial class Form1
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
            this.rbUsal = new System.Windows.Forms.RadioButton();
            this.panelFormType = new System.Windows.Forms.Panel();
            this.btnCreateForm = new System.Windows.Forms.Button();
            this.lbFormSelect = new System.Windows.Forms.Label();
            this.rbModal = new System.Windows.Forms.RadioButton();
            this.rbMDI = new System.Windows.Forms.RadioButton();
            this.lbDialogResult = new System.Windows.Forms.Label();
            this.textBox_forms = new System.Windows.Forms.TextBox();
            this.listBox_forms = new System.Windows.Forms.ListBox();
            this.panelFormType.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbUsal
            // 
            this.rbUsal.AutoSize = true;
            this.rbUsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbUsal.Location = new System.Drawing.Point(18, 36);
            this.rbUsal.Name = "rbUsal";
            this.rbUsal.Size = new System.Drawing.Size(146, 35);
            this.rbUsal.TabIndex = 0;
            this.rbUsal.TabStop = true;
            this.rbUsal.Text = "Обычная";
            this.rbUsal.UseVisualStyleBackColor = true;
            // 
            // panelFormType
            // 
            this.panelFormType.Controls.Add(this.btnCreateForm);
            this.panelFormType.Controls.Add(this.lbFormSelect);
            this.panelFormType.Controls.Add(this.rbModal);
            this.panelFormType.Controls.Add(this.rbMDI);
            this.panelFormType.Controls.Add(this.rbUsal);
            this.panelFormType.Location = new System.Drawing.Point(12, 36);
            this.panelFormType.Name = "panelFormType";
            this.panelFormType.Size = new System.Drawing.Size(277, 168);
            this.panelFormType.TabIndex = 1;
            // 
            // btnCreateForm
            // 
            this.btnCreateForm.Location = new System.Drawing.Point(184, 47);
            this.btnCreateForm.Name = "btnCreateForm";
            this.btnCreateForm.Size = new System.Drawing.Size(75, 65);
            this.btnCreateForm.TabIndex = 2;
            this.btnCreateForm.Text = "Создать";
            this.btnCreateForm.UseVisualStyleBackColor = true;
            this.btnCreateForm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCreateForm_MouseClick);
            // 
            // lbFormSelect
            // 
            this.lbFormSelect.AutoSize = true;
            this.lbFormSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFormSelect.Location = new System.Drawing.Point(18, 4);
            this.lbFormSelect.Name = "lbFormSelect";
            this.lbFormSelect.Size = new System.Drawing.Size(239, 31);
            this.lbFormSelect.TabIndex = 1;
            this.lbFormSelect.Text = "Тип новой формы";
            // 
            // rbModal
            // 
            this.rbModal.AutoSize = true;
            this.rbModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbModal.Location = new System.Drawing.Point(18, 118);
            this.rbModal.Name = "rbModal";
            this.rbModal.Size = new System.Drawing.Size(240, 35);
            this.rbModal.TabIndex = 0;
            this.rbModal.TabStop = true;
            this.rbModal.Text = "Модальное окно";
            this.rbModal.UseVisualStyleBackColor = true;
            // 
            // rbMDI
            // 
            this.rbMDI.AutoSize = true;
            this.rbMDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMDI.Location = new System.Drawing.Point(18, 77);
            this.rbMDI.Name = "rbMDI";
            this.rbMDI.Size = new System.Drawing.Size(82, 35);
            this.rbMDI.TabIndex = 0;
            this.rbMDI.TabStop = true;
            this.rbMDI.Text = "MDI";
            this.rbMDI.UseVisualStyleBackColor = true;
            // 
            // lbDialogResult
            // 
            this.lbDialogResult.AutoSize = true;
            this.lbDialogResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDialogResult.Location = new System.Drawing.Point(21, 223);
            this.lbDialogResult.Name = "lbDialogResult";
            this.lbDialogResult.Size = new System.Drawing.Size(251, 31);
            this.lbDialogResult.TabIndex = 1;
            this.lbDialogResult.Text = "Результат диалога";
            // 
            // textBox_forms
            // 
            this.textBox_forms.Location = new System.Drawing.Point(393, 154);
            this.textBox_forms.Name = "textBox_forms";
            this.textBox_forms.Size = new System.Drawing.Size(100, 20);
            this.textBox_forms.TabIndex = 4;
            this.textBox_forms.TextChanged += new System.EventHandler(this.textBox_forms_TextChanged);
            // 
            // listBox_forms
            // 
            this.listBox_forms.FormattingEnabled = true;
            this.listBox_forms.Location = new System.Drawing.Point(384, 36);
            this.listBox_forms.Name = "listBox_forms";
            this.listBox_forms.Size = new System.Drawing.Size(120, 95);
            this.listBox_forms.TabIndex = 5;
            this.listBox_forms.SelectedValueChanged += new System.EventHandler(this.listBox_forms_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 316);
            this.Controls.Add(this.listBox_forms);
            this.Controls.Add(this.textBox_forms);
            this.Controls.Add(this.panelFormType);
            this.Controls.Add(this.lbDialogResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelFormType.ResumeLayout(false);
            this.panelFormType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbUsal;
        private System.Windows.Forms.Panel panelFormType;
        private System.Windows.Forms.Label lbFormSelect;
        private System.Windows.Forms.Button btnCreateForm;
        private System.Windows.Forms.RadioButton rbModal;
        private System.Windows.Forms.RadioButton rbMDI;
        private System.Windows.Forms.Label lbDialogResult;
        private System.Windows.Forms.TextBox textBox_forms;
        private System.Windows.Forms.ListBox listBox_forms;
    }
}

