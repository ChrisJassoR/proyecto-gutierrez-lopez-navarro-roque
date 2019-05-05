using MVC.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace MVC
{
    public class MysqlData
    {
        public static bool TryConnection()
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=Hojas_de_Cotejo;user=Admin;password=Admin";

            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void CreatDb()
        {
            using (var context = new Hojas_de_CotejoContext())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}