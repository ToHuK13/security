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
        public static int ClientID, ObjectID;

        public Main()
        {      
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ShowClients();
            ShowObjects();

            dataGridView1.TopLeftHeaderCell.Value = "№ п/п";
            dataGridView1.Columns[0].Visible = false;
        }


        public void ShowObjects()
            {
            //DataTable Tabl = new DataTable();
            //SqlDataAdapter Adap = new SqlDataAdapter("SELECT Objects.ID, ProtectionUnitName as [Подразделение охраны],  Objects.FileNumber as  Дело, ObjectCategorys.ObjectCategoryName as Объект, PropertyTypes.PropertyTypeName as [Категория клиента] , (ISNULL(Clients.Surname,'')+ISNULL(' '+Clients.Name,'')+ISNULL(' '+Clients.MiddleName,'')) as Заказчик, (ISNULL(Citys.CityName,'')+ISNULL(' '+Streets.StreetName,'')+ISNULL('  д.'+Objects.House,'')+ISNULL('  к.'+Objects.Building,'') +ISNULL('  п.'+Objects.Entrance,'') +ISNULL('  кв.'+Objects.Room,'')) as Адрес,  (ISNULL(Objects.OS,'')+ISNULL(Objects.TS,'')+ISNULL(Objects.PS,'')) as [Система охраны] , Objects.ConsoleNumber as [Пультовой номер], Objects.KeyNumber as Ячейка FROM Objects LEFT JOIN ObjectCategorys ON Objects.ObjectCategory= ObjectCategorys.ID  LEFT JOIN Clients ON Objects.Client = Clients.ID  LEFT JOIN Citys ON Objects.City = Citys.ID LEFT JOIN Streets ON Objects.Street = Streets.ID LEFT JOIN ProtectionUnits on Objects.ProtectionUnit = ProtectionUnits.ID LEFT JOIN PropertyTypes ON Objects.PropertyType = PropertyTypes.ID", Static.Con);           
            //Adap.Fill(Tabl);
            //dataGridView1.DataSource = Tabl;
            DataTable TablObj = new DataTable();
            SqlDataAdapter AdapObj = new SqlDataAdapter("SELECT Objects.ID, ProtectionUnitName as [Подразделение охраны],  Objects.FileNumber as  Дело, ObjectCategorys.ObjectCategoryName as Объект, PropertyTypes.PropertyTypeName as [Категория клиента] , (ISNULL(Clients.Surname,'')+ISNULL(' '+Clients.Name,'')+ISNULL(' '+Clients.MiddleName,'')) as Заказчик, (ISNULL(Citys.CityName,'')+ISNULL(' '+Streets.StreetName,'')+ISNULL('  д.'+Objects.House,'')+ISNULL('  к.'+Objects.Building,'') +ISNULL('  п.'+Objects.Entrance,'') +ISNULL('  кв.'+Objects.Room,'')) as Адрес,  (ISNULL(Objects.OS,'')+ISNULL(Objects.TS,'')+ISNULL(Objects.PS,'')) as [Система охраны] ,Objects.ConsoleNumber as [Пультовой номер], Objects.KeyNumber as Ячейка FROM Objects LEFT JOIN ObjectCategorys ON Objects.ObjectCategory= ObjectCategorys.ID  LEFT JOIN Clients ON Objects.Client = Clients.ID  LEFT JOIN Citys ON Objects.City = Citys.ID LEFT JOIN Streets ON Objects.Street = Streets.ID LEFT JOIN ProtectionUnits on Objects.ProtectionUnit = ProtectionUnits.ID LEFT JOIN PropertyTypes ON Objects.PropertyType = PropertyTypes.ID", Static.Con);
            AdapObj.Fill(TablObj);
            DataView dvObj = new DataView(TablObj);
            dvObj.RowFilter = string.Format("Заказчик LIKE '%" + textBox1.Text + "%' or Адрес LIKE '%" + textBox1.Text + "%' ");
            dataGridView1.DataSource = dvObj;
    }

        public void ShowClients()
        {
            //DataTable Tabl = new DataTable();
            //SqlDataAdapter Adap = new SqlDataAdapter("SELECT Clients.ID, (ISNULL(Clients.Surname,'')+ISNULL(' '+Clients.Name,'')+ISNULL(' '+Clients.MiddleName,'')) as [Ф.И.О], (ISNULL(Citys.CityName,'')+ISNULL(' '+Streets.StreetName,'')+ISNULL(' д.'+Clients.House,'')+ISNULL(' к.'+Clients.Building,'')+ISNULL(' кв.'+Clients.Room,'')) as [Адрес места жительства],  ISNULL(Clients.MobilPhone,'')+' '+MobileOperators.MobileOperatorName as [Мобильный телефон], Clients.HomePhone as [Домашний телефон],  ClientCategorys.ClientCategoryName as [Категория клиента] FROM Clients  LEFT JOIN Citys ON  Clients.City=Citys.ID  LEFT JOIN Streets ON Clients.Street= Streets.ID LEFT JOIN MobileOperators ON Clients.MobileOperator=MobileOperators.ID LEFT JOIN ClientCategorys ON Clients.ClientCategory=ClientCategorys.ID", Static.Con);
            //Adap.Fill(Tabl);
            //dataGridView1.DataSource = Tabl;

            DataTable TablCl = new DataTable();
            SqlDataAdapter AdapCL = new SqlDataAdapter("SELECT Clients.ID, (ISNULL(Clients.Surname,'')+ISNULL(' '+Clients.Name,'')+ISNULL(' '+Clients.MiddleName,'')) as [Ф.И.О], (ISNULL(Citys.CityName,'')+ISNULL(' '+Streets.StreetName,'')+ISNULL(' д.'+Clients.House,'')+ISNULL(' к.'+Clients.Building,'')+ISNULL(' кв.'+Clients.Room,'')) as [Адрес места жительства],  ISNULL(Clients.MobilPhone,'')+' '+MobileOperators.MobileOperatorName as [Мобильный телефон], Clients.HomePhone as [Домашний телефон],  ClientCategorys.ClientCategoryName as [Категория клиента] FROM Clients  LEFT JOIN Citys ON  Clients.City=Citys.ID  LEFT JOIN Streets ON Clients.Street= Streets.ID LEFT JOIN MobileOperators ON Clients.MobileOperator=MobileOperators.ID LEFT JOIN ClientCategorys ON Clients.ClientCategory=ClientCategorys.ID", Static.Con);
            AdapCL.Fill(TablCl);
            DataView dvCl = new DataView(TablCl);
            dvCl.RowFilter = string.Format("[Ф.И.О] LIKE '%" + textBox1.Text + "%' or [Адрес места жительства] LIKE '%" + textBox1.Text + "%' ");
            dataGridView1.DataSource = dvCl;

        }


        private void Main_Load(object sender, EventArgs e)
        {
            ShowObjects();
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
            dataGridView1.ContextMenuStrip = contextMenuStrip2;
            ShowObjects();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            ShowClients();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ShowObjects();
        }


        public void addCl()
        {
            AddClient.ClientID = 0;
            AddClient AddCl = new AddClient();
            AddCl.ShowDialog();
            ShowClients();
        }

        public void edtCl()
        {
            AddClient.ClientID = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
            AddClient CLEtd = new AddClient();
            CLEtd.ShowDialog();
            ShowClients();
        }

        public void delCl()
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
                    ClientID = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                    DataTable Tabl = new DataTable();
                    string Zap = string.Format("DELETE from Clients where ID={0}", ClientID);
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

        private void дОБАВИТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCl();
        }

        private void иЗМЕНИТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edtCl();
        }

        private void уДАЛИТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delCl();
        }

        public void addObj()
        {
            AddObject.ObjectID = 0;
            AddObject.ClientID = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
            AddObject AddObj = new AddObject();
            AddObj.ShowDialog();
            ShowObjects();
        }

        public void edtObj()
        {
            EdtObject.ObjectID = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
            EdtObject ObjEtd = new EdtObject();
            ObjEtd.ShowDialog();
            ShowObjects();
        }

        public void delObj()
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
                    ObjectID = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                    DataTable Tabl = new DataTable();
                    string Zap = string.Format("DELETE from Objects where ID={0}", ObjectID);
                    SqlCommand cmd = new SqlCommand(Zap, Static.Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно удалена");
                    ShowObjects();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка удаления!");
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            edtObj();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            delObj();
        }





        private void дОБАВИТЬОБЪЕКТToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.ContextMenuStrip = contextMenuStrip2;
            addObj();
        }

        private void оБОРУДОВАНИЕToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddApp.LogStID = 0;
            AddApp.ObjectID = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
            AddApp AddAp = new AddApp();
            AddAp.ShowDialog();
            ShowObjects();
        }




    }
}
