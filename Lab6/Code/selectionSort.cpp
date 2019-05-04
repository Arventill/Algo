#include <iostream>
#include <fstream>

const int ELEMENTS = 4;
int t[ELEMENTS]{4,3,2,1};

void fill_tab()
{
	using namespace std;
	for (int i = 0; i < ELEMENTS; i++)
	{
		cin >> t[i];
	}
}

void show_tab()
{
	using namespace std;
	for (int i = 0; i < ELEMENTS; i++)
	{
		cout << t[i] << endl;
	}
}

int main()
{
	using namespace std;
	int counting = 0, mini, ch;

	//fill_tab();
	
	for (int i = 0; i < ELEMENTS; i++)
	{
		ch = i;
		mini = t[counting];
		for (auto j = counting; j < ELEMENTS; j++)
		{
			if (t[j] < mini)
			{
				mini = t[j];
				ch = j;
			}
		}
		swap(t[counting], t[ch]);
		counting++;
	}

	show_tab();

	return 0;
}
