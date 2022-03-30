
namespace bitc0in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyMenu = new System.Windows.Forms.ComboBox();
            this.getRateBtn = new System.Windows.Forms.Button();
            this.amountOfBtc = new System.Windows.Forms.TextBox();
            this.vault = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyMenu
            // 
            this.currencyMenu.FormattingEnabled = true;
            this.currencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.currencyMenu.Location = new System.Drawing.Point(42, 33);
            this.currencyMenu.Name = "currencyMenu";
            this.currencyMenu.Size = new System.Drawing.Size(121, 24);
            this.currencyMenu.TabIndex = 0;
            this.currencyMenu.Text = "Select Currency";
            // 
            // getRateBtn
            // 
            this.getRateBtn.Location = new System.Drawing.Point(219, 82);
            this.getRateBtn.Name = "getRateBtn";
            this.getRateBtn.Size = new System.Drawing.Size(75, 23);
            this.getRateBtn.TabIndex = 1;
            this.getRateBtn.Text = "GetRates";
            this.getRateBtn.UseVisualStyleBackColor = true;
            this.getRateBtn.Click += new System.EventHandler(this.getRateBtn_Click);
            // 
            // amountOfBtc
            // 
            this.amountOfBtc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.amountOfBtc.Location = new System.Drawing.Point(42, 83);
            this.amountOfBtc.Name = "amountOfBtc";
            this.amountOfBtc.Size = new System.Drawing.Size(121, 22);
            this.amountOfBtc.TabIndex = 2;
            // 
            // vault
            // 
            this.vault.Location = new System.Drawing.Point(42, 204);
            this.vault.Name = "vault";
            this.vault.Size = new System.Drawing.Size(100, 22);
            this.vault.TabIndex = 3;
            this.vault.Visible = false;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(48, 171);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(48, 17);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "Result";
            this.resultLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 391);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.vault);
            this.Controls.Add(this.amountOfBtc);
            this.Controls.Add(this.getRateBtn);
            this.Controls.Add(this.currencyMenu);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyMenu;
        private System.Windows.Forms.Button getRateBtn;
        private System.Windows.Forms.TextBox amountOfBtc;
        private System.Windows.Forms.TextBox vault;
        private System.Windows.Forms.Label resultLbl;
    }
}

