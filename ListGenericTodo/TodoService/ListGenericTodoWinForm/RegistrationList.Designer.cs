namespace ListGenericTodoWinForm
{
    partial class RegistrationList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grp_list = new System.Windows.Forms.GroupBox();
            this.grid_list = new System.Windows.Forms.DataGridView();
            this.btn_Alllist = new System.Windows.Forms.Button();
            this.btn_completed = new System.Windows.Forms.Button();
            this.btn_uncompleted = new System.Windows.Forms.Button();
            this.btn_Canceled = new System.Windows.Forms.Button();
            this.btn_waiting = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grp_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_list)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_waiting);
            this.groupBox1.Controls.Add(this.btn_Canceled);
            this.groupBox1.Controls.Add(this.btn_uncompleted);
            this.groupBox1.Controls.Add(this.btn_completed);
            this.groupBox1.Controls.Add(this.btn_Alllist);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // grp_list
            // 
            this.grp_list.Controls.Add(this.grid_list);
            this.grp_list.Location = new System.Drawing.Point(180, 12);
            this.grp_list.Name = "grp_list";
            this.grp_list.Size = new System.Drawing.Size(805, 377);
            this.grp_list.TabIndex = 1;
            this.grp_list.TabStop = false;
            this.grp_list.Text = "List";
            // 
            // grid_list
            // 
            this.grid_list.AllowUserToAddRows = false;
            this.grid_list.AllowUserToDeleteRows = false;
            this.grid_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_list.Location = new System.Drawing.Point(3, 16);
            this.grid_list.Name = "grid_list";
            this.grid_list.ReadOnly = true;
            this.grid_list.Size = new System.Drawing.Size(799, 358);
            this.grid_list.TabIndex = 0;
            // 
            // btn_Alllist
            // 
            this.btn_Alllist.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Alllist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Alllist.Location = new System.Drawing.Point(16, 36);
            this.btn_Alllist.Name = "btn_Alllist";
            this.btn_Alllist.Size = new System.Drawing.Size(140, 41);
            this.btn_Alllist.TabIndex = 0;
            this.btn_Alllist.Text = "All List";
            this.btn_Alllist.UseVisualStyleBackColor = false;
            this.btn_Alllist.Click += new System.EventHandler(this.btn_Alllist_Click);
            // 
            // btn_completed
            // 
            this.btn_completed.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_completed.Location = new System.Drawing.Point(16, 83);
            this.btn_completed.Name = "btn_completed";
            this.btn_completed.Size = new System.Drawing.Size(140, 41);
            this.btn_completed.TabIndex = 0;
            this.btn_completed.Text = "Completed";
            this.btn_completed.UseVisualStyleBackColor = false;
            this.btn_completed.Click += new System.EventHandler(this.btn_completed_Click);
            // 
            // btn_uncompleted
            // 
            this.btn_uncompleted.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_uncompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uncompleted.Location = new System.Drawing.Point(16, 130);
            this.btn_uncompleted.Name = "btn_uncompleted";
            this.btn_uncompleted.Size = new System.Drawing.Size(140, 41);
            this.btn_uncompleted.TabIndex = 0;
            this.btn_uncompleted.Text = "Uncompleted";
            this.btn_uncompleted.UseVisualStyleBackColor = false;
            this.btn_uncompleted.Click += new System.EventHandler(this.btn_uncompleted_Click);
            // 
            // btn_Canceled
            // 
            this.btn_Canceled.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Canceled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Canceled.Location = new System.Drawing.Point(16, 177);
            this.btn_Canceled.Name = "btn_Canceled";
            this.btn_Canceled.Size = new System.Drawing.Size(140, 41);
            this.btn_Canceled.TabIndex = 0;
            this.btn_Canceled.Text = "Canceled";
            this.btn_Canceled.UseVisualStyleBackColor = false;
            this.btn_Canceled.Click += new System.EventHandler(this.btn_Canceled_Click);
            // 
            // btn_waiting
            // 
            this.btn_waiting.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_waiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_waiting.Location = new System.Drawing.Point(16, 224);
            this.btn_waiting.Name = "btn_waiting";
            this.btn_waiting.Size = new System.Drawing.Size(140, 39);
            this.btn_waiting.TabIndex = 1;
            this.btn_waiting.Text = "Waiting";
            this.btn_waiting.UseVisualStyleBackColor = false;
            this.btn_waiting.Click += new System.EventHandler(this.btn_waiting_Click);
            // 
            // RegistrationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(987, 401);
            this.Controls.Add(this.grp_list);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo Registration List";
            this.Load += new System.EventHandler(this.RegistrationList_Load);
            this.groupBox1.ResumeLayout(false);
            this.grp_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grp_list;
        private System.Windows.Forms.DataGridView grid_list;
        private System.Windows.Forms.Button btn_Canceled;
        private System.Windows.Forms.Button btn_uncompleted;
        private System.Windows.Forms.Button btn_completed;
        private System.Windows.Forms.Button btn_Alllist;
        private System.Windows.Forms.Button btn_waiting;
    }
}