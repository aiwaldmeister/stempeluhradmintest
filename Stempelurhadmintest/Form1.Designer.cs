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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.KalenderGrid_Kalender = new System.Windows.Forms.DataGridView();
            this.Montag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mittwoch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donnerstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freitag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Samstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sonntag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonatsPicker_Kalender = new System.Windows.Forms.DateTimePicker();
            this.PersonPicker_Kalender = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Kalender = new System.Windows.Forms.TabPage();
            this.button_Kalender_Monatvor = new System.Windows.Forms.Button();
            this.button_Kalender_Monatzurueck = new System.Windows.Forms.Button();
            this.groupBox_Kalender_erstelleEintrag = new System.Windows.Forms.GroupBox();
            this.button_Kalender_ganzerTagUrlaub = new System.Windows.Forms.Button();
            this.button_Kalender_Feiertag = new System.Windows.Forms.Button();
            this.button_Kalender_erstelleEintrag = new System.Windows.Forms.Button();
            this.myiconlist = new System.Windows.Forms.ImageList(this.components);
            this.button_Kalender_Krankheitstag = new System.Windows.Forms.Button();
            this.textBox_Kalender_Sollzeit = new System.Windows.Forms.TextBox();
            this.button_Kalender_halberTagUrlaub = new System.Windows.Forms.Button();
            this.textBox_Kalender_Urlaub = new System.Windows.Forms.TextBox();
            this.textBox_Kalender_Bemerkung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_Kalender_AlleEreignisse = new System.Windows.Forms.GroupBox();
            this.button_Kalender_storniereEintrag = new System.Windows.Forms.Button();
            this.Ereignisgrid_Kalender = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sollzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urlaub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vermerk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verrechnung = new System.Windows.Forms.TabPage();
            this.groupBox_Verrechnungen_Update = new System.Windows.Forms.GroupBox();
            this.DatePicker_Verrechnung_Update = new System.Windows.Forms.DateTimePicker();
            this.button_Verrechnungen_SatzStornieren = new System.Windows.Forms.Button();
            this.button_Verrechnungen_SatzUeberschreiben = new System.Windows.Forms.Button();
            this.Verrechnungsgrid_Verrechnungen_Update = new System.Windows.Forms.DataGridView();
            this.satzid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verrechnungsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verrechnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_Verrechnung_StundenGesamt = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox_Verrechnungen_Stunden_edit = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox_Verrechnungen_Insert = new System.Windows.Forms.GroupBox();
            this.DatePicker_Verrechnung_Insert = new System.Windows.Forms.DateTimePicker();
            this.button_Verrechnungen_SatzErstellen = new System.Windows.Forms.Button();
            this.Verrechnungsgrid_Verrechnungen_Insert = new System.Windows.Forms.DataGridView();
            this.Mitarbeiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dat_letzte_Stempelung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gesamtzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_Verrechnungen_Stunden_Insert = new System.Windows.Forms.TextBox();
            this.textBox_Verrechnungen_Mitarbeiter_Insert = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.Auftragspicker_Verrechnung_Insert = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_Verrechnung_Auftragsnummer = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.Bonusberechnung = new System.Windows.Forms.TabPage();
            this.groupBox_Bonus_neu = new System.Windows.Forms.GroupBox();
            this.label_Bonus_Neu_ErstmoeglicherTag = new System.Windows.Forms.Label();
            this.label_Bonus_Neu_LetzterVollverrechneterTag = new System.Windows.Forms.Label();
            this.button_Bonus_BerechnenBis = new System.Windows.Forms.Button();
            this.DatePicker_Bonus_Neu_BerechnenBis = new System.Windows.Forms.DateTimePicker();
            this.label53 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBoxLetzteBonusberechnung = new System.Windows.Forms.GroupBox();
            this.label_Bonus_Alt_Bonuszeit = new System.Windows.Forms.Label();
            this.label_Bonus_Alt_BerechnetBis = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.PersonPicker_Bonus = new System.Windows.Forms.ComboBox();
            this.Stempelungen = new System.Windows.Forms.TabPage();
            this.button_Stempelungen_DatePickerTagzurueck = new System.Windows.Forms.Button();
            this.button_Stempelungen_DatePickerTagvorwaerts = new System.Windows.Forms.Button();
            this.groupBox_Stempelungen_Zeitkonto = new System.Windows.Forms.GroupBox();
            this.label_Stempelungen_Zeitkonto_Berechnungsstand = new System.Windows.Forms.Label();
            this.label_Stempelungen_Hinweis = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.button_Stempelungen_ZeitkontoRueckrechnen = new System.Windows.Forms.Button();
            this.groupBox_Stempelungen_EditierenErstellen = new System.Windows.Forms.GroupBox();
            this.TimePicker_Stempelungen = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Stempelungen_Art = new System.Windows.Forms.ComboBox();
            this.textBox_Stempelungen_Auftragsnummer = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button_Stempelungen_neueStempelung = new System.Windows.Forms.Button();
            this.button_Stempelungen_stornieren = new System.Windows.Forms.Button();
            this.button_Stempelungen_ueberschreiben = new System.Windows.Forms.Button();
            this.Stempelungsgrid_Stempelungen = new System.Windows.Forms.DataGridView();
            this.stampid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StampArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StampTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StampZeitstempel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StampSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePicker_Stempelungen = new System.Windows.Forms.DateTimePicker();
            this.PersonPicker_Stempelungen = new System.Windows.Forms.ComboBox();
            this.Personen = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Personen_ZeitkontoRueckrechnen = new System.Windows.Forms.Button();
            this.DatePicker_Personen_ZeitkontoRueckrechnen = new System.Windows.Forms.DateTimePicker();
            this.label_Personen_Hinweis_ZeitBerechnungsstand = new System.Windows.Forms.Label();
            this.label_Personen_Hinweis_Urlaubsjahr = new System.Windows.Forms.Label();
            this.button_Personen_ZeitkontoAktualisieren = new System.Windows.Forms.Button();
            this.button_Personen_UrlaubsjahrAktualisieren = new System.Windows.Forms.Button();
            this.button_Personen_Edit_Systemdaten = new System.Windows.Forms.Button();
            this.PersonPicker_Personen = new System.Windows.Forms.ComboBox();
            this.groupBox_Personen_Systemdaten = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.comboBox_Personen_Stempelfehler_old = new System.Windows.Forms.ComboBox();
            this.comboBox_Personen_Stempelfehler = new System.Windows.Forms.ComboBox();
            this.textBox_Personen_AktUrlaubsjahr_old = new System.Windows.Forms.TextBox();
            this.textBox_Personen_ResturlaubVorjahr_old = new System.Windows.Forms.TextBox();
            this.textBox_Personen_AktUrlaubsjahr = new System.Windows.Forms.TextBox();
            this.textBox_Personen_AktAuftrag_old = new System.Windows.Forms.TextBox();
            this.textBox_Personen_ResturlaubVorjahr = new System.Windows.Forms.TextBox();
            this.textBox_Personen_AktAuftrag = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_Personen_BetragletzterBonus_old = new System.Windows.Forms.TextBox();
            this.textBox_Personen_BetragletzterBonus = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_Personen_Boniausgezahltbis_old = new System.Windows.Forms.TextBox();
            this.textBox_Personen_Boniausgezahltbis = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_Personen_ZeitkontoBerechnungsstand_old = new System.Windows.Forms.TextBox();
            this.textBox_Personen_ZeitkontoBerechnungsstand = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_Personen_Zeitkonto_old = new System.Windows.Forms.TextBox();
            this.textBox_Personen_Zeitkonto = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DatePicker_Personen_neu = new System.Windows.Forms.DateTimePicker();
            this.textBox_Personen_Neu_WunschID = new System.Windows.Forms.TextBox();
            this.textBox_Personen_Neu_Urlaubstage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Personen_Neu_Nachname = new System.Windows.Forms.TextBox();
            this.button_Personen_newPerson = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_Personen_Neu_Vorname = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Personen_Aktiv_old = new System.Windows.Forms.ComboBox();
            this.comboBox_Personen_Aktiv = new System.Windows.Forms.ComboBox();
            this.textBox_Personen_Urlaubstage_old = new System.Windows.Forms.TextBox();
            this.textBox_Personen_Urlaubstage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Personen_Nachname_old = new System.Windows.Forms.TextBox();
            this.textBox_Personen_Nachname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Personen_Vorname_old = new System.Windows.Forms.TextBox();
            this.textBox_Personen_Vorname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Personen_writeChanges = new System.Windows.Forms.Button();
            this.Auswertungen = new System.Windows.Forms.TabPage();
            this.label_Bonus_Hinweis = new System.Windows.Forms.Label();
            this.button_Bonus_ShowGroupbox_Neu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KalenderGrid_Kalender)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Kalender.SuspendLayout();
            this.groupBox_Kalender_erstelleEintrag.SuspendLayout();
            this.groupBox_Kalender_AlleEreignisse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ereignisgrid_Kalender)).BeginInit();
            this.Verrechnung.SuspendLayout();
            this.groupBox_Verrechnungen_Update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Verrechnungsgrid_Verrechnungen_Update)).BeginInit();
            this.groupBox_Verrechnungen_Insert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Verrechnungsgrid_Verrechnungen_Insert)).BeginInit();
            this.Bonusberechnung.SuspendLayout();
            this.groupBox_Bonus_neu.SuspendLayout();
            this.groupBoxLetzteBonusberechnung.SuspendLayout();
            this.Stempelungen.SuspendLayout();
            this.groupBox_Stempelungen_Zeitkonto.SuspendLayout();
            this.groupBox_Stempelungen_EditierenErstellen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stempelungsgrid_Stempelungen)).BeginInit();
            this.Personen.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Personen_Systemdaten.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // KalenderGrid_Kalender
            // 
            this.KalenderGrid_Kalender.AllowUserToAddRows = false;
            this.KalenderGrid_Kalender.AllowUserToDeleteRows = false;
            this.KalenderGrid_Kalender.AllowUserToResizeColumns = false;
            this.KalenderGrid_Kalender.AllowUserToResizeRows = false;
            this.KalenderGrid_Kalender.BackgroundColor = System.Drawing.SystemColors.Window;
            this.KalenderGrid_Kalender.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.KalenderGrid_Kalender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KalenderGrid_Kalender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Montag,
            this.Dienstag,
            this.Mittwoch,
            this.Donnerstag,
            this.Freitag,
            this.Samstag,
            this.Sonntag});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KalenderGrid_Kalender.DefaultCellStyle = dataGridViewCellStyle1;
            this.KalenderGrid_Kalender.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.KalenderGrid_Kalender.GridColor = System.Drawing.SystemColors.WindowText;
            this.KalenderGrid_Kalender.Location = new System.Drawing.Point(82, 108);
            this.KalenderGrid_Kalender.MultiSelect = false;
            this.KalenderGrid_Kalender.Name = "KalenderGrid_Kalender";
            this.KalenderGrid_Kalender.ReadOnly = true;
            this.KalenderGrid_Kalender.RowHeadersVisible = false;
            this.KalenderGrid_Kalender.RowHeadersWidth = 30;
            this.KalenderGrid_Kalender.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.KalenderGrid_Kalender.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.KalenderGrid_Kalender.Size = new System.Drawing.Size(248, 154);
            this.KalenderGrid_Kalender.TabIndex = 3;
            this.KalenderGrid_Kalender.TabStop = false;
            this.KalenderGrid_Kalender.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KalenderGrid_CellContentClick);
            // 
            // Montag
            // 
            this.Montag.Frozen = true;
            this.Montag.HeaderText = "Mo";
            this.Montag.Name = "Montag";
            this.Montag.ReadOnly = true;
            this.Montag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Montag.Width = 35;
            // 
            // Dienstag
            // 
            this.Dienstag.Frozen = true;
            this.Dienstag.HeaderText = "Di";
            this.Dienstag.Name = "Dienstag";
            this.Dienstag.ReadOnly = true;
            this.Dienstag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Dienstag.Width = 35;
            // 
            // Mittwoch
            // 
            this.Mittwoch.Frozen = true;
            this.Mittwoch.HeaderText = "Mi";
            this.Mittwoch.Name = "Mittwoch";
            this.Mittwoch.ReadOnly = true;
            this.Mittwoch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mittwoch.Width = 35;
            // 
            // Donnerstag
            // 
            this.Donnerstag.Frozen = true;
            this.Donnerstag.HeaderText = "Do";
            this.Donnerstag.Name = "Donnerstag";
            this.Donnerstag.ReadOnly = true;
            this.Donnerstag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Donnerstag.Width = 35;
            // 
            // Freitag
            // 
            this.Freitag.Frozen = true;
            this.Freitag.HeaderText = "Fr";
            this.Freitag.Name = "Freitag";
            this.Freitag.ReadOnly = true;
            this.Freitag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Freitag.Width = 35;
            // 
            // Samstag
            // 
            this.Samstag.Frozen = true;
            this.Samstag.HeaderText = "Sa";
            this.Samstag.Name = "Samstag";
            this.Samstag.ReadOnly = true;
            this.Samstag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Samstag.Width = 35;
            // 
            // Sonntag
            // 
            this.Sonntag.Frozen = true;
            this.Sonntag.HeaderText = "So";
            this.Sonntag.Name = "Sonntag";
            this.Sonntag.ReadOnly = true;
            this.Sonntag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sonntag.Width = 35;
            // 
            // MonatsPicker_Kalender
            // 
            this.MonatsPicker_Kalender.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonatsPicker_Kalender.CustomFormat = "MMMM       yyyy";
            this.MonatsPicker_Kalender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonatsPicker_Kalender.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonatsPicker_Kalender.Location = new System.Drawing.Point(82, 74);
            this.MonatsPicker_Kalender.Margin = new System.Windows.Forms.Padding(0);
            this.MonatsPicker_Kalender.Name = "MonatsPicker_Kalender";
            this.MonatsPicker_Kalender.ShowUpDown = true;
            this.MonatsPicker_Kalender.Size = new System.Drawing.Size(248, 29);
            this.MonatsPicker_Kalender.TabIndex = 2;
            this.MonatsPicker_Kalender.ValueChanged += new System.EventHandler(this.MonatsPicker_Kalender_ValueChanged);
            // 
            // PersonPicker_Kalender
            // 
            this.PersonPicker_Kalender.BackColor = System.Drawing.Color.White;
            this.PersonPicker_Kalender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonPicker_Kalender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonPicker_Kalender.ForeColor = System.Drawing.Color.Black;
            this.PersonPicker_Kalender.FormattingEnabled = true;
            this.PersonPicker_Kalender.Items.AddRange(new object[] {
            "Allgemein"});
            this.PersonPicker_Kalender.Location = new System.Drawing.Point(31, 16);
            this.PersonPicker_Kalender.Name = "PersonPicker_Kalender";
            this.PersonPicker_Kalender.Size = new System.Drawing.Size(353, 32);
            this.PersonPicker_Kalender.TabIndex = 1;
            this.PersonPicker_Kalender.SelectedIndexChanged += new System.EventHandler(this.PersonPicker_Kalender_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Kalender);
            this.tabControl1.Controls.Add(this.Verrechnung);
            this.tabControl1.Controls.Add(this.Bonusberechnung);
            this.tabControl1.Controls.Add(this.Stempelungen);
            this.tabControl1.Controls.Add(this.Personen);
            this.tabControl1.Controls.Add(this.Auswertungen);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 585);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Kalender
            // 
            this.Kalender.Controls.Add(this.button_Kalender_Monatvor);
            this.Kalender.Controls.Add(this.button_Kalender_Monatzurueck);
            this.Kalender.Controls.Add(this.KalenderGrid_Kalender);
            this.Kalender.Controls.Add(this.MonatsPicker_Kalender);
            this.Kalender.Controls.Add(this.PersonPicker_Kalender);
            this.Kalender.Controls.Add(this.groupBox_Kalender_erstelleEintrag);
            this.Kalender.Controls.Add(this.groupBox_Kalender_AlleEreignisse);
            this.Kalender.Location = new System.Drawing.Point(4, 22);
            this.Kalender.Name = "Kalender";
            this.Kalender.Padding = new System.Windows.Forms.Padding(3);
            this.Kalender.Size = new System.Drawing.Size(822, 559);
            this.Kalender.TabIndex = 2;
            this.Kalender.Text = "Kalender";
            this.Kalender.UseVisualStyleBackColor = true;
            // 
            // button_Kalender_Monatvor
            // 
            this.button_Kalender_Monatvor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Kalender_Monatvor.Location = new System.Drawing.Point(330, 73);
            this.button_Kalender_Monatvor.Name = "button_Kalender_Monatvor";
            this.button_Kalender_Monatvor.Size = new System.Drawing.Size(54, 29);
            this.button_Kalender_Monatvor.TabIndex = 6;
            this.button_Kalender_Monatvor.Text = ">";
            this.button_Kalender_Monatvor.UseVisualStyleBackColor = true;
            this.button_Kalender_Monatvor.Click += new System.EventHandler(this.button_Kalender_Monatvor_Click);
            // 
            // button_Kalender_Monatzurueck
            // 
            this.button_Kalender_Monatzurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Kalender_Monatzurueck.Location = new System.Drawing.Point(31, 73);
            this.button_Kalender_Monatzurueck.Name = "button_Kalender_Monatzurueck";
            this.button_Kalender_Monatzurueck.Size = new System.Drawing.Size(51, 29);
            this.button_Kalender_Monatzurueck.TabIndex = 6;
            this.button_Kalender_Monatzurueck.Text = "<";
            this.button_Kalender_Monatzurueck.UseVisualStyleBackColor = true;
            this.button_Kalender_Monatzurueck.Click += new System.EventHandler(this.button_Kalender_Monatzurueck_Click);
            // 
            // groupBox_Kalender_erstelleEintrag
            // 
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.button_Kalender_ganzerTagUrlaub);
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.button_Kalender_Feiertag);
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.button_Kalender_erstelleEintrag);
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.button_Kalender_Krankheitstag);
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.textBox_Kalender_Sollzeit);
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.button_Kalender_halberTagUrlaub);
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.textBox_Kalender_Urlaub);
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.textBox_Kalender_Bemerkung);
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.label6);
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.label2);
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.label4);
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.label5);
            this.groupBox_Kalender_erstelleEintrag.Controls.Add(this.label3);
            this.groupBox_Kalender_erstelleEintrag.Location = new System.Drawing.Point(11, 288);
            this.groupBox_Kalender_erstelleEintrag.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Kalender_erstelleEintrag.Name = "groupBox_Kalender_erstelleEintrag";
            this.groupBox_Kalender_erstelleEintrag.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Kalender_erstelleEintrag.Size = new System.Drawing.Size(399, 257);
            this.groupBox_Kalender_erstelleEintrag.TabIndex = 4;
            this.groupBox_Kalender_erstelleEintrag.TabStop = false;
            this.groupBox_Kalender_erstelleEintrag.Text = "Eintrag erstellen";
            // 
            // button_Kalender_ganzerTagUrlaub
            // 
            this.button_Kalender_ganzerTagUrlaub.Location = new System.Drawing.Point(14, 35);
            this.button_Kalender_ganzerTagUrlaub.Margin = new System.Windows.Forms.Padding(2);
            this.button_Kalender_ganzerTagUrlaub.Name = "button_Kalender_ganzerTagUrlaub";
            this.button_Kalender_ganzerTagUrlaub.Size = new System.Drawing.Size(90, 31);
            this.button_Kalender_ganzerTagUrlaub.TabIndex = 1;
            this.button_Kalender_ganzerTagUrlaub.Text = "1 Tag Urlaub";
            this.button_Kalender_ganzerTagUrlaub.UseVisualStyleBackColor = true;
            this.button_Kalender_ganzerTagUrlaub.Click += new System.EventHandler(this.button_Kalender_ganzerTagUrlaub_Click);
            // 
            // button_Kalender_Feiertag
            // 
            this.button_Kalender_Feiertag.Location = new System.Drawing.Point(296, 35);
            this.button_Kalender_Feiertag.Margin = new System.Windows.Forms.Padding(2);
            this.button_Kalender_Feiertag.Name = "button_Kalender_Feiertag";
            this.button_Kalender_Feiertag.Size = new System.Drawing.Size(90, 31);
            this.button_Kalender_Feiertag.TabIndex = 4;
            this.button_Kalender_Feiertag.Text = "Feiertag";
            this.button_Kalender_Feiertag.UseVisualStyleBackColor = true;
            this.button_Kalender_Feiertag.Click += new System.EventHandler(this.button_Kalender_Feiertag_Click);
            // 
            // button_Kalender_erstelleEintrag
            // 
            this.button_Kalender_erstelleEintrag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kalender_erstelleEintrag.ImageIndex = 0;
            this.button_Kalender_erstelleEintrag.ImageList = this.myiconlist;
            this.button_Kalender_erstelleEintrag.Location = new System.Drawing.Point(20, 213);
            this.button_Kalender_erstelleEintrag.Margin = new System.Windows.Forms.Padding(2);
            this.button_Kalender_erstelleEintrag.Name = "button_Kalender_erstelleEintrag";
            this.button_Kalender_erstelleEintrag.Size = new System.Drawing.Size(353, 34);
            this.button_Kalender_erstelleEintrag.TabIndex = 5;
            this.button_Kalender_erstelleEintrag.Text = "Kalendereintrag erstellen";
            this.button_Kalender_erstelleEintrag.UseVisualStyleBackColor = true;
            this.button_Kalender_erstelleEintrag.Click += new System.EventHandler(this.button_Kalender_erstelleEintrag_Click);
            // 
            // myiconlist
            // 
            this.myiconlist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myiconlist.ImageStream")));
            this.myiconlist.TransparentColor = System.Drawing.Color.Transparent;
            this.myiconlist.Images.SetKeyName(0, "add-icone-3727-96.png");
            this.myiconlist.Images.SetKeyName(1, "remove-icone-8680-96.png");
            this.myiconlist.Images.SetKeyName(2, "disk-backup-icone-6806-96.png");
            this.myiconlist.Images.SetKeyName(3, "favorite-star-icone-5544-96.png");
            this.myiconlist.Images.SetKeyName(4, "undo");
            // 
            // button_Kalender_Krankheitstag
            // 
            this.button_Kalender_Krankheitstag.Location = new System.Drawing.Point(202, 35);
            this.button_Kalender_Krankheitstag.Margin = new System.Windows.Forms.Padding(2);
            this.button_Kalender_Krankheitstag.Name = "button_Kalender_Krankheitstag";
            this.button_Kalender_Krankheitstag.Size = new System.Drawing.Size(90, 31);
            this.button_Kalender_Krankheitstag.TabIndex = 2;
            this.button_Kalender_Krankheitstag.Text = "1 Tag Krank";
            this.button_Kalender_Krankheitstag.UseVisualStyleBackColor = true;
            this.button_Kalender_Krankheitstag.Click += new System.EventHandler(this.button_Kalender_Krankheitstag_Click);
            // 
            // textBox_Kalender_Sollzeit
            // 
            this.textBox_Kalender_Sollzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Kalender_Sollzeit.Location = new System.Drawing.Point(20, 139);
            this.textBox_Kalender_Sollzeit.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Kalender_Sollzeit.Name = "textBox_Kalender_Sollzeit";
            this.textBox_Kalender_Sollzeit.Size = new System.Drawing.Size(37, 26);
            this.textBox_Kalender_Sollzeit.TabIndex = 2;
            this.textBox_Kalender_Sollzeit.Text = "7,2";
            this.textBox_Kalender_Sollzeit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_Kalender_halberTagUrlaub
            // 
            this.button_Kalender_halberTagUrlaub.Location = new System.Drawing.Point(108, 35);
            this.button_Kalender_halberTagUrlaub.Margin = new System.Windows.Forms.Padding(2);
            this.button_Kalender_halberTagUrlaub.Name = "button_Kalender_halberTagUrlaub";
            this.button_Kalender_halberTagUrlaub.Size = new System.Drawing.Size(90, 31);
            this.button_Kalender_halberTagUrlaub.TabIndex = 3;
            this.button_Kalender_halberTagUrlaub.Text = "1/2 Tag Urlaub";
            this.button_Kalender_halberTagUrlaub.UseVisualStyleBackColor = true;
            this.button_Kalender_halberTagUrlaub.Click += new System.EventHandler(this.button_Kalender_halberTagUrlaub_Click);
            // 
            // textBox_Kalender_Urlaub
            // 
            this.textBox_Kalender_Urlaub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Kalender_Urlaub.Location = new System.Drawing.Point(123, 139);
            this.textBox_Kalender_Urlaub.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Kalender_Urlaub.Name = "textBox_Kalender_Urlaub";
            this.textBox_Kalender_Urlaub.Size = new System.Drawing.Size(37, 26);
            this.textBox_Kalender_Urlaub.TabIndex = 3;
            this.textBox_Kalender_Urlaub.Text = "0";
            // 
            // textBox_Kalender_Bemerkung
            // 
            this.textBox_Kalender_Bemerkung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Kalender_Bemerkung.Location = new System.Drawing.Point(228, 139);
            this.textBox_Kalender_Bemerkung.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Kalender_Bemerkung.MaxLength = 30;
            this.textBox_Kalender_Bemerkung.Name = "textBox_Kalender_Bemerkung";
            this.textBox_Kalender_Bemerkung.Size = new System.Drawing.Size(143, 26);
            this.textBox_Kalender_Bemerkung.TabIndex = 4;
            this.textBox_Kalender_Bemerkung.Text = "Halber Tag Urlaub";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stunden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Urlaub abziehen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "neue Sollzeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tag(e)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bemerkung";
            // 
            // groupBox_Kalender_AlleEreignisse
            // 
            this.groupBox_Kalender_AlleEreignisse.Controls.Add(this.button_Kalender_storniereEintrag);
            this.groupBox_Kalender_AlleEreignisse.Controls.Add(this.Ereignisgrid_Kalender);
            this.groupBox_Kalender_AlleEreignisse.Location = new System.Drawing.Point(435, 16);
            this.groupBox_Kalender_AlleEreignisse.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Kalender_AlleEreignisse.Name = "groupBox_Kalender_AlleEreignisse";
            this.groupBox_Kalender_AlleEreignisse.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Kalender_AlleEreignisse.Size = new System.Drawing.Size(370, 529);
            this.groupBox_Kalender_AlleEreignisse.TabIndex = 5;
            this.groupBox_Kalender_AlleEreignisse.TabStop = false;
            this.groupBox_Kalender_AlleEreignisse.Text = "Alle Einträge für diese Auswahl (Mitarbeiter + Jahr)";
            // 
            // button_Kalender_storniereEintrag
            // 
            this.button_Kalender_storniereEintrag.Enabled = false;
            this.button_Kalender_storniereEintrag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kalender_storniereEintrag.ImageIndex = 1;
            this.button_Kalender_storniereEintrag.ImageList = this.myiconlist;
            this.button_Kalender_storniereEintrag.Location = new System.Drawing.Point(21, 485);
            this.button_Kalender_storniereEintrag.Margin = new System.Windows.Forms.Padding(2);
            this.button_Kalender_storniereEintrag.Name = "button_Kalender_storniereEintrag";
            this.button_Kalender_storniereEintrag.Size = new System.Drawing.Size(330, 34);
            this.button_Kalender_storniereEintrag.TabIndex = 2;
            this.button_Kalender_storniereEintrag.Text = "Markierten Kalendereintrag stornieren";
            this.button_Kalender_storniereEintrag.UseVisualStyleBackColor = true;
            this.button_Kalender_storniereEintrag.Click += new System.EventHandler(this.button_Kalender_storniereEintrag_Click);
            // 
            // Ereignisgrid_Kalender
            // 
            this.Ereignisgrid_Kalender.AllowUserToAddRows = false;
            this.Ereignisgrid_Kalender.AllowUserToDeleteRows = false;
            this.Ereignisgrid_Kalender.AllowUserToResizeColumns = false;
            this.Ereignisgrid_Kalender.AllowUserToResizeRows = false;
            this.Ereignisgrid_Kalender.BackgroundColor = System.Drawing.Color.White;
            this.Ereignisgrid_Kalender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ereignisgrid_Kalender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Datum,
            this.Sollzeit,
            this.Urlaub,
            this.Vermerk});
            this.Ereignisgrid_Kalender.Location = new System.Drawing.Point(21, 27);
            this.Ereignisgrid_Kalender.Margin = new System.Windows.Forms.Padding(2);
            this.Ereignisgrid_Kalender.MultiSelect = false;
            this.Ereignisgrid_Kalender.Name = "Ereignisgrid_Kalender";
            this.Ereignisgrid_Kalender.ReadOnly = true;
            this.Ereignisgrid_Kalender.RowHeadersVisible = false;
            this.Ereignisgrid_Kalender.RowTemplate.Height = 24;
            this.Ereignisgrid_Kalender.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ereignisgrid_Kalender.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Ereignisgrid_Kalender.Size = new System.Drawing.Size(330, 445);
            this.Ereignisgrid_Kalender.TabIndex = 1;
            this.Ereignisgrid_Kalender.TabStop = false;
            this.Ereignisgrid_Kalender.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ereignisgrid_Kalender_CellClick);
            this.Ereignisgrid_Kalender.SelectionChanged += new System.EventHandler(this.Ereignisgrid_Kalender_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 40;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Dat.";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Datum.Width = 40;
            // 
            // Sollzeit
            // 
            this.Sollzeit.HeaderText = "Soll";
            this.Sollzeit.Name = "Sollzeit";
            this.Sollzeit.ReadOnly = true;
            this.Sollzeit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sollzeit.Width = 40;
            // 
            // Urlaub
            // 
            this.Urlaub.HeaderText = "Urlb";
            this.Urlaub.Name = "Urlaub";
            this.Urlaub.ReadOnly = true;
            this.Urlaub.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Urlaub.Width = 30;
            // 
            // Vermerk
            // 
            this.Vermerk.HeaderText = "Vermerk";
            this.Vermerk.Name = "Vermerk";
            this.Vermerk.ReadOnly = true;
            this.Vermerk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Vermerk.Width = 250;
            // 
            // Verrechnung
            // 
            this.Verrechnung.Controls.Add(this.groupBox_Verrechnungen_Update);
            this.Verrechnung.Controls.Add(this.groupBox_Verrechnungen_Insert);
            this.Verrechnung.Controls.Add(this.Auftragspicker_Verrechnung_Insert);
            this.Verrechnung.Controls.Add(this.label43);
            this.Verrechnung.Controls.Add(this.label21);
            this.Verrechnung.Controls.Add(this.textBox_Verrechnung_Auftragsnummer);
            this.Verrechnung.Controls.Add(this.label36);
            this.Verrechnung.Location = new System.Drawing.Point(4, 22);
            this.Verrechnung.Name = "Verrechnung";
            this.Verrechnung.Size = new System.Drawing.Size(822, 559);
            this.Verrechnung.TabIndex = 4;
            this.Verrechnung.Text = "Verrechnung";
            this.Verrechnung.UseVisualStyleBackColor = true;
            // 
            // groupBox_Verrechnungen_Update
            // 
            this.groupBox_Verrechnungen_Update.Controls.Add(this.DatePicker_Verrechnung_Update);
            this.groupBox_Verrechnungen_Update.Controls.Add(this.button_Verrechnungen_SatzStornieren);
            this.groupBox_Verrechnungen_Update.Controls.Add(this.button_Verrechnungen_SatzUeberschreiben);
            this.groupBox_Verrechnungen_Update.Controls.Add(this.Verrechnungsgrid_Verrechnungen_Update);
            this.groupBox_Verrechnungen_Update.Controls.Add(this.textBox_Verrechnung_StundenGesamt);
            this.groupBox_Verrechnungen_Update.Controls.Add(this.label44);
            this.groupBox_Verrechnungen_Update.Controls.Add(this.textBox_Verrechnungen_Stunden_edit);
            this.groupBox_Verrechnungen_Update.Controls.Add(this.label41);
            this.groupBox_Verrechnungen_Update.Controls.Add(this.label42);
            this.groupBox_Verrechnungen_Update.Location = new System.Drawing.Point(409, 36);
            this.groupBox_Verrechnungen_Update.Name = "groupBox_Verrechnungen_Update";
            this.groupBox_Verrechnungen_Update.Size = new System.Drawing.Size(383, 505);
            this.groupBox_Verrechnungen_Update.TabIndex = 0;
            this.groupBox_Verrechnungen_Update.TabStop = false;
            this.groupBox_Verrechnungen_Update.Text = "Verrechnete Zeiten";
            // 
            // DatePicker_Verrechnung_Update
            // 
            this.DatePicker_Verrechnung_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker_Verrechnung_Update.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker_Verrechnung_Update.Location = new System.Drawing.Point(247, 362);
            this.DatePicker_Verrechnung_Update.Name = "DatePicker_Verrechnung_Update";
            this.DatePicker_Verrechnung_Update.Size = new System.Drawing.Size(100, 26);
            this.DatePicker_Verrechnung_Update.TabIndex = 6;
            // 
            // button_Verrechnungen_SatzStornieren
            // 
            this.button_Verrechnungen_SatzStornieren.Enabled = false;
            this.button_Verrechnungen_SatzStornieren.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Verrechnungen_SatzStornieren.ImageIndex = 1;
            this.button_Verrechnungen_SatzStornieren.ImageList = this.myiconlist;
            this.button_Verrechnungen_SatzStornieren.Location = new System.Drawing.Point(35, 292);
            this.button_Verrechnungen_SatzStornieren.Name = "button_Verrechnungen_SatzStornieren";
            this.button_Verrechnungen_SatzStornieren.Size = new System.Drawing.Size(313, 35);
            this.button_Verrechnungen_SatzStornieren.TabIndex = 5;
            this.button_Verrechnungen_SatzStornieren.Text = "Markierten Verrechnungssatz stornieren";
            this.button_Verrechnungen_SatzStornieren.UseVisualStyleBackColor = true;
            this.button_Verrechnungen_SatzStornieren.Click += new System.EventHandler(this.button_Verrechnungen_SatzStornieren_Click);
            // 
            // button_Verrechnungen_SatzUeberschreiben
            // 
            this.button_Verrechnungen_SatzUeberschreiben.Enabled = false;
            this.button_Verrechnungen_SatzUeberschreiben.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Verrechnungen_SatzUeberschreiben.ImageIndex = 2;
            this.button_Verrechnungen_SatzUeberschreiben.ImageList = this.myiconlist;
            this.button_Verrechnungen_SatzUeberschreiben.Location = new System.Drawing.Point(35, 449);
            this.button_Verrechnungen_SatzUeberschreiben.Name = "button_Verrechnungen_SatzUeberschreiben";
            this.button_Verrechnungen_SatzUeberschreiben.Size = new System.Drawing.Size(312, 35);
            this.button_Verrechnungen_SatzUeberschreiben.TabIndex = 5;
            this.button_Verrechnungen_SatzUeberschreiben.Text = "Markierten Verrechnungssatz überschreiben";
            this.button_Verrechnungen_SatzUeberschreiben.UseVisualStyleBackColor = true;
            this.button_Verrechnungen_SatzUeberschreiben.Click += new System.EventHandler(this.button_Verrechnungen_SatzUeberschreiben_Click);
            // 
            // Verrechnungsgrid_Verrechnungen_Update
            // 
            this.Verrechnungsgrid_Verrechnungen_Update.AllowUserToAddRows = false;
            this.Verrechnungsgrid_Verrechnungen_Update.AllowUserToDeleteRows = false;
            this.Verrechnungsgrid_Verrechnungen_Update.AllowUserToResizeColumns = false;
            this.Verrechnungsgrid_Verrechnungen_Update.AllowUserToResizeRows = false;
            this.Verrechnungsgrid_Verrechnungen_Update.BackgroundColor = System.Drawing.Color.White;
            this.Verrechnungsgrid_Verrechnungen_Update.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Verrechnungsgrid_Verrechnungen_Update.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satzid,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Verrechnungsdatum,
            this.Verrechnet});
            this.Verrechnungsgrid_Verrechnungen_Update.Location = new System.Drawing.Point(35, 76);
            this.Verrechnungsgrid_Verrechnungen_Update.MultiSelect = false;
            this.Verrechnungsgrid_Verrechnungen_Update.Name = "Verrechnungsgrid_Verrechnungen_Update";
            this.Verrechnungsgrid_Verrechnungen_Update.ReadOnly = true;
            this.Verrechnungsgrid_Verrechnungen_Update.RowHeadersVisible = false;
            this.Verrechnungsgrid_Verrechnungen_Update.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Verrechnungsgrid_Verrechnungen_Update.Size = new System.Drawing.Size(313, 196);
            this.Verrechnungsgrid_Verrechnungen_Update.TabIndex = 4;
            this.Verrechnungsgrid_Verrechnungen_Update.SelectionChanged += new System.EventHandler(this.Verrechnungsgrid_Verrechnungen_Update_SelectionChanged);
            // 
            // satzid
            // 
            this.satzid.HeaderText = "ID";
            this.satzid.Name = "satzid";
            this.satzid.ReadOnly = true;
            this.satzid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.satzid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.satzid.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mitarb.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // Verrechnungsdatum
            // 
            this.Verrechnungsdatum.HeaderText = "Verr.-Datum";
            this.Verrechnungsdatum.Name = "Verrechnungsdatum";
            this.Verrechnungsdatum.ReadOnly = true;
            this.Verrechnungsdatum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Verrechnungsdatum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Verrechnungsdatum.Width = 70;
            // 
            // Verrechnet
            // 
            this.Verrechnet.HeaderText = "Verrechnet";
            this.Verrechnet.Name = "Verrechnet";
            this.Verrechnet.ReadOnly = true;
            this.Verrechnet.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Verrechnet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Verrechnet.Width = 70;
            // 
            // textBox_Verrechnung_StundenGesamt
            // 
            this.textBox_Verrechnung_StundenGesamt.Enabled = false;
            this.textBox_Verrechnung_StundenGesamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Verrechnung_StundenGesamt.Location = new System.Drawing.Point(270, 28);
            this.textBox_Verrechnung_StundenGesamt.Name = "textBox_Verrechnung_StundenGesamt";
            this.textBox_Verrechnung_StundenGesamt.Size = new System.Drawing.Size(77, 26);
            this.textBox_Verrechnung_StundenGesamt.TabIndex = 2;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(32, 36);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(232, 15);
            this.label44.TabIndex = 3;
            this.label44.Text = "Insgesamt verrechnet auf diesem Auftrag:";
            this.label44.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_Verrechnungen_Stunden_edit
            // 
            this.textBox_Verrechnungen_Stunden_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Verrechnungen_Stunden_edit.Location = new System.Drawing.Point(247, 404);
            this.textBox_Verrechnungen_Stunden_edit.Name = "textBox_Verrechnungen_Stunden_edit";
            this.textBox_Verrechnungen_Stunden_edit.Size = new System.Drawing.Size(100, 26);
            this.textBox_Verrechnungen_Stunden_edit.TabIndex = 2;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(32, 412);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(123, 13);
            this.label41.TabIndex = 3;
            this.label41.Text = "Verrechenbare Stunden:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(32, 373);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(105, 13);
            this.label42.TabIndex = 3;
            this.label42.Text = "Verrechnungsdatum:";
            // 
            // groupBox_Verrechnungen_Insert
            // 
            this.groupBox_Verrechnungen_Insert.Controls.Add(this.DatePicker_Verrechnung_Insert);
            this.groupBox_Verrechnungen_Insert.Controls.Add(this.button_Verrechnungen_SatzErstellen);
            this.groupBox_Verrechnungen_Insert.Controls.Add(this.Verrechnungsgrid_Verrechnungen_Insert);
            this.groupBox_Verrechnungen_Insert.Controls.Add(this.textBox_Verrechnungen_Stunden_Insert);
            this.groupBox_Verrechnungen_Insert.Controls.Add(this.textBox_Verrechnungen_Mitarbeiter_Insert);
            this.groupBox_Verrechnungen_Insert.Controls.Add(this.label39);
            this.groupBox_Verrechnungen_Insert.Controls.Add(this.label40);
            this.groupBox_Verrechnungen_Insert.Controls.Add(this.label38);
            this.groupBox_Verrechnungen_Insert.Location = new System.Drawing.Point(24, 81);
            this.groupBox_Verrechnungen_Insert.Name = "groupBox_Verrechnungen_Insert";
            this.groupBox_Verrechnungen_Insert.Size = new System.Drawing.Size(340, 460);
            this.groupBox_Verrechnungen_Insert.TabIndex = 0;
            this.groupBox_Verrechnungen_Insert.TabStop = false;
            this.groupBox_Verrechnungen_Insert.Text = "Unverrechnete Zeiten";
            // 
            // DatePicker_Verrechnung_Insert
            // 
            this.DatePicker_Verrechnung_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker_Verrechnung_Insert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker_Verrechnung_Insert.Location = new System.Drawing.Point(203, 317);
            this.DatePicker_Verrechnung_Insert.Name = "DatePicker_Verrechnung_Insert";
            this.DatePicker_Verrechnung_Insert.Size = new System.Drawing.Size(100, 26);
            this.DatePicker_Verrechnung_Insert.TabIndex = 6;
            // 
            // button_Verrechnungen_SatzErstellen
            // 
            this.button_Verrechnungen_SatzErstellen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Verrechnungen_SatzErstellen.ImageIndex = 0;
            this.button_Verrechnungen_SatzErstellen.ImageList = this.myiconlist;
            this.button_Verrechnungen_SatzErstellen.Location = new System.Drawing.Point(30, 404);
            this.button_Verrechnungen_SatzErstellen.Name = "button_Verrechnungen_SatzErstellen";
            this.button_Verrechnungen_SatzErstellen.Size = new System.Drawing.Size(273, 35);
            this.button_Verrechnungen_SatzErstellen.TabIndex = 5;
            this.button_Verrechnungen_SatzErstellen.Text = "Satz mit diesen Werten erstellen";
            this.button_Verrechnungen_SatzErstellen.UseVisualStyleBackColor = true;
            this.button_Verrechnungen_SatzErstellen.Click += new System.EventHandler(this.button_Verrechnungen_SatzErstellen_Click);
            // 
            // Verrechnungsgrid_Verrechnungen_Insert
            // 
            this.Verrechnungsgrid_Verrechnungen_Insert.AllowUserToAddRows = false;
            this.Verrechnungsgrid_Verrechnungen_Insert.AllowUserToDeleteRows = false;
            this.Verrechnungsgrid_Verrechnungen_Insert.AllowUserToResizeColumns = false;
            this.Verrechnungsgrid_Verrechnungen_Insert.AllowUserToResizeRows = false;
            this.Verrechnungsgrid_Verrechnungen_Insert.BackgroundColor = System.Drawing.Color.White;
            this.Verrechnungsgrid_Verrechnungen_Insert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Verrechnungsgrid_Verrechnungen_Insert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mitarbeiter,
            this.PersName,
            this.Dat_letzte_Stempelung,
            this.gesamtzeit});
            this.Verrechnungsgrid_Verrechnungen_Insert.Location = new System.Drawing.Point(30, 34);
            this.Verrechnungsgrid_Verrechnungen_Insert.MultiSelect = false;
            this.Verrechnungsgrid_Verrechnungen_Insert.Name = "Verrechnungsgrid_Verrechnungen_Insert";
            this.Verrechnungsgrid_Verrechnungen_Insert.ReadOnly = true;
            this.Verrechnungsgrid_Verrechnungen_Insert.RowHeadersVisible = false;
            this.Verrechnungsgrid_Verrechnungen_Insert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Verrechnungsgrid_Verrechnungen_Insert.Size = new System.Drawing.Size(273, 193);
            this.Verrechnungsgrid_Verrechnungen_Insert.TabIndex = 4;
            this.Verrechnungsgrid_Verrechnungen_Insert.SelectionChanged += new System.EventHandler(this.Verrechnungsgrid_Verrechnungen_Insert_SelectionChanged);
            // 
            // Mitarbeiter
            // 
            this.Mitarbeiter.HeaderText = "Mitarb.";
            this.Mitarbeiter.Name = "Mitarbeiter";
            this.Mitarbeiter.ReadOnly = true;
            this.Mitarbeiter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mitarbeiter.Width = 50;
            // 
            // PersName
            // 
            this.PersName.HeaderText = "Name";
            this.PersName.Name = "PersName";
            this.PersName.ReadOnly = true;
            this.PersName.Width = 80;
            // 
            // Dat_letzte_Stempelung
            // 
            this.Dat_letzte_Stempelung.HeaderText = "letzt. Dat.";
            this.Dat_letzte_Stempelung.Name = "Dat_letzte_Stempelung";
            this.Dat_letzte_Stempelung.ReadOnly = true;
            this.Dat_letzte_Stempelung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Dat_letzte_Stempelung.Width = 70;
            // 
            // gesamtzeit
            // 
            this.gesamtzeit.HeaderText = "Stunden";
            this.gesamtzeit.Name = "gesamtzeit";
            this.gesamtzeit.ReadOnly = true;
            this.gesamtzeit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gesamtzeit.Width = 70;
            // 
            // textBox_Verrechnungen_Stunden_Insert
            // 
            this.textBox_Verrechnungen_Stunden_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Verrechnungen_Stunden_Insert.Location = new System.Drawing.Point(203, 359);
            this.textBox_Verrechnungen_Stunden_Insert.Name = "textBox_Verrechnungen_Stunden_Insert";
            this.textBox_Verrechnungen_Stunden_Insert.Size = new System.Drawing.Size(100, 26);
            this.textBox_Verrechnungen_Stunden_Insert.TabIndex = 2;
            // 
            // textBox_Verrechnungen_Mitarbeiter_Insert
            // 
            this.textBox_Verrechnungen_Mitarbeiter_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Verrechnungen_Mitarbeiter_Insert.Location = new System.Drawing.Point(203, 266);
            this.textBox_Verrechnungen_Mitarbeiter_Insert.Name = "textBox_Verrechnungen_Mitarbeiter_Insert";
            this.textBox_Verrechnungen_Mitarbeiter_Insert.Size = new System.Drawing.Size(100, 26);
            this.textBox_Verrechnungen_Mitarbeiter_Insert.TabIndex = 2;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(27, 367);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(120, 13);
            this.label39.TabIndex = 3;
            this.label39.Text = "Verrechenbare Stunden";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(27, 323);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(102, 13);
            this.label40.TabIndex = 3;
            this.label40.Text = "Verrechnungsdatum";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(27, 274);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(93, 13);
            this.label38.TabIndex = 3;
            this.label38.Text = "Mitarbeiternummer";
            // 
            // Auftragspicker_Verrechnung_Insert
            // 
            this.Auftragspicker_Verrechnung_Insert.BackColor = System.Drawing.SystemColors.Window;
            this.Auftragspicker_Verrechnung_Insert.DropDownHeight = 200;
            this.Auftragspicker_Verrechnung_Insert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Auftragspicker_Verrechnung_Insert.DropDownWidth = 200;
            this.Auftragspicker_Verrechnung_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auftragspicker_Verrechnung_Insert.FormattingEnabled = true;
            this.Auftragspicker_Verrechnung_Insert.IntegralHeight = false;
            this.Auftragspicker_Verrechnung_Insert.Location = new System.Drawing.Point(264, 31);
            this.Auftragspicker_Verrechnung_Insert.Name = "Auftragspicker_Verrechnung_Insert";
            this.Auftragspicker_Verrechnung_Insert.Size = new System.Drawing.Size(100, 28);
            this.Auftragspicker_Verrechnung_Insert.TabIndex = 1;
            this.Auftragspicker_Verrechnung_Insert.SelectedIndexChanged += new System.EventHandler(this.Auftragspicker_Verrechnung_Insert_SelectedIndexChanged);
            this.Auftragspicker_Verrechnung_Insert.Click += new System.EventHandler(this.Auftragspicker_Verrechnung_Insert_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(241, 37);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(19, 13);
            this.label43.TabIndex = 3;
            this.label43.Text = "<<";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(261, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "aus offenen wählen:";
            // 
            // textBox_Verrechnung_Auftragsnummer
            // 
            this.textBox_Verrechnung_Auftragsnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Verrechnung_Auftragsnummer.Location = new System.Drawing.Point(24, 30);
            this.textBox_Verrechnung_Auftragsnummer.MaxLength = 6;
            this.textBox_Verrechnung_Auftragsnummer.Name = "textBox_Verrechnung_Auftragsnummer";
            this.textBox_Verrechnung_Auftragsnummer.Size = new System.Drawing.Size(180, 29);
            this.textBox_Verrechnung_Auftragsnummer.TabIndex = 2;
            this.textBox_Verrechnung_Auftragsnummer.TextChanged += new System.EventHandler(this.textBox_Verrechnung_Auftragsnummer_TextChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(21, 12);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(86, 13);
            this.label36.TabIndex = 3;
            this.label36.Text = "Auftragsnummer:";
            // 
            // Bonusberechnung
            // 
            this.Bonusberechnung.Controls.Add(this.button_Bonus_ShowGroupbox_Neu);
            this.Bonusberechnung.Controls.Add(this.groupBox_Bonus_neu);
            this.Bonusberechnung.Controls.Add(this.groupBoxLetzteBonusberechnung);
            this.Bonusberechnung.Controls.Add(this.PersonPicker_Bonus);
            this.Bonusberechnung.Location = new System.Drawing.Point(4, 22);
            this.Bonusberechnung.Name = "Bonusberechnung";
            this.Bonusberechnung.Padding = new System.Windows.Forms.Padding(3);
            this.Bonusberechnung.Size = new System.Drawing.Size(822, 559);
            this.Bonusberechnung.TabIndex = 5;
            this.Bonusberechnung.Text = "Bonusberechnung";
            this.Bonusberechnung.UseVisualStyleBackColor = true;
            // 
            // groupBox_Bonus_neu
            // 
            this.groupBox_Bonus_neu.Controls.Add(this.label_Bonus_Hinweis);
            this.groupBox_Bonus_neu.Controls.Add(this.label_Bonus_Neu_ErstmoeglicherTag);
            this.groupBox_Bonus_neu.Controls.Add(this.label_Bonus_Neu_LetzterVollverrechneterTag);
            this.groupBox_Bonus_neu.Controls.Add(this.button_Bonus_BerechnenBis);
            this.groupBox_Bonus_neu.Controls.Add(this.DatePicker_Bonus_Neu_BerechnenBis);
            this.groupBox_Bonus_neu.Controls.Add(this.label53);
            this.groupBox_Bonus_neu.Controls.Add(this.label58);
            this.groupBox_Bonus_neu.Controls.Add(this.label57);
            this.groupBox_Bonus_neu.Location = new System.Drawing.Point(187, 311);
            this.groupBox_Bonus_neu.Name = "groupBox_Bonus_neu";
            this.groupBox_Bonus_neu.Size = new System.Drawing.Size(425, 224);
            this.groupBox_Bonus_neu.TabIndex = 16;
            this.groupBox_Bonus_neu.TabStop = false;
            this.groupBox_Bonus_neu.Text = "Neue Bonusberechnung";
            this.groupBox_Bonus_neu.Visible = false;
            // 
            // label_Bonus_Neu_ErstmoeglicherTag
            // 
            this.label_Bonus_Neu_ErstmoeglicherTag.AutoSize = true;
            this.label_Bonus_Neu_ErstmoeglicherTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bonus_Neu_ErstmoeglicherTag.Location = new System.Drawing.Point(101, 152);
            this.label_Bonus_Neu_ErstmoeglicherTag.Name = "label_Bonus_Neu_ErstmoeglicherTag";
            this.label_Bonus_Neu_ErstmoeglicherTag.Size = new System.Drawing.Size(100, 24);
            this.label_Bonus_Neu_ErstmoeglicherTag.TabIndex = 17;
            this.label_Bonus_Neu_ErstmoeglicherTag.Text = "00.00.0000";
            // 
            // label_Bonus_Neu_LetzterVollverrechneterTag
            // 
            this.label_Bonus_Neu_LetzterVollverrechneterTag.AutoSize = true;
            this.label_Bonus_Neu_LetzterVollverrechneterTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bonus_Neu_LetzterVollverrechneterTag.Location = new System.Drawing.Point(296, 44);
            this.label_Bonus_Neu_LetzterVollverrechneterTag.Name = "label_Bonus_Neu_LetzterVollverrechneterTag";
            this.label_Bonus_Neu_LetzterVollverrechneterTag.Size = new System.Drawing.Size(100, 24);
            this.label_Bonus_Neu_LetzterVollverrechneterTag.TabIndex = 17;
            this.label_Bonus_Neu_LetzterVollverrechneterTag.Text = "00.00.0000";
            // 
            // button_Bonus_BerechnenBis
            // 
            this.button_Bonus_BerechnenBis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Bonus_BerechnenBis.ImageIndex = 3;
            this.button_Bonus_BerechnenBis.ImageList = this.myiconlist;
            this.button_Bonus_BerechnenBis.Location = new System.Drawing.Point(38, 106);
            this.button_Bonus_BerechnenBis.Name = "button_Bonus_BerechnenBis";
            this.button_Bonus_BerechnenBis.Size = new System.Drawing.Size(330, 36);
            this.button_Bonus_BerechnenBis.TabIndex = 14;
            this.button_Bonus_BerechnenBis.Text = "Bonuszeit neu berechnen für den Zeitraum";
            this.button_Bonus_BerechnenBis.UseVisualStyleBackColor = true;
            this.button_Bonus_BerechnenBis.Click += new System.EventHandler(this.button_Bonus_BerechnenBis_Click);
            // 
            // DatePicker_Bonus_Neu_BerechnenBis
            // 
            this.DatePicker_Bonus_Neu_BerechnenBis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker_Bonus_Neu_BerechnenBis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker_Bonus_Neu_BerechnenBis.Location = new System.Drawing.Point(239, 150);
            this.DatePicker_Bonus_Neu_BerechnenBis.Name = "DatePicker_Bonus_Neu_BerechnenBis";
            this.DatePicker_Bonus_Neu_BerechnenBis.Size = new System.Drawing.Size(100, 29);
            this.DatePicker_Bonus_Neu_BerechnenBis.TabIndex = 13;
            this.DatePicker_Bonus_Neu_BerechnenBis.ValueChanged += new System.EventHandler(this.DatePicker_Bonus_Neu_BerechnenBis_ValueChanged);
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(20, 44);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(283, 35);
            this.label53.TabIndex = 7;
            this.label53.Text = "Der aktuell letzte Tag für den dieser Mitarbeiter keine unverrechneten Stempelung" +
    "en mehr hat, ist der";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(202, 160);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(20, 13);
            this.label58.TabIndex = 7;
            this.label58.Text = "bis";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(70, 160);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(27, 13);
            this.label57.TabIndex = 7;
            this.label57.Text = "vom";
            // 
            // groupBoxLetzteBonusberechnung
            // 
            this.groupBoxLetzteBonusberechnung.Controls.Add(this.label_Bonus_Alt_Bonuszeit);
            this.groupBoxLetzteBonusberechnung.Controls.Add(this.label_Bonus_Alt_BerechnetBis);
            this.groupBoxLetzteBonusberechnung.Controls.Add(this.label49);
            this.groupBoxLetzteBonusberechnung.Controls.Add(this.label50);
            this.groupBoxLetzteBonusberechnung.Controls.Add(this.label51);
            this.groupBoxLetzteBonusberechnung.Controls.Add(this.label52);
            this.groupBoxLetzteBonusberechnung.Location = new System.Drawing.Point(187, 79);
            this.groupBoxLetzteBonusberechnung.Name = "groupBoxLetzteBonusberechnung";
            this.groupBoxLetzteBonusberechnung.Size = new System.Drawing.Size(425, 207);
            this.groupBoxLetzteBonusberechnung.TabIndex = 15;
            this.groupBoxLetzteBonusberechnung.TabStop = false;
            this.groupBoxLetzteBonusberechnung.Text = "Letzte Bonusberechnung";
            // 
            // label_Bonus_Alt_Bonuszeit
            // 
            this.label_Bonus_Alt_Bonuszeit.AutoSize = true;
            this.label_Bonus_Alt_Bonuszeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bonus_Alt_Bonuszeit.Location = new System.Drawing.Point(166, 158);
            this.label_Bonus_Alt_Bonuszeit.Name = "label_Bonus_Alt_Bonuszeit";
            this.label_Bonus_Alt_Bonuszeit.Size = new System.Drawing.Size(55, 24);
            this.label_Bonus_Alt_Bonuszeit.TabIndex = 17;
            this.label_Bonus_Alt_Bonuszeit.Text = "00,00";
            // 
            // label_Bonus_Alt_BerechnetBis
            // 
            this.label_Bonus_Alt_BerechnetBis.AutoSize = true;
            this.label_Bonus_Alt_BerechnetBis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bonus_Alt_BerechnetBis.Location = new System.Drawing.Point(141, 61);
            this.label_Bonus_Alt_BerechnetBis.Name = "label_Bonus_Alt_BerechnetBis";
            this.label_Bonus_Alt_BerechnetBis.Size = new System.Drawing.Size(100, 24);
            this.label_Bonus_Alt_BerechnetBis.TabIndex = 17;
            this.label_Bonus_Alt_BerechnetBis.Text = "00.00.0000";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(53, 36);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(301, 13);
            this.label49.TabIndex = 7;
            this.label49.Text = "Bonuszeit für diesen Mitarbeiter wurde zuletzt bis einschließlich";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(247, 69);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(58, 13);
            this.label50.TabIndex = 7;
            this.label50.Text = "berechnet.";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(53, 132);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(273, 13);
            this.label51.TabIndex = 7;
            this.label51.Text = "Bei dieser letzten Berechnung wurde eine Bonuszeit von";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(247, 166);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(89, 13);
            this.label52.TabIndex = 7;
            this.label52.Text = "Stunden ermittelt.";
            // 
            // PersonPicker_Bonus
            // 
            this.PersonPicker_Bonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonPicker_Bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonPicker_Bonus.FormattingEnabled = true;
            this.PersonPicker_Bonus.Items.AddRange(new object[] {
            "Allgemein"});
            this.PersonPicker_Bonus.Location = new System.Drawing.Point(148, 20);
            this.PersonPicker_Bonus.Name = "PersonPicker_Bonus";
            this.PersonPicker_Bonus.Size = new System.Drawing.Size(514, 32);
            this.PersonPicker_Bonus.TabIndex = 6;
            this.PersonPicker_Bonus.SelectedIndexChanged += new System.EventHandler(this.PersonPicker_Bonus_SelectedIndexChanged);
            // 
            // Stempelungen
            // 
            this.Stempelungen.Controls.Add(this.button_Stempelungen_DatePickerTagzurueck);
            this.Stempelungen.Controls.Add(this.button_Stempelungen_DatePickerTagvorwaerts);
            this.Stempelungen.Controls.Add(this.groupBox_Stempelungen_Zeitkonto);
            this.Stempelungen.Controls.Add(this.groupBox_Stempelungen_EditierenErstellen);
            this.Stempelungen.Controls.Add(this.Stempelungsgrid_Stempelungen);
            this.Stempelungen.Controls.Add(this.DatePicker_Stempelungen);
            this.Stempelungen.Controls.Add(this.PersonPicker_Stempelungen);
            this.Stempelungen.Location = new System.Drawing.Point(4, 22);
            this.Stempelungen.Name = "Stempelungen";
            this.Stempelungen.Padding = new System.Windows.Forms.Padding(3);
            this.Stempelungen.Size = new System.Drawing.Size(822, 559);
            this.Stempelungen.TabIndex = 1;
            this.Stempelungen.Text = "Stempelungen";
            this.Stempelungen.UseVisualStyleBackColor = true;
            // 
            // button_Stempelungen_DatePickerTagzurueck
            // 
            this.button_Stempelungen_DatePickerTagzurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Stempelungen_DatePickerTagzurueck.Location = new System.Drawing.Point(26, 60);
            this.button_Stempelungen_DatePickerTagzurueck.Name = "button_Stempelungen_DatePickerTagzurueck";
            this.button_Stempelungen_DatePickerTagzurueck.Size = new System.Drawing.Size(26, 26);
            this.button_Stempelungen_DatePickerTagzurueck.TabIndex = 12;
            this.button_Stempelungen_DatePickerTagzurueck.Text = "<";
            this.button_Stempelungen_DatePickerTagzurueck.UseVisualStyleBackColor = true;
            this.button_Stempelungen_DatePickerTagzurueck.Click += new System.EventHandler(this.button_Stempelungen_Tagzurueck_Click);
            // 
            // button_Stempelungen_DatePickerTagvorwaerts
            // 
            this.button_Stempelungen_DatePickerTagvorwaerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Stempelungen_DatePickerTagvorwaerts.Location = new System.Drawing.Point(325, 60);
            this.button_Stempelungen_DatePickerTagvorwaerts.Name = "button_Stempelungen_DatePickerTagvorwaerts";
            this.button_Stempelungen_DatePickerTagvorwaerts.Size = new System.Drawing.Size(25, 26);
            this.button_Stempelungen_DatePickerTagvorwaerts.TabIndex = 12;
            this.button_Stempelungen_DatePickerTagvorwaerts.Text = ">";
            this.button_Stempelungen_DatePickerTagvorwaerts.UseVisualStyleBackColor = true;
            this.button_Stempelungen_DatePickerTagvorwaerts.Click += new System.EventHandler(this.button_Stempelungen_Tagvorwaerts_Click);
            // 
            // groupBox_Stempelungen_Zeitkonto
            // 
            this.groupBox_Stempelungen_Zeitkonto.Controls.Add(this.label_Stempelungen_Zeitkonto_Berechnungsstand);
            this.groupBox_Stempelungen_Zeitkonto.Controls.Add(this.label_Stempelungen_Hinweis);
            this.groupBox_Stempelungen_Zeitkonto.Controls.Add(this.label32);
            this.groupBox_Stempelungen_Zeitkonto.Controls.Add(this.button_Stempelungen_ZeitkontoRueckrechnen);
            this.groupBox_Stempelungen_Zeitkonto.Location = new System.Drawing.Point(365, 403);
            this.groupBox_Stempelungen_Zeitkonto.Name = "groupBox_Stempelungen_Zeitkonto";
            this.groupBox_Stempelungen_Zeitkonto.Size = new System.Drawing.Size(424, 138);
            this.groupBox_Stempelungen_Zeitkonto.TabIndex = 11;
            this.groupBox_Stempelungen_Zeitkonto.TabStop = false;
            this.groupBox_Stempelungen_Zeitkonto.Text = "Zeitkonto";
            // 
            // label_Stempelungen_Zeitkonto_Berechnungsstand
            // 
            this.label_Stempelungen_Zeitkonto_Berechnungsstand.AutoSize = true;
            this.label_Stempelungen_Zeitkonto_Berechnungsstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Stempelungen_Zeitkonto_Berechnungsstand.Location = new System.Drawing.Point(303, 36);
            this.label_Stempelungen_Zeitkonto_Berechnungsstand.Name = "label_Stempelungen_Zeitkonto_Berechnungsstand";
            this.label_Stempelungen_Zeitkonto_Berechnungsstand.Size = new System.Drawing.Size(72, 17);
            this.label_Stempelungen_Zeitkonto_Berechnungsstand.TabIndex = 9;
            this.label_Stempelungen_Zeitkonto_Berechnungsstand.Text = "00000000";
            // 
            // label_Stempelungen_Hinweis
            // 
            this.label_Stempelungen_Hinweis.AutoSize = true;
            this.label_Stempelungen_Hinweis.BackColor = System.Drawing.Color.Gold;
            this.label_Stempelungen_Hinweis.Location = new System.Drawing.Point(35, 61);
            this.label_Stempelungen_Hinweis.Name = "label_Stempelungen_Hinweis";
            this.label_Stempelungen_Hinweis.Size = new System.Drawing.Size(361, 13);
            this.label_Stempelungen_Hinweis.TabIndex = 9;
            this.label_Stempelungen_Hinweis.Text = "Stempelungen vom 01.01.0001 sind erst nach Rückrechnung veränderbar.";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(35, 38);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(262, 13);
            this.label32.TabIndex = 9;
            this.label32.Text = "Stand der Zeitkontoberechnung für diesen Mitarbeiter:";
            // 
            // button_Stempelungen_ZeitkontoRueckrechnen
            // 
            this.button_Stempelungen_ZeitkontoRueckrechnen.Enabled = false;
            this.button_Stempelungen_ZeitkontoRueckrechnen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Stempelungen_ZeitkontoRueckrechnen.ImageIndex = 4;
            this.button_Stempelungen_ZeitkontoRueckrechnen.ImageList = this.myiconlist;
            this.button_Stempelungen_ZeitkontoRueckrechnen.Location = new System.Drawing.Point(27, 81);
            this.button_Stempelungen_ZeitkontoRueckrechnen.Name = "button_Stempelungen_ZeitkontoRueckrechnen";
            this.button_Stempelungen_ZeitkontoRueckrechnen.Size = new System.Drawing.Size(375, 30);
            this.button_Stempelungen_ZeitkontoRueckrechnen.TabIndex = 8;
            this.button_Stempelungen_ZeitkontoRueckrechnen.Text = "Zeitkonto bis zum Vorabend des gewählten Tages zurückrechnen";
            this.button_Stempelungen_ZeitkontoRueckrechnen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Stempelungen_ZeitkontoRueckrechnen.UseVisualStyleBackColor = true;
            this.button_Stempelungen_ZeitkontoRueckrechnen.Click += new System.EventHandler(this.button_Stempelungen_ZeitkontoRueckrechnen_Click);
            // 
            // groupBox_Stempelungen_EditierenErstellen
            // 
            this.groupBox_Stempelungen_EditierenErstellen.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Stempelungen_EditierenErstellen.Controls.Add(this.TimePicker_Stempelungen);
            this.groupBox_Stempelungen_EditierenErstellen.Controls.Add(this.comboBox_Stempelungen_Art);
            this.groupBox_Stempelungen_EditierenErstellen.Controls.Add(this.textBox_Stempelungen_Auftragsnummer);
            this.groupBox_Stempelungen_EditierenErstellen.Controls.Add(this.label24);
            this.groupBox_Stempelungen_EditierenErstellen.Controls.Add(this.label23);
            this.groupBox_Stempelungen_EditierenErstellen.Controls.Add(this.label22);
            this.groupBox_Stempelungen_EditierenErstellen.Controls.Add(this.button_Stempelungen_neueStempelung);
            this.groupBox_Stempelungen_EditierenErstellen.Controls.Add(this.button_Stempelungen_stornieren);
            this.groupBox_Stempelungen_EditierenErstellen.Controls.Add(this.button_Stempelungen_ueberschreiben);
            this.groupBox_Stempelungen_EditierenErstellen.Enabled = false;
            this.groupBox_Stempelungen_EditierenErstellen.Location = new System.Drawing.Point(365, 71);
            this.groupBox_Stempelungen_EditierenErstellen.Name = "groupBox_Stempelungen_EditierenErstellen";
            this.groupBox_Stempelungen_EditierenErstellen.Size = new System.Drawing.Size(424, 310);
            this.groupBox_Stempelungen_EditierenErstellen.TabIndex = 10;
            this.groupBox_Stempelungen_EditierenErstellen.TabStop = false;
            this.groupBox_Stempelungen_EditierenErstellen.Text = "Editieren / Erstellen";
            // 
            // TimePicker_Stempelungen
            // 
            this.TimePicker_Stempelungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker_Stempelungen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker_Stempelungen.Location = new System.Drawing.Point(225, 153);
            this.TimePicker_Stempelungen.Name = "TimePicker_Stempelungen";
            this.TimePicker_Stempelungen.ShowUpDown = true;
            this.TimePicker_Stempelungen.Size = new System.Drawing.Size(107, 26);
            this.TimePicker_Stempelungen.TabIndex = 13;
            // 
            // comboBox_Stempelungen_Art
            // 
            this.comboBox_Stempelungen_Art.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Stempelungen_Art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Stempelungen_Art.FormattingEnabled = true;
            this.comboBox_Stempelungen_Art.Items.AddRange(new object[] {
            "an",
            "ab"});
            this.comboBox_Stempelungen_Art.Location = new System.Drawing.Point(225, 82);
            this.comboBox_Stempelungen_Art.MaxLength = 2;
            this.comboBox_Stempelungen_Art.Name = "comboBox_Stempelungen_Art";
            this.comboBox_Stempelungen_Art.Size = new System.Drawing.Size(107, 28);
            this.comboBox_Stempelungen_Art.TabIndex = 12;
            // 
            // textBox_Stempelungen_Auftragsnummer
            // 
            this.textBox_Stempelungen_Auftragsnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Stempelungen_Auftragsnummer.Location = new System.Drawing.Point(225, 119);
            this.textBox_Stempelungen_Auftragsnummer.MaxLength = 6;
            this.textBox_Stempelungen_Auftragsnummer.Name = "textBox_Stempelungen_Auftragsnummer";
            this.textBox_Stempelungen_Auftragsnummer.Size = new System.Drawing.Size(107, 26);
            this.textBox_Stempelungen_Auftragsnummer.TabIndex = 11;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(101, 163);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "Zeitstempel:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(101, 127);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Auftrags-Nummer:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(101, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Art der Stempelung:";
            // 
            // button_Stempelungen_neueStempelung
            // 
            this.button_Stempelungen_neueStempelung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Stempelungen_neueStempelung.ImageIndex = 0;
            this.button_Stempelungen_neueStempelung.ImageList = this.myiconlist;
            this.button_Stempelungen_neueStempelung.Location = new System.Drawing.Point(139, 261);
            this.button_Stempelungen_neueStempelung.Name = "button_Stempelungen_neueStempelung";
            this.button_Stempelungen_neueStempelung.Size = new System.Drawing.Size(263, 34);
            this.button_Stempelungen_neueStempelung.TabIndex = 9;
            this.button_Stempelungen_neueStempelung.Text = "Neue Stempelung mit diesen Werten erstellen";
            this.button_Stempelungen_neueStempelung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Stempelungen_neueStempelung.UseVisualStyleBackColor = true;
            this.button_Stempelungen_neueStempelung.Click += new System.EventHandler(this.button_Stempelungen_neueStempelung_Click);
            // 
            // button_Stempelungen_stornieren
            // 
            this.button_Stempelungen_stornieren.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Stempelungen_stornieren.ImageIndex = 1;
            this.button_Stempelungen_stornieren.ImageList = this.myiconlist;
            this.button_Stempelungen_stornieren.Location = new System.Drawing.Point(27, 24);
            this.button_Stempelungen_stornieren.Name = "button_Stempelungen_stornieren";
            this.button_Stempelungen_stornieren.Size = new System.Drawing.Size(375, 35);
            this.button_Stempelungen_stornieren.TabIndex = 9;
            this.button_Stempelungen_stornieren.Text = "Markierte Stempelung stornieren";
            this.button_Stempelungen_stornieren.UseVisualStyleBackColor = true;
            this.button_Stempelungen_stornieren.Click += new System.EventHandler(this.button_Stempelungen_stornieren_Click);
            // 
            // button_Stempelungen_ueberschreiben
            // 
            this.button_Stempelungen_ueberschreiben.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Stempelungen_ueberschreiben.ImageIndex = 2;
            this.button_Stempelungen_ueberschreiben.ImageList = this.myiconlist;
            this.button_Stempelungen_ueberschreiben.Location = new System.Drawing.Point(27, 199);
            this.button_Stempelungen_ueberschreiben.Name = "button_Stempelungen_ueberschreiben";
            this.button_Stempelungen_ueberschreiben.Size = new System.Drawing.Size(375, 35);
            this.button_Stempelungen_ueberschreiben.TabIndex = 9;
            this.button_Stempelungen_ueberschreiben.Text = "Markierte Stempelung mit diesen Werten überschreiben";
            this.button_Stempelungen_ueberschreiben.UseVisualStyleBackColor = true;
            this.button_Stempelungen_ueberschreiben.Click += new System.EventHandler(this.button_Stempelungen_ueberschreiben_Click);
            // 
            // Stempelungsgrid_Stempelungen
            // 
            this.Stempelungsgrid_Stempelungen.AllowUserToAddRows = false;
            this.Stempelungsgrid_Stempelungen.AllowUserToDeleteRows = false;
            this.Stempelungsgrid_Stempelungen.AllowUserToResizeColumns = false;
            this.Stempelungsgrid_Stempelungen.AllowUserToResizeRows = false;
            this.Stempelungsgrid_Stempelungen.BackgroundColor = System.Drawing.Color.White;
            this.Stempelungsgrid_Stempelungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stempelungsgrid_Stempelungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stampid,
            this.StampArt,
            this.StampTask,
            this.StampZeitstempel,
            this.StampSource});
            this.Stempelungsgrid_Stempelungen.Location = new System.Drawing.Point(26, 95);
            this.Stempelungsgrid_Stempelungen.MultiSelect = false;
            this.Stempelungsgrid_Stempelungen.Name = "Stempelungsgrid_Stempelungen";
            this.Stempelungsgrid_Stempelungen.ReadOnly = true;
            this.Stempelungsgrid_Stempelungen.RowHeadersVisible = false;
            this.Stempelungsgrid_Stempelungen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Stempelungsgrid_Stempelungen.Size = new System.Drawing.Size(324, 446);
            this.Stempelungsgrid_Stempelungen.TabIndex = 7;
            this.Stempelungsgrid_Stempelungen.SelectionChanged += new System.EventHandler(this.Stempelungsgrid_Stempelungen_SelectionChanged);
            // 
            // stampid
            // 
            this.stampid.Frozen = true;
            this.stampid.HeaderText = "ID";
            this.stampid.Name = "stampid";
            this.stampid.ReadOnly = true;
            this.stampid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.stampid.Width = 40;
            // 
            // StampArt
            // 
            this.StampArt.HeaderText = "Art";
            this.StampArt.Name = "StampArt";
            this.StampArt.ReadOnly = true;
            this.StampArt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StampArt.Width = 35;
            // 
            // StampTask
            // 
            this.StampTask.HeaderText = "AuftragsNr.";
            this.StampTask.Name = "StampTask";
            this.StampTask.ReadOnly = true;
            this.StampTask.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StampTask.Width = 65;
            // 
            // StampZeitstempel
            // 
            this.StampZeitstempel.HeaderText = "Zeitstempel";
            this.StampZeitstempel.Name = "StampZeitstempel";
            this.StampZeitstempel.ReadOnly = true;
            this.StampZeitstempel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StampZeitstempel.Width = 80;
            // 
            // StampSource
            // 
            this.StampSource.HeaderText = "Quelle";
            this.StampSource.Name = "StampSource";
            this.StampSource.ReadOnly = true;
            this.StampSource.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DatePicker_Stempelungen
            // 
            this.DatePicker_Stempelungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker_Stempelungen.Location = new System.Drawing.Point(52, 60);
            this.DatePicker_Stempelungen.Name = "DatePicker_Stempelungen";
            this.DatePicker_Stempelungen.Size = new System.Drawing.Size(273, 26);
            this.DatePicker_Stempelungen.TabIndex = 6;
            this.DatePicker_Stempelungen.ValueChanged += new System.EventHandler(this.DatePicker_Stempelungen_ValueChanged);
            // 
            // PersonPicker_Stempelungen
            // 
            this.PersonPicker_Stempelungen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonPicker_Stempelungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonPicker_Stempelungen.FormattingEnabled = true;
            this.PersonPicker_Stempelungen.Items.AddRange(new object[] {
            "Allgemein"});
            this.PersonPicker_Stempelungen.Location = new System.Drawing.Point(26, 24);
            this.PersonPicker_Stempelungen.Name = "PersonPicker_Stempelungen";
            this.PersonPicker_Stempelungen.Size = new System.Drawing.Size(324, 32);
            this.PersonPicker_Stempelungen.TabIndex = 5;
            this.PersonPicker_Stempelungen.SelectedIndexChanged += new System.EventHandler(this.PersonPicker_Stempelungen_SelectedIndexChanged);
            // 
            // Personen
            // 
            this.Personen.Controls.Add(this.groupBox2);
            this.Personen.Controls.Add(this.button_Personen_Edit_Systemdaten);
            this.Personen.Controls.Add(this.PersonPicker_Personen);
            this.Personen.Controls.Add(this.groupBox_Personen_Systemdaten);
            this.Personen.Controls.Add(this.groupBox1);
            this.Personen.Controls.Add(this.groupBox5);
            this.Personen.Controls.Add(this.button_Personen_writeChanges);
            this.Personen.Location = new System.Drawing.Point(4, 22);
            this.Personen.Name = "Personen";
            this.Personen.Padding = new System.Windows.Forms.Padding(3);
            this.Personen.Size = new System.Drawing.Size(822, 559);
            this.Personen.TabIndex = 0;
            this.Personen.Text = "Personen";
            this.Personen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Personen_ZeitkontoRueckrechnen);
            this.groupBox2.Controls.Add(this.DatePicker_Personen_ZeitkontoRueckrechnen);
            this.groupBox2.Controls.Add(this.label_Personen_Hinweis_ZeitBerechnungsstand);
            this.groupBox2.Controls.Add(this.label_Personen_Hinweis_Urlaubsjahr);
            this.groupBox2.Controls.Add(this.button_Personen_ZeitkontoAktualisieren);
            this.groupBox2.Controls.Add(this.button_Personen_UrlaubsjahrAktualisieren);
            this.groupBox2.Location = new System.Drawing.Point(420, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 211);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spezial-Funktionen";
            // 
            // button_Personen_ZeitkontoRueckrechnen
            // 
            this.button_Personen_ZeitkontoRueckrechnen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Personen_ZeitkontoRueckrechnen.ImageIndex = 4;
            this.button_Personen_ZeitkontoRueckrechnen.ImageList = this.myiconlist;
            this.button_Personen_ZeitkontoRueckrechnen.Location = new System.Drawing.Point(14, 167);
            this.button_Personen_ZeitkontoRueckrechnen.Name = "button_Personen_ZeitkontoRueckrechnen";
            this.button_Personen_ZeitkontoRueckrechnen.Size = new System.Drawing.Size(243, 31);
            this.button_Personen_ZeitkontoRueckrechnen.TabIndex = 13;
            this.button_Personen_ZeitkontoRueckrechnen.Text = "Zeitkonto rückrechnen bis zum Stand vom";
            this.button_Personen_ZeitkontoRueckrechnen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Personen_ZeitkontoRueckrechnen.UseVisualStyleBackColor = true;
            this.button_Personen_ZeitkontoRueckrechnen.Click += new System.EventHandler(this.button_Personen_ZeitkontoRueckrechnen_Click);
            // 
            // DatePicker_Personen_ZeitkontoRueckrechnen
            // 
            this.DatePicker_Personen_ZeitkontoRueckrechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker_Personen_ZeitkontoRueckrechnen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker_Personen_ZeitkontoRueckrechnen.Location = new System.Drawing.Point(264, 169);
            this.DatePicker_Personen_ZeitkontoRueckrechnen.Name = "DatePicker_Personen_ZeitkontoRueckrechnen";
            this.DatePicker_Personen_ZeitkontoRueckrechnen.Size = new System.Drawing.Size(100, 26);
            this.DatePicker_Personen_ZeitkontoRueckrechnen.TabIndex = 12;
            // 
            // label_Personen_Hinweis_ZeitBerechnungsstand
            // 
            this.label_Personen_Hinweis_ZeitBerechnungsstand.AutoSize = true;
            this.label_Personen_Hinweis_ZeitBerechnungsstand.BackColor = System.Drawing.Color.Gold;
            this.label_Personen_Hinweis_ZeitBerechnungsstand.Location = new System.Drawing.Point(11, 96);
            this.label_Personen_Hinweis_ZeitBerechnungsstand.Name = "label_Personen_Hinweis_ZeitBerechnungsstand";
            this.label_Personen_Hinweis_ZeitBerechnungsstand.Size = new System.Drawing.Size(355, 13);
            this.label_Personen_Hinweis_ZeitBerechnungsstand.TabIndex = 10;
            this.label_Personen_Hinweis_ZeitBerechnungsstand.Text = "Das Zeitkonto des Mitarbeiters ist nicht auf dem Stand von gestern Abend";
            // 
            // label_Personen_Hinweis_Urlaubsjahr
            // 
            this.label_Personen_Hinweis_Urlaubsjahr.AutoSize = true;
            this.label_Personen_Hinweis_Urlaubsjahr.BackColor = System.Drawing.Color.Gold;
            this.label_Personen_Hinweis_Urlaubsjahr.Location = new System.Drawing.Point(12, 25);
            this.label_Personen_Hinweis_Urlaubsjahr.Name = "label_Personen_Hinweis_Urlaubsjahr";
            this.label_Personen_Hinweis_Urlaubsjahr.Size = new System.Drawing.Size(352, 13);
            this.label_Personen_Hinweis_Urlaubsjahr.TabIndex = 10;
            this.label_Personen_Hinweis_Urlaubsjahr.Text = "Das Urlaubsjahr des Mitarbeiters ist noch nicht auf dieses Jahr eingestellt.";
            // 
            // button_Personen_ZeitkontoAktualisieren
            // 
            this.button_Personen_ZeitkontoAktualisieren.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Personen_ZeitkontoAktualisieren.ImageIndex = 3;
            this.button_Personen_ZeitkontoAktualisieren.ImageList = this.myiconlist;
            this.button_Personen_ZeitkontoAktualisieren.Location = new System.Drawing.Point(14, 112);
            this.button_Personen_ZeitkontoAktualisieren.Name = "button_Personen_ZeitkontoAktualisieren";
            this.button_Personen_ZeitkontoAktualisieren.Size = new System.Drawing.Size(350, 36);
            this.button_Personen_ZeitkontoAktualisieren.TabIndex = 4;
            this.button_Personen_ZeitkontoAktualisieren.Text = "Zeitkontostand auf stand von gestern Abend bringen";
            this.button_Personen_ZeitkontoAktualisieren.UseVisualStyleBackColor = true;
            this.button_Personen_ZeitkontoAktualisieren.Click += new System.EventHandler(this.button_Personen_ZeitkontoAktualisieren_Click);
            // 
            // button_Personen_UrlaubsjahrAktualisieren
            // 
            this.button_Personen_UrlaubsjahrAktualisieren.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Personen_UrlaubsjahrAktualisieren.ImageIndex = 3;
            this.button_Personen_UrlaubsjahrAktualisieren.ImageList = this.myiconlist;
            this.button_Personen_UrlaubsjahrAktualisieren.Location = new System.Drawing.Point(15, 41);
            this.button_Personen_UrlaubsjahrAktualisieren.Name = "button_Personen_UrlaubsjahrAktualisieren";
            this.button_Personen_UrlaubsjahrAktualisieren.Size = new System.Drawing.Size(350, 35);
            this.button_Personen_UrlaubsjahrAktualisieren.TabIndex = 4;
            this.button_Personen_UrlaubsjahrAktualisieren.Text = "Resturlaub berechnen und Urlaubsjahr aktualisieren";
            this.button_Personen_UrlaubsjahrAktualisieren.UseVisualStyleBackColor = true;
            this.button_Personen_UrlaubsjahrAktualisieren.Click += new System.EventHandler(this.button_Personen_UrlaubsjahrAktualisieren_Click);
            // 
            // button_Personen_Edit_Systemdaten
            // 
            this.button_Personen_Edit_Systemdaten.Location = new System.Drawing.Point(6, 216);
            this.button_Personen_Edit_Systemdaten.Name = "button_Personen_Edit_Systemdaten";
            this.button_Personen_Edit_Systemdaten.Size = new System.Drawing.Size(392, 21);
            this.button_Personen_Edit_Systemdaten.TabIndex = 6;
            this.button_Personen_Edit_Systemdaten.TabStop = false;
            this.button_Personen_Edit_Systemdaten.Text = "Bearbeitung der geschützten Systemdaten aktivieren";
            this.button_Personen_Edit_Systemdaten.UseVisualStyleBackColor = true;
            this.button_Personen_Edit_Systemdaten.Click += new System.EventHandler(this.button_Personen_Edit_Systemdaten_Click);
            // 
            // PersonPicker_Personen
            // 
            this.PersonPicker_Personen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonPicker_Personen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonPicker_Personen.FormattingEnabled = true;
            this.PersonPicker_Personen.Items.AddRange(new object[] {
            "Allgemein"});
            this.PersonPicker_Personen.Location = new System.Drawing.Point(8, 6);
            this.PersonPicker_Personen.Name = "PersonPicker_Personen";
            this.PersonPicker_Personen.Size = new System.Drawing.Size(390, 32);
            this.PersonPicker_Personen.TabIndex = 1;
            this.PersonPicker_Personen.SelectedIndexChanged += new System.EventHandler(this.PersonPicker_Personen_SelectedIndexChanged);
            // 
            // groupBox_Personen_Systemdaten
            // 
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label35);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label48);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label47);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label34);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label33);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label31);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label30);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label29);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.comboBox_Personen_Stempelfehler_old);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.comboBox_Personen_Stempelfehler);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_AktUrlaubsjahr_old);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_ResturlaubVorjahr_old);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_AktUrlaubsjahr);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_AktAuftrag_old);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_ResturlaubVorjahr);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_AktAuftrag);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label17);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_BetragletzterBonus_old);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_BetragletzterBonus);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label16);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_Boniausgezahltbis_old);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_Boniausgezahltbis);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label15);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_ZeitkontoBerechnungsstand_old);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_ZeitkontoBerechnungsstand);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label14);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_Zeitkonto_old);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.textBox_Personen_Zeitkonto);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label45);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label13);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label37);
            this.groupBox_Personen_Systemdaten.Controls.Add(this.label12);
            this.groupBox_Personen_Systemdaten.Enabled = false;
            this.groupBox_Personen_Systemdaten.Location = new System.Drawing.Point(6, 243);
            this.groupBox_Personen_Systemdaten.Name = "groupBox_Personen_Systemdaten";
            this.groupBox_Personen_Systemdaten.Size = new System.Drawing.Size(392, 264);
            this.groupBox_Personen_Systemdaten.TabIndex = 3;
            this.groupBox_Personen_Systemdaten.TabStop = false;
            this.groupBox_Personen_Systemdaten.Text = "Systemdaten";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(255, 231);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(19, 13);
            this.label35.TabIndex = 8;
            this.label35.Text = "-->";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(255, 202);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(19, 13);
            this.label48.TabIndex = 8;
            this.label48.Text = "-->";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(255, 173);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(19, 13);
            this.label47.TabIndex = 8;
            this.label47.Text = "-->";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(255, 144);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(19, 13);
            this.label34.TabIndex = 8;
            this.label34.Text = "-->";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(255, 115);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(19, 13);
            this.label33.TabIndex = 8;
            this.label33.Text = "-->";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(255, 86);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(19, 13);
            this.label31.TabIndex = 8;
            this.label31.Text = "-->";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(255, 57);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(19, 13);
            this.label30.TabIndex = 8;
            this.label30.Text = "-->";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(255, 28);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(19, 13);
            this.label29.TabIndex = 8;
            this.label29.Text = "-->";
            // 
            // comboBox_Personen_Stempelfehler_old
            // 
            this.comboBox_Personen_Stempelfehler_old.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Personen_Stempelfehler_old.Enabled = false;
            this.comboBox_Personen_Stempelfehler_old.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Personen_Stempelfehler_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Personen_Stempelfehler_old.FormattingEnabled = true;
            this.comboBox_Personen_Stempelfehler_old.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox_Personen_Stempelfehler_old.Location = new System.Drawing.Point(145, 223);
            this.comboBox_Personen_Stempelfehler_old.Name = "comboBox_Personen_Stempelfehler_old";
            this.comboBox_Personen_Stempelfehler_old.Size = new System.Drawing.Size(100, 28);
            this.comboBox_Personen_Stempelfehler_old.TabIndex = 7;
            this.comboBox_Personen_Stempelfehler_old.TabStop = false;
            // 
            // comboBox_Personen_Stempelfehler
            // 
            this.comboBox_Personen_Stempelfehler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Personen_Stempelfehler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Personen_Stempelfehler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Personen_Stempelfehler.FormattingEnabled = true;
            this.comboBox_Personen_Stempelfehler.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox_Personen_Stempelfehler.Location = new System.Drawing.Point(285, 223);
            this.comboBox_Personen_Stempelfehler.Name = "comboBox_Personen_Stempelfehler";
            this.comboBox_Personen_Stempelfehler.Size = new System.Drawing.Size(100, 28);
            this.comboBox_Personen_Stempelfehler.TabIndex = 6;
            this.comboBox_Personen_Stempelfehler.SelectedIndexChanged += new System.EventHandler(this.comboBox_Personen_Stempelfehler_SelectedIndexChanged);
            // 
            // textBox_Personen_AktUrlaubsjahr_old
            // 
            this.textBox_Personen_AktUrlaubsjahr_old.Enabled = false;
            this.textBox_Personen_AktUrlaubsjahr_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_AktUrlaubsjahr_old.Location = new System.Drawing.Point(145, 165);
            this.textBox_Personen_AktUrlaubsjahr_old.MaxLength = 6;
            this.textBox_Personen_AktUrlaubsjahr_old.Name = "textBox_Personen_AktUrlaubsjahr_old";
            this.textBox_Personen_AktUrlaubsjahr_old.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_AktUrlaubsjahr_old.TabIndex = 1;
            this.textBox_Personen_AktUrlaubsjahr_old.TabStop = false;
            // 
            // textBox_Personen_ResturlaubVorjahr_old
            // 
            this.textBox_Personen_ResturlaubVorjahr_old.Enabled = false;
            this.textBox_Personen_ResturlaubVorjahr_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_ResturlaubVorjahr_old.Location = new System.Drawing.Point(145, 194);
            this.textBox_Personen_ResturlaubVorjahr_old.MaxLength = 6;
            this.textBox_Personen_ResturlaubVorjahr_old.Name = "textBox_Personen_ResturlaubVorjahr_old";
            this.textBox_Personen_ResturlaubVorjahr_old.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_ResturlaubVorjahr_old.TabIndex = 1;
            this.textBox_Personen_ResturlaubVorjahr_old.TabStop = false;
            // 
            // textBox_Personen_AktUrlaubsjahr
            // 
            this.textBox_Personen_AktUrlaubsjahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_AktUrlaubsjahr.Location = new System.Drawing.Point(285, 165);
            this.textBox_Personen_AktUrlaubsjahr.MaxLength = 6;
            this.textBox_Personen_AktUrlaubsjahr.Name = "textBox_Personen_AktUrlaubsjahr";
            this.textBox_Personen_AktUrlaubsjahr.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_AktUrlaubsjahr.TabIndex = 1;
            this.textBox_Personen_AktUrlaubsjahr.TextChanged += new System.EventHandler(this.textBox_Personen_AktUrlaubsjahr_TextChanged);
            // 
            // textBox_Personen_AktAuftrag_old
            // 
            this.textBox_Personen_AktAuftrag_old.Enabled = false;
            this.textBox_Personen_AktAuftrag_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_AktAuftrag_old.Location = new System.Drawing.Point(145, 20);
            this.textBox_Personen_AktAuftrag_old.MaxLength = 6;
            this.textBox_Personen_AktAuftrag_old.Name = "textBox_Personen_AktAuftrag_old";
            this.textBox_Personen_AktAuftrag_old.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_AktAuftrag_old.TabIndex = 1;
            this.textBox_Personen_AktAuftrag_old.TabStop = false;
            // 
            // textBox_Personen_ResturlaubVorjahr
            // 
            this.textBox_Personen_ResturlaubVorjahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_ResturlaubVorjahr.Location = new System.Drawing.Point(285, 194);
            this.textBox_Personen_ResturlaubVorjahr.MaxLength = 6;
            this.textBox_Personen_ResturlaubVorjahr.Name = "textBox_Personen_ResturlaubVorjahr";
            this.textBox_Personen_ResturlaubVorjahr.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_ResturlaubVorjahr.TabIndex = 1;
            this.textBox_Personen_ResturlaubVorjahr.TextChanged += new System.EventHandler(this.textBox_Personen_ResturlaubVorjahr_TextChanged);
            // 
            // textBox_Personen_AktAuftrag
            // 
            this.textBox_Personen_AktAuftrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_AktAuftrag.Location = new System.Drawing.Point(285, 20);
            this.textBox_Personen_AktAuftrag.MaxLength = 6;
            this.textBox_Personen_AktAuftrag.Name = "textBox_Personen_AktAuftrag";
            this.textBox_Personen_AktAuftrag.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_AktAuftrag.TabIndex = 1;
            this.textBox_Personen_AktAuftrag.TextChanged += new System.EventHandler(this.textBox_Personen_AktAuftrag_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 231);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Stempelfehler";
            // 
            // textBox_Personen_BetragletzterBonus_old
            // 
            this.textBox_Personen_BetragletzterBonus_old.Enabled = false;
            this.textBox_Personen_BetragletzterBonus_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_BetragletzterBonus_old.Location = new System.Drawing.Point(145, 136);
            this.textBox_Personen_BetragletzterBonus_old.MaxLength = 10;
            this.textBox_Personen_BetragletzterBonus_old.Name = "textBox_Personen_BetragletzterBonus_old";
            this.textBox_Personen_BetragletzterBonus_old.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_BetragletzterBonus_old.TabIndex = 1;
            this.textBox_Personen_BetragletzterBonus_old.TabStop = false;
            // 
            // textBox_Personen_BetragletzterBonus
            // 
            this.textBox_Personen_BetragletzterBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_BetragletzterBonus.Location = new System.Drawing.Point(285, 136);
            this.textBox_Personen_BetragletzterBonus.MaxLength = 10;
            this.textBox_Personen_BetragletzterBonus.Name = "textBox_Personen_BetragletzterBonus";
            this.textBox_Personen_BetragletzterBonus.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_BetragletzterBonus.TabIndex = 5;
            this.textBox_Personen_BetragletzterBonus.TextChanged += new System.EventHandler(this.textBox_Personen_BetragletzterBonus_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Betrag letzter Bonus";
            // 
            // textBox_Personen_Boniausgezahltbis_old
            // 
            this.textBox_Personen_Boniausgezahltbis_old.Enabled = false;
            this.textBox_Personen_Boniausgezahltbis_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Boniausgezahltbis_old.Location = new System.Drawing.Point(145, 107);
            this.textBox_Personen_Boniausgezahltbis_old.MaxLength = 8;
            this.textBox_Personen_Boniausgezahltbis_old.Name = "textBox_Personen_Boniausgezahltbis_old";
            this.textBox_Personen_Boniausgezahltbis_old.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Boniausgezahltbis_old.TabIndex = 1;
            this.textBox_Personen_Boniausgezahltbis_old.TabStop = false;
            // 
            // textBox_Personen_Boniausgezahltbis
            // 
            this.textBox_Personen_Boniausgezahltbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Boniausgezahltbis.Location = new System.Drawing.Point(285, 107);
            this.textBox_Personen_Boniausgezahltbis.MaxLength = 8;
            this.textBox_Personen_Boniausgezahltbis.Name = "textBox_Personen_Boniausgezahltbis";
            this.textBox_Personen_Boniausgezahltbis.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Boniausgezahltbis.TabIndex = 4;
            this.textBox_Personen_Boniausgezahltbis.TextChanged += new System.EventHandler(this.textBox_Personen_Boniausgezahltbis_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Boni ausgezahlt bis";
            // 
            // textBox_Personen_ZeitkontoBerechnungsstand_old
            // 
            this.textBox_Personen_ZeitkontoBerechnungsstand_old.Enabled = false;
            this.textBox_Personen_ZeitkontoBerechnungsstand_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_ZeitkontoBerechnungsstand_old.Location = new System.Drawing.Point(145, 78);
            this.textBox_Personen_ZeitkontoBerechnungsstand_old.MaxLength = 8;
            this.textBox_Personen_ZeitkontoBerechnungsstand_old.Name = "textBox_Personen_ZeitkontoBerechnungsstand_old";
            this.textBox_Personen_ZeitkontoBerechnungsstand_old.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_ZeitkontoBerechnungsstand_old.TabIndex = 1;
            this.textBox_Personen_ZeitkontoBerechnungsstand_old.TabStop = false;
            // 
            // textBox_Personen_ZeitkontoBerechnungsstand
            // 
            this.textBox_Personen_ZeitkontoBerechnungsstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_ZeitkontoBerechnungsstand.Location = new System.Drawing.Point(285, 78);
            this.textBox_Personen_ZeitkontoBerechnungsstand.MaxLength = 8;
            this.textBox_Personen_ZeitkontoBerechnungsstand.Name = "textBox_Personen_ZeitkontoBerechnungsstand";
            this.textBox_Personen_ZeitkontoBerechnungsstand.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_ZeitkontoBerechnungsstand.TabIndex = 3;
            this.textBox_Personen_ZeitkontoBerechnungsstand.TextChanged += new System.EventHandler(this.textBox_Personen_ZeitkontoBerechnungsstand_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Berechnungsstand";
            // 
            // textBox_Personen_Zeitkonto_old
            // 
            this.textBox_Personen_Zeitkonto_old.Enabled = false;
            this.textBox_Personen_Zeitkonto_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Zeitkonto_old.Location = new System.Drawing.Point(145, 49);
            this.textBox_Personen_Zeitkonto_old.MaxLength = 10;
            this.textBox_Personen_Zeitkonto_old.Name = "textBox_Personen_Zeitkonto_old";
            this.textBox_Personen_Zeitkonto_old.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Zeitkonto_old.TabIndex = 1;
            this.textBox_Personen_Zeitkonto_old.TabStop = false;
            // 
            // textBox_Personen_Zeitkonto
            // 
            this.textBox_Personen_Zeitkonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Zeitkonto.Location = new System.Drawing.Point(285, 49);
            this.textBox_Personen_Zeitkonto.MaxLength = 10;
            this.textBox_Personen_Zeitkonto.Name = "textBox_Personen_Zeitkonto";
            this.textBox_Personen_Zeitkonto.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Zeitkonto.TabIndex = 2;
            this.textBox_Personen_Zeitkonto.TextChanged += new System.EventHandler(this.textBox_Personen_Zeitkonto_TextChanged);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(25, 173);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(106, 13);
            this.label45.TabIndex = 0;
            this.label45.Text = "Aktuelles Urlaubsjahr";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Zeitkonto";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(25, 202);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(117, 13);
            this.label37.TabIndex = 0;
            this.label37.Text = "Resturlaub vom Vorjahr";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Aktueller Auftrag";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DatePicker_Personen_neu);
            this.groupBox1.Controls.Add(this.textBox_Personen_Neu_WunschID);
            this.groupBox1.Controls.Add(this.textBox_Personen_Neu_Urlaubstage);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_Personen_Neu_Nachname);
            this.groupBox1.Controls.Add(this.button_Personen_newPerson);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.textBox_Personen_Neu_Vorname);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(563, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 213);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neuer Mitarbeiter";
            // 
            // DatePicker_Personen_neu
            // 
            this.DatePicker_Personen_neu.CustomFormat = "dd.MM.yyyy";
            this.DatePicker_Personen_neu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker_Personen_neu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker_Personen_neu.Location = new System.Drawing.Point(136, 137);
            this.DatePicker_Personen_neu.Name = "DatePicker_Personen_neu";
            this.DatePicker_Personen_neu.Size = new System.Drawing.Size(100, 26);
            this.DatePicker_Personen_neu.TabIndex = 5;
            // 
            // textBox_Personen_Neu_WunschID
            // 
            this.textBox_Personen_Neu_WunschID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Neu_WunschID.Location = new System.Drawing.Point(136, 21);
            this.textBox_Personen_Neu_WunschID.Name = "textBox_Personen_Neu_WunschID";
            this.textBox_Personen_Neu_WunschID.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Neu_WunschID.TabIndex = 1;
            this.textBox_Personen_Neu_WunschID.TextChanged += new System.EventHandler(this.textBox_Personen_Neu_WunschID_TextChanged);
            // 
            // textBox_Personen_Neu_Urlaubstage
            // 
            this.textBox_Personen_Neu_Urlaubstage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Neu_Urlaubstage.Location = new System.Drawing.Point(136, 108);
            this.textBox_Personen_Neu_Urlaubstage.Name = "textBox_Personen_Neu_Urlaubstage";
            this.textBox_Personen_Neu_Urlaubstage.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Neu_Urlaubstage.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Erster Arbeitstag";
            // 
            // textBox_Personen_Neu_Nachname
            // 
            this.textBox_Personen_Neu_Nachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Neu_Nachname.Location = new System.Drawing.Point(136, 79);
            this.textBox_Personen_Neu_Nachname.Name = "textBox_Personen_Neu_Nachname";
            this.textBox_Personen_Neu_Nachname.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Neu_Nachname.TabIndex = 3;
            // 
            // button_Personen_newPerson
            // 
            this.button_Personen_newPerson.Enabled = false;
            this.button_Personen_newPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Personen_newPerson.ImageIndex = 0;
            this.button_Personen_newPerson.ImageList = this.myiconlist;
            this.button_Personen_newPerson.Location = new System.Drawing.Point(19, 173);
            this.button_Personen_newPerson.Name = "button_Personen_newPerson";
            this.button_Personen_newPerson.Size = new System.Drawing.Size(217, 34);
            this.button_Personen_newPerson.TabIndex = 6;
            this.button_Personen_newPerson.Text = "Neuen Mitarbeiter anlegen";
            this.button_Personen_newPerson.UseVisualStyleBackColor = true;
            this.button_Personen_newPerson.Click += new System.EventHandler(this.button_Personen_newPerson_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Urlaubsanspruch/Jahr";
            // 
            // textBox_Personen_Neu_Vorname
            // 
            this.textBox_Personen_Neu_Vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Neu_Vorname.Location = new System.Drawing.Point(136, 50);
            this.textBox_Personen_Neu_Vorname.Name = "textBox_Personen_Neu_Vorname";
            this.textBox_Personen_Neu_Vorname.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Neu_Vorname.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Nachname";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "gewünschte ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Vorname";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.comboBox_Personen_Aktiv_old);
            this.groupBox5.Controls.Add(this.comboBox_Personen_Aktiv);
            this.groupBox5.Controls.Add(this.textBox_Personen_Urlaubstage_old);
            this.groupBox5.Controls.Add(this.textBox_Personen_Urlaubstage);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBox_Personen_Nachname_old);
            this.groupBox5.Controls.Add(this.textBox_Personen_Nachname);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.textBox_Personen_Vorname_old);
            this.groupBox5.Controls.Add(this.textBox_Personen_Vorname);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(8, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(390, 167);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stammdaten";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(242, 133);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(19, 13);
            this.label28.TabIndex = 8;
            this.label28.Text = "-->";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(242, 99);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(19, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "-->";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(242, 63);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(19, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "-->";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "-->";
            // 
            // comboBox_Personen_Aktiv_old
            // 
            this.comboBox_Personen_Aktiv_old.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Personen_Aktiv_old.Enabled = false;
            this.comboBox_Personen_Aktiv_old.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Personen_Aktiv_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Personen_Aktiv_old.FormattingEnabled = true;
            this.comboBox_Personen_Aktiv_old.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox_Personen_Aktiv_old.Location = new System.Drawing.Point(132, 125);
            this.comboBox_Personen_Aktiv_old.Name = "comboBox_Personen_Aktiv_old";
            this.comboBox_Personen_Aktiv_old.Size = new System.Drawing.Size(100, 28);
            this.comboBox_Personen_Aktiv_old.TabIndex = 7;
            this.comboBox_Personen_Aktiv_old.TabStop = false;
            // 
            // comboBox_Personen_Aktiv
            // 
            this.comboBox_Personen_Aktiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Personen_Aktiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Personen_Aktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Personen_Aktiv.FormattingEnabled = true;
            this.comboBox_Personen_Aktiv.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox_Personen_Aktiv.Location = new System.Drawing.Point(272, 125);
            this.comboBox_Personen_Aktiv.Name = "comboBox_Personen_Aktiv";
            this.comboBox_Personen_Aktiv.Size = new System.Drawing.Size(100, 28);
            this.comboBox_Personen_Aktiv.TabIndex = 4;
            this.comboBox_Personen_Aktiv.SelectedIndexChanged += new System.EventHandler(this.comboBox_Personen_Aktiv_SelectedIndexChanged);
            // 
            // textBox_Personen_Urlaubstage_old
            // 
            this.textBox_Personen_Urlaubstage_old.Enabled = false;
            this.textBox_Personen_Urlaubstage_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Urlaubstage_old.Location = new System.Drawing.Point(132, 91);
            this.textBox_Personen_Urlaubstage_old.MaxLength = 10;
            this.textBox_Personen_Urlaubstage_old.Name = "textBox_Personen_Urlaubstage_old";
            this.textBox_Personen_Urlaubstage_old.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Urlaubstage_old.TabIndex = 1;
            this.textBox_Personen_Urlaubstage_old.TabStop = false;
            // 
            // textBox_Personen_Urlaubstage
            // 
            this.textBox_Personen_Urlaubstage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Urlaubstage.Location = new System.Drawing.Point(272, 91);
            this.textBox_Personen_Urlaubstage.MaxLength = 10;
            this.textBox_Personen_Urlaubstage.Name = "textBox_Personen_Urlaubstage";
            this.textBox_Personen_Urlaubstage.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Urlaubstage.TabIndex = 3;
            this.textBox_Personen_Urlaubstage.TextChanged += new System.EventHandler(this.textBox_Personen_Urlaubstage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktiver Mitarbeiter";
            // 
            // textBox_Personen_Nachname_old
            // 
            this.textBox_Personen_Nachname_old.Enabled = false;
            this.textBox_Personen_Nachname_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Nachname_old.Location = new System.Drawing.Point(132, 55);
            this.textBox_Personen_Nachname_old.MaxLength = 30;
            this.textBox_Personen_Nachname_old.Name = "textBox_Personen_Nachname_old";
            this.textBox_Personen_Nachname_old.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Nachname_old.TabIndex = 1;
            this.textBox_Personen_Nachname_old.TabStop = false;
            // 
            // textBox_Personen_Nachname
            // 
            this.textBox_Personen_Nachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Nachname.Location = new System.Drawing.Point(272, 55);
            this.textBox_Personen_Nachname.MaxLength = 30;
            this.textBox_Personen_Nachname.Name = "textBox_Personen_Nachname";
            this.textBox_Personen_Nachname.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Nachname.TabIndex = 2;
            this.textBox_Personen_Nachname.TextChanged += new System.EventHandler(this.textBox_Personen_Nachname_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Urlaubsanspruch";
            // 
            // textBox_Personen_Vorname_old
            // 
            this.textBox_Personen_Vorname_old.Enabled = false;
            this.textBox_Personen_Vorname_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Vorname_old.Location = new System.Drawing.Point(132, 19);
            this.textBox_Personen_Vorname_old.MaxLength = 30;
            this.textBox_Personen_Vorname_old.Name = "textBox_Personen_Vorname_old";
            this.textBox_Personen_Vorname_old.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Vorname_old.TabIndex = 1;
            this.textBox_Personen_Vorname_old.TabStop = false;
            // 
            // textBox_Personen_Vorname
            // 
            this.textBox_Personen_Vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Personen_Vorname.Location = new System.Drawing.Point(272, 19);
            this.textBox_Personen_Vorname.MaxLength = 30;
            this.textBox_Personen_Vorname.Name = "textBox_Personen_Vorname";
            this.textBox_Personen_Vorname.Size = new System.Drawing.Size(100, 26);
            this.textBox_Personen_Vorname.TabIndex = 1;
            this.textBox_Personen_Vorname.TextChanged += new System.EventHandler(this.textBox_Personen_Vorname_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nachname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Vorname";
            // 
            // button_Personen_writeChanges
            // 
            this.button_Personen_writeChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Personen_writeChanges.ImageIndex = 2;
            this.button_Personen_writeChanges.ImageList = this.myiconlist;
            this.button_Personen_writeChanges.Location = new System.Drawing.Point(6, 516);
            this.button_Personen_writeChanges.Name = "button_Personen_writeChanges";
            this.button_Personen_writeChanges.Size = new System.Drawing.Size(392, 34);
            this.button_Personen_writeChanges.TabIndex = 4;
            this.button_Personen_writeChanges.Text = "Änderungen festschreiben";
            this.button_Personen_writeChanges.UseVisualStyleBackColor = true;
            this.button_Personen_writeChanges.Click += new System.EventHandler(this.button_Personen_writeChanges_Click);
            // 
            // Auswertungen
            // 
            this.Auswertungen.Location = new System.Drawing.Point(4, 22);
            this.Auswertungen.Name = "Auswertungen";
            this.Auswertungen.Padding = new System.Windows.Forms.Padding(3);
            this.Auswertungen.Size = new System.Drawing.Size(822, 559);
            this.Auswertungen.TabIndex = 3;
            this.Auswertungen.Text = "Auswertungen";
            this.Auswertungen.UseVisualStyleBackColor = true;
            // 
            // label_Bonus_Hinweis
            // 
            this.label_Bonus_Hinweis.BackColor = System.Drawing.Color.Gold;
            this.label_Bonus_Hinweis.Location = new System.Drawing.Point(38, 182);
            this.label_Bonus_Hinweis.Name = "label_Bonus_Hinweis";
            this.label_Bonus_Hinweis.Size = new System.Drawing.Size(330, 30);
            this.label_Bonus_Hinweis.TabIndex = 17;
            this.label_Bonus_Hinweis.Text = "Der gewählte Berechnungszeitraum geht über das Datum hinaus,\r\nbis zu dem alle Ste" +
    "mpelungen bereits verrechnet sind.";
            this.label_Bonus_Hinweis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Bonus_ShowGroupbox_Neu
            // 
            this.button_Bonus_ShowGroupbox_Neu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Bonus_ShowGroupbox_Neu.ImageIndex = 3;
            this.button_Bonus_ShowGroupbox_Neu.ImageList = this.myiconlist;
            this.button_Bonus_ShowGroupbox_Neu.Location = new System.Drawing.Point(187, 297);
            this.button_Bonus_ShowGroupbox_Neu.Name = "button_Bonus_ShowGroupbox_Neu";
            this.button_Bonus_ShowGroupbox_Neu.Size = new System.Drawing.Size(423, 32);
            this.button_Bonus_ShowGroupbox_Neu.TabIndex = 17;
            this.button_Bonus_ShowGroupbox_Neu.Text = "Neue Bonuszeit berechnen";
            this.button_Bonus_ShowGroupbox_Neu.UseVisualStyleBackColor = true;
            this.button_Bonus_ShowGroupbox_Neu.Click += new System.EventHandler(this.button_Bonus_ShowGroupbox_Neu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 584);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KalenderGrid_Kalender)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Kalender.ResumeLayout(false);
            this.groupBox_Kalender_erstelleEintrag.ResumeLayout(false);
            this.groupBox_Kalender_erstelleEintrag.PerformLayout();
            this.groupBox_Kalender_AlleEreignisse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ereignisgrid_Kalender)).EndInit();
            this.Verrechnung.ResumeLayout(false);
            this.Verrechnung.PerformLayout();
            this.groupBox_Verrechnungen_Update.ResumeLayout(false);
            this.groupBox_Verrechnungen_Update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Verrechnungsgrid_Verrechnungen_Update)).EndInit();
            this.groupBox_Verrechnungen_Insert.ResumeLayout(false);
            this.groupBox_Verrechnungen_Insert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Verrechnungsgrid_Verrechnungen_Insert)).EndInit();
            this.Bonusberechnung.ResumeLayout(false);
            this.groupBox_Bonus_neu.ResumeLayout(false);
            this.groupBox_Bonus_neu.PerformLayout();
            this.groupBoxLetzteBonusberechnung.ResumeLayout(false);
            this.groupBoxLetzteBonusberechnung.PerformLayout();
            this.Stempelungen.ResumeLayout(false);
            this.groupBox_Stempelungen_Zeitkonto.ResumeLayout(false);
            this.groupBox_Stempelungen_Zeitkonto.PerformLayout();
            this.groupBox_Stempelungen_EditierenErstellen.ResumeLayout(false);
            this.groupBox_Stempelungen_EditierenErstellen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stempelungsgrid_Stempelungen)).EndInit();
            this.Personen.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Personen_Systemdaten.ResumeLayout(false);
            this.groupBox_Personen_Systemdaten.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView KalenderGrid_Kalender;
        private System.Windows.Forms.DateTimePicker MonatsPicker_Kalender;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Auswertungen;
        private System.Windows.Forms.TabPage Verrechnung;
        private System.Windows.Forms.TabPage Stempelungen;
        private System.Windows.Forms.TabPage Kalender;
        private System.Windows.Forms.TabPage Personen;
        private System.Windows.Forms.Button button_Kalender_ganzerTagUrlaub;
        private System.Windows.Forms.TextBox textBox_Kalender_Sollzeit;
        private System.Windows.Forms.Button button_Kalender_halberTagUrlaub;
        private System.Windows.Forms.Button button_Kalender_erstelleEintrag;
        private System.Windows.Forms.Button button_Kalender_storniereEintrag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Kalender_Bemerkung;
        private System.Windows.Forms.TextBox textBox_Kalender_Urlaub;
        private System.Windows.Forms.GroupBox groupBox_Kalender_erstelleEintrag;
        private System.Windows.Forms.GroupBox groupBox_Kalender_AlleEreignisse;
        private System.Windows.Forms.Button button_Kalender_Krankheitstag;
        private System.Windows.Forms.Button button_Kalender_Feiertag;
        private System.Windows.Forms.DataGridView Ereignisgrid_Kalender;
        private System.Windows.Forms.GroupBox groupBox_Personen_Systemdaten;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_Personen_BetragletzterBonus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_Personen_Boniausgezahltbis;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_Personen_ZeitkontoBerechnungsstand;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Personen_Zeitkonto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_Personen_Urlaubstage;
        private System.Windows.Forms.TextBox textBox_Personen_Nachname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Personen_Vorname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Personen_newPerson;
        private System.Windows.Forms.Button button_Personen_writeChanges;
        private System.Windows.Forms.TextBox textBox_Personen_AktAuftrag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PersonPicker_Personen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Personen_Neu_WunschID;
        private System.Windows.Forms.TextBox textBox_Personen_Neu_Urlaubstage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Personen_Neu_Nachname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_Personen_Neu_Vorname;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView Stempelungsgrid_Stempelungen;
        private System.Windows.Forms.DateTimePicker DatePicker_Stempelungen;
        private System.Windows.Forms.GroupBox groupBox_Stempelungen_EditierenErstellen;
        private System.Windows.Forms.TextBox textBox_Stempelungen_Auftragsnummer;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button_Stempelungen_ueberschreiben;
        private System.Windows.Forms.Button button_Stempelungen_neueStempelung;
        private System.Windows.Forms.Button button_Stempelungen_stornieren;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker DatePicker_Personen_neu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mittwoch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donnerstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freitag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Samstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sonntag;
        private System.Windows.Forms.Button button_Personen_Edit_Systemdaten;
        private System.Windows.Forms.ComboBox comboBox_Personen_Aktiv;
        private System.Windows.Forms.ComboBox comboBox_Personen_Stempelfehler;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox comboBox_Personen_Stempelfehler_old;
        private System.Windows.Forms.TextBox textBox_Personen_AktAuftrag_old;
        private System.Windows.Forms.TextBox textBox_Personen_BetragletzterBonus_old;
        private System.Windows.Forms.TextBox textBox_Personen_Boniausgezahltbis_old;
        private System.Windows.Forms.TextBox textBox_Personen_ZeitkontoBerechnungsstand_old;
        private System.Windows.Forms.TextBox textBox_Personen_Zeitkonto_old;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Personen_Aktiv_old;
        private System.Windows.Forms.TextBox textBox_Personen_Urlaubstage_old;
        private System.Windows.Forms.TextBox textBox_Personen_Nachname_old;
        private System.Windows.Forms.TextBox textBox_Personen_Vorname_old;
        private System.Windows.Forms.DateTimePicker TimePicker_Stempelungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn stampid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StampArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn StampTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn StampZeitstempel;
        private System.Windows.Forms.DataGridViewTextBoxColumn StampSource;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button button_Stempelungen_ZeitkontoRueckrechnen;
        private System.Windows.Forms.Label label_Stempelungen_Zeitkonto_Berechnungsstand;
        private System.Windows.Forms.Label label_Stempelungen_Hinweis;
        private System.Windows.Forms.GroupBox groupBox_Verrechnungen_Update;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBox_Verrechnung_Auftragsnummer;
        private System.Windows.Forms.GroupBox groupBox_Verrechnungen_Insert;
        private System.Windows.Forms.Button button_Verrechnungen_SatzErstellen;
        private System.Windows.Forms.DataGridView Verrechnungsgrid_Verrechnungen_Insert;
        private System.Windows.Forms.TextBox textBox_Verrechnungen_Stunden_Insert;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox Auftragspicker_Verrechnung_Insert;
        private System.Windows.Forms.DateTimePicker DatePicker_Verrechnung_Update;
        private System.Windows.Forms.Button button_Verrechnungen_SatzStornieren;
        private System.Windows.Forms.Button button_Verrechnungen_SatzUeberschreiben;
        private System.Windows.Forms.DataGridView Verrechnungsgrid_Verrechnungen_Update;
        private System.Windows.Forms.TextBox textBox_Verrechnungen_Stunden_edit;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DateTimePicker DatePicker_Verrechnung_Insert;
        private System.Windows.Forms.TextBox textBox_Verrechnungen_Mitarbeiter_Insert;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox comboBox_Stempelungen_Art;
        private System.Windows.Forms.ComboBox PersonPicker_Stempelungen;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox_Verrechnung_StundenGesamt;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox PersonPicker_Kalender;
        private System.Windows.Forms.Button button_Stempelungen_DatePickerTagzurueck;
        private System.Windows.Forms.Button button_Stempelungen_DatePickerTagvorwaerts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mitarbeiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dat_letzte_Stempelung;
        private System.Windows.Forms.DataGridViewTextBoxColumn gesamtzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn satzid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verrechnungsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verrechnet;
        private System.Windows.Forms.Button button_Kalender_Monatvor;
        private System.Windows.Forms.Button button_Kalender_Monatzurueck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Personen_Hinweis_Urlaubsjahr;
        private System.Windows.Forms.Button button_Personen_UrlaubsjahrAktualisieren;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox textBox_Personen_AktUrlaubsjahr_old;
        private System.Windows.Forms.TextBox textBox_Personen_ResturlaubVorjahr_old;
        private System.Windows.Forms.TextBox textBox_Personen_AktUrlaubsjahr;
        private System.Windows.Forms.TextBox textBox_Personen_ResturlaubVorjahr;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label_Personen_Hinweis_ZeitBerechnungsstand;
        private System.Windows.Forms.Button button_Personen_ZeitkontoAktualisieren;
        private System.Windows.Forms.GroupBox groupBox_Stempelungen_Zeitkonto;
        private System.Windows.Forms.Button button_Personen_ZeitkontoRueckrechnen;
        private System.Windows.Forms.DateTimePicker DatePicker_Personen_ZeitkontoRueckrechnen;
        private System.Windows.Forms.TabPage Bonusberechnung;
        private System.Windows.Forms.Button button_Bonus_BerechnenBis;
        private System.Windows.Forms.DateTimePicker DatePicker_Bonus_Neu_BerechnenBis;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.ComboBox PersonPicker_Bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sollzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urlaub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vermerk;
        private System.Windows.Forms.GroupBox groupBox_Bonus_neu;
        private System.Windows.Forms.Label label_Bonus_Neu_ErstmoeglicherTag;
        private System.Windows.Forms.Label label_Bonus_Neu_LetzterVollverrechneterTag;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.GroupBox groupBoxLetzteBonusberechnung;
        private System.Windows.Forms.Label label_Bonus_Alt_Bonuszeit;
        private System.Windows.Forms.Label label_Bonus_Alt_BerechnetBis;
        private System.Windows.Forms.ImageList myiconlist;
        private System.Windows.Forms.Label label_Bonus_Hinweis;
        private System.Windows.Forms.Button button_Bonus_ShowGroupbox_Neu;
    }
}

