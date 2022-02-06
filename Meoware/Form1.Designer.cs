namespace Meoware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_lock_window = new System.Windows.Forms.CheckBox();
            this.button_open_growtopia = new System.Windows.Forms.Button();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.AttachLabel = new System.Windows.Forms.Label();
            this.button_info = new System.Windows.Forms.Button();
            this.button_cheats2 = new System.Windows.Forms.Button();
            this.button_cheats1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControl_Info1 = new Meoware.UserControl_Info();
            this.userControl_Cheats21 = new Meoware.UserControl_Cheats2();
            this.userControl_Cheats11 = new Meoware.UserControl_Cheats1();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_minimize);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 74);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(13, 12, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(55, 74);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meoware";
            // 
            // button_minimize
            // 
            this.button_minimize.BackColor = System.Drawing.Color.Transparent;
            this.button_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.White;
            this.button_minimize.Location = new System.Drawing.Point(907, 0);
            this.button_minimize.Margin = new System.Windows.Forms.Padding(4);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(80, 74);
            this.button_minimize.TabIndex = 1;
            this.button_minimize.Text = "-";
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Transparent;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(987, 0);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(80, 74);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.cb_lock_window);
            this.panel2.Controls.Add(this.button_open_growtopia);
            this.panel2.Controls.Add(this.ProcOpenLabel);
            this.panel2.Controls.Add(this.AttachLabel);
            this.panel2.Controls.Add(this.button_info);
            this.panel2.Controls.Add(this.button_cheats2);
            this.panel2.Controls.Add(this.button_cheats1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 480);
            this.panel2.TabIndex = 1;
            // 
            // cb_lock_window
            // 
            this.cb_lock_window.AutoSize = true;
            this.cb_lock_window.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb_lock_window.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold);
            this.cb_lock_window.ForeColor = System.Drawing.Color.White;
            this.cb_lock_window.Location = new System.Drawing.Point(0, 387);
            this.cb_lock_window.Name = "cb_lock_window";
            this.cb_lock_window.Padding = new System.Windows.Forms.Padding(18, 0, 0, 6);
            this.cb_lock_window.Size = new System.Drawing.Size(200, 29);
            this.cb_lock_window.TabIndex = 6;
            this.cb_lock_window.Text = "Always on top";
            this.cb_lock_window.UseVisualStyleBackColor = true;
            this.cb_lock_window.CheckedChanged += new System.EventHandler(this.cb_lock_window_CheckedChanged);
            // 
            // button_open_growtopia
            // 
            this.button_open_growtopia.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_open_growtopia.FlatAppearance.BorderSize = 0;
            this.button_open_growtopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open_growtopia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_open_growtopia.ForeColor = System.Drawing.Color.White;
            this.button_open_growtopia.Location = new System.Drawing.Point(0, 222);
            this.button_open_growtopia.Margin = new System.Windows.Forms.Padding(4);
            this.button_open_growtopia.Name = "button_open_growtopia";
            this.button_open_growtopia.Size = new System.Drawing.Size(200, 74);
            this.button_open_growtopia.TabIndex = 5;
            this.button_open_growtopia.Text = "Open Growtopia";
            this.button_open_growtopia.UseVisualStyleBackColor = true;
            this.button_open_growtopia.Click += new System.EventHandler(this.button_open_growtopia_Click);
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProcOpenLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProcOpenLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcOpenLabel.ForeColor = System.Drawing.Color.Red;
            this.ProcOpenLabel.Location = new System.Drawing.Point(0, 416);
            this.ProcOpenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Padding = new System.Windows.Forms.Padding(13, 0, 0, 6);
            this.ProcOpenLabel.Size = new System.Drawing.Size(131, 29);
            this.ProcOpenLabel.TabIndex = 4;
            this.ProcOpenLabel.Text = "No Growtopia";
            // 
            // AttachLabel
            // 
            this.AttachLabel.AutoSize = true;
            this.AttachLabel.BackColor = System.Drawing.Color.Transparent;
            this.AttachLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AttachLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachLabel.ForeColor = System.Drawing.Color.Red;
            this.AttachLabel.Location = new System.Drawing.Point(0, 445);
            this.AttachLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AttachLabel.Name = "AttachLabel";
            this.AttachLabel.Padding = new System.Windows.Forms.Padding(13, 0, 0, 12);
            this.AttachLabel.Size = new System.Drawing.Size(126, 35);
            this.AttachLabel.TabIndex = 3;
            this.AttachLabel.Text = "Not Attached";
            // 
            // button_info
            // 
            this.button_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.button_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_info.FlatAppearance.BorderSize = 0;
            this.button_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_info.ForeColor = System.Drawing.Color.White;
            this.button_info.Location = new System.Drawing.Point(0, 148);
            this.button_info.Margin = new System.Windows.Forms.Padding(4);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(200, 74);
            this.button_info.TabIndex = 2;
            this.button_info.Text = "Info";
            this.button_info.UseVisualStyleBackColor = false;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // button_cheats2
            // 
            this.button_cheats2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_cheats2.FlatAppearance.BorderSize = 0;
            this.button_cheats2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cheats2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cheats2.ForeColor = System.Drawing.Color.White;
            this.button_cheats2.Location = new System.Drawing.Point(0, 74);
            this.button_cheats2.Margin = new System.Windows.Forms.Padding(4);
            this.button_cheats2.Name = "button_cheats2";
            this.button_cheats2.Size = new System.Drawing.Size(200, 74);
            this.button_cheats2.TabIndex = 1;
            this.button_cheats2.Text = "Cheats 2";
            this.button_cheats2.UseVisualStyleBackColor = true;
            this.button_cheats2.Click += new System.EventHandler(this.button_cheats2_Click);
            // 
            // button_cheats1
            // 
            this.button_cheats1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_cheats1.FlatAppearance.BorderSize = 0;
            this.button_cheats1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cheats1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cheats1.ForeColor = System.Drawing.Color.White;
            this.button_cheats1.Location = new System.Drawing.Point(0, 0);
            this.button_cheats1.Margin = new System.Windows.Forms.Padding(4);
            this.button_cheats1.Name = "button_cheats1";
            this.button_cheats1.Size = new System.Drawing.Size(200, 74);
            this.button_cheats1.TabIndex = 0;
            this.button_cheats1.Text = "Cheats 1";
            this.button_cheats1.UseVisualStyleBackColor = true;
            this.button_cheats1.Click += new System.EventHandler(this.button_cheats1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.userControl_Info1);
            this.panel3.Controls.Add(this.userControl_Cheats21);
            this.panel3.Controls.Add(this.userControl_Cheats11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 480);
            this.panel3.TabIndex = 2;
            // 
            // userControl_Info1
            // 
            this.userControl_Info1.BackColor = System.Drawing.Color.Transparent;
            this.userControl_Info1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Info1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Info1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_Info1.Name = "userControl_Info1";
            this.userControl_Info1.Size = new System.Drawing.Size(867, 480);
            this.userControl_Info1.TabIndex = 0;
            // 
            // userControl_Cheats21
            // 
            this.userControl_Cheats21.BackColor = System.Drawing.Color.Transparent;
            this.userControl_Cheats21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Cheats21.Location = new System.Drawing.Point(0, 0);
            this.userControl_Cheats21.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_Cheats21.Name = "userControl_Cheats21";
            this.userControl_Cheats21.Size = new System.Drawing.Size(867, 480);
            this.userControl_Cheats21.TabIndex = 2;
            this.userControl_Cheats21.Visible = false;
            // 
            // userControl_Cheats11
            // 
            this.userControl_Cheats11.BackColor = System.Drawing.Color.Transparent;
            this.userControl_Cheats11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Cheats11.Location = new System.Drawing.Point(0, 0);
            this.userControl_Cheats11.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_Cheats11.Name = "userControl_Cheats11";
            this.userControl_Cheats11.Size = new System.Drawing.Size(867, 480);
            this.userControl_Cheats11.TabIndex = 1;
            this.userControl_Cheats11.Visible = false;
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Meoware";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.Button button_cheats2;
        private System.Windows.Forms.Button button_cheats1;
        private System.Windows.Forms.Panel panel3;
        private UserControl_Info userControl_Info1;
        private System.Windows.Forms.Label label1;
        private UserControl_Cheats1 userControl_Cheats11;
        private UserControl_Cheats2 userControl_Cheats21;
        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.Label AttachLabel;
        private System.Windows.Forms.Button button_open_growtopia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_lock_window;
    }
}

