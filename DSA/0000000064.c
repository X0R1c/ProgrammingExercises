// Fonte: https://thehuxley.com/problem/271

#include <stdio.h>
#define PI 3.14159

int main()
{
    double raio, area;
    scanf("%lf", &raio);
    raio = raio / 100.0;
    area = PI * (raio * raio);
    printf("Area = %.4lf\n", area);

    return 0;
}