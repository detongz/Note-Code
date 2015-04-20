//参考以上示例程序中建立并发进程的方法,
//编写一个多进程并发执行程序。
//父进程首先创建一个执行 ls 命令的子进程
//然后再创建一个执行 ps 命令的子进程,并控制
//ps 命令(child)总在 ls 命令(parent)之前执行。
#include<sys/types.h>
#include<wait.h>
#include<unistd.h>
#include<signal.h>
#include<stdio.h>
#include<stdlib.h>
#include<iostream>
using namespace std;

int main(int argc, char *argv[]){
    int i;
    int pid;
    int status;

    char *args[] = {"/bin/ls","-a",NULL};
    char *args2[] = {"/bin/ps","-f",NULL};
    pid = fork();

    if(pid < 0){
        printf("create process fail!\n");
        exit(EXIT_FAILURE);
    }

    if(pid==0){
        printf("child running\n");
        printf("\n\n");
        status = execve(args2[0],&args2[0], NULL);
        printf("\n\n");
    }
    else{
        printf("parent running\n");
        waitpid(pid, &status, 0);
        printf("\n\n");
        status = execve(args[0],&args[0],NULL);
        printf("\n\n");
    }
    return EXIT_SUCCESS;

}
