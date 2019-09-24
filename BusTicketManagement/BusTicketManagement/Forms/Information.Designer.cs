namespace BusTicketManagement.Forms
{
    partial class Information
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
            this.tbCtrlInformationPage = new System.Windows.Forms.TabControl();
            this.tbPageHome = new System.Windows.Forms.TabPage();
            this.lblABC = new System.Windows.Forms.Label();
            this.tbPageBus = new System.Windows.Forms.TabPage();
            this.cmbxBusID = new System.Windows.Forms.ComboBox();
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bus_Ticket_ReservationDataSet1 = new BusTicketManagement.Bus_Ticket_ReservationDataSet1();
            this.lblBusID = new System.Windows.Forms.Label();
            this.btnBusDelete = new System.Windows.Forms.Button();
            this.btnBusUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.busIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busCatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfActiveSeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBusInsert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkBxIsActive = new System.Windows.Forms.CheckBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtBxTicketPrice = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.txtBxTotalActiveSeat = new System.Windows.Forms.TextBox();
            this.lblActiveSeat = new System.Windows.Forms.Label();
            this.txtBxTotalSeat = new System.Windows.Forms.TextBox();
            this.lblTotalSeat = new System.Windows.Forms.Label();
            this.txtBxBusNumber = new System.Windows.Forms.TextBox();
            this.lblBusNumber = new System.Windows.Forms.Label();
            this.cmbxBusCategory = new System.Windows.Forms.ComboBox();
            this.busCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bus_Ticket_ReservationDataSet = new BusTicketManagement.Bus_Ticket_ReservationDataSet();
            this.lblBusCat = new System.Windows.Forms.Label();
            this.lblNewBus = new System.Windows.Forms.Label();
            this.tbPageEmployee = new System.Windows.Forms.TabPage();
            this.btnEmpReset = new System.Windows.Forms.Button();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bus_Ticket_ReservationDataSet3 = new BusTicketManagement.Bus_Ticket_ReservationDataSet3();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            this.btnEmpInsert = new System.Windows.Forms.Button();
            this.cmbxEmpID = new System.Windows.Forms.ComboBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.txtEmpNID = new System.Windows.Forms.TextBox();
            this.lblEmpNID = new System.Windows.Forms.Label();
            this.cmbxEmpCategory = new System.Windows.Forms.ComboBox();
            this.empCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bus_Ticket_ReservationDataSet2 = new BusTicketManagement.Bus_Ticket_ReservationDataSet2();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpCellPhone = new System.Windows.Forms.Label();
            this.lblEmpCat = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.tbPageTktPurchase = new System.Windows.Forms.TabPage();
            this.btnPassDelete = new System.Windows.Forms.Button();
            this.btnPassUpdate = new System.Windows.Forms.Button();
            this.btnPassInsert = new System.Windows.Forms.Button();
            this.chkBxPassConfirm = new System.Windows.Forms.CheckBox();
            this.lblPassConfirm = new System.Windows.Forms.Label();
            this.cmbxPassSchedule = new System.Windows.Forms.ComboBox();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bus_Ticket_ReservationDataSet4 = new BusTicketManagement.Bus_Ticket_ReservationDataSet4();
            this.cmbxPassBus = new System.Windows.Forms.ComboBox();
            this.lblPassSchedule = new System.Windows.Forms.Label();
            this.lblPassBus = new System.Windows.Forms.Label();
            this.txtPassVat = new System.Windows.Forms.TextBox();
            this.lblPassVat = new System.Windows.Forms.Label();
            this.txtPassUnitFare = new System.Windows.Forms.TextBox();
            this.lblPassUntFre = new System.Windows.Forms.Label();
            this.txtPassTBkdStNo = new System.Windows.Forms.TextBox();
            this.lblPassTBkdStNo = new System.Windows.Forms.Label();
            this.txtPassBkdSeatNo = new System.Windows.Forms.TextBox();
            this.lblPassBookedSeatNo = new System.Windows.Forms.Label();
            this.dtpPassJourneyDate = new System.Windows.Forms.DateTimePicker();
            this.lblPassJrnyDate = new System.Windows.Forms.Label();
            this.txtPassNID = new System.Windows.Forms.TextBox();
            this.txtPassEmail = new System.Windows.Forms.TextBox();
            this.txtPassPhone = new System.Windows.Forms.TextBox();
            this.txtPassName = new System.Windows.Forms.TextBox();
            this.lblPassNID = new System.Windows.Forms.Label();
            this.lblPassEmail = new System.Windows.Forms.Label();
            this.lblPassPhone = new System.Windows.Forms.Label();
            this.lblPassName = new System.Windows.Forms.Label();
            this.busCategoryTableAdapter = new BusTicketManagement.Bus_Ticket_ReservationDataSetTableAdapters.BusCategoryTableAdapter();
            this.busTableAdapter = new BusTicketManagement.Bus_Ticket_ReservationDataSet1TableAdapters.BusTableAdapter();
            this.empCategoryTableAdapter = new BusTicketManagement.Bus_Ticket_ReservationDataSet2TableAdapters.EmpCategoryTableAdapter();
            this.employeeTableAdapter = new BusTicketManagement.Bus_Ticket_ReservationDataSet3TableAdapters.EmployeeTableAdapter();
            this.scheduleTableAdapter = new BusTicketManagement.Bus_Ticket_ReservationDataSet4TableAdapters.ScheduleTableAdapter();
            this.tbPageReport = new System.Windows.Forms.TabPage();
            this.crystalReportViewerEmp = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptEmloyeeInformaiton1 = new BusTicketManagement.Reports.rptEmloyeeInformaiton();
            this.rptEmloyeeInformaiton2 = new BusTicketManagement.Reports.rptEmloyeeInformaiton();
            this.tbCtrlInformationPage.SuspendLayout();
            this.tbPageHome.SuspendLayout();
            this.tbPageBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_Ticket_ReservationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_Ticket_ReservationDataSet)).BeginInit();
            this.tbPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_Ticket_ReservationDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_Ticket_ReservationDataSet2)).BeginInit();
            this.tbPageTktPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_Ticket_ReservationDataSet4)).BeginInit();
            this.tbPageReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCtrlInformationPage
            // 
            this.tbCtrlInformationPage.Controls.Add(this.tbPageHome);
            this.tbCtrlInformationPage.Controls.Add(this.tbPageBus);
            this.tbCtrlInformationPage.Controls.Add(this.tbPageEmployee);
            this.tbCtrlInformationPage.Controls.Add(this.tbPageTktPurchase);
            this.tbCtrlInformationPage.Controls.Add(this.tbPageReport);
            this.tbCtrlInformationPage.Location = new System.Drawing.Point(-2, 0);
            this.tbCtrlInformationPage.Multiline = true;
            this.tbCtrlInformationPage.Name = "tbCtrlInformationPage";
            this.tbCtrlInformationPage.SelectedIndex = 0;
            this.tbCtrlInformationPage.Size = new System.Drawing.Size(805, 453);
            this.tbCtrlInformationPage.TabIndex = 0;
            // 
            // tbPageHome
            // 
            this.tbPageHome.Controls.Add(this.lblABC);
            this.tbPageHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbPageHome.Location = new System.Drawing.Point(4, 22);
            this.tbPageHome.Name = "tbPageHome";
            this.tbPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageHome.Size = new System.Drawing.Size(797, 427);
            this.tbPageHome.TabIndex = 0;
            this.tbPageHome.Text = "Home";
            this.tbPageHome.UseVisualStyleBackColor = true;
            // 
            // lblABC
            // 
            this.lblABC.AutoSize = true;
            this.lblABC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblABC.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblABC.Location = new System.Drawing.Point(248, 18);
            this.lblABC.Name = "lblABC";
            this.lblABC.Size = new System.Drawing.Size(189, 34);
            this.lblABC.TabIndex = 0;
            this.lblABC.Text = "ABC Transport";
            // 
            // tbPageBus
            // 
            this.tbPageBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbPageBus.Controls.Add(this.cmbxBusID);
            this.tbPageBus.Controls.Add(this.lblBusID);
            this.tbPageBus.Controls.Add(this.btnBusDelete);
            this.tbPageBus.Controls.Add(this.btnBusUpdate);
            this.tbPageBus.Controls.Add(this.dataGridView1);
            this.tbPageBus.Controls.Add(this.btnBusInsert);
            this.tbPageBus.Controls.Add(this.btnReset);
            this.tbPageBus.Controls.Add(this.chkBxIsActive);
            this.tbPageBus.Controls.Add(this.txtRemarks);
            this.tbPageBus.Controls.Add(this.txtBxTicketPrice);
            this.tbPageBus.Controls.Add(this.lblRemarks);
            this.tbPageBus.Controls.Add(this.lblIsActive);
            this.tbPageBus.Controls.Add(this.lblTicketPrice);
            this.tbPageBus.Controls.Add(this.txtBxTotalActiveSeat);
            this.tbPageBus.Controls.Add(this.lblActiveSeat);
            this.tbPageBus.Controls.Add(this.txtBxTotalSeat);
            this.tbPageBus.Controls.Add(this.lblTotalSeat);
            this.tbPageBus.Controls.Add(this.txtBxBusNumber);
            this.tbPageBus.Controls.Add(this.lblBusNumber);
            this.tbPageBus.Controls.Add(this.cmbxBusCategory);
            this.tbPageBus.Controls.Add(this.lblBusCat);
            this.tbPageBus.Controls.Add(this.lblNewBus);
            this.tbPageBus.Location = new System.Drawing.Point(4, 22);
            this.tbPageBus.Name = "tbPageBus";
            this.tbPageBus.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageBus.Size = new System.Drawing.Size(797, 427);
            this.tbPageBus.TabIndex = 1;
            this.tbPageBus.Text = "Bus";
            // 
            // cmbxBusID
            // 
            this.cmbxBusID.DataSource = this.busBindingSource;
            this.cmbxBusID.DisplayMember = "BusID";
            this.cmbxBusID.FormattingEnabled = true;
            this.cmbxBusID.Location = new System.Drawing.Point(425, 140);
            this.cmbxBusID.Name = "cmbxBusID";
            this.cmbxBusID.Size = new System.Drawing.Size(152, 21);
            this.cmbxBusID.TabIndex = 22;
            this.cmbxBusID.ValueMember = "BusID";
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataMember = "Bus";
            this.busBindingSource.DataSource = this.bus_Ticket_ReservationDataSet1;
            // 
            // bus_Ticket_ReservationDataSet1
            // 
            this.bus_Ticket_ReservationDataSet1.DataSetName = "Bus_Ticket_ReservationDataSet1";
            this.bus_Ticket_ReservationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblBusID
            // 
            this.lblBusID.AutoSize = true;
            this.lblBusID.BackColor = System.Drawing.Color.Snow;
            this.lblBusID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBusID.Location = new System.Drawing.Point(350, 140);
            this.lblBusID.Name = "lblBusID";
            this.lblBusID.Size = new System.Drawing.Size(62, 19);
            this.lblBusID.TabIndex = 21;
            this.lblBusID.Text = "Bus ID";
            // 
            // btnBusDelete
            // 
            this.btnBusDelete.Location = new System.Drawing.Point(245, 190);
            this.btnBusDelete.Name = "btnBusDelete";
            this.btnBusDelete.Size = new System.Drawing.Size(110, 37);
            this.btnBusDelete.TabIndex = 20;
            this.btnBusDelete.Text = "Delete";
            this.btnBusDelete.UseVisualStyleBackColor = true;
            this.btnBusDelete.Click += new System.EventHandler(this.btnBusDelete_Click);
            // 
            // btnBusUpdate
            // 
            this.btnBusUpdate.Location = new System.Drawing.Point(122, 190);
            this.btnBusUpdate.Name = "btnBusUpdate";
            this.btnBusUpdate.Size = new System.Drawing.Size(110, 37);
            this.btnBusUpdate.TabIndex = 19;
            this.btnBusUpdate.Text = "Update";
            this.btnBusUpdate.UseVisualStyleBackColor = true;
            this.btnBusUpdate.Click += new System.EventHandler(this.btnBusUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.busIDDataGridViewTextBoxColumn,
            this.busCatIDDataGridViewTextBoxColumn,
            this.busNumberDataGridViewTextBoxColumn,
            this.noOfSeatsDataGridViewTextBoxColumn,
            this.noOfActiveSeatDataGridViewTextBoxColumn,
            this.tPriceDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.busBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // busIDDataGridViewTextBoxColumn
            // 
            this.busIDDataGridViewTextBoxColumn.DataPropertyName = "BusID";
            this.busIDDataGridViewTextBoxColumn.HeaderText = "BusID";
            this.busIDDataGridViewTextBoxColumn.Name = "busIDDataGridViewTextBoxColumn";
            this.busIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // busCatIDDataGridViewTextBoxColumn
            // 
            this.busCatIDDataGridViewTextBoxColumn.DataPropertyName = "BusCatID";
            this.busCatIDDataGridViewTextBoxColumn.HeaderText = "BusCatID";
            this.busCatIDDataGridViewTextBoxColumn.Name = "busCatIDDataGridViewTextBoxColumn";
            // 
            // busNumberDataGridViewTextBoxColumn
            // 
            this.busNumberDataGridViewTextBoxColumn.DataPropertyName = "BusNumber";
            this.busNumberDataGridViewTextBoxColumn.HeaderText = "BusNumber";
            this.busNumberDataGridViewTextBoxColumn.Name = "busNumberDataGridViewTextBoxColumn";
            // 
            // noOfSeatsDataGridViewTextBoxColumn
            // 
            this.noOfSeatsDataGridViewTextBoxColumn.DataPropertyName = "NoOfSeats";
            this.noOfSeatsDataGridViewTextBoxColumn.HeaderText = "NoOfSeats";
            this.noOfSeatsDataGridViewTextBoxColumn.Name = "noOfSeatsDataGridViewTextBoxColumn";
            // 
            // noOfActiveSeatDataGridViewTextBoxColumn
            // 
            this.noOfActiveSeatDataGridViewTextBoxColumn.DataPropertyName = "NoOfActiveSeat";
            this.noOfActiveSeatDataGridViewTextBoxColumn.HeaderText = "NoOfActiveSeat";
            this.noOfActiveSeatDataGridViewTextBoxColumn.Name = "noOfActiveSeatDataGridViewTextBoxColumn";
            // 
            // tPriceDataGridViewTextBoxColumn
            // 
            this.tPriceDataGridViewTextBoxColumn.DataPropertyName = "TPrice";
            this.tPriceDataGridViewTextBoxColumn.HeaderText = "TPrice";
            this.tPriceDataGridViewTextBoxColumn.Name = "tPriceDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // btnBusInsert
            // 
            this.btnBusInsert.Location = new System.Drawing.Point(6, 190);
            this.btnBusInsert.Name = "btnBusInsert";
            this.btnBusInsert.Size = new System.Drawing.Size(110, 37);
            this.btnBusInsert.TabIndex = 17;
            this.btnBusInsert.Text = "Insert";
            this.btnBusInsert.UseVisualStyleBackColor = true;
            this.btnBusInsert.Click += new System.EventHandler(this.btnBusInsert_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(425, 190);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 37);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkBxIsActive
            // 
            this.chkBxIsActive.AutoSize = true;
            this.chkBxIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkBxIsActive.Location = new System.Drawing.Point(702, 63);
            this.chkBxIsActive.Name = "chkBxIsActive";
            this.chkBxIsActive.Size = new System.Drawing.Size(55, 22);
            this.chkBxIsActive.TabIndex = 14;
            this.chkBxIsActive.Text = "Yes";
            this.chkBxIsActive.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkBxIsActive.UseVisualStyleBackColor = true;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(441, 91);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(152, 33);
            this.txtRemarks.TabIndex = 13;
            // 
            // txtBxTicketPrice
            // 
            this.txtBxTicketPrice.Location = new System.Drawing.Point(441, 65);
            this.txtBxTicketPrice.Name = "txtBxTicketPrice";
            this.txtBxTicketPrice.Size = new System.Drawing.Size(152, 20);
            this.txtBxTicketPrice.TabIndex = 12;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.BackColor = System.Drawing.Color.Snow;
            this.lblRemarks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblRemarks.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRemarks.Location = new System.Drawing.Point(338, 92);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(81, 19);
            this.lblRemarks.TabIndex = 11;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.BackColor = System.Drawing.Color.Snow;
            this.lblIsActive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblIsActive.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIsActive.Location = new System.Drawing.Point(616, 65);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(80, 19);
            this.lblIsActive.TabIndex = 10;
            this.lblIsActive.Text = "Is Active";
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.BackColor = System.Drawing.Color.Snow;
            this.lblTicketPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTicketPrice.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTicketPrice.Location = new System.Drawing.Point(329, 63);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(106, 19);
            this.lblTicketPrice.TabIndex = 9;
            this.lblTicketPrice.Text = "Ticket Price";
            // 
            // txtBxTotalActiveSeat
            // 
            this.txtBxTotalActiveSeat.Location = new System.Drawing.Point(166, 153);
            this.txtBxTotalActiveSeat.Name = "txtBxTotalActiveSeat";
            this.txtBxTotalActiveSeat.Size = new System.Drawing.Size(152, 20);
            this.txtBxTotalActiveSeat.TabIndex = 8;
            // 
            // lblActiveSeat
            // 
            this.lblActiveSeat.AutoSize = true;
            this.lblActiveSeat.BackColor = System.Drawing.Color.Snow;
            this.lblActiveSeat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblActiveSeat.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblActiveSeat.Location = new System.Drawing.Point(10, 154);
            this.lblActiveSeat.Name = "lblActiveSeat";
            this.lblActiveSeat.Size = new System.Drawing.Size(150, 19);
            this.lblActiveSeat.TabIndex = 7;
            this.lblActiveSeat.Text = "Total Active Seat";
            // 
            // txtBxTotalSeat
            // 
            this.txtBxTotalSeat.Location = new System.Drawing.Point(142, 121);
            this.txtBxTotalSeat.Name = "txtBxTotalSeat";
            this.txtBxTotalSeat.Size = new System.Drawing.Size(152, 20);
            this.txtBxTotalSeat.TabIndex = 6;
            // 
            // lblTotalSeat
            // 
            this.lblTotalSeat.AutoSize = true;
            this.lblTotalSeat.BackColor = System.Drawing.Color.Snow;
            this.lblTotalSeat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalSeat.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalSeat.Location = new System.Drawing.Point(10, 122);
            this.lblTotalSeat.Name = "lblTotalSeat";
            this.lblTotalSeat.Size = new System.Drawing.Size(94, 19);
            this.lblTotalSeat.TabIndex = 5;
            this.lblTotalSeat.Text = "Total Seat";
            // 
            // txtBxBusNumber
            // 
            this.txtBxBusNumber.Location = new System.Drawing.Point(142, 91);
            this.txtBxBusNumber.Name = "txtBxBusNumber";
            this.txtBxBusNumber.Size = new System.Drawing.Size(152, 20);
            this.txtBxBusNumber.TabIndex = 4;
            // 
            // lblBusNumber
            // 
            this.lblBusNumber.AutoSize = true;
            this.lblBusNumber.BackColor = System.Drawing.Color.Snow;
            this.lblBusNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusNumber.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBusNumber.Location = new System.Drawing.Point(9, 92);
            this.lblBusNumber.Name = "lblBusNumber";
            this.lblBusNumber.Size = new System.Drawing.Size(107, 19);
            this.lblBusNumber.TabIndex = 3;
            this.lblBusNumber.Text = "Bus Number";
            // 
            // cmbxBusCategory
            // 
            this.cmbxBusCategory.DataSource = this.busCategoryBindingSource;
            this.cmbxBusCategory.DisplayMember = "BusCatName";
            this.cmbxBusCategory.FormattingEnabled = true;
            this.cmbxBusCategory.Location = new System.Drawing.Point(142, 63);
            this.cmbxBusCategory.Name = "cmbxBusCategory";
            this.cmbxBusCategory.Size = new System.Drawing.Size(152, 21);
            this.cmbxBusCategory.TabIndex = 2;
            this.cmbxBusCategory.ValueMember = "BusCatID";
            // 
            // busCategoryBindingSource
            // 
            this.busCategoryBindingSource.DataMember = "BusCategory";
            this.busCategoryBindingSource.DataSource = this.bus_Ticket_ReservationDataSet;
            // 
            // bus_Ticket_ReservationDataSet
            // 
            this.bus_Ticket_ReservationDataSet.DataSetName = "Bus_Ticket_ReservationDataSet";
            this.bus_Ticket_ReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblBusCat
            // 
            this.lblBusCat.AutoSize = true;
            this.lblBusCat.BackColor = System.Drawing.Color.Snow;
            this.lblBusCat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusCat.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBusCat.Location = new System.Drawing.Point(6, 61);
            this.lblBusCat.Name = "lblBusCat";
            this.lblBusCat.Size = new System.Drawing.Size(117, 19);
            this.lblBusCat.TabIndex = 1;
            this.lblBusCat.Text = "Bus Category";
            // 
            // lblNewBus
            // 
            this.lblNewBus.AutoSize = true;
            this.lblNewBus.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBus.ForeColor = System.Drawing.Color.Black;
            this.lblNewBus.Location = new System.Drawing.Point(305, 17);
            this.lblNewBus.Name = "lblNewBus";
            this.lblNewBus.Size = new System.Drawing.Size(50, 31);
            this.lblNewBus.TabIndex = 0;
            this.lblNewBus.Text = "Bus";
            // 
            // tbPageEmployee
            // 
            this.tbPageEmployee.Controls.Add(this.btnEmpReset);
            this.tbPageEmployee.Controls.Add(this.btnEmpUpdate);
            this.tbPageEmployee.Controls.Add(this.dgvEmp);
            this.tbPageEmployee.Controls.Add(this.btnEmpDelete);
            this.tbPageEmployee.Controls.Add(this.btnEmpInsert);
            this.tbPageEmployee.Controls.Add(this.cmbxEmpID);
            this.tbPageEmployee.Controls.Add(this.txtEmpEmail);
            this.tbPageEmployee.Controls.Add(this.lblEmpID);
            this.tbPageEmployee.Controls.Add(this.lblEmpEmail);
            this.tbPageEmployee.Controls.Add(this.txtEmpNID);
            this.tbPageEmployee.Controls.Add(this.lblEmpNID);
            this.tbPageEmployee.Controls.Add(this.cmbxEmpCategory);
            this.tbPageEmployee.Controls.Add(this.txtCellPhone);
            this.tbPageEmployee.Controls.Add(this.txtEmpName);
            this.tbPageEmployee.Controls.Add(this.lblEmpCellPhone);
            this.tbPageEmployee.Controls.Add(this.lblEmpCat);
            this.tbPageEmployee.Controls.Add(this.lblEmpName);
            this.tbPageEmployee.Location = new System.Drawing.Point(4, 22);
            this.tbPageEmployee.Name = "tbPageEmployee";
            this.tbPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageEmployee.Size = new System.Drawing.Size(797, 427);
            this.tbPageEmployee.TabIndex = 2;
            this.tbPageEmployee.Text = "Employee";
            this.tbPageEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEmpReset
            // 
            this.btnEmpReset.AutoEllipsis = true;
            this.btnEmpReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpReset.Location = new System.Drawing.Point(389, 174);
            this.btnEmpReset.Name = "btnEmpReset";
            this.btnEmpReset.Size = new System.Drawing.Size(54, 43);
            this.btnEmpReset.TabIndex = 22;
            this.btnEmpReset.Text = "Reset";
            this.btnEmpReset.UseVisualStyleBackColor = false;
            this.btnEmpReset.Click += new System.EventHandler(this.btnEmpReset_Click);
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.AutoEllipsis = true;
            this.btnEmpUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpUpdate.Location = new System.Drawing.Point(239, 174);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(58, 43);
            this.btnEmpUpdate.TabIndex = 21;
            this.btnEmpUpdate.Text = "Update";
            this.btnEmpUpdate.UseVisualStyleBackColor = false;
            this.btnEmpUpdate.Click += new System.EventHandler(this.btnEmpUpdate_Click);
            // 
            // dgvEmp
            // 
            this.dgvEmp.AllowUserToOrderColumns = true;
            this.dgvEmp.AutoGenerateColumns = false;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.empCatIDDataGridViewTextBoxColumn,
            this.cellPhoneDataGridViewTextBoxColumn,
            this.nIDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvEmp.DataSource = this.employeeBindingSource;
            this.dgvEmp.Location = new System.Drawing.Point(6, 250);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.Size = new System.Drawing.Size(763, 174);
            this.dgvEmp.TabIndex = 20;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // empCatIDDataGridViewTextBoxColumn
            // 
            this.empCatIDDataGridViewTextBoxColumn.DataPropertyName = "EmpCatID";
            this.empCatIDDataGridViewTextBoxColumn.HeaderText = "EmpCatID";
            this.empCatIDDataGridViewTextBoxColumn.Name = "empCatIDDataGridViewTextBoxColumn";
            // 
            // cellPhoneDataGridViewTextBoxColumn
            // 
            this.cellPhoneDataGridViewTextBoxColumn.DataPropertyName = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.HeaderText = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.Name = "cellPhoneDataGridViewTextBoxColumn";
            // 
            // nIDDataGridViewTextBoxColumn
            // 
            this.nIDDataGridViewTextBoxColumn.DataPropertyName = "NID";
            this.nIDDataGridViewTextBoxColumn.HeaderText = "NID";
            this.nIDDataGridViewTextBoxColumn.Name = "nIDDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bus_Ticket_ReservationDataSet3;
            // 
            // bus_Ticket_ReservationDataSet3
            // 
            this.bus_Ticket_ReservationDataSet3.DataSetName = "Bus_Ticket_ReservationDataSet3";
            this.bus_Ticket_ReservationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.AutoEllipsis = true;
            this.btnEmpDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpDelete.Location = new System.Drawing.Point(318, 174);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(54, 43);
            this.btnEmpDelete.TabIndex = 19;
            this.btnEmpDelete.Text = "Delete";
            this.btnEmpDelete.UseVisualStyleBackColor = false;
            this.btnEmpDelete.Click += new System.EventHandler(this.btnEmpDelete_Click);
            // 
            // btnEmpInsert
            // 
            this.btnEmpInsert.AutoEllipsis = true;
            this.btnEmpInsert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpInsert.Location = new System.Drawing.Point(175, 174);
            this.btnEmpInsert.Name = "btnEmpInsert";
            this.btnEmpInsert.Size = new System.Drawing.Size(58, 43);
            this.btnEmpInsert.TabIndex = 18;
            this.btnEmpInsert.Text = "Insert";
            this.btnEmpInsert.UseVisualStyleBackColor = false;
            this.btnEmpInsert.Click += new System.EventHandler(this.btnEmpInsert_Click);
            // 
            // cmbxEmpID
            // 
            this.cmbxEmpID.DataSource = this.employeeBindingSource;
            this.cmbxEmpID.DisplayMember = "EmployeeID";
            this.cmbxEmpID.FormattingEnabled = true;
            this.cmbxEmpID.Location = new System.Drawing.Point(538, 135);
            this.cmbxEmpID.Name = "cmbxEmpID";
            this.cmbxEmpID.Size = new System.Drawing.Size(152, 21);
            this.cmbxEmpID.TabIndex = 15;
            this.cmbxEmpID.ValueMember = "EmployeeID";
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(188, 135);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmpEmail.TabIndex = 14;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmpID.Location = new System.Drawing.Point(428, 137);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(92, 18);
            this.lblEmpID.TabIndex = 13;
            this.lblEmpID.Text = "Employee ID";
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEmpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmpEmail.Location = new System.Drawing.Point(86, 137);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmpEmail.TabIndex = 12;
            this.lblEmpEmail.Text = "Email";
            // 
            // txtEmpNID
            // 
            this.txtEmpNID.Location = new System.Drawing.Point(484, 98);
            this.txtEmpNID.Name = "txtEmpNID";
            this.txtEmpNID.Size = new System.Drawing.Size(219, 20);
            this.txtEmpNID.TabIndex = 11;
            // 
            // lblEmpNID
            // 
            this.lblEmpNID.AutoSize = true;
            this.lblEmpNID.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEmpNID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmpNID.Location = new System.Drawing.Point(428, 100);
            this.lblEmpNID.Name = "lblEmpNID";
            this.lblEmpNID.Size = new System.Drawing.Size(33, 18);
            this.lblEmpNID.TabIndex = 10;
            this.lblEmpNID.Text = "NID";
            // 
            // cmbxEmpCategory
            // 
            this.cmbxEmpCategory.DataSource = this.empCategoryBindingSource;
            this.cmbxEmpCategory.DisplayMember = "Category";
            this.cmbxEmpCategory.FormattingEnabled = true;
            this.cmbxEmpCategory.Location = new System.Drawing.Point(529, 51);
            this.cmbxEmpCategory.Name = "cmbxEmpCategory";
            this.cmbxEmpCategory.Size = new System.Drawing.Size(152, 21);
            this.cmbxEmpCategory.TabIndex = 9;
            this.cmbxEmpCategory.ValueMember = "EmpCatID";
            // 
            // empCategoryBindingSource
            // 
            this.empCategoryBindingSource.DataMember = "EmpCategory";
            this.empCategoryBindingSource.DataSource = this.bus_Ticket_ReservationDataSet2;
            // 
            // bus_Ticket_ReservationDataSet2
            // 
            this.bus_Ticket_ReservationDataSet2.DataSetName = "Bus_Ticket_ReservationDataSet2";
            this.bus_Ticket_ReservationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(188, 100);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(219, 20);
            this.txtCellPhone.TabIndex = 8;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(150, 49);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(219, 20);
            this.txtEmpName.TabIndex = 4;
            // 
            // lblEmpCellPhone
            // 
            this.lblEmpCellPhone.AutoSize = true;
            this.lblEmpCellPhone.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEmpCellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpCellPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmpCellPhone.Location = new System.Drawing.Point(86, 100);
            this.lblEmpCellPhone.Name = "lblEmpCellPhone";
            this.lblEmpCellPhone.Size = new System.Drawing.Size(80, 18);
            this.lblEmpCellPhone.TabIndex = 2;
            this.lblEmpCellPhone.Text = "Cell Phone";
            // 
            // lblEmpCat
            // 
            this.lblEmpCat.AutoSize = true;
            this.lblEmpCat.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEmpCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmpCat.Location = new System.Drawing.Point(431, 51);
            this.lblEmpCat.Name = "lblEmpCat";
            this.lblEmpCat.Size = new System.Drawing.Size(68, 18);
            this.lblEmpCat.TabIndex = 1;
            this.lblEmpCat.Text = "Category";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmpName.Location = new System.Drawing.Point(86, 51);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(48, 18);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "Name";
            // 
            // tbPageTktPurchase
            // 
            this.tbPageTktPurchase.Controls.Add(this.btnPassDelete);
            this.tbPageTktPurchase.Controls.Add(this.btnPassUpdate);
            this.tbPageTktPurchase.Controls.Add(this.btnPassInsert);
            this.tbPageTktPurchase.Controls.Add(this.chkBxPassConfirm);
            this.tbPageTktPurchase.Controls.Add(this.lblPassConfirm);
            this.tbPageTktPurchase.Controls.Add(this.cmbxPassSchedule);
            this.tbPageTktPurchase.Controls.Add(this.cmbxPassBus);
            this.tbPageTktPurchase.Controls.Add(this.lblPassSchedule);
            this.tbPageTktPurchase.Controls.Add(this.lblPassBus);
            this.tbPageTktPurchase.Controls.Add(this.txtPassVat);
            this.tbPageTktPurchase.Controls.Add(this.lblPassVat);
            this.tbPageTktPurchase.Controls.Add(this.txtPassUnitFare);
            this.tbPageTktPurchase.Controls.Add(this.lblPassUntFre);
            this.tbPageTktPurchase.Controls.Add(this.txtPassTBkdStNo);
            this.tbPageTktPurchase.Controls.Add(this.lblPassTBkdStNo);
            this.tbPageTktPurchase.Controls.Add(this.txtPassBkdSeatNo);
            this.tbPageTktPurchase.Controls.Add(this.lblPassBookedSeatNo);
            this.tbPageTktPurchase.Controls.Add(this.dtpPassJourneyDate);
            this.tbPageTktPurchase.Controls.Add(this.lblPassJrnyDate);
            this.tbPageTktPurchase.Controls.Add(this.txtPassNID);
            this.tbPageTktPurchase.Controls.Add(this.txtPassEmail);
            this.tbPageTktPurchase.Controls.Add(this.txtPassPhone);
            this.tbPageTktPurchase.Controls.Add(this.txtPassName);
            this.tbPageTktPurchase.Controls.Add(this.lblPassNID);
            this.tbPageTktPurchase.Controls.Add(this.lblPassEmail);
            this.tbPageTktPurchase.Controls.Add(this.lblPassPhone);
            this.tbPageTktPurchase.Controls.Add(this.lblPassName);
            this.tbPageTktPurchase.Location = new System.Drawing.Point(4, 22);
            this.tbPageTktPurchase.Name = "tbPageTktPurchase";
            this.tbPageTktPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageTktPurchase.Size = new System.Drawing.Size(797, 427);
            this.tbPageTktPurchase.TabIndex = 3;
            this.tbPageTktPurchase.Text = "Ticket Purchase";
            this.tbPageTktPurchase.UseVisualStyleBackColor = true;
            // 
            // btnPassDelete
            // 
            this.btnPassDelete.Location = new System.Drawing.Point(240, 253);
            this.btnPassDelete.Name = "btnPassDelete";
            this.btnPassDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPassDelete.TabIndex = 28;
            this.btnPassDelete.Text = "Delete";
            this.btnPassDelete.UseVisualStyleBackColor = true;
            // 
            // btnPassUpdate
            // 
            this.btnPassUpdate.Location = new System.Drawing.Point(132, 253);
            this.btnPassUpdate.Name = "btnPassUpdate";
            this.btnPassUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnPassUpdate.TabIndex = 27;
            this.btnPassUpdate.Text = "Update";
            this.btnPassUpdate.UseVisualStyleBackColor = true;
            // 
            // btnPassInsert
            // 
            this.btnPassInsert.Location = new System.Drawing.Point(24, 253);
            this.btnPassInsert.Name = "btnPassInsert";
            this.btnPassInsert.Size = new System.Drawing.Size(75, 23);
            this.btnPassInsert.TabIndex = 26;
            this.btnPassInsert.Text = "Insert";
            this.btnPassInsert.UseVisualStyleBackColor = true;
            this.btnPassInsert.Click += new System.EventHandler(this.btnPassInsert_Click);
            // 
            // chkBxPassConfirm
            // 
            this.chkBxPassConfirm.AutoSize = true;
            this.chkBxPassConfirm.Location = new System.Drawing.Point(579, 205);
            this.chkBxPassConfirm.Name = "chkBxPassConfirm";
            this.chkBxPassConfirm.Size = new System.Drawing.Size(44, 17);
            this.chkBxPassConfirm.TabIndex = 25;
            this.chkBxPassConfirm.Text = "Yes";
            this.chkBxPassConfirm.UseVisualStyleBackColor = true;
            // 
            // lblPassConfirm
            // 
            this.lblPassConfirm.AutoSize = true;
            this.lblPassConfirm.Location = new System.Drawing.Point(530, 205);
            this.lblPassConfirm.Name = "lblPassConfirm";
            this.lblPassConfirm.Size = new System.Drawing.Size(42, 13);
            this.lblPassConfirm.TabIndex = 24;
            this.lblPassConfirm.Text = "Confirm";
            // 
            // cmbxPassSchedule
            // 
            this.cmbxPassSchedule.DataSource = this.scheduleBindingSource;
            this.cmbxPassSchedule.DisplayMember = "DepartureTime";
            this.cmbxPassSchedule.FormattingEnabled = true;
            this.cmbxPassSchedule.Location = new System.Drawing.Point(341, 200);
            this.cmbxPassSchedule.Name = "cmbxPassSchedule";
            this.cmbxPassSchedule.Size = new System.Drawing.Size(121, 21);
            this.cmbxPassSchedule.TabIndex = 23;
            this.cmbxPassSchedule.ValueMember = "ScheduleID";
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.bus_Ticket_ReservationDataSet4;
            // 
            // bus_Ticket_ReservationDataSet4
            // 
            this.bus_Ticket_ReservationDataSet4.DataSetName = "Bus_Ticket_ReservationDataSet4";
            this.bus_Ticket_ReservationDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbxPassBus
            // 
            this.cmbxPassBus.DataSource = this.busBindingSource;
            this.cmbxPassBus.DisplayMember = "BusNumber";
            this.cmbxPassBus.FormattingEnabled = true;
            this.cmbxPassBus.Location = new System.Drawing.Point(59, 197);
            this.cmbxPassBus.Name = "cmbxPassBus";
            this.cmbxPassBus.Size = new System.Drawing.Size(121, 21);
            this.cmbxPassBus.TabIndex = 22;
            this.cmbxPassBus.ValueMember = "BusID";
            // 
            // lblPassSchedule
            // 
            this.lblPassSchedule.AutoSize = true;
            this.lblPassSchedule.Location = new System.Drawing.Point(265, 204);
            this.lblPassSchedule.Name = "lblPassSchedule";
            this.lblPassSchedule.Size = new System.Drawing.Size(52, 13);
            this.lblPassSchedule.TabIndex = 20;
            this.lblPassSchedule.Text = "Schedule";
            // 
            // lblPassBus
            // 
            this.lblPassBus.AutoSize = true;
            this.lblPassBus.Location = new System.Drawing.Point(12, 200);
            this.lblPassBus.Name = "lblPassBus";
            this.lblPassBus.Size = new System.Drawing.Size(25, 13);
            this.lblPassBus.TabIndex = 18;
            this.lblPassBus.Text = "Bus";
            // 
            // txtPassVat
            // 
            this.txtPassVat.Location = new System.Drawing.Point(651, 162);
            this.txtPassVat.Name = "txtPassVat";
            this.txtPassVat.Size = new System.Drawing.Size(107, 20);
            this.txtPassVat.TabIndex = 17;
            // 
            // lblPassVat
            // 
            this.lblPassVat.AutoSize = true;
            this.lblPassVat.Location = new System.Drawing.Point(595, 165);
            this.lblPassVat.Name = "lblPassVat";
            this.lblPassVat.Size = new System.Drawing.Size(23, 13);
            this.lblPassVat.TabIndex = 16;
            this.lblPassVat.Text = "Vat";
            // 
            // txtPassUnitFare
            // 
            this.txtPassUnitFare.Location = new System.Drawing.Point(417, 165);
            this.txtPassUnitFare.Name = "txtPassUnitFare";
            this.txtPassUnitFare.Size = new System.Drawing.Size(146, 20);
            this.txtPassUnitFare.TabIndex = 15;
            // 
            // lblPassUntFre
            // 
            this.lblPassUntFre.AutoSize = true;
            this.lblPassUntFre.Location = new System.Drawing.Point(360, 169);
            this.lblPassUntFre.Name = "lblPassUntFre";
            this.lblPassUntFre.Size = new System.Drawing.Size(50, 13);
            this.lblPassUntFre.TabIndex = 14;
            this.lblPassUntFre.Text = "Unit Fare";
            // 
            // txtPassTBkdStNo
            // 
            this.txtPassTBkdStNo.Location = new System.Drawing.Point(132, 159);
            this.txtPassTBkdStNo.Name = "txtPassTBkdStNo";
            this.txtPassTBkdStNo.Size = new System.Drawing.Size(146, 20);
            this.txtPassTBkdStNo.TabIndex = 13;
            // 
            // lblPassTBkdStNo
            // 
            this.lblPassTBkdStNo.AutoSize = true;
            this.lblPassTBkdStNo.Location = new System.Drawing.Point(13, 162);
            this.lblPassTBkdStNo.Name = "lblPassTBkdStNo";
            this.lblPassTBkdStNo.Size = new System.Drawing.Size(113, 13);
            this.lblPassTBkdStNo.TabIndex = 12;
            this.lblPassTBkdStNo.Text = "Total Booked Seat No";
            // 
            // txtPassBkdSeatNo
            // 
            this.txtPassBkdSeatNo.Location = new System.Drawing.Point(506, 119);
            this.txtPassBkdSeatNo.Name = "txtPassBkdSeatNo";
            this.txtPassBkdSeatNo.Size = new System.Drawing.Size(146, 20);
            this.txtPassBkdSeatNo.TabIndex = 11;
            // 
            // lblPassBookedSeatNo
            // 
            this.lblPassBookedSeatNo.AutoSize = true;
            this.lblPassBookedSeatNo.Location = new System.Drawing.Point(414, 122);
            this.lblPassBookedSeatNo.Name = "lblPassBookedSeatNo";
            this.lblPassBookedSeatNo.Size = new System.Drawing.Size(86, 13);
            this.lblPassBookedSeatNo.TabIndex = 10;
            this.lblPassBookedSeatNo.Text = "Booked Seat No";
            // 
            // dtpPassJourneyDate
            // 
            this.dtpPassJourneyDate.Location = new System.Drawing.Point(115, 122);
            this.dtpPassJourneyDate.Name = "dtpPassJourneyDate";
            this.dtpPassJourneyDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPassJourneyDate.TabIndex = 9;
            // 
            // lblPassJrnyDate
            // 
            this.lblPassJrnyDate.AutoSize = true;
            this.lblPassJrnyDate.Location = new System.Drawing.Point(21, 122);
            this.lblPassJrnyDate.Name = "lblPassJrnyDate";
            this.lblPassJrnyDate.Size = new System.Drawing.Size(70, 13);
            this.lblPassJrnyDate.TabIndex = 8;
            this.lblPassJrnyDate.Text = "Journey Date";
            // 
            // txtPassNID
            // 
            this.txtPassNID.Location = new System.Drawing.Point(473, 84);
            this.txtPassNID.Name = "txtPassNID";
            this.txtPassNID.Size = new System.Drawing.Size(146, 20);
            this.txtPassNID.TabIndex = 7;
            // 
            // txtPassEmail
            // 
            this.txtPassEmail.Location = new System.Drawing.Point(115, 80);
            this.txtPassEmail.Name = "txtPassEmail";
            this.txtPassEmail.Size = new System.Drawing.Size(146, 20);
            this.txtPassEmail.TabIndex = 6;
            // 
            // txtPassPhone
            // 
            this.txtPassPhone.Location = new System.Drawing.Point(473, 47);
            this.txtPassPhone.Name = "txtPassPhone";
            this.txtPassPhone.Size = new System.Drawing.Size(146, 20);
            this.txtPassPhone.TabIndex = 5;
            // 
            // txtPassName
            // 
            this.txtPassName.Location = new System.Drawing.Point(115, 47);
            this.txtPassName.Name = "txtPassName";
            this.txtPassName.Size = new System.Drawing.Size(146, 20);
            this.txtPassName.TabIndex = 4;
            // 
            // lblPassNID
            // 
            this.lblPassNID.AutoSize = true;
            this.lblPassNID.Location = new System.Drawing.Point(414, 87);
            this.lblPassNID.Name = "lblPassNID";
            this.lblPassNID.Size = new System.Drawing.Size(26, 13);
            this.lblPassNID.TabIndex = 3;
            this.lblPassNID.Text = "NID";
            // 
            // lblPassEmail
            // 
            this.lblPassEmail.AutoSize = true;
            this.lblPassEmail.Location = new System.Drawing.Point(21, 83);
            this.lblPassEmail.Name = "lblPassEmail";
            this.lblPassEmail.Size = new System.Drawing.Size(32, 13);
            this.lblPassEmail.TabIndex = 2;
            this.lblPassEmail.Text = "Email";
            // 
            // lblPassPhone
            // 
            this.lblPassPhone.AutoSize = true;
            this.lblPassPhone.Location = new System.Drawing.Point(414, 47);
            this.lblPassPhone.Name = "lblPassPhone";
            this.lblPassPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPassPhone.TabIndex = 1;
            this.lblPassPhone.Text = "Phone";
            // 
            // lblPassName
            // 
            this.lblPassName.AutoSize = true;
            this.lblPassName.Location = new System.Drawing.Point(21, 47);
            this.lblPassName.Name = "lblPassName";
            this.lblPassName.Size = new System.Drawing.Size(88, 13);
            this.lblPassName.TabIndex = 0;
            this.lblPassName.Text = "Passenger Name";
            // 
            // busCategoryTableAdapter
            // 
            this.busCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // busTableAdapter
            // 
            this.busTableAdapter.ClearBeforeFill = true;
            // 
            // empCategoryTableAdapter
            // 
            this.empCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tbPageReport
            // 
            this.tbPageReport.Controls.Add(this.crystalReportViewerEmp);
            this.tbPageReport.Location = new System.Drawing.Point(4, 22);
            this.tbPageReport.Name = "tbPageReport";
            this.tbPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageReport.Size = new System.Drawing.Size(797, 427);
            this.tbPageReport.TabIndex = 4;
            this.tbPageReport.Text = "Report";
            this.tbPageReport.UseVisualStyleBackColor = true;
            this.tbPageReport.Click += new System.EventHandler(this.tbPageReport_Click);
            // 
            // crystalReportViewerEmp
            // 
            this.crystalReportViewerEmp.ActiveViewIndex = -1;
            this.crystalReportViewerEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerEmp.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerEmp.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewerEmp.Name = "crystalReportViewerEmp";
            this.crystalReportViewerEmp.ReportSource = this.rptEmloyeeInformaiton2;
            this.crystalReportViewerEmp.Size = new System.Drawing.Size(791, 421);
            this.crystalReportViewerEmp.TabIndex = 0;
            this.crystalReportViewerEmp.Load += new System.EventHandler(this.crystalReportViewerEmp_Load);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCtrlInformationPage);
            this.Name = "Information";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            this.tbCtrlInformationPage.ResumeLayout(false);
            this.tbPageHome.ResumeLayout(false);
            this.tbPageHome.PerformLayout();
            this.tbPageBus.ResumeLayout(false);
            this.tbPageBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_Ticket_ReservationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_Ticket_ReservationDataSet)).EndInit();
            this.tbPageEmployee.ResumeLayout(false);
            this.tbPageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_Ticket_ReservationDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_Ticket_ReservationDataSet2)).EndInit();
            this.tbPageTktPurchase.ResumeLayout(false);
            this.tbPageTktPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_Ticket_ReservationDataSet4)).EndInit();
            this.tbPageReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCtrlInformationPage;
        private System.Windows.Forms.TabPage tbPageHome;
        private System.Windows.Forms.TabPage tbPageBus;
        private System.Windows.Forms.TabPage tbPageEmployee;
        private System.Windows.Forms.TabPage tbPageTktPurchase;
        private System.Windows.Forms.Label lblABC;
        private System.Windows.Forms.TextBox txtBxBusNumber;
        private System.Windows.Forms.Label lblBusNumber;
        private System.Windows.Forms.ComboBox cmbxBusCategory;
        private System.Windows.Forms.Label lblBusCat;
        private System.Windows.Forms.Label lblNewBus;
        private Bus_Ticket_ReservationDataSet bus_Ticket_ReservationDataSet;
        private System.Windows.Forms.BindingSource busCategoryBindingSource;
        private Bus_Ticket_ReservationDataSetTableAdapters.BusCategoryTableAdapter busCategoryTableAdapter;
        private System.Windows.Forms.TextBox txtBxTotalActiveSeat;
        private System.Windows.Forms.Label lblActiveSeat;
        private System.Windows.Forms.TextBox txtBxTotalSeat;
        private System.Windows.Forms.Label lblTotalSeat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkBxIsActive;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtBxTicketPrice;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblTicketPrice;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpCat;
        private System.Windows.Forms.Label lblEmpCellPhone;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Button btnBusInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bus_Ticket_ReservationDataSet1 bus_Ticket_ReservationDataSet1;
        private System.Windows.Forms.BindingSource busBindingSource;
        private Bus_Ticket_ReservationDataSet1TableAdapters.BusTableAdapter busTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busCatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfActiveSeatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbxBusID;
        private System.Windows.Forms.Label lblBusID;
        private System.Windows.Forms.Button btnBusDelete;
        private System.Windows.Forms.Button btnBusUpdate;
        private System.Windows.Forms.ComboBox cmbxEmpID;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.TextBox txtEmpNID;
        private System.Windows.Forms.Label lblEmpNID;
        private System.Windows.Forms.ComboBox cmbxEmpCategory;
        private System.Windows.Forms.TextBox txtCellPhone;
        private Bus_Ticket_ReservationDataSet2 bus_Ticket_ReservationDataSet2;
        private System.Windows.Forms.BindingSource empCategoryBindingSource;
        private Bus_Ticket_ReservationDataSet2TableAdapters.EmpCategoryTableAdapter empCategoryTableAdapter;
        private Bus_Ticket_ReservationDataSet3 bus_Ticket_ReservationDataSet3;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Bus_Ticket_ReservationDataSet3TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEmpDelete;
        private System.Windows.Forms.Button btnEmpInsert;
        private System.Windows.Forms.Button btnEmpUpdate;
        private System.Windows.Forms.Button btnEmpReset;
        private System.Windows.Forms.TextBox txtPassNID;
        private System.Windows.Forms.TextBox txtPassEmail;
        private System.Windows.Forms.TextBox txtPassPhone;
        private System.Windows.Forms.TextBox txtPassName;
        private System.Windows.Forms.Label lblPassNID;
        private System.Windows.Forms.Label lblPassEmail;
        private System.Windows.Forms.Label lblPassPhone;
        private System.Windows.Forms.Label lblPassName;
        private System.Windows.Forms.DateTimePicker dtpPassJourneyDate;
        private System.Windows.Forms.Label lblPassJrnyDate;
        private System.Windows.Forms.TextBox txtPassTBkdStNo;
        private System.Windows.Forms.Label lblPassTBkdStNo;
        private System.Windows.Forms.TextBox txtPassBkdSeatNo;
        private System.Windows.Forms.Label lblPassBookedSeatNo;
        private System.Windows.Forms.TextBox txtPassUnitFare;
        private System.Windows.Forms.Label lblPassUntFre;
        private System.Windows.Forms.Label lblPassSchedule;
        private System.Windows.Forms.Label lblPassBus;
        private System.Windows.Forms.TextBox txtPassVat;
        private System.Windows.Forms.Label lblPassVat;
        private System.Windows.Forms.ComboBox cmbxPassBus;
        private System.Windows.Forms.ComboBox cmbxPassSchedule;
        private System.Windows.Forms.Button btnPassDelete;
        private System.Windows.Forms.Button btnPassUpdate;
        private System.Windows.Forms.Button btnPassInsert;
        private System.Windows.Forms.CheckBox chkBxPassConfirm;
        private System.Windows.Forms.Label lblPassConfirm;
        private Bus_Ticket_ReservationDataSet4 bus_Ticket_ReservationDataSet4;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private Bus_Ticket_ReservationDataSet4TableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.TabPage tbPageReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerEmp;
        private Reports.rptEmloyeeInformaiton rptEmloyeeInformaiton1;
        private Reports.rptEmloyeeInformaiton rptEmloyeeInformaiton2;
    }
}