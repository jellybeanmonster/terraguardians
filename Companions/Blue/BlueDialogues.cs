using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using System.Collections.Generic;

namespace terraguardians.Companions
{
    public class BlueDialogues : CompanionDialogueContainer
    {public override string GreetMessages(Companion companion)
        {
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "*Hello Terrarian. If I'm a Werewolf? What is a Werewolf?*";//"\"Is... That... a Werewolf? I don't think so... It's a taller one?\"";
                case 1:
                    return "*Hi. I didn't expected to meet someone else here.*";//"\"As soon as I got closer to it, that... Wolf? Friendly waved at me.\"";
                case 2:
                    return "*Are you here for camping too? I love sitting by the fire sometimes.*"; //"\"She is asking me If I'm camping too.\"";
                default:
                    return "*Hello. I was about to setup a campfire here, want to join in?*"; //"\"She seems to be enjoying the bonfire, until I showed up.\"";
            }
        }
        public override string NormalMessages(Companion guardian)
        {
            bool ZacksRecruited = false; //He's not implemented yet
            List<string> Mes = new List<string>();
            if (!Main.bloodMoon)
            {
                Mes.Add("*Yes, [nickname]. Need something?*"); //"*[name] is looking at me with a question mark face, while wondering what you want.*");
                Mes.Add("*I'm so happy to see you.*"); //"*[name] looks to me while smiling.*");
                if (Main.LocalPlayer.head == 17)
                {
                    Mes.Add("*That's one cute little hood you got. Makes me want to hug you.*");//"*[name] says that you look cute with that hood.*");
                }
                /*if (MainMod.IsPopularityContestRunning)
                {
                    Mes.Add("*Hey [nickname]. Did you knew that the TerraGuardians Popularity Contest is running right now? Be sure to vote some time.*");
                    Mes.Add("*The TerraGuardians Popularity Contest is currently running. You can access the voting by speaking to me about it.*");
                }*/
                Mes.Add("*Have you heard Deadraccoon5? Oh, I feel bad for you right now.*");
            }
            else
            {
                Mes.Add("*Grrr.... What do you want?*"); //"*[name] is growling and showing her teeth as I approached her.*");
                Mes.Add("*Have you came to annoy me?!* (Her facial expression is very scary. I should avoid talking to her.)"); //"*[name]'s facial expressions is very scary, I should avoid talking to her at the moment.*");
            }
            if (!ZacksRecruited)
            {
                if (true || !Main.bloodMoon) //Todo - When Zacks is implemented, I need to remove the true flag.
                {
                    if (Main.raining)
                        Mes.Add("*This weather was a lot better when I was with...*"); //"*[name] looks sad.*");
                    if (!Main.dayTime)
                        Mes.Add("*Awooooo. Snif~ Snif~* (She looks in sorrow)");//"*[name] howls to the moon, showing small signs of sorrow.*");
                }
                else
                {
                    if (!Main.dayTime)
                        Mes.Add("*I'm feeling the presence of... [nickname], could you take me and check the border of this world? I think someone I'm looking for may be found there.*"); //"*[name] is saying that she is feeling a familiar presence, coming from the far lands of the world. Saying that we should check.*");
                }
            }
            //Outfit messages
            /*if (!Main.bloodMoon)
            {
                switch (guardian.OutfitID)
                {
                    case RedHoodOutfitID:
                        Mes.Add("*I really love this outfit! I feel very much into starting a new adventure when wearing this.*"); //"*[name] is saying that she likes that outfit. She also tells you that feels very adventurous when wearing It.*");
                        break;
                    case CloaklessOutfitID:
                        Mes.Add("*I really love this outfit, but I preffer using my cloak too...*"); //"*[name] says that likes this outfit, but would like having her cloak on too.*");
                        break;
                }
            }*/
            if (!Main.dayTime)
            {
                if (!Main.bloodMoon)
                {
                    Mes.Add("*Yawn... Feeling sleepy, [nickname]? Me too.*"); //"*[name] looks sleepy.*");
                    Mes.Add("*Why I'm circling the room? I... Have no idea..*"); //"*[name] is circling the room, I wonder what for.*");
                }
            }
            /*switch (guardian.OutfitID)
            {
                case RedHoodOutfitID:
                    Mes.Add("*Now I'm ready for adventure.*"); //"*[name] says that now she's ready for adventure.*");
                    Mes.Add("*This outfit has everything: It's comfy and has style. What else could I want?*"); //"*[name] is saying that she finds this outfit comfy and style.*");
                    Mes.Add("*The cloak is the most important part of this outfit. I'd feel naked without it.*"); //"*[name] is saying that the cloak is the most important part of her outfit.*");
                    Mes.Add("*Hey, [nickname]. What do you think of my outfit?*"); //"*[name] asks what you think of her outfit.*");
                    break;
                case CloaklessOutfitID:
                    Mes.Add("*Now I'm ready for adventure.*"); //"*[name] says that now she's ready for adventure.*");
                    Mes.Add("*This outfit doesn't feel the same without the cloak...*"); //"*[name] seems to be missing the cloak.*");
                    Mes.Add("*Hey, [nickname]. What do you think of my outfit?*"); //"*[name] asks what you think of her outfit.*");
                    break;
            }*/
            Mes.Add("*There was a weird Terrarian I met once, named beaverrac. It was so weird that he didn't even tried to speak to me, but I can't blame him, since a lot of weird things were happening.*"); //"*[name] tells you of a Terrarian she met, named beaverrac. She said that found weird that he didn't talked with her, beside there were a lot of weird things happening around too.");
            if (Terraria.GameContent.Events.BirthdayParty.PartyIsUp)
            {
                Mes.Add("*Let's dance, [nickname].* (She's stealing all the spotlights of the party.)"); //"*[name] is stealing all the spotlights of the party.*");
                if (PlayerMod.PlayerHasCompanionSummoned(Main.LocalPlayer, 3))
                {
                    Mes.Add("*Hey [gn:3], let's dance!*"); //"*[name] is calling [gn:3] for a dance.*");
                    Mes.Add("(She's is dancing with [gn:3], they seems to be enjoying.)");
                }
            }
            Player player = Main.LocalPlayer;
            if ((guardian.ID != 2 || guardian.ModID != MainMod.mod.Name) && !PlayerMod.PlayerHasCompanionSummoned(player, 2))
            {
                Mes.Add("*I'm so bored... I want to play a game, but nobody seems good enough for that...*"); //"*[name] is bored. She would like to play a game, but nobody seems good for that.*");
            }
            if (guardian.ID == 3 && guardian.ModID == MainMod.mod.Name && PlayerMod.PlayerHasCompanionSummoned(player, 2))
                Mes.Add("(First, [name] called [gn:3] to play a game, now they are arguing about what game they want to play. Maybe I should sneak away very slowly.)");
            if (PlayerMod.PlayerHasCompanionSummoned(player, 3) && PlayerMod.PlayerHasCompanionSummoned(player, 2))
                Mes.Add("*Hey, [nickname], may I borrow [gn:3] for a few minute? I want to play a game with [gn:2] and would love having his company.*"); //"*[name] is asking if she could borrow [gn:3] for a minute, so they could play a game with [gn:2].*");
            if (NPC.AnyNPCs(Terraria.ID.NPCID.WitchDoctor))
                Mes.Add("(She seems to be playing with flasks of poison.)");
            if (NPC.AnyNPCs(Terraria.ID.NPCID.Stylist))
                Mes.Add("*Check out my hair. I visitted [nn:"+Terraria.ID.NPCID.Stylist+"] and she did wonders to it.*"); //"*[name] wants you to check her hair.*");
            if (MainMod.HasCompanionInWorld(0))
                Mes.Add("*I really don't like talking to [gn:0], he's childish and annoying. I feel like I babysit him.*"); //"*[name] seems to be complaining about [gn:0], saying he's childish and annoying.*");
            if (PlayerMod.PlayerHasCompanionSummoned(player, 0))
                Mes.Add("*Urgh... You came too... Nice...* (She doesn't seems to like having [gn:0]'s presence.)"); //"*[name]'s mood goes away as soon as she saw [gn:0].*");
            if (PlayerMod.PlayerHasCompanionSummoned(player, 3))
                Mes.Add("*Oh, hello. I'm glad to see you and [gn:3] visitting me...* (She looks a bit saddened)"); //"*[name] said that she feels good for knowing that [gn:3] is around, but she also looks a bit saddened.*");
            if (MainMod.HasCompanionInWorld(2))
                Mes.Add("*My teeth are itching right now. Do you know where [gn:2] is?*"); //"*[name] is saying that wants to bite something, and is asking If I've seen [gn:2] somewhere.*");
            if (PlayerMod.PlayerHasCompanionSummoned(player, 2))
                Mes.Add("*Hey [gn:2], wanna play a game?* ([gn:2] ran away)"); //"*[name] said that she wants to play. For some reason, [gn:2] ran away.*");
            if (MainMod.HasCompanionInWorld(2) && MainMod.HasCompanionInWorld(5))
            {
                Mes.Add("(She is watching [gn:2] and [gn:5] playing together, with a worry face.)");
                Mes.Add("*Ever since [gn:5] arrived, I didn't had much chances of playing with [gn:2]...*"); //"*[name] says that didn't had much chances to play with [gn:2], since most of the time he ends up playing with [gn:5].*");
            }
            if (MainMod.HasCompanionInWorld(5) && !PlayerMod.PlayerHasCompanionSummoned(player, 5))
            {
                Mes.Add("(She's is whistling, like as if was calling a dog, and trying to hide the broom she's holding on her back.)");
                Mes.Add("*Alright, do tell that mutt [gn:5] that the next time he leaves a smelly surprise in my front door, I'll show him how resistant to impact is my broom!*"); //"*[name] is telling me that the next time [gn:5] leaves a smelly surprise on her front door, she'll chase him with her broom.*");
            }
            if (MainMod.HasCompanionInWorld(7))
                Mes.Add("*I really hate when [gn:7] interrupts me, when I'm playing with [gn:2]. She's just plain boring.*"); //"*[name] says that really hates when [gn:7] interrupts when playing with [gn:2].*");
            if (MainMod.HasCompanionInWorld(8))
            {
                Mes.Add("*The audacity [gn:8] have... Insulting my looks in my presence! How she dares!*"); //"*[name] is angry, because [gn:8] insulted her hair earlier.*");
                Mes.Add("*Who does [gn:8] think she is? I'm prettier than her!*"); //"*[name] is complaining about [gn:8], asking who she thinks she is.*");
            }
            if (MainMod.HasCompanionInWorld(CompanionDB.Leopold))
            {
                Mes.Add("*I'm really happy for having [gn:10] around my arms... I mean... Around. Yes, around.*"); //"*[name] is very happy for having [gn:10] around.*");
            }
            if (MainMod.HasCompanionInWorld(CompanionDB.Vladimir))
            {
                if (NPC.AnyNPCs(Terraria.ID.NPCID.ArmsDealer) && NPC.AnyNPCs(Terraria.ID.NPCID.Nurse))
                {
                    Mes.Add("*[nn:"+Terraria.ID.NPCID.Nurse+"] came earlier to me, asking for tips for her date with [nn:"+Terraria.ID.NPCID.ArmsDealer+"]. Of course I had the perfect tip, I hope she executes it well.*"); //"*[name] tells that [nn:" + Terraria.ID.NPCID.Nurse + "] appeared earlier, asking for tips on what to do on a date with [nn:"+Terraria.ID.NPCID.ArmsDealer+"]. She said that she gave some tips that she can use at that moment.*");
                }
                if (!MainMod.HasCompanionInWorld(CompanionDB.Zacks))
                    Mes.Add("*Hey. Say... Have you seen [gn:"+CompanionDB.Vladimir+"]? I... Really need to see him...* (She seems to be wiping some tears from her face)"); //"*[name] asks If you have seen [gn:"+Vladimir+"], after removing a tear from her face. She seems to need to speak with him.*");
            }
            if (MainMod.HasCompanionInWorld(CompanionDB.Michelle))
            {
                Mes.Add("*I really hate when [gn:"+CompanionDB.Michelle+"] pets my hair, she ruins my haircare.*"); //"*[name] says that hates when [gn:" + GuardianBase.Michelle + "] pets her hair.*");
                Mes.Add("*I keep telling [gn:"+CompanionDB.Michelle+"] that I need some space, but she just don't get it!*"); //"*[name] is saying taht needs some space, but [gn:" + GuardianBase.Michelle + "] doesn't get it.*");
            }
            if (MainMod.HasCompanionInWorld(CompanionDB.Malisha))
            {
                Mes.Add("(She seems to have tried casting some spell on you) *Hm... It didn't worked. Did I do it right? Better I research* (The book cover says something about polymorphing.)"); //"*[name] seems to have casted some kind of spell on you, but It didn't seem to work. With a disappointment look, she tells herself that needs to research some more.*");
                if(!PlayerMod.PlayerHasCompanion(Main.LocalPlayer, CompanionDB.Zacks))
                    Mes.Add("(She seems to be reading some kind of magic book.)");
                else
                    Mes.Add("(She seems focused into reading books about necromancy and biology.)");
            }
            if (MainMod.HasCompanionInWorld(CompanionDB.Fluffles))
            {
                Mes.Add("*I really enjoy having [gn:"+CompanionDB.Fluffles+"] around. She always comes up to check up if I'm fine.*"); //"*[name] seems to be enjoying having [gn:" + Fluffles + "] around. They seems to be get along very well.*");
                Mes.Add("*I've been sharing some beauty tips with [gn:"+CompanionDB.Fluffles+"]. Beside she can't speak, she managed to teach me some new tips related to that.*"); //"*[name] told you that she's sharing some beauty tips with [gn:" + Fluffles + "]. She said that learned something new with that.*");
                if (MainMod.HasCompanionInWorld(CompanionDB.Sardine))
                {
                    Mes.Add("*Playing Cat and Wolf with [gn:"+CompanionDB.Sardine+"] got more fun after I invited [gn:"+CompanionDB.Fluffles+"] to play too. She often catches him off guard, but that kind of makes the game easier.*"); //"*[name] says that always teams up with [gn:"+Fluffles+"] to catch [gn:"+Sardine+"] on Cat and Wolf. [gn:"+Fluffles+"] catches him off guard more easier than her, but she also said that the game got easier too.*");
                }
            }
            if (MainMod.HasCompanionInWorld(CompanionDB.Minerva))
            {
                Mes.Add("*I'm not in the mood now.... Grr....* (She seems to have came angry from [gn:17]'s place. I wonder what happened.)"); //"*[name] seems to have came from [gn:17]'s place angry. I wonder what happened.*");
                Mes.Add("(She seems to be eating a Squirrel on a Spit.) Oh, hi. I'm just nibbling something.");
            }
            if (MainMod.HasCompanionInWorld(CompanionDB.Luna))
            {
                Mes.Add("*I'm so happy to have [gn:" + CompanionDB.Luna + "] around. She has so many good points.*");
                Mes.Add("*Sometimes, [gn:" + CompanionDB.Luna + "] and I compare whose fur has better texture.*");
            }
            if (MainMod.HasCompanionInWorld(CompanionDB.Cille))
            {
                Mes.Add("*I greeted [gn:" + CompanionDB.Cille + "] the other day, but she told me to go away.*");
                Mes.Add("*There is something wrong with [gn:" + CompanionDB.Cille + "], I visited her some night, and she attacked me! Then the other day, she was back to being the shy person we know. What is wrong with her?*");
            }
            if (Main.moonPhase == 0 && !Main.dayTime && !Main.bloodMoon)
            {
                Mes.Add("*I'm sorry for calling your attention, [nickname]. I wasn't actually calling you.*"); //"*[name] apologizes, saying that she wasn't calling you at the moment.*");
                Mes.Add("(She's staring at the moon.)");
            }
            if (BlueBase.HasBunnyInInventory(guardian))
            {
                Mes.Add("*How did you knew I loved bunnies? I really loved this gift. Thank you.*"); //"*[name] asks how did you know, and tells you that she loved the pet you gave her.*");
            }
            return Mes[Main.rand.Next(Mes.Count)];
        }

