#ifndef HEAD_H
#define HEAD_H

#include <queue>
#include<iostream>
using namespace std;

class singlePro{
public:
    int num;
    char name;
    singlePro *next = NULL;


    //为每个节点内变量赋值
    void init(int i =0){
        cout<<"\ninput number:";
        cin>>num;
        name = 65 + i;
    }
};


class processes{
private:
    singlePro* head, *tail;
public:
    processes();
    void sjf();
    void runMIN();
};

void processes::sjf(){
    cout<<endl;
    while(head)
        runMIN();
}


//find min 'rinnign time'and put it at the front of queue.
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
        delete minNode;
    }
}

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
    sjf();
}


#endif // HEAD_H

