using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KursFirst
{
    public partial class Student : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuho\Documents\Visual Studio 2015\Projects\KursFirst\FirstKurs.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;

        public Student()
        {
            InitializeComponent();
        }

        //Проверка на пустые поля
        private bool Button_Press_Enter()
        {
            if (string.IsNullOrEmpty(textBox1.Text.ToString()))
            {
                MessageBox.Show("Вы не ввели код зачетки студента.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Вы не ввели ФИО студента.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Вы не ввели код образовательного уч.", "Ошибка.");
                return false;
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Вы не ввели код формы обучения.", "Ошибка.");
                return false;
            }

            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Вы не ввели код факультета.", "Ошибка.");
                return false;
            }

            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Вы не ввели код специальности.", "Ошибка.");
                return false;
            }
            return true;
        }

        private bool Button_Press_Delete()
        {
            if (string.IsNullOrEmpty(textBox7.Text.ToString()))
            {
                MessageBox.Show("Вы не ввели код зачетки студента для удаления.", "Ошибка.");
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
            tt.Show("Вводить только цифры.", TB, 0, -22, VisibleTime);
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

        private void textBox6_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Вводить только цифры.", TB, 0, -22, VisibleTime);
        }

        private void textBox7_Enter(object sender, EventArgs e)
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
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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
                    int KodStudentRecordBook = int.Parse(this.textBox1.Text);
                    string FIO = Convert.ToString(this.textBox2.Text);
                    int KodEducationalInstitut = int.Parse(this.textBox3.Text);
                    int FormObuch = int.Parse(this.textBox4.Text);
                    int Facultet = int.Parse(this.textBox5.Text);
                    int Speciality = int.Parse(this.textBox6.Text);


                    conn = new SqlConnection();
                    conn.ConnectionString = connectionString;
                    conn.Open();

                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = "INSERT INTO " + " Student (KodStudentRecordBook, FIO, KodEducationalInstitut, FormObuch, Facultet, Speciality)" +
                        "VALUES (@KodStudentRecordBook, @FIO, @KodEducationalInstitut, @FormObuch, @Facultet, @Speciality)";

                    myCommand.Parameters.Add("@KodStudentRecordBook", SqlDbType.Int, 4);
                    myCommand.Parameters["@KodStudentRecordBook"].Value = KodStudentRecordBook;

                    myCommand.Parameters.Add("@FIO", SqlDbType.NVarChar, 30);
                    myCommand.Parameters["@FIO"].Value = FIO;

                    myCommand.Parameters.Add("@KodEducationalInstitut", SqlDbType.Int, 4);
                    myCommand.Parameters["@KodEducationalInstitut"].Value = KodEducationalInstitut;

                    myCommand.Parameters.Add("@FormObuch", SqlDbType.Int, 4);
                    myCommand.Parameters["@FormObuch"].Value = FormObuch;

                    myCommand.Parameters.Add("@Facultet", SqlDbType.Int, 4);
                    myCommand.Parameters["@Facultet"].Value = Facultet;

                    myCommand.Parameters.Add("@Speciality", SqlDbType.Int, 4);
                    myCommand.Parameters["@Speciality"].Value = Speciality;

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
            if (Button_Press_Delete() == true)
            {
                try
                {
                    int KodStudentRecordBook = int.Parse(this.textBox7.Text);

                    conn = new SqlConnection();
                    conn.ConnectionString = connectionString;
                    conn.Open();

                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = "DELETE FROM Student WHERE KodStudentRecordBook = @KodStudentRecordBook";

                    myCommand.Parameters.Add("@KodStudentRecordBook", SqlDbType.Int, 4);
                    myCommand.Parameters["@KodStudentRecordBook"].Value = KodStudentRecordBook;

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
