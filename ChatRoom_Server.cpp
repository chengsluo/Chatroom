#include <stdio.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <sys/time.h>
#include <stdlib.h>

#define PORT 1234               //服务器端口
#define BACKLOG 10               //listen队列中等待的连接数
#define MAXDATASIZE 1024        //缓冲区大小

typedef struct _CLIENT
{
    int fd;                     //客户端socket描述符
    struct sockaddr_in addr;    //客户端地址信息结构体
} CLIENT;

int main()
{
    int i, maxi, maxfd, sockfd;
    int nready;
    ssize_t n;
    fd_set rset, allset;        //select所需的文件描述符集合
    int listenfd, connectfd;    //socket文件描述符
    struct sockaddr_in server;  //服务器地址信息结构体

    CLIENT client[FD_SETSIZE];  //FD_SETSIZE为select函数支持的最大描述符个数
    char recvbuf[MAXDATASIZE];  //缓冲区
    int sin_size;               //地址信息结构体大小
	FILE *fp;

	if((fp=fopen("ChatRoom.log","a+"))==NULL){
		printf("Create ChatRoom.log Failed!\n");
		fflush(fp);
		exit(1);
	}
    if ((listenfd = socket(AF_INET, SOCK_STREAM, 0)) == -1)
    {
        //调用socket创建用于监听客户端的socket
        fprintf(fp,"ERROR:Create Creating socket failed.");
        fflush(fp);
        exit(1);
    }

     
    int opt = SO_REUSEADDR;
    setsockopt(listenfd, SOL_SOCKET, SO_REUSEADDR, &opt, sizeof(opt));  //设置socket属性

    bzero(&server, sizeof(server));
    server.sin_family = AF_INET;
    server.sin_port = htons(PORT);
    server.sin_addr.s_addr = htonl(INADDR_ANY);

    if (bind(listenfd, (struct sockaddr *)&server, sizeof(struct sockaddr)) == -1)
    {
        //调用bind绑定地址
        fprintf(fp,"Bind error.\n");
        fflush(fp);
        exit(1);
    }

    if (listen(listenfd, BACKLOG) == -1)
    {
        //调用listen开始监听
        fprintf(fp,"listen() error\n");
        fflush(fp);
        exit(1);
    }

    //初始化select
    maxfd = listenfd;
    maxi = -1;
    for (i = 0; i < FD_SETSIZE; i++)
    {
        client[i].fd = -1;
    }
    FD_ZERO(&allset);           //清空
    FD_SET(listenfd, &allset);  //将监听socket加入select检测的描述符集合

    while (1)
    {
        struct sockaddr_in addr;
        rset = allset;
        nready = select(maxfd + 1, &rset, NULL, NULL, NULL);    //调用select
        if (FD_ISSET(listenfd, &rset))                          //检测是否有新客户端请求
        {
            //调用accept，返回服务器与客户端连接的socket描述符
            sin_size = sizeof(struct sockaddr_in);
            if ((connectfd = accept(listenfd, (struct sockaddr *)&addr, (socklen_t *) & sin_size)) == -1)
            {
                fprintf(fp,"Accept() error\n");
                fflush(fp);
                continue;
            }
            //将新客户端的加入数组
            for (i = 0; i < FD_SETSIZE; i++)
            {
                if (client[i].fd < 0)
                {
                    client[i].fd = connectfd;   //保存客户端描述符
                    fprintf(fp,"System:临时编号为%d的已经进入聊天室\n",connectfd);
                	fflush(fp);
                    break;
                }
            }

            if (i == FD_SETSIZE){
                fprintf(fp,"Too many clients，Rejected！！\n");
                fflush(fp);
            }

            FD_SET(connectfd, &allset); //将新socket连接放入select监听集合,in this ,everything very be listen;
            if (connectfd > maxfd)
                maxfd = connectfd;  //确认maxfd是最大描述符
            if (i > maxi)       //数组最大元素值
                maxi = i;
            if (--nready <= 0)
                continue;       //如果没有新客户端连接，继续循环
        }
        for (i = 0; i <= maxi; i++)
        {
            if ((sockfd = client[i].fd) < 0)    //如果客户端描述符小于0，则没有客户端连接，检测下一个
                continue;
            // 有客户连接，检测是否有数据
            if (FD_ISSET(sockfd, &rset))
            {
                n = recv(sockfd, recvbuf, MAXDATASIZE, 0);
                if (n < 0)
                {
                	FD_CLR(sockfd, &allset); 
                	client[i].fd = -1; 
                    //从客户端socket读数据，小于0表示客户关闭了网络链接
                    fprintf(fp,"System:临时编号为%d的用户已经离开了聊天室\n",i);
                    fflush(fp);
                    break;
                }
                else if (n ==0)
                {
                    //从客户端socket读数据，等于0表示网络中断
                    
                    FD_CLR(sockfd, &allset);    //从监听集合中删除此socket连接
                    client[i].fd = -1;  //数组元素设初始值，表示没客户端连接
                    close(sockfd);  //关闭socket连接
                }
                else   //接收到客户数据，开始处理
                {
                    char sendbuf[MAXDATASIZE];
                    int i;
                    fprintf(fp,"CharRoom:%s\n", recvbuf);
                    fflush(fp);
                    for (i = 0; i < n; i++)
                        sendbuf[i] = recvbuf[i];
                    sendbuf[n] = '\0';
                    for (int j = 0; j<= maxi; j++)
                    {
                        if(client[j].fd >0)
                        {
                            send(client[j].fd, sendbuf, strlen(sendbuf), 0);
                        }
                    }
                }
                if (--nready <= 0)
                    break;      //如果没有新客户端有数据，跳出for循环回到while循环
            }
        }
    }
    fclose(fp);
    close(listenfd);            //关闭服务器监听socket
}
