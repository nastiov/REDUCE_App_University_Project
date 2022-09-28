using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//библиотека для команд M SQL
using System.Data;

namespace REDUCE_App1
{//в этом классе собмраем элементы для работы с базой
    internal class DBConnection
    {
        public static SqlConnection connection = null; //это наше будущее соединение
        public static SqlCommand command = null; //тут хранится команда к базе данных и через нее будем получать ответ

        public static SqlDataAdapter adapter = null; //для работы с таблицами и "красивое" обновление, он преобразует сложные запросы
        public static SqlCommandBuilder commandBuilder = null; //он позволяет в адаптер записать обновление сложных запросов

        public static string connectionString = @"Data Source=DESKTOP-32SPV8J;Initial Catalog=DB_REDUCE;Integrated Security=True";//строка соединения 

        //сохраним имена наших хранимых процедур
        public static string spGetUserData = "sp_GetUsersData";
        public static string spAllGetUserData = "sp_GetAllUsersData";
        public static string spDeleteUser = "sp_DeleteUsers";
        public static string spInsertUserData = "sp_InsertUsersData";
        public static string spUpdateUserData = "sp_UpdatetUsersData";

        public static string spGetAllUsersLists = "sp_GetAllUsersLists";
        public static string spGetAllUsersMenus = "sp_GetAllUsersMenus";
        public static string spGetAllUsersDishes = "sp_GetAllUsersDishes";
        public static string spGetAllUsersInstruction = "sp_GetAllUsersInstruction";
        public static string spGetUsersMenu = "sp_GetUsersMenu";

        public static string spGetMenuCouple = "sp_GetMenuCouple";
        public static string spGetMenuMan = "sp_GetMenuMan";
        public static string spGetMenuWoman = "sp_GetMenuWoman";

        public static string spGetDishCouple = "sp_GetDishCouple";
        public static string spGetDishMan = "sp_GetDishMan";
        public static string spGetDishWoman = "sp_GetDishWoman";

        public static string spGetListCouple = "sp_GetListCouple";
        public static string spGetListMan = "sp_GetListMan";
        public static string spGetListWoman = "sp_GetListWoman";

        public static string spGetListCoupleMonth = "sp_GetListCouple_Month";
        public static string spGetListManMonth = "sp_GetListMan_Month";
        public static string spGetListWomanMonth = "sp_GetListWoman_Month";

        public static string spRequest = "sp_Request";
        public static string spInsertRequest = "sp_InsertRequest";
        public static string spUpdateRequest = "sp_UpdateRequest";

        //метод для проверки авторизации зарегистрированного пользователя
        public static bool LoginUser(string login, string pass)
        {
            bool res = false;

            //используем using, чтобы в конце не закрывать соединение
            using (connection = new SqlConnection(connectionString))
            {
                //создали соединение, теперь открываем

                connection.Open();
                command = new SqlCommand(spGetUserData, connection); //на вход подаем имя команды
                command.CommandType = System.Data.CommandType.StoredProcedure; //используем именно его, тк используем хранимую процедуру

                //теперь добавляем параметры в процедуру
                command.Parameters.Add(new SqlParameter("@login", login));
                command.Parameters.Add(new SqlParameter("@password", pass));

                command.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@role",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Size = 10,
                    Direction = System.Data.ParameterDirection.Output
                });
                //выполнение команды
                command.ExecuteNonQuery();
                String temp = command.Parameters["@role"].Value.ToString().Trim();

                if (String.IsNullOrEmpty(temp) || temp.Length < 2)
                    throw new Exception($"Введены неверные данные");
                else
                {
                    UserInfo.login = command.Parameters["@login"].Value.ToString().Trim(); //из SQL команды "достаем" значение
                    UserInfo.password = command.Parameters["@password"].Value.ToString().Trim();
                    UserInfo.role = temp;
                    res = true;
                }


                return res;
            }
        }


        public static void SingUpUser(string login, string pass, DateTime birthdate, string fio = null, string sex = null)
        {//используем using, чтобы в конце не закрывать соединение
            using (connection = new SqlConnection(connectionString))
            {
                //создали соединение, теперь открываем

                connection.Open();
                command = new SqlCommand(spInsertUserData, connection); //на вход подаем имя команды
                command.CommandType = System.Data.CommandType.StoredProcedure; //используем именно его, тк используем хранимую процедуру

                //теперь добавляем параметры в процедуру
                command.Parameters.Add(new SqlParameter("@login", login));
                command.Parameters.Add(new SqlParameter("@password", pass));
                command.Parameters.Add(new SqlParameter("@fio", fio));
                command.Parameters.Add(new SqlParameter("@sex", sex));
                command.Parameters.Add(new SqlParameter("@birthdate", birthdate));

                command.ExecuteNonQuery();//запускаем запрос
            }
        }
    }
}
