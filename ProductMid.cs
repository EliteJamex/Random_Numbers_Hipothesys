namespace TecSim{
    public class ProductMid{
        public List<string> ListA;
        public List<string> ListB;
        public List<long> ListProduct;
        public List<float> ListRandomVal;

        public ProductMid(int x0,int x1){
            ListA = new List<string> { x0.ToString() };
            ListB = new List<string> { x1.ToString() };
            ListProduct = new List<long>();
            ListRandomVal = new List<float>();
        }

        public void GenerateNumbers(){
            long product;
            string intermediaryValues;
            for (int i = 0; i < 1000; i++)
            {
                product = long.Parse(ListA[i]) * long.Parse(ListB[i]);
                ListProduct.Add(product);
                ListA.Add(ListB[i]);

                string productStr = product.ToString();

                int middleIndex = Convert.ToInt32(productStr.Length / 2);
                int middleIndexmiddle = Convert.ToInt32((productStr.Length / 2)/2);
                int PositionIndex = (middleIndex - middleIndexmiddle)-1;
                
                intermediaryValues = GetIntermediaryValues(ListProduct[i],PositionIndex, PositionIndex+5);

                ListB.Add(intermediaryValues);
                float ValDiv = float.Parse(intermediaryValues)/1000000;
                ListRandomVal.Add(ValDiv);
            }
        }

        public void MostrarValores(){
            string Valores = "";
            Console.WriteLine("X0\t\tX1\t\tPRODUCTO (X0 * X1)\tVALOR ALEATORIO ( ri )");
            Console.WriteLine("------\t\t------\t\t----------------\t---------------");
            for(int i=0;i<1000;i++){
                Console.WriteLine($"{ListA[i]}\t\t{ListB[i]}\t\t{ListProduct[i]}\t\t{ListRandomVal[i]}");
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