        public override string TalkMessages(Companion companion)
        {
            Player player = MainMod.GetLocalPlayer;
            List<string> Mes = new List<string>();
            if (PlayerMod.PlayerHasCompanionSummoned(player, 0))
                Mes.Add("*Oh, you brought [gn:0] with you... Do you have some \"Naggicide\" too?*"); //"*[name] is asking me if she knows any good \"Naggicide\", why? Because she wants to use it on that guy following you.*");
            if (WorldMod.HasCompanionNPCSpawned(0) && WorldMod.CompanionNPCs[WorldMod.GetCompanionNpcPosition(0)].Distance(player.Center) < 1024f)
                Mes.Add("*Mind sending [gn:0] somewhere far away from me?*"); //"*[name] is asking if you could send [gn:0] some place far away from her.*");
            if (WorldMod.HasCompanionNPCSpawned(3) && WorldMod.CompanionNPCs[WorldMod.GetCompanionNpcPosition(3)].Distance(player.Center) >= 768f)
                Mes.Add("*Say, [gn:3] is living here too, right? Could I move to somewhere close to him?*"); //"*[name] would like to move to somewhere closer to [gn:3].*");
            if (NPC.AnyNPCs(Terraria.ID.NPCID.WitchDoctor))
                Mes.Add("*Tell me, what is your favorite type of poison?*"); //"*[name] is asking you what is your favorite type of poison.*");
            if (!PlayerMod.PlayerHasCompanionSummoned(player, 1))
            {
                Mes.Add("*What do you think of what I did to my room?*"); //"*[name] is asking what you think about what she did with her room.*");
                Mes.Add("*I'd like to travel the world with you. Take me some time.*"); //"*[name] wants to travel the world with you.*");
                Mes.Add("*Would you mind helping me move some furnitures?*"); //"*[name] asks if you want to help her move some furnitures.*");
                Mes.Add("*Those fleas are killing me. Do you have some remedy to kill them?*"); //"*[name] is asking if you have any flea killing remedy.*");
            }
            else
            {
                if (NPC.AnyNPCs(Terraria.ID.NPCID.Stylist))
                    Mes.Add("*I want to visit [nn:"+Terraria.ID.NPCID.Stylist+"] some time.*"); //"*[name] wants to visit [nn:" + Terraria.ID.NPCID.Stylist + "] sometime.*");
                if (Main.moonPhase == 0 )
                {
                    if (!PlayerMod.PlayerHasCompanion(player, 3))
                    {
                        Mes.Add("*I'm sorry... I'm just missing.... Someone...*"); //"*[name] seems to be missing someone.*");
                    }
                    else
                    {
                        Mes.Add("*I always love full moons, because they remind me of [gn:3].*"); //"*[name] said that the full moon always reminds her of [gn:3].*");
                    }
                }
            }
            if (PlayerMod.PlayerHasCompanionSummoned(player, 2))
            {
                Mes.Add("*Hey [gn:2], wanna play a game?* ([gn:2] is panicking right now.)"); //"*[name] said that she wants to play a game with [gn:2], causing him to panic for some reason.*");
            }
            if (PlayerMod.PlayerHasCompanionSummoned(player, 3))
            {
                Mes.Add("*It's... It's so good to see you again, [gn:3]...* (She looks relieved for seeing [gn:3], but also looks a bit saddened.)"); //"*[name] got a bit saddened when she saw [gn:3], but feels a bit relieved for seeying him.*");
            }
            else if (PlayerMod.PlayerHasCompanion(player, 3))
            {
                Mes.Add("*I wonder.... Is there some way of bringing [gn:3] to his old self?*"); //"*[name] keeps wondering if there is a way of bringing [gn:3] to his old self.*");
            }
            if (WorldMod.HasCompanionNPCSpawned(3))
                Mes.Add("*I admit. I initially came to your world looking for [gn:3], but after seeing how beautiful the environment here is, I decided to stay for longer. Since [gn:3] is here, we can then stay for even longer.*"); //"*[name] says that initially she came to the world looking for [gn:3], but after seeying how beautiful the environment is, she decided to stay more. And since [gn:3] is here, she can stay for longer.*");
            Mes.Add("*Want to go shopping, [nickname]? So... Would you like lending me some coins too?*"); //"*[name] wants to go shopping, and is asking if you would lend some coins.*");
            if (Main.bloodMoon)
                Mes.Add("*I'm so furious right now, that I could kill someone! I'm so glad outside has many options.*"); //"*[name] is so furious right now that she could kill someone, good thing that outside has many options.*");
            return Mes[Main.rand.Next(Mes.Count)];
        }

