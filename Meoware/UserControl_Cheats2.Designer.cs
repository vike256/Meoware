namespace Meoware
{
    partial class UserControl_Cheats2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_tractor = new System.Windows.Forms.CheckBox();
            this.cb_slowmo = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.cb_tractor);
            this.panel1.Controls.Add(this.cb_slowmo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 390);
            this.panel1.TabIndex = 3;
            // 
            // cb_tractor
            // 
            this.cb_tractor.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_tractor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tractor.ForeColor = System.Drawing.Color.Lime;
            this.cb_tractor.Location = new System.Drawing.Point(0, 60);
            this.cb_tractor.Name = "cb_tractor";
            this.cb_tractor.Padding = new System.Windows.Forms.Padding(50, 20, 0, 0);
            this.cb_tractor.Size = new System.Drawing.Size(217, 60);
            this.cb_tractor.TabIndex = 2;
            this.cb_tractor.Text = "Tractor";
            this.cb_tractor.UseVisualStyleBackColor = true;
            this.cb_tractor.CheckedChanged += new System.EventHandler(this.cb_tractor_CheckedChanged);
            // 
            // cb_slowmo
            // 
            this.cb_slowmo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_slowmo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_slowmo.ForeColor = System.Drawing.Color.Lime;
            this.cb_slowmo.Location = new System.Drawing.Point(0, 0);
            this.cb_slowmo.Name = "cb_slowmo";
            this.cb_slowmo.Padding = new System.Windows.Forms.Padding(50, 20, 0, 0);
            this.cb_slowmo.Size = new System.Drawing.Size(217, 60);
            this.cb_slowmo.TabIndex = 1;
            this.cb_slowmo.Text = "Slowmo";
            this.cb_slowmo.UseVisualStyleBackColor = true;
            this.cb_slowmo.CheckedChanged += new System.EventHandler(this.cb_slowmo_CheckedChanged);
            // 
            // UserControl_Cheats2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_Cheats2";
            this.Size = new System.Drawing.Size(650, 390);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_tractor;
        private System.Windows.Forms.CheckBox cb_slowmo;
    }
}
