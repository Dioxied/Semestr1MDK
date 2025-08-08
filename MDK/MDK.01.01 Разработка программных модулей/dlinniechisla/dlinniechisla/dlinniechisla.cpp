#include <iostream>
#include <cstdio>
using namespace std;

void func(long int x)
{
    long int M = 100000;
    while (M > 0)
    {
        cout << x / M;
        x %= M;
        M /= 10;
    }
}

int main()
{
    const int N2 = 100;
    bool A2[N2 + 1];
    int i2, k2;

    for (i2 = 2; i2 <= N2; i2++)
        A2[i2] = true;
    k2 = 2;

    while (k2 * k2 <= N2) {
        if (A2[k2]) {
            i2 = k2 * k2;
            while (i2 <= N2)
            {
                A2[i2] = false;
                i2 += k2;
            }
        }
        k2++;
    }

    for (i2 = 2; i2 <= N2; i2++)
        if (A2[i2])
            cout << i2 << " ";
    cout << endl;

    ////////////////////////////////////////////////////
    const int N = 33;
    long int A[N + 1] = { 1 }, s = 0, d = 1000000;
    for (int k = 2; k <= 100; k++) {
        long int r = 0;
        for (int i = 0; i <= N; i++) {
            s = A[i] * k + r;
            A[i] = s % d;
            r = s / d;
        }

    }
    int j = N;
    while (!A[j]) {
        j--;
    }
    cout << A[j];
    for (int k = j - 1; k >= 0; k--) {
        func(A[k]);
    }


}
