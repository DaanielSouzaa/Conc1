using System;

class Program {
 static void Main(string[] args)
        {
            List<Carro> listCarros = new List<Carro>();
            Concessionaria conc1 = new Concessionaria("Serra","Daniel",2020);

            CarroImportado carroI1 = new CarroImportado("azul1","Ferrari1","f430",2021);
            CarroImportado carroI2 = new CarroImportado("azul2", "Ferrari2", "f430", 2022);
            CarroImportado carroI3 = new CarroImportado("azul3", "Ferrari3", "f430", 2023);
            CarroImportado carroI4 = new CarroImportado("azul4", "Ferrari4", "f430", 2024);
            CarroImportado carroI5 = new CarroImportado("azul5", "Ferrari5", "f430", 2025);

            CarroNacional carroN1 = new CarroNacional("Branco", "Fiat", "Uno", 2015);
            CarroNacional carroN2 = new CarroNacional("Branco", "Fiat", "Uno", 2015);
            CarroNacional carroN3 = new CarroNacional("Branco", "Fiat", "Uno", 2015);
            CarroNacional carroN4 = new CarroNacional("Branco", "Fiat", "Uno", 2015);
            CarroNacional carroN5 = new CarroNacional("Branco", "Fiat", "Uno", 2015);

            carroI1.DefinirValorVeiculo(2000000);
            carroI2.DefinirValorVeiculo(3000000);
            carroI3.DefinirValorVeiculo(4000000);
            carroI4.DefinirValorVeiculo(5000000);
            carroI5.DefinirValorVeiculo(6000000);

            carroN1.DefinirValorVeiculo(10000);
            carroN2.DefinirValorVeiculo(20000);
            carroN3.DefinirValorVeiculo(30000);
            carroN4.DefinirValorVeiculo(40000);
            carroN5.DefinirValorVeiculo(50000);

            listCarros.Add(carroN1);
            listCarros.Add(carroN2);
            listCarros.Add(carroN3);
            listCarros.Add(carroI5);
            listCarros.Add(carroI4);

            carroN1.Mover(50);
            carroN1.Abastecer(1);
            carroN1.Abastecer(200);

            carroI1.GetValor();

            Concessionaria conc2 = new Concessionaria("Vitória", "Daniel2", 2021,listCarros);

            conc1.addCarro(carroN4);
            conc1.addCarro(carroN5);
            conc1.addCarro(carroI1);
            conc1.addCarro(carroI2);
            conc1.addCarro(carroI3);

            conc1.calcPortfolio();
            conc2.calcPortfolio();
        }
}