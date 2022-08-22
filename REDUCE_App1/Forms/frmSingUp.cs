using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;//для работы с регулярными выражениями


namespace REDUCE_App1
{
    public partial class frmSingUp : Form
    {
        public frmSingUp()
        {
            InitializeComponent();
            dtpBirthdate.CustomFormat = " ";
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSingUp_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.SingUpUser(tbLogin.Text.Trim(), tbPassword.Text.Trim(), dtpBirthdate.Value, tbFIO.Text.Trim(), cbSex.Text.Trim());
                MessageBox.Show("Регистрация прошла успешно!\n Теперь вы можите пройти авторизацию в приложении.");

                tbLogin.Text = "";
                tbPassword.Text = "";
                tbConfirmPassword.Text = "";
                tbFIO.Text = "";
                cbSex.Text = "";
                dtpBirthdate.CustomFormat = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbLogin_Validating(object sender, CancelEventArgs e)
        {//предварительная проверка введенных данных
            if (String.IsNullOrEmpty(tbLogin.Text.Trim()))
                epUserDialog.SetError(tbLogin, "Пожалуйста, введите пароль");
            else if (!Regex.IsMatch(tbLogin.Text.Trim(), "^[a-zA-Z0-9]+$"))
                epUserDialog.SetError(tbLogin, "Пароль должен иметь хотябы одну букву и цифру.");
            else
                epUserDialog.Clear();
        }

        

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {// предварительная проверка введенных данных
            if (String.IsNullOrEmpty(tbPassword.Text.Trim()))
                epUserDialog.SetError(tbPassword, "Пожалуйста, введите пароль");
            else if (!Regex.IsMatch(tbPassword.Text.Trim(), @"^(?=.*\d)(?=.*[a-zA-Z]).{8,}$"))
                epUserDialog.SetError(tbPassword, "Пароль должен иметь хотябы 8 сиволов из букв и цифр.");
            else
                epUserDialog.Clear();

        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {// предварительная проверка введенных данных
            if (String.IsNullOrEmpty(tbConfirmPassword.Text.Trim()))
                epUserDialog.SetError(tbConfirmPassword, "Пожалуйста, введите пароль");
            else if (tbPassword.Text.Trim() != tbConfirmPassword.Text.Trim())
                epUserDialog.SetError(tbConfirmPassword, "Пароль не соответсвует ранее введенному.");
            else
                epUserDialog.Clear();

        }
        
        private void tbFIO_Validating(object sender, CancelEventArgs e)
        {//предварительная проверка введенных данных
            if (String.IsNullOrEmpty(tbFIO.Text.Trim()))
                epUserDialog.SetError(tbFIO, "Пожалуйста, ФИО полностью");
            else if (!Regex.IsMatch(tbFIO.Text.Trim(), "^[a-zA-Z].{2} + $"))
                epUserDialog.SetError(tbFIO, "Имя должено иметь хотябы одну букву и цифру.");
            else
                epUserDialog.Clear();

        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            dtpBirthdate.CustomFormat = "dd.mm.yy";
        }

        private bool ValidatePassword(string password, out string ErrorMessage)
        {//Проверка пароля с помощью regex c# [дубликат]
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one lower case letter";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one upper case letter";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should not be less than or greater than 12 characters";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one numeric value";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one special case characters";
                return false;
            }
            else
            {
                return true;
            }
        }

        
    }
}
