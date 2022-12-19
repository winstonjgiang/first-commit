/*
    Winston Giang
    09/28/2022
*/

#include <iostream>
using namespace std;



double calculateAmountEntered(double price) //Loop function to add all coins entered until price value for selected item is reached
{
    double coinEntry, coinTotal;
    coinTotal = 0;
    do
    {
        cout << "\nPlease enter the coin amount (0.01, 0.05, 0.10, 0.25, or 1.00): $"; cin >> coinEntry;
        do
        {
            if ((coinEntry != 0.01) && (coinEntry != 0.05) && (coinEntry != 0.10) && (coinEntry != 0.25) && (coinEntry != 1.00))
            {
                cout << "Please enter a valid coin input: $"; cin >> coinEntry;
            }
        } 
        while ((coinEntry != 0.01) && (coinEntry != 0.05) && (coinEntry != 0.10) && (coinEntry != 0.25) && (coinEntry != 1.00));
        coinTotal += coinEntry;
        cout << "Total amount entered: $" << coinTotal;
    } 
    while (coinTotal < price);
    return coinTotal;
}

void calculateChange(double total, double price) //Function to calculate change for customer
{
    double change;
    change = total - price;
    cout << "\n\nYour change is $" << change << endl;
}

void snackChoice(char slot)
{
    if (slot == 'A')
    {
        cout << "Enjoy your Flamin' Hot Cheetos!";
    }
    if (slot == 'B')
    {
        cout << "Enjoy your chocolate chip cookie!";
    }
    if (slot == 'C')
    {
        cout << "Enjoy your gummy bears!";
    }
}

int main()
{
    char slot;
    double price, total;
    cout << "Thank you for using Winston's Local Vending Machine." << endl << endl;
    cout << "Slot A: Flamin' Hot Cheetos = $2.50" << endl;
    cout << "Slot B: Chocolate Chip Cookie = $2.00" << endl;
    cout << "Slot C: Gummy Bears = $1.75" << endl;
    cout << "Please enter the slot letter of your desired snack choice: "; cin >> slot;
    do
    {
        if ((slot != 'A') && (slot != 'B') && (slot != 'C'))
        {
            cout << "Please enter a valid slot letter: "; cin >> slot;
        }
    } 
    while ((slot != 'A') && (slot != 'B') && (slot != 'C'));

    if (slot == 'A')
    {
        price = 2.50;
    }
    if (slot == 'B')
    {
        price = 2.00;
    }
    if (slot == 'C')
    {
        price = 1.75;
    }

    total = calculateAmountEntered(price);
    calculateChange(total, price);
    snackChoice(slot);
    
    return 0;
}

