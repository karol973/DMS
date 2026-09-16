namespace DMS
{
   partial class MainForm
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
         this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
         this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
         this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
         this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
         this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
         this.txtUserName = new MaterialSkin.Controls.MaterialTextBox();
         this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
         this.btnLogin = new MaterialSkin.Controls.MaterialButton();

         this.materialCard1.SuspendLayout();
         this.SuspendLayout();

         // 
         // materialCard1
         // 
         this.materialCard1.BackColor =
            System.Drawing.Color.FromArgb(255, 255, 255);

         this.materialCard1.Controls.Add(this.materialLabel1);
         this.materialCard1.Controls.Add(this.materialLabel2);
         this.materialCard1.Controls.Add(this.materialLabel3);
         this.materialCard1.Controls.Add(this.txtUserName);
         this.materialCard1.Controls.Add(this.materialLabel4);
         this.materialCard1.Controls.Add(this.txtPassword);
         this.materialCard1.Controls.Add(this.btnLogin);

         this.materialCard1.Depth = 0;

         this.materialCard1.ForeColor =
            System.Drawing.Color.FromArgb(222, 0, 0, 0);

         this.materialCard1.Location =
            new System.Drawing.Point(220, 120);

         this.materialCard1.Margin =
            new System.Windows.Forms.Padding(14);

         this.materialCard1.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.materialCard1.Name = "materialCard1";

         this.materialCard1.Padding =
            new System.Windows.Forms.Padding(24);

         this.materialCard1.Size =
            new System.Drawing.Size(460, 330);

         this.materialCard1.TabIndex = 0;

         // 
         // materialLabel1
         // 
         this.materialLabel1.AutoSize = true;
         this.materialLabel1.Depth = 0;

         this.materialLabel1.Font =
            new System.Drawing.Font(
               "Roboto",
               20F,
               System.Drawing.FontStyle.Bold,
               System.Drawing.GraphicsUnit.Pixel);

         this.materialLabel1.Location =
            new System.Drawing.Point(185, 24);

         this.materialLabel1.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.materialLabel1.Name = "materialLabel1";
         this.materialLabel1.Size =
            new System.Drawing.Size(90, 24);

         this.materialLabel1.TabIndex = 0;
         this.materialLabel1.Text = "Logowanie";

         // 
         // materialLabel2
         // 
         this.materialLabel2.AutoSize = true;
         this.materialLabel2.Depth = 0;

         this.materialLabel2.Font =
            new System.Drawing.Font(
               "Roboto",
               14F,
               System.Drawing.FontStyle.Regular,
               System.Drawing.GraphicsUnit.Pixel);

         this.materialLabel2.Location =
            new System.Drawing.Point(165, 58);

         this.materialLabel2.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.materialLabel2.Name = "materialLabel2";
         this.materialLabel2.Size =
            new System.Drawing.Size(127, 19);

         this.materialLabel2.TabIndex = 1;
         this.materialLabel2.Text = "Panel pracownika";

         // 
         // materialLabel3
         // 
         this.materialLabel3.AutoSize = true;
         this.materialLabel3.Depth = 0;

         this.materialLabel3.Font =
            new System.Drawing.Font(
               "Roboto",
               14F,
               System.Drawing.FontStyle.Regular,
               System.Drawing.GraphicsUnit.Pixel);

         this.materialLabel3.Location =
            new System.Drawing.Point(50, 100);

         this.materialLabel3.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.materialLabel3.Name = "materialLabel3";
         this.materialLabel3.Size =
            new System.Drawing.Size(143, 19);

         this.materialLabel3.TabIndex = 2;
         this.materialLabel3.Text = "Nazwa użytkownika";

         // 
         // txtUserName
         // 
         this.txtUserName.AnimateReadOnly = false;
         this.txtUserName.BorderStyle =
            System.Windows.Forms.BorderStyle.None;

         this.txtUserName.Depth = 0;

         this.txtUserName.Font =
            new System.Drawing.Font(
               "Roboto",
               16F,
               System.Drawing.FontStyle.Regular,
               System.Drawing.GraphicsUnit.Pixel);

         this.txtUserName.LeadingIcon = null;

         this.txtUserName.Location =
            new System.Drawing.Point(50, 125);

         this.txtUserName.MaxLength = 100;

         this.txtUserName.MouseState =
            MaterialSkin.MouseState.OUT;

         this.txtUserName.Multiline = false;

         this.txtUserName.Name = "txtUserName";

         this.txtUserName.Size =
            new System.Drawing.Size(360, 50);

         this.txtUserName.TabIndex = 3;

         this.txtUserName.Text = "";

         this.txtUserName.TrailingIcon = null;

         // 
         // materialLabel4
         // 
         this.materialLabel4.AutoSize = true;
         this.materialLabel4.Depth = 0;

         this.materialLabel4.Font =
            new System.Drawing.Font(
               "Roboto",
               14F,
               System.Drawing.FontStyle.Regular,
               System.Drawing.GraphicsUnit.Pixel);

         this.materialLabel4.Location =
            new System.Drawing.Point(50, 190);

         this.materialLabel4.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.materialLabel4.Name = "materialLabel4";

         this.materialLabel4.Size =
            new System.Drawing.Size(42, 19);

         this.materialLabel4.TabIndex = 4;

         this.materialLabel4.Text = "Hasło";

         // 
         // txtPassword
         // 
         this.txtPassword.AnimateReadOnly = false;

         this.txtPassword.BorderStyle =
            System.Windows.Forms.BorderStyle.None;

         this.txtPassword.Depth = 0;

         this.txtPassword.Font =
            new System.Drawing.Font(
               "Roboto",
               16F,
               System.Drawing.FontStyle.Regular,
               System.Drawing.GraphicsUnit.Pixel);

         this.txtPassword.LeadingIcon = null;

         this.txtPassword.Location =
            new System.Drawing.Point(50, 215);

         this.txtPassword.MaxLength = 100;

         this.txtPassword.MouseState =
            MaterialSkin.MouseState.OUT;

         this.txtPassword.Multiline = false;

         this.txtPassword.Name = "txtPassword";

         this.txtPassword.Password = true;

         this.txtPassword.Size =
            new System.Drawing.Size(360, 50);

         this.txtPassword.TabIndex = 5;

         this.txtPassword.Text = "";

         this.txtPassword.TrailingIcon = null;

         // 
         // btnLogin
         // 
         this.btnLogin.AutoSizeMode =
            System.Windows.Forms.AutoSizeMode.GrowAndShrink;

         this.btnLogin.Density =
            MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;

         this.btnLogin.Depth = 0;

         this.btnLogin.HighEmphasis = true;

         this.btnLogin.Icon = null;

         this.btnLogin.Location =
            new System.Drawing.Point(179, 283);

         this.btnLogin.Margin =
            new System.Windows.Forms.Padding(4, 6, 4, 6);

         this.btnLogin.MouseState =
            MaterialSkin.MouseState.HOVER;

         this.btnLogin.Name = "btnLogin";

         this.btnLogin.NoAccentTextColor =
            System.Drawing.Color.Empty;

         this.btnLogin.Size =
            new System.Drawing.Size(102, 36);

         this.btnLogin.TabIndex = 6;

         this.btnLogin.Text = "Zaloguj się";

         this.btnLogin.Type =
            MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;

         this.btnLogin.UseAccentColor = false;

         this.btnLogin.UseVisualStyleBackColor = true;

         this.btnLogin.Click +=
            new System.EventHandler(this.btnLogin_Click);

         // 
         // MainForm
         // 
         this.AutoScaleDimensions =
            new System.Drawing.SizeF(6F, 13F);

         this.AutoScaleMode =
            System.Windows.Forms.AutoScaleMode.Font;

         this.ClientSize =
            new System.Drawing.Size(900, 560);

         this.Controls.Add(this.materialCard1);

         this.MinimumSize =
            new System.Drawing.Size(760, 520);

         this.Name = "MainForm";

         this.Text = "Dental Management";

         this.materialCard1.ResumeLayout(false);
         this.materialCard1.PerformLayout();

         this.ResumeLayout(false);
      }

      #endregion

      private MaterialSkin.Controls.MaterialCard materialCard1;

      private MaterialSkin.Controls.MaterialLabel materialLabel1;
      private MaterialSkin.Controls.MaterialLabel materialLabel2;
      private MaterialSkin.Controls.MaterialLabel materialLabel3;
      private MaterialSkin.Controls.MaterialLabel materialLabel4;

      private MaterialSkin.Controls.MaterialTextBox txtUserName;
      private MaterialSkin.Controls.MaterialTextBox txtPassword;

      private MaterialSkin.Controls.MaterialButton btnLogin;
   }
}