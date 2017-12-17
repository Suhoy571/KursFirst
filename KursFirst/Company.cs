using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KursFirst
{
    public partial class Company : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuho\Documents\Visual Studio 2015\Projects\KursFirst\FirstKurs.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;

        public Company()
        {
            InitializeComponent();
        }

        //Проверка на пустые поля
        private bool Button_Press_Enter()
        {
            if (string.IsNullOrEmpty(textBox1.Text.ToString()))
            {
                MessageBox.Show("Вы не ввели код кампании.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Вы не ввели название кампании.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Вы не ввели краткое название кампании.", "Ошибка.");
                return false;
            }
            return true;
        }

        private bool Button_Press_Delete()
        {
            if (string.IsNullOrEmpty(textBox4.Text.ToString()))
            {
                MessageBox.Show("Вы не ввели код кампании для удаления.", "Ошибка.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Button_Press_Enter() == true)
            {
                try
                {
                    int Kod = int.Parse(this.textBox1.Text);
                    string Nazvanie = Convert.ToString(this.textBox2.Text);
                    string KratkoeNazvanie = Convert.ToString(this.textBox3.Text);

                    conn = new SqlConnection();
                    conn.ConnectionString = connectionString;
                    conn.Open();

                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = "INSERT INTO " + "Company (Kod, Name, ShortName)" +
                        "VALUES (@Kod, @Name, @ShortName)";
                    myCommand.Parameters.Add("@Kod", SqlDbType.Int, 4);
                    myCommand.Parameters["@Kod"].Value = Kod;
                    myCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 30);
                    myCommand.Parameters["@Name"].Value = Nazvanie;
                    myCommand.Parameters.Add("@ShortName", SqlDbType.NVarChar, 30);
                    myCommand.Parameters["@ShortName"].Value = KratkoeNazvanie;

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
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Button_Press_Delete() == true)
            {
                try
                {
                    int Kod = int.Parse(this.textBox4.Text);

                    conn = new SqlConnection();
                    conn.ConnectionString = connectionString;
                    conn.Open();

                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = "DELETE FROM Company WHERE Kod = @Kod";
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
                    textBox4.Clear();
                    conn.Close();
                }
            }
        }
    }
}
