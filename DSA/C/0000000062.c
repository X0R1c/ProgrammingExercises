// Fonte: https://thehuxley.com/problem/278

#include <stdio.h>

int main()
{
    int a, b, c, d;
    scanf("%d%d%d%d", &a, &b, &c, &d);
    int prod1 = a * b, prod2 = c * d, dif = prod1 - prod2;
    printf("DIFERENCA = %d\n", dif);
    return 0;
}