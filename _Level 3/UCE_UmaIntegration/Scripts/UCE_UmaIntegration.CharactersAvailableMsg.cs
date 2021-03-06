﻿// =======================================================================================
// Created and maintained by iMMO
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............: https://discord.gg/YkMbDHs
// * Public downloads website...........: https://www.indie-mmo.net
// * Pledge on Patreon for VIP AddOns...: https://www.patreon.com/IndieMMO
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
#if _UMA

using System.Collections.Generic;
using UnityEngine;

public partial class CharactersAvailableMsg
{
    public partial struct CharacterPreview
    {
        public string umaDna;
    }

    private void Load_UmaIntegration(List<Player> players)
    {
        for (int i = 0; i < players.Count; ++i)
        {
            characters[i].umaDna = players[i].umaDna;
        }
    }
}

#endif