// Fonte: https://www.thehuxley.com/problem/279/

#include <stdio.h>

int main()
{
    int num, horas;
    float salario, phora;
    scanf("%d%d%f", &num, &horas, &phora);
    salario = horas * phora;
    printf("NUMBER = %d\n", num);
    printf("SALARY = R$ %.2f\n", salario);

    return 0;
}