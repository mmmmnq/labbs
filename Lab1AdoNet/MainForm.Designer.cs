namespace Lab1AdoNet
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePhones = new System.Windows.Forms.TabPage();
            this.buttonSaveAgents = new System.Windows.Forms.Button();
            this.dataGridViewAgents = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPagOrders = new System.Windows.Forms.TabPage();
            this.buttonSaveDeals = new System.Windows.Forms.Button();
            this.dataGridViewDeals = new System.Windows.Forms.DataGridView();
            this.tabPageQuery = new System.Windows.Forms.TabPage();
            this.dataGridViewReport1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGetReport1 = new System.Windows.Forms.Button();
            this.comboBoxReport1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSP = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonReport2 = new System.Windows.Forms.Button();
            this.dataGridViewReport2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPagePhones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgents)).BeginInit();
            this.tabPagOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeals)).BeginInit();
            this.tabPageQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePhones);
            this.tabControl1.Controls.Add(this.tabPagOrders);
            this.tabControl1.Controls.Add(this.tabPageQuery);
            this.tabControl1.Controls.Add(this.tabPageSP);
            this.tabControl1.Location = new System.Drawing.Point(-1, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePhones
            // 
            this.tabPagePhones.Controls.Add(this.buttonSaveAgents);
            this.tabPagePhones.Controls.Add(this.dataGridViewAgents);
            this.tabPagePhones.Location = new System.Drawing.Point(4, 25);
            this.tabPagePhones.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePhones.Name = "tabPagePhones";
            this.tabPagePhones.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePhones.Size = new System.Drawing.Size(1044, 517);
            this.tabPagePhones.TabIndex = 0;
            this.tabPagePhones.Text = "Агенты";
            this.tabPagePhones.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAgents
            // 
            this.buttonSaveAgents.Location = new System.Drawing.Point(8, 7);
            this.buttonSaveAgents.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveAgents.Name = "buttonSaveAgents";
            this.buttonSaveAgents.Size = new System.Drawing.Size(217, 28);
            this.buttonSaveAgents.TabIndex = 1;
            this.buttonSaveAgents.Text = "Сохранить изменения";
            this.buttonSaveAgents.UseVisualStyleBackColor = true;
            this.buttonSaveAgents.Click += new System.EventHandler(this.buttonSavePhone_Click);
            // 
            // dataGridViewAgents
            // 
            this.dataGridViewAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.bonus});
            this.dataGridViewAgents.Location = new System.Drawing.Point(0, 42);
            this.dataGridViewAgents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAgents.Name = "dataGridViewAgents";
            this.dataGridViewAgents.RowHeadersWidth = 51;
            this.dataGridViewAgents.Size = new System.Drawing.Size(1037, 469);
            this.dataGridViewAgents.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "agent_id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "deal_count";
            this.name.HeaderText = "deal count";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // bonus
            // 
            this.bonus.DataPropertyName = "bonus_count";
            this.bonus.HeaderText = "bonus count";
            this.bonus.MinimumWidth = 6;
            this.bonus.Name = "bonus";
            this.bonus.Width = 125;
            // 
            // tabPagOrders
            // 
            this.tabPagOrders.Controls.Add(this.buttonSaveDeals);
            this.tabPagOrders.Controls.Add(this.dataGridViewDeals);
            this.tabPagOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPagOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagOrders.Name = "tabPagOrders";
            this.tabPagOrders.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagOrders.Size = new System.Drawing.Size(1044, 517);
            this.tabPagOrders.TabIndex = 1;
            this.tabPagOrders.Text = "Продажи";
            this.tabPagOrders.UseVisualStyleBackColor = true;
            // 
            // buttonSaveDeals
            // 
            this.buttonSaveDeals.Location = new System.Drawing.Point(12, 9);
            this.buttonSaveDeals.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveDeals.Name = "buttonSaveDeals";
            this.buttonSaveDeals.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveDeals.TabIndex = 1;
            this.buttonSaveDeals.Text = "Сохранить";
            this.buttonSaveDeals.UseVisualStyleBackColor = true;
            this.buttonSaveDeals.Click += new System.EventHandler(this.buttonSaveOrders_Click);
            // 
            // dataGridViewDeals
            // 
            this.dataGridViewDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeals.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewDeals.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDeals.Name = "dataGridViewDeals";
            this.dataGridViewDeals.RowHeadersWidth = 51;
            this.dataGridViewDeals.Size = new System.Drawing.Size(1037, 514);
            this.dataGridViewDeals.TabIndex = 0;
            // 
            // tabPageQuery
            // 
            this.tabPageQuery.Controls.Add(this.dataGridViewReport1);
            this.tabPageQuery.Controls.Add(this.groupBox1);
            this.tabPageQuery.Location = new System.Drawing.Point(4, 25);
            this.tabPageQuery.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageQuery.Size = new System.Drawing.Size(1044, 517);
            this.tabPageQuery.TabIndex = 2;
            this.tabPageQuery.Text = "Отчет1";
            this.tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReport1
            // 
            this.dataGridViewReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridViewReport1.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewReport1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReport1.Name = "dataGridViewReport1";
            this.dataGridViewReport1.RowHeadersWidth = 51;
            this.dataGridViewReport1.Size = new System.Drawing.Size(865, 400);
            this.dataGridViewReport1.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "deal_date";
            this.Column2.HeaderText = "Время продажи";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "deal_pay";
            this.Column3.HeaderText = "Стоимость";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "client_name";
            this.Column5.HeaderText = "Имя клиентта";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "estate_address";
            this.Column4.HeaderText = "Адрес ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGetReport1);
            this.groupBox1.Controls.Add(this.comboBoxReport1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(865, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonGetReport1
            // 
            this.buttonGetReport1.Location = new System.Drawing.Point(563, 25);
            this.buttonGetReport1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetReport1.Name = "buttonGetReport1";
            this.buttonGetReport1.Size = new System.Drawing.Size(100, 28);
            this.buttonGetReport1.TabIndex = 2;
            this.buttonGetReport1.Text = "Найти";
            this.buttonGetReport1.UseVisualStyleBackColor = true;
            this.buttonGetReport1.Click += new System.EventHandler(this.buttonGetReport1_Click);
            // 
            // comboBoxReport1
            // 
            this.comboBoxReport1.FormattingEnabled = true;
            this.comboBoxReport1.Location = new System.Drawing.Point(149, 21);
            this.comboBoxReport1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxReport1.Name = "comboBoxReport1";
            this.comboBoxReport1.Size = new System.Drawing.Size(356, 24);
            this.comboBoxReport1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адресс";
            // 
            // tabPageSP
            // 
            this.tabPageSP.Controls.Add(this.numericUpDown2);
            this.tabPageSP.Controls.Add(this.numericUpDown1);
            this.tabPageSP.Controls.Add(this.buttonReport2);
            this.tabPageSP.Controls.Add(this.dataGridViewReport2);
            this.tabPageSP.Controls.Add(this.label3);
            this.tabPageSP.Controls.Add(this.label2);
            this.tabPageSP.Location = new System.Drawing.Point(4, 25);
            this.tabPageSP.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSP.Name = "tabPageSP";
            this.tabPageSP.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSP.Size = new System.Drawing.Size(1044, 517);
            this.tabPageSP.TabIndex = 3;
            this.tabPageSP.Text = "Отчет2";
            this.tabPageSP.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(409, 16);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(172, 18);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonReport2
            // 
            this.buttonReport2.Location = new System.Drawing.Point(611, 12);
            this.buttonReport2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReport2.Name = "buttonReport2";
            this.buttonReport2.Size = new System.Drawing.Size(119, 28);
            this.buttonReport2.TabIndex = 4;
            this.buttonReport2.Text = "Найти";
            this.buttonReport2.UseVisualStyleBackColor = true;
            this.buttonReport2.Click += new System.EventHandler(this.buttonReport2_Click);
            // 
            // dataGridViewReport2
            // 
            this.dataGridViewReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport2.Location = new System.Drawing.Point(16, 55);
            this.dataGridViewReport2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReport2.Name = "dataGridViewReport2";
            this.dataGridViewReport2.RowHeadersWidth = 51;
            this.dataGridViewReport2.Size = new System.Drawing.Size(713, 455);
            this.dataGridViewReport2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Месяц";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePhones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgents)).EndInit();
            this.tabPagOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeals)).EndInit();
            this.tabPageQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSP.ResumeLayout(false);
            this.tabPageSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePhones;
        private System.Windows.Forms.TabPage tabPagOrders;
        private System.Windows.Forms.DataGridView dataGridViewDeals;
        private System.Windows.Forms.Button buttonSaveAgents;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSP;
        private System.Windows.Forms.ComboBox comboBoxReport1;
        private System.Windows.Forms.DataGridView dataGridViewReport1;
        private System.Windows.Forms.Button buttonGetReport1;
        private System.Windows.Forms.Button buttonReport2;
        private System.Windows.Forms.DataGridView dataGridViewReport2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonSaveDeals;
        private System.Windows.Forms.DataGridView dataGridViewAgents;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

