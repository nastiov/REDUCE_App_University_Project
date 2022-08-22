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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lSingUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//в этом методе реализация открытия формы для нового пользователя
            frmSingUp frmSingUp = new frmSingUp();//новый экземпляр
            frmSingUp.ShowDialog(); //открываем модальное окно
        }

        private void bCancel_Click(object sender, EventArgs e)
        {//метод закрытия приложения из формы регистрации
            this.Close();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {//метод входа и проверки авторизации
            if (isValid())
            {
                try
                {
                    if (DBConnection.LoginUser(tbLogin.Text.Trim(),
                        tbPassword.Text.Trim()))
                    {//если пользователь залогинился, то закрываем форму
                        Program.openMainForm = true;
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //доп метод проверки "правильно ли мы пишим логин/пароль"
        private bool isValid()
        {
            bool temp = true;

            if (String.IsNullOrEmpty(tbLogin.Text.Trim()))
            {
                epLoginDialog.SetError(tbLogin, "Проверьте введенный логин");
                temp = false;
            }
            else
                epLoginDialog.Clear();

            if (String.IsNullOrEmpty(tbPassword.Text.Trim()))
            { 
                epLoginDialog.SetError(tbPassword, "Проверьте введенный пароль");
                temp = false;
            }
            else
                epPasswordDialog.Clear();

            //изменить вывод ошибок при отсутвии данных на ввод
            return temp;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {//скрыть и показать симвалы при вводе пароля
            tbPassword.PasswordChar = cbShowPassword.Checked ? '*' : '\0';
        }

        frmInfo frmInfo;
        public void linfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // открытие окна с инфо
            frmInfo = new frmInfo();
            frmInfo.btnAdmin.Enabled = false;
            frmInfo.btnAdmin.Text = "Пройдите авторизацию";
            frmInfo.ShowDialog();
        }
    }
}
