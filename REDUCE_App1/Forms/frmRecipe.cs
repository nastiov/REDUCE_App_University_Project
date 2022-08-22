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
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        
        //привязка элемента на уровне класса для загрузки меню
        DataSet ds = new DataSet(); //набор данных



        private void btnToMenu_Click(object sender, EventArgs e)
        {//вернуться в меню - открывается меню не в модальном режиме, есть возможность работы в двух окнах
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }


        private void frmRecipe_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "allUsersDishes.sp_GetAllUsersDishes". При необходимости она может быть перемещена или удалена.
            //this.sp_GetAllUsersDishesTableAdapter.Fill(this.allUsersDishes.sp_GetAllUsersDishes);

            if (UserInfo.login.Trim() == "UserCouple")
                try
                {//создаем соединение
                    using (DBConnection.connection = new System.Data.SqlClient.SqlConnection(DBConnection.connectionString)) //у нас есть класс DBConnection, обращаемся к connection и создаем новое соединение через SqlConnection, передаем в него connectionString со строкой соединения к базе данных
                    {//запуск соединения
                        DBConnection.connection.Open(); //открываем
                        DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetDishCouple, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                        DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                        dgwRecipe.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                        //меняем размер формы под размер таблицы
                        int width = dgwRecipe.Width - dgwRecipe.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dgwRecipe.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.Width = width + 80; //размер общей формы плюс отступы
                        this.MinimumSize = new Size(this.Width, this.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                        this.MaximumSize = new Size(1000, 700);
                        dgwRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top; //так же делаем привязку ко всем сторонам формы окна

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
                        DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetDishMan, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                        DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                        dgwRecipe.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                        //меняем размер формы под размер таблицы
                        int width = dgwRecipe.Width - dgwRecipe.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dgwRecipe.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.Width = width + 80; //размер общей формы плюс отступы
                        this.MinimumSize = new Size(this.Width, this.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                        this.MaximumSize = new Size(1000, 700);
                        dgwRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top; //так же делаем привязку ко всем сторонам формы окна

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
                        DBConnection.adapter = new System.Data.SqlClient.SqlDataAdapter(DBConnection.spGetDishWoman, DBConnection.connection); //теперь нам нужен адаптер для более сложной "логики работы", для этого в SqlDataAdapter передаем запрос хранимой процедуры и соединение через connectionString со строкой соединения к базе данных
                        DBConnection.adapter.Fill(ds); //теперь нам необходим связываем адаптер и заполняем данные из адаптера в DataSet, а именно в переменную ds
                        dgwRecipe.DataSource = ds.Tables[0]; //через свойство DataSource(источник данных) привязываем к отображению в форме dgvUserData таблицу

                        //меняем размер формы под размер таблицы
                        int width = dgwRecipe.Width - dgwRecipe.Width; //создаем переменную, в нее помещаем текущую ширину, отнимаем ширину формы

                        foreach (DataGridViewColumn column in dgwRecipe.Columns) //делаем перебор для каждого столбца таблицы в нашей формы
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //настраиваем автоподбор размера колонок(под размер текста)
                            width += column.Width; //в размер будущей формы добавляем размер столбца
                        }
                        this.Width = width + 80; //размер общей формы плюс отступы
                        this.MinimumSize = new Size(this.Width, this.Height); //запрещаем изменять размер формы, а минимальным задаем расчитаный ранее
                        this.MaximumSize = new Size(1000, 700);
                        dgwRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top; //так же делаем привязку ко всем сторонам формы окна

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            else
            {
                dgwRecipe.Visible = false;
                pNewUsre.Visible = true;
                labNewUsre.Text = $"Добрый день, вы вошли в систему под логином: {UserInfo.login} \n Ваша регистрация прошла успешно.\nК сожаелению, вы ещё не оставить заявку на разработку \n индивидуального меню для вас.\nМы с радостью подготовим для вас рацион, \n чтобы вы могли воспользоваться всеми функциями нашего приложения!\nДля этого вам необходимо связаться \n с нами или сделать запрос Администратору.";
            }



        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DBConnection.connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRequest frmRequest = new frmRequest();
            frmRequest.ShowDialog();
        }
    }
}
