public class boxing_unboxing
{
  static object obj = 9; // 9 é um int por padrão empacotado dentro de um object
  long x = (int)obj; // unbox do int e cast implicito para long

  // Assim como o exemplo abaixo tbm funciona:
  static object objeto = 3.5; // 3.5 é automaticamente inferido como double empacotado dentro de um object

  // unbox de objeto para double. Depois cast implicito para int.
  // O valor do y será 3 (pois é apenas a parte inteira do valor 3.5)
  int y = (int)(double)objeto;
}