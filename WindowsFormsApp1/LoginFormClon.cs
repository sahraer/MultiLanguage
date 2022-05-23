using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Globalization;
using System.Threading;
using System.Resources;

namespace RetmindWms.Presentation.DesktopApplication.Forms
{
    public partial class LoginFormClon : Form
    {
        public LoginFormClon()
        {
            InitializeComponent();
        }

        private void LoginFormClon_Load(object sender, EventArgs e)
        {
            languageData.ReadXml(string.Format("{0}/data.xml", System.Windows.Forms.Application.StartupPath));
            comboBox1.Items.Add("en-US");
            comboBox1.Items.Add("tr-TR");
            comboBox1.Items.Add("de-DE");
            comboBox1.Items.Add("fr-FR");

        }

       private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        public void ValueForLanguageSelection(string languageselected)
        {


            CultureInfo cultureInfo = new CultureInfo(languageselected);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            ResourceManager rm = ResourceManager.CreateFileBasedResourceManager("resource", Application.StartupPath, null);



            if (rm.GetString("bsı_SelectLanguage") != null && rm.GetString("ribbonGroupPage_LanguageSettings") != null)
            {
                btn_SelectLanguage.Caption = rm.GetString("bsı_SelectLanguage");
                ribbonGroupPage_LanguageSettings.Text = rm.GetString("ribbonGroupPage_LanguageSettings");
                rp_settings.Text = rm.GetString("rp_settings");
                rp_reports.Text = rm.GetString("rp_reports");
                rp_users.Text = rm.GetString("rp_users");
                rp_supports.Text = rm.GetString("rp_supports");
                rp_CustomerRepresentative.Text = rm.GetString("rp_CustomerRepresentative");
                rp_RetailReturns.Text = rm.GetString("rp_RetailReturns");
                rp_Definitions.Text = rm.GetString("rp_Definitions");
                rp_Shelves.Text = rm.GetString("rp_Shelves");
                rp_Transactions.Text = rm.GetString("rp_Transactions");
                rp_Dispatch.Text = rm.GetString("rp_Dispatch");
                rp_Acceptance.Text = rm.GetString("rp_Acceptance");
                btn_LanguageDataAdd.Caption = rm.GetString("btn_LanguageDataAdd");

                //buttons
                btn_AddressDistributionWizard.Caption = rm.GetString("btn_AddressDistributionWizard");
                btn_RepositoryDeploymentWizard.Caption = rm.GetString("btn_RepositoryDeploymentWizard");
                btn_MerchandiseReceptionRacks.Caption = rm.GetString("btn_MerchandiseReceptionRacks");
                btn_ExcelSerialNumber.Caption = rm.GetString("btn_ExcelSerialNumber");
                btn_ReceiptOfMerchandise.Caption = rm.GetString("btn_ReceiptOfMerchandise");
                btn_CreateWaybill.Caption = rm.GetString("btn_CreateWaybill");
                btn_ReturnFromCustomer.Caption = rm.GetString("btn_ReturnFromCustomer");
                btn_ReturnFromDealer.Caption = rm.GetString("btn_ReturnFromDealer");
                btn_ReadToOrder.Caption = rm.GetString("btn_ReadToOrder");
                btn_ConfirmStoreReturnSlip.Caption = rm.GetString("btn_ConfirmStoreReturnSlip");
                btn_RFIDAccept.Caption = rm.GetString("btn_RFIDAccept");
                btn_FlowThruWarrent.Caption = rm.GetString("btn_FlowThruWarrent");

                //button group
                ribbonPageGroup_MerchandiseAcceptanceOrder.Text = rm.GetString("ribbonPageGroup_MerchandiseAcceptanceOrder");
                ribbonPageGroup_ReceiptOfMerchandise.Text = rm.GetString("ribbonPageGroup_ReceiptOfMerchandise");
                ribbonPageGroup_ReturnProcedures.Text = rm.GetString("ribbonPageGroup_ReturnProcedures");
                ribbonGroupPage_FlowThru.Text = rm.GetString("ribbonGroupPage_FlowThru");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            var selected = comboBox1.SelectedItem;
            CultureInfo cultureInfo = new CultureInfo(selected.ToString());
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            ResourceManager rm = ResourceManager.CreateFileBasedResourceManager("resource", System.Windows.Forms.Application.StartupPath, null);
            if (rm.GetString("lbl_Username") != null && rm.GetString("lbl_Password") != null && btnLogin.Text != null && btnClose.Text != null)
            {
                lbl_Username.Text = rm.GetString("lbl_Username");
                lbl_Password.Text = rm.GetString("lbl_Password");
                btnLogin.Text = rm.GetString("btn_Login");
                btnClose.Text = rm.GetString("btn_Close");
                lbl_WelcomeText.Text = rm.GetString("lbl_WelcomeText");
               
            }
        }

        private void LoginFormClon_Load_1(object sender, EventArgs e)
        {

        }
    }
}
