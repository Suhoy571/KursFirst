using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KursFirst
{
    public partial class Speciality : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuho\Documents\Visual Studio 2015\Projects\KursFirst\FirstKurs.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;

        public Speciality()
        {
            InitializeComponent();
        }

        //Проверка на пустые поля
        private bool Button_Press_Enter()
        {
            if (string.IsNullOrEmpty(textBox1.Text.ToString()))
            {
                MessageBox.Show("Вы не ввели код специальности.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Вы не ввели название специальности.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Вы не ввели краткое название специальности.", "Ошибка.");
                return false;
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Вы не ввели код факультета.", "Ошибка.");
                return false;
            }
            return true;
        }

        private bool Button_Press_Delete()
        {
            if (string.IsNullOrEmpty(textBox5.Text.ToString()))
            {
                MessageBox.Show("Вы не ввели код специальности для удаления.", "Ошибка.");
                return false;
            }
            return true;
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Вводить только цифры.", TB, 0, -22, VisibleTime);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Вводить только буквы.", TB, 0, -22, VisibleTime);
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Вводить только буквы.", TB, 0, -22, VisibleTime);
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Вводить только цифры.", TB, 0, -22, VisibleTime);
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Вводить только цифры.", TB, 0, -22, VisibleTime);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Button_Press_Enter() == true)
            {
                try
                {
                    int Kod = int.Parse(this.textBox1.Text);
                    string Name = Convert.ToString(this.textBox2.Text);
                    string ShortName = Convert.ToString(this.textBox3.Text);
                    int KodFacult = int.Parse(this.textBox4.Text);

                    //Проверка кода факультета
                    int KodFacultetaCheck = 0;
                    using (var con = new SqlConnection(connectionString))
                    {
                        var sql = "SELECT Kod FROM Facultet";
                        using (var cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@KodFacult", textBox4.Text);
                            con.Open();
                            KodFacultetaCheck = (int)cmd.ExecuteScalar();
                            if (KodFacultetaCheck != KodFacult)
                                MessageBox.Show("Такого факультета не существует. Попробуйте еще раз.");
                        }
                        //Запрет на воод данных при отстутствии факультета
                        con.Close();
                    }

                    conn = new SqlConnection();
                    conn.ConnectionString = connectionString;
                    conn.Open();

                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = "INSERT INTO " + "Speciality (Kod, Name, ShortName, KodFacult)" +
                        "VALUES (@Kod, @Name, @ShortName, @KodFacult)";
                    myCommand.Parameters.Add("@Kod", SqlDbType.Int, 4);
                    myCommand.Parameters["@Kod"].Value = Kod;
                    myCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 30);
                    myCommand.Parameters["@Name"].Value = Name;
                    myCommand.Parameters.Add("@ShortName", SqlDbType.NVarChar, 30);
                    myCommand.Parameters["@ShortName"].Value = ShortName;
                    myCommand.Parameters.Add("@KodFacult", SqlDbType.Int, 30);
                    myCommand.Parameters["@KodFacult"].Value = KodFacult;

                    int Uspex = myCommand.ExecuteNonQuery();
                    if (Uspex != 0)
                    {
                        MessageBox.Show("Изменения внесены. ", "Изменениие записи. ");
                    }
                    else
                    {
                        MessageBox.Show("Изменения не внесены. ", "Изменениие записи. ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Button_Press_Delete() == true)
            {
                try
                {
                    int Kod = int.Parse(this.textBox5.Text);

                    conn = new SqlConnection();
                    conn.ConnectionString = connectionString;
                    conn.Open();

                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = "DELETE FROM Speciality WHERE Kod = @Kod";
                    myCommand.Parameters.Add("@Kod", SqlDbType.Int, 4);
                    myCommand.Parameters["@Kod"].Value = Kod;

                    int Uspex = myCommand.ExecuteNonQuery();
                    if (Uspex != 0)
                    {
                        MessageBox.Show("Изменения внесены. ", "Изменениие записи. ");
                    }
                    else
                    {
                        MessageBox.Show("Изменения не внеены. ", "Изменениие записи. ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
