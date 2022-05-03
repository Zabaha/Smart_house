
namespace WindowsFormsApp1
{
    partial class RegForm1
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
            this.login_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.passfield = new System.Windows.Forms.TextBox();
            this.loginfield = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(256, 543);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(296, 49);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "Далее";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 74);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(286, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Регистрация";
            // 
            // passfield
            // 
            this.passfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passfield.Location = new System.Drawing.Point(256, 348);
            this.passfield.Name = "passfield";
            this.passfield.Size = new System.Drawing.Size(318, 34);
            this.passfield.TabIndex = 4;
            this.passfield.UseSystemPasswordChar = true;
            this.passfield.Enter += new System.EventHandler(this.passfield_Enter);
            this.passfield.Leave += new System.EventHandler(this.passfield_Leave);
            // 
            // loginfield
            // 
            this.loginfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginfield.Location = new System.Drawing.Point(256, 244);
            this.loginfield.Multiline = true;
            this.loginfield.Name = "loginfield";
            this.loginfield.Size = new System.Drawing.Size(318, 47);
            this.loginfield.TabIndex = 12;
            this.loginfield.Enter += new System.EventHandler(this.loginfield_Enter);
            this.loginfield.Leave += new System.EventHandler(this.loginfield_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(248, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 46);
            this.label7.TabIndex = 11;
            this.label7.Text = "Логин";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(248, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 46);
            this.label8.TabIndex = 13;
            this.label8.Text = "Пароль";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.loginfield);
            this.panel1.Controls.Add(this.passfield);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 604);
            this.panel1.TabIndex = 4;
            // 
            // RegForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 604);
            this.Controls.Add(this.panel1);
            this.Name = "RegForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passfield;
        private System.Windows.Forms.TextBox loginfield;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}