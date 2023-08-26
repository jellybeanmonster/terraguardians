using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using System.Collections.Generic;

namespace terraguardians.Companions
{
    public class LeonaDialogues : CompanionDialogueContainer
    {
        public override string GreetMessages(Companion companion)
        {
            switch (Main.rand.Next(3))
            {
                default:
                    return "*I guess I'll never get tired of seeing Terrarians. Hello, I'm Leona.*";
                case 1:
                    return "*Look at what I found here. The name's Leona. Need something killed?*";
                case 2:
                    return "*Oh, a friendly face! Happy to meet me? I'm Leona, Swordswoman.*";
            }
        }
        
        public override string NormalMessages(Companion companion)
        {
            List<string> Mes = new List<string>();
            bool LeonaHasSword = (companion as Leona.LeonaCompanion).HoldingSword;
            if (companion.IsUsingToilet)
            {
                if (LeonaHasSword)
                    Mes.Add("*You sure that you want to speak with me right now? Not only the smell isn't good, but I also have a long range sword.*");
                Mes.Add("*Couldn't you find a more improper moment to talk with me?*");
                Mes.Add("*I was having problems doing my business here, and you staring at me isn't helping either.*");
            }
            else
            {
                if (!Main.bloodMoon)
                {
                    Mes.Add("*Heeey shortie, came to check on me?*");
                    Mes.Add("*What is it? Someone bullying you? Tell me who and I will take care of them.*");
                    Mes.Add("*I was expecting to see you.*");
                    Mes.Add("*I'm not fat! This is just stocking for whenever I get no food for days. Wait, that's fat...*");
                    if (Main.dayTime)
                    {
                        if (Main.raining)
                        {
                            Mes.Add("*Mr Raindrop, falling away from me now...*");
                            Mes.Add("*Do you like rainy weather too? It make me kind of drowzy, but I'll survive.*");
                            Mes.Add("*Oh, look at you: Dripping. Need a towel? I don't have one.*");
                        }
                        else
                        {
                            Mes.Add("*My beautiful fur will only get beautier with sunlight help.*");
                            Mes.Add("*Are you here to get some tanning too? Great!*");
                            if (LeonaHasSword)
                                Mes.Add("*It's being quite hard to wield the sword. Its metal is getting hotter.*");
                        }
                    }
                    else
                    {
                        if (Main.raining)
                        {
                            Mes.Add("*I hope it keeps raining while I'm asleep.*");
                            Mes.Add("*What a nice surprise. Yes, we can chat for a while.*");
                        }
                        Mes.Add("*I can't wait for the moment of hitting the bed...*");
                        Mes.Add("*Oh, you came visit me. Could you be brief? I'm going to bed soon.*");
                        Mes.Add("*A nice meal and then I'm ready for bed.*");
                    }
                    if (LeonaHasSword)
                    {
                        Mes.Add("*This sword? It doesn't weight on me that much.*");
                        Mes.Add("*Are you trying to keep distance from me? Don't worry, I don't plan on using this on you.*");
                        Mes.Add("*Sadly, as a part of my old job, I got the habit of keeping my weapon ready all the time.*");
                    }
                    else
                    {
                        Mes.Add("*I feel defenseless without my sword. Oh, you shouldn't have heard that.*");
                        Mes.Add("*It's so odd to have so much freedom of movement with my right arm. What could I do with it..?*");
                        Mes.Add("*Where I stored my sword? Why do you want to know? You think you can lift it? Someday you'll have to let me see you lift it, haha.*");
                    }
                    if (CanTalkAboutCompanion(CompanionDB.Brutus))
                    {
                        Mes.Add("**");
                    }
                }
                else
                {
                    Mes.Add("*Back off! Now's not the time.*");
                    Mes.Add("*You're starting to buzz my patience. What do you want?*");
                    Mes.Add("*Grr... Couldn't you talk to me on a less horrible time?*");
                }
            }
            return Mes[Main.rand.Next(Mes.Count)];
        }

