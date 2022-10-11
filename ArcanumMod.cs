using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArcanumMod {
	public class ArcanumMod : Mod {
        public static string currentDate;
        public static int day;
        public static int month;
        public const string AssetPath = "ArcanumMod/Assets/";

        public static ArcanumMod Instance => ModContent.GetInstance<ArcanumMod>();
    }
}