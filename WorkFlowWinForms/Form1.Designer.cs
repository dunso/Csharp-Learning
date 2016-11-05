namespace WorkFlowWinForms
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
            this.btnWorkFlowStart = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtBookMarkName = new System.Windows.Forms.TextBox();
            this.btnStateWorkflowStart = new System.Windows.Forms.Button();
            this.btnStateLeaveWFStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWorkFlowStart
            // 
            this.btnWorkFlowStart.Location = new System.Drawing.Point(12, 59);
            this.btnWorkFlowStart.Name = "btnWorkFlowStart";
            this.btnWorkFlowStart.Size = new System.Drawing.Size(85, 23);
            this.btnWorkFlowStart.TabIndex = 0;
            this.btnWorkFlowStart.Text = "WorkFlowStart";
            this.btnWorkFlowStart.UseVisualStyleBackColor = true;
            this.btnWorkFlowStart.Click += new System.EventHandler(this.btnWorkFlowStart_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(12, 98);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(85, 23);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(115, 101);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(143, 20);
            this.txtDays.TabIndex = 3;
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // txtBookMarkName
            // 
            this.txtBookMarkName.Location = new System.Drawing.Point(115, 62);
            this.txtBookMarkName.Name = "txtBookMarkName";
            this.txtBookMarkName.Size = new System.Drawing.Size(143, 20);
            this.txtBookMarkName.TabIndex = 1;
            this.txtBookMarkName.TextChanged += new System.EventHandler(this.txtBookMarkName_TextChanged);
            // 
            // btnStateWorkflowStart
            // 
            this.btnStateWorkflowStart.Location = new System.Drawing.Point(12, 143);
            this.btnStateWorkflowStart.Name = "btnStateWorkflowStart";
            this.btnStateWorkflowStart.Size = new System.Drawing.Size(111, 23);
            this.btnStateWorkflowStart.TabIndex = 4;
            this.btnStateWorkflowStart.Text = "StateWorkflowStart";
            this.btnStateWorkflowStart.UseVisualStyleBackColor = true;
            this.btnStateWorkflowStart.Click += new System.EventHandler(this.btnStateWorkflowStart_Click);
            // 
            // btnStateLeaveWFStart
            // 
            this.btnStateLeaveWFStart.Location = new System.Drawing.Point(12, 186);
            this.btnStateLeaveWFStart.Name = "btnStateLeaveWFStart";
            this.btnStateLeaveWFStart.Size = new System.Drawing.Size(117, 23);
            this.btnStateLeaveWFStart.TabIndex = 5;
            this.btnStateLeaveWFStart.Text = "StateLeaveWFStart";
            this.btnStateLeaveWFStart.UseVisualStyleBackColor = true;
            this.btnStateLeaveWFStart.Click += new System.EventHandler(this.btnStateLeaveWFStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnStateLeaveWFStart);
            this.Controls.Add(this.btnStateWorkflowStart);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtBookMarkName);
            this.Controls.Add(this.btnWorkFlowStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWorkFlowStart;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtBookMarkName;
        private System.Windows.Forms.Button btnStateWorkflowStart;
        private System.Windows.Forms.Button btnStateLeaveWFStart;
    }
}

