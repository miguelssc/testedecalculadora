Double n1;
Double n2;
String operaçao;
Console.WriteLine("calculadora basica");
Console.WriteLine("");
Console.WriteLine("digite um numero");
n1= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite outro numero");
n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("+ = mais  - = menos, / = divisao, * = multiplicaçao");
Console.WriteLine("escolha uma das 4 operaçao a calculadora vai fazer");
operaçao = Console.ReadLine()!;
if (operaçao == "+" ) {
Double resultadomais = n1 + n2;
Console.WriteLine($"resultado = {resultadomais}");

}
if ( operaçao == "-"){
    Double resultadomenos = n1 -n2;

Console.WriteLine($"resultado = {resultadomenos}");

}
if (operaçao == "/"){
    Double resultadodivisao = n1 / n2 ;
    

Console.WriteLine($" resultado = {resultadodivisao}");

}




if(operaçao =="*"){
  
  Double resultadomulti = n1 * n2;
Console.WriteLine($"resulatdo = {resultadomulti}");

}
