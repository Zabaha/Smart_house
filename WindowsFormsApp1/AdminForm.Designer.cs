
namespace WindowsFormsApp1
{
    partial class AdminForm
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
            this.zapros = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // zapros
            // 
            this.zapros.Location = new System.Drawing.Point(12, 415);
            this.zapros.Name = "Chat";
            this.zapros.Size = new System.Drawing.Size(176, 57);
            this.zapros.TabIndex = 1;
            this.zapros.Text = "Войти в чат";
            this.zapros.UseVisualStyleBackColor = true;
            this.zapros.Click += new System.EventHandler(this.Chat_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(776, 181);
            this.dgv.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 214);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(612, 581);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(176, 57);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "Очистка";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 478);
            this.button5.Name = "Device_button";
            this.button5.Size = new System.Drawing.Size(176, 57);
            this.button5.TabIndex = 10;
            this.button5.Text = "Добавить девайс";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Device_button_Click);
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(12, 352);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(176, 57);
            this.Registration.TabIndex = 11;
            this.Registration.Text = "Регистрация";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_button_click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.zapros);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button zapros;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Registration;
    }
}