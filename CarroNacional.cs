class CarroNacional : Carro
    {
        public CarroNacional(string cor, string marca, string modelo, int anoFabricacao) : base(cor, marca, modelo, anoFabricacao) { }

        public override void DefinirValorVeiculo(double CustoFixo)
        {

            if (CustoFixo > 0)
            {
                this.SetValor((CustoFixo * 1.5) + (0.2 * CustoFixo) + (CustoFixo / 10));
            }
            else
            {
                try
                {
                    Console.WriteLine("Favor informar um valor maior do que 0:");
                    CustoFixo = double.Parse(Console.ReadLine());
                    if (CustoFixo > 0)
                    {
                        this.DefinirValorVeiculo(CustoFixo);
                    }
                }
                catch (FormatException)
                {
                    this.DefinirValorVeiculo(-1);
                }

            }
        }
    }