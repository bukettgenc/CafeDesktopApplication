
namespace CafeApp
{
    partial class Table
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orders = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxDrinks = new System.Windows.Forms.ListBox();
            this.listBoxSoups = new System.Windows.Forms.ListBox();
            this.listBoxPizzas = new System.Windows.Forms.ListBox();
            this.listBoxDessert = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "İçecekler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tatlılar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Çorbalar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pizzalar";
            // 
            // orders
            // 
            this.orders.FormattingEnabled = true;
            this.orders.Location = new System.Drawing.Point(586, 96);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(160, 225);
            this.orders.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Siparişler";
            // 
            // listBoxDrinks
            // 
            this.listBoxDrinks.FormattingEnabled = true;
            this.listBoxDrinks.Location = new System.Drawing.Point(52, 96);
            this.listBoxDrinks.Name = "listBoxDrinks";
            this.listBoxDrinks.Size = new System.Drawing.Size(162, 264);
            this.listBoxDrinks.TabIndex = 11;
            // 
            // listBoxSoups
            // 
            this.listBoxSoups.FormattingEnabled = true;
            this.listBoxSoups.Location = new System.Drawing.Point(230, 259);
            this.listBoxSoups.Name = "listBoxSoups";
            this.listBoxSoups.Size = new System.Drawing.Size(156, 147);
            this.listBoxSoups.TabIndex = 12;
            // 
            // listBoxPizzas
            // 
            this.listBoxPizzas.FormattingEnabled = true;
            this.listBoxPizzas.Location = new System.Drawing.Point(406, 96);
            this.listBoxPizzas.Name = "listBoxPizzas";
            this.listBoxPizzas.Size = new System.Drawing.Size(159, 160);
            this.listBoxPizzas.TabIndex = 13;
            // 
            // listBoxDessert
            // 
            this.listBoxDessert.FormattingEnabled = true;
            this.listBoxDessert.Location = new System.Drawing.Point(220, 96);
            this.listBoxDessert.Name = "listBoxDessert";
            this.listBoxDessert.Size = new System.Drawing.Size(180, 121);
            this.listBoxDessert.TabIndex = 14;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxDessert);
            this.Controls.Add(this.listBoxPizzas);
            this.Controls.Add(this.listBoxSoups);
            this.Controls.Add(this.listBoxDrinks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox orders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxDrinks;
        private System.Windows.Forms.ListBox listBoxSoups;
        private System.Windows.Forms.ListBox listBoxPizzas;
        private System.Windows.Forms.ListBox listBoxDessert;
    }
}