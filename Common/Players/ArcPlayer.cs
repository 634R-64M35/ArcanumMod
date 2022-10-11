using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArcanumMod.Common.Players {
	public class ArcPlayer : ModPlayer {
		public bool drillerPet;

		public override void Initialize() {
			ResetButton();
        }

        public override void ResetEffects() {
            ResetButton();
        }


        public override void UpdateDead() {
            ResetButton();
        }

        private void ResetButton() {
			drillerPet = false;
		}
	}
}