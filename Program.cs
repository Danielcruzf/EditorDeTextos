using System;
using System.IO;
namespace editortxt
{
  class Program
  {
    static void Main()
    {
       Menu();
    }

     static void Menu()
     {  
        Console.Clear();
        Console.WriteLine("selecione uma opção para o editor");
        Console.WriteLine("1 = ABRIR");
        Console.WriteLine("2 = EDITAR");
        Console.WriteLine("0 = SAIR");
        short op = short.Parse(Console.ReadLine());
          switch(op)
        { 
          case 1: Abrir(); break;
          case 2: Editar(); break;
          case 0: Console.WriteLine("Obrigado por usar nosso aplicativo");Thread.Sleep(2000); Environment.Exit(0); break;
          default: Menu(); break;
        }
     }
     static void Abrir(){}
     static void Editar()
     {
      Console.Clear();
      Console.WriteLine("Digite seu texto");
      string text ="";
        do
        {
          text += Console.ReadLine(); //add tudo aou que ja foi digitado sem apagar o q ja existia
          text += Environment.NewLine; //add uma linha apos o enter
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);//"ReadKey()" enter com qualr tecla ".Key" grava a tecla e console.key.nome da tecla q qro escoler no caso do exemolo foi "escape = Esc"
        Salvar(text);
        
        }

   static void Salvar(string text)
   { 
    Console.Clear();
    Console.WriteLine("Qual o caminho de local onde você dejesa salvar esse arquivo");
    var path = Console.ReadLine();//'path' recebe o caminho do diretorio

    using (var file = new StreamWriter(path))//'StreamRead' abre o arquivo e 'StreamWrite' escreve no arquivo 
    {//'using()' fecha o programa apos o uso p n deixar aberto 
      file.Write(text);//colocando o texto no arquivo
    }
      Console.WriteLine($"Arquivo {path} salvo com sucesso");// '$' interploção dentro do string tudo q estiver entre chaves'[]' vaiser retornado
      Console.ReadKey();
      
      Menu();


   } 
  }

}



 
 
 
 
 
 
 


 
 
 
 
 
 
 

 
 


 
