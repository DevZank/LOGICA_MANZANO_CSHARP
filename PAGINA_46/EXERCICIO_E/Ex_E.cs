/*
  Apresentar os resultados das potências de 3, variando do expoente 0 até o expoente 15. 
  Deve ser considerado que qualquer número elevado a zero é 1, e elevado a 1 é ele próprio. 
  Observe que neste exercício não pode ser utilizado o operador de exponenciação do 
  portuguol (^).
*/

using System;

class ExercioE
{
  static void Main(string[] args)
  {
    int contadora = 0;
    int acumuladora = 1;

    while (contadora <= 15)
    {
      Console.WriteLine($"3 ^ {contadora} = {acumuladora}");
      acumuladora *= 3;

      contadora++;
    }
  }
}