namespace KyThuatDoHoa
{
    partial class MenuFormMain
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
            this.HeToaDo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLine = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Coach = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.HeToaDo.SuspendLayout();
            this.btnLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeToaDo
            // 
            this.HeToaDo.Controls.Add(this.label2);
            this.HeToaDo.Controls.Add(this.label1);
            this.HeToaDo.Location = new System.Drawing.Point(0, 3);
            this.HeToaDo.Name = "HeToaDo";
            this.HeToaDo.Size = new System.Drawing.Size(800, 360);
            this.HeToaDo.TabIndex = 0;
            this.HeToaDo.Paint += new System.Windows.Forms.PaintEventHandler(this.HeToaDo_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(782, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(380, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "y";
            // 
            // btnLine
            // 
            this.btnLine.Controls.Add(this.button4);
            this.btnLine.Controls.Add(this.button3);
            this.btnLine.Controls.Add(this.Coach);
            this.btnLine.Controls.Add(this.button2);
            this.btnLine.Controls.Add(this.button1);
            this.btnLine.Location = new System.Drawing.Point(2, 359);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(799, 148);
            this.btnLine.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(359, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tinh Tien";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Coach
            // 
            this.Coach.Location = new System.Drawing.Point(359, 24);
            this.Coach.Name = "Coach";
            this.Coach.Size = new System.Drawing.Size(75, 23);
            this.Coach.TabIndex = 2;
            this.Coach.Text = "Coach";
            this.Coach.UseVisualStyleBackColor = true;
            this.Coach.Click += new System.EventHandler(this.Coach_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quay";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.HeToaDo);
            this.Name = "MenuFormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuFormMain_Load);
            this.HeToaDo.ResumeLayout(false);
            this.HeToaDo.PerformLayout();
            this.btnLine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeToaDo;
        private System.Windows.Forms.Panel btnLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Coach;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

