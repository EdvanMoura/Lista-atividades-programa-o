using System;

namespace Listaatividades
//QUESTÃO 1
/*{
    class Program
    {
        static void Main(string[] args)
        {
            Double Temp1, Fahrenheit, v1, v2;
            v2 = 32;
            v1 = 1.8;
           
            Console.WriteLine("Olá, o dia hoje está belo! Quantos Cº o termometro está marcando?");

            Temp1 = Double.Parse(Console.ReadLine());
            Fahrenheit = (Temp1 * v1) + v2;


            if (Temp1 >= 1 && Temp1 <= 10)
            {
                Console.WriteLine("Tá frio, mas não tá tando assim. No medidor alemão isso dá " + Fahrenheit + "Fº. Bota uma roupinha quente, se enrola num cobertor e vá jogar lol.");
            }
            else if (Temp1 < 1)
            {
                Console.WriteLine("Eita que o inferno ta congelando. Isso, em Fahrenheit dá " + Fahrenheit + "Fº. Melhor entrar em casa e jogar LOL");
            }
            else
            {
                Console.WriteLine("Oxe, passou de 10 da pra viver, isso é só " + Fahrenheit + "Fº. E se ficar muito quente, liga o ventilador ou arcondicionado e vai jogar LOL");
            }

            Console.ReadKey();
        }
        }
        }*/

//----------------------------------------------------------------------------------------------------------------
//QUESTÃO 2
/*{
class Program
{
static void Main(string[] args)
{

    double valorAula, numeroAula, sal, inss, salf;

    Console.WriteLine("Qual o valor da hora aula? ");
    valorAula = Double.Parse(Console.ReadLine());

    Console.WriteLine("Qual o valor números hora aula? ");
    numeroAula = Double.Parse(Console.ReadLine());

    sal = numeroAula * valorAula;

    if (sal <= 1100)
    {
        inss = 0.75;

    }
    else if (sal >= 1100.01 && sal <=2203.48)
    {

        inss = 0.09;

    }
    else if (sal >= 2203.49 && sal <= 3305.22) 
    {

        inss = 0.12;

    }else{

        inss = 0.14;
    }

    salf = sal - ((inss * sal));

    Console.WriteLine("O salário Líquido é " + salf + "Imposto de Renda não está sendo considerado e Imposto é roubo.");
    Console.ReadKey();
}
}
}*/
//-----------------------------------------------------------------------------------------------------------------------------------
//QUESTÃO 3

/*{
    class Program
    {
        static void Main(string[] args)
        {
            double num,res;
            
            Console.WriteLine("Informar Número");
            num = Double.Parse(Console.ReadLine());
            if (num < 0)
                res = num * num;

            else
                res = Math.Sqrt(num);

            Console.WriteLine("O resultado esperado é " + res + " chuva de bença");
            Console.ReadKey();
        }
        
    } 
}*/
//------------------------------------------------------------------------------------------------------------
//QUESTÃO 4

/*{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, are;
            const double pi = 3.1415;

            Console.WriteLine("Informar raio");
            raio = Double.Parse(Console.ReadLine());
            are = pi * raio * raio;

            Console.WriteLine("Área do círculo é " + are );
            Console.ReadKey();
        }

    }
}*/
//---------------------------------------------------------------------
// QUESTÃO 5
/*
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, anoatual, nasc, idadeatual;

            Console.WriteLine("Informar ano atual, no formato: (aaaa)");
            anoatual = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informar ano de nascimento, no formato: (aaaa)");
            nasc = Double.Parse(Console.ReadLine());
            idade = 2022 - nasc;
            idadeatual = anoatual - nasc;
            Console.WriteLine("Sua idade no ano " + anoatual +" é " + idadeatual + "\nE ao fim de 2022 será " + idade);
            Console.ReadKey();
        }

    }
}*/
//-------------------------------------------------------------------------
//QUESTÃO 6
/*
{
    class Program
    {
        static void Main(string[] args)
        {
            double prefab, margem, taxa, prefin ;

            Console.WriteLine("Informar preço de fábrica:");
            prefab = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informar a margem percentual (%) de lucro, apenas números:");
            margem = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informar o percentual (%) de impostos sobre o preço de fábrica, apenas números:");
            taxa = Double.Parse(Console.ReadLine());

            taxa = (prefab * taxa) / 100;
            margem = (prefab * margem) / 100;
            prefin = prefab + margem + taxa;

            Console.WriteLine(" O Lucro do vendedor é " + margem);
            Console.ReadKey();

            Console.WriteLine(" O Imposto devido é " + taxa);
            Console.ReadKey();

            Console.WriteLine(" E o preço final ao consumidor é " + prefin);
            Console.ReadKey();

        }

    }
}*/
//QUESTÃO 7
/*
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int altdegrau, alttotal;
            double qtddegrau;

            Console.WriteLine("Digite a altura do degrau em centímetros:");
            altdegrau = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura que deseja alcançar, em centímetros");
            alttotal = int.Parse(Console.ReadLine());

           qtddegrau = alttotal / altdegrau;

            if (alttotal % altdegrau != 0)

            {
                qtddegrau++;

            }

            if (qtddegrau >= 2)
            {
                Console.WriteLine("O usuário deverá subir " + qtddegrau + " degraus.");
            }
            else if (qtddegrau == 1)

            {
                Console.WriteLine("O usuário deverá subir 1 degrau.");
            }

            else
            {
                Console.WriteLine("Altura do degrau e/ou Altura deseja inválida(s). Favor verificar e tentar novamente");
            }

        }
    }
}*/

//QUESTÃO

/*{
    class Program
    {
        static void Main(string[] args)
        {
            double htrab, salmin, salliquido, tax, hvalor, salbruto;

            Console.WriteLine("Informar a quantidade de horas trabalhadas:");
            htrab = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informar o salário mínimo:");
            salmin = Double.Parse(Console.ReadLine());

            hvalor = salmin / 2;
            salbruto = htrab * hvalor;
            tax = salbruto * 0.03;
            salliquido = salbruto - tax;

            Console.WriteLine("O Salário a receber é " + salliquido);
            Console.ReadKey();


        }

    }
}*/

{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int numale = 4;

                
                switch (numale)

                {

                    case 1:
                        Console.WriteLine("Você ganhou uma paçoca");
                        break;

                    case 2:
                        Console.Write("Você ganhou um Kit festa");
                        break;

                    case 3:
                        Console.WriteLine("Você ganhou uma goiaba");
                        break;

                    case 4:
                        Console.WriteLine("Você ganhou um ps4");
                        break;

                    default:
                        Console.WriteLine("opção inválida, tente novamente!");
                        break;

                        




                }

            }
        }
    }
}

