namespace TecSim{
    public class ProductMidModified{
        public List<string> ListA;
        public long K;
        public List<long> ListProduct;
        public List<float> ListRandomVal;

        public ProductMidModified(int x0,int k){
            ListA = new List<string>{x0.ToString()};
            ListProduct = new List<long>();
            ListRandomVal = new List<float>();
            this.K = k;    
        }

        public void GenerateNumbers(){
            long product;
            string intermediaryValues;
            for (int i = 0; i < 1000; i++){
                product = this.K*long.Parse(ListA[i]);
                ListProduct.Add(product);
                string productStr = product.ToString();

                int middleIndex = Convert.ToInt32(productStr.Length / 2);
                int middleIndexmiddle = Convert.ToInt32(((productStr.Length / 2)+0.1)/(2));
                int PositionIndex = (middleIndex - middleIndexmiddle);

                Console.WriteLine(middleIndex+" | "+middleIndexmiddle);
                
                intermediaryValues = GetIntermediaryValues(ListProduct[i],PositionIndex, PositionIndex+5);

                ListA.Add(intermediaryValues);
                float ValDiv = float.Parse(intermediaryValues)/1000000;
                ListRandomVal.Add(ValDiv);
            }
        }
        public void MostrarValores(){
            string Valores = "";
            Console.WriteLine("K\t\tX0\t\tPRODUCTO (X0 * K)\tVALOR ALEATORIO ( ri )");
            Console.WriteLine("------\t\t------\t\t----------------\t---------------");
            for(int i=0;i<1000;i++){
                Console.WriteLine($"{this.K}\t\t{ListA[i]}\t\t{ListProduct[i]}\t\t{ListRandomVal[i]}");
            }
        }
        static string GetIntermediaryValues(long number, int startIndex, int endIndex)
        {
            string numberStr = number.ToString();
            string result = "";

            if (startIndex >= 0 && endIndex < numberStr.Length && startIndex <= endIndex)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    result += numberStr[i];
                }
            }
            else
            {
                Console.WriteLine("Índices fuera de rango.");
            }

            return result;
        }
    }
}