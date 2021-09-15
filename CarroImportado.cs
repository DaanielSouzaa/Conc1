 class CarroImportado : Carro
    {
        public CarroImportado(string cor, string marca, string modelo, int anoFabricacao) : base(cor, marca, modelo, anoFabricacao) { }

        public override void DefinirValorVeiculo(double CustoFixo)
        {

            if (CustoFixo > 0)
            {
                this.SetValor((CustoFixo * 3) + (0.6 * CustoFixo) + (CustoFixo / 5));
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