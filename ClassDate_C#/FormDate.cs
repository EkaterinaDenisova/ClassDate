/// @author Денисова Екатерина
/// Файл с обработчиками событий (нажатий на кнопки)
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsAppDate
{

    public partial class FormDate : Form
    {
        // Date1 и Date2 - ссылки на объекты класса Date
        // Поля класса FormDate
        // Ручное освобождение памяти не требуется, так как есть сборщик мусора
        Date Date1 = new Date();
        Date Date2 = new Date();

        /// Конструктор формы
        public FormDate()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        /// Перевод даты в дни
        private void buttonConvertDate_Click(object sender, EventArgs e)
        {
            try
            {
                Date1.SetDate(Convert.ToInt32(textBoxDay1.Text), Convert.ToInt32(textBoxMonth1.Text), Convert.ToInt32(textBoxYear1.Text));
                textBoxResultDays.Text = Date1.ConvertDateToDays().ToString();
                labelError.Text = ""; // очистка поля вывода ошибок, если не было выброшено исключений
            }
            catch (ArgumentException er)
            {
                labelError.Text = er.Message; // вывод сообщения об ошибке пользователю
            }
        }

        /// Перевод дней в дату
        private void buttonSetDateInDay_Click(object sender, EventArgs e)
        {
            try
            {
                
                Date1.ConvertDaysToDate(Convert.ToInt32(textBoxResultDays.Text));
                textBoxYear1.Text = Date1.GetYear().ToString();
                textBoxMonth1.Text = Date1.GetMonth().ToString();
                textBoxDay1.Text = Date1.GetDay().ToString();
                labelError.Text = "";
            }
            catch (ArgumentException er)
            {
                labelError.Text = er.Message; // вывод сообщения об ошибке пользователю
            }
        }

        private void SetDates()
        {
            Date1.SetDate(Convert.ToInt32(textBoxDay1.Text), Convert.ToInt32(textBoxMonth1.Text), Convert.ToInt32(textBoxYear1.Text));
            Date2.SetDate(Convert.ToInt32(textBoxDay2.Text), Convert.ToInt32(textBoxMonth2.Text), Convert.ToInt32(textBoxYear2.Text));
        }

        /// Сложение даты
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                labelSign.Text = "+";
                SetDates();
                //Date1.SetDate(Convert.ToInt32(textBoxDay1.Text), Convert.ToInt32(textBoxMonth1.Text), Convert.ToInt32(textBoxYear1.Text));
                //Date2.SetDate(Convert.ToInt32(textBoxDay2.Text), Convert.ToInt32(textBoxMonth2.Text), Convert.ToInt32(textBoxYear2.Text));

                Date2.AddDate(Date1);
                textBoxResult.Text = Date2.ToString();
                labelError.Text = "";
            }
            catch (ArgumentException er)
            {
                labelError.Text = er.Message; // вывод сообщения об ошибке пользователю
            }

        }

        /// Вычитание даты
        private void buttonSub_Click(object sender, EventArgs e)
        {
            try
            {
                labelSign.Text = "-";
                SetDates();
                //Date1.SetDate(Convert.ToInt32(textBoxDay1.Text), Convert.ToInt32(textBoxMonth1.Text), Convert.ToInt32(textBoxYear1.Text));
                //Date2.SetDate(Convert.ToInt32(textBoxDay2.Text), Convert.ToInt32(textBoxMonth2.Text), Convert.ToInt32(textBoxYear2.Text));

                Date1.SubDate(Date2);
                textBoxResult.Text = Date1.ToString();
                labelError.Text = "";
            }
            catch (ArgumentException er)
            {
                labelError.Text = er.Message; // вывод сообщения об ошибке пользователю
            }
        }
    }
}
