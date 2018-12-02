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
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelPointA = new System.Windows.Forms.Label();
            this.labelPointB = new System.Windows.Forms.Label();
            this.labelPointC = new System.Windows.Forms.Label();
            this.labelPointD = new System.Windows.Forms.Label();
            this.labelIntersectionPoint = new System.Windows.Forms.Label();
            this.labelPointO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScope)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonClear);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(105, 70);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 23);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonRigth
            // 
            this.buttonRigth.Location = new System.Drawing.Point(180, 99);
            this.buttonRigth.Name = "buttonRigth";
            this.buttonRigth.Size = new System.Drawing.Size(75, 23);
            this.buttonRigth.TabIndex = 2;
            this.buttonRigth.Text = "Right";
            this.buttonRigth.UseVisualStyleBackColor = true;
            this.buttonRigth.Click += new System.EventHandler(this.buttonRigth_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(105, 128);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 23);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(30, 99);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // numericUpDownMove
            // 
            this.numericUpDownMove.Location = new System.Drawing.Point(111, 99);
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
            this.buttonPlus.Location = new System.Drawing.Point(122, 240);
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
            this.buttonMinus.Location = new System.Drawing.Point(122, 275);
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
            this.numericUpDownScope.Location = new System.Drawing.Point(175, 264);
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
            this.groupBox1.Controls.Add(this.labelPointO);
            this.groupBox1.Controls.Add(this.labelIntersectionPoint);
            this.groupBox1.Controls.Add(this.labelPointD);
            this.groupBox1.Controls.Add(this.labelPointC);
            this.groupBox1.Controls.Add(this.labelPointB);
            this.groupBox1.Controls.Add(this.labelPointA);
            this.groupBox1.Controls.Add(this.labelPoints);
            this.groupBox1.Controls.Add(this.buttonDown);
            this.groupBox1.Controls.Add(this.numericUpDownScope);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonMinus);
            this.groupBox1.Controls.Add(this.buttonUp);
            this.groupBox1.Controls.Add(this.buttonPlus);
            this.groupBox1.Controls.Add(this.buttonRigth);
            this.groupBox1.Controls.Add(this.numericUpDownMove);
            this.groupBox1.Controls.Add(this.buttonLeft);
            this.groupBox1.Location = new System.Drawing.Point(760, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 460);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoints.Location = new System.Drawing.Point(6, 326);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(57, 20);
            this.labelPoints.TabIndex = 9;
            this.labelPoints.Text = "Points:";
            // 
            // labelPointA
            // 
            this.labelPointA.AutoSize = true;
            this.labelPointA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPointA.Location = new System.Drawing.Point(69, 326);
            this.labelPointA.Name = "labelPointA";
            this.labelPointA.Size = new System.Drawing.Size(24, 20);
            this.labelPointA.TabIndex = 10;
            this.labelPointA.Text = "A:";
            // 
            // labelPointB
            // 
            this.labelPointB.AutoSize = true;
            this.labelPointB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPointB.Location = new System.Drawing.Point(69, 346);
            this.labelPointB.Name = "labelPointB";
            this.labelPointB.Size = new System.Drawing.Size(24, 20);
            this.labelPointB.TabIndex = 11;
            this.labelPointB.Text = "B:";
            // 
            // labelPointC
            // 
            this.labelPointC.AutoSize = true;
            this.labelPointC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPointC.Location = new System.Drawing.Point(69, 366);
            this.labelPointC.Name = "labelPointC";
            this.labelPointC.Size = new System.Drawing.Size(24, 20);
            this.labelPointC.TabIndex = 12;
            this.labelPointC.Text = "C:";
            // 
            // labelPointD
            // 
            this.labelPointD.AutoSize = true;
            this.labelPointD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPointD.Location = new System.Drawing.Point(69, 386);
            this.labelPointD.Name = "labelPointD";
            this.labelPointD.Size = new System.Drawing.Size(25, 20);
            this.labelPointD.TabIndex = 13;
            this.labelPointD.Text = "D:";
            // 
            // labelIntersectionPoint
            // 
            this.labelIntersectionPoint.AutoSize = true;
            this.labelIntersectionPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntersectionPoint.Location = new System.Drawing.Point(6, 418);
            this.labelIntersectionPoint.Name = "labelIntersectionPoint";
            this.labelIntersectionPoint.Size = new System.Drawing.Size(136, 20);
            this.labelIntersectionPoint.TabIndex = 14;
            this.labelIntersectionPoint.Text = "Intersection point:";
            // 
            // labelPointO
            // 
            this.labelPointO.AutoSize = true;
            this.labelPointO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPointO.Location = new System.Drawing.Point(148, 418);
            this.labelPointO.Name = "labelPointO";
            this.labelPointO.Size = new System.Drawing.Size(25, 20);
            this.labelPointO.TabIndex = 15;
            this.labelPointO.Text = "O:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 622);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Paint";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScope)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label labelPointO;
        private System.Windows.Forms.Label labelIntersectionPoint;
        private System.Windows.Forms.Label labelPointD;
        private System.Windows.Forms.Label labelPointC;
        private System.Windows.Forms.Label labelPointB;
        private System.Windows.Forms.Label labelPointA;
        private System.Windows.Forms.Label labelPoints;
    }
}
