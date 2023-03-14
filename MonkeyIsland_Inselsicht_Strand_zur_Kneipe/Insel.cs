using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland_Inselsicht_Strand_zur_Kneipe {
    internal class Insel {
        private Kneipe kneipe = new Kneipe();
        private Strand strand = new Strand();
        // Spielfigur ParkPlatz
        private Spielfigur sfpp;

        public void SetKneipe(Kneipe kneipe) {
            this.kneipe = kneipe;
        }

        public Kneipe GetKneipe() {
            return this.kneipe; 
        }

        public void SetStrand(Strand strand) {
            this.strand = strand;
        }

        public Strand GetStrand() {
            return this.strand; 
        }

        public void SetSfpp(Spielfigur sfpp) {
            this.sfpp = sfpp;
        }

        public Spielfigur GetSfpp() {
            return this.sfpp;
        }
    }
}
