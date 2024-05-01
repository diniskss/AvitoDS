using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using WinFormsApp1;


namespace WinFormsApp1
{
    internal class PostrgreSQL
    {
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "postgres";
        private static string Password = "root";
        private static string Port = "5432";
        public static void PostgreSQL_Connection()
        {
            string connString =
            String.Format(
                "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                Host,
                User,
                DBname,
                Port,
                Password);

            var conn = new NpgsqlConnection(connString);

            Form mainForm = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Main))
                {
                    mainForm = form;
                    break;
                }
            }

            Label myLabel = (Label)mainForm.Controls.Find("db_check", true)[0];
            myLabel.Text = "Подключил";
        }
    }
}
