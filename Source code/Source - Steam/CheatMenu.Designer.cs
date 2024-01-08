namespace MordhauCheat_2._0
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pIDLabel = new System.Windows.Forms.Label();
            this.Global = new System.Windows.Forms.Timer(this.components);
            this.alivelabel = new System.Windows.Forms.Label();
            this.dodgebutton = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resuplabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.afklabel = new System.Windows.Forms.Label();
            this.labelafk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Antiafkbutton = new System.Windows.Forms.CheckBox();
            this.Turncapbutton = new System.Windows.Forms.CheckBox();
            this.DodgeDurationBar = new System.Windows.Forms.TrackBar();
            this.DodgeCooldownBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Noslowdownwhenchased = new System.Windows.Forms.CheckBox();
            this.releasetimebox = new System.Windows.Forms.CheckBox();
            this.drawtimebox = new System.Windows.Forms.CheckBox();
            this.norealoadbox = new System.Windows.Forms.CheckBox();
            this.FOVtrackbar = new System.Windows.Forms.TrackBar();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.FOVcheck = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.teamespbox = new System.Windows.Forms.CheckBox();
            this.turncapxtrack = new System.Windows.Forms.TrackBar();
            this.turncapytrack = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dodgecooldown = new System.Windows.Forms.Label();
            this.dodgetime = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nosmoke = new System.Windows.Forms.CheckBox();
            this.ezparry = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DodgeDurationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DodgeCooldownBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOVtrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turncapxtrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turncapytrack)).BeginInit();
            this.SuspendLayout();
            // 
            // pIDLabel
            // 
            this.pIDLabel.AutoSize = true;
            this.pIDLabel.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.pIDLabel.Location = new System.Drawing.Point(32, 17);
            this.pIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pIDLabel.Name = "pIDLabel";
            this.pIDLabel.Size = new System.Drawing.Size(24, 26);
            this.pIDLabel.TabIndex = 1;
            this.pIDLabel.Text = "0";
            // 
            // Global
            // 
            this.Global.Enabled = true;
            this.Global.Interval = 10;
            this.Global.Tick += new System.EventHandler(this.Global_Tick);
            // 
            // alivelabel
            // 
            this.alivelabel.AutoSize = true;
            this.alivelabel.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alivelabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.alivelabel.Location = new System.Drawing.Point(184, 86);
            this.alivelabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.alivelabel.Name = "alivelabel";
            this.alivelabel.Size = new System.Drawing.Size(72, 26);
            this.alivelabel.TabIndex = 2;
            this.alivelabel.Text = "Alive";
            this.alivelabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dodgebutton
            // 
            this.dodgebutton.AutoSize = true;
            this.dodgebutton.BackColor = System.Drawing.Color.Transparent;
            this.dodgebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dodgebutton.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodgebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.dodgebutton.Location = new System.Drawing.Point(466, 80);
            this.dodgebutton.Margin = new System.Windows.Forms.Padding(6);
            this.dodgebutton.Name = "dodgebutton";
            this.dodgebutton.Size = new System.Drawing.Size(91, 30);
            this.dodgebutton.TabIndex = 3;
            this.dodgebutton.Text = "Dodge";
            this.dodgebutton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox1.Controls.Add(this.resuplabel);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.afklabel);
            this.groupBox1.Controls.Add(this.labelafk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.alivelabel);
            this.groupBox1.Controls.Add(this.Antiafkbutton);
            this.groupBox1.Location = new System.Drawing.Point(762, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 528);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // resuplabel
            // 
            this.resuplabel.AutoSize = true;
            this.resuplabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.resuplabel.Location = new System.Drawing.Point(204, 193);
            this.resuplabel.Name = "resuplabel";
            this.resuplabel.Size = new System.Drawing.Size(48, 26);
            this.resuplabel.TabIndex = 17;
            this.resuplabel.Text = "Yes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 26);
            this.label14.TabIndex = 16;
            this.label14.Text = "Resup Avaible: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(196, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "max 180";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(101, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Made by philip\r\n";
            // 
            // afklabel
            // 
            this.afklabel.AutoSize = true;
            this.afklabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.afklabel.Location = new System.Drawing.Point(192, 127);
            this.afklabel.Name = "afklabel";
            this.afklabel.Size = new System.Drawing.Size(24, 26);
            this.afklabel.TabIndex = 5;
            this.afklabel.Text = "0";
            // 
            // labelafk
            // 
            this.labelafk.AutoSize = true;
            this.labelafk.Location = new System.Drawing.Point(20, 124);
            this.labelafk.Name = "labelafk";
            this.labelafk.Size = new System.Drawing.Size(108, 26);
            this.labelafk.TabIndex = 6;
            this.labelafk.Text = "AfkTime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "State:";
            // 
            // Antiafkbutton
            // 
            this.Antiafkbutton.AutoSize = true;
            this.Antiafkbutton.BackColor = System.Drawing.Color.Transparent;
            this.Antiafkbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Antiafkbutton.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antiafkbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.Antiafkbutton.Location = new System.Drawing.Point(25, 156);
            this.Antiafkbutton.Margin = new System.Windows.Forms.Padding(6);
            this.Antiafkbutton.Name = "Antiafkbutton";
            this.Antiafkbutton.Size = new System.Drawing.Size(127, 30);
            this.Antiafkbutton.TabIndex = 10;
            this.Antiafkbutton.Text = "Anti-AFK";
            this.Antiafkbutton.UseVisualStyleBackColor = false;
            // 
            // Turncapbutton
            // 
            this.Turncapbutton.AutoSize = true;
            this.Turncapbutton.BackColor = System.Drawing.Color.Transparent;
            this.Turncapbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Turncapbutton.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turncapbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.Turncapbutton.Location = new System.Drawing.Point(15, 108);
            this.Turncapbutton.Margin = new System.Windows.Forms.Padding(6);
            this.Turncapbutton.Name = "Turncapbutton";
            this.Turncapbutton.Size = new System.Drawing.Size(199, 30);
            this.Turncapbutton.TabIndex = 5;
            this.Turncapbutton.Text = "Change turncap";
            this.Turncapbutton.UseVisualStyleBackColor = false;
            // 
            // DodgeDurationBar
            // 
            this.DodgeDurationBar.LargeChange = 1;
            this.DodgeDurationBar.Location = new System.Drawing.Point(504, 119);
            this.DodgeDurationBar.Maximum = 5;
            this.DodgeDurationBar.Name = "DodgeDurationBar";
            this.DodgeDurationBar.Size = new System.Drawing.Size(188, 45);
            this.DodgeDurationBar.TabIndex = 6;
            this.DodgeDurationBar.TabStop = false;
            this.DodgeDurationBar.Value = 1;
            // 
            // DodgeCooldownBar
            // 
            this.DodgeCooldownBar.LargeChange = 1;
            this.DodgeCooldownBar.Location = new System.Drawing.Point(504, 156);
            this.DodgeCooldownBar.Maximum = 5;
            this.DodgeCooldownBar.Name = "DodgeCooldownBar";
            this.DodgeCooldownBar.Size = new System.Drawing.Size(188, 45);
            this.DodgeCooldownBar.TabIndex = 7;
            this.DodgeCooldownBar.TabStop = false;
            this.DodgeCooldownBar.Value = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(687, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(687, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time";
            // 
            // Noslowdownwhenchased
            // 
            this.Noslowdownwhenchased.AutoSize = true;
            this.Noslowdownwhenchased.BackColor = System.Drawing.Color.Transparent;
            this.Noslowdownwhenchased.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Noslowdownwhenchased.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noslowdownwhenchased.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.Noslowdownwhenchased.Location = new System.Drawing.Point(466, 210);
            this.Noslowdownwhenchased.Margin = new System.Windows.Forms.Padding(6);
            this.Noslowdownwhenchased.Name = "Noslowdownwhenchased";
            this.Noslowdownwhenchased.Size = new System.Drawing.Size(259, 30);
            this.Noslowdownwhenchased.TabIndex = 11;
            this.Noslowdownwhenchased.Text = "No slow when chased";
            this.Noslowdownwhenchased.UseVisualStyleBackColor = false;
            // 
            // releasetimebox
            // 
            this.releasetimebox.AutoSize = true;
            this.releasetimebox.BackColor = System.Drawing.Color.Transparent;
            this.releasetimebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.releasetimebox.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releasetimebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.releasetimebox.Location = new System.Drawing.Point(52, 275);
            this.releasetimebox.Margin = new System.Windows.Forms.Padding(6);
            this.releasetimebox.Name = "releasetimebox";
            this.releasetimebox.Size = new System.Drawing.Size(271, 30);
            this.releasetimebox.TabIndex = 13;
            this.releasetimebox.Text = "Instant release time";
            this.releasetimebox.UseVisualStyleBackColor = false;
            // 
            // drawtimebox
            // 
            this.drawtimebox.AutoSize = true;
            this.drawtimebox.BackColor = System.Drawing.Color.Transparent;
            this.drawtimebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.drawtimebox.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawtimebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.drawtimebox.Location = new System.Drawing.Point(52, 317);
            this.drawtimebox.Margin = new System.Windows.Forms.Padding(6);
            this.drawtimebox.Name = "drawtimebox";
            this.drawtimebox.Size = new System.Drawing.Size(235, 30);
            this.drawtimebox.TabIndex = 14;
            this.drawtimebox.Text = "Instant draw time";
            this.drawtimebox.UseVisualStyleBackColor = false;
            // 
            // norealoadbox
            // 
            this.norealoadbox.AutoSize = true;
            this.norealoadbox.BackColor = System.Drawing.Color.Transparent;
            this.norealoadbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.norealoadbox.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.norealoadbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.norealoadbox.Location = new System.Drawing.Point(52, 359);
            this.norealoadbox.Margin = new System.Windows.Forms.Padding(6);
            this.norealoadbox.Name = "norealoadbox";
            this.norealoadbox.Size = new System.Drawing.Size(139, 30);
            this.norealoadbox.TabIndex = 15;
            this.norealoadbox.Text = "No reload";
            this.norealoadbox.UseVisualStyleBackColor = false;
            // 
            // FOVtrackbar
            // 
            this.FOVtrackbar.LargeChange = 1;
            this.FOVtrackbar.Location = new System.Drawing.Point(315, 490);
            this.FOVtrackbar.Maximum = 150;
            this.FOVtrackbar.Name = "FOVtrackbar";
            this.FOVtrackbar.Size = new System.Drawing.Size(366, 45);
            this.FOVtrackbar.TabIndex = 18;
            this.FOVtrackbar.Value = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel2.Location = new System.Drawing.Point(687, 490);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 26);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "0";
            // 
            // FOVcheck
            // 
            this.FOVcheck.AutoSize = true;
            this.FOVcheck.BackColor = System.Drawing.Color.Transparent;
            this.FOVcheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FOVcheck.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOVcheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.FOVcheck.Location = new System.Drawing.Point(242, 490);
            this.FOVcheck.Margin = new System.Windows.Forms.Padding(6);
            this.FOVcheck.Name = "FOVcheck";
            this.FOVcheck.Size = new System.Drawing.Size(79, 30);
            this.FOVcheck.TabIndex = 20;
            this.FOVcheck.Text = "FOV:";
            this.FOVcheck.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(5, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 37);
            this.label10.TabIndex = 21;
            this.label10.Text = "Visual";
            // 
            // teamespbox
            // 
            this.teamespbox.AutoSize = true;
            this.teamespbox.BackColor = System.Drawing.Color.Transparent;
            this.teamespbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.teamespbox.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamespbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.teamespbox.Location = new System.Drawing.Point(52, 490);
            this.teamespbox.Margin = new System.Windows.Forms.Padding(6);
            this.teamespbox.Name = "teamespbox";
            this.teamespbox.Size = new System.Drawing.Size(163, 30);
            this.teamespbox.TabIndex = 22;
            this.teamespbox.Text = "Teamate ESP";
            this.teamespbox.UseVisualStyleBackColor = false;
            // 
            // turncapxtrack
            // 
            this.turncapxtrack.LargeChange = 50;
            this.turncapxtrack.Location = new System.Drawing.Point(52, 136);
            this.turncapxtrack.Maximum = 600;
            this.turncapxtrack.Minimum = 200;
            this.turncapxtrack.Name = "turncapxtrack";
            this.turncapxtrack.Size = new System.Drawing.Size(366, 45);
            this.turncapxtrack.SmallChange = 10;
            this.turncapxtrack.TabIndex = 23;
            this.turncapxtrack.Value = 200;
            // 
            // turncapytrack
            // 
            this.turncapytrack.LargeChange = 50;
            this.turncapytrack.Location = new System.Drawing.Point(52, 182);
            this.turncapytrack.Maximum = 600;
            this.turncapytrack.Minimum = 200;
            this.turncapytrack.Name = "turncapytrack";
            this.turncapytrack.Size = new System.Drawing.Size(366, 45);
            this.turncapytrack.SmallChange = 10;
            this.turncapytrack.TabIndex = 24;
            this.turncapytrack.Value = 200;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(22, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(22, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(5, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 37);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ranged";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(6, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 37);
            this.label12.TabIndex = 29;
            this.label12.Text = "Melle";
            // 
            // dodgecooldown
            // 
            this.dodgecooldown.AutoSize = true;
            this.dodgecooldown.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodgecooldown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dodgecooldown.Location = new System.Drawing.Point(465, 162);
            this.dodgecooldown.Name = "dodgecooldown";
            this.dodgecooldown.Size = new System.Drawing.Size(18, 19);
            this.dodgecooldown.TabIndex = 34;
            this.dodgecooldown.Text = "0";
            // 
            // dodgetime
            // 
            this.dodgetime.AutoSize = true;
            this.dodgetime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodgetime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dodgetime.Location = new System.Drawing.Point(464, 124);
            this.dodgetime.Name = "dodgetime";
            this.dodgetime.Size = new System.Drawing.Size(18, 19);
            this.dodgetime.TabIndex = 33;
            this.dodgetime.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(462, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 37);
            this.label13.TabIndex = 35;
            this.label13.Text = "Movement";
            // 
            // nosmoke
            // 
            this.nosmoke.AutoSize = true;
            this.nosmoke.BackColor = System.Drawing.Color.Transparent;
            this.nosmoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nosmoke.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosmoke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.nosmoke.Location = new System.Drawing.Point(53, 448);
            this.nosmoke.Margin = new System.Windows.Forms.Padding(6);
            this.nosmoke.Name = "nosmoke";
            this.nosmoke.Size = new System.Drawing.Size(175, 30);
            this.nosmoke.TabIndex = 36;
            this.nosmoke.Text = "See in smoke";
            this.nosmoke.UseVisualStyleBackColor = false;
            // 
            // ezparry
            // 
            this.ezparry.AutoSize = true;
            this.ezparry.BackColor = System.Drawing.Color.Transparent;
            this.ezparry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ezparry.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ezparry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.ezparry.Location = new System.Drawing.Point(242, 108);
            this.ezparry.Margin = new System.Windows.Forms.Padding(6);
            this.ezparry.Name = "ezparry";
            this.ezparry.Size = new System.Drawing.Size(151, 30);
            this.ezparry.TabIndex = 37;
            this.ezparry.Text = "Easy parry";
            this.ezparry.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1055, 549);
            this.Controls.Add(this.ezparry);
            this.Controls.Add(this.nosmoke);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dodgecooldown);
            this.Controls.Add(this.dodgetime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.turncapytrack);
            this.Controls.Add(this.turncapxtrack);
            this.Controls.Add(this.DodgeDurationBar);
            this.Controls.Add(this.drawtimebox);
            this.Controls.Add(this.dodgebutton);
            this.Controls.Add(this.Turncapbutton);
            this.Controls.Add(this.DodgeCooldownBar);
            this.Controls.Add(this.releasetimebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.norealoadbox);
            this.Controls.Add(this.teamespbox);
            this.Controls.Add(this.Noslowdownwhenchased);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FOVcheck);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.FOVtrackbar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pIDLabel);
            this.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menu";
            this.Text = "Cool Mordhau Exploit Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DodgeDurationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DodgeCooldownBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOVtrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turncapxtrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turncapytrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pIDLabel;
        private System.Windows.Forms.Timer Global;
        private System.Windows.Forms.Label alivelabel;
        private System.Windows.Forms.CheckBox dodgebutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelafk;
        private System.Windows.Forms.Label afklabel;
        private System.Windows.Forms.CheckBox Turncapbutton;
        private System.Windows.Forms.TrackBar DodgeDurationBar;
        private System.Windows.Forms.TrackBar DodgeCooldownBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Antiafkbutton;
        private System.Windows.Forms.CheckBox Noslowdownwhenchased;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox releasetimebox;
        private System.Windows.Forms.CheckBox drawtimebox;
        private System.Windows.Forms.CheckBox norealoadbox;
        private System.Windows.Forms.TrackBar FOVtrackbar;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.CheckBox FOVcheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox teamespbox;
        private System.Windows.Forms.TrackBar turncapxtrack;
        private System.Windows.Forms.TrackBar turncapytrack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label dodgecooldown;
        private System.Windows.Forms.Label dodgetime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox nosmoke;
        private System.Windows.Forms.Label resuplabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ezparry;
    }
}

