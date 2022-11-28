namespace firmaPMS
{
    partial class boczny
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ok1 = new System.Windows.Forms.Button();
            this.anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ok1
            // 
            this.ok1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok1.Location = new System.Drawing.Point(58, 64);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(75, 23);
            this.ok1.TabIndex = 2;
            this.ok1.Text = "ok";
            this.ok1.UseVisualStyleBackColor = true;
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // anuluj
            // 
            this.anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.anuluj.Location = new System.Drawing.Point(192, 64);
            this.anuluj.Name = "anuluj";
            this.anuluj.Size = new System.Drawing.Size(76, 23);
            this.anuluj.TabIndex = 3;
            this.anuluj.Text = "Anuluj";
            this.anuluj.UseVisualStyleBackColor = true;
            // 
            // boczny
            // 
            this.AcceptButton = this.ok1;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.anuluj;
            this.ClientSize = new System.Drawing.Size(290, 108);
            this.Controls.Add(this.anuluj);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "boczny";
            this.Text = "Dodawanie galezi";
            this.Load += new System.EventHandler(this.form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ok1;
        private System.Windows.Forms.Button anuluj;
    }
}