// See https://aka.ms/new-console-template for more information
using System.Numerics;

int daysYear = 365;
decimal centValue = 0.01m;

BigInteger billionFinalYear = 0;
BigInteger oneBillion = 1000000000;

BigInteger centFinalYear = new BigInteger(centValue * 100);

for (var i = 0; i < daysYear; i++ )
{

    centFinalYear *= 2;
    billionFinalYear += oneBillion;
}
Console.WriteLine("Centavos duplicados por dia: " + centFinalYear);
Console.WriteLine("//////");
Console.WriteLine("Um bilhão por dia: " + billionFinalYear);
Console.WriteLine("Centavos duplicados por dia: " + string.Format("{0:N0}", centFinalYear));