        public override string TalkAboutOtherTopicsMessage(Companion companion, TalkAboutOtherTopicsContext context)
        {
            switch(context)
            {
                case TalkAboutOtherTopicsContext.FirstTimeInThisDialogue:
                    return "*Oh, what do you want to talk about?*";
                case TalkAboutOtherTopicsContext.AfterFirstTime:
                    return "*Is there anything else you want to talk about?*";
                case TalkAboutOtherTopicsContext.Nevermind:
                    return "*Alright. Want to talk about something else, then?*";
            }
            return base.TalkAboutOtherTopicsMessage(companion, context);
        }

        public override string RequestMessages(Companion companion, RequestContext context)
        {
            switch(context)
            {
                case RequestContext.NoRequest:
                    if (Main.rand.NextDouble() < 0.5)
                        return "*I don't want anything right now. Come back later and I may be in need of something.*";
                    return "*No, I'm not in need of anything right now.*";
                case RequestContext.HasRequest:
                    if (Main.rand.NextDouble() < 0.5)
                        return "*I'm so glad you asked. I really need a thing done, but I'm already busy with something else, if you could help me... This is my problem, if you ask: [objective]*";
                    return "*I'm so happy you asked! Here, check this: \"[objective]\". Will you do it?*";
                case RequestContext.Completed:
                    if (Main.rand.NextDouble() < 0.5)
                        return "*I'm so happy that you managed to do that. Thank you, [nickname].*";
                    return "*I'm so happy that I could kiss you. Thanks!* (She's wagging her tail while smiling)";
                case RequestContext.Failed:
                    return "*I'm really disappointed that you managed to fail my request. Don't worry, by the way... It's fine.*";
                case RequestContext.Accepted:
                    return "*Be careful when doing my request, [nickname].*";
                case RequestContext.Rejected:
                    return "*Oh... Well... Better I store this list for me to do some other time, then.*";
                case RequestContext.TooManyRequests:
                    return "*You wont be able to focus on my request, due to having many other requests opened.*";
                case RequestContext.PostponeRequest:
                    return "*Did you find the request impossible, or you can't do it right now?*";
                case RequestContext.AskIfRequestIsCompleted:
                    return "*Did you do what I asked?*";
                case RequestContext.RemindObjective:
                    return "*I asked you to [objective].*";
            }
            return base.RequestMessages(companion, context);
        }

