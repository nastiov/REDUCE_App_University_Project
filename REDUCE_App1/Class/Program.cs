
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REDUCE_App1
{
    internal static class Program
    {
        
        //добавим поле со свойством через get/set и тут будем хранить метку: входил ли кто-то
        public static bool openMainForm { get; set; }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region начало работы приожения с авторизации
            //*
            //переменная в которой будет маркер, можем ли мы открывать какую-либо форму или нет
            openMainForm = false;//при входе пользователь должен пройти авторизацию, чтобы изменить на true
            Application.Run(new frmLogin());

                    
            if (openMainForm)
            {
                if (UserInfo.role.Trim() == "ADMIN")//прописываем роль явно, тк небольшое кол-во ролей в базе, но можно настроить выгрузку
                    Application.Run(new frmAdmin());//если роль соответсвует админу, то открываем форму админа
                else Application.Run(new frmUser());//в противном случае открываем форму пользователя
            }
            //*/
            #endregion

            #region запуск окон для теста
            //Application.Run(new frmLogin());
            //Application.Run(new frmUser());
            //Application.Run(new frmList());
            //Application.Run(new frmRecipe());
            //Application.Run(new frmMenu());
            //Application.Run(new frmAdmin());
            //Application.Run(new frmRequest());
            //Application.Run(new frmSingUp());

            #endregion
        }
    }
}
