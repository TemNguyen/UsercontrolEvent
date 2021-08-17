
namespace UsercontrolEvent
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
            this.userControl11 = new ClassLibrary1.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(167, 26);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(406, 212);
            this.userControl11.TabIndex = 0;
            this.userControl11.Button1_Click += new System.EventHandler(this.userControl11_Button1_Click);
            this.userControl11.TextBox1_TextChanged += new System.EventHandler(this.userControl11_TextBox1_TextChanged);
            this.userControl11.ComboBox1_SelectedIndexChanged += new System.EventHandler(this.userControl11_ComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary1.UserControl1 userControl11;
    }
}

