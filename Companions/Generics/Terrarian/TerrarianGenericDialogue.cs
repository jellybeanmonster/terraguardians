using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using System.Collections.Generic;
using Terraria.ModLoader.IO;

namespace terraguardians.Companions.Generics.Terrarian
{
    public class TerrarianGenericDialogue : CompanionDialogueContainer
    {
        public override string GreetMessages(Companion companion)
        {
            switch (Main.rand.Next(3))
            {
                default:
                    return "Are you an adventurer too? I am an adventurer!";
                case 1:
                    return "Have you managed to beat any boss yet?";
                case 2:
                    return "Are you also seeing creatures popping up here, too?";
            }
        }

        public override string NormalMessages(Companion companion)
        {
            List<string> Mes = new List<string>();
            Mes.Add("Hello.");
            return Mes[Main.rand.Next(Mes.Count)];
        }

        public override string TalkMessages(Companion companion)
        {
            return "What's up?";
        }
    }
}