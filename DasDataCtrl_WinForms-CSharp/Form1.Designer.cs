namespace DasDataCtrl_WinForms_CSharp
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
            this.Label2 = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTestMe = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtDSKey = new System.Windows.Forms.TextBox();
            this.txtAKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(50, 113);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "New line";
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(129, 113);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(402, 20);
            this.txtLine.TabIndex = 25;
            this.txtLine.Text = "12|44";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(547, 113);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(118, 23);
            this.btnAddNew.TabIndex = 24;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(45, 193);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(620, 354);
            this.DataGridView1.TabIndex = 23;
            // 
            // btnTestMe
            // 
            this.btnTestMe.Location = new System.Drawing.Point(545, 164);
            this.btnTestMe.Name = "btnTestMe";
            this.btnTestMe.Size = new System.Drawing.Size(120, 23);
            this.btnTestMe.TabIndex = 22;
            this.btnTestMe.Text = "Browse data";
            this.btnTestMe.UseVisualStyleBackColor = true;
            this.btnTestMe.Click += new System.EventHandler(this.btnTestMe_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(50, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "ds guid";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(50, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "access key";
            // 
            // txtDSKey
            // 
            this.txtDSKey.Location = new System.Drawing.Point(129, 62);
            this.txtDSKey.Name = "txtDSKey";
            this.txtDSKey.Size = new System.Drawing.Size(402, 20);
            this.txtDSKey.TabIndex = 19;
            // 
            // txtAKey
            // 
            this.txtAKey.Location = new System.Drawing.Point(129, 17);
            this.txtAKey.Name = "txtAKey";
            this.txtAKey.Size = new System.Drawing.Size(402, 20);
            this.txtAKey.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(126, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "123|555|454 (delimited text)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 581);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnTestMe);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtDSKey);
            this.Controls.Add(this.txtAKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtLine;
        internal System.Windows.Forms.Button btnAddNew;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button btnTestMe;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtDSKey;
        internal System.Windows.Forms.TextBox txtAKey;
        internal System.Windows.Forms.Label label3;
    }
}

