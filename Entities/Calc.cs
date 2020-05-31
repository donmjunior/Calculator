namespace Calculator.Entities{

    /*
    Esta classe é basicamente dispensável por já existir na biblioteca da linguagem C#
    a classe Math() que realiza as mesmas operações, porém, como dito na introdução da
    classe Program.cs, o programa inteiro será apenas para prática do uso da linguagem.
    */
    class Calc{

        //Variáveis essenciais para retornos de resultados das funções
        double soma = 0.0;
        double subtrai = 0.0;
        double multiplica = 0.0;
        double divide = 0.0;
        //double raiz = 0.0;

        //Propriedades que receberão os valores passados pelo usuário
        public double X { get; set; }
        public double Y { get; set; }

        //Construtores padrões para instâncias de objetos do tipo Calc
        public Calc(){}
        public Calc(double x, double y){
            X = x;
            Y = y;
        }

        //Método que retorna a soma entre x e y
        public double Soma(double x, double y){
            return soma = x + y;
        }

        //Método que retorna a subtração entre x e y
        public double Subtrai(double x, double y){
            return subtrai = x - y;
        }

        //Método que retorna a multiplicação entre x e y
        public double Multiplica(double x, double y){
            return multiplica = x * y;
        }

        //Método que retorna a divisão entre x e y
        public double Divide(double x, double y){
            return divide = x / y;
        }

        //Método que retorna a potência de x elevado à y
        public double Potencia(double x, int y){
            if(x == 1 || y == 0)
                return 1;
            else if(y == 1)
                return x;
            else if(y < 0)
                return 1 / ForCalcPot(x, y);
            else
                return ForCalcPot(x, y);
        }

        //Método interno que realizará o looping do cálculo da potenciação
        private double ForCalcPot(double x, int y){
            double result = 1.0;
            for(int i = 0; i < y; i++){
                result *= x;
            }
            return result;
        }
        /*Até o momento estudarei a melhor forma de conseguir criar uma função
        que calcule a raiz de qualquer valor por qualquer radicando sem que seja necessário
        a utilização da função Math.Sqrt().
        */
    }
}