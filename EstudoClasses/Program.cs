using System;
using System.Collections.Generic;

namespace EstudoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Marca = "Fiat";
            /*carro.AntigosDonos = new List<string>();
            carro.AntigosDonos.Add("João da Silva");
            Console.WriteLine("A marca do carro é: {0}", carro.Marca);
            foreach(string nome in carro.AntigosDonos)
            {
                Console.WriteLine("Um dos antigos donos é {0}", nome);
            }*/
            Dono donoJoao = new Dono();
            donoJoao.Nome = "João";
            donoJoao.Idade = 30;
            Dono donoMaria = new Dono();
            donoMaria.Nome = "Maria";
            donoMaria.Idade = 28;

            carro.AdicionarAntigoDono(donoJoao);
            carro.AdicionarAntigoDono(donoMaria);
            
            foreach(Dono dono in carro.GetAntigosDonos())
            {
                Console.WriteLine("Antigo dono do veiculo: {0} com idade {1}", dono.Nome, dono.Idade); 
            }
            Console.WriteLine(carro.Ligar());
            Console.WriteLine("Este carro tem {0} portas", carro.NumeroPortas);
            Carro carro2 = new Carro("Astra");
            Console.WriteLine("Meu carro 2 se chama {0}", carro2.Nome);
            Carro carro3 = new Carro("Ford", 2);
            Console.WriteLine("Este outro carro é da {0} e tem {1} portas", carro3.Marca, carro3.NumeroPortas);
            Carro carro4 = new Carro(8);
            Console.WriteLine("Já este carro tem {0} portas", carro4.NumeroPortas);
            //Carro carro5 = new Carro("Ka", "Ford");
            Carro carro5 = new Carro(nome: "Ka", marca: "Ford", numeroPortas: 2);
            Console.WriteLine("O carro {1} da marca {0} tem {2} portas", carro5.Marca, carro5.Nome, carro5.NumeroPortas);
            Carro carro6 = new Carro
            {
                Nome = "Astra",
                Marca = "GM",
                NumeroPortas = 4,
                Potencia = 1.4
            };
            Console.WriteLine("Agora este carro se chama {0}, é da marca {1}, possui {2} portas e tem potência de {3}",
                carro6.Nome, 
                carro6.Marca, 
                carro6.NumeroPortas, 
                carro6.Potencia);
            Carro carro7 = new Carro();
            Console.WriteLine("O carro 7 está ligado a potencia de {0}", carro7.Ligar());
            Moto moto1 = new Moto
            {
                Nome = "Titan",
                Marca = "Honda",
                Potencia = 150,
                CapacidadeTanque = 15
            };
            Console.WriteLine("Essa moto se chama {0}, da marca {1}, com potencia de {2} e capacidade do tanque{3}", 
                moto1.Nome,
                moto1.Marca,
                moto1.Potencia,
                moto1.CapacidadeTanque);

            Carro carroford = new Carro();
            carroford.Nome = "Ka";
            carroford.Marca = "Ford";
            Carro carroFord2 = new Carro();
            carroFord2.Nome = "Ka";
            carroFord2.Marca = "Ford";
            Console.WriteLine(carroford.Ligar());

            Console.WriteLine(carro.GetHashCode());
            Console.WriteLine(carroford.ToString());
            Console.WriteLine(carroford.Equals(carroFord2));
            //Polimorfismo devido a herança
            Veiculo meuCarro = new Carro();
            Veiculo minhaMoto = new Moto();

            Console.WriteLine("Ligando o carro: {0}", meuCarro.Ligar());
            Console.WriteLine("Ligando a moto: {0}", minhaMoto.Ligar());
            Console.WriteLine("Desligando o carro: {0}", meuCarro.Desligar());
            Console.WriteLine("Desligando a moto: {0}", minhaMoto.Desligar());
            Console.WriteLine("Abastecendo o carro: {0}", meuCarro.Abastecer());
            Console.WriteLine("Abastecendo moto: {0}", minhaMoto.Abastecer());
            Veiculo meuCaminhao = new Caminhao();
            Console.WriteLine("O caminhão ligando: ", meuCaminhao.Ligar());
            Console.WriteLine("Abastecendo o caminhão: {0}", meuCaminhao.Abastecer());
            Console.WriteLine("Abastecendo o caminhão: {0}", meuCaminhao.Desabaster());

        }
        
    }
}
