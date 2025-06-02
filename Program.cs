Console.Clear();

string lerInput;
int input;

int[] output = new int[11];



Console.WriteLine("Digite um número");
lerInput = Console.ReadLine()!;

while (!(Int32.TryParse(lerInput, out int teste)))
{
    Console.WriteLine("Não é um número! Tente novamente.");
    lerInput = Console.ReadLine()!;
}

input = Convert.ToInt32(lerInput);

for (int i = 0; i < 11; i++)
{
    output[i] = input * i;
    Console.WriteLine($"{input} * {i} = {output[i]}");

}
