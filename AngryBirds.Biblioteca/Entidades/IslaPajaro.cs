using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirds.Biblioteca.Entidades;

public class IslaPajaro
{
    public List<Pajaro> Pajaros { get; set; } = new List<Pajaro>();

    public int FuerzaTotal()
    {
        return Pajaros.Sum(p => p.CalcularFuerza());
    }

    public List<Pajaro> PajarosFuertes()
    {
        return Pajaros.Where(a => a.CalcularFuerza() > 5000).ToList();
    }
}