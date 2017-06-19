#include<iostream>
using namespace std;
int main()
{
	int x, y;
	int de;
	int a[6][6] = {
		1,1,1,1,1,1,
		1,1,1,1,1,1,
		1,1,1,1,1,1,
		1,1,1,1,1,1,
		1,1,1,1,1,1,
		1,1,1,1,1,1 };
	while (1)
	{
		for (int q = 1; q<6; q++)
		{
			for (int w = 1; w<6; w++)
			{
				cout << a[q][w] << " ";
			}
			cout << endl;
		}
		cout << endl;
		cout << "输入行:";
		cin >> y;
		cout << "输入列:";
		cin >> x;
		a[y][x] = 0;
		cout << "=============================================>" << endl;
	}
}