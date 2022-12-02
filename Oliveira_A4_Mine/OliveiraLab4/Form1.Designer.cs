namespace OliveiraLab4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.grpSelectLocation = new System.Windows.Forms.GroupBox();
            this.radMexico = new System.Windows.Forms.RadioButton();
            this.radCuba = new System.Windows.Forms.RadioButton();
            this.chkFlightIncluded = new System.Windows.Forms.CheckBox();
            this.radFlorida = new System.Windows.Forms.RadioButton();
            this.lblPriceOutput = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCreditCard = new System.Windows.Forms.RadioButton();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.grpTripInformation = new System.Windows.Forms.GroupBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpBook.SuspendLayout();
            this.grpSelectLocation.SuspendLayout();
            this.grpTripInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.grpSelectLocation);
            this.grpBook.Controls.Add(this.lblPriceOutput);
            this.grpBook.Controls.Add(this.btnBook);
            this.grpBook.Controls.Add(this.btnReset);
            this.grpBook.Controls.Add(this.lblPrice);
            this.grpBook.Controls.Add(this.radCash);
            this.grpBook.Controls.Add(this.radCreditCard);
            this.grpBook.Controls.Add(this.txtPeople);
            this.grpBook.Controls.Add(this.lblPeople);
            this.grpBook.Location = new System.Drawing.Point(13, 13);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(200, 311);
            this.grpBook.TabIndex = 0;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // grpSelectLocation
            // 
            this.grpSelectLocation.BackColor = System.Drawing.Color.LightSalmon;
            this.grpSelectLocation.Controls.Add(this.radMexico);
            this.grpSelectLocation.Controls.Add(this.radCuba);
            this.grpSelectLocation.Controls.Add(this.chkFlightIncluded);
            this.grpSelectLocation.Controls.Add(this.radFlorida);
            this.grpSelectLocation.Location = new System.Drawing.Point(6, 58);
            this.grpSelectLocation.Name = "grpSelectLocation";
            this.grpSelectLocation.Size = new System.Drawing.Size(188, 132);
            this.grpSelectLocation.TabIndex = 2;
            this.grpSelectLocation.TabStop = false;
            this.grpSelectLocation.Text = "Select Location";
            // 
            // radMexico
            // 
            this.radMexico.AutoSize = true;
            this.radMexico.BackColor = System.Drawing.Color.LightSalmon;
            this.radMexico.Location = new System.Drawing.Point(6, 79);
            this.radMexico.Name = "radMexico";
            this.radMexico.Size = new System.Drawing.Size(71, 19);
            this.radMexico.TabIndex = 4;
            this.radMexico.TabStop = true;
            this.radMexico.Text = "Mexico";
            this.radMexico.UseVisualStyleBackColor = false;
            this.radMexico.CheckedChanged += new System.EventHandler(this.radMexico_CheckedChanged);
            // 
            // radCuba
            // 
            this.radCuba.AutoSize = true;
            this.radCuba.BackColor = System.Drawing.Color.LightSalmon;
            this.radCuba.Location = new System.Drawing.Point(6, 29);
            this.radCuba.Name = "radCuba";
            this.radCuba.Size = new System.Drawing.Size(59, 19);
            this.radCuba.TabIndex = 2;
            this.radCuba.TabStop = true;
            this.radCuba.Text = "Cuba";
            this.radCuba.UseVisualStyleBackColor = false;
            this.radCuba.CheckedChanged += new System.EventHandler(this.radCuba_CheckedChanged);
            // 
            // chkFlightIncluded
            // 
            this.chkFlightIncluded.AutoSize = true;
            this.chkFlightIncluded.BackColor = System.Drawing.Color.LightSalmon;
            this.chkFlightIncluded.Enabled = false;
            this.chkFlightIncluded.Location = new System.Drawing.Point(6, 104);
            this.chkFlightIncluded.Name = "chkFlightIncluded";
            this.chkFlightIncluded.Size = new System.Drawing.Size(122, 19);
            this.chkFlightIncluded.TabIndex = 5;
            this.chkFlightIncluded.Text = "Flight Included";
            this.chkFlightIncluded.UseVisualStyleBackColor = false;
            // 
            // radFlorida
            // 
            this.radFlorida.AutoSize = true;
            this.radFlorida.BackColor = System.Drawing.Color.LightSalmon;
            this.radFlorida.Location = new System.Drawing.Point(6, 54);
            this.radFlorida.Name = "radFlorida";
            this.radFlorida.Size = new System.Drawing.Size(71, 19);
            this.radFlorida.TabIndex = 3;
            this.radFlorida.TabStop = true;
            this.radFlorida.Text = "Florida";
            this.radFlorida.UseVisualStyleBackColor = false;
            this.radFlorida.CheckedChanged += new System.EventHandler(this.radFlorida_CheckedChanged);
            // 
            // lblPriceOutput
            // 
            this.lblPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPriceOutput.Location = new System.Drawing.Point(60, 248);
            this.lblPriceOutput.Name = "lblPriceOutput";
            this.lblPriceOutput.Size = new System.Drawing.Size(134, 17);
            this.lblPriceOutput.TabIndex = 10;
            this.lblPriceOutput.Text = "\r\n";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(92, 282);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 6;
            this.btnBook.Text = "&Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(10, 282);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(7, 248);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 15);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(7, 222);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(58, 19);
            this.radCash.TabIndex = 4;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radCreditCard
            // 
            this.radCreditCard.AutoSize = true;
            this.radCreditCard.Location = new System.Drawing.Point(7, 196);
            this.radCreditCard.Name = "radCreditCard";
            this.radCreditCard.Size = new System.Drawing.Size(101, 19);
            this.radCreditCard.TabIndex = 3;
            this.radCreditCard.TabStop = true;
            this.radCreditCard.Text = "Credit Card";
            this.radCreditCard.UseVisualStyleBackColor = true;
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(70, 23);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(100, 23);
            this.txtPeople.TabIndex = 1;
            this.txtPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Location = new System.Drawing.Point(7, 23);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(56, 15);
            this.lblPeople.TabIndex = 0;
            this.lblPeople.Text = "People:";
            // 
            // grpTripInformation
            // 
            this.grpTripInformation.Controls.Add(this.lblDisplay);
            this.grpTripInformation.Controls.Add(this.btnConfirm);
            this.grpTripInformation.Location = new System.Drawing.Point(220, 13);
            this.grpTripInformation.Name = "grpTripInformation";
            this.grpTripInformation.Size = new System.Drawing.Size(234, 311);
            this.grpTripInformation.TabIndex = 1;
            this.grpTripInformation.TabStop = false;
            this.grpTripInformation.Text = "Trip Information";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Pink;
            this.lblDisplay.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDisplay.Location = new System.Drawing.Point(7, 23);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(221, 242);
            this.lblDisplay.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(81, 282);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(494, 336);
            this.Controls.Add(this.grpTripInformation);
            this.Controls.Add(this.grpBook);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking by Daniel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpSelectLocation.ResumeLayout(false);
            this.grpSelectLocation.PerformLayout();
            this.grpTripInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radCreditCard;
        private System.Windows.Forms.CheckBox chkFlightIncluded;
        private System.Windows.Forms.RadioButton radMexico;
        private System.Windows.Forms.RadioButton radFlorida;
        private System.Windows.Forms.RadioButton radCuba;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.GroupBox grpTripInformation;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblPriceOutput;
        private System.Windows.Forms.GroupBox grpSelectLocation;
    }
}

