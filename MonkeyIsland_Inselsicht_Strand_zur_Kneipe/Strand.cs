﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland_Inselsicht_Strand_zur_Kneipe {
    internal class Strand {
        private Spielfigur sfpp;

        public void SetSfpp(Spielfigur sfpp) {
            this.sfpp = sfpp;
        }

        public Spielfigur GetSfpp() {
            return this.sfpp;
        }
    }
}
