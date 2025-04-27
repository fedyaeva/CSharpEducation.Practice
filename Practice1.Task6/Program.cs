double catetA = 3;
double catetB = 4;
double hypotinuse = 5;
double unknownHypotinuse = Math.Sqrt(catetA*catetA + catetB*catetB);
Console.Write("В треугольнике с катетом " + catetA + " и катетом " + catetB + " гипотенуза равна " + unknownHypotinuse + "\n");
double unknownCatet = Math.Sqrt(hypotinuse*hypotinuse - catetA*catetA);
Console.Write("В треугольнике с катетом " + catetA + " и гипотенузой " + hypotinuse + " второй катет равен " + unknownCatet);