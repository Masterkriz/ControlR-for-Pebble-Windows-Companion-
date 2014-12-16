namespace ControlR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBackOff = new System.Windows.Forms.TextBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.txtUp = new System.Windows.Forms.TextBox();
            this.lblDown = new System.Windows.Forms.Label();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtBackOn = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // txtBackOff
            // 
            this.txtBackOff.Location = new System.Drawing.Point(107, 12);
            this.txtBackOff.Name = "txtBackOff";
            this.txtBackOff.Size = new System.Drawing.Size(114, 20);
            this.txtBackOff.TabIndex = 0;
            this.txtBackOff.Text = "{F5}";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(17, 15);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(35, 13);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "BACK";
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Location = new System.Drawing.Point(17, 41);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(22, 13);
            this.lblUp.TabIndex = 3;
            this.lblUp.Text = "UP";
            // 
            // txtUp
            // 
            this.txtUp.Location = new System.Drawing.Point(107, 38);
            this.txtUp.Name = "txtUp";
            this.txtUp.Size = new System.Drawing.Size(238, 20);
            this.txtUp.TabIndex = 2;
            this.txtUp.Text = "{LEFT}";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Location = new System.Drawing.Point(17, 67);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(42, 13);
            this.lblDown.TabIndex = 5;
            this.lblDown.Text = "DOWN";
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point(107, 64);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(238, 20);
            this.txtDown.TabIndex = 4;
            this.txtDown.Text = "{RIGHT}";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(17, 93);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(48, 13);
            this.lblSelect.TabIndex = 7;
            this.lblSelect.Text = "SELECT";
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(107, 90);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(238, 20);
            this.txtSelect.TabIndex = 6;
            this.txtSelect.Text = "{HOME}";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(17, 153);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(0, 13);
            this.lblIP.TabIndex = 11;
            // 
            // txtBackOn
            // 
            this.txtBackOn.Location = new System.Drawing.Point(227, 11);
            this.txtBackOn.Name = "txtBackOn";
            this.txtBackOn.Size = new System.Drawing.Size(117, 20);
            this.txtBackOn.TabIndex = 12;
            this.txtBackOn.Text = "{ESC}";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ControlR for Pebble";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 121);
            this.Controls.Add(this.txtBackOn);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.txtDown);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.txtUp);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.txtBackOff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ControlR for Pebble - Windows Companion App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBackOff;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.TextBox txtUp;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtBackOn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

