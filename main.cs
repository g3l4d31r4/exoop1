using System;

class MainClass {
  public static void Main (string[] args) {
    
    Pessoa lucca = new Pessoa();
    lucca.setNome("lucca");
    lucca.setIdade(13);
    lucca.setPeso(45);
    lucca.setAltura(1.30);
    lucca.crescer();

    Console.WriteLine( lucca.getNome() );
    Console.WriteLine( lucca.getIdade() );
    Console.WriteLine( lucca.getPeso() );
    Console.WriteLine( lucca.getAltura() );

  }
}