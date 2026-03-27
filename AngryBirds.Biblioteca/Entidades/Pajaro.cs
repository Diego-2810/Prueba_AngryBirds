using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirds.Biblioteca.Entidades;

public abstract class Pajaro
{
    public int Ira { get; set; }
    public int Peso { get; set; }
    public int Fuerza { get; set; }
    public abstract int CalcularFuerza();
    public virtual void Enojarse()
    {
        Ira *= 2;
    }
}
