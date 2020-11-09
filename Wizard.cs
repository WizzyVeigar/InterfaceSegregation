using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Wizard : ICharacter, ITeleport, IThrowMagicMissile, IThrowFrostNova
    {
        public void Die()
        {
            throw new NotImplementedException();
        }

        public void Fight()
        {
            throw new NotImplementedException();
        }

        public void Heal()
        {
            throw new NotImplementedException();
        }

        public void Slash()
        {
            throw new NotImplementedException();
        }

        public void Teleport(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void ThrowFrostNova()
        {
            throw new NotImplementedException();
        }

        public void ThrowMagicMissile()
        {
            throw new NotImplementedException();
        }
    }
}
