/*
    Winston Giang
    10/26/2022
    Username and Password Program
*/

#include <iostream>
#include <string>
using namespace std;

bool usernameRestriction(string username)
{
    if (isdigit(username[0]))
    {
        cout << "Username cannot start with a number. Please try again." << endl;
        return false;
    } 
    else for (int i = 0; i < username.length(); i++)
    {
        if (!isalnum(username[i]))
        {
            cout << "Username must contain only letters or numbers. Please try again" << endl;
            return false;
        }
    }
    return true;
}

bool passwordRestriction(string& password)
{
    bool otherCharacter, hasUpper, hasLower, hasDigit;
    otherCharacter = false; hasUpper = false; hasLower = false; hasDigit = false;
    for (int i = 0; i < password.length(); i++)
    {
        if (!isalnum(password[i]))
        {
            otherCharacter = true;
        }
        if (isupper(password[i]))
        {
            hasUpper = true;
        }
        if (islower(password[i]))
        {
            hasLower = true;
        }
        if (isdigit(password[i]))
        {
            hasDigit = true;
        }
    }
    if (otherCharacter == false)
    {
        cout << "Password must contain atleast ONE non-numeric or alphabetical character, please try again." << endl;
        return false;
    }
    else if ((hasUpper == false) || (hasLower == false))
    {
        cout << "Password must contain atleast ONE uppercase letter and ONE lowercase letter." << endl;
        return false;
    }
    else if (hasDigit == false)
    {
        cout << "Password must contain atleast ONE digit." << endl;
        return false;
    }
    if ((otherCharacter == true) && (hasUpper == true) && (hasLower == true) && (hasDigit == true))
    {
        return true;
    }
}

int main()
{
    string username, password;
    bool check = true;
    do
    {
        cout << "Please enter a username: ";
        getline(cin, username);
        check = usernameRestriction(username);
    } 
    while (!check);

    bool check2 = true;
    do
    {
        cout << "Please enter a password: ";
        getline(cin, password);
        check2 = passwordRestriction(password);
    } 
    while (!check2);
    
    return 0;
}

