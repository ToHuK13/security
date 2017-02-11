﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace security
{
    public partial class EdtObject : Form
    {
        public static int ObjectID,TrustID;
        public EdtObject()
        {
            InitializeComponent();
            ShowTrustees();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.TopLeftHeaderCell.Value = "№ п/п";
            dataGridView1.Columns[0].Visible = false;
        }

        private void ShowTrustees()
        {
            DataTable TablAC1 = new DataTable();
            SqlDataAdapter AdapAC1 = new SqlDataAdapter("SELECT * FROM ProtectionUnits", Static.Con);
            AdapAC1.Fill(TablAC1);
            comboBox1.DataSource = TablAC1.DefaultView;
            comboBox1.DisplayMember = "ProtectionUnitName";
            comboBox1.ValueMember = "ID";

            DataTable TablAC2 = new DataTable();
            SqlDataAdapter AdapAC2 = new SqlDataAdapter("SELECT * FROM ObjectCategorys", Static.Con);
            AdapAC2.Fill(TablAC2);
            comboBox2.DataSource = TablAC2.DefaultView;
            comboBox2.DisplayMember = "ObjectCategoryName";
            comboBox2.ValueMember = "ID";

            DataTable TablAC3 = new DataTable();
            SqlDataAdapter AdapAC3 = new SqlDataAdapter("SELECT ID, (ISNULL(Clients.Surname,'')+ISNULL(' '+Clients.Name,'')+ISNULL(' '+Clients.MiddleName,'')) as ClientName FROM Clients ORDER BY ClientName ", Static.Con);
            AdapAC3.Fill(TablAC3);
            comboBox3.DataSource = TablAC3.DefaultView;
            comboBox3.DisplayMember = "ClientName";
            comboBox3.ValueMember = "ID";

            DataTable TablAC4 = new DataTable();
            SqlDataAdapter AdapAC4 = new SqlDataAdapter("SELECT * FROM Citys ORDER BY CityName", Static.Con);
            AdapAC4.Fill(TablAC4);
            comboBox4.DataSource = TablAC4.DefaultView;
            comboBox4.DisplayMember = "CityName";
            comboBox4.ValueMember = "ID";

            DataTable TablAC5 = new DataTable();
            SqlDataAdapter AdapAC5 = new SqlDataAdapter("SELECT * FROM Streets ORDER BY StreetName", Static.Con);
            AdapAC5.Fill(TablAC5);
            comboBox5.DataSource = TablAC5.DefaultView;
            comboBox5.DisplayMember = "StreetName";
            comboBox5.ValueMember = "ID";

            DataTable TablAC6 = new DataTable();
            SqlDataAdapter AdapAC6 = new SqlDataAdapter("SELECT * FROM PropertyTypes", Static.Con);
            AdapAC6.Fill(TablAC6);
            comboBox6.DataSource = TablAC6.DefaultView;
            comboBox6.DisplayMember = "PropertyTypeName";
            comboBox6.ValueMember = "ID";


            DataTable Tabl = new DataTable();
            string sql = string.Format("SELECT * FROM Objects WHERE ID={0}", ObjectID);
            SqlDataAdapter Adap = new SqlDataAdapter(sql, Static.Con);
            Adap.Fill(Tabl);

            DataTable TablTrust = new DataTable();
            string sqlTr = string.Format("select Trustees.ID, (ISNULL(Trustees.Surname,'')+ISNULL(' '+Trustees.Name,'')+ISNULL(' '+Trustees.MiddleName,'')) as [Ф.И.О], (ISNULL(Citys.CityName,'')+ISNULL(' '+Streets.StreetName,'')+ISNULL(' д.'+Trustees.House,'')+ISNULL(' к.'+Trustees.Building,'')+ISNULL(' кв.'+Trustees.Room,'')) as [Адрес места жительства],  ISNULL(Trustees.MobilPhone,'')+' '+MobileOperators.MobileOperatorName as [Мобильный телефон], Trustees.HomePhone as [Домашний телефон], Trustees.Work as [Место работы]  from Trustees LEFT JOIN Citys ON  Trustees.City=Citys.ID  LEFT JOIN Streets ON Trustees.Street= Streets.ID LEFT JOIN MobileOperators ON Trustees.MobileOperator=MobileOperators.ID  WHERE Trustees.Object={0}", ObjectID);
            SqlDataAdapter AdapTr = new SqlDataAdapter(sqlTr, Static.Con);
            AdapTr.Fill(TablTrust);
            dataGridView1.DataSource = TablTrust;

            textBox10.Text = Tabl.Rows[0]["FileNumber"].ToString();
            comboBox1.SelectedValue = int.Parse(Tabl.Rows[0]["ProtectionUnit"].ToString());
            comboBox2.SelectedValue = int.Parse(Tabl.Rows[0]["ObjectCategory"].ToString());
            comboBox3.SelectedValue = int.Parse(Tabl.Rows[0]["Client"].ToString());
            comboBox4.SelectedValue = int.Parse(Tabl.Rows[0]["City"].ToString());
            comboBox5.SelectedValue = int.Parse(Tabl.Rows[0]["Street"].ToString());
            comboBox6.SelectedValue = int.Parse(Tabl.Rows[0]["PropertyType"].ToString());
            textBox1.Text = Tabl.Rows[0]["House"].ToString();
            textBox2.Text = Tabl.Rows[0]["Building"].ToString();
            textBox3.Text = Tabl.Rows[0]["Entrance"].ToString();
            textBox4.Text = Tabl.Rows[0]["Level"].ToString();
            textBox5.Text = Tabl.Rows[0]["Room"].ToString();
            textBox6.Text = Tabl.Rows[0]["CountRoom"].ToString();
            textBox7.Text = Tabl.Rows[0]["HomePhone"].ToString();
            textBox8.Text = Tabl.Rows[0]["Intercom"].ToString();
            textBox9.Text = Tabl.Rows[0]["KeyNumber"].ToString();
            textBox11.Text = Tabl.Rows[0]["Description"].ToString();
            textBox12.Text = Tabl.Rows[0]["Blocking"].ToString();
            textBox13.Text = Tabl.Rows[0]["Keys"].ToString();
        }


        private void EdtObject_Load(object sender, EventArgs e)
        {
            ShowTrustees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Zap;
            Zap = string.Format("UPDATE Objects SET " +
                "FileNumber='{0}', ProtectionUnit='{1}', ObjectCategory='{2}', Client='{3}', City='{4}', Street='{5}'                , PropertyType='{6}', House='{7}', Building='{8}', Entrance='{9}', Level='{10}', Room='{11}',                 CountRoom='{12}' ,  HomePhone='{13}' , Intercom='{14}', KeyNumber='{15}', Description='{16}',                Blocking='{17}',Keys='{18}' WHERE ID='{19}' ",
            textBox10.Text, comboBox1.SelectedValue, comboBox2.SelectedValue, comboBox3.SelectedValue, comboBox4.SelectedValue, comboBox5.SelectedValue, comboBox6.SelectedValue, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox11.Text, textBox12.Text, textBox13.Text, ObjectID);
            SqlCommand cmd = new SqlCommand(Zap, Static.Con);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {


        }

        private void дОБАВИТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTrust.TrustID = 0;
            AddTrust.ObjectID = ObjectID;
            AddTrust AddTr = new AddTrust();
            AddTr.ShowDialog();
            ShowTrustees();

        }

        private void иЗМЕНИТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTrust.TrustID = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
            AddTrust.ObjectID = ObjectID;
            AddTrust AddTr = new AddTrust();
            AddTr.ShowDialog();
            ShowTrustees();
        }

        private void уДАЛИТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
"Вы действительно хотите удалить запись?",
"Сообщение",
MessageBoxButtons.YesNo,
MessageBoxIcon.Information,
MessageBoxDefaultButton.Button1,
MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                try
                {
                    TrustID = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                    DataTable TablTr = new DataTable();
                    string Zap = string.Format("DELETE from Trustees where ID={0}", TrustID);
                    SqlCommand cmd = new SqlCommand(Zap, Static.Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно удалена");
                    ShowTrustees();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка удаления!");
                }
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridView1.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridView1.Rows[index].HeaderCell.Value = indexStr;
        }

    }
}
