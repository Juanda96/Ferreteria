namespace Ferreteria.Clients
{
    partial class LobbyCliente
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.timerWelcome = new System.Windows.Forms.Timer(this.components);
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnService);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnWelcome);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 749);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.label5.Location = new System.Drawing.Point(55, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cliente";
            // 
            // timerWelcome
            // 
            this.timerWelcome.Tick += new System.EventHandler(this.timerWelcome_Tick);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(618, 359);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 24);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(654, 397);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 24);
            this.lblTimer.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(591, 433);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 20);
            this.lblDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1327, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1360, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.panelButton.Location = new System.Drawing.Point(201, 98);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(10, 103);
            this.panelButton.TabIndex = 12;
            this.panelButton.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Ferreteria.Properties.Resources.log_out;
            this.btnClose.Location = new System.Drawing.Point(0, 628);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(193, 101);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Cerrar sesión";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnService
            // 
            this.btnService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnService.ForeColor = System.Drawing.Color.White;
            this.btnService.Image = global::Ferreteria.Properties.Resources.consult;
            this.btnService.Location = new System.Drawing.Point(4, 449);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(193, 101);
            this.btnService.TabIndex = 11;
            this.btnService.Text = "Servicios";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            this.btnService.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnService_MouseMove);
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::Ferreteria.Properties.Resources.carpenter;
            this.btnProduct.Location = new System.Drawing.Point(4, 273);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(193, 101);
            this.btnProduct.TabIndex = 10;
            this.btnProduct.Text = "Productos";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            this.btnProduct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnProduct_MouseMove);
            // 
            // btnWelcome
            // 
            this.btnWelcome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnWelcome.ForeColor = System.Drawing.Color.White;
            this.btnWelcome.Image = global::Ferreteria.Properties.Resources.home;
            this.btnWelcome.Location = new System.Drawing.Point(4, 99);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(193, 101);
            this.btnWelcome.TabIndex = 8;
            this.btnWelcome.Text = "Bienvenido";
            this.btnWelcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWelcome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            this.btnWelcome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnWelcome_MouseMove);
            // 
            // LobbyCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LobbyCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LobbyCliente";
            this.Load += new System.EventHandler(this.LobbyCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timerWelcome;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelButton;
    }
}