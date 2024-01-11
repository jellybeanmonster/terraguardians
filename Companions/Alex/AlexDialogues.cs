using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using System.Collections.Generic;

namespace terraguardians.Companions
{
    public class AlexDialogues : CompanionDialogueContainer
    {
        public override string GreetMessages(Companion companion)
        {
            switch (Main.rand.Next(3))
            {
                case 0:
                    return "Hey, who are you? Are you my newest friend?";
                case 1:
                    return "More friends? I like that!";
                case 2:
                    return "Yay! I've met more people!";
            }
            return base.GreetMessages(companion);
        }

        public override string NormalMessages(Companion companion)
        {
            TerraGuardian guardian = (TerraGuardian)companion;
            List<string> Mes = new List<string>();
            Mes.Add("Yay! I've met more people!");
            Mes.Add("Don't worry, I'll protect you from any danger.");
            Mes.Add("I'm sure you would like to meet " + AlexRecruitmentScript.AlexOldPartner + ". Well, she was a bit closed off to other people, but she was my best pal, and that's what matters, I guess?");
            Mes.Add("I wonder if " + AlexRecruitmentScript.AlexOldPartner + "'s tombstone is alright. Should I check on it later?");

            Mes.Add("A number of Terrarians kept asking me how I managed to place "+AlexRecruitmentScript.AlexOldPartner+"'s tombstone in so many weird places, so now I learned how to place them properly.");
            Mes.Add("Whaaaaaaaaaaat? You can't place tombstones on trees? Or plants? Or in the water?");
            if(NPC.AnyNPCs(22))
                Mes.Add("[nn:22] taught me how to place things in the correct places properly, and now I can't place them in the wrong place.");

            if (Main.bloodMoon)
            {
                Mes.Add("Stay near me and you'll be safe.");
                Mes.Add("So many things to bite outside.");
            }
            if (Main.eclipse)
            {
                Mes.Add("I think I saw some of those guys in some movies I watched with " + AlexRecruitmentScript.AlexOldPartner + ".");
                Mes.Add("I don't fear any of those monsters outside. The only thing I fear is the Legion, but It doesn't exist in this world.");
            }
            if (Main.dayTime)
            {
                if (!Main.eclipse)
                {
                    if (!Main.raining)
                        Mes.Add("This day seems alright for playing outside!");
                    else
                        Mes.Add("The rain would spoil all the fun if it weren't for the puddles.");
                    Mes.Add("I still have two AA batteries to be depleted, so let's play a game!");
                }
            }
            else
            {
                if (!Main.bloodMoon)
                {
                    if (Main.moonPhase == 2)
                        Mes.Add("This night reminds me of an adventure I had with " + AlexRecruitmentScript.AlexOldPartner + ". That makes me miss her.");
                }
            }
            if (CanTalkAboutCompanion(0))
            {
                Mes.Add("When you are not around, I play some Hide and Seek with [gn:0]. He's terrible at hiding. His tail gives him away, but It's fun always finding him");
                if (NPC.AnyNPCs(Terraria.ID.NPCID.Merchant))
                    Mes.Add("Do you know why [gn:0] eats [nn:" + Terraria.ID.NPCID.Merchant + "]'s trash? I'd join him but, " + AlexRecruitmentScript.AlexOldPartner + " taught me that eating trash is bad.");
            }
            if (CanTalkAboutCompanion(1))
            {
                Mes.Add("I fertilized [gn:1]'s yard, and she thanked me by chasing me while swinging her broom at me. I guess we are besties now.");
                Mes.Add("[gn:1] looked very upset when I was playing with her red cloak. By the way, tell her that you didn't see me if she asks.");
                if (CanTalkAboutCompanion(2))
                    Mes.Add("Why does [gn:1] watch [gn:2] and I play? Why doesn't she join us in the fun? That would be better than staring, right?");
            }
            if (CanTalkAboutCompanion(2))
            {
                Mes.Add("[gn:2] called me to go on an adventure, I wonder if you will mind that.");
            }
            if (CanTalkAboutCompanion(3))
            {
                Mes.Add("I asked earlier if [gn:3] was using one of his bones. His answer was very rude.");
                if (CanTalkAboutCompanion(1))
                    Mes.Add("Why do [gn:3] and [gn:1] look a bit sad when they meet each other? Aren't they dating?");
                Mes.Add("I tried to cheer [gn:3] on. He threw a frisbee for me to catch, but when I returned, he wasn't there. Where did he go?");
            }
            if (CanTalkAboutCompanion(4))
            {
                Mes.Add("What's with [gn:4]? He never shows any kind of emotion when I talk to him. Even when we play.");
                Mes.Add("I don't really have any fun when playing with [gn:4] because he doesn't seem to be having fun.");
            }
            if (CanTalkAboutCompanion(0) && CanTalkAboutCompanion(2))
                Mes.Add("I've got [gn:0] and [gn:2] to play with me. I guess my new dream will be for everyone in the village to play together.");
            if (CanTalkAboutCompanion(7))
            {
                Mes.Add("I think sometimes [gn:7] feels lonely, so I stay nearby to make her feel less lonely.");
                Mes.Add("I smell a variety of things inside of [gn:7]'s bag, including food. Can you persuade her to open her bag and show us what is inside?");
            }
            if (CanTalkAboutCompanion(8))
            {
                Mes.Add("I love playing with [gn:8]. The other person that played as much with me was " + AlexRecruitmentScript.AlexOldPartner + ".");
                Mes.Add("I'm up to playing some more. Do you know if [gn:8] is free?");
            }
            if (CanTalkAboutCompanion(CompanionDB.Vladimir))
            {
                Mes.Add("(He's watching the horizon. Maybe he's thinking about something?)");
                Mes.Add("I have been talking with [gn:"+CompanionDB.Vladimir+"] and... No... Forget it... Nevermind what I was going to say.");
                Mes.Add("That [gn:" + CompanionDB.Vladimir + "] is a real buddy. He accompanies me when I go visit " + AlexRecruitmentScript.AlexOldPartner + "'s Tombstone. I don't feel alone when doing that anymore.");
            }
            if (CanTalkAboutCompanion(CompanionDB.Michelle))
            {
                Mes.Add("I've got a new friend, and the name is [gn:" + CompanionDB.Michelle + "]. What? I'm still your buddy too.*");
            }
            if (CanTalkAboutCompanion(CompanionDB.Wrath))
            {
                Mes.Add("*Whine~whine* [gn:" + CompanionDB.Wrath + "] is a mean guy, I tried playing with him, and then he gets really mad at me.");
                Mes.Add("I try making [gn:"+CompanionDB.Wrath+"] feel better, but he always yells at me.");
            }
            if (CanTalkAboutCompanion(CompanionDB.Fluffles))
            {
                Mes.Add("I don't know why some people are scared of [gn:" + CompanionDB.Fluffles + "], she's a good person. I like her.");
                Mes.Add("I love playing with [gn:" + CompanionDB.Fluffles + "]. She always knows my favorite petting spot.");
                if (CanTalkAboutCompanion(CompanionDB.Rococo))
                {
                    Mes.Add("Sometimes [gn:"+CompanionDB.Rococo+"] and [gn:"+CompanionDB.Fluffles+"] play with me. It's like a dream come true. I wish they could do that more often.");
                }
            }
            if (CanTalkAboutCompanion(CompanionDB.Miguel))
            {
                Mes.Add("[nickname]... I'm working hard... With the help of [gn:" + CompanionDB.Miguel + "]... To get stronger... and protect you...");
                Mes.Add("I'm exhausted... [gn:" + CompanionDB.Miguel + "]'s exercises are hardcore... But I'm feeling stronger.");
            }
            if (CanTalkAboutCompanion(CompanionDB.Luna))
            {
                Mes.Add("I like [gn:"+ CompanionDB.Luna+ "], she always rubs my belly when I ask.");
            }
            if (CanTalkAboutCompanion(CompanionDB.Celeste))
            {
                Mes.Add("Who is "+MainMod.TgGodName+"? Is he [gn:"+CompanionDB.Celeste+"] friend? If he is, he is my friend too.");
                Mes.Add("I sometimes lie next to [gn:"+CompanionDB.Celeste+"] when she's kneeling. She always pets me on the back of my head after that.");
            }
            if (CanTalkAboutCompanion(CompanionDB.Leona))
            {
                Mes.Add("[gn:"+CompanionDB.Leona+"] looked sad about hearing of what happened to "+AlexRecruitmentScript.AlexOldPartner+". She said that wouldn't have happened if she met us earlier...");
                Mes.Add("Whenever I pass through [gn:"+CompanionDB.Leona+"], she pets my head and call me a good boy. I like that.");
                Mes.Add("It's odd the scent [gn:"+CompanionDB.Leona+"] has. No other female in the world has a scent such as hers. Like, other females smell good.");
            }
            if (guardian.IsUsingToilet)
            {
                Mes.Add("I'm trying hard to aim at the hole.");
                Mes.Add("Is this how you humans use a toilet? It's very hard for me to use it.");
            }
            if (guardian.IsPlayerRoomMate(MainMod.GetLocalPlayer))
            {
                Mes.Add("You'll sleep in my bedroom? That's awesome! I will keep you protected while you sleep.");
                Mes.Add("You'll share your bed with me? This is the best day ever!");
            }
            if (guardian.IsSleeping)
            {
                Mes.Clear();
                Mes.Add("(He's moving his paws while sleeping, maybe he's dreaming that he's running?)");
                Mes.Add("No... Don't go... No... (He seems to be having a nightmare)");
                Mes.Add("(You can hear his silent snores.)");
            }
            if(PlayerMod.IsHauntedByFluffles(MainMod.GetLocalPlayer) && Main.rand.NextDouble() < 0.75)
            {
                Mes.Clear();
                Mes.Add("Who's she? Is she your friend? Can she play with me?");
            }
            /*if (FlufflesBase.IsCompanionHaunted(guardian) && Main.rand.Next(2) == 0)
            {
                Mes.Clear();
                Mes.Add("");
            }*/
            return Mes[Main.rand.Next(Mes.Count)];
        }

