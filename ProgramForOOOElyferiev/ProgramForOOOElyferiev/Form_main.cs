using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForOOOElyferiev
{
    public partial class Main_program : Form
    {


        SqlConnection sqlconnection;
        string[] mass;

        public Main_program()
        {
            InitializeComponent();
            mass = new string[5];
            text_log_operation_name.Text += Environment.NewLine;
            text_log_operation_time.Text += Environment.NewLine;
            text_log_product_name.Text += Environment.NewLine;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            if (sqlconnection != null && sqlconnection.State != ConnectionState.Closed)
                sqlconnection.Close();
            Application.Exit();
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработана Лаутеншлегером Даниилом для организации \"ООО Елуферьев\".\n ", "Информация о программе");
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {           
            Refresh_table_base();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlconnection != null && sqlconnection.State != ConnectionState.Closed)
                sqlconnection.Close();
        }

        private void Refresh_table_Click(object sender, EventArgs e)
        {
            Refresh_table_base();
        }
        private async void Refresh_table_base()
        {
            dataGridView.Rows.Clear();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects from Visual Stuido\ProgramForOOOElyferiev\ProgramForOOOElyferiev\Database.mdf;Integrated Security=True";
            sqlconnection = new SqlConnection(connectionString);
            await sqlconnection.OpenAsync();
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Products]", sqlconnection);
            try
            {
                reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    mass[0] = reader["Id"].ToString();
                    mass[1] = reader["name"].ToString();
                    mass[2] = reader["price"].ToString();
                    mass[3] = reader["country"].ToString();
                    mass[4] = reader["count"].ToString();
                    dataGridView.Rows.Add(mass);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private async void Button_add_Click(object sender, EventArgs e)
        {
            if (text_add_name.Text == "" || text_add_price.Text == "" || text_add_country.Text == "" || text_add_count.Text == "")
            {
                MessageBox.Show("Неверно введены данные!\nПопробуйте снова!" , "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            SqlCommand command = new SqlCommand("INSERT INTO [Products] (Name, Price, Country, Count)VALUES(@Name,@Price,@Country,@Count)",sqlconnection);
            command.Parameters.AddWithValue("Name",text_add_name.Text);
            command.Parameters.AddWithValue("Price", text_add_price.Text);
            command.Parameters.AddWithValue("Country", text_add_country.Text);
            command.Parameters.AddWithValue("Count", text_add_count.Text);
            await command.ExecuteNonQueryAsync();
            text_log_operation_name.Text += Environment.NewLine + "Добавление продукции";
            text_log_operation_time.Text += Environment.NewLine + string.Format("{0}", DateTime.Now.ToString());
            text_log_product_name.Text += Environment.NewLine + text_add_name.Text;
            text_add_count.Text = "";
            text_add_name.Text = "";
            text_add_price.Text = "";
            text_add_country.Text = "";
        }

        private async void Button_refresh_Click(object sender, EventArgs e)
        {
            if (text_refresh_id.Text == "" || text_refresh_price.Text == "" ||  text_refresh_count.Text == "")
            {
                MessageBox.Show("Неверно введены данные!\nПопробуйте снова!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlCommand command = new SqlCommand("UPDATE [Products] SET [Name]=@Name, [Price]=@Price, [Count]=@Count WHERE [Id]=@id",sqlconnection);
            command.Parameters.AddWithValue("id", text_refresh_id.Text);
            command.Parameters.AddWithValue("Count", text_refresh_count.Text);
            command.Parameters.AddWithValue("Price", text_refresh_price.Text);
            command.Parameters.AddWithValue("Name", text_refresh_name.Text);
            await command.ExecuteNonQueryAsync();
            text_log_operation_name.Text += Environment.NewLine + "Обновление продукции";
            text_log_operation_time.Text += Environment.NewLine +  string.Format("{0}", DateTime.Now.ToString());
            text_log_product_name.Text += Environment.NewLine + text_refresh_name.Text;
            text_refresh_count.Text = "";
            text_refresh_id.Text = "";
            text_refresh_name.Text = "";
            text_refresh_price.Text = "";
        }

        private async void Button_remove_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            if (text_remove_name.Text == "" && text_remove_id.Text == "")
            {
                MessageBox.Show("Неверно введены данные!\nПопробуйте снова!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (text_remove_id.Text != "" && text_remove_name.Text == "")
            {
                command = new SqlCommand("DELETE FROM [Products] WHERE  [Id]=@Id", sqlconnection);
                command.Parameters.AddWithValue("Id", text_remove_id.Text);
            }
            else if (text_remove_id.Text == "" && text_remove_name.Text != "")
            {
                command = new SqlCommand("DELETE FROM [Products] WHERE  [Name]=@Name", sqlconnection);
                command.Parameters.AddWithValue("Name", text_remove_name.Text);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите один из параметров","Ошибка при удалении",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            await command.ExecuteNonQueryAsync();
            text_log_operation_name.Text += Environment.NewLine + "Удаление продукции";
            text_log_operation_time.Text += Environment.NewLine + string.Format("{0}", DateTime.Now.ToString());
            if (text_remove_id.Text != "" && text_remove_name.Text == "")
            {
                text_log_product_name.Text += Environment.NewLine + "Удаление продукции по ID" + text_remove_id.Text;
            }
            else
            {
                text_log_product_name.Text += Environment.NewLine + text_remove_name.Text;
            } 
            text_remove_id.Text = "";
            text_remove_name.Text = "";
        }

        private async void Button_check_result_Click(object sender, EventArgs e)
        {
            text_result.Text = "Наименование продукции" + Environment.NewLine + Environment.NewLine;
            text_result_count.Text = "Количество" + Environment.NewLine + Environment.NewLine;
            int count;
            string product_name;
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Products]",sqlconnection);
            try
            {
                reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    if (reader["name"].ToString() == "Картофель")
                    {
                        if (Convert.ToInt32(reader["count"]) < 100)
                        {
                            count = 100 - Convert.ToInt32(reader["count"]);
                            product_name = reader["name"].ToString();
                            text_result.Text += product_name + Environment.NewLine;
                            text_result_count.Text += count.ToString() + Environment.NewLine;
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(reader["count"]) < 30)
                        {
                            product_name = reader["name"].ToString();
                            count = 30 - Convert.ToInt32(reader["count"]);
                            text_result.Text += product_name + Environment.NewLine;
                            text_result_count.Text += count.ToString() + Environment.NewLine;
                        }
                    }
                }
                text_log_operation_name.Text += Environment.NewLine + "Запрос проверки на заказ продукции";
                text_log_operation_time.Text += Environment.NewLine + string.Format("{0}", DateTime.Now.ToString());
                text_log_product_name.Text += Environment.NewLine + "-";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void LinkLabel_site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fruktovikov.ru/");
        }

        private void ChooseBase_Click(object sender, EventArgs e)
        {
            string file_path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Базы данных формата MDF(*.mdf)|*.mdf";
            if (file.ShowDialog() == DialogResult.OK)
            {
                file_path = file.FileName;
                sqlconnection.Close();
                string connecting  = file_path;
                sqlconnection = new SqlConnection(connecting);
            }
            else
            {
                return;
            }
;        }

    }
}
