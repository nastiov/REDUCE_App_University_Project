using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REDUCE_App1
{
    public partial class frmRequest : Form
    {
        public frmRequest()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet(); //набор данных
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRequest_Load(object sender, EventArgs e)
        {
            //автоматическое добавление
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_REDUCE_request.sp_Request". При необходимости она может быть перемещена или удалена.
            // this.sp_RequestTableAdapter.Fill(this.dB_REDUCE_request.sp_Request);

            //подключаемся к базе данных и выводим данные "вручную" - "Работа с данными пользователя"
            try
            {//создаем соединение
                using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                {//запуск соединения
                    DBConnection.connection.Open(); //открываем
                    DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spRequest, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                    DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                    dgvRequest.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                    //dgvRequest.Columns["ID_request"].HeaderText = "№ запроса"; //ищем в таблице столбец и меняем текст
                    //dgvRequest.Columns["Request"].HeaderText = "Тип запроса";
                   // dgvRequest.Columns["FIO"].HeaderText = "Ваше ФИО";
                   // dgvRequest.Columns["Text"].HeaderText = "Текст запроса"; 

                    //меняем размер формы под размер таблицы
                    int width = this.Width - dgvRequest.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                    foreach (DataGridViewColumn column in dgvRequest.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                        width += column.Width; //в размер будущей формы добавляем размер столбца

                    }

                    this.Width = width + 80; //размер общей формы плюс отступы
                    this.MinimumSize = new Size(this.Width, this.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее

                    dgvRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top; //так же делаем привязку ко всем сторонам формы окна


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            //добавление данных 
            DataRow row = ds.Tables[0].NewRow();
            ds.Tables[0].Rows.Add(row);
        }

        private void bFind_Click(object sender, EventArgs e)
        {
            // поиск по нажатию на кнопку из DataSet
            //ищет по всем строкам в базеи проверять есть ли совпадение со строками + выделение строк
            foreach (DataGridViewRow row in dgvRequest.Rows)
            {
                row.Selected = false;
                foreach (DataGridViewCell cell in row.Cells)
                    if (cell.Value != null && cell.Value.ToString().Contains(tbSearchValue.Text))
                    {
                        row.Selected = true;
                    }
            }
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
                        new System.Data.SqlClient.SqlDataAdapter(DBConnection.spRequest, DBConnection.connection);
                    DBConnection.commandBuilder =
                        new System.Data.SqlClient.SqlCommandBuilder(DBConnection.adapter);

                    //команды запускающие измение в база денных и их правила
                    
                    //ввод
                    DBConnection.adapter.InsertCommand =
                        new System.Data.SqlClient.SqlCommand(DBConnection.spInsertRequest, DBConnection.connection);
                    DBConnection.adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    DBConnection.adapter.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@idrequest", SqlDbType.Int, 0, "ID_request"));
                    DBConnection.adapter.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Request", SqlDbType.VarChar, 20, "Request"));
                    DBConnection.adapter.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@fio", SqlDbType.VarChar, 50, "FIO_request"));
                    DBConnection.adapter.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@text", SqlDbType.VarChar, 300, "Text"));


                    //обновление
                    DBConnection.adapter.UpdateCommand =
                        new System.Data.SqlClient.SqlCommand(DBConnection.spUpdateRequest, DBConnection.connection);
                    DBConnection.adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

                    DBConnection.adapter.Update(ds);

                    ds.Clear();
                    DBConnection.adapter.Fill(ds);
                    dgvRequest.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DBConnection.adapter.Update(ds);
        }
    }
}

