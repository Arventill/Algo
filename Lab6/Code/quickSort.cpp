#include <iostream>
#include <ctime>
#include <vector>

#define SIZE 30

using namespace std;

void quick_sort(vector<int>& numbers_vector, const int left_pivot, const int right_pivot) 
{
	const auto pivot = numbers_vector[(left_pivot + right_pivot) / 2];
	auto i = left_pivot, j = right_pivot;

	while (i <= j) 
	{
		while (numbers_vector[i] < pivot) ++i;
		while (numbers_vector[j] > pivot) --j;
		if (i <= j) 
		{
			swap(numbers_vector[i], numbers_vector[j]);
			++i, --j;
		}
	}
	if (i < right_pivot)
	{
		quick_sort(numbers_vector, i, right_pivot);
	}
	if (j > left_pivot)
	{
		quick_sort(numbers_vector, left_pivot, j);
	}
}

void sort(vector<int>& numbers_vector) 
{
	if (!numbers_vector.empty()) 
	{
		quick_sort(numbers_vector, 0, numbers_vector.size() - 1);
	}
}

int main()
{
	vector<int> numbers_vector;
	srand(time(nullptr));
	numbers_vector.reserve(SIZE);
	for (auto i = 0; i < SIZE; i++)
	{
		numbers_vector.push_back(rand() % 1500);
	}

	sort(numbers_vector);
	cout << "Zakonczono sortowanie. Tablica po posortowaniu:" << endl;
	for (auto& i : numbers_vector)
	{
		cout << i << endl;
	}

	return 0;
}
