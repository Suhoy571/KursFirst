using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KursFirst
{
    public partial class Main : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuho\Documents\Visual Studio 2015\Projects\KursFirst\FirstKurs.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Kod AS [Код кампании], Name AS [Название кампании], " +
                "ShortName AS [Краткое название кампании] FROM Company", conn);
            //Создание объекта DataSet
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            //Связываем источники данных объекта dataGridView1 с таблицами из базы данных
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //Метод Dispose, включающий в себя метод Close();
            //Разрывает соединение и освобождает ресурсы
            conn.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Kod AS [Код уч. зав.], Name AS [Название уч. зав.], " +
                "ShortName AS [Краткое название уч. зав.] FROM EducationInstitut", conn);
            //Создание объекта DataSet
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            //Связываем источники данных объекта dataGridView1 с таблицами из базы данных
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //Метод Dispose, включающий в себя метод Close();
            //Разрывает соединение и освобождает ресурсы
            conn.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Kod AS [Код факультета], Name AS [Название факультета], " +
                "ShortName AS [Краткое название факультета] FROM Facultet", conn);
            //Создание объекта DataSet
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            //Связываем источники данных объекта dataGridView1 с таблицами из базы данных
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //Метод Dispose, включающий в себя метод Close();
            //Разрывает соединение и освобождает ресурсы
            conn.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Kod AS [Код формы обучения], Name AS [Название формы обучения], " +
                "ShortName AS [Краткое название формы обучения] FROM FormObuch", conn);
            //Создание объекта DataSet
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            //Связываем источники данных объекта dataGridView1 с таблицами из базы данных
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //Метод Dispose, включающий в себя метод Close();
            //Разрывает соединение и освобождает ресурсы
            conn.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Kod AS [Код формы обучения], KodStudentRecordBook AS [Код зачетки студента], " +
                "NumberCompany AS [Номер кампании], NameCompany AS [Название кампании], " +
                "FIOotVuza AS [Фамилия руководителя от ВУЗа], DoljnostOtVuza AS [Должность руководителя от ВУЗа], " +
                "FIOotPrep AS [Должность руководителя от Предприятия], DateStart AS [Дата начала практики], " + 
                "DateEnd AS [Дата окончания практики],  Mark AS [Оценка за практику] FROM Result", conn);
            //Создание объекта DataSet
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            //Связываем источники данных объекта dataGridView1 с таблицами из базы данных
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //Метод Dispose, включающий в себя метод Close();
            //Разрывает соединение и освобождает ресурсы
            conn.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Kod AS [Код специальности], Name AS [Название специальности], " +
                "ShortName AS [Краткое название специальности], KodFacult AS [Код факультета] FROM Speciality", conn);
            //Создание объекта DataSet
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            //Связываем источники данных объекта dataGridView1 с таблицами из базы данных
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //Метод Dispose, включающий в себя метод Close();
            //Разрывает соединение и освобождает ресурсы
            conn.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT KodStudentRecordBook AS [Код зачетки студента], FIO AS [ФИО], " +
                "KodEducationalInstitut AS [Код обр. уч.], FormObuch AS [Код формы обучения], Facultet  AS [Код факультета], Speciality AS [Код специальности] FROM Student", conn);
            //Создание объекта DataSet
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            //Связываем источники данных объекта dataGridView1 с таблицами из базы данных
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //Метод Dispose, включающий в себя метод Close();
            //Разрывает соединение и освобождает ресурсы
            conn.Dispose();
        }
    }
}
