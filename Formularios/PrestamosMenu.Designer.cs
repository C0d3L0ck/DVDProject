namespace ProyectoIUJO.Formularios
{
    partial class PrestamosMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestamosMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cantidadBox = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.registrarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Días = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolaresC = new System.Windows.Forms.Label();
            this.diasDecimal = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.tituloBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.inventarioValue = new System.Windows.Forms.Label();
            this.clienteBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.menosBtn = new Guna.UI2.WinForms.Guna2Button();
            this.masBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.consultarBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.consultarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadBox
            // 
            this.cantidadBox.BackColor = System.Drawing.Color.Transparent;
            this.cantidadBox.BorderRadius = 14;
            this.cantidadBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cantidadBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cantidadBox.Location = new System.Drawing.Point(585, 21);
            this.cantidadBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cantidadBox.Name = "cantidadBox";
            this.cantidadBox.Size = new System.Drawing.Size(143, 35);
            this.cantidadBox.TabIndex = 1;
            this.cantidadBox.ValueChanged += new System.EventHandler(this.cantidadBox_ValueChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Animated = true;
            this.DeleteBtn.BorderRadius = 10;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.DeleteBtn.Location = new System.Drawing.Point(684, 257);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(44, 36);
            this.DeleteBtn.TabIndex = 31;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Animated = true;
            this.updateBtn.BorderRadius = 10;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(490, 248);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(180, 45);
            this.updateBtn.TabIndex = 30;
            this.updateBtn.Text = "Actualizar";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // registrarBtn
            // 
            this.registrarBtn.Animated = true;
            this.registrarBtn.BorderRadius = 10;
            this.registrarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registrarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registrarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registrarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registrarBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registrarBtn.ForeColor = System.Drawing.Color.White;
            this.registrarBtn.Location = new System.Drawing.Point(490, 197);
            this.registrarBtn.Name = "registrarBtn";
            this.registrarBtn.Size = new System.Drawing.Size(180, 45);
            this.registrarBtn.TabIndex = 29;
            this.registrarBtn.Text = "Registrar";
            this.registrarBtn.Click += new System.EventHandler(this.registrarBtn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGrid.ColumnHeadersHeight = 30;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Titulo,
            this.Cantidad,
            this.Días,
            this.Monto,
            this.Tipo});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.Location = new System.Drawing.Point(12, 308);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid.RowTemplate.Height = 30;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGrid.Size = new System.Drawing.Size(741, 281);
            this.dataGrid.TabIndex = 32;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGrid.ThemeStyle.ReadOnly = true;
            this.dataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid.ThemeStyle.RowsStyle.Height = 30;
            this.dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 8;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 8;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Días
            // 
            this.Días.HeaderText = "Días";
            this.Días.MinimumWidth = 8;
            this.Días.Name = "Días";
            this.Días.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 8;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 8;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // dolaresC
            // 
            this.dolaresC.AutoSize = true;
            this.dolaresC.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.dolaresC.ForeColor = System.Drawing.Color.White;
            this.dolaresC.Location = new System.Drawing.Point(151, 157);
            this.dolaresC.Name = "dolaresC";
            this.dolaresC.Size = new System.Drawing.Size(27, 32);
            this.dolaresC.TabIndex = 33;
            this.dolaresC.Text = "0";
            // 
            // diasDecimal
            // 
            this.diasDecimal.AutoSize = true;
            this.diasDecimal.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.diasDecimal.ForeColor = System.Drawing.Color.White;
            this.diasDecimal.Location = new System.Drawing.Point(623, 133);
            this.diasDecimal.Name = "diasDecimal";
            this.diasDecimal.Size = new System.Drawing.Size(27, 32);
            this.diasDecimal.TabIndex = 34;
            this.diasDecimal.Text = "0";
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.tipoLabel.ForeColor = System.Drawing.Color.White;
            this.tipoLabel.Location = new System.Drawing.Point(106, 210);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(0, 32);
            this.tipoLabel.TabIndex = 35;
            // 
            // tituloBox
            // 
            this.tituloBox.BackColor = System.Drawing.Color.Transparent;
            this.tituloBox.BorderRadius = 14;
            this.tituloBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tituloBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tituloBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tituloBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tituloBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tituloBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tituloBox.ItemHeight = 30;
            this.tituloBox.Location = new System.Drawing.Point(140, 72);
            this.tituloBox.Name = "tituloBox";
            this.tituloBox.Size = new System.Drawing.Size(198, 36);
            this.tituloBox.TabIndex = 37;
            this.tituloBox.SelectedIndexChanged += new System.EventHandler(this.tituloBox_SelectedIndexChanged);
            // 
            // inventarioValue
            // 
            this.inventarioValue.AutoSize = true;
            this.inventarioValue.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioValue.ForeColor = System.Drawing.Color.White;
            this.inventarioValue.Location = new System.Drawing.Point(648, 62);
            this.inventarioValue.Name = "inventarioValue";
            this.inventarioValue.Size = new System.Drawing.Size(22, 25);
            this.inventarioValue.TabIndex = 38;
            this.inventarioValue.Text = "0";
            // 
            // clienteBox
            // 
            this.clienteBox.BackColor = System.Drawing.Color.Transparent;
            this.clienteBox.BorderRadius = 14;
            this.clienteBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clienteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clienteBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clienteBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clienteBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.clienteBox.ItemHeight = 30;
            this.clienteBox.Location = new System.Drawing.Point(140, 21);
            this.clienteBox.Name = "clienteBox";
            this.clienteBox.Size = new System.Drawing.Size(198, 36);
            this.clienteBox.TabIndex = 39;
            // 
            // menosBtn
            // 
            this.menosBtn.Animated = true;
            this.menosBtn.BorderRadius = 10;
            this.menosBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menosBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menosBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menosBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menosBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menosBtn.ForeColor = System.Drawing.Color.White;
            this.menosBtn.Location = new System.Drawing.Point(551, 128);
            this.menosBtn.Name = "menosBtn";
            this.menosBtn.Size = new System.Drawing.Size(44, 45);
            this.menosBtn.TabIndex = 40;
            this.menosBtn.Text = "<";
            this.menosBtn.Click += new System.EventHandler(this.menosBtn_Click);
            // 
            // masBtn
            // 
            this.masBtn.Animated = true;
            this.masBtn.BorderRadius = 10;
            this.masBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.masBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.masBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.masBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.masBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.masBtn.ForeColor = System.Drawing.Color.White;
            this.masBtn.Location = new System.Drawing.Point(676, 128);
            this.masBtn.Name = "masBtn";
            this.masBtn.Size = new System.Drawing.Size(44, 45);
            this.masBtn.TabIndex = 41;
            this.masBtn.Text = ">";
            this.masBtn.Click += new System.EventHandler(this.masBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 32);
            this.label2.TabIndex = 43;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 44;
            this.label3.Text = "Monto: $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(545, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Inventario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 32);
            this.label5.TabIndex = 46;
            this.label5.Text = "Tipo:";
            // 
            // consultarBox
            // 
            this.consultarBox.Animated = true;
            this.consultarBox.AutoCompleteCustomSource.AddRange(new string[] {
            "k",
            "k",
            "kk",
            "",
            "k",
            "",
            "k",
            "k"});
            this.consultarBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.consultarBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.consultarBox.BorderRadius = 14;
            this.consultarBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.consultarBox.DefaultText = "";
            this.consultarBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.consultarBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.consultarBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.consultarBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.consultarBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.consultarBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.consultarBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.consultarBox.Location = new System.Drawing.Point(85, 267);
            this.consultarBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.consultarBox.Name = "consultarBox";
            this.consultarBox.PasswordChar = '\0';
            this.consultarBox.PlaceholderText = "";
            this.consultarBox.SelectedText = "";
            this.consultarBox.Size = new System.Drawing.Size(327, 33);
            this.consultarBox.TabIndex = 48;
            // 
            // consultarBtn
            // 
            this.consultarBtn.Animated = true;
            this.consultarBtn.BorderRadius = 10;
            this.consultarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.consultarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.consultarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.consultarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.consultarBtn.FillColor = System.Drawing.Color.White;
            this.consultarBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.consultarBtn.ForeColor = System.Drawing.Color.White;
            this.consultarBtn.Image = ((System.Drawing.Image)(resources.GetObject("consultarBtn.Image")));
            this.consultarBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.consultarBtn.Location = new System.Drawing.Point(38, 262);
            this.consultarBtn.Name = "consultarBtn";
            this.consultarBtn.Size = new System.Drawing.Size(41, 40);
            this.consultarBtn.TabIndex = 47;
            this.consultarBtn.Click += new System.EventHandler(this.consultarBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(482, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 32);
            this.label6.TabIndex = 49;
            this.label6.Text = "Días:";
            // 
            // PrestamosMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 605);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.consultarBox);
            this.Controls.Add(this.consultarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.masBtn);
            this.Controls.Add(this.menosBtn);
            this.Controls.Add(this.clienteBox);
            this.Controls.Add(this.inventarioValue);
            this.Controls.Add(this.tituloBox);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.diasDecimal);
            this.Controls.Add(this.dolaresC);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.registrarBtn);
            this.Controls.Add(this.cantidadBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrestamosMenu";
            this.Text = "PrestamosMenu";
            this.Load += new System.EventHandler(this.PrestamosMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown cantidadBox;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button registrarBtn;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Días;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Label dolaresC;
        private System.Windows.Forms.Label diasDecimal;
        private System.Windows.Forms.Label tipoLabel;
        private Guna.UI2.WinForms.Guna2ComboBox tituloBox;
        private System.Windows.Forms.Label inventarioValue;
        private Guna.UI2.WinForms.Guna2ComboBox clienteBox;
        private Guna.UI2.WinForms.Guna2Button menosBtn;
        private Guna.UI2.WinForms.Guna2Button masBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox consultarBox;
        private Guna.UI2.WinForms.Guna2Button consultarBtn;
        private System.Windows.Forms.Label label6;
    }
}