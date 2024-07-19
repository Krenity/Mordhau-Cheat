using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MordhauCheat_2._0
{
    internal class Offsets
    {
        public Offsets() { }

        static Offsets() { }


        public const string GWorld = "Mordhau-Win64-Shipping.exe+0x58FFE00";

        // main
        public static string PlayerController = GWorld + ",180,38,0,30";
        public static string AGameStateBase = GWorld + ",120";
        public static string PlayerCameraManager = PlayerController + ",2B8";
        public static string APlayerState = PlayerController + ",228";
        public static string ACharacter = PlayerController + ",260";
        public static string Pawn = PlayerController + ",2A0";
        public static string UMordhauMotion = Pawn + ",B08";

        public static string CheckIfStab = ",B08,1108";
        public static string CheckIfSwing = ",B08,A94";
        public static string CheckIfFeint = ",C0,18";

        public static string AttackDelay = ",B08,E8";

        public static string ActiveParryWindow = UMordhauMotion + ",A68";
        public static string FeintWindow = UMordhauMotion + ",B74";
        public static string HitThroughWalls = UMordhauMotion + ",A46";

        public static string Player_Array = AGameStateBase + ",238";
        public static string PlayerSizeOffset = AGameStateBase + ",240";
        public static string CharacterMovement = Pawn + ",288";

        // visual

        public static string forcecoloroverride = Pawn + ",D8C";

        public static string folorteamA_R = GWorld + ",120" + ",6B8" + ",0";
        public static string folorteamA_G = GWorld + ",120" + ",6B8" + ",4";
        public static string folorteamA_B = GWorld + ",120" + ",6B8" + ",8";

        public static string folorteamB_R = GWorld + ",120" + ",6B8" + ",10";
        public static string folorteamB_G = GWorld + ",120" + ",6B8" + ",14";
        public static string folorteamB_B = GWorld + ",120" + ",6B8" + ",18";

        public static string DefaultFOV = PlayerCameraManager + ",238";
        public static string RealFOV = PlayerCameraManager + ",23C";
        public static string teamesp = AGameStateBase + ",558";
        public static string smokesmoothfield = Pawn + ",518";
        public static string smokesmooth = Pawn + ",51C";

        //movment

        public static string cam_pitch = PlayerController + ",250,F30";
        public static string cam_yaw =   PlayerController + ",250,F34";
        public static string cam_x =     PlayerController + ",250,F18";
        public static string cam_y =     PlayerController + ",250,F1C";
        public static string cam_z =     PlayerController + ",250,F20";

        public static string player_x = "288,250";
        public static string player_y = "288,254";
        public static string player_z = "288,258";

        public static string antiafk = ACharacter + " ,DE4";
        public static string NoSlowdownWhenChased = CharacterMovement + ",C49";
        public static string MinTimeChasing = CharacterMovement + ",CB4";

        //weapon
        public static string RightHandEquipment = Pawn + ",11F8";
        public static string LeftHandEquipment = Pawn + ",1200";

        // weapon modifications
        public static string StrikeWindup1 = RightHandEquipment + ",13F0";
        public static string StrikeWindup2 = RightHandEquipment + ",1518";
        public static string turncapx = Pawn + ",8C4";
        public static string turncapy = Pawn + ",8CC";

        //combat
        public static string MotionSystemComponenet = Pawn + ",688";

        public static string EasyParryDuration = ",F0" + ",494";
        public static string LastParryMotion = Pawn + ",F0" + ",688"  ;

        public static string LastAttackMotion = MotionSystemComponenet + ",108";
        public static string LastFeintMotion = MotionSystemComponenet + ",100";

        public static string ParryRecoveryTime = LastParryMotion + ",500";
        public static string RiposteWindowBase = LastParryMotion + ",4B4";
        public static string EndTime = LastAttackMotion + ",50";

        public static string haslastchance = Pawn + ",9F0";
        public static string wantsblock = Pawn + ",1029";
        public static string CanDodge = Pawn + ",E66";
        public static string DodgeDuration = Pawn + ",EA4";
        public static string DodgeCooldown = Pawn + ",EA8";
        public static string easyparry = Pawn + ",E94";

        public static string IgnoreTurnCap = Pawn + ",8D4";

        //ranged
        public static string RangedDrawTime = LeftHandEquipment + ",CEC";
        public static string RangedReleaseTime = LeftHandEquipment + ",CF4";
        public static string RangedReloadTime = LeftHandEquipment + ",D14";

        //playerstate
        public static string IsAlive = APlayerState + ",368";
        public static string AfkTimer = PlayerController + ",A28";
        public static string nextbox = PlayerController + ",CD1";
    }
}
