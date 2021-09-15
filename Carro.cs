using System;

abstract class Carro
  {
      private string cor;
      private string marca;
      private string modelo;
      private double valor;
      private int anoFabricacao;
      private double capacidadeTanque;
      private double tanqueAtual;
      private double kmRodados;

      public string GetCor()
      {
          return this.cor;
      }
      protected void SetCor(string cor)
      {
          this.cor = cor;
      }

      public string GetMarca()
      {
          return this.marca;
      }
      protected void setMarca(string marca)
      {
          this.marca = marca;
      }

      public string getModelo()
      {
          return this.modelo;
      }
      protected void SetModelo(string modelo)
      {
          this.modelo = modelo;
      }
      public double GetValor()
      {
          return this.valor;
      }
      protected void SetValor(double valor)
      {
          this.valor = valor;
      }
      public Carro(string cor, string marca, string modelo, int anoFabricacao)
      {
          this.cor = cor;
          this.marca = marca;
          this.modelo = modelo;
          this.anoFabricacao = anoFabricacao;
          this.capacidadeTanque = 100;
          this.tanqueAtual = this.capacidadeTanque;
      }

      public void Mover(double distanciaKm)
      {
          if (distanciaKm > 0)
          {
              this.kmRodados += distanciaKm;
              this.tanqueAtual -= distanciaKm / 8;
          }
      }

      public void Mover()
      {
          this.kmRodados += 5;
          this.tanqueAtual -= 5 / 8;
      }

      public void Abastecer(double litros)
      {
          if ((this.tanqueAtual + litros) <= capacidadeTanque)
          {
              this.tanqueAtual += litros;
              Console.WriteLine("Foi abastecida a quantidade solicitada!");
          }
          else
          {
              Console.WriteLine("Você não precisa da quantidade que solicitou, abasteceremos até que o tanque complete sua capacidade total");
              Abastecer();
          }
      }
      public void Abastecer()
      {
          double abastecido = (this.tanqueAtual - this.capacidadeTanque) * -1;
          this.tanqueAtual = this.capacidadeTanque;
          Console.WriteLine("Foram abastecidos {0} litros", abastecido);
      }

      public abstract void DefinirValorVeiculo(double CustoFixo);
  }