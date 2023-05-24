using System.Windows.Forms;

namespace SimpleStorage
{
    partial class SearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPriceTo = new System.Windows.Forms.TextBox();
            this.textBoxPriceFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxProce = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPriceTo
            // 
            this.textBoxPriceTo.Location = new System.Drawing.Point(584, 9);
            this.textBoxPriceTo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxPriceTo.Name = "textBoxPriceTo";
            this.textBoxPriceTo.Size = new System.Drawing.Size(125, 22);
            this.textBoxPriceTo.TabIndex = 14;
            // 
            // textBoxPriceFrom
            // 
            this.textBoxPriceFrom.Location = new System.Drawing.Point(419, 9);
            this.textBoxPriceFrom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxPriceFrom.Name = "textBoxPriceFrom";
            this.textBoxPriceFrom.Size = new System.Drawing.Size(125, 22);
            this.textBoxPriceFrom.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "до:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "ФИО ребенка";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 11);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 22);
            this.textBoxName.TabIndex = 10;
            // 
            // checkBoxProce
            // 
            this.checkBoxProce.AutoSize = true;
            this.checkBoxProce.Location = new System.Drawing.Point(324, 11);
            this.checkBoxProce.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBoxProce.Name = "checkBoxProce";
            this.checkBoxProce.Size = new System.Drawing.Size(83, 20);
            this.checkBoxProce.TabIndex = 9;
            this.checkBoxProce.Text = "Цена от:";
            this.checkBoxProce.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(716, 9);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(119, 25);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxPriceTo);
            this.Controls.Add(this.textBoxPriceFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.checkBoxProce);
            this.Controls.Add(this.buttonSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(852, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxPriceTo;
        private TextBox textBoxPriceFrom;
        private Label label3;
        private Label label2;
        private TextBox textBoxName;
        private CheckBox checkBoxProce;
        private Button buttonSearch;
    }
}
