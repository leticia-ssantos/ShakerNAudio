namespace ShakerNAudio
{
    partial class ShakerNAudio
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
            this.tabControlShaker = new System.Windows.Forms.TabControl();
            this.tabPageDevices = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.tabPageShaker = new System.Windows.Forms.TabPage();
            this.trackBarPanChB = new System.Windows.Forms.TrackBar();
            this.trackBarPanChA = new System.Windows.Forms.TrackBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.labelGain = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.trackBarGain = new System.Windows.Forms.TrackBar();
            this.trackBarFrequency = new System.Windows.Forms.TrackBar();
            this.tabControlShaker.SuspendLayout();
            this.tabPageDevices.SuspendLayout();
            this.tabPageShaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPanChB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPanChA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlShaker
            // 
            this.tabControlShaker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlShaker.Controls.Add(this.tabPageDevices);
            this.tabControlShaker.Controls.Add(this.tabPageShaker);
            this.tabControlShaker.Location = new System.Drawing.Point(12, 12);
            this.tabControlShaker.Name = "tabControlShaker";
            this.tabControlShaker.SelectedIndex = 0;
            this.tabControlShaker.Size = new System.Drawing.Size(770, 345);
            this.tabControlShaker.TabIndex = 0;
            // 
            // tabPageDevices
            // 
            this.tabPageDevices.Controls.Add(this.label1);
            this.tabPageDevices.Controls.Add(this.comboBoxDevices);
            this.tabPageDevices.Location = new System.Drawing.Point(4, 22);
            this.tabPageDevices.Name = "tabPageDevices";
            this.tabPageDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDevices.Size = new System.Drawing.Size(762, 455);
            this.tabPageDevices.TabIndex = 1;
            this.tabPageDevices.Text = "Output Devices";
            this.tabPageDevices.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dispositivos";
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(87, 20);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(659, 21);
            this.comboBoxDevices.TabIndex = 0;
            // 
            // tabPageShaker
            // 
            this.tabPageShaker.Controls.Add(this.trackBarPanChB);
            this.tabPageShaker.Controls.Add(this.trackBarPanChA);
            this.tabPageShaker.Controls.Add(this.buttonStart);
            this.tabPageShaker.Controls.Add(this.label4);
            this.tabPageShaker.Controls.Add(this.textBoxGain);
            this.tabPageShaker.Controls.Add(this.label3);
            this.tabPageShaker.Controls.Add(this.textBoxFrequency);
            this.tabPageShaker.Controls.Add(this.labelGain);
            this.tabPageShaker.Controls.Add(this.labelFrequency);
            this.tabPageShaker.Controls.Add(this.trackBarGain);
            this.tabPageShaker.Controls.Add(this.trackBarFrequency);
            this.tabPageShaker.Location = new System.Drawing.Point(4, 22);
            this.tabPageShaker.Name = "tabPageShaker";
            this.tabPageShaker.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShaker.Size = new System.Drawing.Size(762, 319);
            this.tabPageShaker.TabIndex = 0;
            this.tabPageShaker.Text = "Shaker";
            this.tabPageShaker.UseVisualStyleBackColor = true;
            // 
            // trackBarPanChB
            // 
            this.trackBarPanChB.Location = new System.Drawing.Point(18, 255);
            this.trackBarPanChB.Maximum = 100;
            this.trackBarPanChB.Name = "trackBarPanChB";
            this.trackBarPanChB.Size = new System.Drawing.Size(622, 45);
            this.trackBarPanChB.TabIndex = 7;
            this.trackBarPanChB.ValueChanged += new System.EventHandler(this.trackBarPanChB_ValueChanged);
            // 
            // trackBarPanChA
            // 
            this.trackBarPanChA.Location = new System.Drawing.Point(18, 178);
            this.trackBarPanChA.Maximum = 100;
            this.trackBarPanChA.Name = "trackBarPanChA";
            this.trackBarPanChA.Size = new System.Drawing.Size(622, 45);
            this.trackBarPanChA.TabIndex = 7;
            this.trackBarPanChA.ValueChanged += new System.EventHandler(this.trackBarPanChA_ValueChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Location = new System.Drawing.Point(671, 276);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Play";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Canal B";
            // 
            // textBoxGain
            // 
            this.textBoxGain.Location = new System.Drawing.Point(651, 100);
            this.textBoxGain.Name = "textBoxGain";
            this.textBoxGain.Size = new System.Drawing.Size(100, 20);
            this.textBoxGain.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Canal A";
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Location = new System.Drawing.Point(651, 29);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrequency.TabIndex = 4;
            // 
            // labelGain
            // 
            this.labelGain.AutoSize = true;
            this.labelGain.Location = new System.Drawing.Point(15, 84);
            this.labelGain.Name = "labelGain";
            this.labelGain.Size = new System.Drawing.Size(39, 13);
            this.labelGain.TabIndex = 3;
            this.labelGain.Text = "Ganho";
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(15, 13);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(60, 13);
            this.labelFrequency.TabIndex = 2;
            this.labelFrequency.Text = "Frequência";
            // 
            // trackBarGain
            // 
            this.trackBarGain.Location = new System.Drawing.Point(15, 100);
            this.trackBarGain.Maximum = 100;
            this.trackBarGain.Name = "trackBarGain";
            this.trackBarGain.Size = new System.Drawing.Size(625, 45);
            this.trackBarGain.TabIndex = 1;
            this.trackBarGain.ValueChanged += new System.EventHandler(this.trackBarGain_Scroll);
            // 
            // trackBarFrequency
            // 
            this.trackBarFrequency.Location = new System.Drawing.Point(15, 29);
            this.trackBarFrequency.Maximum = 150;
            this.trackBarFrequency.Minimum = 20;
            this.trackBarFrequency.Name = "trackBarFrequency";
            this.trackBarFrequency.Size = new System.Drawing.Size(625, 45);
            this.trackBarFrequency.TabIndex = 0;
            this.trackBarFrequency.Value = 20;
            this.trackBarFrequency.ValueChanged += new System.EventHandler(this.trackBarFrequency_Scroll);
            // 
            // ShakerNAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 370);
            this.Controls.Add(this.tabControlShaker);
            this.Name = "ShakerNAudio";
            this.Text = "ShakerNAudio";
            this.Load += new System.EventHandler(this.ShakerNAudio_Load);
            this.tabControlShaker.ResumeLayout(false);
            this.tabPageDevices.ResumeLayout(false);
            this.tabPageDevices.PerformLayout();
            this.tabPageShaker.ResumeLayout(false);
            this.tabPageShaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPanChB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPanChA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlShaker;
        private System.Windows.Forms.TabPage tabPageShaker;
        private System.Windows.Forms.TextBox textBoxGain;
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.Label labelGain;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.TrackBar trackBarGain;
        private System.Windows.Forms.TrackBar trackBarFrequency;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TabPage tabPageDevices;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarPanChB;
        private System.Windows.Forms.TrackBar trackBarPanChA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

