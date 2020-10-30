namespace VMCProtocolReflectorGUI
{
    partial class frmGUI
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.nudReceivePort = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudSendPort10 = new System.Windows.Forms.NumericUpDown();
            this.nudSendPort09 = new System.Windows.Forms.NumericUpDown();
            this.nudSendPort08 = new System.Windows.Forms.NumericUpDown();
            this.nudSendPort07 = new System.Windows.Forms.NumericUpDown();
            this.nudSendPort06 = new System.Windows.Forms.NumericUpDown();
            this.nudSendPort05 = new System.Windows.Forms.NumericUpDown();
            this.nudSendPort04 = new System.Windows.Forms.NumericUpDown();
            this.nudSendPort03 = new System.Windows.Forms.NumericUpDown();
            this.nudSendPort02 = new System.Windows.Forms.NumericUpDown();
            this.nudSendPort01 = new System.Windows.Forms.NumericUpDown();
            this.btnAdd10 = new System.Windows.Forms.Button();
            this.btnAdd09 = new System.Windows.Forms.Button();
            this.btnAdd08 = new System.Windows.Forms.Button();
            this.btnAdd07 = new System.Windows.Forms.Button();
            this.btnAdd06 = new System.Windows.Forms.Button();
            this.btnAdd05 = new System.Windows.Forms.Button();
            this.btnAdd04 = new System.Windows.Forms.Button();
            this.btnAdd03 = new System.Windows.Forms.Button();
            this.btnAdd02 = new System.Windows.Forms.Button();
            this.btnAdd01 = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnReStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudReceivePort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort01)).BeginInit();
            this.SuspendLayout();
            // 
            // nudReceivePort
            // 
            this.nudReceivePort.Location = new System.Drawing.Point(6, 18);
            this.nudReceivePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudReceivePort.Name = "nudReceivePort";
            this.nudReceivePort.Size = new System.Drawing.Size(108, 19);
            this.nudReceivePort.TabIndex = 2;
            this.nudReceivePort.Value = new decimal(new int[] {
            39539,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudReceivePort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "受信ポート";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudSendPort10);
            this.groupBox2.Controls.Add(this.nudSendPort09);
            this.groupBox2.Controls.Add(this.nudSendPort08);
            this.groupBox2.Controls.Add(this.nudSendPort07);
            this.groupBox2.Controls.Add(this.nudSendPort06);
            this.groupBox2.Controls.Add(this.nudSendPort05);
            this.groupBox2.Controls.Add(this.nudSendPort04);
            this.groupBox2.Controls.Add(this.nudSendPort03);
            this.groupBox2.Controls.Add(this.nudSendPort02);
            this.groupBox2.Controls.Add(this.nudSendPort01);
            this.groupBox2.Controls.Add(this.btnAdd10);
            this.groupBox2.Controls.Add(this.btnAdd09);
            this.groupBox2.Controls.Add(this.btnAdd08);
            this.groupBox2.Controls.Add(this.btnAdd07);
            this.groupBox2.Controls.Add(this.btnAdd06);
            this.groupBox2.Controls.Add(this.btnAdd05);
            this.groupBox2.Controls.Add(this.btnAdd04);
            this.groupBox2.Controls.Add(this.btnAdd03);
            this.groupBox2.Controls.Add(this.btnAdd02);
            this.groupBox2.Controls.Add(this.btnAdd01);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 217);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "送信ポート";
            // 
            // nudSendPort10
            // 
            this.nudSendPort10.Location = new System.Drawing.Point(6, 189);
            this.nudSendPort10.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSendPort10.Name = "nudSendPort10";
            this.nudSendPort10.Size = new System.Drawing.Size(108, 19);
            this.nudSendPort10.TabIndex = 26;
            this.nudSendPort10.Value = new decimal(new int[] {
            39609,
            0,
            0,
            0});
            this.nudSendPort10.Visible = false;
            this.nudSendPort10.DoubleClick += new System.EventHandler(this.nudSendPort_DoubleClick);
            // 
            // nudSendPort09
            // 
            this.nudSendPort09.Location = new System.Drawing.Point(6, 170);
            this.nudSendPort09.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSendPort09.Name = "nudSendPort09";
            this.nudSendPort09.Size = new System.Drawing.Size(108, 19);
            this.nudSendPort09.TabIndex = 24;
            this.nudSendPort09.Value = new decimal(new int[] {
            39608,
            0,
            0,
            0});
            this.nudSendPort09.Visible = false;
            this.nudSendPort09.DoubleClick += new System.EventHandler(this.nudSendPort_DoubleClick);
            // 
            // nudSendPort08
            // 
            this.nudSendPort08.Location = new System.Drawing.Point(6, 151);
            this.nudSendPort08.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSendPort08.Name = "nudSendPort08";
            this.nudSendPort08.Size = new System.Drawing.Size(108, 19);
            this.nudSendPort08.TabIndex = 22;
            this.nudSendPort08.Value = new decimal(new int[] {
            39607,
            0,
            0,
            0});
            this.nudSendPort08.Visible = false;
            this.nudSendPort08.DoubleClick += new System.EventHandler(this.nudSendPort_DoubleClick);
            // 
            // nudSendPort07
            // 
            this.nudSendPort07.Location = new System.Drawing.Point(6, 132);
            this.nudSendPort07.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSendPort07.Name = "nudSendPort07";
            this.nudSendPort07.Size = new System.Drawing.Size(108, 19);
            this.nudSendPort07.TabIndex = 20;
            this.nudSendPort07.Value = new decimal(new int[] {
            39606,
            0,
            0,
            0});
            this.nudSendPort07.Visible = false;
            this.nudSendPort07.DoubleClick += new System.EventHandler(this.nudSendPort_DoubleClick);
            // 
            // nudSendPort06
            // 
            this.nudSendPort06.Location = new System.Drawing.Point(6, 113);
            this.nudSendPort06.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSendPort06.Name = "nudSendPort06";
            this.nudSendPort06.Size = new System.Drawing.Size(108, 19);
            this.nudSendPort06.TabIndex = 18;
            this.nudSendPort06.Value = new decimal(new int[] {
            39605,
            0,
            0,
            0});
            this.nudSendPort06.Visible = false;
            this.nudSendPort06.DoubleClick += new System.EventHandler(this.nudSendPort_DoubleClick);
            // 
            // nudSendPort05
            // 
            this.nudSendPort05.Location = new System.Drawing.Point(6, 94);
            this.nudSendPort05.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSendPort05.Name = "nudSendPort05";
            this.nudSendPort05.Size = new System.Drawing.Size(108, 19);
            this.nudSendPort05.TabIndex = 16;
            this.nudSendPort05.Value = new decimal(new int[] {
            39604,
            0,
            0,
            0});
            this.nudSendPort05.Visible = false;
            this.nudSendPort05.DoubleClick += new System.EventHandler(this.nudSendPort_DoubleClick);
            // 
            // nudSendPort04
            // 
            this.nudSendPort04.Location = new System.Drawing.Point(6, 75);
            this.nudSendPort04.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSendPort04.Name = "nudSendPort04";
            this.nudSendPort04.Size = new System.Drawing.Size(108, 19);
            this.nudSendPort04.TabIndex = 14;
            this.nudSendPort04.Value = new decimal(new int[] {
            39603,
            0,
            0,
            0});
            this.nudSendPort04.Visible = false;
            this.nudSendPort04.DoubleClick += new System.EventHandler(this.nudSendPort_DoubleClick);
            // 
            // nudSendPort03
            // 
            this.nudSendPort03.Location = new System.Drawing.Point(6, 56);
            this.nudSendPort03.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSendPort03.Name = "nudSendPort03";
            this.nudSendPort03.Size = new System.Drawing.Size(108, 19);
            this.nudSendPort03.TabIndex = 12;
            this.nudSendPort03.Value = new decimal(new int[] {
            39602,
            0,
            0,
            0});
            this.nudSendPort03.Visible = false;
            this.nudSendPort03.DoubleClick += new System.EventHandler(this.nudSendPort_DoubleClick);
            // 
            // nudSendPort02
            // 
            this.nudSendPort02.Location = new System.Drawing.Point(6, 37);
            this.nudSendPort02.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSendPort02.Name = "nudSendPort02";
            this.nudSendPort02.Size = new System.Drawing.Size(108, 19);
            this.nudSendPort02.TabIndex = 10;
            this.nudSendPort02.Value = new decimal(new int[] {
            39601,
            0,
            0,
            0});
            this.nudSendPort02.DoubleClick += new System.EventHandler(this.nudSendPort_DoubleClick);
            // 
            // nudSendPort01
            // 
            this.nudSendPort01.Location = new System.Drawing.Point(6, 18);
            this.nudSendPort01.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSendPort01.Name = "nudSendPort01";
            this.nudSendPort01.Size = new System.Drawing.Size(108, 19);
            this.nudSendPort01.TabIndex = 8;
            this.nudSendPort01.Value = new decimal(new int[] {
            39600,
            0,
            0,
            0});
            this.nudSendPort01.DoubleClick += new System.EventHandler(this.nudSendPort_DoubleClick);
            // 
            // btnAdd10
            // 
            this.btnAdd10.Location = new System.Drawing.Point(6, 189);
            this.btnAdd10.Name = "btnAdd10";
            this.btnAdd10.Size = new System.Drawing.Size(108, 19);
            this.btnAdd10.TabIndex = 27;
            this.btnAdd10.Text = "ADD";
            this.btnAdd10.UseVisualStyleBackColor = true;
            this.btnAdd10.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd09
            // 
            this.btnAdd09.Location = new System.Drawing.Point(6, 170);
            this.btnAdd09.Name = "btnAdd09";
            this.btnAdd09.Size = new System.Drawing.Size(108, 19);
            this.btnAdd09.TabIndex = 25;
            this.btnAdd09.Text = "ADD";
            this.btnAdd09.UseVisualStyleBackColor = true;
            this.btnAdd09.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd08
            // 
            this.btnAdd08.Location = new System.Drawing.Point(6, 151);
            this.btnAdd08.Name = "btnAdd08";
            this.btnAdd08.Size = new System.Drawing.Size(108, 19);
            this.btnAdd08.TabIndex = 23;
            this.btnAdd08.Text = "ADD";
            this.btnAdd08.UseVisualStyleBackColor = true;
            this.btnAdd08.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd07
            // 
            this.btnAdd07.Location = new System.Drawing.Point(6, 132);
            this.btnAdd07.Name = "btnAdd07";
            this.btnAdd07.Size = new System.Drawing.Size(108, 19);
            this.btnAdd07.TabIndex = 21;
            this.btnAdd07.Text = "ADD";
            this.btnAdd07.UseVisualStyleBackColor = true;
            this.btnAdd07.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd06
            // 
            this.btnAdd06.Location = new System.Drawing.Point(6, 113);
            this.btnAdd06.Name = "btnAdd06";
            this.btnAdd06.Size = new System.Drawing.Size(108, 19);
            this.btnAdd06.TabIndex = 19;
            this.btnAdd06.Text = "ADD";
            this.btnAdd06.UseVisualStyleBackColor = true;
            this.btnAdd06.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd05
            // 
            this.btnAdd05.Location = new System.Drawing.Point(6, 94);
            this.btnAdd05.Name = "btnAdd05";
            this.btnAdd05.Size = new System.Drawing.Size(108, 19);
            this.btnAdd05.TabIndex = 17;
            this.btnAdd05.Text = "ADD";
            this.btnAdd05.UseVisualStyleBackColor = true;
            this.btnAdd05.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd04
            // 
            this.btnAdd04.Location = new System.Drawing.Point(6, 75);
            this.btnAdd04.Name = "btnAdd04";
            this.btnAdd04.Size = new System.Drawing.Size(108, 19);
            this.btnAdd04.TabIndex = 15;
            this.btnAdd04.Text = "ADD";
            this.btnAdd04.UseVisualStyleBackColor = true;
            this.btnAdd04.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd03
            // 
            this.btnAdd03.Location = new System.Drawing.Point(6, 56);
            this.btnAdd03.Name = "btnAdd03";
            this.btnAdd03.Size = new System.Drawing.Size(108, 19);
            this.btnAdd03.TabIndex = 13;
            this.btnAdd03.Text = "ADD";
            this.btnAdd03.UseVisualStyleBackColor = true;
            this.btnAdd03.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd02
            // 
            this.btnAdd02.Location = new System.Drawing.Point(6, 37);
            this.btnAdd02.Name = "btnAdd02";
            this.btnAdd02.Size = new System.Drawing.Size(108, 19);
            this.btnAdd02.TabIndex = 11;
            this.btnAdd02.Text = "ADD";
            this.btnAdd02.UseVisualStyleBackColor = true;
            this.btnAdd02.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd01
            // 
            this.btnAdd01.Location = new System.Drawing.Point(6, 18);
            this.btnAdd01.Name = "btnAdd01";
            this.btnAdd01.Size = new System.Drawing.Size(108, 19);
            this.btnAdd01.TabIndex = 9;
            this.btnAdd01.Text = "ADD";
            this.btnAdd01.UseVisualStyleBackColor = true;
            this.btnAdd01.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(154, 143);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(137, 65);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "設定保存";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnReStart
            // 
            this.btnReStart.Location = new System.Drawing.Point(154, 224);
            this.btnReStart.Name = "btnReStart";
            this.btnReStart.Size = new System.Drawing.Size(137, 65);
            this.btnReStart.TabIndex = 8;
            this.btnReStart.Text = "VMCProtocolReflector\r\n\r\n再起動";
            this.btnReStart.UseVisualStyleBackColor = true;
            this.btnReStart.Click += new System.EventHandler(this.btnReStart_Click);
            // 
            // frmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 305);
            this.Controls.Add(this.btnReStart);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGUI";
            this.Text = "VMCProtocolReflectorGUI";
            ((System.ComponentModel.ISupportInitialize)(this.nudReceivePort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendPort01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudReceivePort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudSendPort10;
        private System.Windows.Forms.Button btnAdd10;
        private System.Windows.Forms.NumericUpDown nudSendPort09;
        private System.Windows.Forms.Button btnAdd09;
        private System.Windows.Forms.NumericUpDown nudSendPort08;
        private System.Windows.Forms.Button btnAdd08;
        private System.Windows.Forms.NumericUpDown nudSendPort07;
        private System.Windows.Forms.Button btnAdd07;
        private System.Windows.Forms.NumericUpDown nudSendPort06;
        private System.Windows.Forms.Button btnAdd06;
        private System.Windows.Forms.NumericUpDown nudSendPort05;
        private System.Windows.Forms.Button btnAdd05;
        private System.Windows.Forms.NumericUpDown nudSendPort04;
        private System.Windows.Forms.Button btnAdd04;
        private System.Windows.Forms.NumericUpDown nudSendPort03;
        private System.Windows.Forms.Button btnAdd03;
        private System.Windows.Forms.NumericUpDown nudSendPort02;
        private System.Windows.Forms.Button btnAdd02;
        private System.Windows.Forms.NumericUpDown nudSendPort01;
        private System.Windows.Forms.Button btnAdd01;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnReStart;
    }
}

