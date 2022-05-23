
namespace RetmindWms.Presentation.DesktopApplication.Forms
{
    partial class LoginFormClon
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
            this.SuspendLayout();
            // 
            // LoginFormClon
            // 
            this.ClientSize = new System.Drawing.Size(887, 369);
            this.Name = "LoginFormClon";
            this.Load += new System.EventHandler(this.LoginFormClon_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.ComboBox comboBox1;
        private LanguageData languageData;
        private System.Windows.Forms.Label lbl_WelcomeText;
    }
}