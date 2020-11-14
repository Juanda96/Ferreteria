namespace Ferreteria.Cashiers
{
    partial class PayOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbUserBuy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalImp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUserBuy
            // 
            this.cmbUserBuy.Font = new System.Drawing.Font("Havelock Titling", 9.75F);
            this.cmbUserBuy.FormattingEnabled = true;
            this.cmbUserBuy.Location = new System.Drawing.Point(105, 68);
            this.cmbUserBuy.Name = "cmbUserBuy";
            this.cmbUserBuy.Size = new System.Drawing.Size(295, 24);
            this.cmbUserBuy.TabIndex = 25;
            this.cmbUserBuy.SelectedIndexChanged += new System.EventHandler(this.cmbUserBuy_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Havelock Titling", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Havelock Titling", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cancelar factura";
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.dgvPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvPayment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvPayment.Location = new System.Drawing.Point(17, 150);
            this.dgvPayment.MultiSelect = false;
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPayment.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvPayment.Size = new System.Drawing.Size(692, 286);
            this.dgvPayment.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Havelock Titling", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Compras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Havelock Titling", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "total:   ₡";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Havelock Titling", 9.75F);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(110, 467);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 16);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "0";
            // 
            // lblTotalImp
            // 
            this.lblTotalImp.AutoSize = true;
            this.lblTotalImp.Font = new System.Drawing.Font("Havelock Titling", 9.75F);
            this.lblTotalImp.ForeColor = System.Drawing.Color.White;
            this.lblTotalImp.Location = new System.Drawing.Point(364, 467);
            this.lblTotalImp.Name = "lblTotalImp";
            this.lblTotalImp.Size = new System.Drawing.Size(17, 16);
            this.lblTotalImp.TabIndex = 31;
            this.lblTotalImp.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Havelock Titling", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(195, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "total con imp.   ₡";
            // 
            // btnWelcome
            // 
            this.btnWelcome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcome.Font = new System.Drawing.Font("Havelock Titling", 9.75F);
            this.btnWelcome.ForeColor = System.Drawing.Color.White;
            this.btnWelcome.Location = new System.Drawing.Point(582, 452);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(127, 42);
            this.btnWelcome.TabIndex = 32;
            this.btnWelcome.Text = "Cancelar deuda";
            this.btnWelcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWelcome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(716, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "-";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(751, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "x";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // PayOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(786, 518);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnWelcome);
            this.Controls.Add(this.lblTotalImp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.cmbUserBuy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(620, 260);
            this.Name = "PayOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Payout";
            this.Load += new System.EventHandler(this.PayOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserBuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalImp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}