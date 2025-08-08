#include <iostream>
#include <random>
#include <vector>
using namespace std;


class Parrot{
private:
    vector<string> texts;
public:
    Parrot(string text0 = "Привет друзья!") {
        texts.push_back(text0);
    }
    void say(int i = 1) {
        for (int j = 0; j < i; j++) {
            cout << texts[rand() % texts.size()];
        }
        cout << endl;
    }
    void newtext(string newtxt = "") {
        texts.clear();
        texts.push_back(newtxt);
    }
    void learn(string newword) {
        texts.push_back(newword);
    }
    
};


int main()
{
    setlocale(LC_ALL, "Russian");
    srand(time(NULL));

    cout << "-----Task A-----" << endl;
    Parrot p = Parrot();
    p.say();

    cout << "-----Task B-----" << endl;
    Parrot p1 = Parrot("Гав!");
    Parrot p2 = Parrot("Мяу!");
    p1.say();
    p2.say();

    cout << "-----Task C-----" << endl;
    Parrot p3 = Parrot("Гав!");
    p3.say();
    p3.newtext("Мяу!");
    p3.say();

    cout << "-----Task D-----" << endl;
    Parrot p4 = Parrot("Гав!");
    p4.say();
    p4.newtext("Мяу!");
    p4.say(3);

    cout << "-----Task E-----" << endl;
    Parrot p5 = Parrot("Гав!");
    p5.say();
    p5.learn("Мяу!");
    p5.say();
    p5.say(3);
}

