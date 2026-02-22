// Fonte: https://www.thehuxley.com/problem/294

#include <stdio.h>

int main()
{

    int distancia;
    float litro, consumo;

    scanf("%d%f", &distancia, &litro);
    consumo = distancia / litro;
    printf("%.3f km/l\n", consumo);

    return 0;
}