        public override string RequestMessages(Companion companion, RequestContext context)
        {
            switch(context)
            {
                case RequestContext.NoRequest:
                    return "";
                case RequestContext.HasRequest: //[objective] tag useable for listing objective
                    return "";
                case RequestContext.Completed:
                    return "";
                case RequestContext.Accepted:
                    return "";
                case RequestContext.TooManyRequests:
                    return "";
                case RequestContext.Rejected:
                    return "";
                case RequestContext.PostponeRequest:
                    return "";
                case RequestContext.Failed:
                    return "";
                case RequestContext.AskIfRequestIsCompleted:
                    return "";
                case RequestContext.RemindObjective: //[objective] tag useable for listing objective
                    return ""; 
                case RequestContext.CancelRequestAskIfSure:
                    return "";
                case RequestContext.CancelRequestYes:
                    return "";
                case RequestContext.CancelRequestNo:
                    return "";
            }
            return base.RequestMessages(companion, context);
        }

        public override string TalkMessages(Companion companion)
        {
            return "";
        }

        public override string AskCompanionToMoveInMessage(Companion companion, MoveInContext context)
        {
            switch(context)
            {
                case MoveInContext.Success:
                    return "";
                case MoveInContext.Fail:
                    return "";
                case MoveInContext.NotFriendsEnough:
                    return "";
            }
            return base.AskCompanionToMoveInMessage(companion, context);
        }

        public override string AskCompanionToMoveOutMessage(Companion companion, MoveOutContext context)
        {
            switch(context)
            {
                case MoveOutContext.Success:
                    return "";
                case MoveOutContext.Fail:
                    return "";
                case MoveOutContext.NoAuthorityTo:
                    return "";
            }
            return base.AskCompanionToMoveOutMessage(companion, context);
        }

        public override string JoinGroupMessages(Companion companion, JoinMessageContext context)
        {
            switch(context)
            {
                case JoinMessageContext.Success:
                    return "";
                case JoinMessageContext.Fail:
                    return "";
                case JoinMessageContext.FullParty:
                    return "";
            }
            return base.JoinGroupMessages(companion, context);
        }

        public override string LeaveGroupMessages(Companion companion, LeaveMessageContext context)
        {
            switch(context)
            {
                case LeaveMessageContext.Success:
                    return "";
                case LeaveMessageContext.Fail:
                    return "";
                case LeaveMessageContext.AskIfSure:
                    return "";
                case LeaveMessageContext.DangerousPlaceYesAnswer:
                    return "";
                case LeaveMessageContext.DangerousPlaceNoAnswer:
                    return "";
            }
            return base.LeaveGroupMessages(companion, context);
        }

        public override string MountCompanionMessage(Companion companion, MountCompanionContext context)
        {
            switch(context)
            {
                case MountCompanionContext.Success:
                    return "";
                case MountCompanionContext.SuccessMountedOnPlayer:
                    return "";
                case MountCompanionContext.Fail:
                    return "";
                case MountCompanionContext.NotFriendsEnough:
                    return "";
                case MountCompanionContext.SuccessCompanionMount:
                    return "";
                case MountCompanionContext.AskWhoToCarryMount:
                    return "";
            }
            return base.MountCompanionMessage(companion, context);
        }

        public override string DismountCompanionMessage(Companion companion, DismountCompanionContext context)
        {
            switch(context)
            {
                case DismountCompanionContext.SuccessMount:
                    return "";
                case DismountCompanionContext.SuccessMountOnPlayer:
                    return "";
                case DismountCompanionContext.Fail:
                    return "";
            }
            return base.DismountCompanionMessage(companion, context);
        }

        public override string OnToggleShareBedsMessage(Companion companion, bool Share)
        {
            if (Share)
                return "";
            return "";
        }

        public override string OnToggleShareChairMessage(Companion companion, bool Share)
        {
            if (Share)
                return "";
            return "";
        }

        public override string SleepingMessage(Companion companion, SleepingMessageContext context)
        {
            switch(context)
            {
                case SleepingMessageContext.WhenSleeping:
                    return "";
                case SleepingMessageContext.OnWokeUp:
                    return "";
                case SleepingMessageContext.OnWokeUpWithRequestActive:
                    return "";
            }
            return base.SleepingMessage(companion, context);
        }

        public override string TacticChangeMessage(Companion companion, TacticsChangeContext context)
        {
            switch(context)
            {
                case TacticsChangeContext.OnAskToChangeTactic:
                    return "";
                case TacticsChangeContext.ChangeToCloseRange:
                    return "";
                case TacticsChangeContext.ChangeToMidRanged:
                    return "";
                case TacticsChangeContext.ChangeToLongRanged:
                    return "";
                case TacticsChangeContext.Nevermind:
                    return "";
            }
            return base.TacticChangeMessage(companion, context);
        }

