/*
    Winston Giang
    09/20/2020
    Miles Per Gallon Program
*/

#include <iostream>
using namespace std;

int main()
{
    double distance, gas;
    char repeat;
    do
    {
        cout << "Enter the number of miles travelled: "; cin >> distance;
        cout << "Enter the number of gallons of gas used: "; cin >> gas;
        cout << endl;
        cout << "You got " << (distance / gas) << " miles per gallon." << endl;
        cout << "Do you want to calculate the MPG again? Y/N" << endl;
        cin >> repeat;

    } while (repeat == 'Y');

    return 0;

       
}

