namespace AirBook_Project
{
    partial class SignUpFr
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnMini = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPW = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPWCF = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timePick = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnCreateUsers = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPrePage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnPrePage);
            this.kryptonPanel1.Controls.Add(this.btnMini);
            this.kryptonPanel1.Controls.Add(this.btnExit);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(123, 18, 123, 17);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.kryptonPanel1.Size = new System.Drawing.Size(360, 62);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.kryptonPanel1.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kryptonPanel1.TabIndex = 2;
            this.kryptonPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel1_MouseDown);
            this.kryptonPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel1_MouseMove);
            this.kryptonPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel1_MouseUp);
            // 
            // btnMini
            // 
            this.btnMini.AutoSize = true;
            this.btnMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Location = new System.Drawing.Point(309, 9);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(14, 18);
            this.btnMini.TabIndex = 13;
            this.btnMini.Text = "-";
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            this.btnMini.MouseLeave += new System.EventHandler(this.btnMini_MouseLeave);
            this.btnMini.MouseHover += new System.EventHandler(this.btnMini_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(329, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(19, 18);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.ColorAngle = 45F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.ColorAngle = 45F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Width = 1;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(127, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(22, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(182, 169);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 31);
            this.txtEmail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Rounding = 6;
            this.txtEmail.StateCommon.Border.Width = 1;
            this.txtEmail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label4.Location = new System.Drawing.Point(22, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mật khẩu";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(182, 208);
            this.txtPW.Margin = new System.Windows.Forms.Padding(4);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(156, 31);
            this.txtPW.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPW.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPW.StateCommon.Border.Rounding = 6;
            this.txtPW.StateCommon.Border.Width = 1;
            this.txtPW.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label5.Location = new System.Drawing.Point(22, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // txtPWCF
            // 
            this.txtPWCF.Location = new System.Drawing.Point(182, 247);
            this.txtPWCF.Margin = new System.Windows.Forms.Padding(4);
            this.txtPWCF.Name = "txtPWCF";
            this.txtPWCF.PasswordChar = '*';
            this.txtPWCF.Size = new System.Drawing.Size(156, 31);
            this.txtPWCF.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPWCF.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPWCF.StateCommon.Border.Rounding = 6;
            this.txtPWCF.StateCommon.Border.Width = 1;
            this.txtPWCF.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.panel1.Location = new System.Drawing.Point(25, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 1);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label6.Location = new System.Drawing.Point(22, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thông tin cá nhân";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label7.Location = new System.Drawing.Point(22, 376);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Họ và tên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 363);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 31);
            this.txtName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateCommon.Border.Rounding = 6;
            this.txtName.StateCommon.Border.Width = 1;
            this.txtName.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label8.Location = new System.Drawing.Point(22, 412);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ngày sinh";
            // 
            // timePick
            // 
            this.timePick.CustomFormat = "dd/MM/yyyy";
            this.timePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePick.Location = new System.Drawing.Point(182, 401);
            this.timePick.Name = "timePick";
            this.timePick.Palette = this.kryptonPalette1;
            this.timePick.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.timePick.Size = new System.Drawing.Size(156, 29);
            this.timePick.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.timePick.StateCommon.Border.Rounding = 6;
            this.timePick.StateCommon.Border.Width = 1;
            this.timePick.TabIndex = 19;
            this.timePick.ValueNullable = new System.DateTime(2023, 11, 4, 19, 43, 48, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label9.Location = new System.Drawing.Point(22, 450);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Số CCCD";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(181, 437);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(156, 31);
            this.txtID.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtID.StateCommon.Border.Rounding = 6;
            this.txtID.StateCommon.Border.Width = 1;
            this.txtID.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label10.Location = new System.Drawing.Point(22, 489);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Quốc gia";
            // 
            // txtNation
            // 
            this.txtNation.Location = new System.Drawing.Point(182, 476);
            this.txtNation.Margin = new System.Windows.Forms.Padding(4);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(156, 31);
            this.txtNation.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtNation.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNation.StateCommon.Border.Rounding = 6;
            this.txtNation.StateCommon.Border.Width = 1;
            this.txtNation.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label11.Location = new System.Drawing.Point(22, 528);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(182, 515);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(156, 31);
            this.txtAddress.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtAddress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddress.StateCommon.Border.Rounding = 6;
            this.txtAddress.StateCommon.Border.Width = 1;
            this.txtAddress.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label12.Location = new System.Drawing.Point(22, 567);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Số điện thoại";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(181, 554);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(156, 31);
            this.txtPhone.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPhone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhone.StateCommon.Border.Rounding = 6;
            this.txtPhone.StateCommon.Border.Width = 1;
            this.txtPhone.TabIndex = 27;
            // 
            // btnCreateUsers
            // 
            this.btnCreateUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateUsers.Location = new System.Drawing.Point(25, 614);
            this.btnCreateUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateUsers.Name = "btnCreateUsers";
            this.btnCreateUsers.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCreateUsers.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCreateUsers.OverrideDefault.Back.ColorAngle = 45F;
            this.btnCreateUsers.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCreateUsers.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCreateUsers.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreateUsers.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCreateUsers.OverrideDefault.Border.Rounding = 6;
            this.btnCreateUsers.OverrideDefault.Border.Width = 1;
            this.btnCreateUsers.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCreateUsers.Size = new System.Drawing.Size(312, 34);
            this.btnCreateUsers.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCreateUsers.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCreateUsers.StateCommon.Back.ColorAngle = 45F;
            this.btnCreateUsers.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCreateUsers.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnCreateUsers.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCreateUsers.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCreateUsers.StateCommon.Border.ColorAngle = 45F;
            this.btnCreateUsers.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreateUsers.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCreateUsers.StateCommon.Border.Rounding = 6;
            this.btnCreateUsers.StateCommon.Border.Width = 1;
            this.btnCreateUsers.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCreateUsers.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCreateUsers.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCreateUsers.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCreateUsers.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCreateUsers.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCreateUsers.StatePressed.Back.Color1 = System.Drawing.Color.Teal;
            this.btnCreateUsers.StatePressed.Back.Color2 = System.Drawing.Color.Teal;
            this.btnCreateUsers.StatePressed.Back.ColorAngle = 130F;
            this.btnCreateUsers.StatePressed.Border.Color1 = System.Drawing.Color.Teal;
            this.btnCreateUsers.StatePressed.Border.Color2 = System.Drawing.Color.Teal;
            this.btnCreateUsers.StatePressed.Border.ColorAngle = 130F;
            this.btnCreateUsers.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreateUsers.StatePressed.Border.Rounding = 6;
            this.btnCreateUsers.StatePressed.Border.Width = 1;
            this.btnCreateUsers.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCreateUsers.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnCreateUsers.StateTracking.Back.ColorAngle = 45F;
            this.btnCreateUsers.StateTracking.Border.Color1 = System.Drawing.Color.Teal;
            this.btnCreateUsers.StateTracking.Border.Color2 = System.Drawing.Color.Teal;
            this.btnCreateUsers.StateTracking.Border.ColorAngle = 45F;
            this.btnCreateUsers.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreateUsers.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCreateUsers.StateTracking.Border.Rounding = 6;
            this.btnCreateUsers.StateTracking.Border.Width = 1;
            this.btnCreateUsers.TabIndex = 28;
            this.btnCreateUsers.Values.Text = "Đăng ký";
            // 
            // btnPrePage
            // 
            this.btnPrePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.btnPrePage.Image = global::AirBook_Project.Properties.Resources.action_arrow_back;
            this.btnPrePage.Location = new System.Drawing.Point(25, 15);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(32, 32);
            this.btnPrePage.TabIndex = 14;
            this.btnPrePage.TabStop = false;
            this.btnPrePage.MouseLeave += new System.EventHandler(this.btnPrePage_MouseLeave);
            this.btnPrePage.MouseHover += new System.EventHandler(this.btnPrePage_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pictureBox1.Image = global::AirBook_Project.Properties.Resources.airbooklogo;
            this.pictureBox1.Location = new System.Drawing.Point(107, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SignUpFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 675);
            this.Controls.Add(this.btnCreateUsers);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.timePick);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPWCF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpFr";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUpFr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label btnMini;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPW;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPWCF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtName;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker timePick;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtID;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNation;
        private System.Windows.Forms.Label label11;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhone;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateUsers;
        private System.Windows.Forms.PictureBox btnPrePage;
    }
}