        public override string SleepingMessage(Companion companion, SleepingMessageContext context)
        {
            List<string> Mes = new List<string>();
            Mes.Add("(He's moving his paws while sleeping, maybe he's dreaming that he's running?)");
            Mes.Add("No... Don't go... No... (He seems to be having a nightmare)");
            Mes.Add("(You can hear his silent snores.)");
            return Mes[Main.rand.Next(Mes.Count)];
        }

        public override string RequestMessages(Companion companion, RequestContext context)
        {
            switch(context)
            {
                case RequestContext.NoRequest:
                    if (Main.rand.NextDouble() < 0.5)
                        return "Other than playing? I want nothing else.";
                    return "I'm full of energy if that's what you mean.";
                case RequestContext.HasRequest:
                    if (Main.rand.NextDouble() < 0.5)
                        return "I really need something to be done. What? You thought I was into playing 24/7? I also have my things too other than that. Can you do this for me? [objective]?";
                    return "There is a thing I need to be done, can you help me with it? I need to [objective], but I think I may need help with it...";
                case RequestContext.Completed:
                    if (Main.rand.NextDouble() < 0.5)
                        return "Yay! You're the best!";
                    return "You did it! Yay!";
                case RequestContext.Accepted:
                    return "You'll do It? Woof!";
                case RequestContext.TooManyRequests:
                    return "Won't you get overloaded? You seem to have lots to do already.";
                case RequestContext.Rejected:
                    return "Whine.. Whine.. It's okay.. It was a silly request anyway..";
                case RequestContext.PostponeRequest:
                    return "Not now? Try helping me with this later. Woof!";
                case RequestContext.Failed:
                    return "You couldn't do it? Don't worry. *He seems to be trying to cheer you up now*";
                case RequestContext.AskIfRequestIsCompleted:
                    return "Did you do it? Did you do it?";
                case RequestContext.RemindObjective:
                    return "You forgot? It's fine! I asked you to [objective].";
                case RequestContext.CancelRequestAskIfSure:
                    return "Yipee! Wait, what? You don't want to do that for me?";
                case RequestContext.CancelRequestYes:
                    return "*Whine whine* Fine... I'm not sad or anything...";
                case RequestContext.CancelRequestNo:
                    return "*Happily wags his tail*";
            }
            return base.RequestMessages(companion, context);
        }

