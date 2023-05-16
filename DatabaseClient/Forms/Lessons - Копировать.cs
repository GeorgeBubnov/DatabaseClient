using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseClient.Forms
{
    public partial class Lessons : Form
    {
        public Lessons()
        {
            InitializeComponent();
        }

		private NpgsqlConnection Connection { get; set; }

		private BindingList<Records> RecordsBindingList { get; set; }

		//Підключення до сервера PostgreSQL
		private void Open(string connectionString)
		{
			Connection = new NpgsqlConnection(connectionString);
			Connection.Open();
		}

		private class Records
		{
			public Records(string _id, string _name)
			{
				ID = _id;
				Name = _name;
			}
			public string ID { get; set; }
			public string Name { get; set; }
		}

		//Завантаження даних
		private void LoadRecords()
		{
			RecordsBindingList.Clear();

			string query = "SELECT * FROM public.tab1 ORDER BY id ASC";

			NpgsqlCommand nCommand = new NpgsqlCommand(query, Connection);

			NpgsqlDataReader reader = nCommand.ExecuteReader();

			while (reader.Read())
			{
				RecordsBindingList.Add(new Records(
					reader["id"].ToString(),
					reader["name"].ToString()
					));
			}

			reader.Close();
		}

        private void FormLessons_Load(object sender, EventArgs e)
        {
			RecordsBindingList = new BindingList<Records>();
			dataGridViewLessons.DataSource = RecordsBindingList;

			dataGridViewLessons.Columns["Name"].Width = 300;

			//Підключення до сервера PostgreSQL
			Open($"Server=localhost;User Id=postgres;Password=203302;Port=5432;Database=test;");

			//Заватаження даних з таблиці
			LoadRecords();
		}
    }
}
