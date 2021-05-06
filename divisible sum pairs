#include <map>
#include <set>
#include <list>
#include <cmath>
#include <ctime>
#include <deque>
#include <queue>
#include <stack>
#include <string>
#include <bitset>
#include <cstdio>
#include <limits>
#include <vector>
#include <climits>
#include <cstring>
#include <cstdlib>
#include <fstream>
#include <numeric>
#include <sstream>
#include <iostream>
#include <algorithm>
#include <unordered_map>

using namespace std;

int main()
{
    int n,k,countt=0;
    cin >> n >> k;
    int arr[n];
    for(int i=0;i<n;i++)
    {
        cin >> arr[i];

    }
    for(int i=0;i<n-1;i++)
    {
        for(int j=i+1;j<n;j++)
        {
            if((arr[i]+arr[j])%k==0)
            {

                 countt++;
            }

        }
    }
    cout << countt;
    return 0;
}
