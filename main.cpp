#include <bits/stdc++.h>
using namespace std;
class Monitor
{
    // Access specifier
    public:

    // Data Members
    string color;
    float dimension;
    int resolution_width;
    int resolution_height;

    // Member Functions()
    void inputProperties()
    {
       cout << "Culoarea: " ;
       cin >> color;
       cout << "Dimesiunea(in inch): " ;
       cin >> dimension;
       cout << "Rezolutia: " <<endl;
       cout << "   latimea: ";
       cin >> resolution_width;
       cout << "   inaltimea: " ;
       cin >> resolution_height;
    }
};

int main() {

    // Declare an object of class geeks
    Monitor obj1;
    Monitor obj2;

    // accessing data member
 /*   obj1.geekname = "Abhi";  */

    // accessing member function
    cout << "Proprietatile monitorului nr.1"  << endl;
    obj1.inputProperties();
    cout << "Proprietatile monitorului nr.2"  << endl;
    obj2.inputProperties();

    if (obj1.color == obj2.color){
        cout << "Culoarea monitoarelor este la fel." << endl;
    } else {
        cout << "Monitoarele au culori diferite:"<< endl <<"  primul este "<< obj1.color << ", iar al doilea " << obj2.color <<endl;
    }

     if (obj1.dimension == obj2.dimension){
        cout << "Dimensiunea monitoarelor este la fel." << endl;
    } else {
        cout << "Monitoarele au dimensiuni diferite:"<< endl <<"  primul are "<< obj1.dimension << " inch, iar al doilea " << obj2.dimension <<" inch."<<endl;
    }

     if ((obj1.resolution_width == obj2.resolution_width) and (obj1.resolution_height == obj2.resolution_height)){
        cout << "Rezolutia monitoarelor este la fel." << endl;
    } else {
        cout << "Rezolutia monitoarelor este diferita:"<< endl <<"  primul are "<< obj1.resolution_width << "x"<< obj1.resolution_height << ", iar al doilea " << obj2.resolution_width << "x" << obj2.resolution_height << endl;
    }
    return 0;
}
