/* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X 
 * que serão lidos em seguida.
 * Mostre quantos destes valores X estão dentro do intervalo [10,20] e 
 * quantos estão fora do intervalo, mostrando essas informações.
 * 
 * Entrada
 * A primeira linha da entrada contém um valor inteiro N (N < 10000), 
 * que indica o número de casos de teste.
 * Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
 * 
 * 
 * Saída
 * Para cada caso, imprima quantos números estão dentro (in) 
 * e quantos valores estão fora (out) do intervalo.
 * 
 * */

int N = Convert.ToInt32(Console.ReadLine());
int cont = 0, contIn = 0, contOut=0;

while (cont < N)
{
    int x = Convert.ToInt32(Console.ReadLine());

    if (x >= 10 && x <= 20)
    {
        contIn++;
    }
    else {  contOut++; }

    cont++;
}

Console.WriteLine($"{contIn} in");
Console.WriteLine($"{contOut} out");
Console.ReadLine();