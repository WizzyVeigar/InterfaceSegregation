﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    interface ICharacter
    {
        void Heal();
        void Die();
        void Fight();
    }
}
