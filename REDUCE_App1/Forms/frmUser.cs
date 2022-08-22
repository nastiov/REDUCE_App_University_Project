using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//библиотека для команд M SQL


namespace REDUCE_App1
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }



        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {//польностью закрываем приложение
            Application.Exit();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {//возвращаемся к окну авторизации
            UserInfo.ClearDate();
            Application.Restart();
        }

        private void linfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {// открытие окна с инфо
            frmInfo frmInfo = new frmInfo();
            frmInfo.ShowDialog();
        }

        private void btnToMenu_Click(object sender, EventArgs e)
        {//просмотр меню - открывается меню в модальном режиме, нет возможности работать в двух окнах
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {//просмотр рецептов - открываются рецепты в модальном режиме, нет возможности работать в двух окнах
            frmRecipe frmRecipe = new frmRecipe();
            frmRecipe.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {//просмотр списка покупок - открывается список в модальном режиме, нет возможности работать в двух окнах
            frmList frmList = new frmList();
            frmList.ShowDialog();
        }



        private void Timer_Tick(object sender, EventArgs e)
        {//таймер, который запускается при начале работы приложения и отражает в нижней части время и дату в StatusTime
            StatusTime.Text = $"Текущее время: \n {DateTime.Now.ToLongTimeString()}"; //привязка времени и даты к StatusTime

        }

       
        

        //привязка элемента на уровне класса для загрузки меню
        DataSet ds = new DataSet(); //набор данных
        private void frmUser_Load(object sender, EventArgs e)
        {
            if (UserInfo.login.Trim() == "UserCouple")
                try
                {//создаем соединение
                    using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                    {//запуск соединения
                        DBConnection.connection.Open(); //открываем
                        DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetMenuCouple, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                        DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                        dgvUser.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                        dgvUser.Columns["FIO"].ReadOnly = true; //ищем в таблице столбец и названием "FIO" и делаем функцию ReadOnly, чтобы не было возможность изменять значения
                        dgvUser.Columns["FIO"].HeaderText = "Ваше имя"; //ищем в таблице столбец и названием "FIO" и меняем текст

                        dgvUser.Columns["MealOfDay"].ReadOnly = true;
                        dgvUser.Columns["MealOfDay"].HeaderText = "Прием пищи";

                        dgvUser.Columns["DishName"].ReadOnly = true;
                        dgvUser.Columns["DishName"].HeaderText = "Блюдо";

                        dgvUser.Columns["WeightDish"].ReadOnly = true;
                        dgvUser.Columns["WeightDish"].HeaderText = "Кол-во";

                        dgvUser.Columns["Unit"].ReadOnly = true;
                        dgvUser.Columns["Unit"].HeaderText = "ед.измерения";

                        //меняем размер формы под размер таблицы
                        int width = dgvUser.Width - dgvUser.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dgvUser.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.MinimumSize = new Size(dgvUser.Width, dgvUser.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            else if (UserInfo.login.Trim() == "UserMan")
                try
                {//создаем соединение
                    using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                    {//запуск соединения
                        DBConnection.connection.Open(); //открываем
                        DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetMenuMan, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                        DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                        dgvUser.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                        dgvUser.Columns["FIO"].ReadOnly = true; //ищем в таблице столбец и названием "FIO" и делаем функцию ReadOnly, чтобы не было возможность изменять значения
                        dgvUser.Columns["FIO"].HeaderText = "Ваше имя"; //ищем в таблице столбец и названием "FIO" и меняем текст

                        dgvUser.Columns["MealOfDay"].ReadOnly = true;
                        dgvUser.Columns["MealOfDay"].HeaderText = "Прием пищи";

                        dgvUser.Columns["DishName"].ReadOnly = true;
                        dgvUser.Columns["DishName"].HeaderText = "Блюдо";

                        dgvUser.Columns["WeightDish"].ReadOnly = true;
                        dgvUser.Columns["WeightDish"].HeaderText = "Кол-во";

                        dgvUser.Columns["Unit"].ReadOnly = true;
                        dgvUser.Columns["Unit"].HeaderText = "ед.измерения";


                        //меняем размер формы под размер таблицы
                        int width = dgvUser.Width - dgvUser.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dgvUser.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.MinimumSize = new Size(dgvUser.Width, dgvUser.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
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
                        dgvUser.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                        dgvUser.Columns["FIO"].ReadOnly = true; //ищем в таблице столбец и названием "FIO" и делаем функцию ReadOnly, чтобы не было возможность изменять значения
                        dgvUser.Columns["FIO"].HeaderText = "Ваше имя"; //ищем в таблице столбец и названием "FIO" и меняем текст

                        dgvUser.Columns["MealOfDay"].ReadOnly = true;
                        dgvUser.Columns["MealOfDay"].HeaderText = "Прием пищи";

                        dgvUser.Columns["DishName"].ReadOnly = true;
                        dgvUser.Columns["DishName"].HeaderText = "Блюдо";

                        dgvUser.Columns["WeightDish"].ReadOnly = true;
                        dgvUser.Columns["WeightDish"].HeaderText = "Кол-во";

                        dgvUser.Columns["Unit"].ReadOnly = true;
                        dgvUser.Columns["Unit"].HeaderText = "ед.измерения";


                        //меняем размер формы под размер таблицы
                        int width = dgvUser.Width - dgvUser.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dgvUser.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.MinimumSize = new Size(dgvUser.Width, dgvUser.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            else
            {
                dgvUser.Visible = false;
                pNewUsre.Visible = true;
                labNewUsre.Text = $"Добрый день, вы вошли в систему под логином: {UserInfo.login}!\nВаша регистрация прошла успешно.\nК сожаелению, вы ещё не оставить заявку на разработку \n индивидуального меню для вас.\nМы с радостью подготовим для вас рацион, \n чтобы вы могли воспользоваться всеми функциями нашего приложения!\nДля этого вам необходимо связаться с нами \n или сделать запрос Администратору.";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRequest frmRequest = new frmRequest();
            frmRequest.ShowDialog();
        }



        /*private void frmUser_Load_1(object sender, EventArgs e, string login)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_REDUCEUser_dishes.sp_GetAllUsersDishes". При необходимости она может быть перемещена или удалена.
            //this.sp_GetAllUsersDishesTableAdapter.Fill(this.dB_REDUCEUser_dishes.sp_GetAllUsersDishes);
                
            try
            {
                using (DBConnection.connection = new SqlConnection(DBConnection.connectionString))
                {
                    //создали соединение, теперь открываем

                    DBConnection.connection.Open();
                    DBConnection.command = new SqlCommand(DBConnection.spGetAllUsersMenus, DBConnection.connection); //на вход подаем имя команды

                    login = UserInfo.login;

                    //теперь добавляем параметры в процедуру
                    DBConnection.command.Parameters.Add(new SqlParameter("@login", login));

                    DBConnection.command.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@userID",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Direction = System.Data.ParameterDirection.Output
                    });

                    //выполнение команды
                    DBConnection.command.ExecuteNonQuery();

                    DataSet ds = new DataSet();//для хранения набора данных
                    DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetAllUsersMenus, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                    DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                    dataGridView1.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }*/
    }
}
