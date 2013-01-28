namespace cub_scout_race_manager
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.tabRace = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabWelcome);
            this.tabControl.Controls.Add(this.tabSetup);
            this.tabControl.Controls.Add(this.tabRegistration);
            this.tabControl.Controls.Add(this.tabRace);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(663, 431);
            this.tabControl.TabIndex = 4;
            // 
            // tabWelcome
            // 
            this.tabWelcome.Controls.Add(this.label1);
            this.tabWelcome.Location = new System.Drawing.Point(4, 22);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(655, 405);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "Welcome";
            this.tabWelcome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Follow these steps to run your race:\r\n\r\n1. Set up the program to your race format" +
    " and preferences.\r\n\r\n2. Register each entry and verify qualifications.\r\n\r\n3. Rac" +
    "e!\r\n";
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.groupBox2);
            this.tabSetup.Controls.Add(this.groupBox1);
            this.tabSetup.Location = new System.Drawing.Point(4, 22);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(655, 405);
            this.tabSetup.TabIndex = 1;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Settings";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Local"});
            this.comboBox2.Location = new System.Drawing.Point(127, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Database type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.num);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Race Settings";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Den Champions > Overall Winner",
            "Qualifications > Tournament > Overall Winner"});
            this.comboBox1.Location = new System.Drawing.Point(127, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(127, 30);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(120, 20);
            this.num.TabIndex = 2;
            this.num.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Race format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of lanes: ";
            // 
            // tabRegistration
            // 
            this.tabRegistration.Location = new System.Drawing.Point(4, 22);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistration.Size = new System.Drawing.Size(655, 405);
            this.tabRegistration.TabIndex = 2;
            this.tabRegistration.Text = "Registration";
            this.tabRegistration.UseVisualStyleBackColor = true;
            // 
            // tabRace
            // 
            this.tabRace.Location = new System.Drawing.Point(4, 22);
            this.tabRace.Name = "tabRace";
            this.tabRace.Padding = new System.Windows.Forms.Padding(3);
            this.tabRace.Size = new System.Drawing.Size(655, 405);
            this.tabRace.TabIndex = 3;
            this.tabRace.Text = "Race";
            this.tabRace.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 455);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Cub Scout Race Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.tabWelcome.PerformLayout();
            this.tabSetup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabRegistration;
        private System.Windows.Forms.TabPage tabRace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;

    }
}