using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _2048
{
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Port=13305;Database=2048_db;Uid=doho;Pwd=password;Charset=utf8;");
        Label[] nameArr, scoreArr;
        public Form2()
        {
            InitializeComponent();
            InitValue();
            LoadValue();
        }

        private void InitValue()
        {
            nameArr = new Label[7] { Name1, Name2, Name3, Name4, Name5, Name6, Name7 };
            scoreArr = new Label[7] { Score1, Score2, Score3, Score4, Score5, Score6, Score7 };
        }

        private void LoadValue()
        {
            string selectQuery = "SELECT nickname, score from scoreboard order by score DESC LIMIT 7";
            connection.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            MySqlDataReader table = command.ExecuteReader();

            int idx = 0;
            while (table.Read())
            {
                nameArr[idx].Text = table["nickname"].ToString();
                scoreArr[idx].Text = table["score"].ToString();
                idx++;
            }

            connection.Close();
        }
    }
}
