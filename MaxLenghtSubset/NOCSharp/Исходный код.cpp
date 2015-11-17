#include <fstream>
using namespace std;
ifstream cin("input.txt");
ofstream cout("output.txt");
 
int main(){
	int lenght;
	cin >> lenght;
	int* num = new int[lenght];
	for (int i = 0; i < lenght; i++)
	{
		cin >> num[i];
	}
	//Cleaning massive
	bool* clear = new bool[lenght];
	for (int i = 0; i < lenght; i++)
	{
		if (!clear[i])
		{
			for (int j = i + 1; j < lenght; j++)
			{
				if (num[i] == num[j])
				{
					clear[j] = true;
				}
			}
		}
	}
	//
	int* l = new int[lenght];
	for (int i = 0; i < lenght; i++)
	{
		l[i] = 1;
	}
	for (int i = 0; i < lenght; i++)
	{
		if (!clear[i])
		{
			for (int j = 0; j < i; j++)
			{
				if (num[i] > num[j] && l[i] < l[j] + 1)
				{
					l[i] = l[j] + 1;
				}
			}
		}
	}
	int result = l[0];
	for (int i = 1; i < lenght; i++)
	{
		if (l[i]>result){
			result = l[i];
		}
	}
	cout << result;



}