        public override string JoinGroupMessages(Companion companion, JoinMessageContext context)
        {
            switch(context)
            {
                case JoinMessageContext.Success:
                    return "You're taking me out for a walk? Cool! I'll get the leash.";
                case JoinMessageContext.Fail:
                    return "I don't want to go out for a walk right now...";
                case JoinMessageContext.FullParty:
                    return "Uh... There are too many people with you right now...";
            }
            return base.JoinGroupMessages(companion, context);
        }

        public override string LeaveGroupMessages(Companion companion, LeaveMessageContext context)
        {
            switch(context)
            {
                case LeaveMessageContext.AskIfSure:
                    return "You're going to leave me here? All alone?";
                case LeaveMessageContext.Success:
                    return "Okay! I'll be waiting for your return. Woof!";
                case LeaveMessageContext.DangerousPlaceYesAnswer:
                    return "Alright... I'll be heading home then...";
                case LeaveMessageContext.DangerousPlaceNoAnswer:
                    return "Woof! Amazing!";
                case LeaveMessageContext.Fail:
                    return "Woof! No way. I'll follow you for a bit longer.";
            }
            return base.LeaveGroupMessages(companion, context);
        }

        public override string TalkMessages(Companion companion)
        {
            List<string> Mes = new List<string>();
            Mes.Add("My old partner once said that I had C batteries in my body. What is that supposed to mean?");
            Mes.Add("You're the best, let's play a game?");
            Mes.Add(AlexRecruitmentScript.AlexOldPartner + " and I were the best friends ever! I should've followed my instincts and stopped her.");
            if (CanTalkAboutCompanion(0))
                Mes.Add("[gn:0] and I are trying to guess who's your best friend. Can you tell me?");
            if(!Main.dayTime && Main.moonPhase == 2)
                Mes.Add("Maybe I should tell you why " + AlexRecruitmentScript.AlexOldPartner + " isn't with us anymore... She tried to protect me from flying bugs in the purple place... I should be the one protecting her, not the inverse.");
            return Mes[Main.rand.Next(Mes.Count)];
        }

