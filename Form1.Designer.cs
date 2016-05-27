namespace WebSiteAdministration
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
            this.btn_startServer = new System.Windows.Forms.Button();
            this.btn_stop_server = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.gb_os = new System.Windows.Forms.GroupBox();
            this.rb_64 = new System.Windows.Forms.RadioButton();
            this.rb_86 = new System.Windows.Forms.RadioButton();
            this.gb_projectFolder = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_portInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.lbl_link = new System.Windows.Forms.Label();
            this.lbl_eg = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.lbl_note1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pc_off = new System.Windows.Forms.PictureBox();
            this.pc_on = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gb_os.SuspendLayout();
            this.gb_projectFolder.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_on)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_startServer
            // 
            this.btn_startServer.Enabled = false;
            this.btn_startServer.Location = new System.Drawing.Point(84, 19);
            this.btn_startServer.Name = "btn_startServer";
            this.btn_startServer.Size = new System.Drawing.Size(103, 41);
            this.btn_startServer.TabIndex = 0;
            this.btn_startServer.Text = "Start Web Tool";
            this.btn_startServer.UseVisualStyleBackColor = true;
            this.btn_startServer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_stop_server
            // 
            this.btn_stop_server.Enabled = false;
            this.btn_stop_server.Location = new System.Drawing.Point(219, 19);
            this.btn_stop_server.Name = "btn_stop_server";
            this.btn_stop_server.Size = new System.Drawing.Size(120, 41);
            this.btn_stop_server.TabIndex = 1;
            this.btn_stop_server.Text = "Stop Web Tool";
            this.btn_stop_server.UseVisualStyleBackColor = true;
            this.btn_stop_server.Click += new System.EventHandler(this.btn_stop_server_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pc_off);
            this.groupBox1.Controls.Add(this.pc_on);
            this.groupBox1.Controls.Add(this.btn_startServer);
            this.groupBox1.Controls.Add(this.btn_stop_server);
            this.groupBox1.Location = new System.Drawing.Point(3, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(11, 19);
            this.txt_location.Name = "txt_location";
            this.txt_location.ReadOnly = true;
            this.txt_location.Size = new System.Drawing.Size(335, 20);
            this.txt_location.TabIndex = 3;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(352, 19);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(47, 23);
            this.btnFolder.TabIndex = 4;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // gb_os
            // 
            this.gb_os.Controls.Add(this.rb_64);
            this.gb_os.Controls.Add(this.rb_86);
            this.gb_os.Location = new System.Drawing.Point(12, 83);
            this.gb_os.Name = "gb_os";
            this.gb_os.Size = new System.Drawing.Size(191, 58);
            this.gb_os.TabIndex = 5;
            this.gb_os.TabStop = false;
            this.gb_os.Text = "Choose Your OS Architecture";
            // 
            // rb_64
            // 
            this.rb_64.AutoSize = true;
            this.rb_64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_64.Location = new System.Drawing.Point(124, 23);
            this.rb_64.Name = "rb_64";
            this.rb_64.Size = new System.Drawing.Size(45, 17);
            this.rb_64.TabIndex = 1;
            this.rb_64.Text = "x64";
            this.rb_64.UseVisualStyleBackColor = true;
            // 
            // rb_86
            // 
            this.rb_86.AutoSize = true;
            this.rb_86.Checked = true;
            this.rb_86.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_86.Location = new System.Drawing.Point(11, 24);
            this.rb_86.Name = "rb_86";
            this.rb_86.Size = new System.Drawing.Size(45, 17);
            this.rb_86.TabIndex = 0;
            this.rb_86.TabStop = true;
            this.rb_86.Text = "x86";
            this.rb_86.UseVisualStyleBackColor = true;
            this.rb_86.CheckedChanged += new System.EventHandler(this.rb_86_CheckedChanged);
            // 
            // gb_projectFolder
            // 
            this.gb_projectFolder.Controls.Add(this.txt_location);
            this.gb_projectFolder.Controls.Add(this.btnFolder);
            this.gb_projectFolder.Location = new System.Drawing.Point(12, 158);
            this.gb_projectFolder.Name = "gb_projectFolder";
            this.gb_projectFolder.Size = new System.Drawing.Size(411, 51);
            this.gb_projectFolder.TabIndex = 6;
            this.gb_projectFolder.TabStop = false;
            this.gb_projectFolder.Text = "Choose Your ASP.NET Project Folder";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_eg);
            this.groupBox2.Controls.Add(this.lbl_portInfo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_port);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advance";
            // 
            // lbl_portInfo
            // 
            this.lbl_portInfo.AutoSize = true;
            this.lbl_portInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_portInfo.Location = new System.Drawing.Point(11, 62);
            this.lbl_portInfo.Name = "lbl_portInfo";
            this.lbl_portInfo.Size = new System.Drawing.Size(350, 13);
            this.lbl_portInfo.TabIndex = 2;
            this.lbl_portInfo.Text = "If left blank automatic port will be assign. For advance users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(43, 24);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 20);
            this.txt_port.TabIndex = 0;
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(12, 420);
            this.txt_link.Multiline = true;
            this.txt_link.Name = "txt_link";
            this.txt_link.ReadOnly = true;
            this.txt_link.Size = new System.Drawing.Size(411, 46);
            this.txt_link.TabIndex = 8;
            // 
            // lbl_link
            // 
            this.lbl_link.AutoSize = true;
            this.lbl_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_link.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_link.Location = new System.Drawing.Point(9, 474);
            this.lbl_link.Name = "lbl_link";
            this.lbl_link.Size = new System.Drawing.Size(406, 13);
            this.lbl_link.TabIndex = 9;
            this.lbl_link.Text = "COPY LINK TO ANY BROWSER TO OPEN WEB ADMINISTRATION TOOL";
            this.lbl_link.Visible = false;
            // 
            // lbl_eg
            // 
            this.lbl_eg.AutoSize = true;
            this.lbl_eg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eg.Location = new System.Drawing.Point(162, 27);
            this.lbl_eg.Name = "lbl_eg";
            this.lbl_eg.Size = new System.Drawing.Size(90, 13);
            this.lbl_eg.TabIndex = 3;
            this.lbl_eg.Text = "Example: 8451";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_note.ForeColor = System.Drawing.Color.Black;
            this.lbl_note.Location = new System.Drawing.Point(33, 505);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(368, 13);
            this.lbl_note.TabIndex = 11;
            this.lbl_note.Text = "If browser asks for your username and password enter your own";
            this.lbl_note.Visible = false;
            // 
            // lbl_note1
            // 
            this.lbl_note1.AutoSize = true;
            this.lbl_note1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_note1.ForeColor = System.Drawing.Color.Black;
            this.lbl_note1.Location = new System.Drawing.Point(84, 518);
            this.lbl_note1.Name = "lbl_note1";
            this.lbl_note1.Size = new System.Drawing.Size(210, 13);
            this.lbl_note1.TabIndex = 12;
            this.lbl_note1.Text = "logging  in details for your computer";
            this.lbl_note1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WebSiteAdministration.Properties.Resources.ASP;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 70);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pc_off
            // 
            this.pc_off.Image = global::WebSiteAdministration.Properties.Resources.ASP1;
            this.pc_off.Location = new System.Drawing.Point(361, 14);
            this.pc_off.Name = "pc_off";
            this.pc_off.Size = new System.Drawing.Size(41, 50);
            this.pc_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_off.TabIndex = 3;
            this.pc_off.TabStop = false;
            // 
            // pc_on
            // 
            this.pc_on.Image = global::WebSiteAdministration.Properties.Resources.AP;
            this.pc_on.Location = new System.Drawing.Point(18, 15);
            this.pc_on.Name = "pc_on";
            this.pc_on.Size = new System.Drawing.Size(41, 50);
            this.pc_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_on.TabIndex = 2;
            this.pc_on.TabStop = false;
            this.pc_on.Visible = false;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_status.Location = new System.Drawing.Point(216, 103);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(160, 24);
            this.lbl_status.TabIndex = 13;
            this.lbl_status.Text = "Web Tool Is Off!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 540);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_note1);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_link);
            this.Controls.Add(this.txt_link);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_projectFolder);
            this.Controls.Add(this.gb_os);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ASP.NET Web Administration Tool v0.1 TnZ";
            this.groupBox1.ResumeLayout(false);
            this.gb_os.ResumeLayout(false);
            this.gb_os.PerformLayout();
            this.gb_projectFolder.ResumeLayout(false);
            this.gb_projectFolder.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_on)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startServer;
        private System.Windows.Forms.Button btn_stop_server;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.GroupBox gb_os;
        private System.Windows.Forms.RadioButton rb_64;
        private System.Windows.Forms.RadioButton rb_86;
        private System.Windows.Forms.GroupBox gb_projectFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_portInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Label lbl_link;
        private System.Windows.Forms.Label lbl_eg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Label lbl_note1;
        private System.Windows.Forms.PictureBox pc_on;
        private System.Windows.Forms.PictureBox pc_off;
        private System.Windows.Forms.Label lbl_status;
    }
}

