#include<fstream>
#include<iostream>
#define NUM "201392436"
#define NAME "张德通"
using namespace std;

class word
{
public:
    word* next = NULL;
    string w;
};


class processingLines{
private:
    int counter = 0;
    word * head ,*tail, *pointer/*indicating current line, among all the words.*/;
    fstream f;
public:
    processingLines();
    void parsing(string);
    bool isSame(string);
    void addWord(string);
    ~processingLines();
};



void processingLines::parsing(string line){
    int i;
    string w = "";
    for(i = 0; i< line.length(); i++){
        if(line[i]!= ' ')
                w += line[i];
        else{
            if(line[i - 1]!= ' '){
                if(w == NUM)
                    w = NAME;
                if(!isSame(w))
                    addWord(w);
                cout<<w<<" ";
                w = "";
            }
        }
    }
}

void processingLines::addWord(string str){
    word *current = tail;
    tail = new word;
    current->next = tail;
    tail->w = str;
    counter++;
}

bool processingLines::isSame(string str){
    word *current = head;
    while(current){
        if(current->w == str)
            return true;
        current = current->next;
    }
    return false;
}


processingLines::processingLines(){
    string line;
    word *p = NULL;
    head = tail = new word;
    f.open("/home/zdt/Documents/qtWorkstation/parsing/test.txt");
    while(getline(f, line)){
        parsing(line);
        cout<<endl;
    }
    cout<<endl<<"The number of words are:"<<counter<<endl;
}

processingLines::~processingLines(){
    f.close();
    while(head){
        word *p = head;
        head = head->next;
        delete p;
    }
}


int main()
{
    processingLines p;
    return 0;
}

