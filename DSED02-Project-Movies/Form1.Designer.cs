namespace DSED02_Project_Movies
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Customers = new System.Windows.Forms.TabPage();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.Movies = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.Rentals = new System.Windows.Forms.TabPage();
            this.DGVRental = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RbnAllRented = new System.Windows.Forms.RadioButton();
            this.RbnOutRented = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtRMID = new System.Windows.Forms.TextBox();
            this.txtCurrentYear = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVTopCustomers = new System.Windows.Forms.DataGridView();
            this.DGVTopMovies = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            this.Movies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.Rentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Controls.Add(this.Movies);
            this.tabControl1.Controls.Add(this.Rentals);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("AR CENA", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(441, 165);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1592, 985);
            this.tabControl1.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.BackColor = System.Drawing.Color.Black;
            this.Customers.Controls.Add(this.DGVCustomer);
            this.Customers.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.Location = new System.Drawing.Point(66, 4);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(1522, 977);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVCustomer.BackgroundColor = System.Drawing.Color.Black;
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustomer.Location = new System.Drawing.Point(3, 3);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.RowTemplate.Height = 37;
            this.DGVCustomer.Size = new System.Drawing.Size(1516, 971);
            this.DGVCustomer.TabIndex = 0;
            this.DGVCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_CellContentClick);
            this.DGVCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_CellContentClick);
            // 
            // Movies
            // 
            this.Movies.BackColor = System.Drawing.Color.Black;
            this.Movies.Controls.Add(this.DGVMovies);
            this.Movies.Controls.Add(this.DGVCustomers);
            this.Movies.Location = new System.Drawing.Point(66, 4);
            this.Movies.Name = "Movies";
            this.Movies.Padding = new System.Windows.Forms.Padding(3);
            this.Movies.Size = new System.Drawing.Size(1522, 977);
            this.Movies.TabIndex = 1;
            this.Movies.Text = "Movies";
            // 
            // DGVMovies
            // 
            this.DGVMovies.BackgroundColor = System.Drawing.Color.Black;
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMovies.Location = new System.Drawing.Point(3, 3);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.RowTemplate.Height = 37;
            this.DGVMovies.Size = new System.Drawing.Size(1516, 971);
            this.DGVMovies.TabIndex = 1;
            this.DGVMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick);
            this.DGVMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick);
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustomers.Location = new System.Drawing.Point(3, 3);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.RowTemplate.Height = 37;
            this.DGVCustomers.Size = new System.Drawing.Size(1516, 971);
            this.DGVCustomers.TabIndex = 0;
            // 
            // Rentals
            // 
            this.Rentals.BackColor = System.Drawing.Color.Black;
            this.Rentals.Controls.Add(this.DGVRental);
            this.Rentals.Location = new System.Drawing.Point(66, 4);
            this.Rentals.Name = "Rentals";
            this.Rentals.Size = new System.Drawing.Size(1522, 977);
            this.Rentals.TabIndex = 2;
            this.Rentals.Text = "Rentals";
            // 
            // DGVRental
            // 
            this.DGVRental.BackgroundColor = System.Drawing.Color.Black;
            this.DGVRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRental.Location = new System.Drawing.Point(0, 0);
            this.DGVRental.Name = "DGVRental";
            this.DGVRental.RowTemplate.Height = 37;
            this.DGVRental.Size = new System.Drawing.Size(1522, 977);
            this.DGVRental.TabIndex = 0;
            this.DGVRental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRental_CellContentClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-48, -99);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1650);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 1650);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer2.Location = new System.Drawing.Point(6, 1198);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.DarkRed;
            this.splitContainer2.Panel1.Controls.Add(this.txtMovieID);
            this.splitContainer2.Panel1.Controls.Add(this.txtCustID);
            this.splitContainer2.Panel1.Controls.Add(this.txtPhone);
            this.splitContainer2.Panel1.Controls.Add(this.btnDeleteCustomer);
            this.splitContainer2.Panel1.Controls.Add(this.btnUpdateCustomer);
            this.splitContainer2.Panel1.Controls.Add(this.btnAddCustomer);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.txtAddress);
            this.splitContainer2.Panel1.Controls.Add(this.txtSurname);
            this.splitContainer2.Panel1.Controls.Add(this.txtName);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(3100, 452);
            this.splitContainer2.SplitterDistance = 2296;
            this.splitContainer2.TabIndex = 4;
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(76, 361);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(100, 36);
            this.txtMovieID.TabIndex = 35;
            this.txtMovieID.Visible = false;
            // 
            // txtCustID
            // 
            this.txtCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustID.Location = new System.Drawing.Point(59, 139);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(100, 48);
            this.txtCustID.TabIndex = 34;
            this.txtCustID.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(1454, 104);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(260, 48);
            this.txtPhone.TabIndex = 21;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(1818, 285);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(280, 61);
            this.btnDeleteCustomer.TabIndex = 12;
            this.btnDeleteCustomer.Text = "DELETE";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(1818, 180);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(280, 61);
            this.btnUpdateCustomer.TabIndex = 11;
            this.btnUpdateCustomer.Text = "UPDATE";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(1818, 75);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(280, 61);
            this.btnAddCustomer.TabIndex = 10;
            this.btnAddCustomer.Text = "ADD";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(1449, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(651, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(1061, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(651, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(647, 229);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(1067, 117);
            this.txtAddress.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(1053, 105);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(378, 48);
            this.txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(647, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(385, 48);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR CENA", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(99, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 83);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.RbnAllRented);
            this.panel2.Controls.Add(this.RbnOutRented);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(110, 174);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 187);
            this.panel2.TabIndex = 1;
            // 
            // RbnAllRented
            // 
            this.RbnAllRented.AutoSize = true;
            this.RbnAllRented.Checked = true;
            this.RbnAllRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbnAllRented.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RbnAllRented.Location = new System.Drawing.Point(100, 110);
            this.RbnAllRented.Name = "RbnAllRented";
            this.RbnAllRented.Size = new System.Drawing.Size(185, 40);
            this.RbnAllRented.TabIndex = 12;
            this.RbnAllRented.TabStop = true;
            this.RbnAllRented.Text = "All Rented";
            this.RbnAllRented.UseVisualStyleBackColor = true;
            this.RbnAllRented.CheckedChanged += new System.EventHandler(this.RbnAllRented_CheckedChanged);
            // 
            // RbnOutRented
            // 
            this.RbnOutRented.AutoSize = true;
            this.RbnOutRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbnOutRented.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RbnOutRented.Location = new System.Drawing.Point(347, 110);
            this.RbnOutRented.Name = "RbnOutRented";
            this.RbnOutRented.Size = new System.Drawing.Size(197, 40);
            this.RbnOutRented.TabIndex = 13;
            this.RbnOutRented.Text = "Out Rented";
            this.RbnOutRented.UseVisualStyleBackColor = true;
            this.RbnOutRented.CheckedChanged += new System.EventHandler(this.RbnOutRented_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR CENA", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(163, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rented Movies";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnIssue);
            this.panel1.Location = new System.Drawing.Point(18, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 135);
            this.panel1.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Red;
            this.btnReturn.Font = new System.Drawing.Font("AR CENA", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(439, 18);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(339, 95);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.Chartreuse;
            this.btnIssue.Font = new System.Drawing.Font("AR CENA", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(48, 18);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(339, 95);
            this.btnIssue.TabIndex = 0;
            this.btnIssue.Text = "Issue Movie";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // txtCopies
            // 
            this.txtCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopies.Location = new System.Drawing.Point(601, 230);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(100, 48);
            this.txtCopies.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(137, 475);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 36);
            this.label14.TabIndex = 33;
            this.label14.Text = "Plot";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(432, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 36);
            this.label13.TabIndex = 32;
            this.label13.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(425, 377);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(276, 48);
            this.txtGenre.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(282, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 36);
            this.label12.TabIndex = 30;
            this.label12.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(276, 377);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(97, 48);
            this.txtCost.TabIndex = 29;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(133, 377);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(97, 48);
            this.txtYear.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(471, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 36);
            this.label10.TabIndex = 25;
            this.label10.Text = "Rating";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(128, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 36);
            this.label9.TabIndex = 24;
            this.label9.Text = "Year";
            // 
            // txtPlot
            // 
            this.txtPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlot.Location = new System.Drawing.Point(124, 526);
            this.txtPlot.Multiline = true;
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(577, 206);
            this.txtPlot.TabIndex = 22;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.Location = new System.Drawing.Point(492, 876);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(252, 61);
            this.btnDeleteMovie.TabIndex = 20;
            this.btnDeleteMovie.Text = "DELETE";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.Location = new System.Drawing.Point(248, 876);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(226, 61);
            this.btnUpdateMovie.TabIndex = 19;
            this.btnUpdateMovie.Text = "UPDATE";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(29, 876);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(201, 61);
            this.btnAddMovie.TabIndex = 18;
            this.btnAddMovie.Text = "ADD";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(119, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = "Title";
            // 
            // txtRating
            // 
            this.txtRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRating.Location = new System.Drawing.Point(484, 230);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(68, 48);
            this.txtRating.TabIndex = 14;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(124, 230);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(318, 48);
            this.txtTitle.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("AR CENA", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(110, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(500, 83);
            this.label7.TabIndex = 9;
            this.label7.Text = "Movie Information";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(165, 346);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(0, 29);
            this.lblCustID.TabIndex = 5;
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(131, 960);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(100, 35);
            this.txtDateTime.TabIndex = 7;
            this.txtDateTime.Visible = false;
            // 
            // txtRMID
            // 
            this.txtRMID.Location = new System.Drawing.Point(105, 805);
            this.txtRMID.Name = "txtRMID";
            this.txtRMID.Size = new System.Drawing.Size(100, 35);
            this.txtRMID.TabIndex = 8;
            this.txtRMID.Visible = false;
            // 
            // txtCurrentYear
            // 
            this.txtCurrentYear.Location = new System.Drawing.Point(2516, 47);
            this.txtCurrentYear.Name = "txtCurrentYear";
            this.txtCurrentYear.Size = new System.Drawing.Size(175, 35);
            this.txtCurrentYear.TabIndex = 9;
            this.txtCurrentYear.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.lblFee);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtCopies);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnDeleteMovie);
            this.panel3.Controls.Add(this.btnUpdateMovie);
            this.panel3.Controls.Add(this.txtTitle);
            this.panel3.Controls.Add(this.btnAddMovie);
            this.panel3.Controls.Add(this.txtPlot);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtGenre);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtRating);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtCost);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtYear);
            this.panel3.Location = new System.Drawing.Point(2032, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 974);
            this.panel3.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(600, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 36);
            this.label15.TabIndex = 40;
            this.label15.Text = "Copies";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFee.Location = new System.Drawing.Point(303, 752);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(0, 63);
            this.lblFee.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(138, 763);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 36);
            this.label11.TabIndex = 37;
            this.label11.Text = "Hire Fee $";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(-48, -99);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Size = new System.Drawing.Size(150, 100);
            this.splitContainer3.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BackgroundImage = global::DSED02_Project_Movies.Properties.Resources.movie_bckrnd;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3106, 1650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Maroon;
            this.label16.Font = new System.Drawing.Font("AR CENA", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(1162, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(586, 124);
            this.label16.TabIndex = 17;
            this.label16.Text = "Movie Rentals";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVTopCustomers);
            this.tabPage1.Font = new System.Drawing.Font("AR CENA", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(66, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1522, 977);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Top Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVTopMovies);
            this.tabPage2.Font = new System.Drawing.Font("AR CENA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(66, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1522, 977);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Top Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVTopCustomers
            // 
            this.DGVTopCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTopCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTopCustomers.Location = new System.Drawing.Point(3, 3);
            this.DGVTopCustomers.Name = "DGVTopCustomers";
            this.DGVTopCustomers.RowTemplate.Height = 37;
            this.DGVTopCustomers.Size = new System.Drawing.Size(1516, 971);
            this.DGVTopCustomers.TabIndex = 0;
            // 
            // DGVTopMovies
            // 
            this.DGVTopMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTopMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTopMovies.Location = new System.Drawing.Point(3, 3);
            this.DGVTopMovies.Name = "DGVTopMovies";
            this.DGVTopMovies.RowTemplate.Height = 37;
            this.DGVTopMovies.Size = new System.Drawing.Size(1516, 971);
            this.DGVTopMovies.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(3106, 1650);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtCurrentYear);
            this.Controls.Add(this.txtRMID);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            this.Movies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.Rentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.TabPage Movies;
        private System.Windows.Forms.TabPage Rentals;
        private System.Windows.Forms.DataGridView DGVCustomer;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.DataGridView DGVRental;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtRMID;
        private System.Windows.Forms.TextBox txtCurrentYear;
        private System.Windows.Forms.RadioButton RbnAllRented;
        private System.Windows.Forms.RadioButton RbnOutRented;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVTopCustomers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVTopMovies;
    }
}

