using System;

public class Program
{
   static  void Main()
    {
      int menorDistancia = 32767;
      int []v1 = {-3,0,3,6,9,12,15,18,21,24,27,30};
      int []v2 = {-14,-7,7,14,23,28,35,42,49,56,63};
      int aux = menorDistancia;
      for (int i = 0; i < v1.Length; i++)
           {
            for (int j = 0; j < v2.Length; j++)
            {
              if (v1[i] > v2[j]){
                if(aux > v1[i] -  v2[j])
                {
                  aux =  v1[i] -  v2[j];
                }
              }else{
                if(aux > v2[j]- v1[i])
                {
                  aux =  v2[j] - v1[i];
                }
              }
              if(menorDistancia > aux){
                menorDistancia = aux;
                }
           }
         }
      Console.WriteLine("Menor Distancia = "+ menorDistancia);
    }
}