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
        private const string GWorld = "Mordhau-Win64-Shipping.exe+0x58FCB80";

        // main
        public static string PlayerController = GWorld + ",180,38,0,30";
        public static string AGameStateBase = GWorld + ",120";
        public static string PlayerCameraManager = PlayerController + ",2B8";
        public static string APlayerState = PlayerController + ",228";
        public static string ACharacter = PlayerController + ",260";

        public static string Pawn = PlayerController + ",2A0";
        public static string Player_Array = AGameStateBase + ",238";
        public static string CharacterMovement = Pawn + ",288";

        // visual
        public static string DefaultFOV = PlayerCameraManager + ",238";
        public static string RealFOV = PlayerCameraManager + ",23C";
        public static string teamesp = AGameStateBase + ",558";
        public static string smokesmoothfield = Pawn + ",518";
        public static string smokesmooth = Pawn + ",51C";

        //movment
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
        public static string haslastchance = Pawn + ",9F0";
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
