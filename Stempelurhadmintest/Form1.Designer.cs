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
            this.KalenderGrid = new System.Windows.Forms.DataGridView();
            this.Montag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mittwoch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donnerstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freitag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Samstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sonntag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonatsPicker = new System.Windows.Forms.DateTimePicker();
            this.PersonPicker = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.KalenderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KalenderGrid
            // 
            this.KalenderGrid.AllowUserToAddRows = false;
            this.KalenderGrid.AllowUserToDeleteRows = false;
            this.KalenderGrid.AllowUserToResizeColumns = false;
            this.KalenderGrid.AllowUserToResizeRows = false;
            this.KalenderGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.KalenderGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.KalenderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KalenderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Montag,
            this.Dienstag,
            this.Mittwoch,
            this.Donnerstag,
            this.Freitag,
            this.Samstag,
            this.Sonntag});
            this.KalenderGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.KalenderGrid.GridColor = System.Drawing.SystemColors.WindowText;
            this.KalenderGrid.Location = new System.Drawing.Point(12, 440);
            this.KalenderGrid.Name = "KalenderGrid";
            this.KalenderGrid.ReadOnly = true;
            this.KalenderGrid.RowHeadersVisible = false;
            this.KalenderGrid.RowHeadersWidth = 30;
            this.KalenderGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.KalenderGrid.Size = new System.Drawing.Size(214, 154);
            this.KalenderGrid.TabIndex = 2;
            // 
            // Montag
            // 
            this.Montag.Frozen = true;
            this.Montag.HeaderText = "Mo";
            this.Montag.Name = "Montag";
            this.Montag.ReadOnly = true;
            this.Montag.Width = 30;
            // 
            // Dienstag
            // 
            this.Dienstag.Frozen = true;
            this.Dienstag.HeaderText = "Di";
            this.Dienstag.Name = "Dienstag";
            this.Dienstag.ReadOnly = true;
            this.Dienstag.Width = 30;
            // 
            // Mittwoch
            // 
            this.Mittwoch.Frozen = true;
            this.Mittwoch.HeaderText = "Mi";
            this.Mittwoch.Name = "Mittwoch";
            this.Mittwoch.ReadOnly = true;
            this.Mittwoch.Width = 30;
            // 
            // Donnerstag
            // 
            this.Donnerstag.Frozen = true;
            this.Donnerstag.HeaderText = "Do";
            this.Donnerstag.Name = "Donnerstag";
            this.Donnerstag.ReadOnly = true;
            this.Donnerstag.Width = 30;
            // 
            // Freitag
            // 
            this.Freitag.Frozen = true;
            this.Freitag.HeaderText = "Fr";
            this.Freitag.Name = "Freitag";
            this.Freitag.ReadOnly = true;
            this.Freitag.Width = 30;
            // 
            // Samstag
            // 
            this.Samstag.Frozen = true;
            this.Samstag.HeaderText = "Sa";
            this.Samstag.Name = "Samstag";
            this.Samstag.ReadOnly = true;
            this.Samstag.Width = 30;
            // 
            // Sonntag
            // 
            this.Sonntag.Frozen = true;
            this.Sonntag.HeaderText = "So";
            this.Sonntag.Name = "Sonntag";
            this.Sonntag.ReadOnly = true;
            this.Sonntag.Width = 30;
            // 
            // MonatsPicker
            // 
            this.MonatsPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonatsPicker.CustomFormat = "MMMM       yyyy";
            this.MonatsPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonatsPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonatsPicker.Location = new System.Drawing.Point(12, 413);
            this.MonatsPicker.Margin = new System.Windows.Forms.Padding(0);
            this.MonatsPicker.Name = "MonatsPicker";
            this.MonatsPicker.ShowUpDown = true;
            this.MonatsPicker.Size = new System.Drawing.Size(214, 26);
            this.MonatsPicker.TabIndex = 3;
            this.MonatsPicker.ValueChanged += new System.EventHandler(this.MonatsPicker_ValueChanged);
            // 
            // PersonPicker
            // 
            this.PersonPicker.FormattingEnabled = true;
            this.PersonPicker.Items.AddRange(new object[] {
            "Allgemein"});
            this.PersonPicker.Location = new System.Drawing.Point(12, 360);
            this.PersonPicker.Name = "PersonPicker";
            this.PersonPicker.Size = new System.Drawing.Size(118, 21);
            this.PersonPicker.TabIndex = 4;
            this.PersonPicker.Text = "Allgemein";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 606);
            this.Controls.Add(this.PersonPicker);
            this.Controls.Add(this.MonatsPicker);
            this.Controls.Add(this.KalenderGrid);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KalenderGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView KalenderGrid;
        private System.Windows.Forms.DateTimePicker MonatsPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mittwoch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donnerstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freitag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Samstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sonntag;
        private System.Windows.Forms.ComboBox PersonPicker;
    }
}

