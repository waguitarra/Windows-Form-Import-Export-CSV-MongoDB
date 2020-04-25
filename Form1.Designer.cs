namespace AppExcel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboBoxValor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTodosEnUm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPorcentual = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPorcentual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButtonValor = new System.Windows.Forms.RadioButton();
            this.radioButtonPrefix = new System.Windows.Forms.RadioButton();
            this.radioButtonDestination = new System.Windows.Forms.RadioButton();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.lblId_ = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxDeleteExcel = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnName = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(415, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(327, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(929, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(929, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prefix";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(929, 347);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(929, 386);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(929, 425);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(929, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(90, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 26);
            this.txtName.TabIndex = 12;
            // 
            // comboBoxValor
            // 
            this.comboBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxValor.FormattingEnabled = true;
            this.comboBoxValor.Items.AddRange(new object[] {
            "All",
            "3",
            "2",
            "1",
            "0.9",
            "0.09",
            "0.009"});
            this.comboBoxValor.Location = new System.Drawing.Point(647, 76);
            this.comboBoxValor.Name = "comboBoxValor";
            this.comboBoxValor.Size = new System.Drawing.Size(140, 28);
            this.comboBoxValor.TabIndex = 13;
            this.comboBoxValor.SelectedIndexChanged += new System.EventHandler(this.comboBoxValor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Menor que:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(733, 52);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(19, 20);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importCSVToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 29);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importCSVToolStripMenuItem
            // 
            this.importCSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarCSVToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.version11ToolStripMenuItem});
            this.importCSVToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importCSVToolStripMenuItem.Name = "importCSVToolStripMenuItem";
            this.importCSVToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.importCSVToolStripMenuItem.Text = "Menu";
            // 
            // exportarCSVToolStripMenuItem
            // 
            this.exportarCSVToolStripMenuItem.Name = "exportarCSVToolStripMenuItem";
            this.exportarCSVToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.exportarCSVToolStripMenuItem.Text = "IMPORTE CSV";
            this.exportarCSVToolStripMenuItem.Click += new System.EventHandler(this.exportarCSVToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // version11ToolStripMenuItem
            // 
            this.version11ToolStripMenuItem.Name = "version11ToolStripMenuItem";
            this.version11ToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.version11ToolStripMenuItem.Text = "Version 1.1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(818, 79);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 25);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total";
            // 
            // btnTodosEnUm
            // 
            this.btnTodosEnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosEnUm.Location = new System.Drawing.Point(9, 40);
            this.btnTodosEnUm.Name = "btnTodosEnUm";
            this.btnTodosEnUm.Size = new System.Drawing.Size(75, 66);
            this.btnTodosEnUm.TabIndex = 18;
            this.btnTodosEnUm.Text = "1 por:";
            this.btnTodosEnUm.UseVisualStyleBackColor = true;
            this.btnTodosEnUm.Click += new System.EventHandler(this.btnTodosEnUm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1119, 544);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.btnPorcentual);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtPorcentual);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.radioButtonValor);
            this.tabPage1.Controls.Add(this.radioButtonPrefix);
            this.tabPage1.Controls.Add(this.radioButtonDestination);
            this.tabPage1.Controls.Add(this.btnDesc);
            this.tabPage1.Controls.Add(this.btnOrdenar);
            this.tabPage1.Controls.Add(this.btnDeleteItem);
            this.tabPage1.Controls.Add(this.lblId_);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1111, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnPorcentual
            // 
            this.btnPorcentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentual.Location = new System.Drawing.Point(935, 78);
            this.btnPorcentual.Name = "btnPorcentual";
            this.btnPorcentual.Size = new System.Drawing.Size(151, 29);
            this.btnPorcentual.TabIndex = 32;
            this.btnPorcentual.Text = "Calcular";
            this.btnPorcentual.UseVisualStyleBackColor = true;
            this.btnPorcentual.Click += new System.EventHandler(this.btnPorcentual_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(947, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Valor por %";
            // 
            // txtPorcentual
            // 
            this.txtPorcentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentual.Location = new System.Drawing.Point(986, 46);
            this.txtPorcentual.Name = "txtPorcentual";
            this.txtPorcentual.Size = new System.Drawing.Size(46, 31);
            this.txtPorcentual.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(932, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Filtro";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(930, 270);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 28;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // radioButtonValor
            // 
            this.radioButtonValor.AutoSize = true;
            this.radioButtonValor.Location = new System.Drawing.Point(952, 188);
            this.radioButtonValor.Name = "radioButtonValor";
            this.radioButtonValor.Size = new System.Drawing.Size(49, 17);
            this.radioButtonValor.TabIndex = 25;
            this.radioButtonValor.TabStop = true;
            this.radioButtonValor.Text = "Valor";
            this.radioButtonValor.UseVisualStyleBackColor = true;
            this.radioButtonValor.CheckedChanged += new System.EventHandler(this.radioButtonValor_CheckedChanged);
            // 
            // radioButtonPrefix
            // 
            this.radioButtonPrefix.AutoSize = true;
            this.radioButtonPrefix.Location = new System.Drawing.Point(952, 165);
            this.radioButtonPrefix.Name = "radioButtonPrefix";
            this.radioButtonPrefix.Size = new System.Drawing.Size(51, 17);
            this.radioButtonPrefix.TabIndex = 24;
            this.radioButtonPrefix.TabStop = true;
            this.radioButtonPrefix.Text = "Prefix";
            this.radioButtonPrefix.UseVisualStyleBackColor = true;
            this.radioButtonPrefix.CheckedChanged += new System.EventHandler(this.radioButtonPrefix_CheckedChanged);
            // 
            // radioButtonDestination
            // 
            this.radioButtonDestination.AutoSize = true;
            this.radioButtonDestination.Location = new System.Drawing.Point(952, 142);
            this.radioButtonDestination.Name = "radioButtonDestination";
            this.radioButtonDestination.Size = new System.Drawing.Size(78, 17);
            this.radioButtonDestination.TabIndex = 21;
            this.radioButtonDestination.TabStop = true;
            this.radioButtonDestination.Text = "Destination";
            this.radioButtonDestination.UseVisualStyleBackColor = true;
            this.radioButtonDestination.CheckedChanged += new System.EventHandler(this.radioButtonDestination_CheckedChanged);
            // 
            // btnDesc
            // 
            this.btnDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesc.Location = new System.Drawing.Point(1005, 217);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(65, 31);
            this.btnDesc.TabIndex = 23;
            this.btnDesc.Text = "DESC";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(935, 217);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(65, 31);
            this.btnOrdenar.TabIndex = 22;
            this.btnOrdenar.Text = "ASC";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(972, 456);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 29);
            this.btnDeleteItem.TabIndex = 21;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // lblId_
            // 
            this.lblId_.AutoSize = true;
            this.lblId_.Location = new System.Drawing.Point(933, 315);
            this.lblId_.Name = "lblId_";
            this.lblId_.Size = new System.Drawing.Size(0, 13);
            this.lblId_.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(898, 480);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.comboBoxDeleteExcel);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1111, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // comboBoxDeleteExcel
            // 
            this.comboBoxDeleteExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDeleteExcel.FormattingEnabled = true;
            this.comboBoxDeleteExcel.Location = new System.Drawing.Point(188, 50);
            this.comboBoxDeleteExcel.Name = "comboBoxDeleteExcel";
            this.comboBoxDeleteExcel.Size = new System.Drawing.Size(219, 28);
            this.comboBoxDeleteExcel.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(413, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Busca por:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Busca por selecion:";
            // 
            // btnName
            // 
            this.btnName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnName.BackgroundImage")));
            this.btnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.Location = new System.Drawing.Point(1017, 29);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(95, 87);
            this.btnName.TabIndex = 21;
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 714);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnTodosEnUm);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxValor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "App Excel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboBoxValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarCSVToolStripMenuItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnTodosEnUm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDeleteExcel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version11ToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label lblId_;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton radioButtonValor;
        private System.Windows.Forms.RadioButton radioButtonPrefix;
        private System.Windows.Forms.RadioButton radioButtonDestination;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPorcentual;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtPorcentual;
        private System.Windows.Forms.Button btnName;
    }
}

