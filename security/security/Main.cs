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


namespace security
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }




        private void Main_Load(object sender, EventArgs e)
        {
            DataTable Tabl = new DataTable();
            SqlDataAdapter Adap = new SqlDataAdapter("SELECT ObjectCategory.NameCategory as Объект, Clients.Surname+' '+Clients.Name+' '+Clients.MiddleName as Заказчик, Citys.CityName as [Населенный пункт], (ISNULL(Streets.StreetName,'')+ISNULL('  д.'+Objects.House,'')+ISNULL('  к.'+Objects.Building,'') +ISNULL('  п.'+Objects.Entrance,'') +ISNULL('  кв.'+Objects.Room,'')) as Адрес, Objects.ConsoleNumber as [Пультовой номер], Objects.KeyNumber as Ячейка, Objects.FileNumber as  Дело FROM Objects LEFT JOIN ObjectCategory ON Objects.ObjectCategory= ObjectCategory.ID_ObjectCategory  LEFT JOIN Clients ON Objects.Client = Clients.ID_Client  LEFT JOIN Citys ON Objects.City = Citys.ID_City LEFT JOIN Streets ON Objects.Street = Streets.ID_Street", Static.Con);
            Adap.Fill(Tabl);
            dataGridView1.DataSource = Tabl;
            dataGridView1.TopLeftHeaderCell.Value = "№ п/п";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridView1.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridView1.Rows[index].HeaderCell.Value = indexStr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable Tabl = new DataTable();
            SqlDataAdapter Adap = new SqlDataAdapter("SELECT ObjectCategory.NameCategory as Объект, Clients.Surname+' '+Clients.Name+' '+Clients.MiddleName as Заказчик, Citys.CityName as [Населенный пункт], (ISNULL(Streets.StreetName,'')+ISNULL('  д.'+Objects.House,'')+ISNULL('  к.'+Objects.Building,'') +ISNULL('  п.'+Objects.Entrance,'') +ISNULL('  кв.'+Objects.Room,'')) as Адрес, Objects.ConsoleNumber as [Пультовой номер], Objects.KeyNumber as Ячейка, Objects.FileNumber as  Дело FROM Objects LEFT JOIN ObjectCategory ON Objects.ObjectCategory= ObjectCategory.ID_ObjectCategory  LEFT JOIN Clients ON Objects.Client = Clients.ID_Client  LEFT JOIN Citys ON Objects.City = Citys.ID_City LEFT JOIN Streets ON Objects.Street = Streets.ID_Street", Static.Con);
            Adap.Fill(Tabl);
            dataGridView1.DataSource = Tabl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable Tabl = new DataTable();
            SqlDataAdapter Adap = new SqlDataAdapter("SELECT Surname+' '+Name+' '+MiddleName as [Ф.И.О], (ISNULL(Citys.CityName,'')+ISNULL(' '+Streets.StreetName,'')+ISNULL(' д.'+House,'')+ISNULL(' к.'+Building,'')+ISNULL(' кв.'+Clients.Room,'')) as [Адрес места жительства],  ISNULL(MobilPhone,'')+' '+MobileOperators.MobileOperatorName as [Мобильный телефон], HomePhone as [Домашний телефон] FROM Clients   JOIN Citys ON City=Citys.ID_City  JOIN Streets ON Street= Streets.ID_Street JOIN MobileOperators ON MobileOperator=MobileOperators.ID_MobileOperator", Static.Con);
            Adap.Fill(Tabl);
            dataGridView1.DataSource = Tabl;
        }
    }
}