        public override string JoinGroupMessages(Companion companion, JoinMessageContext context)
        {
            switch(context)
            {
                case JoinMessageContext.Success:
                    return "*I was getting bored of staying at home, anyways. Let's go on an adventure!*";
                case JoinMessageContext.Fail:
                    return "*I'm not interessed in going on an adventure right now.*";
                case JoinMessageContext.FullParty:
                    return "*I dislike crowds.*";
            }
            return base.JoinGroupMessages(companion, context);
        }

        public override string LeaveGroupMessages(Companion companion, LeaveMessageContext context)
        {
            switch(context)
            {
                case LeaveMessageContext.Success:
                    return "*Farewell, [nickname]. Remember to find the other wolf TerraGuardian I seek.*";
                case LeaveMessageContext.Fail:
                    return "*I'm going nowhere else right now.*";
                case LeaveMessageContext.AskIfSure:
                    return "*You really want to leave me here?*";
                case LeaveMessageContext.DangerousPlaceYesAnswer:
                    return "*Well, I think It will be entertaining slashing my way back home. See you there, [nickname].*";
                case LeaveMessageContext.DangerousPlaceNoAnswer:
                    return "*Phew...*";
            }
            return base.LeaveGroupMessages(companion, context);
        }

        public override string MountCompanionMessage(Companion companion, MountCompanionContext context)
        {
            switch(context)
            {
                case MountCompanionContext.Success:
                    return "*As long as you don't ruin my hair, I don't mind.*";
                case MountCompanionContext.SuccessMountedOnPlayer:
                    return "*You're going to give me a ride? My feet thanks you.*";
                case MountCompanionContext.Fail:
                    return "*No. I don't think so.*";
                case MountCompanionContext.NotFriendsEnough:
                    return "*No way. You might ruin my hair.*";
            }
            return base.MountCompanionMessage(companion, context);
        }

