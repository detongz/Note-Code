

#include <queue>
#include<iostream>
using namespace std;
int countTime = 0;
int wait[]={0,0,0};

class singlePro{
public:
    int num;//区间时间
    int name;
    singlePro *next = NULL;

    //为每个节点内变量赋值
    void init(int i =0){
        cout<<"\ninput number:";
        cin>>num;
        name = i;
    }
};


class processes{
private:
    singlePro* head, *tail;
public:
    processes();
    void runMIN();
};

//找到运行时间最短的节点，将该节点从链表中取出
void processes::runMIN(){
    singlePro *p = head;
    singlePro *minNode = p;
    singlePro *minPre = NULL;
    singlePro *curPre = NULL;
    int min = p->num;

    while(p->next){
        curPre = p;
        p = p->next;
        if(p->num < min){
            min = p->num;
            minNode = p;
            minPre = curPre;
        }
    }

    if(minNode){
        if(minPre)
            minPre->next = minNode->next;
        else
            head = minNode->next;
        cout<<"process "<<minNode->name<<" running"<<endl;
        wait[minNode->name]= countTime;
        countTime+=minNode->num;
        delete minNode;
    }
}

//初始化每个模拟的进程，并模拟进程的运行
processes::processes(){
    int i;
    singlePro *p;

    head = tail = p = new singlePro;
    p->init();

    for(i = 1; i < 3; i++){
        p = new singlePro;
        p->init(i);
        tail->next = p;
        tail = p;
    }
    cout<<endl;
    while(head)
        runMIN();
    double ave = (wait[0]+wait[1]+wait[2])/3.0;
    cout<<endl<<endl<<"average waiting time is :  "<<ave<<endl;
}


int main()
{
    processes p;
}

