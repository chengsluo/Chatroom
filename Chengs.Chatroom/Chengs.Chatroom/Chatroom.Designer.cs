namespace Chengs.Chatroom
{
    partial class ChatroomUI
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.All = new System.Windows.Forms.TableLayoutPanel();
            this.Head = new System.Windows.Forms.TableLayoutPanel();
            this.label_IPAddr = new System.Windows.Forms.Label();
            this.label_Port = new System.Windows.Forms.Label();
            this.label_Nickname = new System.Windows.Forms.Label();
            this.button_Connection = new System.Windows.Forms.Button();
            this.textBox_IPAddr = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_Nickname = new System.Windows.Forms.TextBox();
            this.Tail = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Edit = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.All.SuspendLayout();
            this.Head.SuspendLayout();
            this.Tail.SuspendLayout();
            this.SuspendLayout();
            // 
            // All
            // 
            this.All.ColumnCount = 1;
            this.All.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.All.Controls.Add(this.Head, 0, 0);
            this.All.Controls.Add(this.Tail, 0, 2);
            this.All.Controls.Add(this.listView1, 0, 1);
            this.All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.All.Location = new System.Drawing.Point(0, 0);
            this.All.Name = "All";
            this.All.RowCount = 3;
            this.All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.7033F));
            this.All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.2967F));
            this.All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.All.Size = new System.Drawing.Size(675, 546);
            this.All.TabIndex = 0;
            // 
            // Head
            // 
            this.Head.ColumnCount = 5;
            this.Head.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.02281F));
            this.Head.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.97719F));
            this.Head.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.Head.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.Head.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.Head.Controls.Add(this.label_IPAddr, 0, 0);
            this.Head.Controls.Add(this.label_Port, 0, 1);
            this.Head.Controls.Add(this.label_Nickname, 2, 0);
            this.Head.Controls.Add(this.button_Connection, 4, 1);
            this.Head.Controls.Add(this.textBox_IPAddr, 1, 0);
            this.Head.Controls.Add(this.textBox_Port, 1, 1);
            this.Head.Controls.Add(this.textBox_Nickname, 3, 0);
            this.Head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Head.Location = new System.Drawing.Point(3, 3);
            this.Head.Name = "Head";
            this.Head.RowCount = 2;
            this.Head.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Head.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Head.Size = new System.Drawing.Size(669, 73);
            this.Head.TabIndex = 0;
            // 
            // label_IPAddr
            // 
            this.label_IPAddr.AutoSize = true;
            this.label_IPAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_IPAddr.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_IPAddr.Location = new System.Drawing.Point(3, 0);
            this.label_IPAddr.Name = "label_IPAddr";
            this.label_IPAddr.Size = new System.Drawing.Size(119, 36);
            this.label_IPAddr.TabIndex = 0;
            this.label_IPAddr.Text = "IP地址";
            this.label_IPAddr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Port.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Port.Location = new System.Drawing.Point(3, 36);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(119, 37);
            this.label_Port.TabIndex = 1;
            this.label_Port.Text = "端口号";
            this.label_Port.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Nickname
            // 
            this.label_Nickname.AutoSize = true;
            this.label_Nickname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Nickname.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Nickname.Location = new System.Drawing.Point(333, 0);
            this.label_Nickname.Name = "label_Nickname";
            this.label_Nickname.Size = new System.Drawing.Size(80, 36);
            this.label_Nickname.TabIndex = 2;
            this.label_Nickname.Text = "昵称";
            this.label_Nickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Connection
            // 
            this.button_Connection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Connection.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Connection.Location = new System.Drawing.Point(530, 39);
            this.button_Connection.Name = "button_Connection";
            this.button_Connection.Size = new System.Drawing.Size(136, 31);
            this.button_Connection.TabIndex = 3;
            this.button_Connection.Text = "连接到服务器";
            this.button_Connection.UseVisualStyleBackColor = true;
            this.button_Connection.Click += new System.EventHandler(this.button_Connection_Click);
            // 
            // textBox_IPAddr
            // 
            this.textBox_IPAddr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_IPAddr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_IPAddr.Location = new System.Drawing.Point(128, 3);
            this.textBox_IPAddr.Name = "textBox_IPAddr";
            this.textBox_IPAddr.Size = new System.Drawing.Size(199, 29);
            this.textBox_IPAddr.TabIndex = 4;
            this.textBox_IPAddr.Text = "182.254.246.75";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Port.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Port.Location = new System.Drawing.Point(128, 39);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(199, 29);
            this.textBox_Port.TabIndex = 5;
            this.textBox_Port.Text = "1234";
            // 
            // textBox_Nickname
            // 
            this.textBox_Nickname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Nickname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Nickname.Location = new System.Drawing.Point(419, 3);
            this.textBox_Nickname.Name = "textBox_Nickname";
            this.textBox_Nickname.Size = new System.Drawing.Size(105, 29);
            this.textBox_Nickname.TabIndex = 6;
            this.textBox_Nickname.Text = "Chengs";
            // 
            // Tail
            // 
            this.Tail.ColumnCount = 2;
            this.Tail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.54607F));
            this.Tail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.45392F));
            this.Tail.Controls.Add(this.textBox_Edit, 0, 0);
            this.Tail.Controls.Add(this.button_Send, 1, 0);
            this.Tail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tail.Location = new System.Drawing.Point(3, 475);
            this.Tail.Name = "Tail";
            this.Tail.RowCount = 1;
            this.Tail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tail.Size = new System.Drawing.Size(669, 68);
            this.Tail.TabIndex = 1;
            // 
            // textBox_Edit
            // 
            this.textBox_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Edit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Edit.Location = new System.Drawing.Point(3, 3);
            this.textBox_Edit.Multiline = true;
            this.textBox_Edit.Name = "textBox_Edit";
            this.textBox_Edit.Size = new System.Drawing.Size(532, 62);
            this.textBox_Edit.TabIndex = 1;
            // 
            // button_Send
            // 
            this.button_Send.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Send.Location = new System.Drawing.Point(558, 20);
            this.button_Send.Margin = new System.Windows.Forms.Padding(20);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(64, 28);
            this.button_Send.TabIndex = 0;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.All.SetColumnSpan(this.listView1, 2);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(669, 387);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "昵称";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "消息";
            this.columnHeader2.Width = 530;
            // 
            // ChatroomUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 546);
            this.Controls.Add(this.All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChatroomUI";
            this.Text = "即时聊天工具";
            this.All.ResumeLayout(false);
            this.Head.ResumeLayout(false);
            this.Head.PerformLayout();
            this.Tail.ResumeLayout(false);
            this.Tail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel All;
        private System.Windows.Forms.TableLayoutPanel Head;
        private System.Windows.Forms.Label label_IPAddr;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Label label_Nickname;
        private System.Windows.Forms.Button button_Connection;
        private System.Windows.Forms.TextBox textBox_IPAddr;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_Nickname;
        private System.Windows.Forms.TableLayoutPanel Tail;
        private System.Windows.Forms.TextBox textBox_Edit;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

