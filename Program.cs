namespace TecSim{
    class Program{
        static void Main(string[] args){
            bool salir = false;
            string opcion = "";
            while(!salir){
                Console.WriteLine("··· Menu ···\n\t1. Cuadrados Medios\n\t2. Congruencial Multiplicativo\n\t3. Productos Medios\n\t4. Productos Medios Modificado");
                opcion = Console.ReadLine()!;
                switch(opcion){
                    case "1": {
                        CuadradosMedios Algoritmo = new CuadradosMedios(456122);//515856 - Numero que pasa todas las pruebas
                        Algoritmo.GenerateNumbers();
                        Algoritmo.MostrarValores();
                        break;
                        }
                    case "2": {
                        CongruencialMultiplicativo Algoritmo2 = new CongruencialMultiplicativo(12345,56439,67990);
                        Algoritmo2.GenerateNumbers();
                        Algoritmo2.MostrarValores();
                        break;
                        }
                    case "3": {
                        ProductMid Algoritmo3 = new ProductMid(172345,232157);
                        Algoritmo3.GenerateNumbers();
                        Algoritmo3.MostrarValores();
                        break;
                        }
                    case "4":{
                        ProductMidModified Algoritmo4 = new ProductMidModified(232157,172345);
                        Algoritmo4.GenerateNumbers();
                        Algoritmo4.MostrarValores();
                        break;
                    }
                    case "S": {
                        salir = true;
                        break;
                        }
                    default: {break;}
                }
                Console.WriteLine("###########################################");
            }
            /*
            ProductMid Algoritmo1 = new ProductMid(172345,232157);
            Algoritmo1.GenerateNumbers();
            Algoritmo1.MostrarValores();
            */
        }
    }
}