#include <iostream>
using namespace std;

double calculatePosition(double initialPosition, double initialVelocity, double acceleration, double time)
{
	return initialPosition + initialVelocity * time + acceleration * time * time / 2;
}

int main()
{
	double initialPosition, initialVelocity, acceleration, time;

	cout << "Input the initial position, initial velocity, acceleration, and then time" << endl;
	cin >> initialPosition >> initialVelocity >> acceleration >> time;
	cout << calculatePosition(initialPosition, initialVelocity, acceleration, time) << endl;

	return 0;
}