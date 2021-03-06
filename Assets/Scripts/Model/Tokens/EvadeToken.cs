﻿using Ship;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tokens
{

    public class EvadeToken : GenericToken
    {
        public EvadeToken(GenericShip host) : base(host)
        {
            Name = ImageName = "Evade Token";
            TokenColor = TokenColors.Green;
            TokenShape = TokenShapes.Cirular;
            PriorityUI = 60;
            Action = new ActionsList.EvadeAction() { HostShip = host };
        }

    }

}
