#include <iostream>
using namespace std;
int main1() {
	int a, b, c;
	cout << "����㷨����a��b�η��ĵ�����"<<endl;
	while(1){ 
	cout<<"������a" << endl;
	cin >> a;
	cout << "������b" << endl;
	cin >> b;
	if (b == 0) cout << "a��b�η�����Ϊ:" << "1" << endl; //�κ�����0�η���Ϊ1
	else if(b<0)cout << "b��ֵ����С��0��" << endl;
	else {
		int i = a;
		for (int j = 1; j < b; j++) {
			a = a*i;

		}
		cout << "a��b�η�����Ϊ:" << a << endl;
	}
}
}