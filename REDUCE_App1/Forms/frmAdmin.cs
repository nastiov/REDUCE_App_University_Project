using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace REDUCE_App1
{
    public partial class frmAdmin : Form
    {
        //привязка двух элементов на уровне класса
        DataSet ds = new DataSet(); //набор данных
        //DataTable dt;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_REDUCE_Prod.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.dB_REDUCE_Prod.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_REDUCE_AllUsersDishes.sp_GetAllUsersDishes". При необходимости она может быть перемещена или удалена.
            this.sp_GetAllUsersDishesTableAdapter.Fill(this.dB_REDUCE_AllUsersDishes.sp_GetAllUsersDishes);
            //это подключение базы данных через хранимую процедуру "Просмотр всех пользователей"
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_REDUCE_GetAllUsersData.sp_GetAllUsersData". При необходимости она может быть перемещена или удалена.
            this.sp_GetAllUsersDataTableAdapter.Fill(this.dB_REDUCE_GetAllUsersData.sp_GetAllUsersData);

            //подключаемся к базе данных и выводим данные "вручную" - "Работа с данными пользователя"
            try
            {//создаем соединение
                using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                {//запуск соединения
                    DBConnection.connection.Open(); //открываем
                    DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spAllGetUserData, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                    DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                    dgvUserData.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                    dgvUserData.Columns["ID"].ReadOnly = true; //ищем в таблице столбец и названием "ID" и делаем функцию ReadOnly, чтобы не было возможность изменять значения
                    dgvUserData.Columns["ID"].HeaderText = "Инд.номер"; //ищем в таблице столбец и названием "ID" и меняем текст

                    //меняем размер формы под размер таблицы
                    int width = this.Width - dgvUserData.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                    foreach (DataGridViewColumn column in dgvUserData.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                        width += column.Width; //в размер будущей формы добавляем размер столбца

                    }

                    this.Width = width + 80; //размер общей формы плюс отступы
                    this.MinimumSize = new Size(this.Width, this.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее

                    dgvUserData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top; //так же делаем привязку ко всем сторонам формы окна

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //подключаемся к базе данных и выводим данные "вручную" - "Работа с меню"
            try
            {//создаем соединение
                using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                {//запуск соединения
                    DBConnection.connection.Open(); //открываем
                    DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetAllUsersMenus, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                    DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                    dgvAllMenu.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                    dgvAllMenu.Columns["FIO"].HeaderText = "Имя пользователя"; //ищем в таблице столбец и меняем текст
                    dgvAllMenu.Columns["MealOfDay"].HeaderText = "Прием пищи"; //ищем в таблице столбец и меняем текст
                    dgvAllMenu.Columns["DishName"].HeaderText = "Название блюда"; //ищем в таблице столбец и меняем текст
                    dgvAllMenu.Columns["WeightDish"].HeaderText = "Кол-во блюда"; //ищем в таблице столбец и меняем текст

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //подключаемся к базе данных и выводим данные "вручную" - "Работа с блюдами"
            try
            {//создаем соединение
                using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                {//запуск соединения
                    DBConnection.connection.Open(); //открываем
                    DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetAllUsersDishes, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                    DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                    dgvAllDishes.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

        }

        

        private void bAdd_Click(object sender, EventArgs e)
        {//добавление данных 
            DataRow row = ds.Tables[0].NewRow();
            ds.Tables[0].Rows.Add(row);
        }

        private void bDelete_Click(object sender, EventArgs e)
        {//удаление данных
            DialogResult dialogResult = 
                MessageBox.Show("Удалить?", "Delete", //окно будет называться Delete и текст Удалить?
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, //высветятся кнопки ок/отмена и иконка внимание
                MessageBoxDefaultButton.Button2);//в "дефолте" будет нажата отмена

            //проверка
            if(dialogResult == DialogResult.OK)
                foreach(DataGridViewRow row in dgvUserData.SelectedRows)
                    dgvUserData.Rows.Remove(row);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBConnection.connection =
                    new System.Data.SqlClient.SqlConnection(DBConnection.connectionString))
                {
                    DBConnection.connection.Open();
                    DBConnection.adapter =
                        new System.Data.SqlClient.SqlDataAdapter(DBConnection.spAllGetUserData, DBConnection.connection);
                    DBConnection.commandBuilder = 
                        new System.Data.SqlClient.SqlCommandBuilder(DBConnection.adapter);
                    
                    //команды запускающие измение в база денных и их правила
                    //удаление
                    DBConnection.adapter.DeleteCommand = 
                        new System.Data.SqlClient.SqlCommand(DBConnection.spDeleteUser, DBConnection.connection);
                    DBConnection.adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
                    DBConnection.adapter.DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@userid", SqlDbType.Int, 0, "ID"));

                    //ввод
                    DBConnection.adapter.InsertCommand =
                        new System.Data.SqlClient.SqlCommand(DBConnection.spInsertUserData, DBConnection.connection);
                    DBConnection.adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    DBConnection.adapter.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@login", SqlDbType.VarChar, 20, "Login"));
                    DBConnection.adapter.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@password", SqlDbType.VarChar, 30, "Password"));
                    DBConnection.adapter.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@fio", SqlDbType.VarChar, 30, "FIO"));
                    DBConnection.adapter.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@birthdate", SqlDbType.Date, 0, "BirthDate"));
                    DBConnection.adapter.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sex", SqlDbType.VarChar, 20, "Email"));
                    DBConnection.adapter.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@role", SqlDbType.VarChar, 10, "RoleName"));

                    //обновление
                    DBConnection.adapter.UpdateCommand =
                        new System.Data.SqlClient.SqlCommand(DBConnection.spUpdateUserData, DBConnection.connection);
                    DBConnection.adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
                    DBConnection.adapter.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@userid", SqlDbType.Int, 0, "ID"));
                    DBConnection.adapter.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@login", SqlDbType.VarChar, 20, "Login"));
                    DBConnection.adapter.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@password", SqlDbType.VarChar, 30, "Password"));
                    DBConnection.adapter.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@fio", SqlDbType.VarChar, 30, "FIO"));
                    DBConnection.adapter.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@birthdate", SqlDbType.Date, 0, "BirthDate"));
                    DBConnection.adapter.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sex", SqlDbType.VarChar, 20, "Email"));
                    DBConnection.adapter.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@role", SqlDbType.VarChar, 10, "RoleName"));

                    DBConnection.adapter.Update(ds);

                    ds.Clear();
                    DBConnection.adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DBConnection.adapter.Update(ds);
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {//возвращаемся к окну авторизации
            UserInfo.ClearDate();
            Application.Restart();
        }

        private void bFind_Click_1(object sender, EventArgs e)
        {
            // поиск по нажатию на кнопку из DataSet
            //ищет по всем строкам в базеи проверять есть ли совпадение со строками + выделение строк
            foreach (DataGridViewRow row in dgvUserData.Rows)
            {
                row.Selected = false;
                foreach (DataGridViewCell cell in row.Cells)
                    if (cell.Value != null && cell.Value.ToString().Contains(tbSearchValue.Text))
                    {
                        row.Selected = true;
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRequest frmRequest = new frmRequest();
            frmRequest.ShowDialog();
        }





        /* поиск по изменению текста в строке поиска
        private void tbSearchValue_TextChanged(object sender, EventArgs e)
        {
            (dgvUserData.DataSource as DataTable).DefaultView.RowFilter =
                $"login Like '%{tbSearchValue.Text}%'";

            (dgvUserData.DataSource as DataTable).DefaultView.RowFilter =
                $"pass Like '%{tbSearchValue.Text}%'";
        }*/
    }
}
