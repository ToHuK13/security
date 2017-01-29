namespace security
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lIGDataSet = new security.LIGDataSet();
            this.userPrivilegesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userPrivilegesTableAdapter = new security.LIGDataSetTableAdapters.UserPrivilegesTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.дОБАВИТЬToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иЗМЕНИТЬToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уДАЛИТЬToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зАЯВЛЕНИЕToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нАПОДКЛЮЧЕНИЕToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нАМОНТАЖToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оТКАЗОТБЛОКРОВКИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPrivilegesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(50, 103);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(15, 10);
            this.dataGridView2.TabIndex = 1;
            // 
            // lIGDataSet
            // 
            this.lIGDataSet.DataSetName = "LIGDataSet";
            this.lIGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userPrivilegesBindingSource
            // 
            this.userPrivilegesBindingSource.DataMember = "UserPrivileges";
            this.userPrivilegesBindingSource.DataSource = this.lIGDataSet;
            // 
            // userPrivilegesTableAdapter
            // 
            this.userPrivilegesTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 58);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(616, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 53);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Left;
            this.button8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(325, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 58);
            this.button8.TabIndex = 7;
            this.button8.Text = " УДАЛИТЬ ОБЪЕКТ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Left;
            this.button7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(223, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 58);
            this.button7.TabIndex = 6;
            this.button7.Text = "РЕДАКТИРОВАТЬ ОБЪЕКТ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Left;
            this.button6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(146, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 58);
            this.button6.TabIndex = 5;
            this.button6.Text = " ДОБАВИТЬ ОБЪЕКТ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(77, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "ОБЪЕКТЫ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "ЗАКАЗЧИКИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 69);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 327);
            this.panel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(803, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дОБАВИТЬToolStripMenuItem,
            this.иЗМЕНИТЬToolStripMenuItem,
            this.уДАЛИТЬToolStripMenuItem,
            this.зАЯВЛЕНИЕToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 92);
            // 
            // дОБАВИТЬToolStripMenuItem
            // 
            this.дОБАВИТЬToolStripMenuItem.Name = "дОБАВИТЬToolStripMenuItem";
            this.дОБАВИТЬToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.дОБАВИТЬToolStripMenuItem.Text = "ДОБАВИТЬ";
            this.дОБАВИТЬToolStripMenuItem.Click += new System.EventHandler(this.дОБАВИТЬToolStripMenuItem_Click);
            // 
            // иЗМЕНИТЬToolStripMenuItem
            // 
            this.иЗМЕНИТЬToolStripMenuItem.Name = "иЗМЕНИТЬToolStripMenuItem";
            this.иЗМЕНИТЬToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.иЗМЕНИТЬToolStripMenuItem.Text = "ИЗМЕНИТЬ";
            this.иЗМЕНИТЬToolStripMenuItem.Click += new System.EventHandler(this.иЗМЕНИТЬToolStripMenuItem_Click);
            // 
            // уДАЛИТЬToolStripMenuItem
            // 
            this.уДАЛИТЬToolStripMenuItem.Name = "уДАЛИТЬToolStripMenuItem";
            this.уДАЛИТЬToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.уДАЛИТЬToolStripMenuItem.Text = "УДАЛИТЬ";
            this.уДАЛИТЬToolStripMenuItem.Click += new System.EventHandler(this.уДАЛИТЬToolStripMenuItem_Click);
            // 
            // зАЯВЛЕНИЕToolStripMenuItem
            // 
            this.зАЯВЛЕНИЕToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нАПОДКЛЮЧЕНИЕToolStripMenuItem,
            this.нАМОНТАЖToolStripMenuItem,
            this.нАToolStripMenuItem,
            this.оТКАЗОТБЛОКРОВКИToolStripMenuItem});
            this.зАЯВЛЕНИЕToolStripMenuItem.Name = "зАЯВЛЕНИЕToolStripMenuItem";
            this.зАЯВЛЕНИЕToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.зАЯВЛЕНИЕToolStripMenuItem.Text = "ЗАЯВЛЕНИЯ";
            // 
            // нАПОДКЛЮЧЕНИЕToolStripMenuItem
            // 
            this.нАПОДКЛЮЧЕНИЕToolStripMenuItem.Name = "нАПОДКЛЮЧЕНИЕToolStripMenuItem";
            this.нАПОДКЛЮЧЕНИЕToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.нАПОДКЛЮЧЕНИЕToolStripMenuItem.Text = "ПОДКЛЮЧЕНИЕ";
            // 
            // нАМОНТАЖToolStripMenuItem
            // 
            this.нАМОНТАЖToolStripMenuItem.Name = "нАМОНТАЖToolStripMenuItem";
            this.нАМОНТАЖToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.нАМОНТАЖToolStripMenuItem.Text = "МОНТАЖ";
            // 
            // нАToolStripMenuItem
            // 
            this.нАToolStripMenuItem.Name = "нАToolStripMenuItem";
            this.нАToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.нАToolStripMenuItem.Text = "РАССРОЧКА";
            // 
            // оТКАЗОТБЛОКРОВКИToolStripMenuItem
            // 
            this.оТКАЗОТБЛОКРОВКИToolStripMenuItem.Name = "оТКАЗОТБЛОКРОВКИToolStripMenuItem";
            this.оТКАЗОТБЛОКРОВКИToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.оТКАЗОТБЛОКРОВКИToolStripMenuItem.Text = "ОТКАЗ ОТ БЛОКРОВКИ";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личное имущество граждан";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPrivilegesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private LIGDataSet lIGDataSet;
        private System.Windows.Forms.BindingSource userPrivilegesBindingSource;
        private LIGDataSetTableAdapters.UserPrivilegesTableAdapter userPrivilegesTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem дОБАВИТЬToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иЗМЕНИТЬToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уДАЛИТЬToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зАЯВЛЕНИЕToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нАПОДКЛЮЧЕНИЕToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нАМОНТАЖToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оТКАЗОТБЛОКРОВКИToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}