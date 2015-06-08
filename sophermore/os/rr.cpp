#include<queue>
#include<iostream>
using namespace std;

int countTime = 0;//总时间
int wait[] = {0,0,0};//节点等待的时间
//节点类
class singlePro{
public:
    int num;//rr算法，
    int name;//每个节点的名称，a，b，c
    int time = 0;//上一次被调用结束的时间节点

    //为每个节点内变量赋值，节点初始化
    void init(int i =0){
        cout<<"\ninput number:";
        cin>>num;
        name = i;
    }
};



class processes{
private:
    int timeSlice;
    queue<singlePro*> head;
public:
    processes();
    void queueing();//模拟的进程没有执行完毕，调用此函数使当前进程排到队尾
    bool execP();//模拟执行进程

    //析构函数
    ~processes(){
        while(!head.empty())
            head.pop();
    }
};

//模拟执行进程
bool processes::execP(){
    singlePro *p = head.front();//队列中的头结点
    cout<<"\nprocess "<<p->name<<" is running!";
    //如果被模拟的进程需要执行的区间时间比时间片长，则将所需执行时间减去时间片的长度，并把未执行完毕的当前进程放到队列尾部等待下一次调用
    if(p->num > timeSlice){
        p->num -= timeSlice;
        wait[p->name]+=countTime - p->time;    //计算等待时间,该结点等待时间为（总时间-上一次调用结束时间）之和
        countTime+=timeSlice;//当前总运行时间增加
        p->time=countTime;//把更新上一次调用结束时间
        queueing();
    }
    //若如果被模拟的进程需要执行的区间时间比时间片短，则进程执行完毕，从队列中弹出
    else {
        head.pop();
        wait[p->name]+=countTime - p->time;
        countTime+=p->num;
        p->time=countTime;
        cout<<p->name<<"'s wating time is: "<<wait[p->name];
    }

}

//模拟的进程没有执行完毕，调用此函数使当前进程排到队尾
void processes::queueing(){
    singlePro *p = head.front();
    head.pop();
    head.push(p);
}

//初始化各个模拟进程节点
processes::processes(){
    int j;
    for(j = 0; j < 3 ; j++){
        singlePro *p = new singlePro;
        p->init(j);
        head.push(p);
    }
    //rr算法实现
    cout<<"set time slice:";//设置时间片大小
    cin>>timeSlice;
    //队列不为空时循环，直到队列为空，及所有节点都被弹出队列，模拟的所有进程都被执行完
    while(!head.empty())
            execP();
    double ave = (wait[0]+wait[1]+wait[2])/3.0;
    cout<<endl<<endl<<"average waiting time is :  "<<ave<<endl;
}


int main()
{
    processes p;
}
