
namespace WindowsFormsApp1
{
    partial class UserForm
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
            this.Device_maneg_button = new System.Windows.Forms.Button();
            this.Show_devices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // zapros
            // 
            this.zapros.Location = new System.Drawing.Point(12, 405);
            this.zapros.Name = "zapros";
            this.zapros.Size = new System.Drawing.Size(176, 57);
            this.zapros.TabIndex = 1;
            this.zapros.Text = "Сделать запрос";
            this.zapros.UseVisualStyleBackColor = true;
            this.zapros.Click += new System.EventHandler(this.zapros_Click_1);
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
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            // Device_maneg_button
            // 
            this.Device_maneg_button.Location = new System.Drawing.Point(12, 342);
            this.Device_maneg_button.Name = "Device_maneg_button";
            this.Device_maneg_button.Size = new System.Drawing.Size(176, 57);
            this.Device_maneg_button.TabIndex = 7;
            this.Device_maneg_button.Text = "Управление устройствами";
            this.Device_maneg_button.UseVisualStyleBackColor = true;
            this.Device_maneg_button.Click += new System.EventHandler(this.Device_maneg_button_click);
            // 
            // Show_devices
            // 
            this.Show_devices.Location = new System.Drawing.Point(12, 468);
            this.Show_devices.Name = "Show_devices";
            this.Show_devices.Size = new System.Drawing.Size(176, 57);
            this.Show_devices.TabIndex = 8;
            this.Show_devices.Text = "Вывод доступных устройств";
            this.Show_devices.UseVisualStyleBackColor = true;
            this.Show_devices.Click += new System.EventHandler(this.Show_devices_button_click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.Show_devices);
            this.Controls.Add(this.Device_maneg_button);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.zapros);
            this.Name = "UserForm";
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
        private System.Windows.Forms.Button Device_maneg_button;
        private System.Windows.Forms.Button Show_devices;
    }
}