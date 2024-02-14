namespace Processes
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
            this.rtbProcessName = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbProcessInfo = new System.Windows.Forms.Label();
            this.lvProcesses = new System.Windows.Forms.ListView();
            this.lbCountProcesses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbProcessName
            // 
            this.rtbProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbProcessName.Location = new System.Drawing.Point(13, 16);
            this.rtbProcessName.Name = "rtbProcessName";
            this.rtbProcessName.Size = new System.Drawing.Size(402, 23);
            this.rtbProcessName.TabIndex = 0;
            this.rtbProcessName.Text = "calc.exe";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(340, 45);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbProcessInfo
            // 
            this.lbProcessInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProcessInfo.AutoSize = true;
            this.lbProcessInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProcessInfo.Location = new System.Drawing.Point(462, 19);
            this.lbProcessInfo.Name = "lbProcessInfo";
            this.lbProcessInfo.Size = new System.Drawing.Size(246, 24);
            this.lbProcessInfo.TabIndex = 3;
            this.lbProcessInfo.Text = "нет выбранного процесса";
            // 
            // lvProcesses
            // 
            this.lvProcesses.FullRowSelect = true;
            this.lvProcesses.HideSelection = false;
            this.lvProcesses.Location = new System.Drawing.Point(15, 97);
            this.lvProcesses.Name = "lvProcesses";
            this.lvProcesses.Size = new System.Drawing.Size(400, 366);
            this.lvProcesses.TabIndex = 4;
            this.lvProcesses.UseCompatibleStateImageBehavior = false;
            this.lvProcesses.View = System.Windows.Forms.View.Details;
            this.lvProcesses.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvProcesses_ItemSelectionChanged);
            // 
            // lbCountProcesses
            // 
            this.lbCountProcesses.AutoSize = true;
            this.lbCountProcesses.Location = new System.Drawing.Point(380, 466);
            this.lbCountProcesses.Name = "lbCountProcesses";
            this.lbCountProcesses.Size = new System.Drawing.Size(35, 13);
            this.lbCountProcesses.TabIndex = 5;
            this.lbCountProcesses.Text = "Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 488);
            this.Controls.Add(this.lbCountProcesses);
            this.Controls.Add(this.lvProcesses);
            this.Controls.Add(this.lbProcessInfo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtbProcessName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbProcessName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbProcessInfo;
        private System.Windows.Forms.ListView lvProcesses;
        private System.Windows.Forms.Label lbCountProcesses;
    }
}

