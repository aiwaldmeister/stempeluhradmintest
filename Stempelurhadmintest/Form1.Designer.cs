namespace Stempelurhadmintest
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Montag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mittwoch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donnerstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freitag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Samstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sonntag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "init kalender";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Montag,
            this.Dienstag,
            this.Mittwoch,
            this.Donnerstag,
            this.Freitag,
            this.Samstag,
            this.Sonntag});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView1.Location = new System.Drawing.Point(18, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(283, 154);
            this.dataGridView1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "MMMM yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 254);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Montag
            // 
            this.Montag.Frozen = true;
            this.Montag.HeaderText = "Mo";
            this.Montag.Name = "Montag";
            this.Montag.ReadOnly = true;
            this.Montag.Width = 40;
            // 
            // Dienstag
            // 
            this.Dienstag.Frozen = true;
            this.Dienstag.HeaderText = "Di";
            this.Dienstag.Name = "Dienstag";
            this.Dienstag.ReadOnly = true;
            this.Dienstag.Width = 40;
            // 
            // Mittwoch
            // 
            this.Mittwoch.Frozen = true;
            this.Mittwoch.HeaderText = "Mi";
            this.Mittwoch.Name = "Mittwoch";
            this.Mittwoch.ReadOnly = true;
            this.Mittwoch.Width = 40;
            // 
            // Donnerstag
            // 
            this.Donnerstag.Frozen = true;
            this.Donnerstag.HeaderText = "Do";
            this.Donnerstag.Name = "Donnerstag";
            this.Donnerstag.ReadOnly = true;
            this.Donnerstag.Width = 40;
            // 
            // Freitag
            // 
            this.Freitag.Frozen = true;
            this.Freitag.HeaderText = "Fr";
            this.Freitag.Name = "Freitag";
            this.Freitag.ReadOnly = true;
            this.Freitag.Width = 40;
            // 
            // Samstag
            // 
            this.Samstag.Frozen = true;
            this.Samstag.HeaderText = "Sa";
            this.Samstag.Name = "Samstag";
            this.Samstag.ReadOnly = true;
            this.Samstag.Width = 40;
            // 
            // Sonntag
            // 
            this.Sonntag.Frozen = true;
            this.Sonntag.HeaderText = "So";
            this.Sonntag.Name = "Sonntag";
            this.Sonntag.ReadOnly = true;
            this.Sonntag.Width = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 606);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mittwoch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donnerstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freitag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Samstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sonntag;
    }
}

