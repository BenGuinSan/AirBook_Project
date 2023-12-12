namespace GUI
{
    partial class Signup
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
            this.aIRBOOKDataSet = new GUI.AIRBOOKDataSet();
            this.actionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionsTableAdapter = new GUI.AIRBOOKDataSetTableAdapters.actionsTableAdapter();
            this.tableAdapterManager = new GUI.AIRBOOKDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCCCD = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectedDoB = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.selectedGender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRealname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConfirmPwD = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPwD = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSignup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDNBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.aIRBOOKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedGender)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // aIRBOOKDataSet
            // 
            this.aIRBOOKDataSet.DataSetName = "AIRBOOKDataSet";
            this.aIRBOOKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actionsBindingSource
            // 
            this.actionsBindingSource.DataMember = "actions";
            this.actionsBindingSource.DataSource = this.aIRBOOKDataSet;
            // 
            // actionsTableAdapter
            // 
            this.actionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.actionsTableAdapter = this.actionsTableAdapter;
            this.tableAdapterManager.airlinesTableAdapter = null;
            this.tableAdapterManager.airport_gatesTableAdapter = null;
            this.tableAdapterManager.airportsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.flightsTableAdapter = null;
            this.tableAdapterManager.more_luggageTableAdapter = null;
            this.tableAdapterManager.order_detailsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.permissionTableAdapter = null;
            this.tableAdapterManager.planesTableAdapter = null;
            this.tableAdapterManager.promotionsTableAdapter = null;
            this.tableAdapterManager.receiversTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.seatsTableAdapter = null;
            this.tableAdapterManager.ticket_classesTableAdapter = null;
            this.tableAdapterManager.ticketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.AIRBOOKDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = global::GUI.Properties.Resources.log_header_logo;
            this.pictureBox1.Image = global::GUI.Properties.Resources.log_header_logo;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(204, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đăng ký tài khoản mới";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label2.Location = new System.Drawing.Point(33, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin tài khoản";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtNation);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCCCD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.selectedDoB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.selectedGender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtRealname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(27, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 274);
            this.panel1.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(125, 226);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(176, 31);
            this.txtPhone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhone.StateCommon.Border.Rounding = 6;
            this.txtPhone.StateCommon.Border.Width = 1;
            this.txtPhone.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Số điện thoại";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(125, 190);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(176, 31);
            this.txtAddress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddress.StateCommon.Border.Rounding = 6;
            this.txtAddress.StateCommon.Border.Width = 1;
            this.txtAddress.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Địa chỉ";
            // 
            // txtNation
            // 
            this.txtNation.Location = new System.Drawing.Point(125, 153);
            this.txtNation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(176, 31);
            this.txtNation.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNation.StateCommon.Border.Rounding = 6;
            this.txtNation.StateCommon.Border.Width = 1;
            this.txtNation.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quốc gia";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(125, 116);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(176, 31);
            this.txtCCCD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCCCD.StateCommon.Border.Rounding = 6;
            this.txtCCCD.StateCommon.Border.Width = 1;
            this.txtCCCD.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số CCCD";
            // 
            // selectedDoB
            // 
            this.selectedDoB.CustomFormat = "dd-MM-yyyy";
            this.selectedDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectedDoB.Location = new System.Drawing.Point(125, 81);
            this.selectedDoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectedDoB.Name = "selectedDoB";
            this.selectedDoB.Size = new System.Drawing.Size(176, 29);
            this.selectedDoB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.selectedDoB.StateCommon.Border.Rounding = 6;
            this.selectedDoB.StateCommon.Border.Width = 1;
            this.selectedDoB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh";
            // 
            // selectedGender
            // 
            this.selectedGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedGender.DropDownWidth = 172;
            this.selectedGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.selectedGender.Location = new System.Drawing.Point(125, 46);
            this.selectedGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectedGender.Name = "selectedGender";
            this.selectedGender.Size = new System.Drawing.Size(176, 29);
            this.selectedGender.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.selectedGender.StateCommon.ComboBox.Border.Rounding = 6;
            this.selectedGender.StateCommon.ComboBox.Border.Width = 1;
            this.selectedGender.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // txtRealname
            // 
            this.txtRealname.Location = new System.Drawing.Point(125, 9);
            this.txtRealname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRealname.Name = "txtRealname";
            this.txtRealname.Size = new System.Drawing.Size(176, 31);
            this.txtRealname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRealname.StateCommon.Border.Rounding = 6;
            this.txtRealname.StateCommon.Border.Width = 1;
            this.txtRealname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và tên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label10.Location = new System.Drawing.Point(381, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Thông tin đăng nhập";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtConfirmPwD);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.txtPwD);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(376, 171);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 169);
            this.panel2.TabIndex = 6;
            // 
            // txtConfirmPwD
            // 
            this.txtConfirmPwD.Location = new System.Drawing.Point(175, 121);
            this.txtConfirmPwD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPwD.Name = "txtConfirmPwD";
            this.txtConfirmPwD.PasswordChar = '*';
            this.txtConfirmPwD.Size = new System.Drawing.Size(157, 31);
            this.txtConfirmPwD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtConfirmPwD.StateCommon.Border.Rounding = 6;
            this.txtConfirmPwD.StateCommon.Border.Width = 1;
            this.txtConfirmPwD.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(175, 46);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(157, 31);
            this.txtUsername.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.Rounding = 6;
            this.txtUsername.StateCommon.Border.Width = 1;
            this.txtUsername.TabIndex = 8;
            // 
            // txtPwD
            // 
            this.txtPwD.Location = new System.Drawing.Point(175, 82);
            this.txtPwD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPwD.Name = "txtPwD";
            this.txtPwD.PasswordChar = '*';
            this.txtPwD.Size = new System.Drawing.Size(157, 31);
            this.txtPwD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPwD.StateCommon.Border.Rounding = 6;
            this.txtPwD.StateCommon.Border.Width = 1;
            this.txtPwD.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Xác nhận mật khẩu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Mật khẩu";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(5, 46);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(78, 16);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Username";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(175, 9);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 31);
            this.txtEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Rounding = 6;
            this.txtEmail.StateCommon.Border.Width = 1;
            this.txtEmail.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Email";
            // 
            // btnSignup
            // 
            this.btnSignup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignup.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSignup.Location = new System.Drawing.Point(376, 348);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSignup.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSignup.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSignup.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSignup.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSignup.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSignup.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignup.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSignup.OverrideDefault.Border.Rounding = 6;
            this.btnSignup.OverrideDefault.Border.Width = 1;
            this.btnSignup.Size = new System.Drawing.Size(336, 44);
            this.btnSignup.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSignup.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSignup.StateCommon.Back.ColorAngle = 45F;
            this.btnSignup.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSignup.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSignup.StateCommon.Border.ColorAngle = 45F;
            this.btnSignup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignup.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSignup.StateCommon.Border.Rounding = 6;
            this.btnSignup.StateCommon.Border.Width = 1;
            this.btnSignup.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSignup.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSignup.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(124)))));
            this.btnSignup.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(124)))));
            this.btnSignup.StatePressed.Back.ColorAngle = 130F;
            this.btnSignup.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(124)))));
            this.btnSignup.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(124)))));
            this.btnSignup.StatePressed.Border.ColorAngle = 130F;
            this.btnSignup.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignup.StatePressed.Border.Rounding = 6;
            this.btnSignup.StatePressed.Border.Width = 1;
            this.btnSignup.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSignup.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSignup.StateTracking.Back.ColorAngle = 45F;
            this.btnSignup.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSignup.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnSignup.StateTracking.Border.ColorAngle = 45F;
            this.btnSignup.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignup.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSignup.StateTracking.Border.Rounding = 6;
            this.btnSignup.StateTracking.Border.Width = 1;
            this.btnSignup.TabIndex = 7;
            this.btnSignup.Values.Image = global::GUI.Properties.Resources.action_add_white18;
            this.btnSignup.Values.Text = "Đăng ký";
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnDNBack
            // 
            this.btnDNBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDNBack.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btnDNBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDNBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDNBack.Location = new System.Drawing.Point(376, 401);
            this.btnDNBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDNBack.Name = "btnDNBack";
            this.btnDNBack.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnDNBack.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnDNBack.OverrideDefault.Back.ColorAngle = 45F;
            this.btnDNBack.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnDNBack.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnDNBack.OverrideDefault.Border.ColorAngle = 45F;
            this.btnDNBack.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDNBack.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDNBack.OverrideDefault.Border.Rounding = 6;
            this.btnDNBack.OverrideDefault.Border.Width = 1;
            this.btnDNBack.Size = new System.Drawing.Size(336, 44);
            this.btnDNBack.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnDNBack.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnDNBack.StateCommon.Back.ColorAngle = 45F;
            this.btnDNBack.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnDNBack.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnDNBack.StateCommon.Border.ColorAngle = 45F;
            this.btnDNBack.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDNBack.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDNBack.StateCommon.Border.Rounding = 6;
            this.btnDNBack.StateCommon.Border.Width = 1;
            this.btnDNBack.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnDNBack.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnDNBack.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnDNBack.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnDNBack.StatePressed.Back.ColorAngle = 130F;
            this.btnDNBack.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnDNBack.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnDNBack.StatePressed.Border.ColorAngle = 130F;
            this.btnDNBack.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDNBack.StatePressed.Border.Rounding = 6;
            this.btnDNBack.StatePressed.Border.Width = 1;
            this.btnDNBack.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnDNBack.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnDNBack.StateTracking.Back.ColorAngle = 45F;
            this.btnDNBack.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnDNBack.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnDNBack.StateTracking.Border.ColorAngle = 45F;
            this.btnDNBack.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDNBack.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDNBack.StateTracking.Border.Rounding = 6;
            this.btnDNBack.StateTracking.Border.Width = 1;
            this.btnDNBack.TabIndex = 8;
            this.btnDNBack.Values.Image = global::GUI.Properties.Resources.action_login_black20;
            this.btnDNBack.Values.Text = "Đăng nhập";
            this.btnDNBack.Click += new System.EventHandler(this.btnDNBack_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 572);
            this.Controls.Add(this.btnDNBack);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Signup";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aIRBOOKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedGender)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AIRBOOKDataSet aIRBOOKDataSet;
        private System.Windows.Forms.BindingSource actionsBindingSource;
        private AIRBOOKDataSetTableAdapters.actionsTableAdapter actionsTableAdapter;
        private AIRBOOKDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRealname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox selectedGender;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker selectedDoB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCCCD;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNation;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.Label label17;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPwD;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtConfirmPwD;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSignup;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDNBack;
    }
}