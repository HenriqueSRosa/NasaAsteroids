
namespace NASATeste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridAsteroids = new System.Windows.Forms.DataGridView();
            this.AsteroidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPotentiallyHazardous = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDiameterEstimatedM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDiameterEstimatedM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDiameterEstimatedMiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDiameterEstimatedMiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minEstimatedDiameterKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDiameterEstimatedKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gpbPeriod = new System.Windows.Forms.GroupBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cboHazardous = new System.Windows.Forms.ComboBox();
            this.lblHazard = new System.Windows.Forms.Label();
            this.cboMetrics = new System.Windows.Forms.ComboBox();
            this.lblMeasureUnit = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAsteroids)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpbPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridAsteroids
            // 
            this.dataGridAsteroids.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAsteroids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAsteroids.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AsteroidName,
            this.isPotentiallyHazardous,
            this.minDiameterEstimatedM,
            this.maxDiameterEstimatedM,
            this.minDiameterEstimatedMiles,
            this.maxDiameterEstimatedMiles,
            this.minEstimatedDiameterKM,
            this.maxDiameterEstimatedKM,
            this.Speed,
            this.Date});
            this.dataGridAsteroids.Location = new System.Drawing.Point(351, 64);
            this.dataGridAsteroids.Name = "dataGridAsteroids";
            this.dataGridAsteroids.RowTemplate.Height = 25;
            this.dataGridAsteroids.Size = new System.Drawing.Size(643, 588);
            this.dataGridAsteroids.TabIndex = 1;
            this.dataGridAsteroids.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AsteroidName
            // 
            this.AsteroidName.HeaderText = "Nome";
            this.AsteroidName.Name = "AsteroidName";
            // 
            // isPotentiallyHazardous
            // 
            this.isPotentiallyHazardous.HeaderText = "Perigoso";
            this.isPotentiallyHazardous.Name = "isPotentiallyHazardous";
            // 
            // minDiameterEstimatedM
            // 
            this.minDiameterEstimatedM.HeaderText = "Diâmetro Mínimo Estimado (Metros)";
            this.minDiameterEstimatedM.Name = "minDiameterEstimatedM";
            this.minDiameterEstimatedM.Visible = false;
            // 
            // maxDiameterEstimatedM
            // 
            this.maxDiameterEstimatedM.HeaderText = "Diâmetro Máximo Estimado (Metros)";
            this.maxDiameterEstimatedM.Name = "maxDiameterEstimatedM";
            this.maxDiameterEstimatedM.Visible = false;
            // 
            // minDiameterEstimatedMiles
            // 
            this.minDiameterEstimatedMiles.HeaderText = "Diâmetro Mínimo Estimado (Milhas)";
            this.minDiameterEstimatedMiles.Name = "minDiameterEstimatedMiles";
            this.minDiameterEstimatedMiles.Visible = false;
            // 
            // maxDiameterEstimatedMiles
            // 
            this.maxDiameterEstimatedMiles.HeaderText = "Diâmetro Máximo Estimado (Milhas)";
            this.maxDiameterEstimatedMiles.Name = "maxDiameterEstimatedMiles";
            this.maxDiameterEstimatedMiles.Visible = false;
            // 
            // minEstimatedDiameterKM
            // 
            this.minEstimatedDiameterKM.HeaderText = "Diâmetro Mínimo Estimado (Quilômetros)";
            this.minEstimatedDiameterKM.Name = "minEstimatedDiameterKM";
            this.minEstimatedDiameterKM.Visible = false;
            // 
            // maxDiameterEstimatedKM
            // 
            this.maxDiameterEstimatedKM.HeaderText = "Diâmetro Máximo Estimado (Quilômetros)";
            this.maxDiameterEstimatedKM.Name = "maxDiameterEstimatedKM";
            this.maxDiameterEstimatedKM.Visible = false;
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Velocidade (km/h)";
            this.Speed.Name = "Speed";
            // 
            // Date
            // 
            this.Date.HeaderText = "Data";
            this.Date.Name = "Date";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(610, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Asteróides";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.gpbPeriod);
            this.groupBox2.Controls.Add(this.cboHazardous);
            this.groupBox2.Controls.Add(this.lblHazard);
            this.groupBox2.Controls.Add(this.cboMetrics);
            this.groupBox2.Controls.Add(this.lblMeasureUnit);
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Location = new System.Drawing.Point(13, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 514);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções de Filtro";
            // 
            // gpbPeriod
            // 
            this.gpbPeriod.Controls.Add(this.dateTo);
            this.gpbPeriod.Controls.Add(this.dateFrom);
            this.gpbPeriod.Controls.Add(this.lblTo);
            this.gpbPeriod.Controls.Add(this.lblFrom);
            this.gpbPeriod.Location = new System.Drawing.Point(7, 96);
            this.gpbPeriod.Name = "gpbPeriod";
            this.gpbPeriod.Size = new System.Drawing.Size(306, 84);
            this.gpbPeriod.TabIndex = 2;
            this.gpbPeriod.TabStop = false;
            this.gpbPeriod.Text = "Período";
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(200, 47);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(99, 23);
            this.dateTo.TabIndex = 3;
            this.dateTo.Value = new System.DateTime(2021, 7, 10, 0, 0, 0, 0);
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(200, 17);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(99, 23);
            this.dateFrom.TabIndex = 2;
            this.dateFrom.Value = new System.DateTime(2021, 7, 3, 0, 0, 0, 0);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(7, 51);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 15);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "Até:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(7, 23);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(24, 15);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "De:";
            // 
            // cboHazardous
            // 
            this.cboHazardous.FormattingEnabled = true;
            this.cboHazardous.Items.AddRange(new object[] {
            "Todos",
            "Sim",
            "Não"});
            this.cboHazardous.Location = new System.Drawing.Point(207, 56);
            this.cboHazardous.Name = "cboHazardous";
            this.cboHazardous.Size = new System.Drawing.Size(99, 23);
            this.cboHazardous.TabIndex = 1;
            // 
            // lblHazard
            // 
            this.lblHazard.AutoSize = true;
            this.lblHazard.Location = new System.Drawing.Point(7, 62);
            this.lblHazard.Name = "lblHazard";
            this.lblHazard.Size = new System.Drawing.Size(65, 15);
            this.lblHazard.TabIndex = 0;
            this.lblHazard.Text = "É perigoso:";
            // 
            // cboMetrics
            // 
            this.cboMetrics.FormattingEnabled = true;
            this.cboMetrics.Items.AddRange(new object[] {
            "Metros",
            "Milhas",
            "Quilômetros"});
            this.cboMetrics.Location = new System.Drawing.Point(126, 26);
            this.cboMetrics.Name = "cboMetrics";
            this.cboMetrics.Size = new System.Drawing.Size(181, 23);
            this.cboMetrics.TabIndex = 1;
            this.cboMetrics.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblMeasureUnit
            // 
            this.lblMeasureUnit.AutoSize = true;
            this.lblMeasureUnit.Location = new System.Drawing.Point(7, 29);
            this.lblMeasureUnit.Name = "lblMeasureUnit";
            this.lblMeasureUnit.Size = new System.Drawing.Size(113, 15);
            this.lblMeasureUnit.TabIndex = 0;
            this.lblMeasureUnit.Text = "Unidade de Medida:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(238, 485);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Buscar";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 485);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Desfazer Filtros";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(780, 9);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(222, 15);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "Desenvolvido por Henrique Silva da Rosa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 664);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridAsteroids);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NASA Dados de Asteróides";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAsteroids)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpbPeriod.ResumeLayout(false);
            this.gpbPeriod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridAsteroids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboHazardous;
        private System.Windows.Forms.Label lblHazard;
        private System.Windows.Forms.ComboBox cboMetrics;
        private System.Windows.Forms.Label lblMeasureUnit;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gpbPeriod;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsteroidName;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPotentiallyHazardous;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDiameterEstimatedM;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDiameterEstimatedM;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDiameterEstimatedMiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDiameterEstimatedMiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn minEstimatedDiameterKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDiameterEstimatedKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label lblCopyright;
    }
}

