namespace WFComboBox
{
    partial class Form1
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
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(87, 58);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(250, 34);
            this.cb1.TabIndex = 0;
            // 
            // cb2
            // 
            this.cb2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(445, 58);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(250, 34);
            this.cb2.TabIndex = 1;
            // 
            // cb3
            // 
            this.cb3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(87, 259);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(250, 34);
            this.cb3.TabIndex = 2;
            this.cb3.SelectedValueChanged += new System.EventHandler(this.cb3_SelectedValueChanged);
            // 
            // cb4
            // 
            this.cb4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb4.FormattingEnabled = true;
            this.cb4.Location = new System.Drawing.Point(445, 259);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(250, 34);
            this.cb4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb4;
    }
}

