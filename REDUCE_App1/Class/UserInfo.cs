using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDUCE_App1
{ //Класс, для сохранения информации о пользователе, который попытался зайти в систему
    internal class UserInfo
    {
        //
        public static string login = null; //храним логин, с которым пришел пользователь и по умолчанию вносим значение null
        public static string password = null; //храним пароль, с которым пришел пользователь и по умолчанию вносим значение null
        public static string role = null; //проверяем роль пользователя, зарегистрирован он или нет, если не зареган, то значение не возвращается


        //при возврате пользователя к окну авторизации очищаем данные предыдущего входа
        public static void ClearDate()
        {
            login = null;
            password = null;
            role = null;
           
        }
    }
}
