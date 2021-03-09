using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Classe1> classe1 = new List<Classe1>();
            Classe1 classe11 = new Classe1{cci =1, valor =10};
            Classe1 classe12 = new Classe1{cci =2, valor =20};
            Classe1 classe13 = new Classe1{cci =3, valor =30};

            classe1.Add(classe11);
            classe1.Add(classe12);
            classe1.Add(classe13);

            List<Classe2> classe2 = new List<Classe2>();
            Classe2 classe21 = new Classe2{cci =1, codigo ="um"};
            Classe2 classe22 = new Classe2{cci =2, codigo ="dois"};
            Classe2 classe23 = new Classe2{cci =3, codigo ="tres"};
             
            classe2.Add(classe21);
            classe2.Add(classe22);
            classe2.Add(classe23);

         classe1.ForEach(c1 => {
                               var clss2 = classe2
                                           .Where(c2 => c2.cci == c1.cci)
                                           .FirstOrDefault();
                               c1.codigo = clss2 != null ? clss2.codigo : "";
                             });

         Console.WriteLine("Foreach");
         classe1.ForEach(teste => Console.WriteLine($"cc1: {teste.cci}  valor: {teste.valor} codigo: {teste.codigo}"));

        List<classe3> testeJoin = (from c1 in classe1
                        join c2 in classe2  
                            on c1.cci equals c2.cci
                            select new classe3()
                            {
                                cci = c1.cci,
                                valor = c1.valor,
                                codigo = c2.codigo
                            }).ToList();
        Console.WriteLine("Join");
        foreach(var item in testeJoin)
        {
            Console.WriteLine($"cci: {item.cci} valor:{item.valor} codigo: {item.codigo}");
        }


        }
    }

    public class Classe1
    {
        public int cci { get; set; }
        public int valor {get;set;}

        public string codigo {get;set;}
    }

    public class Classe2
    {
        public int cci{get;set;}
        public string codigo{get;set;}
    }

        public class classe3
    {
        public int cci{get;set;}
        public int valor {get;set;}
        public string codigo{get;set;}

    }
}
