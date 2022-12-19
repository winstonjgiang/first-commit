/*
    Winston Giang
    09/11/2022
*/

#include <iostream>
using namespace std;

int main()
{
    int inputM, inputY;
    cout << "Please enter your month as an integer between 1 and 12." << endl;
    cin >> inputM;
    cout << "Please enter your year as an integer between 1 and 2100." << endl;
    cin >> inputY;

    if (inputM == 2)
    {
        if ((inputY >= 1) && (inputY <= 2100))
        {
            if ((inputY % 100 == 0) && (inputY % 400 == 0))
            {
                cout << "\nThis month has 29 days." << endl;
            }
            else
            {
                if ((inputY % 4 == 0) && (inputM == 2))
                {
                    cout << "\nThis month has 29 days." << endl;
                }
                else
                {
                    cout << "\nThis month has 28 days." << endl;
                }
            }
        }
        else
        {
            cout << "Please enter a year value between 1 and 2100." << endl;
        }
    }

    if ((inputM >= 1) && (inputM <= 12))
    {
        if ((inputM == 1) || (inputM == 3) || (inputM == 5) || (inputM == 7) || (inputM == 8) || (inputM == 10) || (inputM == 12))
        {
            cout << "This month has 31 days." << endl;
        }
        else if ((inputM == 4) || (inputM == 6) || (inputM == 9) || (inputM == 11))
        {
            cout << "This month has 30 days." << endl;
        }
    }
    else
    {
        cout << "Please enter a month value between 1 and 12." << endl;
    }
    return 0;
}

