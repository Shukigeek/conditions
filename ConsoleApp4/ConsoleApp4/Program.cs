int tenperature = 78;
int toxicity = 40;
int colorCode = 5;
int glowLevel = 6;
int baseScore = (100 - toxicity) + glowLevel * 3 - Math.Abs(colorCode - 7) * 2;
if  (baseScore > 80)
{
    Console.WriteLine("The potion is successful");

}
if (tenperature > 90 ||  toxicity > 70)
{
    Console.WriteLine("The potion is dangerous");
}