namespace ForSedi
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ckbList_TaskItem = new System.Windows.Forms.CheckedListBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTaskCalStart = new System.Windows.Forms.Button();
            this.ckbSelectAll = new System.Windows.Forms.CheckBox();
            this.dgTaskTime = new System.Windows.Forms.DataGridView();
            this.usSelectFile_CT = new Tool.usSelectFile();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskTime)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbList_TaskItem
            // 
            this.ckbList_TaskItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbList_TaskItem.FormattingEnabled = true;
            this.ckbList_TaskItem.Location = new System.Drawing.Point(0, 54);
            this.ckbList_TaskItem.Name = "ckbList_TaskItem";
            this.ckbList_TaskItem.Size = new System.Drawing.Size(344, 615);
            this.ckbList_TaskItem.TabIndex = 1;
            this.ckbList_TaskItem.SelectedIndexChanged += new System.EventHandler(this.ckbList_TaskItem_SelectedIndexChanged);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1233, 701);
            this.tcMain.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.usSelectFile_CT);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1225, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CT2 執行時間分析";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1225, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "重新新增統計檔";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbList_TaskItem);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(878, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 669);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckbSelectAll);
            this.panel2.Controls.Add(this.btnTaskCalStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 54);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgTaskTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 615);
            this.panel3.TabIndex = 3;
            // 
            // btnTaskCalStart
            // 
            this.btnTaskCalStart.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTaskCalStart.Location = new System.Drawing.Point(226, 11);
            this.btnTaskCalStart.Name = "btnTaskCalStart";
            this.btnTaskCalStart.Size = new System.Drawing.Size(113, 31);
            this.btnTaskCalStart.TabIndex = 4;
            this.btnTaskCalStart.Text = "Start";
            this.btnTaskCalStart.UseVisualStyleBackColor = true;
            this.btnTaskCalStart.Click += new System.EventHandler(this.btnTaskCalStart_Click);
            // 
            // ckbSelectAll
            // 
            this.ckbSelectAll.AutoSize = true;
            this.ckbSelectAll.Location = new System.Drawing.Point(3, 20);
            this.ckbSelectAll.Name = "ckbSelectAll";
            this.ckbSelectAll.Size = new System.Drawing.Size(48, 16);
            this.ckbSelectAll.TabIndex = 0;
            this.ckbSelectAll.Text = "全選";
            this.ckbSelectAll.UseVisualStyleBackColor = true;
            this.ckbSelectAll.CheckedChanged += new System.EventHandler(this.ckbSelectAll_CheckedChanged);
            // 
            // dgTaskTime
            // 
            this.dgTaskTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaskTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTaskTime.Location = new System.Drawing.Point(0, 0);
            this.dgTaskTime.Name = "dgTaskTime";
            this.dgTaskTime.RowTemplate.Height = 24;
            this.dgTaskTime.Size = new System.Drawing.Size(875, 615);
            this.dgTaskTime.TabIndex = 0;
            // 
            // usSelectFile_CT
            // 
            this.usSelectFile_CT.Dock = System.Windows.Forms.DockStyle.Top;
            this.usSelectFile_CT.Location = new System.Drawing.Point(3, 3);
            this.usSelectFile_CT.Name = "usSelectFile_CT";
            this.usSelectFile_CT.Size = new System.Drawing.Size(875, 54);
            this.usSelectFile_CT.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 701);
            this.Controls.Add(this.tcMain);
            this.Name = "Form1";
            this.Text = "Tool for SEDI";
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Tool.usSelectFile usSelectFile_CT;
        private System.Windows.Forms.CheckedListBox ckbList_TaskItem;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTaskCalStart;
        private System.Windows.Forms.CheckBox ckbSelectAll;
        private System.Windows.Forms.DataGridView dgTaskTime;
    }
}

