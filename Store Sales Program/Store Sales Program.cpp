/*
    Winston Giang
    09/17/2022
    Store Sales Program
*/

#include <iostream>
using namespace std;

int main()
{
    int store1, store2, store3, store4, store5;
    cout << "Enter today's sales for store 1: "; cin >> store1;
    cout << "Enter today's sales for store 2: "; cin >> store2;
    cout << "Enter today's sales for store 3: "; cin >> store3;
    cout << "Enter today's sales for store 4: "; cin >> store4;
    cout << "Enter today's sales for store 5: "; cin >> store5;
    cout << endl;


    cout << "(Each asterisk* represents $100 worth of sales)" << endl;
    cout << "Store 1 sales: ";
    for (int counter = 0; counter < store1; counter = counter + 100)
    {
        cout << "*";
    }
    cout << endl;
    cout << "Store 2 sales: ";
    for (int counter = 0; counter < store2; counter = counter + 100)
    {
        cout << "*";
    }
    cout << endl;
    cout << "Store 3 sales: ";
    for (int counter = 0; counter < store3; counter = counter + 100)
    {
        cout << "*";
    }
    cout << endl;
    cout << "Store 4 sales: ";
    for (int counter = 0; counter < store4; counter = counter + 100)
    {
        cout << "*";
    }
    cout << endl;
    cout << "Store 5 sales: ";
    for (int counter = 0; counter < store5; counter = counter + 100)
    {
        cout << "*";
    }
    cout << endl;

    return 0;
}

