namespace MVVMCreater
{
    partial class ToolForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMainVmName = new System.Windows.Forms.TextBox();
            this.btnCreateScripts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewGListVmName = new System.Windows.Forms.ListBox();
            this.textBoxGListVmName = new System.Windows.Forms.TextBox();
            this.BtnAddGlistVmName = new System.Windows.Forms.Button();
            this.BtnRemoveGlistVmName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCommomVmName = new System.Windows.Forms.TextBox();
            this.BtnAddCommomVmName = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxIsGlist = new System.Windows.Forms.CheckBox();
            this.textBoxVmScriptName = new System.Windows.Forms.TextBox();
            this.btnCreateSingleVm = new System.Windows.Forms.Button();
            this.listBoxCommomVmName = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMainVmName
            // 
            this.tbMainVmName.Location = new System.Drawing.Point(181, 34);
            this.tbMainVmName.Name = "tbMainVmName";
            this.tbMainVmName.Size = new System.Drawing.Size(192, 21);
            this.tbMainVmName.TabIndex = 0;
            // 
            // btnCreateScripts
            // 
            this.btnCreateScripts.Location = new System.Drawing.Point(238, 393);
            this.btnCreateScripts.Name = "btnCreateScripts";
            this.btnCreateScripts.Size = new System.Drawing.Size(75, 23);
            this.btnCreateScripts.TabIndex = 1;
            this.btnCreateScripts.Text = "生成代码";
            this.btnCreateScripts.UseVisualStyleBackColor = true;
            this.btnCreateScripts.Click += new System.EventHandler(this.btnCreateScripts_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(183, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "window的主Vm创建";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "列表绑定（VM类名）";
            // 
            // listViewGListVmName
            // 
            this.listViewGListVmName.FormattingEnabled = true;
            this.listViewGListVmName.ItemHeight = 12;
            this.listViewGListVmName.Location = new System.Drawing.Point(31, 85);
            this.listViewGListVmName.Name = "listViewGListVmName";
            this.listViewGListVmName.Size = new System.Drawing.Size(251, 136);
            this.listViewGListVmName.TabIndex = 5;
            // 
            // textBoxGListVmName
            // 
            this.textBoxGListVmName.Location = new System.Drawing.Point(31, 227);
            this.textBoxGListVmName.Name = "textBoxGListVmName";
            this.textBoxGListVmName.Size = new System.Drawing.Size(251, 21);
            this.textBoxGListVmName.TabIndex = 6;
            // 
            // BtnAddGlistVmName
            // 
            this.BtnAddGlistVmName.Location = new System.Drawing.Point(29, 267);
            this.BtnAddGlistVmName.Name = "BtnAddGlistVmName";
            this.BtnAddGlistVmName.Size = new System.Drawing.Size(130, 23);
            this.BtnAddGlistVmName.TabIndex = 7;
            this.BtnAddGlistVmName.Text = "添加Glist绑定脚本";
            this.BtnAddGlistVmName.UseVisualStyleBackColor = true;
            this.BtnAddGlistVmName.Click += new System.EventHandler(this.BtnAddGlistVmName_Click);
            // 
            // BtnRemoveGlistVmName
            // 
            this.BtnRemoveGlistVmName.Location = new System.Drawing.Point(166, 266);
            this.BtnRemoveGlistVmName.Name = "BtnRemoveGlistVmName";
            this.BtnRemoveGlistVmName.Size = new System.Drawing.Size(116, 23);
            this.BtnRemoveGlistVmName.TabIndex = 8;
            this.BtnRemoveGlistVmName.Text = "删除列表内容";
            this.BtnRemoveGlistVmName.UseVisualStyleBackColor = true;
            this.BtnRemoveGlistVmName.Click += new System.EventHandler(this.BtnRemoveGlistVmName_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Location = new System.Drawing.Point(564, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 382);
            this.label3.TabIndex = 9;
            this.label3.Text = "|||||||||||||||||||||||||||||||||||||||||||";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "无列表界面绑定";
            // 
            // textBoxCommomVmName
            // 
            this.textBoxCommomVmName.Location = new System.Drawing.Point(318, 226);
            this.textBoxCommomVmName.Name = "textBoxCommomVmName";
            this.textBoxCommomVmName.Size = new System.Drawing.Size(214, 21);
            this.textBoxCommomVmName.TabIndex = 12;
            // 
            // BtnAddCommomVmName
            // 
            this.BtnAddCommomVmName.Location = new System.Drawing.Point(318, 267);
            this.BtnAddCommomVmName.Name = "BtnAddCommomVmName";
            this.BtnAddCommomVmName.Size = new System.Drawing.Size(137, 23);
            this.BtnAddCommomVmName.TabIndex = 13;
            this.BtnAddCommomVmName.Text = "添加无列表的绑定脚本";
            this.BtnAddCommomVmName.UseVisualStyleBackColor = true;
            this.BtnAddCommomVmName.Click += new System.EventHandler(this.BtnAddCommomVmName_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "删除列表内容";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(164, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "需要选中列表内容";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(460, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "需要选中列表内容";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Location = new System.Drawing.Point(598, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "单个Vm+bind创建";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxIsGlist
            // 
            this.checkBoxIsGlist.AutoSize = true;
            this.checkBoxIsGlist.Location = new System.Drawing.Point(600, 122);
            this.checkBoxIsGlist.Name = "checkBoxIsGlist";
            this.checkBoxIsGlist.Size = new System.Drawing.Size(96, 16);
            this.checkBoxIsGlist.TabIndex = 19;
            this.checkBoxIsGlist.Text = "是否是绑列表";
            this.checkBoxIsGlist.UseVisualStyleBackColor = true;
            // 
            // textBoxVmScriptName
            // 
            this.textBoxVmScriptName.Location = new System.Drawing.Point(600, 144);
            this.textBoxVmScriptName.Name = "textBoxVmScriptName";
            this.textBoxVmScriptName.Size = new System.Drawing.Size(175, 21);
            this.textBoxVmScriptName.TabIndex = 20;
            // 
            // btnCreateSingleVm
            // 
            this.btnCreateSingleVm.Location = new System.Drawing.Point(600, 184);
            this.btnCreateSingleVm.Name = "btnCreateSingleVm";
            this.btnCreateSingleVm.Size = new System.Drawing.Size(75, 23);
            this.btnCreateSingleVm.TabIndex = 21;
            this.btnCreateSingleVm.Text = "生成代码";
            this.btnCreateSingleVm.UseVisualStyleBackColor = true;
            this.btnCreateSingleVm.Click += new System.EventHandler(this.btnCreateSingleVm_Click);
            // 
            // listBoxCommomVmName
            // 
            this.listBoxCommomVmName.FormattingEnabled = true;
            this.listBoxCommomVmName.ItemHeight = 12;
            this.listBoxCommomVmName.Location = new System.Drawing.Point(318, 86);
            this.listBoxCommomVmName.Name = "listBoxCommomVmName";
            this.listBoxCommomVmName.Size = new System.Drawing.Size(214, 136);
            this.listBoxCommomVmName.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxCommomVmName);
            this.Controls.Add(this.btnCreateSingleVm);
            this.Controls.Add(this.textBoxVmScriptName);
            this.Controls.Add(this.checkBoxIsGlist);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnAddCommomVmName);
            this.Controls.Add(this.textBoxCommomVmName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnRemoveGlistVmName);
            this.Controls.Add(this.BtnAddGlistVmName);
            this.Controls.Add(this.textBoxGListVmName);
            this.Controls.Add(this.listViewGListVmName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateScripts);
            this.Controls.Add(this.tbMainVmName);
            this.Name = "ToolForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMainVmName;
        private System.Windows.Forms.Button btnCreateScripts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listViewGListVmName;
        private System.Windows.Forms.TextBox textBoxGListVmName;
        private System.Windows.Forms.Button BtnAddGlistVmName;
        private System.Windows.Forms.Button BtnRemoveGlistVmName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCommomVmName;
        private System.Windows.Forms.Button BtnAddCommomVmName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxIsGlist;
        private System.Windows.Forms.TextBox textBoxVmScriptName;
        private System.Windows.Forms.Button btnCreateSingleVm;
        private System.Windows.Forms.ListBox listBoxCommomVmName;
        private System.Windows.Forms.Button button1;
    }
}

