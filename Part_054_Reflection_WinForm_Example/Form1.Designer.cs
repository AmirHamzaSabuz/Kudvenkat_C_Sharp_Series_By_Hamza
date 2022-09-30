namespace Part_054_Reflection_WinForm_Example
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstConstructors = new System.Windows.Forms.ListBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.lstMethods = new System.Windows.Forms.ListBox();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(592, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Discover Type Information";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstConstructors
            // 
            this.lstConstructors.FormattingEnabled = true;
            this.lstConstructors.ItemHeight = 20;
            this.lstConstructors.Location = new System.Drawing.Point(608, 142);
            this.lstConstructors.Name = "lstConstructors";
            this.lstConstructors.Size = new System.Drawing.Size(274, 444);
            this.lstConstructors.TabIndex = 3;
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(14, 70);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(461, 27);
            this.txtTypeName.TabIndex = 4;
            this.txtTypeName.TextChanged += new System.EventHandler(this.txtTypeName_TextChanged);
            this.txtTypeName.Enter += new System.EventHandler(this.txtTypeName_Enter);
            this.txtTypeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTypeName_KeyDown);
            this.txtTypeName.MouseEnter += new System.EventHandler(this.txtTypeName_MouseEnter);
            // 
            // lstMethods
            // 
            this.lstMethods.FormattingEnabled = true;
            this.lstMethods.ItemHeight = 20;
            this.lstMethods.Location = new System.Drawing.Point(14, 142);
            this.lstMethods.Name = "lstMethods";
            this.lstMethods.Size = new System.Drawing.Size(274, 444);
            this.lstMethods.TabIndex = 5;
            // 
            // lstProperties
            // 
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.ItemHeight = 20;
            this.lstProperties.Location = new System.Drawing.Point(310, 142);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(274, 444);
            this.lstProperties.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Methods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Constructors";
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.BackColor = System.Drawing.Color.Red;
            this.lblEx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEx.ForeColor = System.Drawing.Color.White;
            this.lblEx.Location = new System.Drawing.Point(14, 596);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(156, 28);
            this.lblEx.TabIndex = 11;
            this.lblEx.Text = "Exception: Null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(723, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "In the textbox bellow write System.Windows.Forms.TextBox, System.Windows.Forms or" +
    " System.Int32";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 635);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lstMethods);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.lstConstructors);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Reflection Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ListBox lstConstructors;
        private TextBox txtTypeName;
        private ListBox lstMethods;
        private ListBox lstProperties;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblEx;
        private Label label5;
    }
}