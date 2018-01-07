//#include "stdafx.h"
#include "iostream"
#include "string"
#include "cctype"
 
using namespace std;
 
int main()
{
    string line;
    cout << "string : ";
    getline(cin, line);
    int count_of_symbols = 0;
    int min = line.length();
    int r = 0, s = 0;
    for (int i = 0; i < line.length(); i++) {
        if (isalpha(line[i])) count_of_symbols++;
        if ((isspace(line[i]) || (ispunct(line[i])) || (isalpha(line[i]) && i + 1 == line.length())) && (count_of_symbols < min && count_of_symbols != 0)) {
            min = count_of_symbols;
            if (i + 1 == line.length() && isalpha(line[i])) {
                s = i;
                r = s - count_of_symbols;
            }
            else {
                s = i - 1;
                r = s - count_of_symbols+1;
            }
        }
        if (isspace(line[i])) count_of_symbols = 0;
    }
    cout << "Min : ";
    for (int i = r; i <= s; i++) cout << line[i];
    cout << endl;
    return 0;
}