        public override string DismountCompanionMessage(Companion companion, DismountCompanionContext context)
        {
            switch(context)
            {
                case DismountCompanionContext.SuccessMount:
                    return "*I hope you left my hair the way it was.*";
                case DismountCompanionContext.SuccessMountOnPlayer:
                    return "*Back to walking.*";
                case DismountCompanionContext.Fail:
                    return "*That doesn't seems like a good idea.*";
            }
            return base.DismountCompanionMessage(companion, context);
        }

        public override string AskCompanionToMoveInMessage(Companion companion, MoveInContext context)
        {
            switch(context)
            {
                case MoveInContext.Success:
                    return "*Of course. I like the environment of this world, and also the people in it.*";
                case MoveInContext.Fail:
                    return "*No.. I would like not to live here for now..*";
                case MoveInContext.NotFriendsEnough:
                    return "*As much as I like this place, I don't know you enough for that.*";
            }
            return base.AskCompanionToMoveInMessage(companion, context);
        }

        public override string AskCompanionToMoveOutMessage(Companion companion, MoveOutContext context)
        {
            switch(context)
            {
                case MoveOutContext.Success:
                    return "*Awww.. I was enjoying living here...*";
                case MoveOutContext.Fail:
                    return "*Sorry, but I wont be moving right now.*";
                case MoveOutContext.NoAuthorityTo:
                    return "*I barelly know you. The person who let me move in was at least a friend of mine.*";
            }
            return base.AskCompanionToMoveOutMessage(companion, context);
        }

        public override string OnToggleShareChairMessage(bool Share)
        {
            if (Share) return "*I believe there is no harm in that..*";
            return "*I think that's a good idea too.*";
        }

        public override string OnToggleShareBedsMessage(bool Share)
        {
            if(Share)
            {
                if(MainMod.GetLocalPlayer.Male)
                    return "*As long as it's only for sleeping, I don't mind.*";
                return "*I'd be more comfortable by having the bed for myself, but sure, I may share with you.*";
            }
            return "*I don't oppose that.*";
        }
    }
}