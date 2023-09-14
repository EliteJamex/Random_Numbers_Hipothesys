namespace TecSim{
    public class CuadradosMedios{
        public List<int> ListA;
        public List<double> ListCuadrados;
        public List<string> ListRandom;
         
        public CuadradosMedios(int x0){
            ListA = new List<int>{x0};
            ListCuadrados = new List<double>();
            ListRandom = new List<string>();
        }

        public void GenerateNumbers(){
            double product;
            float DivNum;
            string intermediaryValues;
            for(int i=1;i<1001;i++){
                product = Math.Pow(ListA[i-1], 2);
                ListCuadrados.Add(product);
                string productStr = product.ToString();
                int middleIndex = Convert.ToInt32(productStr.Length / 2);
                int middleIndexmiddle = Convert.ToInt32((productStr.Length / 2)/2);
                intermediaryValues = GetIntermediaryValues(product,middleIndexmiddle, middleIndexmiddle+5);
                ListA.Add(int.Parse(intermediaryValues));
                DivNum = (float)ListA[i]/1000000;
                ListRandom.Add(DivNum.ToString($"F6"));
            }
        }

        public void MostrarValores(){
            
            string Valores = "";
            Console.WriteLine("Valor\t\tCuadrado\t\tValor Aleatorio(ri)");
            Console.WriteLine("------\t\t------\t\t------");
            for(int i=0;i<1000;i++){
                Console.WriteLine($"{this.ListA[i]}\t\t{this.ListCuadrados[i]}\t\t{this.ListRandom[i]}");
            }
            Console.WriteLine("Cantidad de numero "+ListRandom.Count());
            Procedimientos procedimientos = new Procedimientos(ListRandom,0.05);
            
        }

        static string GetIntermediaryValues(double number, int startIndex, int endIndex)
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