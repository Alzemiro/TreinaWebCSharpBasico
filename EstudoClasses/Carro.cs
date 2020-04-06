using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoClasses
{
    public sealed class Carro : Veiculo
    {

        public int NumeroPortas { get; set; }

        private List<Dono> AntigosDonos;

        public void AdicionarAntigoDono(Dono dono)
        {
            AntigosDonos.Add(dono);
        }
        public List<Dono> GetAntigosDonos()
        {
            return AntigosDonos;
        }              

        public Carro()
        {
            AntigosDonos = new List<Dono>();
            NumeroPortas = 4;
        }

        public Carro(string nome)
        {
            Nome = nome;
        }

        public Carro(string nomeMarca, int numeroPortas)
        {
            this.Marca = nomeMarca;
            this.NumeroPortas = numeroPortas;
        }

        public Carro(int numeroPortas)
        {
            this.NumeroPortas = numeroPortas;
        }

        //construtor nomeado
        public Carro(string nome, string marca, int numeroPortas = 4)
        {
            this.Nome = nome;
            this.Marca = marca;
            this.NumeroPortas = numeroPortas;
        }

        public override bool Equals(object obj)
        {
            Carro carro2 = (Carro)obj;
            return carro2.Nome == this.Nome && carro2.Marca == this.Marca;
        }

        public override string ToString()
        {
            return string.Format("Carro: {0}, Marca: {1}", this.Nome, this.Marca);
        }

        public override string Ligar()
        {
            return "O carro está ligado";
        }

        public override string Desligar()
        {
            return "O carro está desligado";
        }

        public override string Abastecer()
        {
            return "O carro está abastecido";
        }

     
    }
}
