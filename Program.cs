

namespace Target{
    public class Program{
        static void Main(string[] args){
            
            // olá, meu nome é higor e seja bem-vindo ao meu código
            Console.WriteLine("LISTA DE CÓDIGO");
            System.Console.WriteLine();
            // Inicío Exercício 1

            Console.WriteLine($"Resultado do exercício 1: {Fibonacci(21)}");

            // Fim Exercício 1
            System.Console.WriteLine();
            // Início Exercício 2

            StringReaderLetterA("Taaaarget");

            // Fim Exercício 2
            System.Console.WriteLine();
            // Inicío Exercício 3

            // O resultado será => 

            // Fim Exercício 3
        }

        static string Fibonacci(int numeroParametro){
            // Pensei em fazer uma função iterativa, mas estou ansioso e meu cerébro também, acabei optando dessa forma, um pouco gambiarra infelizmente..
            int inicioNumeroFibo = 0;
            int segundoNumeroFibo = 1;
            while(true){
                inicioNumeroFibo += segundoNumeroFibo; // O motivo desta atribuição estar no topo, enquanto a outra está no fim do loop, é a forma adequada para não ocorrer erros.
                if (numeroParametro < 0){
                    return "Valor inserido é inválido.";
                }
                else if (inicioNumeroFibo > numeroParametro && segundoNumeroFibo > numeroParametro){
                    return "Valor não pertence a sequência fibonacci.";
                }
                else if (inicioNumeroFibo == numeroParametro || segundoNumeroFibo == numeroParametro){
                    return "Valor pertence a sequência fibonacci.";
                }
                segundoNumeroFibo += inicioNumeroFibo;
            }
        }

        static void StringReaderLetterA(string palavraParametro){
            int quantidadeVezes = 0;
            foreach(char letra in palavraParametro){ 
                if (letra.ToString().ToLower().Equals("a")){
                    quantidadeVezes += 1;
                }
            }
            if (quantidadeVezes > 0){ // se a qtd de letras A é == 0, portanto não existe a letra A na palavra
                Console.WriteLine($"A letra A existe na palavra {palavraParametro} e a quantidade de letras A é de: {quantidadeVezes}");
            }
            else{
                Console.WriteLine("A letra A é inexistenta na palavra " + palavraParametro );
            }
        }
    }
}