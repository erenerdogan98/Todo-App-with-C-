namespace ListGenericTodoWinForm
{
    partial class NewRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_briefdesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_importance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_situation = new System.Windows.Forms.ComboBox();
            this.btn_newwReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(122, 34);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(199, 20);
            this.txt_title.TabIndex = 0;
            this.txt_title.Enter += new System.EventHandler(this.txt_title_Enter);
            this.txt_title.Leave += new System.EventHandler(this.txt_title_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Briefdescription";
            // 
            // txt_briefdesc
            // 
            this.txt_briefdesc.Location = new System.Drawing.Point(122, 60);
            this.txt_briefdesc.Multiline = true;
            this.txt_briefdesc.Name = "txt_briefdesc";
            this.txt_briefdesc.Size = new System.Drawing.Size(199, 70);
            this.txt_briefdesc.TabIndex = 1;
            this.txt_briefdesc.Enter += new System.EventHandler(this.txt_title_Enter);
            this.txt_briefdesc.Leave += new System.EventHandler(this.txt_title_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(30, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description";
            // 
            // txt_descr
            // 
            this.txt_descr.Location = new System.Drawing.Point(122, 136);
            this.txt_descr.Multiline = true;
            this.txt_descr.Name = "txt_descr";
            this.txt_descr.Size = new System.Drawing.Size(199, 70);
            this.txt_descr.TabIndex = 2;
            this.txt_descr.Enter += new System.EventHandler(this.txt_title_Enter);
            this.txt_descr.Leave += new System.EventHandler(this.txt_title_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(30, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Importance";
            // 
            // txt_importance
            // 
            this.txt_importance.Location = new System.Drawing.Point(122, 212);
            this.txt_importance.Name = "txt_importance";
            this.txt_importance.Size = new System.Drawing.Size(199, 20);
            this.txt_importance.TabIndex = 3;
            this.txt_importance.Enter += new System.EventHandler(this.txt_title_Enter);
            this.txt_importance.Leave += new System.EventHandler(this.txt_title_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(30, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Situation";
            // 
            // cmb_situation
            // 
            this.cmb_situation.FormattingEnabled = true;
            this.cmb_situation.Items.AddRange(new object[] {
            "Waiting",
            "Completed",
            "Could not complete",
            "Postponed",
            "Cancelled"});
            this.cmb_situation.Location = new System.Drawing.Point(122, 241);
            this.cmb_situation.Name = "cmb_situation";
            this.cmb_situation.Size = new System.Drawing.Size(199, 21);
            this.cmb_situation.TabIndex = 4;
            this.cmb_situation.Enter += new System.EventHandler(this.cmb_situation_Enter);
            this.cmb_situation.Leave += new System.EventHandler(this.cmb_situation_Leave);
            // 
            // btn_newwReg
            // 
            this.btn_newwReg.BackColor = System.Drawing.Color.Cyan;
            this.btn_newwReg.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_newwReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_newwReg.Location = new System.Drawing.Point(122, 268);
            this.btn_newwReg.Name = "btn_newwReg";
            this.btn_newwReg.Size = new System.Drawing.Size(199, 34);
            this.btn_newwReg.TabIndex = 5;
            this.btn_newwReg.Text = "New Registration";
            this.btn_newwReg.UseVisualStyleBackColor = false;
            this.btn_newwReg.Click += new System.EventHandler(this.btn_newwReg_Click);
            // 
            // NewRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(335, 305);
            this.Controls.Add(this.btn_newwReg);
            this.Controls.Add(this.cmb_situation);
            this.Controls.Add(this.txt_descr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_briefdesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_importance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo App - New Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_briefdesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_importance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_situation;
        private System.Windows.Forms.Button btn_newwReg;
    }
}