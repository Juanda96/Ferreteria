namespace Ferreteria.Administration
{
    partial class Reports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ventas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.catProdcut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CatService = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catProdcut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatService)).BeginInit();
            this.SuspendLayout();
            // 
            // ventas
            // 
            this.ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            chartArea7.Name = "ChartArea1";
            this.ventas.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.ventas.Legends.Add(legend7);
            this.ventas.Location = new System.Drawing.Point(21, 247);
            this.ventas.Name = "ventas";
            this.ventas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.ventas.Size = new System.Drawing.Size(434, 300);
            this.ventas.TabIndex = 0;
            this.ventas.Text = "chart1";
            this.ventas.Click += new System.EventHandler(this.ventas_Click);
            // 
            // catProdcut
            // 
            this.catProdcut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            chartArea8.Name = "ChartArea1";
            this.catProdcut.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.catProdcut.Legends.Add(legend8);
            this.catProdcut.Location = new System.Drawing.Point(461, 247);
            this.catProdcut.Name = "catProdcut";
            this.catProdcut.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.catProdcut.Size = new System.Drawing.Size(434, 300);
            this.catProdcut.TabIndex = 1;
            this.catProdcut.Text = "chart2";
            // 
            // CatService
            // 
            this.CatService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            chartArea9.Name = "ChartArea1";
            this.CatService.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.CatService.Legends.Add(legend9);
            this.CatService.Location = new System.Drawing.Point(901, 247);
            this.CatService.Name = "CatService";
            this.CatService.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.CatService.Size = new System.Drawing.Size(434, 300);
            this.CatService.TabIndex = 2;
            this.CatService.Text = "chart3";
            this.CatService.Click += new System.EventHandler(this.CatService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(573, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "REPORTES GENERALES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1351, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CatService);
            this.Controls.Add(this.catProdcut);
            this.Controls.Add(this.ventas);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catProdcut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ventas;
        private System.Windows.Forms.DataVisualization.Charting.Chart catProdcut;
        private System.Windows.Forms.DataVisualization.Charting.Chart CatService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}