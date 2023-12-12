namespace GUI
{
    partial class ClientFrm
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
            this.navSignout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pallete = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.navAccount = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.navPromo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.navMyTicket = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.navBuyTicket = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonBorderEdge2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMainBody = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtFormTitle = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.navSignout);
            this.kryptonPanel1.Controls.Add(this.navAccount);
            this.kryptonPanel1.Controls.Add(this.navPromo);
            this.kryptonPanel1.Controls.Add(this.navMyTicket);
            this.kryptonPanel1.Controls.Add(this.navBuyTicket);
            this.kryptonPanel1.Controls.Add(this.kryptonBorderEdge2);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Palette = this.pallete;
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonPanel1.Size = new System.Drawing.Size(200, 659);
            this.kryptonPanel1.TabIndex = 4;
            // 
            // navSignout
            // 
            this.navSignout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navSignout.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.navSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navSignout.Location = new System.Drawing.Point(0, 617);
            this.navSignout.Name = "navSignout";
            this.navSignout.Palette = this.pallete;
            this.navSignout.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.navSignout.Size = new System.Drawing.Size(200, 42);
            this.navSignout.TabIndex = 16;
            this.navSignout.Values.Image = global::GUI.Properties.Resources.action_logout_white20;
            this.navSignout.Values.Text = "Đăng xuất";
            this.navSignout.Click += new System.EventHandler(this.navSignout_Click);
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
            this.pallete.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.PanelStyles.PanelClient.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(165)))));
            this.pallete.PanelStyles.PanelRibbonInactive.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pallete.PanelStyles.PanelRibbonInactive.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            // 
            // navAccount
            // 
            this.navAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navAccount.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.navAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navAccount.Location = new System.Drawing.Point(0, 189);
            this.navAccount.Name = "navAccount";
            this.navAccount.Palette = this.pallete;
            this.navAccount.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.navAccount.Size = new System.Drawing.Size(200, 42);
            this.navAccount.TabIndex = 15;
            this.navAccount.Values.Image = global::GUI.Properties.Resources.nav_account_white20;
            this.navAccount.Values.Text = "Tài khoản";
            this.navAccount.Click += new System.EventHandler(this.navAccount_Click);
            // 
            // navPromo
            // 
            this.navPromo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navPromo.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.navPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navPromo.Location = new System.Drawing.Point(0, 147);
            this.navPromo.Name = "navPromo";
            this.navPromo.Palette = this.pallete;
            this.navPromo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.navPromo.Size = new System.Drawing.Size(200, 42);
            this.navPromo.TabIndex = 14;
            this.navPromo.Values.Image = global::GUI.Properties.Resources.nav_promotion_white20;
            this.navPromo.Values.Text = "Khuyến mãi";
            this.navPromo.Click += new System.EventHandler(this.navPromo_Click);
            // 
            // navMyTicket
            // 
            this.navMyTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navMyTicket.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.navMyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navMyTicket.Location = new System.Drawing.Point(0, 105);
            this.navMyTicket.Name = "navMyTicket";
            this.navMyTicket.Palette = this.pallete;
            this.navMyTicket.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.navMyTicket.Size = new System.Drawing.Size(200, 42);
            this.navMyTicket.TabIndex = 13;
            this.navMyTicket.Values.Image = global::GUI.Properties.Resources.nav_my_ticket_white20;
            this.navMyTicket.Values.Text = "Vé của tôi";
            this.navMyTicket.Click += new System.EventHandler(this.navMyTicket_Click);
            // 
            // navBuyTicket
            // 
            this.navBuyTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navBuyTicket.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.navBuyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navBuyTicket.Location = new System.Drawing.Point(0, 63);
            this.navBuyTicket.Name = "navBuyTicket";
            this.navBuyTicket.Palette = this.pallete;
            this.navBuyTicket.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.navBuyTicket.Size = new System.Drawing.Size(200, 42);
            this.navBuyTicket.TabIndex = 11;
            this.navBuyTicket.Values.Image = global::GUI.Properties.Resources.nav_ticket_white20;
            this.navBuyTicket.Values.Text = "Mua vé";
            this.navBuyTicket.Click += new System.EventHandler(this.navBuyTicket_Click);
            // 
            // kryptonBorderEdge2
            // 
            this.kryptonBorderEdge2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonBorderEdge2.Location = new System.Drawing.Point(0, 62);
            this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            this.kryptonBorderEdge2.Size = new System.Drawing.Size(200, 1);
            this.kryptonBorderEdge2.Text = "kryptonBorderEdge2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI.Properties.Resources.log_header_logo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelMainBody
            // 
            this.panelMainBody.AutoScroll = true;
            this.panelMainBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainBody.Location = new System.Drawing.Point(200, 62);
            this.panelMainBody.Name = "panelMainBody";
            this.panelMainBody.Size = new System.Drawing.Size(816, 597);
            this.panelMainBody.TabIndex = 7;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonButton1);
            this.kryptonPanel2.Controls.Add(this.txtFormTitle);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(200, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Palette = this.pallete;
            this.kryptonPanel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive;
            this.kryptonPanel2.Size = new System.Drawing.Size(816, 62);
            this.kryptonPanel2.TabIndex = 6;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.kryptonButton1.Location = new System.Drawing.Point(714, 14);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Palette = this.pallete;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton1.Size = new System.Drawing.Size(90, 34);
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Text = "Vé của tôi";
            // 
            // txtFormTitle
            // 
            this.txtFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFormTitle.AutoSize = true;
            this.txtFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(123)))));
            this.txtFormTitle.Location = new System.Drawing.Point(24, 19);
            this.txtFormTitle.Name = "txtFormTitle";
            this.txtFormTitle.Size = new System.Drawing.Size(89, 25);
            this.txtFormTitle.TabIndex = 0;
            this.txtFormTitle.Text = "Mua vé";
            // 
            // ClientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 659);
            this.Controls.Add(this.panelMainBody);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ClientFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton navSignout;
        private ComponentFactory.Krypton.Toolkit.KryptonButton navAccount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton navPromo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton navMyTicket;
        private ComponentFactory.Krypton.Toolkit.KryptonButton navBuyTicket;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette pallete;
        private System.Windows.Forms.Panel panelMainBody;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label txtFormTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

