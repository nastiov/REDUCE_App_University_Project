using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace REDUCE_App1
{
    public partial class frmMenu : Form
    {        
        public frmMenu()
        {
            InitializeComponent();
        }
        //привязка элемента на уровне класса для загрузки меню
        DataSet ds = new DataSet(); //набор данных

        private void frmMenu_Load(object sender, EventArgs e)
        {//в данном методе заполняется форма по логину                     
           
                if (UserInfo.login.Trim() == "UserCouple")
                    try
                {//создаем соединение
                    using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                    {//запуск соединения
                        DBConnection.connection.Open(); //открываем
                        DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetMenuCouple, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                        DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                        dgwMenu.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                        dgwMenu.Columns["FIO"].ReadOnly = true; //ищем в таблице столбец и названием "FIO" и делаем функцию ReadOnly, чтобы не было возможность изменять значения
                        dgwMenu.Columns["FIO"].HeaderText = "Ваше имя"; //ищем в таблице столбец и названием "FIO" и меняем текст

                        //меняем размер формы под размер таблицы
                        int width = dgwMenu.Width - dgwMenu.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dgwMenu.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.MinimumSize = new Size(dgwMenu.Width, dgwMenu.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                else if(UserInfo.login.Trim() == "UserMan")
                    try
                    {//создаем соединение
                        using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                        {//запуск соединения
                            DBConnection.connection.Open(); //открываем
                            DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetMenuMan, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                            DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                            dgwMenu.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                            dgwMenu.Columns["FIO"].ReadOnly = true; //ищем в таблице столбец и названием "FIO" и делаем функцию ReadOnly, чтобы не было возможность изменять значения
                            dgwMenu.Columns["FIO"].HeaderText = "Ваше имя"; //ищем в таблице столбец и названием "FIO" и меняем текст

                            //меняем размер формы под размер таблицы
                            int width = dgwMenu.Width - dgwMenu.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                            foreach (DataGridViewColumn column in dgwMenu.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                            {
                                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                                width += column.Width; //в размер будущей формы добавляем размер столбца
                            }
                            this.MinimumSize = new Size(dgwMenu.Width, dgwMenu.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                else if (UserInfo.login.Trim() == "UserWoman")
                    try
                    {//создаем соединение
                        using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                        {//запуск соединения
                            DBConnection.connection.Open(); //открываем
                            DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetMenuWoman, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                            DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                            dgwMenu.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                            dgwMenu.Columns["FIO"].ReadOnly = true; //ищем в таблице столбец и названием "FIO" и делаем функцию ReadOnly, чтобы не было возможность изменять значения
                            dgwMenu.Columns["FIO"].HeaderText = "Ваше имя"; //ищем в таблице столбец и названием "FIO" и меняем текст

                            //меняем размер формы под размер таблицы
                            int width = dgwMenu.Width - dgwMenu.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                            foreach (DataGridViewColumn column in dgwMenu.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                            {
                                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                                width += column.Width; //в размер будущей формы добавляем размер столбца
                            }
                            this.MinimumSize = new Size(dgwMenu.Width, dgwMenu.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                else
            {
                dgwMenu.Visible = false;
                pNewUsre.Visible = true;
                labNewUsre.Text = $"Добрый день, вы вошли в систему под логином: {UserInfo.login}!\nВаша регистрация прошла успешно.\nК сожаелению, вы ещё не оставить заявку на разработку индивидуального меню для вас.\nМы с радостью подготовим для вас рацион, чтобы вы могли воспользоваться всеми функциями нашего приложения!\nДля этого вам необходимо связаться с нами или сделать запрос Администратору.";
            }



        }

        public static DateTime GetBeginDateOfWeek(int weekNumber)
        {
            DateTime firstDay = new DateTime(DateTime.Now.Year, 1, 1); //1 января сего года
            while (firstDay.DayOfWeek != DayOfWeek.Monday) firstDay = firstDay.AddDays(-1); //ближайший предыдущий понедельник
            return firstDay.AddDays(7 * weekNumber); //добавляем количество недель * 7 дней
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //расчет номера недели
            var dt = new DateTime(DateTime.Now.Year, 6, 15);
            var cal = new GregorianCalendar();
            var weekNumber = cal.GetWeekOfYear(dt, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);
            label1.Text = GetBeginDateOfWeek(weekNumber).ToShortDateString();//вывод пн
            label2.Text = GetBeginDateOfWeek(weekNumber).AddDays(6).ToShortDateString();//вывод вс
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //расчет номера недели
            var dt = new DateTime(DateTime.Now.Year, 6, 15);
            var cal = new GregorianCalendar();
            var weekNumber = cal.GetWeekOfYear(dt, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);
            label4.Text = $"{weekNumber}";
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRequest frmRequest = new frmRequest();
            frmRequest.ShowDialog();
        }
    }
}
