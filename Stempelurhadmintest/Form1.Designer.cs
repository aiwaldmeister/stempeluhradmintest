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
            this.MonatsPicker = new System.Windows.Forms.DateTimePicker();
            this.PersonPicker = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Auswertungen = new System.Windows.Forms.TabPage();
            this.Verrechenbare_Zeiten = new System.Windows.Forms.TabPage();
            this.Stempelungen = new System.Windows.Forms.TabPage();
            this.Abwesenheiten = new System.Windows.Forms.TabPage();
            this.Personen = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Montag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mittwoch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donnerstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freitag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Samstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sonntag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Ereignisgrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sollzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urlaub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vermerk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.KalenderGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Abwesenheiten.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ereignisgrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
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
            this.KalenderGrid.Location = new System.Drawing.Point(272, 30);
            this.KalenderGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KalenderGrid.Name = "KalenderGrid";
            this.KalenderGrid.ReadOnly = true;
            this.KalenderGrid.RowHeadersVisible = false;
            this.KalenderGrid.RowHeadersWidth = 30;
            this.KalenderGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.KalenderGrid.Size = new System.Drawing.Size(353, 170);
            this.KalenderGrid.TabIndex = 2;
            this.KalenderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KalenderGrid_CellContentClick);
            // 
            // MonatsPicker
            // 
            this.MonatsPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonatsPicker.CustomFormat = "MMMM       yyyy";
            this.MonatsPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonatsPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonatsPicker.Location = new System.Drawing.Point(19, 30);
            this.MonatsPicker.Margin = new System.Windows.Forms.Padding(0);
            this.MonatsPicker.Name = "MonatsPicker";
            this.MonatsPicker.ShowUpDown = true;
            this.MonatsPicker.Size = new System.Drawing.Size(236, 30);
            this.MonatsPicker.TabIndex = 3;
            this.MonatsPicker.ValueChanged += new System.EventHandler(this.MonatsPicker_ValueChanged);
            // 
            // PersonPicker
            // 
            this.PersonPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonPicker.FormattingEnabled = true;
            this.PersonPicker.Items.AddRange(new object[] {
            "Allgemein"});
            this.PersonPicker.Location = new System.Drawing.Point(19, 82);
            this.PersonPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PersonPicker.Name = "PersonPicker";
            this.PersonPicker.Size = new System.Drawing.Size(236, 33);
            this.PersonPicker.TabIndex = 4;
            this.PersonPicker.Text = "Allgemein";
            this.PersonPicker.SelectedIndexChanged += new System.EventHandler(this.PersonPicker_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Auswertungen);
            this.tabControl1.Controls.Add(this.Verrechenbare_Zeiten);
            this.tabControl1.Controls.Add(this.Stempelungen);
            this.tabControl1.Controls.Add(this.Abwesenheiten);
            this.tabControl1.Controls.Add(this.Personen);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1106, 720);
            this.tabControl1.TabIndex = 5;
            // 
            // Auswertungen
            // 
            this.Auswertungen.Location = new System.Drawing.Point(4, 25);
            this.Auswertungen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Auswertungen.Name = "Auswertungen";
            this.Auswertungen.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Auswertungen.Size = new System.Drawing.Size(1098, 691);
            this.Auswertungen.TabIndex = 3;
            this.Auswertungen.Text = "Auswertungen";
            this.Auswertungen.UseVisualStyleBackColor = true;
            // 
            // Verrechenbare_Zeiten
            // 
            this.Verrechenbare_Zeiten.Location = new System.Drawing.Point(4, 25);
            this.Verrechenbare_Zeiten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Verrechenbare_Zeiten.Name = "Verrechenbare_Zeiten";
            this.Verrechenbare_Zeiten.Size = new System.Drawing.Size(1098, 691);
            this.Verrechenbare_Zeiten.TabIndex = 4;
            this.Verrechenbare_Zeiten.Text = "Verrechnung";
            this.Verrechenbare_Zeiten.UseVisualStyleBackColor = true;
            // 
            // Stempelungen
            // 
            this.Stempelungen.Location = new System.Drawing.Point(4, 25);
            this.Stempelungen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Stempelungen.Name = "Stempelungen";
            this.Stempelungen.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Stempelungen.Size = new System.Drawing.Size(1098, 691);
            this.Stempelungen.TabIndex = 1;
            this.Stempelungen.Text = "Stempelungen";
            this.Stempelungen.UseVisualStyleBackColor = true;
            // 
            // Abwesenheiten
            // 
            this.Abwesenheiten.Controls.Add(this.groupBox4);
            this.Abwesenheiten.Controls.Add(this.Ereignisgrid);
            this.Abwesenheiten.Controls.Add(this.groupBox2);
            this.Abwesenheiten.Controls.Add(this.groupBox1);
            this.Abwesenheiten.Controls.Add(this.label7);
            this.Abwesenheiten.Location = new System.Drawing.Point(4, 25);
            this.Abwesenheiten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Abwesenheiten.Name = "Abwesenheiten";
            this.Abwesenheiten.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Abwesenheiten.Size = new System.Drawing.Size(1098, 691);
            this.Abwesenheiten.TabIndex = 2;
            this.Abwesenheiten.Text = "Kalender-Eintragungen";
            this.Abwesenheiten.UseVisualStyleBackColor = true;
            this.Abwesenheiten.Click += new System.EventHandler(this.Abwesenheiten_Click);
            // 
            // Personen
            // 
            this.Personen.Location = new System.Drawing.Point(4, 25);
            this.Personen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Personen.Name = "Personen";
            this.Personen.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Personen.Size = new System.Drawing.Size(695, 442);
            this.Personen.TabIndex = 0;
            this.Personen.Text = "Personen verwalten";
            this.Personen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Für Person X am 01.01.2099...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "7.2";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "ganzer Tag Urlaub";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 27);
            this.button3.TabIndex = 8;
            this.button3.Text = "halber Tag Urlaub";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(598, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "sonstigen Kalendereintrag erstellen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(598, 42);
            this.button5.TabIndex = 8;
            this.button5.Text = "alle Einträge stornieren";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(315, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(310, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Halber Tag Urlaub";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Urlaub abziehen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bemerkung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "neue Sollzeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tag(e)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stunden";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(15, 555);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 112);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eintragungen stornieren";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 260);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eintrag erstellen";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(27, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 59);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Voreinstellungen";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(670, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Eintragungen zu PersonX in 2099";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // Montag
            // 
            this.Montag.Frozen = true;
            this.Montag.HeaderText = "Mo";
            this.Montag.Name = "Montag";
            this.Montag.ReadOnly = true;
            this.Montag.Width = 50;
            // 
            // Dienstag
            // 
            this.Dienstag.Frozen = true;
            this.Dienstag.HeaderText = "Di";
            this.Dienstag.Name = "Dienstag";
            this.Dienstag.ReadOnly = true;
            this.Dienstag.Width = 50;
            // 
            // Mittwoch
            // 
            this.Mittwoch.Frozen = true;
            this.Mittwoch.HeaderText = "Mi";
            this.Mittwoch.Name = "Mittwoch";
            this.Mittwoch.ReadOnly = true;
            this.Mittwoch.Width = 50;
            // 
            // Donnerstag
            // 
            this.Donnerstag.Frozen = true;
            this.Donnerstag.HeaderText = "Do";
            this.Donnerstag.Name = "Donnerstag";
            this.Donnerstag.ReadOnly = true;
            this.Donnerstag.Width = 50;
            // 
            // Freitag
            // 
            this.Freitag.Frozen = true;
            this.Freitag.HeaderText = "Fr";
            this.Freitag.Name = "Freitag";
            this.Freitag.ReadOnly = true;
            this.Freitag.Width = 50;
            // 
            // Samstag
            // 
            this.Samstag.Frozen = true;
            this.Samstag.HeaderText = "Sa";
            this.Samstag.Name = "Samstag";
            this.Samstag.ReadOnly = true;
            this.Samstag.Width = 50;
            // 
            // Sonntag
            // 
            this.Sonntag.Frozen = true;
            this.Sonntag.HeaderText = "So";
            this.Sonntag.Name = "Sonntag";
            this.Sonntag.ReadOnly = true;
            this.Sonntag.Width = 50;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(367, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 27);
            this.button6.TabIndex = 8;
            this.button6.Text = "Krankheitstag";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(495, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 27);
            this.button7.TabIndex = 8;
            this.button7.Text = "Feiertag";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ereignisgrid
            // 
            this.Ereignisgrid.AllowUserToAddRows = false;
            this.Ereignisgrid.AllowUserToDeleteRows = false;
            this.Ereignisgrid.AllowUserToResizeColumns = false;
            this.Ereignisgrid.AllowUserToResizeRows = false;
            this.Ereignisgrid.BackgroundColor = System.Drawing.Color.White;
            this.Ereignisgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ereignisgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Sollzeit,
            this.Urlaub,
            this.Vermerk});
            this.Ereignisgrid.Location = new System.Drawing.Point(673, 50);
            this.Ereignisgrid.Name = "Ereignisgrid";
            this.Ereignisgrid.RowHeadersVisible = false;
            this.Ereignisgrid.RowTemplate.Height = 24;
            this.Ereignisgrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ereignisgrid.Size = new System.Drawing.Size(403, 617);
            this.Ereignisgrid.TabIndex = 11;
            this.Ereignisgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ereignisgrid_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.KalenderGrid);
            this.groupBox4.Controls.Add(this.MonatsPicker);
            this.groupBox4.Controls.Add(this.PersonPicker);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(15, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(640, 225);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Auswahl";
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Dat.";
            this.Datum.Name = "Datum";
            this.Datum.Width = 50;
            // 
            // Sollzeit
            // 
            this.Sollzeit.HeaderText = "Soll";
            this.Sollzeit.Name = "Sollzeit";
            this.Sollzeit.Width = 40;
            // 
            // Urlaub
            // 
            this.Urlaub.HeaderText = "Urlb";
            this.Urlaub.Name = "Urlaub";
            this.Urlaub.Width = 40;
            // 
            // Vermerk
            // 
            this.Vermerk.HeaderText = "Vermerk";
            this.Vermerk.Name = "Vermerk";
            this.Vermerk.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 746);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KalenderGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Abwesenheiten.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ereignisgrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView KalenderGrid;
        private System.Windows.Forms.DateTimePicker MonatsPicker;
        private System.Windows.Forms.ComboBox PersonPicker;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Auswertungen;
        private System.Windows.Forms.TabPage Verrechenbare_Zeiten;
        private System.Windows.Forms.TabPage Stempelungen;
        private System.Windows.Forms.TabPage Abwesenheiten;
        private System.Windows.Forms.TabPage Personen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mittwoch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donnerstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freitag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Samstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sonntag;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView Ereignisgrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sollzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urlaub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vermerk;
    }
}

