using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash {
    class Program {
        static void Main(string[] args) {
            int quantidade, hash1, hash2, numero;
            Console.WriteLine("Informe quantos numeros serao inseridos: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            int?[] vetor = new int?[quantidade];
            for(int i = 0;i < quantidade; i++) {
                numero = Convert.ToInt32(Console.ReadLine());
                hash1 = numero % quantidade;
                if(vetor[hash1] == null) {
                    vetor[hash1] = numero;
                }
                else {
                    hash2 = (numero * 3 / 2) % quantidade;
                    if(vetor[hash2] == null) {
                        vetor[hash2] = numero;
                    }
                    else {
                        while(vetor[hash2] != null) {
                            hash2++;
                            if(hash2 == quantidade) {
                                hash2 = 0;
                            }
                        }
                        vetor[hash2] = numero;
                    }
                }
                
            }
            for(int i = 0;i < quantidade; i++) {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < quantidade; i++) {
                Console.Write(vetor[i]%quantidade + " ");
            }
            Console.ReadKey();
        }
    }
}