        public override string AskCompanionToMoveInMessage(Companion companion, MoveInContext context)
        {
            switch(context)
            {
                case MoveInContext.Success:
                    return "Woof! Woof! You've got a house for me? Woof! Woof! I'm so happy!";
                case MoveInContext.Fail:
                    return "I think now isn't the best moment for that.";
                case MoveInContext.NotFriendsEnough:
                    return "No. I still need to guard " + AlexRecruitmentScript.AlexOldPartner+ "'s tombstone.";
            }
            return base.AskCompanionToMoveInMessage(companion, context);
        }

        public override string AskCompanionToMoveOutMessage(Companion companion, MoveOutContext context)
        {
            switch(context)
            {
                case MoveOutContext.Success:
                    return "You don't want me around? Whine whine whine.. I'll look someplace else to stay then..";
                case MoveOutContext.Fail:
                    return "I will not leave my house.";
                case MoveOutContext.NoAuthorityTo:
                    return "You're not the one who let me live here. Why are you trying to make me leave?";
            }
            return base.AskCompanionToMoveOutMessage(companion, context);
        }

        public override string MountCompanionMessage(Companion companion, MountCompanionContext context)
        {
            switch(context)
            {
                case MountCompanionContext.Success:
                    return "Sure buddy. Just sit on my back.";
                case MountCompanionContext.SuccessMountedOnPlayer:
                    return "You'll carry me? Thanks pal.";
                case MountCompanionContext.Fail:
                    return "Not right now..";
                case MountCompanionContext.NotFriendsEnough:
                    return "Sorry friend, but no.";
                case MountCompanionContext.SuccessCompanionMount:
                    return "I don't mind doing that, buddy.";
                case MountCompanionContext.AskWhoToCarryMount:
                    return "Sure friend. Who should I carry?";
            }
            return base.MountCompanionMessage(companion, context);
        }

