partial class Form1
{

    private void InitializeComponent()
    {
        dataGridViewUsuarios = new DataGridView();
        label1 = new Label();
        btnExportToCSV = new Button();
        adduserId = new TextBox();
        addLogin = new TextBox();
        addNombre = new TextBox();
        addPaterno = new TextBox();
        addMaterno = new TextBox();
        addSueldo = new TextBox();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        btnAddUser = new Button();
        label8 = new Label();
        textBox7 = new TextBox();
        textBox8 = new TextBox();
        button1 = new Button();
        label9 = new Label();
        bBuscar = new Button();
        dataG = new DataGridView();
        textBU = new TextBox();
        label10 = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataG).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewUsuarios
        // 
        dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewUsuarios.Location = new Point(22, 47);
        dataGridViewUsuarios.Name = "dataGridViewUsuarios";
        dataGridViewUsuarios.Size = new Size(630, 308);
        dataGridViewUsuarios.TabIndex = 1;
        // 
        // label1
        // 
        label1.AccessibleRole = AccessibleRole.MenuBar;
        label1.AutoSize = true;
        label1.Enabled = false;
        label1.Location = new Point(34, 11);
        label1.Name = "label1";
        label1.Size = new Size(88, 15);
        label1.TabIndex = 2;
        label1.Text = "Top 10 usuarios";
        // 
        // btnExportToCSV
        // 
        btnExportToCSV.Location = new Point(132, 7);
        btnExportToCSV.Name = "btnExportToCSV";
        btnExportToCSV.Size = new Size(96, 23);
        btnExportToCSV.TabIndex = 3;
        btnExportToCSV.Text = "Exportar CSV";
        btnExportToCSV.UseVisualStyleBackColor = true;
//        btnExportToCSV.Click += btnExportToCSV_Click;
        // 
        // adduserId
        // 
        adduserId.Location = new Point(11, 444);
        adduserId.Name = "adduserId";
        adduserId.Size = new Size(100, 23);
        adduserId.TabIndex = 4;
        // 
        // addLogin
        // 
        addLogin.Location = new Point(117, 444);
        addLogin.Name = "addLogin";
        addLogin.Size = new Size(100, 23);
        addLogin.TabIndex = 5;
        // 
        // addNombre
        // 
        addNombre.Location = new Point(223, 444);
        addNombre.Name = "addNombre";
        addNombre.Size = new Size(100, 23);
        addNombre.TabIndex = 6;
        // 
        // addPaterno
        // 
        addPaterno.Location = new Point(329, 444);
        addPaterno.Name = "addPaterno";
        addPaterno.Size = new Size(100, 23);
        addPaterno.TabIndex = 7;
        // 
        // addMaterno
        // 
        addMaterno.Location = new Point(435, 444);
        addMaterno.Name = "addMaterno";
        addMaterno.Size = new Size(100, 23);
        addMaterno.TabIndex = 8;
        // 
        // addSueldo
        // 
        addSueldo.Location = new Point(541, 444);
        addSueldo.Name = "addSueldo";
        addSueldo.Size = new Size(100, 23);
        addSueldo.TabIndex = 9;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(43, 423);
        label2.Name = "label2";
        label2.Size = new Size(39, 15);
        label2.TabIndex = 10;
        label2.Text = "userId";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(144, 423);
        label3.Name = "label3";
        label3.Size = new Size(37, 15);
        label3.TabIndex = 11;
        label3.Text = "Login";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(247, 426);
        label4.Name = "label4";
        label4.Size = new Size(51, 15);
        label4.TabIndex = 12;
        label4.Text = "Nombre";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(352, 423);
        label5.Name = "label5";
        label5.Size = new Size(48, 15);
        label5.TabIndex = 13;
        label5.Text = "Paterno";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(453, 423);
        label6.Name = "label6";
        label6.Size = new Size(52, 15);
        label6.TabIndex = 14;
        label6.Text = "Materno";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(551, 423);
        label7.Name = "label7";
        label7.Size = new Size(43, 15);
        label7.TabIndex = 15;
        label7.Text = "Sueldo";
        // 
        // btnAddUser
        // 
        btnAddUser.Location = new Point(292, 486);
        btnAddUser.Name = "btnAddUser";
        btnAddUser.Size = new Size(75, 23);
        btnAddUser.TabIndex = 16;
        btnAddUser.Text = "Agregar";
        btnAddUser.UseVisualStyleBackColor = true;
//        btnAddUser.Click += btnAddUser_Click;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(362, 368);
        label8.Name = "label8";
        label8.Size = new Size(71, 15);
        label8.TabIndex = 17;
        label8.Text = "Sueld actual";
        // 
        // textBox7
        // 
        textBox7.Location = new Point(347, 386);
        textBox7.Name = "textBox7";
        textBox7.Size = new Size(100, 23);
        textBox7.TabIndex = 20;
        // 
        // textBox8
        // 
        textBox8.Location = new Point(453, 386);
        textBox8.Name = "textBox8";
        textBox8.Size = new Size(100, 23);
        textBox8.TabIndex = 21;
        // 
        // button1
        // 
        button1.Location = new Point(559, 386);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 22;
        button1.Text = "Actualizar";
        button1.UseVisualStyleBackColor = true;
//        button1.Click += button1_Click;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(464, 368);
        label9.Name = "label9";
        label9.Size = new Size(80, 15);
        label9.TabIndex = 23;
        label9.Text = "Nuevo Salario";
        // 
        // bBuscar
        // 
        bBuscar.Location = new Point(22, 386);
        bBuscar.Name = "bBuscar";
        bBuscar.Size = new Size(159, 23);
        bBuscar.TabIndex = 24;
        bBuscar.Text = "Ver sueldos";
        bBuscar.UseVisualStyleBackColor = true;
        bBuscar.Click += bBuscar_Click;
        // 
        // dataG
        // 
        dataG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataG.Location = new Point(671, 47);
        dataG.Name = "dataG";
        dataG.Size = new Size(382, 308);
        dataG.TabIndex = 25;
        dataG.CellContentClick += dataG_CellContentClick;
        // 
        // textBU
        // 
        textBU.Location = new Point(223, 386);
        textBU.Name = "textBU";
        textBU.Size = new Size(100, 23);
        textBU.TabIndex = 4;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(255, 365);
        label10.Name = "label10";
        label10.Size = new Size(39, 15);
        label10.TabIndex = 10;
        label10.Text = "userId";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1075, 716);
        Controls.Add(dataG);
        Controls.Add(bBuscar);
        Controls.Add(label9);
        Controls.Add(button1);
        Controls.Add(textBox8);
        Controls.Add(textBox7);
        Controls.Add(label8);
        Controls.Add(btnAddUser);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label10);
        Controls.Add(label2);
        Controls.Add(addSueldo);
        Controls.Add(addMaterno);
        Controls.Add(addPaterno);
        Controls.Add(addNombre);
        Controls.Add(addLogin);
        Controls.Add(textBU);
        Controls.Add(adduserId);
        Controls.Add(btnExportToCSV);
        Controls.Add(label1);
        Controls.Add(dataGridViewUsuarios);
        Margin = new Padding(4, 3, 4, 3);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataG).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private DataGridView dataGridViewUsuarios;
    private Label label1;
    private Button btnExportToCSV;
    private TextBox adduserId;
    private TextBox addLogin;
    private TextBox addNombre;
    private TextBox addPaterno;
    private TextBox addMaterno;
    private TextBox addSueldo;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Button btnAddUser;
    private Label label8;
    private TextBox textBox7;
    private TextBox textBox8;
    private Button button1;
    private Label label9;
    private Button bBuscar;
    private DataGridView dataG;
    private TextBox textBU;
    private Label label10;
}
