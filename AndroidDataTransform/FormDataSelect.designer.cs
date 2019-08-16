using System.Windows.Forms;

namespace AndroidDataTransform
{
    partial class FormDataSelect
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://blog.csdn.net/omguare");

        }
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbDevices = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txbDeviceInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudWaitTime = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lsbFiles = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbPcPath = new YEControl.YESelectPathBox_XML();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaitTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDownload.Location = new System.Drawing.Point(373, 16);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(101, 32);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "↓下载到电脑(&D)";
            this.toolTip1.SetToolTip(this.btnDownload, "将设备上的数据Copy到电脑上");
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.Enabled = false;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.Location = new System.Drawing.Point(373, 16);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(101, 32);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "↑上传到PAD (&U)";
            this.toolTip1.SetToolTip(this.btnUpload, "将PC上的数据导入到设备");
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PC 路径：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "设备序号：";
            // 
            // cbbDevices
            // 
            this.cbbDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbDevices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbDevices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDevices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbDevices.FormattingEnabled = true;
            this.cbbDevices.Location = new System.Drawing.Point(72, 14);
            this.cbbDevices.Name = "cbbDevices";
            this.cbbDevices.Size = new System.Drawing.Size(458, 20);
            this.cbbDevices.TabIndex = 3;
            this.cbbDevices.SelectedIndexChanged += new System.EventHandler(this.cbbDevices_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.Location = new System.Drawing.Point(206, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 32);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "刷新(&R)";
            this.toolTip1.SetToolTip(this.btnRefresh, "刷新");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoEllipsis = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(12, 252);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(518, 23);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // txbDeviceInfo
            // 
            this.txbDeviceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDeviceInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDeviceInfo.Location = new System.Drawing.Point(72, 40);
            this.txbDeviceInfo.Name = "txbDeviceInfo";
            this.txbDeviceInfo.Size = new System.Drawing.Size(458, 14);
            this.txbDeviceInfo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txbDeviceInfo, "当前的设备信息");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "设备信息：";
            // 
            // nudWaitTime
            // 
            this.nudWaitTime.Location = new System.Drawing.Point(61, 22);
            this.nudWaitTime.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudWaitTime.Name = "nudWaitTime";
            this.nudWaitTime.Size = new System.Drawing.Size(52, 21);
            this.nudWaitTime.TabIndex = 12;
            this.toolTip1.SetToolTip(this.nudWaitTime, "读取数据的超时时间[毫秒]");
            this.nudWaitTime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudWaitTime.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(457, 297);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 12);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "By:omguare";
            this.toolTip1.SetToolTip(this.linkLabel1, "omguare制作");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "DB文件(*.db)|*.db|DB3文件(*.db3)|*.db3|所有文件(*.*)|*.*";
            // 
            // lsbFiles
            // 
            this.lsbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbFiles.FormattingEnabled = true;
            this.lsbFiles.ItemHeight = 12;
            this.lsbFiles.Location = new System.Drawing.Point(72, 63);
            this.lsbFiles.Name = "lsbFiles";
            this.lsbFiles.Size = new System.Drawing.Size(458, 88);
            this.lsbFiles.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.nudWaitTime);
            this.panel1.Location = new System.Drawing.Point(14, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 64);
            this.panel1.TabIndex = 15;
            // 
            // cbbPcPath
            // 
            this.cbbPcPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbPcPath.ControlLogKey = "";
            this.cbbPcPath.Location = new System.Drawing.Point(72, 226);
            this.cbbPcPath.Name = "cbbPcPath";
            this.cbbPcPath.Size = new System.Drawing.Size(458, 20);
            this.cbbPcPath.TabIndex = 13;
            // 
            // FormDataSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 321);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsbFiles);
            this.Controls.Add(this.cbbPcPath);
            this.Controls.Add(this.txbDeviceInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cbbDevices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDataSelect";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAD数据传输工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudWaitTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComboBox cbbDevices;
        private Button btnRefresh;
        private Label lblInfo;
        private TextBox txbDeviceInfo;
        private Label label5;
        private NumericUpDown nudWaitTime;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
        private YEControl.YESelectPathBox_XML cbbPcPath;
        private ListBox lsbFiles;
        private Panel panel1;
        private LinkLabel linkLabel1;
    }
}

