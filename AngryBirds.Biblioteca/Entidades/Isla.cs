using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirds.Biblioteca.Entidades;

public class Isla
{
    public List<Pajaro> Pajaros { get; set; } = new List<Pajaro>();

    public int CalcularFuerzaTotal()
    {
        return Pajaros.Sum(p => p.CalcularFuerza());
    }
}