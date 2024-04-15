namespace AC3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            anySelector = new ComboBox();
            comarcaSelector = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            poblacioSelector = new NumericUpDown();
            label10 = new Label();
            domesticXarxaSelector = new TextBox();
            actEconomiquesSelector = new TextBox();
            label11 = new Label();
            consumDomesticSelector = new TextBox();
            label12 = new Label();
            totalSelector = new TextBox();
            label13 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGrid = new DataGridView();
            Any = new DataGridViewTextBoxColumn();
            CodiComarca = new DataGridViewTextBoxColumn();
            Comarca = new DataGridViewTextBoxColumn();
            Poblacio = new DataGridViewTextBoxColumn();
            DomesticXarxa = new DataGridViewTextBoxColumn();
            ActEconomiques = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ConsumDomestic = new DataGridViewTextBoxColumn();
            poblacioMayor20000 = new Label();
            domesticMedio = new Label();
            ((System.ComponentModel.ISupportInitialize)poblacioSelector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(372, 25);
            label1.TabIndex = 0;
            label1.Text = "Gestió de dades demogràfiques de regions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(562, 44);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 1;
            label2.Text = "Estadístiques";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.Location = new Point(572, 94);
            label3.Name = "label3";
            label3.Size = new Size(128, 13);
            label3.TabIndex = 2;
            label3.Text = "Població > 20.000 hab.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.Location = new Point(572, 137);
            label4.Name = "label4";
            label4.Size = new Size(132, 13);
            label4.TabIndex = 3;
            label4.Text = "Consum domèstic mitjà:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label5.Location = new Point(572, 183);
            label5.Name = "label5";
            label5.Size = new Size(197, 13);
            label5.TabIndex = 4;
            label5.Text = "Consum domèstic per càpita més alt:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label6.Location = new Point(572, 224);
            label6.Name = "label6";
            label6.Size = new Size(206, 13);
            label6.TabIndex = 5;
            label6.Text = "Consum domèstic per càpita més baix:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label7.Location = new Point(12, 94);
            label7.Name = "label7";
            label7.Size = new Size(28, 13);
            label7.TabIndex = 6;
            label7.Text = "Any";
            // 
            // anySelector
            // 
            anySelector.FormattingEnabled = true;
            anySelector.Location = new Point(12, 112);
            anySelector.Name = "anySelector";
            anySelector.Size = new Size(70, 23);
            anySelector.TabIndex = 7;
            // 
            // comarcaSelector
            // 
            comarcaSelector.FormattingEnabled = true;
            comarcaSelector.Location = new Point(99, 112);
            comarcaSelector.Name = "comarcaSelector";
            comarcaSelector.Size = new Size(99, 23);
            comarcaSelector.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label8.Location = new Point(99, 94);
            label8.Name = "label8";
            label8.Size = new Size(52, 13);
            label8.TabIndex = 8;
            label8.Text = "Comarca";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label9.Location = new Point(218, 94);
            label9.Name = "label9";
            label9.Size = new Size(52, 13);
            label9.TabIndex = 10;
            label9.Text = "Població";
            // 
            // poblacioSelector
            // 
            poblacioSelector.Location = new Point(218, 112);
            poblacioSelector.Name = "poblacioSelector";
            poblacioSelector.Size = new Size(120, 23);
            poblacioSelector.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label10.Location = new Point(12, 158);
            label10.Name = "label10";
            label10.Size = new Size(86, 13);
            label10.TabIndex = 12;
            label10.Text = "Domèstic xarxa";
            // 
            // domesticXarxaSelector
            // 
            domesticXarxaSelector.Location = new Point(12, 191);
            domesticXarxaSelector.Name = "domesticXarxaSelector";
            domesticXarxaSelector.Size = new Size(110, 23);
            domesticXarxaSelector.TabIndex = 13;
            // 
            // actEconomiquesSelector
            // 
            actEconomiquesSelector.Location = new Point(138, 191);
            actEconomiquesSelector.Name = "actEconomiquesSelector";
            actEconomiquesSelector.Size = new Size(110, 23);
            actEconomiquesSelector.TabIndex = 15;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label11.Location = new Point(138, 154);
            label11.Name = "label11";
            label11.Size = new Size(140, 34);
            label11.TabIndex = 14;
            label11.Text = "Activitats econòmiques i fonts pròpies";
            // 
            // consumDomesticSelector
            // 
            consumDomesticSelector.Location = new Point(414, 150);
            consumDomesticSelector.Name = "consumDomesticSelector";
            consumDomesticSelector.Size = new Size(110, 23);
            consumDomesticSelector.TabIndex = 17;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label12.Location = new Point(308, 150);
            label12.Name = "label12";
            label12.Size = new Size(100, 41);
            label12.TabIndex = 16;
            label12.Text = "Consum domèstic per càpita total";
            // 
            // totalSelector
            // 
            totalSelector.Location = new Point(414, 191);
            totalSelector.Name = "totalSelector";
            totalSelector.Size = new Size(110, 23);
            totalSelector.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label13.Location = new Point(308, 195);
            label13.Name = "label13";
            label13.Size = new Size(32, 13);
            label13.TabIndex = 18;
            label13.Text = "Total";
            // 
            // button1
            // 
            button1.Location = new Point(357, 244);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Netejar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(449, 244);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 21;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Any, CodiComarca, Comarca, Poblacio, DomesticXarxa, ActEconomiques, Total, ConsumDomestic });
            dataGrid.Location = new Point(32, 300);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(826, 150);
            dataGrid.TabIndex = 22;
            // 
            // Any
            // 
            Any.HeaderText = "Any";
            Any.Name = "Any";
            Any.Width = 50;
            // 
            // CodiComarca
            // 
            CodiComarca.HeaderText = "Codi Comarca";
            CodiComarca.Name = "CodiComarca";
            CodiComarca.Width = 60;
            // 
            // Comarca
            // 
            Comarca.HeaderText = "Comarca";
            Comarca.Name = "Comarca";
            Comarca.Width = 110;
            // 
            // Poblacio
            // 
            Poblacio.HeaderText = "Població";
            Poblacio.Name = "Poblacio";
            Poblacio.Width = 110;
            // 
            // DomesticXarxa
            // 
            DomesticXarxa.HeaderText = "Domèstic Xarxa";
            DomesticXarxa.Name = "DomesticXarxa";
            DomesticXarxa.Width = 110;
            // 
            // ActEconomiques
            // 
            ActEconomiques.HeaderText = "A.E. i fonts pròpies";
            ActEconomiques.Name = "ActEconomiques";
            ActEconomiques.Width = 110;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 105;
            // 
            // ConsumDomestic
            // 
            ConsumDomestic.HeaderText = "Consum doméstic/càpita";
            ConsumDomestic.Name = "ConsumDomestic";
            ConsumDomestic.Width = 105;
            // 
            // poblacioMayor20000
            // 
            poblacioMayor20000.BackColor = SystemColors.ActiveCaption;
            poblacioMayor20000.Location = new Point(722, 87);
            poblacioMayor20000.Name = "poblacioMayor20000";
            poblacioMayor20000.Size = new Size(35, 28);
            poblacioMayor20000.TabIndex = 23;
            // 
            // domesticMedio
            // 
            domesticMedio.BackColor = SystemColors.ActiveCaption;
            domesticMedio.Location = new Point(722, 131);
            domesticMedio.Name = "domesticMedio";
            domesticMedio.Size = new Size(35, 28);
            domesticMedio.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 462);
            Controls.Add(domesticMedio);
            Controls.Add(poblacioMayor20000);
            Controls.Add(dataGrid);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(totalSelector);
            Controls.Add(label13);
            Controls.Add(consumDomesticSelector);
            Controls.Add(label12);
            Controls.Add(actEconomiquesSelector);
            Controls.Add(label11);
            Controls.Add(domesticXarxaSelector);
            Controls.Add(label10);
            Controls.Add(poblacioSelector);
            Controls.Add(label9);
            Controls.Add(comarcaSelector);
            Controls.Add(label8);
            Controls.Add(anySelector);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Gestió de dades demogràfiques de regions";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)poblacioSelector).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox anySelector;
        private ComboBox comarcaSelector;
        private Label label8;
        private Label label9;
        private NumericUpDown poblacioSelector;
        private Label label10;
        private TextBox domesticXarxaSelector;
        private TextBox actEconomiquesSelector;
        private Label label11;
        private TextBox consumDomesticSelector;
        private Label label12;
        private TextBox totalSelector;
        private Label label13;
        private Button button1;
        private Button button2;
        private DataGridView dataGrid;
        private Label poblacioMayor20000;
        private Label domesticMedio;
        private DataGridViewTextBoxColumn Any;
        private DataGridViewTextBoxColumn CodiComarca;
        private DataGridViewTextBoxColumn Comarca;
        private DataGridViewTextBoxColumn Poblacio;
        private DataGridViewTextBoxColumn DomesticXarxa;
        private DataGridViewTextBoxColumn ActEconomiques;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn ConsumDomestic;
    }
}
