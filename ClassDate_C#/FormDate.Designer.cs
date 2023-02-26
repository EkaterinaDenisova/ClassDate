namespace WindowsFormsAppDate
{
    partial class FormDate
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
            this.buttonFromDateToDays = new System.Windows.Forms.Button();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxDay1 = new System.Windows.Forms.TextBox();
            this.textBoxMonth1 = new System.Windows.Forms.TextBox();
            this.labelMonth = new System.Windows.Forms.Label();
            this.textBoxYear1 = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelInDays = new System.Windows.Forms.Label();
            this.textBoxResultDays = new System.Windows.Forms.TextBox();
            this.buttonFromDaysToDate = new System.Windows.Forms.Button();
            this.textBoxDay2 = new System.Windows.Forms.TextBox();
            this.textBoxMonth2 = new System.Windows.Forms.TextBox();
            this.textBoxYear2 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelEq = new System.Windows.Forms.Label();
            this.labelSign = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFromDateToDays
            // 
            this.buttonFromDateToDays.Location = new System.Drawing.Point(356, 74);
            this.buttonFromDateToDays.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFromDateToDays.Name = "buttonFromDateToDays";
            this.buttonFromDateToDays.Size = new System.Drawing.Size(140, 25);
            this.buttonFromDateToDays.TabIndex = 0;
            this.buttonFromDateToDays.Text = "Дату в дни";
            this.buttonFromDateToDays.UseVisualStyleBackColor = true;
            this.buttonFromDateToDays.Click += new System.EventHandler(this.buttonConvertDate_Click);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(16, 20);
            this.labelDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(40, 16);
            this.labelDay.TabIndex = 1;
            this.labelDay.Text = "Дней";
            // 
            // textBoxDay1
            // 
            this.textBoxDay1.Location = new System.Drawing.Point(19, 39);
            this.textBoxDay1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDay1.Name = "textBoxDay1";
            this.textBoxDay1.Size = new System.Drawing.Size(96, 22);
            this.textBoxDay1.TabIndex = 2;
            this.textBoxDay1.Text = "0";
            // 
            // textBoxMonth1
            // 
            this.textBoxMonth1.Location = new System.Drawing.Point(121, 39);
            this.textBoxMonth1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMonth1.Name = "textBoxMonth1";
            this.textBoxMonth1.Size = new System.Drawing.Size(96, 22);
            this.textBoxMonth1.TabIndex = 4;
            this.textBoxMonth1.Text = "0";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(118, 20);
            this.labelMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(64, 16);
            this.labelMonth.TabIndex = 3;
            this.labelMonth.Text = "Месяцев";
            // 
            // textBoxYear1
            // 
            this.textBoxYear1.Location = new System.Drawing.Point(225, 39);
            this.textBoxYear1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYear1.Name = "textBoxYear1";
            this.textBoxYear1.Size = new System.Drawing.Size(96, 22);
            this.textBoxYear1.TabIndex = 6;
            this.textBoxYear1.Text = "0";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(222, 20);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(31, 16);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "Лет";
            // 
            // labelInDays
            // 
            this.labelInDays.AutoSize = true;
            this.labelInDays.Location = new System.Drawing.Point(354, 20);
            this.labelInDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInDays.Name = "labelInDays";
            this.labelInDays.Size = new System.Drawing.Size(120, 16);
            this.labelInDays.TabIndex = 7;
            this.labelInDays.Text = "Количество дней";
            // 
            // textBoxResultDays
            // 
            this.textBoxResultDays.Location = new System.Drawing.Point(357, 39);
            this.textBoxResultDays.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResultDays.Multiline = true;
            this.textBoxResultDays.Name = "textBoxResultDays";
            this.textBoxResultDays.Size = new System.Drawing.Size(139, 24);
            this.textBoxResultDays.TabIndex = 12;
            this.textBoxResultDays.Text = "0";
            // 
            // buttonFromDaysToDate
            // 
            this.buttonFromDaysToDate.Location = new System.Drawing.Point(356, 107);
            this.buttonFromDaysToDate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFromDaysToDate.Name = "buttonFromDaysToDate";
            this.buttonFromDaysToDate.Size = new System.Drawing.Size(140, 25);
            this.buttonFromDaysToDate.TabIndex = 13;
            this.buttonFromDaysToDate.Text = "Дни в дату";
            this.buttonFromDaysToDate.UseVisualStyleBackColor = true;
            this.buttonFromDaysToDate.Click += new System.EventHandler(this.buttonSetDateInDay_Click);
            // 
            // textBoxDay2
            // 
            this.textBoxDay2.Location = new System.Drawing.Point(19, 75);
            this.textBoxDay2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDay2.Name = "textBoxDay2";
            this.textBoxDay2.Size = new System.Drawing.Size(96, 22);
            this.textBoxDay2.TabIndex = 14;
            this.textBoxDay2.Text = "0";
            // 
            // textBoxMonth2
            // 
            this.textBoxMonth2.Location = new System.Drawing.Point(121, 75);
            this.textBoxMonth2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMonth2.Name = "textBoxMonth2";
            this.textBoxMonth2.Size = new System.Drawing.Size(96, 22);
            this.textBoxMonth2.TabIndex = 15;
            this.textBoxMonth2.Text = "0";
            // 
            // textBoxYear2
            // 
            this.textBoxYear2.Location = new System.Drawing.Point(225, 75);
            this.textBoxYear2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYear2.Name = "textBoxYear2";
            this.textBoxYear2.Size = new System.Drawing.Size(97, 22);
            this.textBoxYear2.TabIndex = 16;
            this.textBoxYear2.Text = "0";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(19, 107);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(145, 25);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Сложить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(172, 107);
            this.buttonSubtract.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(152, 25);
            this.buttonSubtract.TabIndex = 18;
            this.buttonSubtract.Text = "Вычесть";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(19, 168);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(304, 25);
            this.textBoxResult.TabIndex = 20;
            this.textBoxResult.Text = "0";
            // 
            // labelEq
            // 
            this.labelEq.AutoSize = true;
            this.labelEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEq.Location = new System.Drawing.Point(330, 42);
            this.labelEq.Name = "labelEq";
            this.labelEq.Size = new System.Drawing.Size(19, 20);
            this.labelEq.TabIndex = 21;
            this.labelEq.Text = "=";
            // 
            // labelSign
            // 
            this.labelSign.AutoSize = true;
            this.labelSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSign.Location = new System.Drawing.Point(1, 60);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(14, 16);
            this.labelSign.TabIndex = 22;
            this.labelSign.Text = "+";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(16, 148);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(82, 16);
            this.labelRes.TabIndex = 23;
            this.labelRes.Text = "Новая дата";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.Location = new System.Drawing.Point(16, 214);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 18);
            this.labelError.TabIndex = 24;
            // 
            // FormDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 248);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelSign);
            this.Controls.Add(this.labelEq);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxYear2);
            this.Controls.Add(this.textBoxMonth2);
            this.Controls.Add(this.textBoxDay2);
            this.Controls.Add(this.buttonFromDaysToDate);
            this.Controls.Add(this.textBoxResultDays);
            this.Controls.Add(this.labelInDays);
            this.Controls.Add(this.textBoxYear1);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxMonth1);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.textBoxDay1);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.buttonFromDateToDays);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDate";
            this.Text = "Таймер даты";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFromDateToDays;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxDay1;
        private System.Windows.Forms.TextBox textBoxMonth1;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.TextBox textBoxYear1;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelInDays;
        private System.Windows.Forms.TextBox textBoxResultDays;
        private System.Windows.Forms.Button buttonFromDaysToDate;
        private System.Windows.Forms.TextBox textBoxDay2;
        private System.Windows.Forms.TextBox textBoxMonth2;
        private System.Windows.Forms.TextBox textBoxYear2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelEq;
        private System.Windows.Forms.Label labelRes;
        public System.Windows.Forms.Label labelSign;
        public System.Windows.Forms.Label labelError;
    }
}

