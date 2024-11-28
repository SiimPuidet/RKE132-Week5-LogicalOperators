//Math >= 90; Biology >= 90; Chemistry >= 90;
int math, biology, chemistry; //sisestame muutujad vahemällu

Console.WriteLine("Enter your Math result:"); //palume kasutajal matemaatika eksami tulemus sisestada
math = Int32.Parse(Console.ReadLine()); //muudame selle arvväärtuseks

Console.WriteLine("Enter your Biology result:"); //palume kasutajal bioloogia eksami tulemus sisestada
biology = Int32.Parse(Console.ReadLine()); //muudame selle arvväärtuseks

Console.WriteLine("Enter your Chemistry result:"); //palume kasutajal keemia eksami tulemus sisestada
chemistry = Int32.Parse(Console.ReadLine()); //muudame selle arvväärtuseks

if(math >= 90 && biology >= 90 && chemistry >= 90) //seame tingimuse, et kõik eksami tulemused peavad olema >= 90%
{
    Console.WriteLine("Congratulations! You got accepted."); //kui tingimus on täidetud, õnnitleme
}
else
{
    Console.WriteLine("Your application cannot be approved."); //kui tingimus ei ole täidetud, teatame ebaõnnnestumisest
}