        public override string TalkAboutOtherTopicsMessage(Companion companion, TalkAboutOtherTopicsContext context)
        {
            switch(context)
            {
                case TalkAboutOtherTopicsContext.FirstTimeInThisDialogue:
                    return "";
                case TalkAboutOtherTopicsContext.AfterFirstTime:
                    return "";
                case TalkAboutOtherTopicsContext.Nevermind:
                    return "";
            }
            return base.TalkAboutOtherTopicsMessage(companion, context);
        }

        public override string ControlMessage(Companion companion, ControlContext context)
        {
            switch(context)
            {
                case ControlContext.SuccessTakeControl:
                    return "";
                case ControlContext.SuccessReleaseControl:
                    return "";
                case ControlContext.FailTakeControl:
                    return "";
                case ControlContext.FailReleaseControl:
                    return "";
                case ControlContext.NotFriendsEnough:
                    return "";
                case ControlContext.ControlChatter:
                    return "";
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
                    return "";
                case UnlockAlertMessageContext.FollowUnlock:
                    return "";
                case UnlockAlertMessageContext.MountUnlock:
                    return "";
                case UnlockAlertMessageContext.RequestsUnlock:
                    return "";
                case UnlockAlertMessageContext.BuddiesModeUnlock:
                    return "";
                case UnlockAlertMessageContext.BuddiesModeBenefitsMessage:
                    return "";
            }
            return base.UnlockAlertMessages(companion, context);
        }

        public override string InteractionMessages(Companion companion, InteractionMessageContext context)
        {
            switch(context)
            {
                case InteractionMessageContext.OnAskForFavor:
                    return "";
                case InteractionMessageContext.Accepts:
                    return "";
                case InteractionMessageContext.Rejects:
                    return "";
                case InteractionMessageContext.Nevermind:
                    return "";
            }
            return base.InteractionMessages(companion, context);
        }

        public override string ChangeLeaderMessage(Companion companion, ChangeLeaderContext context)
        {
            switch(context)
            {
                case ChangeLeaderContext.Success:
                    return "";
                case ChangeLeaderContext.Failed:
                    return "";
            }
            return "";
        }

        public override string BuddiesModeMessage(Companion companion, BuddiesModeContext context)
        {
            switch(context)
            {
                case BuddiesModeContext.AskIfPlayerIsSure:
                    return "";
                case BuddiesModeContext.PlayerSaysYes:
                    return "";
                case BuddiesModeContext.PlayerSaysNo:
                    return "";
                case BuddiesModeContext.NotFriendsEnough:
                    return "";
                case BuddiesModeContext.Failed:
                    return "";
                case BuddiesModeContext.AlreadyHasBuddy:
                    return "";
            }
            return "";
        }

        public override string InviteMessages(Companion companion, InviteContext context)
        {
            switch(context)
            {
                case InviteContext.Success:
                    return "";
                case InviteContext.SuccessNotInTime:
                    return "";
                case InviteContext.Failed:
                    return "";
                case InviteContext.CancelInvite:
                    return "";
                case InviteContext.ArrivalMessage:
                    return "";
            }
            return "";
        }

        public override string GetOtherMessage(Companion companion, string Context)
        {
            switch(Context)
            {
                case MessageIDs.LeopoldEscapedMessage:
                    return "";
                case MessageIDs.VladimirRecruitPlayerGetsHugged:
                    return "";
            }
            return base.GetOtherMessage(companion, Context);
        }

        public override string ReviveMessages(Companion companion, Player target, ReviveContext context)
        {
            switch(context)
            {
                case ReviveContext.HelpCallReceived:
                    return "";
                case ReviveContext.RevivingMessage:
                    {
                        return "";
                    }
                case ReviveContext.OnComingForFallenAllyNearbyMessage:
                    return "";
                case ReviveContext.ReachedFallenAllyMessage:
                    return "";
                case ReviveContext.RevivedByItself:
                    return "";
                case ReviveContext.ReviveWithOthersHelp:
                    return "";
            }
            return base.ReviveMessages(companion, target, context);
        }
    }
}