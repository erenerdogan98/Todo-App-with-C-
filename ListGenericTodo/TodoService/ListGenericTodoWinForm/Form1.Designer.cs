namespace ListGenericTodoWinForm
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
            this.components = new System.ComponentModel.Container();
            this.pnl_operations = new System.Windows.Forms.Panel();
            this.grpB_proceslist = new System.Windows.Forms.GroupBox();
            this.btn_newreg = new System.Windows.Forms.Button();
            this.btn_listreg = new System.Windows.Forms.Button();
            this.btn_closeapp = new System.Windows.Forms.Button();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.timer_ = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.pnl_operations.SuspendLayout();
            this.grpB_proceslist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_operations
            // 
            this.pnl_operations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl_operations.Controls.Add(this.grpB_proceslist);
            this.pnl_operations.Controls.Add(this.pictureBox1);
            this.pnl_operations.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_operations.Location = new System.Drawing.Point(0, 0);
            this.pnl_operations.Name = "pnl_operations";
            this.pnl_operations.Size = new System.Drawing.Size(200, 521);
            this.pnl_operations.TabIndex = 1;
            // 
            // grpB_proceslist
            // 
            this.grpB_proceslist.Controls.Add(this.btn_Remove);
            this.grpB_proceslist.Controls.Add(this.btn_closeapp);
            this.grpB_proceslist.Controls.Add(this.btn_listreg);
            this.grpB_proceslist.Controls.Add(this.btn_newreg);
            this.grpB_proceslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpB_proceslist.Location = new System.Drawing.Point(3, 177);
            this.grpB_proceslist.Name = "grpB_proceslist";
            this.grpB_proceslist.Size = new System.Drawing.Size(197, 344);
            this.grpB_proceslist.TabIndex = 3;
            this.grpB_proceslist.TabStop = false;
            this.grpB_proceslist.Text = "Process List";
            // 
            // btn_newreg
            // 
            this.btn_newreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_newreg.Location = new System.Drawing.Point(9, 21);
            this.btn_newreg.Name = "btn_newreg";
            this.btn_newreg.Size = new System.Drawing.Size(182, 49);
            this.btn_newreg.TabIndex = 0;
            this.btn_newreg.Text = "New Registration";
            this.btn_newreg.UseVisualStyleBackColor = false;
            this.btn_newreg.Click += new System.EventHandler(this.btn_newreg_Click);
            // 
            // btn_listreg
            // 
            this.btn_listreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_listreg.Location = new System.Drawing.Point(9, 76);
            this.btn_listreg.Name = "btn_listreg";
            this.btn_listreg.Size = new System.Drawing.Size(182, 49);
            this.btn_listreg.TabIndex = 0;
            this.btn_listreg.Text = "List Registration";
            this.btn_listreg.UseVisualStyleBackColor = false;
            this.btn_listreg.Click += new System.EventHandler(this.btn_listreg_Click);
            // 
            // btn_closeapp
            // 
            this.btn_closeapp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_closeapp.Location = new System.Drawing.Point(6, 186);
            this.btn_closeapp.Name = "btn_closeapp";
            this.btn_closeapp.Size = new System.Drawing.Size(182, 49);
            this.btn_closeapp.TabIndex = 0;
            this.btn_closeapp.Text = "Close App";
            this.btn_closeapp.UseVisualStyleBackColor = false;
            this.btn_closeapp.Click += new System.EventHandler(this.btn_closeapp_Click);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(818, 485);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(30, 13);
            this.lbl_timer.TabIndex = 2;
            this.lbl_timer.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = global::ListGenericTodoWinForm.Properties.Resources.ToDo_List_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Remove.Location = new System.Drawing.Point(6, 131);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(182, 49);
            this.btn_Remove.TabIndex = 0;
            this.btn_Remove.Text = "Remove Registration";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_closeapp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 521);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.pnl_operations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_operations.ResumeLayout(false);
            this.grpB_proceslist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_operations;
        private System.Windows.Forms.GroupBox grpB_proceslist;
        private System.Windows.Forms.Button btn_closeapp;
        private System.Windows.Forms.Button btn_listreg;
        private System.Windows.Forms.Button btn_newreg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Timer timer_;
        private System.Windows.Forms.Button btn_Remove;
    }
}

