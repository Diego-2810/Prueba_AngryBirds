using Xunit;
using AngryBirds.Biblioteca.Entidades;

public class IslaTest
{
    [Fact]
    public void Isla_CalcularFuerzaTotal()
    {
        var isla = new Isla();
        var red = new Red { Ira = 2 };
        var chuck = new Chuck { Velocidad = 50 };
        var bomb = new Bomb { Ira = 5000 };

        red.Enojarse();
        chuck.Enojarse();

        isla.Pajaros.Add(red);
        isla.Pajaros.Add(chuck);
        isla.Pajaros.Add(bomb);

        var fuerzaTotal = isla.CalcularFuerzaTotal();

        Assert.Equal(40 + 150 + 9000, fuerzaTotal);
    }
}