        public override string DismountCompanionMessage(Companion companion, DismountCompanionContext context)
        {
            switch(context)
            {
                case DismountCompanionContext.SuccessMount:
                    return "Alright pal.";
                case DismountCompanionContext.SuccessMountOnPlayer:
                    return "Thanks for the ride friend.";
                case DismountCompanionContext.Fail:
                    return "Now isn't the best moment for that.";
            }
            return base.DismountCompanionMessage(companion, context);
        }

        public override string TalkAboutOtherTopicsMessage(Companion companion, TalkAboutOtherTopicsContext context)
        {
            switch(context)
            {
                case TalkAboutOtherTopicsContext.FirstTimeInThisDialogue:
                    return "Do you want to talk to me? Want to play with me?";
                case TalkAboutOtherTopicsContext.AfterFirstTime:
                    return "Is there anything else you want to talk about?";
                case TalkAboutOtherTopicsContext.Nevermind:
                    return "Alright!";
            }
            return base.TalkAboutOtherTopicsMessage(companion, context);
        }

        public override string OnToggleShareBedsMessage(Companion companion, bool Share)
        {
            if (Share)
                return "You'll let me sleep on your bed? Yay!";
            return "Aww... I'll sleep on the floor then.";
        }

        public override string TacticChangeMessage(Companion companion, TacticsChangeContext context)
        {
            switch(context)
            {
                case TacticsChangeContext.OnAskToChangeTactic:
                    return "I need to change how I fight..? Can't I just bite my foes?";
                case TacticsChangeContext.ChangeToCloseRange:
                    return "Yes! I'll bite my foes!";
                case TacticsChangeContext.ChangeToMidRanged:
                    return "Not stick close to foes?";
                case TacticsChangeContext.ChangeToLongRanged:
                    return "Keep away from foes?";
                case TacticsChangeContext.Nevermind:
                    return "Alright!";
                case TacticsChangeContext.FollowAhead:
                    return "Woof! Yes! I will do that.";
                case TacticsChangeContext.FollowBehind:
                    return "I'll follow you.";
                case TacticsChangeContext.AvoidCombat:
                    return "I should avoid attacking monsters..? Ok..";
                case TacticsChangeContext.PartakeInCombat:
                    return "Woof! I can protect you again!";
            }
            return base.TacticChangeMessage(companion, context);
        }

        public override string ControlMessage(Companion companion, ControlContext context)
        {
            switch(context)
            {
                case ControlContext.SuccessTakeControl:
                    return "Linking with master.";
                case ControlContext.SuccessReleaseControl:
                    return "Unlinking.";
                case ControlContext.FailTakeControl:
                    return "Not right now.";
                case ControlContext.FailReleaseControl:
                    return "I don't think that's a good idea.";
                case ControlContext.NotFriendsEnough:
                    return "What?";
                case ControlContext.ControlChatter:
                    switch(Main.rand.Next(3))
                    {
                        default:
                            return "Are we winning?";
                        case 1:
                            return "[nickname], wanted to talk to me?";
                        case 2:
                            return "You are the best!";
                    }
                case ControlContext.GiveCompanionControl:
                    return "Okay. Then I will idle around here.";
                case ControlContext.TakeCompanionControl:
                    return "I return control to you.";
            }
            return base.ControlMessage(companion, context);
        }

        public override string UnlockAlertMessages(Companion companion, UnlockAlertMessageContext context)
        {
            switch(context)
            {
                case UnlockAlertMessageContext.MoveInUnlock:
                    return "";
                case UnlockAlertMessageContext.ControlUnlock:
                    return "I care so much for you, I don't want to see any harm come to you. If you need to do something dangerous, let me go do it instead.";
                case UnlockAlertMessageContext.FollowUnlock:
                    return "";
                case UnlockAlertMessageContext.MountUnlock:
                    return "Hey, let's play Dragon Fighter? Mount on my back so we can be like Knight and Steed!";
                case UnlockAlertMessageContext.RequestsUnlock:
                    return "";
                case UnlockAlertMessageContext.BuddiesModeUnlock:
                    return "Hey friend, uh... If you're fine about it... You can be my buddy! Just let me know if you want to pick me.";
                case UnlockAlertMessageContext.BuddiesModeBenefitsMessage:
                    return "Hey Newly-Buddy. I just wanted you to know that since we are buddies, I'll do anything you ask of me. I can even let you ride my back if you want. Do you like knowing that, buddy?";
            }
            return base.UnlockAlertMessages(companion, context);
        }

