

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//для использования файловой системы
using System.Globalization;


namespace REDUCE_App1
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();

             
        }
        

        void GVinRB() //метод, который записывает данные из dataGridView1 в richTextBox1
        {
            richTextBox1.Text = label3.Text + label1.Text + label4.Text + label2.Text + "\n" + "\n" + "\n";


            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                  {

                      richTextBox1.Text = richTextBox1.Text + "-";

                      for (int j = 0; j < dataGridView1.Columns.Count; j++)
                      {

                          richTextBox1.Text = richTextBox1.Text + " " + dataGridView1.Rows[i].Cells[j].Value.ToString() + " ";

                      }

                      richTextBox1.Text = richTextBox1.Text + "\n";
                      richTextBox1.Text = richTextBox1.Text + "----------------------------------------------------------------------------------------------------------";
                      richTextBox1.Text = richTextBox1.Text + "\n";
                  }
            
            }

        void saveFile()
        {
            try
            { //Создаем поток в памяти, потом будем туда скидывать значения из  richTextBox
                MemoryStream memoryStream = new MemoryStream();
                //И поток для записи в файл
                Stream fileStream;
                //проверяем, существует ли нужная папка, и если нет, то создаем
                if (!Directory.Exists("D:\\Недельный отчет\\" + DateTime.Today.Year + "\\" + DateTime.Today.Date.ToShortDateString()))
                    Directory.CreateDirectory("D:\\Недельный отчет\\" + DateTime.Today.Year + "\\" + DateTime.Today.Date.ToShortDateString());
                //начальная папка для сохранения файла

                saveFileDialog1.InitialDirectory = "D:\\Недельный отчет\\" + DateTime.Today.Year + "\\" + DateTime.Today.Date.ToShortDateString();
                //Дальше диалог сохранения файла 
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((fileStream = saveFileDialog1.OpenFile()) != null)
                    {
                        RichTextBox temp = new RichTextBox();

                        richTextBox1.Text = richTextBox1.Text + Environment.NewLine;
                        richTextBox1.SelectAll();
                        richTextBox1.Copy();

                        temp.Paste();

                        richTextBox2.SelectAll();
                        richTextBox2.Copy();

                        temp.Paste();

                        temp.SaveFile(fileStream, RichTextBoxStreamType.RichText);

                        temp.Clear();
                        
                        fileStream.Close();
                    }

                }

                //если нажали сохранить, то нет возможности изменить первое окно
                richTextBox1.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void choiceWeek() //метод, который выводит данные за неделю
        {
            if (UserInfo.login.Trim() == "UserCouple")
            {
                try
                {//создаем соединение
                    using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                    {//запуск соединения
                        DBConnection.connection.Open(); //открываем
                        DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetListCouple, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                        DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                        dataGridView1.DataSource = ds; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу


                        //меняем размер формы под размер таблицы
                        int width = dataGridView1.Width - dataGridView1.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dataGridView1.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.MinimumSize = new Size(dataGridView1.Width, dataGridView1.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (UserInfo.login.Trim() == "UserMan")
            {
                try
                {//создаем соединение
                    using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                    {//запуск соединения
                        DBConnection.connection.Open(); //открываем
                        DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetListMan, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                        DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                        dataGridView1.DataSource = ds; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                        //меняем размер формы под размер таблицы
                        int width = dataGridView1.Width - dataGridView1.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dataGridView1.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.MinimumSize = new Size(dataGridView1.Width, dataGridView1.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (UserInfo.login.Trim() == "UserWoman")
            {
                try
                {//создаем соединение
                    using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                    {//запуск соединения
                        DBConnection.connection.Open(); //открываем
                        DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetListWoman, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                        DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                        dataGridView1.DataSource = ds; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                        //меняем размер формы под размер таблицы
                        int width = dataGridView1.Width - dataGridView1.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dataGridView1.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.MinimumSize = new Size(dataGridView1.Width, dataGridView1.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            else
            {
                dataGridView1.Visible = false;
                pNewUsre.Visible = true;
                labNewUsre.Text = $"Добрый день, вы вошли в систему под логином: {UserInfo.login}!\nВаша регистрация прошла успешно.\nК сожаелению, вы ещё не оставить заявку на разработку индивидуального меню для вас.\nМы с радостью подготовим для вас рацион, чтобы вы могли воспользоваться всеми функциями нашего приложения!\nДля этого вам необходимо связаться с нами или сделать запрос Администратору.\nОднако, вы уже можите составить свой список продуктов в форме ниже.";
            }
        }

        void choiceMonth() //метод, который выводит данные за месяц
        {
            if (UserInfo.login.Trim() == "UserCouple")
            {
                try
                {//создаем соединение
                    using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                    {//запуск соединения
                        DBConnection.connection.Open(); //открываем
                        DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetListCoupleMonth, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                        DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                        dataGridView1.DataSource = ds; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу


                        //меняем размер формы под размер таблицы
                        int width = dataGridView1.Width - dataGridView1.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dataGridView1.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.MinimumSize = new Size(dataGridView1.Width, dataGridView1.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (UserInfo.login.Trim() == "UserMan")
            {
                try
                {//создаем соединение
                    using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                    {//запуск соединения
                        DBConnection.connection.Open(); //открываем
                        DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetListManMonth, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                        DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                        dataGridView1.DataSource = ds; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                        //меняем размер формы под размер таблицы
                        int width = dataGridView1.Width - dataGridView1.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dataGridView1.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.MinimumSize = new Size(dataGridView1.Width, dataGridView1.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (UserInfo.login.Trim() == "UserWoman")
            {
                try
                {//создаем соединение
                    using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                    {//запуск соединения
                        DBConnection.connection.Open(); //открываем
                        DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetListWomanMonth, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                        DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                        dataGridView1.DataSource = ds; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                        //меняем размер формы под размер таблицы
                        int width = dataGridView1.Width - dataGridView1.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dataGridView1.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.MinimumSize = new Size(dataGridView1.Width, dataGridView1.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            else
            {
                dataGridView1.Visible = false;
                pNewUsre.Visible = true;
                labNewUsre.Text = $"Добрый день, вы вошли в систему под логином: {UserInfo.login}!\nВаша регистрация прошла успешно.\nК сожаелению, вы ещё не оставить заявку на разработку индивидуального меню для вас.\nМы с радостью подготовим для вас рацион, чтобы вы могли воспользоваться всеми функциями нашего приложения!\nДля этого вам необходимо связаться с нами или сделать запрос Администратору.\nОднако, вы уже можите составить свой список продуктов в форме ниже.";
            }
        }


        private void btSave_Click(object sender, EventArgs e) //тут обрабатываем работу на нажатие "Сохранить" 
        {

            if (richTextBox1 == null || richTextBox1.Text == null || richTextBox1.Text == "" || richTextBox1.Text == String.Empty)
            {
                GVinRB();
                saveFile();
                
            }
            else if (richTextBox1 != null || richTextBox1.Text != null || richTextBox1.Text != "" || richTextBox1.Text != String.Empty)
            {
                saveFile();
            }
            else
            {
                MessageBox.Show("Saving error");
            }


            }

        private void btnChange_Click(object sender, EventArgs e) //тут обрабатываем работу на нажатие "Изменить"
        {
            dataGridView1.Visible = false;
            richTextBox1.ReadOnly = false;

            GVinRB();

            rbToday.Visible = false;
            rbWeek.Visible = false;
            rbMonth.Visible = false;
        }

        
        
        private void bCancel_Click(object sender, EventArgs e) //тут обрабатываем работу на нажатие "Закрыть"
        {
            this.Close();
        }



        //привязка элемента на уровне класса для загрузки меню
        DataTable ds = new DataTable(); //набор данных

        //вывод таблиц в зависимости от пользователя и периода
        private void frmList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "allUsersLists.sp_GetAllUsersLists". При необходимости она может быть перемещена или удалена.
            //this.sp_GetAllUsersListsTableAdapter.Fill(this.allUsersLists.sp_GetAllUsersLists);

            if (rbWeek.Checked == true)
            {
                dataGridView1.Refresh();
                dataGridView1.DataSource = null;
                ds.Rows.Clear();
                choiceWeek();


            }
            else if (rbMonth.Checked == true)
            {
                dataGridView1.Refresh();
                dataGridView1.DataSource = null;
                ds.Rows.Clear();
                choiceMonth();
            }
        }

           

        private void button4_Click(object sender, EventArgs e) //запрос адмиристратору
        {
            frmRequest frmRequest = new frmRequest();
            frmRequest.ShowDialog();
        }


        //расчет начала недели
        public static DateTime GetBeginDateOfWeek(int weekNumber)
        {
            DateTime firstDay = new DateTime(DateTime.Now.Year, 1, 1); //1 января сего года
            while (firstDay.DayOfWeek != DayOfWeek.Monday) firstDay = firstDay.AddDays(-1); //ближайший предыдущий понедельник
            return firstDay.AddDays(7 * weekNumber); //добавляем количество недель * 7 дней
        }

        private void WeekTimer_Tick(object sender, EventArgs e)//таймер, который начинает работать при запуске формы и расчитывает даты 
        {

            //расчет номера текущей недели
            var dt = new DateTime(DateTime.Now.Year, 8, 22);
            var cal = new GregorianCalendar();
            var weekNumber = cal.GetWeekOfYear(dt, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);

            //вывод на неделю
            if (rbWeek.Checked == true) 
            {
                //dataGridView1.CurrentCell = null;

                #region тут производится вывод в label дат
                rbToday.Checked = false;
                rbMonth.Checked = false;

                label2.Visible = true;
                label4.Visible = true;

                label1.Text = GetBeginDateOfWeek(weekNumber).ToShortDateString();//вывод пн
                label2.Text = GetBeginDateOfWeek(weekNumber).AddDays(6).ToShortDateString();//вывод вс
                #endregion


            }

            #region это возможная модификация на вывод списка для одного дня
            /*  
            else if (rbToday.Checked == true)
            {
                // тут производится вывод в label дат
                rbWeek.Checked = false;
                rbMonth.Checked = false;

                label1.Text = DateTime.Now.ToShortDateString();
                label2.Visible = false;
                label4.Visible = false;

                int dayOfWeek = (int)DateTime.Now.DayOfWeek;
                // проверка, что в переменной 
                //label4.Text = $" {dayOfWeek}";


                

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    int temp = (int)dataGridView1[8, i].Value;
                    dataGridView1.Rows[i].Visible = temp == dayOfWeek;
                }
            }*/
                #endregion

            else if (rbMonth.Checked == true)
            {


                #region тут производится вывод в label дат на месяц
                rbToday.Checked = false;
                rbWeek.Checked = false;

                label2.Visible = true;
                label4.Visible = true;

                DateTime date = DateTime.Now;
                int Month = date.Month;
                int Year = date.Year;
                int allDayMonth = DateTime.DaysInMonth(Year, Month);
                DateTime Begin = new DateTime(Year, Month, 1);
                DateTime End = new DateTime(Year, Month, allDayMonth);

                label1.Text = Begin.ToShortDateString();//вывод начала месяца
                label2.Text = End.ToShortDateString();//вывод конца месяца
                #endregion


                

            }

            else
            {
                rbToday.Checked = false;
                rbWeek.Checked = true;
                rbMonth.Checked = false;

                label2.Visible = true;
                label4.Visible = true;
            }

        }

        private void rbWeek_CheckedChanged(object sender, EventArgs e) // тут описывается логика заполнения dataGridView1 при изменении периода с месяца на неделю
        {
            dataGridView1.Refresh();
            dataGridView1.DataSource = null;
            ds.Rows.Clear();
            choiceWeek();
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)// тут описывается логика заполнения dataGridView1 при изменении периода с недели на месяц
        {
            dataGridView1.Refresh();
            dataGridView1.DataSource = null;
            ds.Rows.Clear();
            choiceMonth();
        }
    }
}

