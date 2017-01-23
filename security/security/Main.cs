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
            ShowOgjects();
            ShowClients();
            
        }


        public void ShowOgjects()
            {
            DataTable Tabl = new DataTable();
            SqlDataAdapter Adap = new SqlDataAdapter("SELECT ProtectionUnitName as [Подразделение охраны],  Objects.FileNumber as  Дело, ObjectCategory.NameCategory as Объект, (ISNULL(Clients.Surname,'')+ISNULL(' '+Clients.Name,'')+ISNULL(' '+Clients.MiddleName,'')) as Заказчик, Citys.CityName as [Населенный пункт], (ISNULL(Streets.StreetName,'')+ISNULL('  д.'+Objects.House,'')+ISNULL('  к.'+Objects.Building,'') +ISNULL('  п.'+Objects.Entrance,'') +ISNULL('  кв.'+Objects.Room,'')) as Адрес,  (ISNULL(Objects.OS,'')+ISNULL(Objects.TS,'')) as [Средства охраны] , Responses.ResponseName as [Вид реагирования],Objects.ConsoleNumber as [Пультовой номер], Objects.KeyNumber as Ячейка FROM Objects LEFT JOIN ObjectCategory ON Objects.ObjectCategory= ObjectCategory.ID_ObjectCategory  LEFT JOIN Clients ON Objects.Client = Clients.ID_Client  LEFT JOIN Citys ON Objects.City = Citys.ID_City LEFT JOIN Streets ON Objects.Street = Streets.ID_Street LEFT JOIN ProtectionUnits on Objects.ProtectionUnit = ProtectionUnits.ID_ProtectionUnit LEFT JOIN Responses ON Objects.Response = Responses.ID_Response", Static.Con);
            Adap.Fill(Tabl);
            dataGridView1.DataSource = Tabl;
            dataGridView1.TopLeftHeaderCell.Value = "№ п/п";
    }

        public void ShowClients()
        {
            DataTable Tabl = new DataTable();
            SqlDataAdapter Adap = new SqlDataAdapter("SELECT Surname+' '+Name+' '+MiddleName as [Ф.И.О], (ISNULL(CityName,'')+ISNULL(' '+StreetName,'')+ISNULL(' д.'+House,'')+ISNULL(' к.'+Building,'')+ISNULL(' кв.'+Room,'')) as [Адрес места жительства],  ISNULL(MobilPhone,'')+' '+MobileOperatorName as [Мобильный телефон], HomePhone as [Домашний телефон], ClientCategoryName [Категория клиента] FROM Clients   JOIN Citys ON City=ID_City  JOIN Streets ON Street= ID_Street JOIN MobileOperators ON MobileOperator=ID_MobileOperator LEFT JOIN ClientCategorys ON Clients.ClientCategory=ClientCategorys.ID_ClientCategory", Static.Con);
            Adap.Fill(Tabl);
            dataGridView1.DataSource = Tabl;
        }


        private void Main_Load(object sender, EventArgs e)
        {
            ShowOgjects();
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
            SqlDataAdapter Adap = new SqlDataAdapter("SELECT ProtectionUnitName as [Подразделение охраны],  Objects.FileNumber as  Дело, ObjectCategory.NameCategory as Объект, (ISNULL(Clients.Surname,'')+ISNULL(' '+Clients.Name,'')+ISNULL(' '+Clients.MiddleName,'')) as Заказчик, Citys.CityName as [Населенный пункт], (ISNULL(Streets.StreetName,'')+ISNULL('  д.'+Objects.House,'')+ISNULL('  к.'+Objects.Building,'') +ISNULL('  п.'+Objects.Entrance,'') +ISNULL('  кв.'+Objects.Room,'')) as Адрес,  (ISNULL(Objects.OS,'')+ISNULL(Objects.TS,'')) as [Средства охраны] , Responses.ResponseName as [Вид реагирования],Objects.ConsoleNumber as [Пультовой номер], Objects.KeyNumber as Ячейка FROM Objects LEFT JOIN ObjectCategory ON Objects.ObjectCategory= ObjectCategory.ID_ObjectCategory  LEFT JOIN Clients ON Objects.Client = Clients.ID_Client  LEFT JOIN Citys ON Objects.City = Citys.ID_City LEFT JOIN Streets ON Objects.Street = Streets.ID_Street LEFT JOIN ProtectionUnits on Objects.ProtectionUnit = ProtectionUnits.ID_ProtectionUnit LEFT JOIN Responses ON Objects.Response = Responses.ID_Response", Static.Con);
            Adap.Fill(Tabl);
            dataGridView1.DataSource = Tabl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowClients();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
         

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable Tabl = new DataTable();
            SqlDataAdapter Adap = new SqlDataAdapter("SELECT ProtectionUnitName as [Подразделение охраны],  Objects.FileNumber as  Дело, ObjectCategory.NameCategory as Объект, (ISNULL(Clients.Surname,'')+ISNULL(' '+Clients.Name,'')+ISNULL(' '+Clients.MiddleName,'')) as Заказчик, Citys.CityName as [Населенный пункт], (ISNULL(Streets.StreetName,'')+ISNULL('  д.'+Objects.House,'')+ISNULL('  к.'+Objects.Building,'') +ISNULL('  п.'+Objects.Entrance,'') +ISNULL('  кв.'+Objects.Room,'')) as Адрес,  (ISNULL(Objects.OS,'')+ISNULL(Objects.TS,'')) as [Средства охраны] , Responses.ResponseName as [Вид реагирования],Objects.ConsoleNumber as [Пультовой номер], Objects.KeyNumber as Ячейка FROM Objects LEFT JOIN ObjectCategory ON Objects.ObjectCategory= ObjectCategory.ID_ObjectCategory  LEFT JOIN Clients ON Objects.Client = Clients.ID_Client  LEFT JOIN Citys ON Objects.City = Citys.ID_City LEFT JOIN Streets ON Objects.Street = Streets.ID_Street LEFT JOIN ProtectionUnits on Objects.ProtectionUnit = ProtectionUnits.ID_ProtectionUnit LEFT JOIN Responses ON Objects.Response = Responses.ID_Response", Static.Con);
            Adap.Fill(Tabl);
            DataView dv = new DataView(Tabl);
            dv.RowFilter = string.Format("Заказчик LIKE '%" + textBox1.Text + "%'");
            dataGridView1.DataSource = dv;
        }
    }
}
