#include<iostream>
using namespace std;

class word{
public:
    word* next = NULL;
    string w;
};

class count{
private:
    int counter = 0;
    string words;
    char *characters;
    word *head = NULL;
public:
    count();
    ~count(){
        delete characters;
        word *current = head;
        head = head->next;
        delete current;
    }
    void pick();
    void print();
    bool isSame(string);
    void addWord(string);
};

count::count(){
    cout<<"input words"<<endl;
    getline(cin,words);
    characters = new char[words.size()];
    for(int i = 0 ; i < words.size(); i++)
        characters[i] = words[i];
}

void count::pick(){
    int i;
    string current = "";
    for(i = 0; i < words.length();i++){
            if(words[i] != ' '){
                //            current.append(characters[i]);
                current += characters[i];
            }
            else if(words[i - 1] != ' '){
                if(!isSame(current)){
                    addWord(current);
                }
                current = "";
            }
    }
}

void count::addWord(string str){
    word *current = head;
    head = new word;
    head->next = current;
    head->w = str;
}

bool count::isSame(string str){
    word *current = head;
    while(current){
        if(current->w == str)
            return true;
        current = current->next;
    }
    return false;
}

void count::print(){
    word *current = head;
    cout<<endl<<"words are:"<<endl;
    while(current){
        cout<<(current->w)<<"\t";
        current = current->next;
        counter++;
    }
    cout<<endl<<"The number of words are:"<<counter<<endl;
}

int main(){
    count c;
    c.pick();
    c.print();
}
