namespace TecSim{
    public class CongruencialMultiplicativo{
        public int K;
        public List<long> ListA;
        public int M;
        public List<string> ListRandomValue;

        public CongruencialMultiplicativo(int K,long x0,int M){
            this.K = K;
            ListA = new List<long>{x0};
            this.M = M;
            ListRandomValue = new List<string>();
        }

        public void GenerateNumbers(){
            long nextValue;
            float DivNum;
            for(int i=1;i<1001;i++){
                nextValue = (this.K * this.ListA[i-1]) % this.M;
                ListA.Add(nextValue);
                DivNum = (float)this.ListA[i]/(this.M-1);
                this.ListRandomValue.Add(DivNum.ToString($"F6"));
            }
        }

        public void MostrarValores(){
            Console.WriteLine("k\t\tX0\t\tM\t\tXn + 1\t\tri = xi /( M-1 )");
            Console.WriteLine("------\t\t------\t\t------\t\t----------------\t---------------");
            for(int i=0;i<1000;i++){
                Console.WriteLine($"{this.K}\t\t{this.ListA[i]}\t\t{this.M}\t\t{this.ListA[i+1]}\t\t\t{this.ListRandomValue[i]}");
            }
            Procedimientos procedimientos = new Procedimientos(ListRandomValue,0.05);
            
        }
    }
}