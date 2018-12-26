namespace Поликлиника_лаба_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPageProcedura = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewProcedura = new System.Windows.Forms.DataGridView();
            this.tabPageZapis = new System.Windows.Forms.TabPage();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxKab = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poliklinikaDataSet = new Поликлиника_лаба_3.PoliklinikaDataSet();
            this.comboBoxSpeciality = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxVrach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelvin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPacient = new System.Windows.Forms.ComboBox();
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRawSQL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPagePacient = new System.Windows.Forms.TabPage();
            this.dataGridViewPacient = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.tabPageRaspisanie = new System.Windows.Forms.TabPage();
            this.gvRaspisanieList = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.doctorTableAdapter = new Поликлиника_лаба_3.PoliklinikaDataSetTableAdapters.DoctorTableAdapter();
            this.doctorsspecialityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctors_specialityTableAdapter = new Поликлиника_лаба_3.PoliklinikaDataSetTableAdapters.Doctors_specialityTableAdapter();
            this.raspisanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientTableAdapter = new Поликлиника_лаба_3.PoliklinikaDataSetTableAdapters.PacientTableAdapter();
            this.tabPageProcedura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedura)).BeginInit();
            this.tabPageZapis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).BeginInit();
            this.tabPagePacient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacient)).BeginInit();
            this.tabPageRaspisanie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRaspisanieList)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsspecialityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageProcedura
            // 
            this.tabPageProcedura.Controls.Add(this.label10);
            this.tabPageProcedura.Controls.Add(this.label5);
            this.tabPageProcedura.Controls.Add(this.label4);
            this.tabPageProcedura.Controls.Add(this.label3);
            this.tabPageProcedura.Controls.Add(this.button2);
            this.tabPageProcedura.Controls.Add(this.dateTimePicker2);
            this.tabPageProcedura.Controls.Add(this.dateTimePicker1);
            this.tabPageProcedura.Controls.Add(this.dataGridViewProcedura);
            this.tabPageProcedura.Location = new System.Drawing.Point(4, 25);
            this.tabPageProcedura.Name = "tabPageProcedura";
            this.tabPageProcedura.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcedura.Size = new System.Drawing.Size(884, 366);
            this.tabPageProcedura.TabIndex = 3;
            this.tabPageProcedura.Text = "Очередь пациентов";
            this.tabPageProcedura.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Электронная очередь пациентов к врачам";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "по";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "с";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(284, 62);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dataGridViewProcedura
            // 
            this.dataGridViewProcedura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcedura.Location = new System.Drawing.Point(7, 109);
            this.dataGridViewProcedura.Name = "dataGridViewProcedura";
            this.dataGridViewProcedura.RowTemplate.Height = 24;
            this.dataGridViewProcedura.Size = new System.Drawing.Size(684, 251);
            this.dataGridViewProcedura.TabIndex = 0;
            // 
            // tabPageZapis
            // 
            this.tabPageZapis.Controls.Add(this.comboBoxTime);
            this.tabPageZapis.Controls.Add(this.dateTimePicker3);
            this.tabPageZapis.Controls.Add(this.label9);
            this.tabPageZapis.Controls.Add(this.comboBoxKab);
            this.tabPageZapis.Controls.Add(this.comboBoxSpeciality);
            this.tabPageZapis.Controls.Add(this.label8);
            this.tabPageZapis.Controls.Add(this.label7);
            this.tabPageZapis.Controls.Add(this.comboBoxVrach);
            this.tabPageZapis.Controls.Add(this.label2);
            this.tabPageZapis.Controls.Add(this.label6);
            this.tabPageZapis.Controls.Add(this.labelvin);
            this.tabPageZapis.Controls.Add(this.label1);
            this.tabPageZapis.Controls.Add(this.comboBoxPacient);
            this.tabPageZapis.Controls.Add(this.lblRawSQL);
            this.tabPageZapis.Controls.Add(this.button1);
            this.tabPageZapis.Location = new System.Drawing.Point(4, 25);
            this.tabPageZapis.Name = "tabPageZapis";
            this.tabPageZapis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZapis.Size = new System.Drawing.Size(884, 366);
            this.tabPageZapis.TabIndex = 2;
            this.tabPageZapis.Text = "Запись на прием";
            this.tabPageZapis.UseVisualStyleBackColor = true;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00"});
            this.comboBoxTime.Location = new System.Drawing.Point(172, 203);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTime.TabIndex = 20;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(9, 203);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(147, 22);
            this.dateTimePicker3.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Выберите дату и время посещения";
            // 
            // comboBoxKab
            // 
            this.comboBoxKab.DataSource = this.doctorBindingSource;
            this.comboBoxKab.DisplayMember = "Kabinet";
            this.comboBoxKab.FormattingEnabled = true;
            this.comboBoxKab.Location = new System.Drawing.Point(375, 243);
            this.comboBoxKab.Name = "comboBoxKab";
            this.comboBoxKab.Size = new System.Drawing.Size(261, 24);
            this.comboBoxKab.TabIndex = 17;
            this.comboBoxKab.ValueMember = "Kabinet";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.poliklinikaDataSet;
            // 
            // poliklinikaDataSet
            // 
            this.poliklinikaDataSet.DataSetName = "PoliklinikaDataSet";
            this.poliklinikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSpeciality
            // 
            this.comboBoxSpeciality.DataSource = this.doctorBindingSource;
            this.comboBoxSpeciality.DisplayMember = "Speciality";
            this.comboBoxSpeciality.FormattingEnabled = true;
            this.comboBoxSpeciality.Location = new System.Drawing.Point(375, 160);
            this.comboBoxSpeciality.Name = "comboBoxSpeciality";
            this.comboBoxSpeciality.Size = new System.Drawing.Size(261, 24);
            this.comboBoxSpeciality.TabIndex = 16;
            this.comboBoxSpeciality.ValueMember = "Speciality";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Номер кабинета";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Выберите специальность";
            // 
            // comboBoxVrach
            // 
            this.comboBoxVrach.DataSource = this.doctorBindingSource;
            this.comboBoxVrach.DisplayMember = "FIO";
            this.comboBoxVrach.FormattingEnabled = true;
            this.comboBoxVrach.Location = new System.Drawing.Point(375, 66);
            this.comboBoxVrach.Name = "comboBoxVrach";
            this.comboBoxVrach.Size = new System.Drawing.Size(261, 24);
            this.comboBoxVrach.TabIndex = 13;
            this.comboBoxVrach.ValueMember = "FIO";
            this.comboBoxVrach.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrach_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выберите врача";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 11;
            // 
            // labelvin
            // 
            this.labelvin.AutoSize = true;
            this.labelvin.Location = new System.Drawing.Point(410, 90);
            this.labelvin.Name = "labelvin";
            this.labelvin.Size = new System.Drawing.Size(0, 17);
            this.labelvin.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите пациента";
            // 
            // comboBoxPacient
            // 
            this.comboBoxPacient.DataSource = this.pacientBindingSource;
            this.comboBoxPacient.DisplayMember = "FIO";
            this.comboBoxPacient.FormattingEnabled = true;
            this.comboBoxPacient.Location = new System.Drawing.Point(6, 66);
            this.comboBoxPacient.Name = "comboBoxPacient";
            this.comboBoxPacient.Size = new System.Drawing.Size(261, 24);
            this.comboBoxPacient.TabIndex = 7;
            this.comboBoxPacient.ValueMember = "FIO";
            this.comboBoxPacient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxPacient_MouseClick);
            // 
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataMember = "Pacient";
            this.pacientBindingSource.DataSource = this.poliklinikaDataSet;
            // 
            // lblRawSQL
            // 
            this.lblRawSQL.AutoSize = true;
            this.lblRawSQL.Location = new System.Drawing.Point(299, 16);
            this.lblRawSQL.Name = "lblRawSQL";
            this.lblRawSQL.Size = new System.Drawing.Size(0, 17);
            this.lblRawSQL.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPagePacient
            // 
            this.tabPagePacient.Controls.Add(this.dataGridViewPacient);
            this.tabPagePacient.Controls.Add(this.Delete);
            this.tabPagePacient.Controls.Add(this.Change);
            this.tabPagePacient.Controls.Add(this.Add);
            this.tabPagePacient.Location = new System.Drawing.Point(4, 25);
            this.tabPagePacient.Name = "tabPagePacient";
            this.tabPagePacient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePacient.Size = new System.Drawing.Size(884, 366);
            this.tabPagePacient.TabIndex = 1;
            this.tabPagePacient.Text = "Пациент";
            this.tabPagePacient.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPacient
            // 
            this.dataGridViewPacient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacient.Location = new System.Drawing.Point(4, 53);
            this.dataGridViewPacient.Name = "dataGridViewPacient";
            this.dataGridViewPacient.RowTemplate.Height = 24;
            this.dataGridViewPacient.Size = new System.Drawing.Size(857, 307);
            this.dataGridViewPacient.TabIndex = 0;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(235, 15);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(106, 29);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(123, 15);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(106, 29);
            this.Change.TabIndex = 2;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(11, 15);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(106, 29);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // tabPageRaspisanie
            // 
            this.tabPageRaspisanie.Controls.Add(this.gvRaspisanieList);
            this.tabPageRaspisanie.Location = new System.Drawing.Point(4, 25);
            this.tabPageRaspisanie.Name = "tabPageRaspisanie";
            this.tabPageRaspisanie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRaspisanie.Size = new System.Drawing.Size(884, 366);
            this.tabPageRaspisanie.TabIndex = 0;
            this.tabPageRaspisanie.Text = "Расписание";
            this.tabPageRaspisanie.UseVisualStyleBackColor = true;
            // 
            // gvRaspisanieList
            // 
            this.gvRaspisanieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRaspisanieList.Location = new System.Drawing.Point(3, 0);
            this.gvRaspisanieList.Name = "gvRaspisanieList";
            this.gvRaspisanieList.RowTemplate.Height = 24;
            this.gvRaspisanieList.Size = new System.Drawing.Size(881, 363);
            this.gvRaspisanieList.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRaspisanie);
            this.tabControl1.Controls.Add(this.tabPagePacient);
            this.tabControl1.Controls.Add(this.tabPageZapis);
            this.tabControl1.Controls.Add(this.tabPageProcedura);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 395);
            this.tabControl1.TabIndex = 5;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsspecialityBindingSource
            // 
            this.doctorsspecialityBindingSource.DataMember = "Doctors_speciality";
            this.doctorsspecialityBindingSource.DataSource = this.poliklinikaDataSet;
            // 
            // doctors_specialityTableAdapter
            // 
            this.doctors_specialityTableAdapter.ClearBeforeFill = true;
            // 
            // raspisanieBindingSource
            // 
            this.raspisanieBindingSource.DataMember = "Raspisanie";
            this.raspisanieBindingSource.DataSource = this.poliklinikaDataSet;
            // 
            // pacientTableAdapter
            // 
            this.pacientTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 412);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Электронная регистратура";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageProcedura.ResumeLayout(false);
            this.tabPageProcedura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedura)).EndInit();
            this.tabPageZapis.ResumeLayout(false);
            this.tabPageZapis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).EndInit();
            this.tabPagePacient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacient)).EndInit();
            this.tabPageRaspisanie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRaspisanieList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsspecialityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageProcedura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewProcedura;
        private System.Windows.Forms.TabPage tabPageZapis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxKab;
        private System.Windows.Forms.ComboBox comboBoxSpeciality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxVrach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelvin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPacient;
        private System.Windows.Forms.Label lblRawSQL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPagePacient;
        private System.Windows.Forms.DataGridView dataGridViewPacient;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TabPage tabPageRaspisanie;
        private System.Windows.Forms.DataGridView gvRaspisanieList;
        private System.Windows.Forms.TabControl tabControl1;
        private PoliklinikaDataSet poliklinikaDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private PoliklinikaDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        public System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.BindingSource doctorsspecialityBindingSource;
        private PoliklinikaDataSetTableAdapters.Doctors_specialityTableAdapter doctors_specialityTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource raspisanieBindingSource;
        private System.Windows.Forms.BindingSource pacientBindingSource;
        private PoliklinikaDataSetTableAdapters.PacientTableAdapter pacientTableAdapter;
    }
}

