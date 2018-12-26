using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DAL;
using BLL.Services;
using BLL.Interfaces;
using BLL.Models;

namespace Поликлиника_лаба_3
{
    public partial class Form1 : Form
    {

        public List<PacientModel> pacients;
        public List<UchastokModel> uchastoks;
        public List<RaspisanieModel> rasp;

        IReportService reportservice;
        IdbCrud dbOperations;

        public Form1(IdbCrud crudDb, IReportService reportservice, IPacientService pacientservice)
        {
            this.Text = "Электронная регистратура";
            this.reportservice = reportservice;
            dbOperations = crudDb;
            InitializeComponent();
            loadData();
        }

        private void RefreshgvPacient()
        {
            dataGridViewPacient.DataSource = dbOperations.GetAllPacient();
            dataGridViewPacient.Refresh();
        }

        private void loadData()
        {
            loadRaspisanie();
            loadPacient();
        }

        private void loadRaspisanie()
        {
            rasp = dbOperations.GetRaspisanie();
            gvRaspisanieList.DataSource = rasp;
        }

        public class pacient
        {
            public string FIO { get; set; }
            public string Adres { get; set; }
            public int Polis_number { get; set; }
            public int Uchastok_number { get; set; }

        }

        private void loadPacient()
        {
            pacients = dbOperations.GetAllPacient();
            dataGridViewPacient.DataSource = pacients;
        }

        public void spravcheck(string ul, FormPacientAdd f, PacientModel pacient)
            {
            if (ul == "Рабфаковская, 1" || ul == "Рабфаковская, 2" || ul == "Рабфаковская, 3") { pacient.Uchastok_number = 1; }
            if (ul == "Профессиональная, 1" || ul == "Профессиональная, 2" || ul == "Профессиональная, 3") { pacient.Uchastok_number = 2; }
            if (ul == "Красных Зорь, 1" || ul == "Красных Зорь, 2" || ul == "Красных Зорь, 3") { pacient.Uchastok_number = 1; }
            if (ul == "Лежневская, 1" || ul == "Лежневская, 2" || ul == "Лежневская, 3") { pacient.Uchastok_number = 3; }
            if (ul == "Ермака, 1" || ul == "Ермака, 2" || ul == "Ермака, 3") { pacient.Uchastok_number = 4; }
            if (ul == "Станционная, 1" || ul == "Станционная, 2" || ul == "Станционная, 3") { pacient.Uchastok_number = 4; }
            if (ul == "Громобоя, 1" || ul == "Громобоя, 2" || ul == "Громобоя, 3") { pacient.Uchastok_number = 5; }
            if (ul == "Парижской Комунны, 1" || ul == "Парижской Комунны, 2" || ul == "Парижской Комунны, 3") { pacient.Uchastok_number = 6; }
            if (ul == "Станкостроителей, 1" || ul == "Станкостроителей, 2" || ul == "Станкостроителей, 3") { pacient.Uchastok_number = 7; }
            }
        
        private void Add_Click(object sender, EventArgs e)
        {
            FormPacientAdd f = new FormPacientAdd();
            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
            string ul;
            PacientModel pacient = new PacientModel();
            pacient.Polis_number = Convert.ToInt32(f.textBox1.Text);
            pacient.FIO = f.textBox2.Text;
            pacient.Gender = f.comboBox1.Text;
            pacient.Birth_day = Convert.ToDateTime(f.textBox4.Text);
            pacient.Adres = f.textBox5.Text;
            ul = f.textBox5.Text;
            spravcheck(ul, f, pacient);

            dbOperations.CreatePacient(pacient);
            RefreshgvPacient();

            MessageBox.Show("Новый пациент добавлен");
        }

        private bool hasSelectedRow(DataGridView dataGridView)
        {
            return (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewPacient);
            if (hasSelectedRow(dataGridViewPacient))
            {
                dbOperations.DeletePacient(((PacientModel)dataGridViewPacient.CurrentRow.DataBoundItem).Polis_number);
                loadPacient();
            }
            else
                MessageBox.Show("Ни один пациент не выбран!");
        }

        private int getSelectedRow(DataGridView dataGridView)
        {
            int index = -1;
            if (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                    index = dataGridView.SelectedRows[0].Index;
                else index = dataGridView.SelectedCells[0].RowIndex;
            }
            return index;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (hasSelectedRow(dataGridViewPacient))
            {
                PacientModel pacient = (PacientModel)dataGridViewPacient.CurrentRow.DataBoundItem;
                FormPacientAdd f = new FormPacientAdd();

                f.textBox1.Text = Convert.ToString(pacient.Polis_number);
                f.textBox2.Text = pacient.FIO;
                f.comboBox1.Text = pacient.Gender;
                f.textBox4.Text = Convert.ToString(pacient.Birth_day);
                f.textBox5.Text = pacient.Adres;
                if (f.ShowDialog(this) == DialogResult.Cancel)
                    return;
                List<PacientModel> items = new List<PacientModel>();
                string ul;
                pacient.Polis_number = Convert.ToInt32(f.textBox1.Text);
                pacient.FIO = f.textBox2.Text;
                pacient.Gender = f.comboBox1.Text;
                pacient.Birth_day = Convert.ToDateTime(f.textBox4.Text);
                pacient.Adres = f.textBox5.Text;
                ul = pacient.Adres;

                spravcheck(ul, f, pacient);

                dbOperations.UpdatePacient(pacient);
                MessageBox.Show("Обновлено");
                RefreshgvPacient();
                /*if (result)
                {
                    loadPacient();
                    MessageBox.Show("Success");
                }
                else MessageBox.Show("Failed");*/
            }
        }

        /*private class SPResult
        {
            public string Pacient_FIO { get; set; }
            public DateTime Zapis_date { get; set; }
        }*/


        private void button1_Click(object sender, EventArgs e)//запись пациента
        {
           
            ZapisModel z = new ZapisModel();
            
            

            z.Zapis_date = dateTimePicker3.Value;
            z.Pacient_FIO = comboBoxPacient.Text;
            z.Zapis_time = comboBoxTime.Text;
            z.Doctor_FIO = comboBoxVrach.Text;

            RaspisanieModel r = dbOperations.GetId(Convert.ToInt32(comboBoxKab.Text));

            if (comboBoxTime.Text == "")
            {
                MessageBox.Show("Введите время приема");
                comboBoxTime.Select();
            }


            if (r.Status == "Больничный" || r.Status == "Отпуск    ")
            {
                MessageBox.Show("Выбранный врач отсутсвует, пожалуйста, выберите другого специалиста");
                comboBoxVrach.Select();
            }
            else
            {
                dbOperations.CreateZapis(z);
                MessageBox.Show("Запись выполнена");
            }
        }

        private void ExecuteSP()//вывод очереди
        {
            ReportsService rs = new ReportsService();
            dataGridViewProcedura.DataSource = rs.ExecuteSP(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void button2_Click(object sender, EventArgs e)//вызов хранимки
        {
            ExecuteSP();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet.Pacient". При необходимости она может быть перемещена или удалена.
            this.pacientTableAdapter.Fill(this.poliklinikaDataSet.Pacient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet.Doctors_speciality". При необходимости она может быть перемещена или удалена.
            this.doctors_specialityTableAdapter.Fill(this.poliklinikaDataSet.Doctors_speciality);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.poliklinikaDataSet.Doctor);


        }

        private void comboBoxVrach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoctorModel d = new DoctorModel();
            
            comboBoxSpeciality.Text = Convert.ToString(d.Speciality);
            comboBoxKab.Text = Convert.ToString(d.Kabinet);
        }

        private void comboBoxPacient_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
