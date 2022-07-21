using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioIMC
{
    public class Pessoa
    {


        public Double peso, altura;
        
        public double Calcular()
        {
            return peso / (altura*altura);

        }

        public string situacao(double imc)
        {
            string retorno;

            if(imc < 18.5)
            {
                retorno = "Abaixo do peso";
            }
            else if(imc < 25 && imc > 18.5)
            {
                retorno = "Peso normal";
            }
            else if (imc < 30 && imc > 25)
            {
                retorno = "Acima do peso";
            }
            else if (imc < 35 && imc > 30)
            {
                retorno = "Obesidade I";
            }
            else if (imc < 40 && imc > 35)
            {
                retorno = "Obesidade II";
            }
            else
            {
                retorno = "Obesidade III";
            }
            return retorno;
        }

        public void Mensagem()
        {

            double obterCalculo = Calcular();

            string obterSituacao = situacao(obterCalculo);

            Console.WriteLine("Seu IMC é " + obterCalculo);
            Console.WriteLine("Sua situação é " + obterSituacao);


        }

    }
}
