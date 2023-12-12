namespace GUI
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pallete = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSignin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRBOOKDataSet = new GUI.AIRBOOKDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.usersTableAdapter = new GUI.AIRBOOKDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new GUI.AIRBOOKDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRBOOKDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.kryptonPanel1, "kryptonPanel1");
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Palette = this.pallete;
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.ErrorImage = global::GUI.Properties.Resources.log_header_logo;
            this.pictureBox1.Image = global::GUI.Properties.Resources.log_header_logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pallete
            // 
            this.pallete.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.pallete.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonCommon.OverrideDefault.Border.Rounding = 6;
            this.pallete.ButtonStyles.ButtonCommon.OverrideDefault.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonCommon.OverrideDefault.Content.AdjacentGap = 8;
            this.pallete.ButtonStyles.ButtonCommon.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(8, -1, 8, -1);
            this.pallete.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pallete.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonCommon.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonCommon.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonCommon.StateNormal.Border.Rounding = 6;
            this.pallete.ButtonStyles.ButtonCommon.StateNormal.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonCommon.StateNormal.Content.AdjacentGap = 8;
            this.pallete.ButtonStyles.ButtonCommon.StateNormal.Content.Padding = new System.Windows.Forms.Padding(8, -1, 8, -1);
            this.pallete.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pallete.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(183)))));
            this.pallete.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(183)))));
            this.pallete.ButtonStyles.ButtonCommon.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonCommon.StatePressed.Border.Rounding = 6;
            this.pallete.ButtonStyles.ButtonCommon.StatePressed.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonCommon.StatePressed.Content.AdjacentGap = 8;
            this.pallete.ButtonStyles.ButtonCommon.StatePressed.Content.Padding = new System.Windows.Forms.Padding(8, -1, 8, -1);
            this.pallete.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pallete.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(183)))));
            this.pallete.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(183)))));
            this.pallete.ButtonStyles.ButtonCommon.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonCommon.StateTracking.Border.Rounding = 6;
            this.pallete.ButtonStyles.ButtonCommon.StateTracking.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonCommon.StateTracking.Content.AdjacentGap = 8;
            this.pallete.ButtonStyles.ButtonCommon.StateTracking.Content.Padding = new System.Windows.Forms.Padding(8, -1, 8, -1);
            this.pallete.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pallete.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.pallete.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.pallete.ButtonStyles.ButtonCustom1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Rounding = 6;
            this.pallete.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonCustom1.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonCustom1.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.pallete.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.pallete.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonCustom1.StateCommon.Border.Rounding = 6;
            this.pallete.ButtonStyles.ButtonCustom1.StateCommon.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonCustom1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonCustom1.StateNormal.Border.Rounding = 8;
            this.pallete.ButtonStyles.ButtonCustom1.StateNormal.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonCustom1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonCustom1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonCustom1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonCustom1.StatePressed.Border.Rounding = 6;
            this.pallete.ButtonStyles.ButtonCustom1.StatePressed.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonCustom1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonCustom1.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.pallete.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.pallete.ButtonStyles.ButtonCustom1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonCustom1.StateTracking.Border.Rounding = 6;
            this.pallete.ButtonStyles.ButtonCustom1.StateTracking.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(124)))));
            this.pallete.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(124)))));
            this.pallete.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Border.Rounding = 0;
            this.pallete.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Content.AdjacentGap = 8;
            this.pallete.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(0, -1, 16, -1);
            this.pallete.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateNormal.Border.Rounding = 0;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateNormal.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.AdjacentGap = 8;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.Padding = new System.Windows.Forms.Padding(0, -1, 16, -1);
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(124)))));
            this.pallete.ButtonStyles.ButtonNavigatorStack.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(124)))));
            this.pallete.ButtonStyles.ButtonNavigatorStack.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonNavigatorStack.StatePressed.Border.Rounding = 0;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StatePressed.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StatePressed.Content.AdjacentGap = 8;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StatePressed.Content.Padding = new System.Windows.Forms.Padding(0, -1, 16, -1);
            this.pallete.ButtonStyles.ButtonNavigatorStack.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(124)))));
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(124)))));
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateTracking.Border.Rounding = 0;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateTracking.Border.Width = 0;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.AdjacentGap = 8;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.Padding = new System.Windows.Forms.Padding(0, -1, 16, -1);
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pallete.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pallete.FormStyles.FormCommon.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.pallete.FormStyles.FormCommon.StateActive.Back.Color2 = System.Drawing.Color.White;
            this.pallete.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.pallete.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.pallete.FormStyles.FormCustom1.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.pallete.FormStyles.FormCustom1.StateActive.Back.Color2 = System.Drawing.Color.White;
            this.pallete.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.pallete.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.White;
            this.pallete.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.pallete.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.pallete.InputControlStyles.InputControlCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pallete.InputControlStyles.InputControlCommon.StateCommon.Border.Rounding = 6;
            this.pallete.InputControlStyles.InputControlCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.pallete.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.PanelStyles.PanelClient.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.PanelStyles.PanelRibbonInactive.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pallete.PanelStyles.PanelRibbonInactive.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnSignup);
            this.panel1.Controls.Add(this.btnSignin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Name = "panel1";
            // 
            // btnSignup
            // 
            resources.ApplyResources(this.btnSignup, "btnSignup");
            this.btnSignup.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Palette = this.pallete;
            this.btnSignup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnSignup.Values.Image = global::GUI.Properties.Resources.action_add_pri18;
            this.btnSignup.Values.Text = resources.GetString("btnSignup.Values.Text");
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnSignin
            // 
            resources.ApplyResources(this.btnSignin, "btnSignin");
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Palette = this.pallete;
            this.btnSignin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnSignin.Values.Image = global::GUI.Properties.Resources.action_login_white18;
            this.btnSignin.Values.Text = resources.GetString("btnSignin.Values.Text");
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Pwd", true));
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Palette = this.pallete;
            this.txtPassword.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.aIRBOOKDataSet;
            // 
            // aIRBOOKDataSet
            // 
            this.aIRBOOKDataSet.DataSetName = "AIRBOOKDataSet";
            this.aIRBOOKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Email", true));
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Palette = this.pallete;
            this.txtEmail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.actionsTableAdapter = null;
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
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // SignIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "SignIn";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRBOOKDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette pallete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSignup;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSignin;
        private AIRBOOKDataSet aIRBOOKDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private AIRBOOKDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private AIRBOOKDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}