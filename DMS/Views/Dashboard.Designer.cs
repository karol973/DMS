namespace DMS
{
   partial class Dashboard
   {
      private System.ComponentModel.IContainer components = null;

      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }

         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      private void InitializeComponent()
      {
         this.sidebarCard =
            new MaterialSkin.Controls.MaterialCard();

         this.lblMenu =
            new MaterialSkin.Controls.MaterialLabel();

         this.btnPatients =
            new MaterialSkin.Controls.MaterialButton();

         this.btnAddPatient =
            new MaterialSkin.Controls.MaterialButton();

         this.btnAddDiagnosis =
            new MaterialSkin.Controls.MaterialButton();

         this.btnFullHistory =
            new MaterialSkin.Controls.MaterialButton();

         this.btnDental =
            new MaterialSkin.Controls.MaterialButton();

         this.btnExit =
            new MaterialSkin.Controls.MaterialButton();

         this.patientListCard =
            new MaterialSkin.Controls.MaterialCard();

         this.lblPatientsList =
            new MaterialSkin.Controls.MaterialLabel();

         this.lblPatientsSubtitle =
            new MaterialSkin.Controls.MaterialLabel();

         this.dataGridView1 =
            new System.Windows.Forms.DataGridView();

         this.addPatientCard =
            new MaterialSkin.Controls.MaterialCard();

         this.lblAddPatient =
            new MaterialSkin.Controls.MaterialLabel();

         this.lblAddPatientSubtitle =
            new MaterialSkin.Controls.MaterialLabel();

         this.txtName =
            new MaterialSkin.Controls.MaterialTextBox();

         this.txtSurname =
            new MaterialSkin.Controls.MaterialTextBox();

         this.txtPhone =
            new MaterialSkin.Controls.MaterialTextBox();

         this.txtAge =
            new MaterialSkin.Controls.MaterialTextBox();

         this.comboGender =
            new MaterialSkin.Controls.MaterialComboBox();

         this.txtBloodGroup =
            new MaterialSkin.Controls.MaterialTextBox();

         this.txtAddress =
            new MaterialSkin.Controls.MaterialTextBox();

         this.txtAddInfo =
            new MaterialSkin.Controls.MaterialTextBox();

         this.btnSave =
            new MaterialSkin.Controls.MaterialButton();

         this.btnCancelAddPatient =
            new MaterialSkin.Controls.MaterialButton();

         this.sidebarCard.SuspendLayout();
         this.patientListCard.SuspendLayout();
         this.addPatientCard.SuspendLayout();

         ((System.ComponentModel.ISupportInitialize)
            (this.dataGridView1)).BeginInit();

         this.SuspendLayout();

         //
         // sidebarCard
         //
         this.sidebarCard.Anchor =
            System.Windows.Forms.AnchorStyles.Top |
            System.Windows.Forms.AnchorStyles.Bottom |
            System.Windows.Forms.AnchorStyles.Left;

         this.sidebarCard.BackColor =
            System.Drawing.Color.White;

         this.sidebarCard.Controls.Add(this.lblMenu);
         this.sidebarCard.Controls.Add(this.btnPatients);
         this.sidebarCard.Controls.Add(this.btnAddPatient);
         this.sidebarCard.Controls.Add(this.btnAddDiagnosis);
         this.sidebarCard.Controls.Add(this.btnFullHistory);
         this.sidebarCard.Controls.Add(this.btnDental);
         this.sidebarCard.Controls.Add(this.btnExit);

         this.sidebarCard.Depth = 0;

         this.sidebarCard.Location =
            new System.Drawing.Point(20, 85);

         this.sidebarCard.Margin =
            new System.Windows.Forms.Padding(14);

         this.sidebarCard.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.sidebarCard.Name =
            "sidebarCard";

         this.sidebarCard.Padding =
            new System.Windows.Forms.Padding(14);

         this.sidebarCard.Size =
            new System.Drawing.Size(210, 590);

         this.sidebarCard.TabIndex = 0;

         //
         // lblMenu
         //
         this.lblMenu.AutoSize = true;
         this.lblMenu.Depth = 0;

         this.lblMenu.Font =
            new System.Drawing.Font(
               "Roboto",
               20F,
               System.Drawing.FontStyle.Bold,
               System.Drawing.GraphicsUnit.Pixel);

         this.lblMenu.Location =
            new System.Drawing.Point(24, 22);

         this.lblMenu.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.lblMenu.Name = "lblMenu";

         this.lblMenu.Size =
            new System.Drawing.Size(58, 24);

         this.lblMenu.TabIndex = 0;

         this.lblMenu.Text = "MENU";

         //
         // btnPatients
         //
         ConfigureMenuButton(
            this.btnPatients,
            "PACJENCI",
            70);

         this.btnPatients.Click +=
            new System.EventHandler(
               this.btnPatients_Click);

         //
         // btnAddPatient
         //
         ConfigureMenuButton(
            this.btnAddPatient,
            "DODAJ PACJENTA",
            125);

         this.btnAddPatient.Click +=
            new System.EventHandler(
               this.btnAddPatient_Click);

         //
         // btnAddDiagnosis
         //
         ConfigureMenuButton(
            this.btnAddDiagnosis,
            "DIAGNOZY",
            180);

         this.btnAddDiagnosis.Click +=
            new System.EventHandler(
               this.btnAddDiagnosis_Click);

         //
         // btnFullHistory
         //
         ConfigureMenuButton(
            this.btnFullHistory,
            "HISTORIA LECZENIA",
            235);

         this.btnFullHistory.Click +=
            new System.EventHandler(
               this.btnFullHistory_Click);

         //
         // btnDental
         //
         ConfigureMenuButton(
            this.btnDental,
            "GABINET",
            290);

         this.btnDental.Click +=
            new System.EventHandler(
               this.btnDental_Click);

         //
         // btnExit
         //
         this.btnExit.Anchor =
            System.Windows.Forms.AnchorStyles.Bottom |
            System.Windows.Forms.AnchorStyles.Left |
            System.Windows.Forms.AnchorStyles.Right;

         this.btnExit.AutoSize = false;

         this.btnExit.Depth = 0;

         this.btnExit.HighEmphasis = false;

         this.btnExit.Location =
            new System.Drawing.Point(20, 530);

         this.btnExit.Name =
            "btnExit";

         this.btnExit.Size =
            new System.Drawing.Size(170, 40);

         this.btnExit.TabIndex = 6;

         this.btnExit.Text =
            "WYLOGUJ";

         this.btnExit.Type =
            MaterialSkin.Controls.MaterialButton
               .MaterialButtonType.Outlined;

         this.btnExit.UseAccentColor = true;

         this.btnExit.Click +=
            new System.EventHandler(
               this.btnExit_Click);

         //
         // patientListCard
         //
         this.patientListCard.Anchor =
            System.Windows.Forms.AnchorStyles.Top |
            System.Windows.Forms.AnchorStyles.Bottom |
            System.Windows.Forms.AnchorStyles.Left |
            System.Windows.Forms.AnchorStyles.Right;

         this.patientListCard.BackColor =
            System.Drawing.Color.White;

         this.patientListCard.Controls.Add(
            this.lblPatientsList);

         this.patientListCard.Controls.Add(
            this.lblPatientsSubtitle);

         this.patientListCard.Controls.Add(
            this.dataGridView1);

         this.patientListCard.Depth = 0;

         this.patientListCard.Location =
            new System.Drawing.Point(250, 85);

         this.patientListCard.Margin =
            new System.Windows.Forms.Padding(14);

         this.patientListCard.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.patientListCard.Name =
            "patientListCard";

         this.patientListCard.Padding =
            new System.Windows.Forms.Padding(24);

         this.patientListCard.Size =
            new System.Drawing.Size(910, 590);

         this.patientListCard.TabIndex = 1;

         //
         // lblPatientsList
         //
         this.lblPatientsList.AutoSize = true;

         this.lblPatientsList.Depth = 0;

         this.lblPatientsList.Font =
            new System.Drawing.Font(
               "Roboto",
               20F,
               System.Drawing.FontStyle.Bold,
               System.Drawing.GraphicsUnit.Pixel);

         this.lblPatientsList.Location =
            new System.Drawing.Point(30, 24);

         this.lblPatientsList.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.lblPatientsList.Name =
            "lblPatientsList";

         this.lblPatientsList.Size =
            new System.Drawing.Size(145, 24);

         this.lblPatientsList.TabIndex = 0;

         this.lblPatientsList.Text =
            "Lista pacjentów";

         //
         // lblPatientsSubtitle
         //
         this.lblPatientsSubtitle.AutoSize = true;

         this.lblPatientsSubtitle.Depth = 0;

         this.lblPatientsSubtitle.Font =
            new System.Drawing.Font(
               "Roboto",
               14F,
               System.Drawing.FontStyle.Regular,
               System.Drawing.GraphicsUnit.Pixel);

         this.lblPatientsSubtitle.Location =
            new System.Drawing.Point(30, 55);

         this.lblPatientsSubtitle.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.lblPatientsSubtitle.Name =
            "lblPatientsSubtitle";

         this.lblPatientsSubtitle.Size =
            new System.Drawing.Size(243, 19);

         this.lblPatientsSubtitle.TabIndex = 1;

         this.lblPatientsSubtitle.Text =
            "Pacjenci zarejestrowani w systemie";

         //
         // dataGridView1
         //
         this.dataGridView1.AllowUserToAddRows = false;

         this.dataGridView1.AllowUserToDeleteRows = false;

         this.dataGridView1.AllowUserToResizeRows = false;

         this.dataGridView1.Anchor =
            System.Windows.Forms.AnchorStyles.Top |
            System.Windows.Forms.AnchorStyles.Bottom |
            System.Windows.Forms.AnchorStyles.Left |
            System.Windows.Forms.AnchorStyles.Right;

         this.dataGridView1.AutoSizeColumnsMode =
            System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

         this.dataGridView1.BackgroundColor =
            System.Drawing.Color.White;

         this.dataGridView1.BorderStyle =
            System.Windows.Forms.BorderStyle.None;

         this.dataGridView1.CellBorderStyle =
            System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

         this.dataGridView1.ColumnHeadersBorderStyle =
            System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

         this.dataGridView1.ColumnHeadersHeight = 42;

         this.dataGridView1.EnableHeadersVisualStyles =
            false;

         this.dataGridView1.Location =
            new System.Drawing.Point(30, 95);

         this.dataGridView1.MultiSelect = false;

         this.dataGridView1.Name =
            "dataGridView1";

         this.dataGridView1.ReadOnly = true;

         this.dataGridView1.RowHeadersVisible = false;

         this.dataGridView1.RowTemplate.Height = 36;

         this.dataGridView1.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

         this.dataGridView1.Size =
            new System.Drawing.Size(850, 455);

         this.dataGridView1.TabIndex = 2;

         //
         // addPatientCard
         //
         this.addPatientCard.Anchor =
            System.Windows.Forms.AnchorStyles.Top |
            System.Windows.Forms.AnchorStyles.Bottom |
            System.Windows.Forms.AnchorStyles.Left |
            System.Windows.Forms.AnchorStyles.Right;

         this.addPatientCard.BackColor =
            System.Drawing.Color.White;

         this.addPatientCard.Controls.Add(
            this.lblAddPatient);

         this.addPatientCard.Controls.Add(
            this.lblAddPatientSubtitle);

         this.addPatientCard.Controls.Add(
            this.txtName);

         this.addPatientCard.Controls.Add(
            this.txtSurname);

         this.addPatientCard.Controls.Add(
            this.txtPhone);

         this.addPatientCard.Controls.Add(
            this.txtAge);

         this.addPatientCard.Controls.Add(
            this.comboGender);

         this.addPatientCard.Controls.Add(
            this.txtBloodGroup);

         this.addPatientCard.Controls.Add(
            this.txtAddress);

         this.addPatientCard.Controls.Add(
            this.txtAddInfo);

         this.addPatientCard.Controls.Add(
            this.btnSave);

         this.addPatientCard.Controls.Add(
            this.btnCancelAddPatient);

         this.addPatientCard.Depth = 0;

         this.addPatientCard.Location =
            new System.Drawing.Point(250, 85);

         this.addPatientCard.Margin =
            new System.Windows.Forms.Padding(14);

         this.addPatientCard.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.addPatientCard.Name =
            "addPatientCard";

         this.addPatientCard.Padding =
            new System.Windows.Forms.Padding(24);

         this.addPatientCard.Size =
            new System.Drawing.Size(910, 590);

         this.addPatientCard.TabIndex = 2;

         //
         // lblAddPatient
         //
         this.lblAddPatient.AutoSize = true;

         this.lblAddPatient.Depth = 0;

         this.lblAddPatient.Font =
            new System.Drawing.Font(
               "Roboto",
               20F,
               System.Drawing.FontStyle.Bold,
               System.Drawing.GraphicsUnit.Pixel);

         this.lblAddPatient.Location =
            new System.Drawing.Point(30, 24);

         this.lblAddPatient.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.lblAddPatient.Name =
            "lblAddPatient";

         this.lblAddPatient.Size =
            new System.Drawing.Size(134, 24);

         this.lblAddPatient.TabIndex = 0;

         this.lblAddPatient.Text =
            "Dodaj pacjenta";

         //
         // lblAddPatientSubtitle
         //
         this.lblAddPatientSubtitle.AutoSize = true;

         this.lblAddPatientSubtitle.Depth = 0;

         this.lblAddPatientSubtitle.Font =
            new System.Drawing.Font(
               "Roboto",
               14F,
               System.Drawing.FontStyle.Regular,
               System.Drawing.GraphicsUnit.Pixel);

         this.lblAddPatientSubtitle.Location =
            new System.Drawing.Point(30, 55);

         this.lblAddPatientSubtitle.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.lblAddPatientSubtitle.Name =
            "lblAddPatientSubtitle";

         this.lblAddPatientSubtitle.Size =
            new System.Drawing.Size(230, 19);

         this.lblAddPatientSubtitle.TabIndex = 1;

         this.lblAddPatientSubtitle.Text =
            "Wprowadź dane nowego pacjenta";

         //
         // txtName
         //
         ConfigureTextBox(
            this.txtName,
            "Imię",
            30,
            105);

         //
         // txtSurname
         //
         ConfigureTextBox(
            this.txtSurname,
            "Nazwisko",
            340,
            105);

         //
         // txtPhone
         //
         ConfigureTextBox(
            this.txtPhone,
            "Telefon",
            30,
            180);

         //
         // txtAge
         //
         ConfigureTextBox(
            this.txtAge,
            "Wiek",
            340,
            180);

         //
         // comboGender
         //
         this.comboGender.AutoResize = false;

         this.comboGender.Depth = 0;

         this.comboGender.DrawMode =
            System.Windows.Forms.DrawMode.OwnerDrawVariable;

         this.comboGender.DropDownStyle =
            System.Windows.Forms.ComboBoxStyle.DropDownList;

         this.comboGender.FormattingEnabled = true;

         this.comboGender.Hint = "Płeć";

         this.comboGender.Items.AddRange(
            new object[]
            {
               "Kobieta",
               "Mężczyzna",
               "Inna"
            });

         this.comboGender.Location =
            new System.Drawing.Point(30, 255);

         this.comboGender.Name =
            "comboGender";

         this.comboGender.Size =
            new System.Drawing.Size(270, 49);

         this.comboGender.TabIndex = 6;

         //
         // txtBloodGroup
         //
         ConfigureTextBox(
            this.txtBloodGroup,
            "Grupa krwi",
            340,
            255);

         //
         // txtAddress
         //
         ConfigureTextBox(
            this.txtAddress,
            "Adres",
            30,
            330);

         this.txtAddress.Size =
            new System.Drawing.Size(580, 50);

         //
         // txtAddInfo
         //
         ConfigureTextBox(
            this.txtAddInfo,
            "Informacje medyczne / diagnoza",
            30,
            405);

         this.txtAddInfo.Size =
            new System.Drawing.Size(580, 50);

         //
         // btnSave
         //
         this.btnSave.AutoSize = false;
         this.btnSave.Depth = 0;
         this.btnSave.HighEmphasis = true;

         this.btnSave.Location =
            new System.Drawing.Point(30, 495);

         this.btnSave.Name =
            "btnSave";

         this.btnSave.Size =
            new System.Drawing.Size(150, 42);

         this.btnSave.TabIndex = 10;

         this.btnSave.Text =
            "ZAPISZ";

         this.btnSave.Type =
            MaterialSkin.Controls.MaterialButton
               .MaterialButtonType.Contained;

         this.btnSave.Click +=
            new System.EventHandler(
               this.btnSave_Click);

         //
         // btnCancelAddPatient
         //
         this.btnCancelAddPatient.AutoSize = false;

         this.btnCancelAddPatient.Depth = 0;

         this.btnCancelAddPatient.HighEmphasis = false;

         this.btnCancelAddPatient.Location =
            new System.Drawing.Point(195, 495);

         this.btnCancelAddPatient.Name =
            "btnCancelAddPatient";

         this.btnCancelAddPatient.Size =
            new System.Drawing.Size(150, 42);

         this.btnCancelAddPatient.TabIndex = 11;

         this.btnCancelAddPatient.Text =
            "ANULUJ";

         this.btnCancelAddPatient.Type =
            MaterialSkin.Controls.MaterialButton
               .MaterialButtonType.Outlined;

         this.btnCancelAddPatient.Click +=
            new System.EventHandler(
               this.btnCancelAddPatient_Click);

         //
         // Dashboard
         //
         this.AutoScaleDimensions =
            new System.Drawing.SizeF(6F, 13F);

         this.AutoScaleMode =
            System.Windows.Forms.AutoScaleMode.Font;

         this.ClientSize =
            new System.Drawing.Size(1180, 700);

         this.Controls.Add(this.addPatientCard);
         this.Controls.Add(this.patientListCard);
         this.Controls.Add(this.sidebarCard);

         this.MinimumSize =
            new System.Drawing.Size(1000, 650);

         this.Name =
            "Dashboard";

         this.Text =
            "DMS - Panel pracownika";

         this.Load +=
            new System.EventHandler(
               this.Dashboard_Load);

         this.sidebarCard.ResumeLayout(false);
         this.sidebarCard.PerformLayout();

         this.patientListCard.ResumeLayout(false);
         this.patientListCard.PerformLayout();

         this.addPatientCard.ResumeLayout(false);
         this.addPatientCard.PerformLayout();

         ((System.ComponentModel.ISupportInitialize)
            (this.dataGridView1)).EndInit();

         this.ResumeLayout(false);
      }

      private void ConfigureMenuButton(
         MaterialSkin.Controls.MaterialButton button,
         string text,
         int top)
      {
         button.AutoSize = false;

         button.Depth = 0;

         button.HighEmphasis = false;

         button.Location =
            new System.Drawing.Point(20, top);

         button.Name =
            "btn" + text.Replace(" ", "");

         button.Size =
            new System.Drawing.Size(170, 40);

         button.Text = text;

         button.Type =
            MaterialSkin.Controls.MaterialButton
               .MaterialButtonType.Text;

         button.UseAccentColor = false;
      }

      private void ConfigureTextBox(
         MaterialSkin.Controls.MaterialTextBox textBox,
         string hint,
         int left,
         int top)
      {
         textBox.AnimateReadOnly = false;

         textBox.BorderStyle =
            System.Windows.Forms.BorderStyle.None;

         textBox.Depth = 0;

         textBox.Hint = hint;

         textBox.Location =
            new System.Drawing.Point(left, top);

         textBox.MaxLength = 100;

         textBox.MouseState =
            MaterialSkin.MouseState.OUT;

         textBox.Multiline = false;

         textBox.Size =
            new System.Drawing.Size(270, 50);

         textBox.Text = "";
      }

      #endregion

      private MaterialSkin.Controls.MaterialCard sidebarCard;
      private MaterialSkin.Controls.MaterialLabel lblMenu;

      private MaterialSkin.Controls.MaterialButton btnPatients;
      private MaterialSkin.Controls.MaterialButton btnAddPatient;
      private MaterialSkin.Controls.MaterialButton btnAddDiagnosis;
      private MaterialSkin.Controls.MaterialButton btnFullHistory;
      private MaterialSkin.Controls.MaterialButton btnDental;
      private MaterialSkin.Controls.MaterialButton btnExit;

      private MaterialSkin.Controls.MaterialCard patientListCard;

      private MaterialSkin.Controls.MaterialLabel lblPatientsList;
      private MaterialSkin.Controls.MaterialLabel lblPatientsSubtitle;

      private System.Windows.Forms.DataGridView dataGridView1;

      private MaterialSkin.Controls.MaterialCard addPatientCard;

      private MaterialSkin.Controls.MaterialLabel lblAddPatient;
      private MaterialSkin.Controls.MaterialLabel lblAddPatientSubtitle;

      private MaterialSkin.Controls.MaterialTextBox txtName;
      private MaterialSkin.Controls.MaterialTextBox txtSurname;
      private MaterialSkin.Controls.MaterialTextBox txtPhone;
      private MaterialSkin.Controls.MaterialTextBox txtAge;
      private MaterialSkin.Controls.MaterialComboBox comboGender;
      private MaterialSkin.Controls.MaterialTextBox txtBloodGroup;
      private MaterialSkin.Controls.MaterialTextBox txtAddress;
      private MaterialSkin.Controls.MaterialTextBox txtAddInfo;

      private MaterialSkin.Controls.MaterialButton btnSave;
      private MaterialSkin.Controls.MaterialButton btnCancelAddPatient;
   }
}