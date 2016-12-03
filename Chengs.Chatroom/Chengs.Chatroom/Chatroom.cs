using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace Chengs.Chatroom
{
    public partial class ChatroomUI : Form
    {
        //客户端负责接收服务端发来的数据消息的线程
        Thread threadClient = null;
        //创建客户端套接字，负责连接服务器
        Socket socketClient = null;

        public ChatroomUI()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ShowMsg("开发者", "Hello World！");
        }

        private void button_Connection_Click(object sender, EventArgs e)
        {
            if (textBox_IPAddr.ReadOnly == false)
            {
                try
                {
                    if (Encoding.ASCII.GetBytes(textBox_Nickname.Text).Length >10)
                    {
                        ShowMsg("系统消息", "昵称过长,请重新设置");
                        return;
                    }
                    //获得文本框中的IP地址对象
                    IPAddress address = IPAddress.Parse(textBox_IPAddr.Text.Trim());
                    //创建包含IP和端口的网络节点对象
                    IPEndPoint endpoint = new IPEndPoint(address, int.Parse(textBox_Port.Text.Trim()));
                    //创建客户端套接字，负责连接服务器
                    socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    //客户端连接到服务器
                    socketClient.Connect(endpoint);
                    textBox_IPAddr.ReadOnly = true;
                    textBox_Nickname.ReadOnly = true;
                    textBox_Port.ReadOnly = true;
                    button_Connection.Text = "断开服务器";
                    ShowMsg("系统消息", "客户端连接服务器成功！");
                    this.Text = "欢迎" + textBox_Nickname.Text + "的使用!";
                    threadClient = new Thread(ReceiveMsg);
                    threadClient.IsBackground = true;
                    threadClient.Start();
                }
                catch (SocketException ex)
                {
                    ShowMsg("系统消息", "客户端连接服务器发生异常：" + ex.Message);
                }
                catch (Exception ex)
                {
                    ShowMsg("系统消息", "客户端连接服务器发生异常：" + ex.Message);
                }
            }
            else
            {
                socketClient.Close();
                textBox_IPAddr.ReadOnly = false;
                textBox_Nickname.ReadOnly = false;
                textBox_Port.ReadOnly = false;
                button_Connection.Text = "再次连接服务器";
            }

        }

        void ShowMsg(string user,string msg)
        {
            ListViewItem lv_item = listView1.Items.Add(user);
            int i = 0, j = 0, k = 0,f=1;
            string msg1;
            foreach (char chr in msg)
            {
                if ((int)chr > 127)
                {
                    i += 2;
                }
                else
                {
                    i++;
                }
                if (i >60*f)
                {
                    msg1 = msg.Substring(k,j-k);
                    lv_item.SubItems.Add(msg1);
                    lv_item = listView1.Items.Add(" ");
                    k =j;
                    f++;
                }
                j++;
            }
            msg1 = msg.Substring(k, j-k);
            lv_item.SubItems.Add(msg1);
            lv_item.EnsureVisible();
        }


        /// <summary>
        /// 监听服务端发来的消息
        /// </summary>
        void ReceiveMsg()
        {
            while (true)
            {
                //定义一个接收消息用的字节数组缓冲区（1000个char）
                byte[] arrMsgRev = new byte[1000*8];
                //将接收到的数据存入arrMsgRev,并返回真正接收到数据的长度
                int length = -1;
                try
                {
                    length = socketClient.Receive(arrMsgRev);
                }
                catch (SocketException ex)
                {
                    ShowMsg("系统消息", "Socket连接关闭，退出了聊天室");
                    break;
                }
                catch (Exception ex)
                {
                    ShowMsg("系统消息", "客户端接收消息时发生异常：" + ex.Message);
                    break;
                }

                //此时是将数组的所有元素（每个字节）都转成字符串，而真正接收到只有服务端发来的几个字符
                string strMsgReceive = Encoding.UTF8.GetString(arrMsgRev, 0, length);
                ShowMsg(strMsgReceive.Substring(0,10), strMsgReceive.Substring(10));
            }
        }
        //向服务器发送文本消息
        private void button_Send_Click(object sender, EventArgs e)
        {
            
            string strMsg = textBox_Edit.Text.Trim();
            //将字符串转成方便网络传送的二进制数组
            byte[] arrMsg = Encoding.UTF8.GetBytes(textBox_Nickname.Text.Trim().PadRight(10, ' ') + strMsg);
            byte[] arrMsgSend = new byte[arrMsg.Length];
           Buffer.BlockCopy(arrMsg, 0, arrMsgSend, 0,arrMsg.Length);
            try
            {
                socketClient.Send(arrMsgSend);

                //ShowMsg(textBox_Nickname.Text, strMsg);
                //清空发送消息文本框中的消息
                this.textBox_Edit.Text = "";
            }
            catch (SocketException ex)
            {
                ShowMsg("系统消息", "客户端发送消息时发生异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                ShowMsg("系统消息", "客户端发送消息时发生异常：" + ex.Message);
            }
        }
    }
}
