namespace WinFormsApp2
{
    partial class FrLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            lblmessage = new Label();
            label3 = new Label();
            panelLogin = new Panel();
            crownDockPanel1 = new ReaLTaiizor.Docking.Crown.CrownDockPanel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 202);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 267);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "Password: ";
            // 
            // txtuser
            // 
            txtuser.Anchor = AnchorStyles.None;
            txtuser.Location = new Point(43, 224);
            txtuser.Multiline = true;
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(454, 38);
            txtuser.TabIndex = 2;
            // 
            // txtpass
            // 
            txtpass.Anchor = AnchorStyles.None;
            txtpass.Location = new Point(43, 289);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(454, 35);
            txtpass.TabIndex = 3;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(194, 353);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(156, 55);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            btnLogin.MouseHover += btnLogin_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.stock_vector_profile_picture_avatar_icon_vector_1760295569_removebg_preview;
            pictureBox1.Location = new Point(178, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblmessage
            // 
            lblmessage.AutoSize = true;
            lblmessage.Location = new Point(498, 592);
            lblmessage.Name = "lblmessage";
            lblmessage.Size = new Size(0, 20);
            lblmessage.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(170, 12);
            label3.Name = "label3";
            label3.Size = new Size(203, 41);
            label3.TabIndex = 8;
            label3.Text = "LOGIN FORM";
            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.None;
            panelLogin.BackColor = Color.Black;
            panelLogin.BorderStyle = BorderStyle.Fixed3D;
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(txtuser);
            panelLogin.Controls.Add(txtpass);
            panelLogin.Controls.Add(label2);
            panelLogin.Location = new Point(363, 129);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(566, 440);
            panelLogin.TabIndex = 9;
            // 
            // crownDockPanel1
            // 
            crownDockPanel1.BackColor = Color.FromArgb(60, 63, 65);
            crownDockPanel1.Dock = DockStyle.Top;
            crownDockPanel1.Location = new Point(0, 0);
            crownDockPanel1.Name = "crownDockPanel1";
            crownDockPanel1.Size = new Size(1317, 54);
            crownDockPanel1.TabIndex = 10;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1166, 12);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 11;
            // 
            // FrLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1317, 676);
            Controls.Add(nightControlBox1);
            Controls.Add(crownDockPanel1);
            Controls.Add(lblmessage);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrgaSync Login Form";
            Load += FrLogin_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtuser;
        private TextBox txtpass;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Label lblmessage;
        private Label label3;
        private Panel panelLogin;
        private ReaLTaiizor.Docking.Crown.CrownDockPanel crownDockPanel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}
