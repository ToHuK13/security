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
        public static int ID;

        public Main()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ShowOgjects();
            ShowClients();
            dataGridView1.TopLeftHeaderCell.Value = "№ п/п";
            dataGridView1.Columns[0].Visible = false;
        }


        public void ShowOgjects()
            {
            DataTable Tabl = new DataTable();
            SqlDataAdapter Adap = new SqlDataAdapter("SELECT Objects.ID, ProtectionUnitName as [Подразделение охраны],  Objects.FileNumber as  Дело, ObjectCategory.ObjectCategoryName as Объект, PropertyTypes.PropertyTypeName as [Категория клиента] , (ISNULL(Clients.Surname,'')+ISNULL(' '+Clients.Name,'')+ISNULL(' '+Clients.MiddleName,'')) as Заказчик, (ISNULL(Citys.CityName,'')+ISNULL(' '+Streets.StreetName,'')+ISNULL('  д.'+Objects.House,'')+ISNULL('  к.'+Objects.Building,'') +ISNULL('  п.'+Objects.Entrance,'') +ISNULL('  кв.'+Objects.Room,'')) as Адрес,  (ISNULL(Objects.OS,'')+ISNULL(Objects.TS,'')+ISNULL(Objects.PS,'')) as [Средства охраны] , Responses.ResponseName as [Вид реагирования],Objects.ConsoleNumber as [Пультовой номер], Objects.KeyNumber as Ячейка FROM Objects LEFT JOIN ObjectCategory ON Objects.ObjectCategory= ObjectCategory.ID  LEFT JOIN Clients ON Objects.Client = Clients.ID  LEFT JOIN Citys ON Objects.City = Citys.ID LEFT JOIN Streets ON Objects.Street = Streets.ID LEFT JOIN ProtectionUnits on Objects.ProtectionUnit = ProtectionUnits.ID LEFT JOIN Responses ON Objects.Response = Responses.ID LEFT JOIN PropertyTypes ON Objects.PropertyType = PropertyTypes.ID", Static.Con);
            
            Adap.Fill(Tabl);
            dataGridView1.DataSource = Tabl;
    }

        public void ShowClients()
        {
            DataTable Tabl = new DataTable();
            SqlDataAdapter Adap = new SqlDataAdapter("SELECT Clients.ID, (ISNULL(Clients.Surname,'')+ISNULL(' '+Clients.Name,'')+ISNULL(' '+Clients.MiddleName,'')) as [Ф.И.О], (ISNULL(Citys.CityName,'')+ISNULL(' '+Streets.StreetName,'')+ISNULL(' д.'+Clients.House,'')+ISNULL(' к.'+Clients.Building,'')+ISNULL(' кв.'+Clients.Room,'')) as [Адрес места жительства],  ISNULL(Clients.MobilPhone,'')+' '+MobileOperators.MobileOperatorName as [Мобильный телефон], Clients.HomePhone as [Домашний телефон],  ClientCategorys.ClientCategoryName as [Категория клиента] FROM Clients  LEFT JOIN Citys ON  Clients.City=Citys.ID  LEFT JOIN Streets ON Clients.Street= Streets.ID LEFT JOIN MobileOperators ON Clients.MobileOperator=MobileOperators.ID LEFT JOIN ClientCategorys ON Clients.ClientCategory=ClientCategorys.ID", Static.Con);
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
            ShowOgjects();
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
            SqlDataAdapter Adap = new SqlDataAdapter("SELECT ProtectionUnitName as [Подразделение охраны],  Objects.FileNumber as  Дело, ObjectCategory.ObjectCategoryName as Объект, PropertyTypes.PropertyTypeName as [Категория клиента] , (ISNULL(Clients.Surname,'')+ISNULL(' '+Clients.Name,'')+ISNULL(' '+Clients.MiddleName,'')) as Заказчик, (ISNULL(Citys.CityName,'')+ISNULL(' '+Streets.StreetName,'')+ISNULL('  д.'+Objects.House,'')+ISNULL('  к.'+Objects.Building,'') +ISNULL('  п.'+Objects.Entrance,'') +ISNULL('  кв.'+Objects.Room,'')) as Адрес,  (ISNULL(Objects.OS,'')+ISNULL(Objects.TS,'')+ISNULL(Objects.PS,'')) as [Средства охраны] , Responses.ResponseName as [Вид реагирования],Objects.ConsoleNumber as [Пультовой номер], Objects.KeyNumber as Ячейка FROM Objects LEFT JOIN ObjectCategory ON Objects.ObjectCategory= ObjectCategory.ID  LEFT JOIN Clients ON Objects.Client = Clients.ID  LEFT JOIN Citys ON Objects.City = Citys.ID LEFT JOIN Streets ON Objects.Street = Streets.ID LEFT JOIN ProtectionUnits on Objects.ProtectionUnit = ProtectionUnits.ID LEFT JOIN Responses ON Objects.Response = Responses.ID LEFT JOIN PropertyTypes ON Objects.PropertyType = PropertyTypes.ID", Static.Con);
            Adap.Fill(Tabl);
            DataView dv = new DataView(Tabl);
            dv.RowFilter = string.Format("Заказчик LIKE '%" + textBox1.Text + "%'");
            dataGridView1.DataSource = dv;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddClient.ID = 0;
            AddClient AddCl = new AddClient();
            AddCl.ShowDialog();
            ShowClients();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddClient.ID = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
            AddClient CLEtd = new AddClient();
            CLEtd.ShowDialog();
            ShowClients();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ID = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                DataTable Tabl = new DataTable();
                string Zap = string.Format("DELETE from Clients where ID={0}", ID);
                SqlCommand cmd = new SqlCommand(Zap, Static.Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена");
                ShowClients();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка удаления!");
            }
        }
    }
}
