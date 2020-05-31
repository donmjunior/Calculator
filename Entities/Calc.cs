using System;

namespace Calculator.Entities{

    /*
    Esta classe é basicamente dispensável por já existir na biblioteca da linguagem C#
    a classe Math() que realiza as mesmas operações, porém, como dito na introdução da
    classe Program.cs, o programa inteiro será apenas para prática do uso da linguagem.
    Mas, independente de quais códigos serão utilizados, o intuito será criar uma
    calculadora avançada e a mais completa possível com interface bem intuitiva e, de
    preferência, bem didática e auto explicativa, de modo que qualquer leigo consiga
    entender as funções disponíveis pelo dispositivo.
    */
    class Calc{

        /*Início de variáveis essenciais e constantes matemáticas
        */
        public static double PI = 3.14159265358979323846264338327950288;

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
            return x + y;
        }

        //Método que retorna a subtração entre x e y
        public double Subtrai(double x, double y){
            return x - y;
        }

        //Método que retorna a multiplicação entre x e y
        public double Multiplica(double x, double y){
            return x * y;
        }

        //Método que retorna a divisão entre x e y
        public double Divide(double x, double y){
            return x / y;
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
        public double RaizQuadrada(double d){
            /*Esta funcão será temporária até que eu descubra o código fonte ou uma fórmula
            exata para calcular tanto a raiz quadrada quanto de qualquer outro radicando
            */
            return Math.Sqrt(d);
        }

        /*Este método também será temporário até o momento que eu conseguir um código 
        que calcula a raiz de um radical por qualquer radicando
        */
        public double RaizCubica(double d){
            return Math.Cbrt(d);
        }
    }
}