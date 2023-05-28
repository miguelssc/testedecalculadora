Double n1;
Double n2;
String operaçao;
Console.WriteLine("calculadora basica");
Console.WriteLine("");
Console.WriteLine("digite um numero");
n1= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite outro numero");
n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("+ = mais  - = menos, / = divisao, % = multiplicaçao");
Console.WriteLine("escolha uma das 4 operaçao a calculadora vai fazer");
operaçao = Console.ReadLine()!;
if (operaçao == "+" ) {
Double resultadomais = n1 + n2;
Console.WriteLine($"{resultadomais}");

}
if ( operaçao == "-"){
    Double resultadomenos = n1 -n2;

Console.WriteLine($"{resultadomenos}");

}
if (operaçao == "/"|| n1 != 0){
    Double resultadodivisao = n1 / n2 ;
Console.WriteLine($"{resultadodivisao}");

}

else{
 Console.WriteLine("nao e possivel dividir um numero por 0");
}


if(operaçao =="%"){
  
  Double resultadomulti = n1 % n2;
Console.WriteLine($"{resultadomulti}");

}
