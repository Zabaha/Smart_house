
namespace WindowsFormsApp1
{
    partial class RegForm2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rolefield = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ofield = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nfield = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ffield = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rolefield);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Ofield);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Nfield);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Ffield);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 604);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(19, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 46);
            this.label6.TabIndex = 9;
            this.label6.Text = "Роль";
            // 
            // rolefield
            // 
            this.rolefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rolefield.Location = new System.Drawing.Point(27, 449);
            this.rolefield.Multiline = true;
            this.rolefield.Name = "rolefield";
            this.rolefield.Size = new System.Drawing.Size(318, 47);
            this.rolefield.TabIndex = 10;
            this.rolefield.Enter += new System.EventHandler(this.rolefield_Enter);
            this.rolefield.Leave += new System.EventHandler(this.rolefield_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 46);
            this.label5.TabIndex = 7;
            this.label5.Text = "Отчество";
            // 
            // Ofield
            // 
            this.Ofield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ofield.Location = new System.Drawing.Point(27, 345);
            this.Ofield.Multiline = true;
            this.Ofield.Name = "Ofield";
            this.Ofield.Size = new System.Drawing.Size(318, 47);
            this.Ofield.TabIndex = 8;
            this.Ofield.Enter += new System.EventHandler(this.Ofield_Enter);
            this.Ofield.Leave += new System.EventHandler(this.Ofield_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "Имя";
            // 
            // Nfield
            // 
            this.Nfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nfield.Location = new System.Drawing.Point(27, 246);
            this.Nfield.Multiline = true;
            this.Nfield.Name = "Nfield";
            this.Nfield.Size = new System.Drawing.Size(318, 47);
            this.Nfield.TabIndex = 6;
            this.Nfield.Enter += new System.EventHandler(this.Nfield_Enter);
            this.Nfield.Leave += new System.EventHandler(this.Nfield_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия";
            // 
            // Ffield
            // 
            this.Ffield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ffield.Location = new System.Drawing.Point(27, 139);
            this.Ffield.Multiline = true;
            this.Ffield.Name = "Ffield";
            this.Ffield.Size = new System.Drawing.Size(318, 47);
            this.Ffield.TabIndex = 3;
            this.Ffield.Enter += new System.EventHandler(this.Ffield_Enter);
            this.Ffield.Leave += new System.EventHandler(this.Ffield_Leave);
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
            // login_button
            // 
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(256, 543);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(296, 49);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "Зарегистрироваться";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // RegForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 604);
            this.Controls.Add(this.panel1);
            this.Name = "RegForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Ffield;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rolefield;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Ofield;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nfield;
    }
}