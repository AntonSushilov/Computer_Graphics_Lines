namespace Lines2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRigth = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.numericUpDownMove = new System.Windows.Forms.NumericUpDown();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.numericUpDownScope = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScope)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonClear);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(100, 29);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 23);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonRigth
            // 
            this.buttonRigth.Location = new System.Drawing.Point(175, 58);
            this.buttonRigth.Name = "buttonRigth";
            this.buttonRigth.Size = new System.Drawing.Size(75, 23);
            this.buttonRigth.TabIndex = 2;
            this.buttonRigth.Text = "Right";
            this.buttonRigth.UseVisualStyleBackColor = true;
            this.buttonRigth.Click += new System.EventHandler(this.buttonRigth_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(100, 87);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 23);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(25, 58);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // numericUpDownMove
            // 
            this.numericUpDownMove.Location = new System.Drawing.Point(106, 58);
            this.numericUpDownMove.Name = "numericUpDownMove";
            this.numericUpDownMove.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownMove.TabIndex = 5;
            this.numericUpDownMove.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(117, 199);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(47, 29);
            this.buttonPlus.TabIndex = 6;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(117, 234);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(47, 29);
            this.buttonMinus.TabIndex = 7;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // numericUpDownScope
            // 
            this.numericUpDownScope.DecimalPlaces = 1;
            this.numericUpDownScope.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownScope.Location = new System.Drawing.Point(170, 223);
            this.numericUpDownScope.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownScope.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScope.Name = "numericUpDownScope";
            this.numericUpDownScope.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownScope.TabIndex = 8;
            this.numericUpDownScope.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonInfo);
            this.groupBox1.Controls.Add(this.buttonDown);
            this.groupBox1.Controls.Add(this.numericUpDownScope);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonMinus);
            this.groupBox1.Controls.Add(this.buttonUp);
            this.groupBox1.Controls.Add(this.buttonPlus);
            this.groupBox1.Controls.Add(this.buttonRigth);
            this.groupBox1.Controls.Add(this.numericUpDownMove);
            this.groupBox1.Controls.Add(this.buttonLeft);
            this.groupBox1.Location = new System.Drawing.Point(783, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 312);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(6, 283);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo.TabIndex = 10;
            this.buttonInfo.Text = "Information";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 622);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Paint";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScope)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonRigth;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownMove;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.NumericUpDown numericUpDownScope;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInfo;
    }
}

