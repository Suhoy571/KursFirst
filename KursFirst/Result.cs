using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KursFirst
{
    public partial class Result : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuho\Documents\Visual Studio 2015\Projects\KursFirst\FirstKurs.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;

        public Result()
        {
            InitializeComponent();
        }

        private bool Button_Press_Enter()
        {
            if (string.IsNullOrEmpty(textBox1.Text.ToString()))
            {
                MessageBox.Show("Вы не ввели код формы обучения.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Вы не ввели код зачетки студента.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Вы не ввели номер кампании.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Вы не ввели название кампании.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Вы не ввели ФИО руководителя от ВУЗа.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox6.Text.ToString()))
            {
                MessageBox.Show("Вы не ввели должность руководителя от ВУЗа.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox7.Text.ToString()))
            {
                MessageBox.Show("Вы не ввели ФИО руководителя от кампании.", "Ошибка.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox8.Text.ToString()))
            {
                MessageBox.Show("Вы не ввели должность руководителя от кампании.", "Ошибка.");
                return false;
            }
            return true;
        }

        private bool Button_Press_Delete()
        {
            if (string.IsNullOrEmpty(textBox10.Text.ToString()))
            {
                MessageBox.Show("Вы не ввели код студента.", "Ошибка.");
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
            tt.Show("Вводить только цифры.", TB, 0, -22, VisibleTime);
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
            tt.Show("Вводить только буквы.", TB, 0, -22, VisibleTime);
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Вводить только буквы.", TB, 0, -22, VisibleTime);
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Вводить только буквы.", TB, 0, -22, VisibleTime);
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Вводить только буквы.", TB, 0, -22, VisibleTime);
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Вводить только буквы.", TB, 0, -22, VisibleTime);
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("Вводить только цифры.", TB, 0, -22, VisibleTime);
        }

        private void textBox10_Enter(object sender, EventArgs e)
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
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
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
                    int KodStudentRecordBook = int.Parse(this.textBox2.Text);
                    int NumberCompany = int.Parse(this.textBox3.Text);
                    string NameCompany = Convert.ToString(this.textBox4.Text);
                    string FIOotVuza = Convert.ToString(this.textBox5.Text);
                    string DoljnostOtVuza = Convert.ToString(this.textBox6.Text);
                    string FIOotPrep = Convert.ToString(this.textBox7.Text);
                    string DoljnostOtPrep = Convert.ToString(this.textBox8.Text);
                    DateTime DateStart = Convert.ToDateTime(this.dateTimePicker1.Value.ToShortDateString());
                    DateTime DateEnd = Convert.ToDateTime(this.dateTimePicker2.Value.ToShortDateString());
                    int Mark = int.Parse(this.textBox9.Text);

                    //Проверка номера зачетной книжки
                    int NomerZachetnoyKinzkCheck = 0;
                    using (var con = new SqlConnection(connectionString))
                    {
                        var sql = "SELECT KodStudentRecordBook FROM Student";
                        using (var cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@FIOStudent", textBox2.Text);
                            con.Open();
                            NomerZachetnoyKinzkCheck = (int)cmd.ExecuteScalar();
                            if (NomerZachetnoyKinzkCheck != KodStudentRecordBook)
                                MessageBox.Show("Такого студента не существует. Проверьте номера зачетных книжек", "Ошибка.");
                        }
                        con.Close();
                    }

                    //Проверка предприятия
                    int AdressPredprCheck = 0;
                    using (var con = new SqlConnection(connectionString))
                    {
                        var sql = "SELECT Kod FROM Company";
                        using (var cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@AdressPredpr", textBox3.Text);
                            con.Open();
                            AdressPredprCheck = (int)cmd.ExecuteScalar();
                            if (AdressPredprCheck != NumberCompany)
                                MessageBox.Show("Такого предприятия не существует. Проверьте номер кампании.", "Ошибка.");
                        }
                        con.Close();
                    }

                    conn = new SqlConnection();
                    conn.ConnectionString = connectionString;
                    conn.Open();

                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = "INSERT INTO " + "Result (Kod, KodStudentRecordBook, NumberCompany, NameCompany, FIOotVuza, DoljnostOtVuza," +
                        "FIOotPrep, DoljnostOtPrep, DateStart, DateEnd, Mark)" +
                        "VALUES (@Kod, @KodStudentRecordBook, @NumberCompany, @NameCompany, @FIOotVuza, @DoljnostOtVuza," +
                        " @FIOotPrep, @DoljnostOtPrep, @DateStart, @DateEnd, @Mark)";

                    myCommand.Parameters.Add("@Kod", SqlDbType.Int, 4);
                    myCommand.Parameters["@Kod"].Value = Kod;

                    myCommand.Parameters.Add("@KodStudentRecordBook", SqlDbType.Int, 4);
                    myCommand.Parameters["@KodStudentRecordBook"].Value = KodStudentRecordBook;

                    myCommand.Parameters.Add("@NumberCompany", SqlDbType.Int, 4);
                    myCommand.Parameters["@NumberCompany"].Value = NumberCompany;

                    myCommand.Parameters.Add("@NameCompany", SqlDbType.Char, 30);
                    myCommand.Parameters["@NameCompany"].Value = NameCompany;

                    myCommand.Parameters.Add("@FIOotVuza", SqlDbType.Char, 30);
                    myCommand.Parameters["@FIOotVuza"].Value = FIOotVuza;

                    myCommand.Parameters.Add("@DoljnostOtVuza", SqlDbType.Char, 30);
                    myCommand.Parameters["@DoljnostOtVuza"].Value = DoljnostOtVuza;

                    myCommand.Parameters.Add("@FIOotPrep", SqlDbType.Char, 30);
                    myCommand.Parameters["@FIOotPrep"].Value = FIOotPrep;

                    myCommand.Parameters.Add("@DoljnostOtPrep", SqlDbType.Char, 30);
                    myCommand.Parameters["@DoljnostOtPrep"].Value = DoljnostOtPrep;

                    myCommand.Parameters.Add("@DateStart", SqlDbType.DateTime, 30);
                    myCommand.Parameters["@DateStart"].Value = DateStart;

                    myCommand.Parameters.Add("@DateEnd", SqlDbType.DateTime, 30);
                    myCommand.Parameters["@DateEnd"].Value = DateEnd;

                    myCommand.Parameters.Add("@Mark", SqlDbType.Int, 4);
                    myCommand.Parameters["@Mark"].Value = Mark;

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
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
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
                    int Kod = int.Parse(this.textBox10.Text);

                    conn = new SqlConnection();
                    conn.ConnectionString = connectionString;
                    conn.Open();

                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = "DELETE FROM Result WHERE Kod = @Kod";
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
                    textBox10.Clear();
                    conn.Close();
                }
            }
        }
    }
}
