using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Program
    {
        ICharacter barb = new Barbarian();
        ICharacter knight = new Knight();
        ICharacter witch = new Witch();
        ICharacter wiz = new Wizard();

    }
}