// Fonte: https://thehuxley.com/problem/274

#include <stdio.h>

int main()
{
    double nota1, nota2, nota3, media;
    scanf("%lf%lf%lf", &nota1, &nota2, &nota3);
    media = (nota1 * 2 + nota2 * 3 + nota3 * 5) / (2 + 3 + 5);
    printf("MEDIA = %.1lf\n", media);
    return 0;
}