#include <iostream>
using namespace std;
int main1() {
	int a, b, c;
	cout << "这个算法是求a的b次方的得数的"<<endl;
	while(1){ 
	cout<<"请输入a" << endl;
	cin >> a;
	cout << "请输入b" << endl;
	cin >> b;
	if (b == 0) cout << "a的b次方得数为:" << "1" << endl; //任何数的0次方都为1
	else if(b<0)cout << "b的值不能小于0！" << endl;
	else {
		int i = a;
		for (int j = 1; j < b; j++) {
			a = a*i;

		}
		cout << "a的b次方得数为:" << a << endl;
	}
}
}