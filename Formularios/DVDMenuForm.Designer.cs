namespace ProyectoIUJO
{
    partial class DVDMenuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DVDMenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codeText = new Guna.UI2.WinForms.Guna2TextBox();
            this.tituloText = new Guna.UI2.WinForms.Guna2TextBox();
            this.emisionDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ingresoDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tipoText = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descripcionText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cantidadText = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.prestamoYes = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2CustomRadioButton2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.prestamoNo = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emisión = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.imgBtn = new Guna.UI2.WinForms.Guna2Button();
            this.registrarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.consultarBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.consultarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(396, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // codeText
            // 
            this.codeText.Animated = true;
            this.codeText.AutoRoundedCorners = true;
            this.codeText.BorderRadius = 11;
            this.codeText.BorderThickness = 0;
            this.codeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeText.DefaultText = "";
            this.codeText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.codeText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.codeText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codeText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeText.Location = new System.Drawing.Point(103, 20);
            this.codeText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codeText.Name = "codeText";
            this.codeText.PasswordChar = '\0';
            this.codeText.PlaceholderText = "";
            this.codeText.SelectedText = "";
            this.codeText.Size = new System.Drawing.Size(262, 25);
            this.codeText.TabIndex = 3;
            // 
            // tituloText
            // 
            this.tituloText.Animated = true;
            this.tituloText.AutoRoundedCorners = true;
            this.tituloText.BorderRadius = 11;
            this.tituloText.BorderThickness = 0;
            this.tituloText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tituloText.DefaultText = "";
            this.tituloText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tituloText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tituloText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tituloText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tituloText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tituloText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tituloText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tituloText.Location = new System.Drawing.Point(462, 20);
            this.tituloText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tituloText.Name = "tituloText";
            this.tituloText.PasswordChar = '\0';
            this.tituloText.PlaceholderText = "";
            this.tituloText.SelectedText = "";
            this.tituloText.Size = new System.Drawing.Size(150, 25);
            this.tituloText.TabIndex = 4;
            // 
            // emisionDate
            // 
            this.emisionDate.Animated = true;
            this.emisionDate.AutoRoundedCorners = true;
            this.emisionDate.BackColor = System.Drawing.Color.Transparent;
            this.emisionDate.BorderRadius = 13;
            this.emisionDate.Checked = true;
            this.emisionDate.FillColor = System.Drawing.Color.White;
            this.emisionDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emisionDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.emisionDate.Location = new System.Drawing.Point(103, 66);
            this.emisionDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emisionDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.emisionDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.emisionDate.Name = "emisionDate";
            this.emisionDate.Size = new System.Drawing.Size(270, 29);
            this.emisionDate.TabIndex = 6;
            this.emisionDate.Value = new System.DateTime(2023, 5, 21, 14, 49, 22, 687);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Emisión:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingreso:";
            // 
            // ingresoDate
            // 
            this.ingresoDate.Animated = true;
            this.ingresoDate.AutoRoundedCorners = true;
            this.ingresoDate.BackColor = System.Drawing.Color.Transparent;
            this.ingresoDate.BorderRadius = 13;
            this.ingresoDate.Checked = true;
            this.ingresoDate.FillColor = System.Drawing.Color.White;
            this.ingresoDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ingresoDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ingresoDate.Location = new System.Drawing.Point(103, 110);
            this.ingresoDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingresoDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ingresoDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ingresoDate.Name = "ingresoDate";
            this.ingresoDate.Size = new System.Drawing.Size(270, 29);
            this.ingresoDate.TabIndex = 9;
            this.ingresoDate.Value = new System.DateTime(2023, 5, 21, 14, 49, 22, 687);
            // 
            // tipoText
            // 
            this.tipoText.BackColor = System.Drawing.Color.Transparent;
            this.tipoText.BorderRadius = 14;
            this.tipoText.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tipoText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoText.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tipoText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tipoText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tipoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tipoText.ItemHeight = 30;
            this.tipoText.Items.AddRange(new object[] {
            "Película",
            "Juego",
            "MP3"});
            this.tipoText.Location = new System.Drawing.Point(469, 66);
            this.tipoText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoText.Name = "tipoText";
            this.tipoText.Size = new System.Drawing.Size(178, 36);
            this.tipoText.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(407, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo:";
            // 
            // descripcionText
            // 
            this.descripcionText.Animated = true;
            this.descripcionText.AutoCompleteCustomSource.AddRange(new string[] {
            "k",
            "k",
            "kk",
            "",
            "k",
            "",
            "k",
            "k"});
            this.descripcionText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.descripcionText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.descripcionText.BorderRadius = 14;
            this.descripcionText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descripcionText.DefaultText = "";
            this.descripcionText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descripcionText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descripcionText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descripcionText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descripcionText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descripcionText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descripcionText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descripcionText.Location = new System.Drawing.Point(135, 162);
            this.descripcionText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.PasswordChar = '\0';
            this.descripcionText.PlaceholderText = "";
            this.descripcionText.SelectedText = "";
            this.descripcionText.Size = new System.Drawing.Size(230, 26);
            this.descripcionText.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descripción:";
            // 
            // cantidadText
            // 
            this.cantidadText.BackColor = System.Drawing.Color.Transparent;
            this.cantidadText.BorderRadius = 14;
            this.cantidadText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cantidadText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cantidadText.Location = new System.Drawing.Point(494, 113);
            this.cantidadText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidadText.Name = "cantidadText";
            this.cantidadText.Size = new System.Drawing.Size(128, 26);
            this.cantidadText.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(393, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad:";
            // 
            // prestamoYes
            // 
            this.prestamoYes.Animated = true;
            this.prestamoYes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prestamoYes.CheckedState.BorderThickness = 0;
            this.prestamoYes.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.prestamoYes.CheckedState.InnerColor = System.Drawing.Color.White;
            this.prestamoYes.Location = new System.Drawing.Point(512, 169);
            this.prestamoYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prestamoYes.Name = "prestamoYes";
            this.prestamoYes.ShadowDecoration.BorderRadius = 5;
            this.prestamoYes.Size = new System.Drawing.Size(23, 17);
            this.prestamoYes.TabIndex = 16;
            this.prestamoYes.Text = "guna2CustomRadioButton1";
            this.prestamoYes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.prestamoYes.UncheckedState.BorderThickness = 2;
            this.prestamoYes.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.prestamoYes.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.prestamoYes.CheckedChanged += new System.EventHandler(this.prestamoYes_CheckedChanged);
            // 
            // guna2CustomRadioButton2
            // 
            this.guna2CustomRadioButton2.Animated = true;
            this.guna2CustomRadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomRadioButton2.CheckedState.BorderThickness = 0;
            this.guna2CustomRadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomRadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2CustomRadioButton2.Location = new System.Drawing.Point(551, 169);
            this.guna2CustomRadioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CustomRadioButton2.Name = "guna2CustomRadioButton2";
            this.guna2CustomRadioButton2.ShadowDecoration.BorderRadius = 5;
            this.guna2CustomRadioButton2.Size = new System.Drawing.Size(23, 17);
            this.guna2CustomRadioButton2.TabIndex = 17;
            this.guna2CustomRadioButton2.Text = "guna2CustomRadioButton2";
            this.guna2CustomRadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.guna2CustomRadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2CustomRadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomRadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // prestamoNo
            // 
            this.prestamoNo.Animated = true;
            this.prestamoNo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prestamoNo.CheckedState.BorderThickness = 0;
            this.prestamoNo.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.prestamoNo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.prestamoNo.Location = new System.Drawing.Point(562, 169);
            this.prestamoNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prestamoNo.Name = "prestamoNo";
            this.prestamoNo.ShadowDecoration.BorderRadius = 5;
            this.prestamoNo.Size = new System.Drawing.Size(23, 17);
            this.prestamoNo.TabIndex = 18;
            this.prestamoNo.Text = "guna2CustomRadioButton3";
            this.prestamoNo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.prestamoNo.UncheckedState.BorderThickness = 2;
            this.prestamoNo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.prestamoNo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(393, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "Prestamo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI Semilight", 8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(495, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Sí";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI Semilight", 8F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(540, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "No";
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
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            this.Código,
            this.Título,
            this.Emisión,
            this.Tipo,
            this.Cantidad,
            this.Ingreso,
            this.Prestamo,
            this.Imagen,
            this.Descripción});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.Location = new System.Drawing.Point(11, 205);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.dataGrid.Size = new System.Drawing.Size(464, 270);
            this.dataGrid.TabIndex = 22;
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
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 8;
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 90;
            // 
            // Título
            // 
            this.Título.HeaderText = "Título";
            this.Título.MinimumWidth = 8;
            this.Título.Name = "Título";
            this.Título.ReadOnly = true;
            this.Título.Width = 79;
            // 
            // Emisión
            // 
            this.Emisión.HeaderText = "Emisión";
            this.Emisión.MinimumWidth = 8;
            this.Emisión.Name = "Emisión";
            this.Emisión.ReadOnly = true;
            this.Emisión.Width = 95;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 8;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 69;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 104;
            // 
            // Ingreso
            // 
            this.Ingreso.HeaderText = "Ingreso";
            this.Ingreso.MinimumWidth = 8;
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.ReadOnly = true;
            this.Ingreso.Width = 93;
            // 
            // Prestamo
            // 
            this.Prestamo.HeaderText = "Prestamo";
            this.Prestamo.MinimumWidth = 8;
            this.Prestamo.Name = "Prestamo";
            this.Prestamo.ReadOnly = true;
            this.Prestamo.Width = 108;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.MinimumWidth = 8;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Width = 71;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 8;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(535, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Imagen";
            // 
            // imgBtn
            // 
            this.imgBtn.Animated = true;
            this.imgBtn.BackColor = System.Drawing.Color.Transparent;
            this.imgBtn.BorderRadius = 7;
            this.imgBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.imgBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.imgBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.imgBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.imgBtn.FillColor = System.Drawing.Color.White;
            this.imgBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgBtn.ForeColor = System.Drawing.Color.Black;
            this.imgBtn.ImageSize = new System.Drawing.Size(183, 148);
            this.imgBtn.Location = new System.Drawing.Point(494, 205);
            this.imgBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgBtn.Name = "imgBtn";
            this.imgBtn.Size = new System.Drawing.Size(163, 118);
            this.imgBtn.TabIndex = 25;
            this.imgBtn.Text = "+";
            this.imgBtn.Click += new System.EventHandler(this.imgBtn_Click);
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
            this.registrarBtn.Location = new System.Drawing.Point(499, 438);
            this.registrarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registrarBtn.Name = "registrarBtn";
            this.registrarBtn.Size = new System.Drawing.Size(160, 36);
            this.registrarBtn.TabIndex = 26;
            this.registrarBtn.Text = "Registrar";
            this.registrarBtn.Click += new System.EventHandler(this.registrarBtn_Click);
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
            this.updateBtn.Location = new System.Drawing.Point(499, 357);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(160, 36);
            this.updateBtn.TabIndex = 27;
            this.updateBtn.Text = "Actualizar";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.consultarBox.Location = new System.Drawing.Point(540, 406);
            this.consultarBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consultarBox.Name = "consultarBox";
            this.consultarBox.PasswordChar = '\0';
            this.consultarBox.PlaceholderText = "";
            this.consultarBox.SelectedText = "";
            this.consultarBox.Size = new System.Drawing.Size(118, 26);
            this.consultarBox.TabIndex = 30;
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
            this.consultarBtn.Location = new System.Drawing.Point(499, 402);
            this.consultarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consultarBtn.Name = "consultarBtn";
            this.consultarBtn.Size = new System.Drawing.Size(36, 32);
            this.consultarBtn.TabIndex = 29;
            this.consultarBtn.Click += new System.EventHandler(this.consultarBtn_Click);
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
            this.DeleteBtn.Location = new System.Drawing.Point(620, 159);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(39, 29);
            this.DeleteBtn.TabIndex = 28;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DVDMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(717, 484);
            this.Controls.Add(this.consultarBox);
            this.Controls.Add(this.consultarBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.registrarBtn);
            this.Controls.Add(this.imgBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.prestamoYes);
            this.Controls.Add(this.prestamoNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2CustomRadioButton2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cantidadText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.descripcionText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tipoText);
            this.Controls.Add(this.ingresoDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emisionDate);
            this.Controls.Add(this.tituloText);
            this.Controls.Add(this.codeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DVDMenuForm";
            this.Load += new System.EventHandler(this.DVDMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox codeText;
        private Guna.UI2.WinForms.Guna2TextBox tituloText;
        private Guna.UI2.WinForms.Guna2DateTimePicker emisionDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker ingresoDate;
        private Guna.UI2.WinForms.Guna2ComboBox tipoText;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox descripcionText;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2NumericUpDown cantidadText;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CustomRadioButton prestamoYes;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton prestamoNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button imgBtn;
        private Guna.UI2.WinForms.Guna2Button registrarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emisión;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button consultarBtn;
        private Guna.UI2.WinForms.Guna2TextBox consultarBox;
    }
}