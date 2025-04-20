namespace TaxCalc
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
            this.priceBox = new System.Windows.Forms.TextBox();
            this.taxPriceBox = new System.Windows.Forms.TextBox();
            this.cakcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceBox
            // 
            this.priceBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.priceBox.Location = new System.Drawing.Point(169, 53);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(268, 22);
            this.priceBox.TabIndex = 0;
            // 
            // taxPriceBox
            // 
            this.taxPriceBox.Enabled = false;
            this.taxPriceBox.Location = new System.Drawing.Point(169, 152);
            this.taxPriceBox.Name = "taxPriceBox";
            this.taxPriceBox.Size = new System.Drawing.Size(268, 22);
            this.taxPriceBox.TabIndex = 1;
            // 
            // cakcButton
            // 
            this.cakcButton.Location = new System.Drawing.Point(143, 224);
            this.cakcButton.Name = "cakcButton";
            this.cakcButton.Size = new System.Drawing.Size(192, 66);
            this.cakcButton.TabIndex = 2;
            this.cakcButton.Text = "計算する";
            this.cakcButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "税抜価格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "税込価格";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cakcButton);
            this.Controls.Add(this.taxPriceBox);
            this.Controls.Add(this.priceBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox taxPriceBox;
        private System.Windows.Forms.Button cakcButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

