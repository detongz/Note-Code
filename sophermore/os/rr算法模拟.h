#ifndef HEAD_H
#define HEAD_H
#include<queue>
#include<time.h>

using namespace std;

//debugging
int countTime = 0;


class singlePro{
public:
    int num;
    char name;


    //为每个节点内变量赋值
    void init(int i =0){
        cout<<"\ninput number:";
        cin>>num;
        name = 65 + i;
    }
};




class processes{
private:
    int timeSlice;
    queue<singlePro*> head;
public:
    processes();
    void roundRobin();
    void queueing();
    bool execP();


    ~processes(){
        while(!head.empty())
            head.pop();
    }
};


void processes::roundRobin(){
    cout<<"set time slice:";
    cin>>timeSlice;
    singlePro *p;
    //队列不为空时循环
    while(!head.empty() && countTime < 20){
        p = head.front();
        if(p->num >= 0){
            execP();
        }
        else
            head.pop();
    }
}

bool processes::execP(){
    singlePro *p = head.front();
    cout<<"\nprocess "<<p->name<<" is running!";
    if(p->num > timeSlice){
        p->num -= timeSlice;
        queueing();
    }
    else head.pop();
}

void processes::queueing(){
    singlePro *p = head.front();
    head.pop();
    head.push(p);
    countTime++;
}


processes::processes(){
    int j;
    for(j = 0; j < 3 ; j++){
        singlePro *p = new singlePro;
        p->init(j);
        head.push(p);
    }
    roundRobin();
}

#endif // HEAD_H
