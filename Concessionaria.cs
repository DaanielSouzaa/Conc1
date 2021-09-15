class Concessionaria
    {
        private string localizacao;
        private string gerentePrincipal;
        private int anoFundacao;

        private List<Carro> carros = new List<Carro>();

        public Concessionaria()
        {

        }

        public Concessionaria(string localizacao, string gerentePrincipal, int anoFundacao)
        {
            this.localizacao = localizacao;
            this.gerentePrincipal = gerentePrincipal;
            this.anoFundacao = anoFundacao;
        }

        public Concessionaria(string localizacao, string gerentePrincipal, int anoFundacao,List<Carro> carros)
        {
            this.localizacao = localizacao;
            this.gerentePrincipal = gerentePrincipal;
            this.anoFundacao = anoFundacao;
            this.carros = carros;
        }

        public void addCarro(Carro carro)
        {
            this.carros.Add(carro);
        }

        public void calcPortfolio()
        {
            double totValue = 0;

            for(int i = 0;i < this.carros.Count; i++)
            {
                totValue += this.carros[i].GetValor();
            }

            Console.WriteLine("O valor total dos carros em nossa concessionária é de: R$ {0}",totValue);
        }
    }