        public override string InteractionMessages(Companion companion, InteractionMessageContext context)
        {
            switch(context)
            {
                case InteractionMessageContext.OnAskForFavor:
                    return "What do you need of me?";
                case InteractionMessageContext.Accepts:
                    return "Yes! I can do that.";
                case InteractionMessageContext.Rejects:
                    return "Sorry... No...";
                case InteractionMessageContext.Nevermind:
                    return "Don't need anything anymore?";
            }
            return base.InteractionMessages(companion, context);
        }

        public override string ChangeLeaderMessage(Companion companion, ChangeLeaderContext context)
        {
            switch(context)
            {
                case ChangeLeaderContext.Success:
                    return "Yes, [nickname]!";
                case ChangeLeaderContext.Failed:
                    return "I will not..";
            }
            return "";
        }

        public override string BuddiesModeMessage(Companion companion, BuddiesModeContext context)
        {
            switch(context)
            {
                case BuddiesModeContext.AskIfPlayerIsSure:
                    return "Y-you want to pick me as your Buddy? Is that what you're saying?";
                case BuddiesModeContext.PlayerSaysYes:
                    return "Yes! I will be your buddy forever!";
                case BuddiesModeContext.PlayerSaysNo:
                    return "Aww... I thought it was true.";
                case BuddiesModeContext.NotFriendsEnough:
                    return "Sorry, but I don't know you well for that.";
                case BuddiesModeContext.Failed:
                    return "No...";
                case BuddiesModeContext.AlreadyHasBuddy:
                    return "But- But don't you have a Buddy already?";
            }
            return "";
        }

        public override string InviteMessages(Companion companion, InviteContext context)
        {
            switch(context)
            {
                case InviteContext.Success:
                    return "I'm coming.";
                case InviteContext.SuccessNotInTime:
                    return "I'll be there the next day.";
                case InviteContext.Failed:
                    return "I'm not going there right now..";
                case InviteContext.CancelInvite:
                    return "You don't want me visiting you anymore..? :()";
                case InviteContext.ArrivalMessage:
                    return "I'm here. Let's play!";
            }
            return "";
        }

        public override string GetOtherMessage(Companion companion, string Context)
        {
            switch(Context)
            {
                case MessageIDs.LeopoldEscapedMessage:
                    return "Why did he run away?";
                case MessageIDs.VladimirRecruitPlayerGetsHugged:
                    return "*Whine whine* I want some too...";
            }
            return base.GetOtherMessage(companion, Context);
        }

        public override string ReviveMessages(Companion companion, Player target, ReviveContext context)
        {
            switch(context)
            {
                case ReviveContext.HelpCallReceived:
                    return "I will help you!";
                case ReviveContext.RevivingMessage:
                    {
                        bool IsPlayer = !(target is Companion);
                        List<string> Mes = new List<string>();
                        if (IsPlayer && target == companion.Owner)
                        {
                            Mes.Add("No!! I wont lose you too!");
                            Mes.Add("Hang on buddy, I'll lick your wounds! Please don't die!");
                            Mes.Add("Don't die too! You are the only things for me in the world right now! I can't lose you like "+AlexRecruitmentScript.AlexOldPartner+"!");
                        }
                        else
                        {
                            Mes.Add("I'll help you!");
                            Mes.Add("I can take care of your wounds.");
                            Mes.Add("When you wake up, I will be here, buddy.");
                        }
                        return Mes[Main.rand.Next(Mes.Count)];
                    }
                case ReviveContext.OnComingForFallenAllyNearbyMessage:
                    return "Hang on buddy, I'll help you.";
                case ReviveContext.ReachedFallenAllyMessage:
                    return "I wont let them hurt you anymore.";
                case ReviveContext.RevivedByItself:
                    return "*Whine whine whine* You guys could have helped me...";
                case ReviveContext.ReviveWithOthersHelp:
                    if (Main.rand.NextFloat() < 0.5f)
                        return "Thank you, Buddy-Buddy!";
                    return "I've got the best pack ever!";
            }
            return base.ReviveMessages(companion, target, context);
        }
    }
}
