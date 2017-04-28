namespace Example3
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.lblExp1 = new System.Windows.Forms.Label();
            this.lblExp2 = new System.Windows.Forms.Label();
            this.lblAns1 = new System.Windows.Forms.Label();
            this.lblAns2 = new System.Windows.Forms.Label();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExp1
            // 
            this.lblExp1.AutoSize = true;
            this.lblExp1.Location = new System.Drawing.Point(20, 30);
            this.lblExp1.Name = "lblExp1";
            this.lblExp1.Size = new System.Drawing.Size(35, 12);
            this.lblExp1.TabIndex = 0;
            this.lblExp1.Text = "1+2*3";
            // 
            // lblExp2
            // 
            this.lblExp2.AutoSize = true;
            this.lblExp2.Location = new System.Drawing.Point(19, 60);
            this.lblExp2.Name = "lblExp2";
            this.lblExp2.Size = new System.Drawing.Size(43, 12);
            this.lblExp2.TabIndex = 1;
            this.lblExp2.Text = "(1+2)*3";
            // 
            // lblAns1
            // 
            this.lblAns1.AutoSize = true;
            this.lblAns1.Location = new System.Drawing.Point(192, 30);
            this.lblAns1.Name = "lblAns1";
            this.lblAns1.Size = new System.Drawing.Size(10, 12);
            this.lblAns1.TabIndex = 2;
            this.lblAns1.Text = "?";
            // 
            // lblAns2
            // 
            this.lblAns2.AutoSize = true;
            this.lblAns2.Location = new System.Drawing.Point(192, 70);
            this.lblAns2.Name = "lblAns2";
            this.lblAns2.Size = new System.Drawing.Size(10, 12);
            this.lblAns2.TabIndex = 3;
            this.lblAns2.Text = "?";
            // 
            // btnCalc1
            // 
            this.btnCalc1.Location = new System.Drawing.Point(128, 25);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(40, 23);
            this.btnCalc1.TabIndex = 4;
            this.btnCalc1.Text = "=";
            this.btnCalc1.UseVisualStyleBackColor = true;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(128, 65);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(40, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "=";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnCalc1);
            this.Controls.Add(this.lblAns2);
            this.Controls.Add(this.lblAns1);
            this.Controls.Add(this.lblExp2);
            this.Controls.Add(this.lblExp1);
            this.Name = "Form1";
            this.Text = "演算子の優先順位";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExp1;
        private System.Windows.Forms.Label lblExp2;
        private System.Windows.Forms.Label lblAns1;
        private System.Windows.Forms.Label lblAns2;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.Button btnCalc;
    }
}

