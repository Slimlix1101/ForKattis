#include <iostream>
#include <vector>
#include <cmath>
using namespace std;

struct circle {
	int x;
	int y;
	int radius;
};
struct rec {
	int xa;
	int ya;
	int xb;
	int yb;
};
struct point {
	int x;
	int y;
};

int main()
{
	int a, times, ans;
	point test;
	vector<rec> recsave;
	vector<circle> circlesave;
	string type;
	while (cin >> a)
	{
		recsave.clear();
		circlesave.clear();
		for (int i = 0 ; i<a ; i++)
		{
			cin >> type;
			if (type == "rectangle")
			{
				rec input;
				cin >> input.xa >> input.ya >> input.xb >> input.yb;
				recsave.push_back(input);
			} else {
				circle input;
				cin >> input.x >> input.y >> input.radius;	
				circlesave.push_back(input);			
			}
		}
		while (cin >> times)
		{
			
			for (int i = 0 ; i<times; i++)
			{
				ans = 0;
				cin >> test.x >> test.y;
				for (int q=0; q<recsave.size() ; q++)
					if (test.x >= recsave[q].xa && test.x <= recsave[q].xb && test.y >= recsave[q].ya && test.y <= recsave[q].yb ) ans++;
				for (int q=0; q<circlesave.size() ; q++)
					if (pow(test.y-circlesave[q].y, 2) + pow(test.x-circlesave[q].x, 2) <= circlesave[q].radius*circlesave[q].radius) ans++;
				cout << ans << endl;
			}
		}
			
	}
}
