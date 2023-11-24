namespace _2FAR_Gestion.classes
{
    public class Tache
    {
        public TP tpTache { get; set; }
        public int idTache { get; set; }
        public string descriptionTache { get; set; }
        public bool isCheckpoint { get; set; }
        public int ordreTache { get; set; }
        public double pointTache { get; set; }
        public int etatTache { get; set; }
        public bool isBonus { get; set; }
        public bool isActif { get; set; }



        public Tache(TP tptache, int idtache, string descriptiontache, bool ischeckpoint, int ordretache, int pointtache, int etattache, bool isbonus, bool isactif)
        {
            tpTache = tptache;
            tpTache.tacheList.Add(this);
            idTache = idtache;
            descriptionTache = descriptiontache;
            isCheckpoint = ischeckpoint;
            ordreTache = ordretache;
            pointTache = pointtache;
            etatTache = etattache;
            isBonus = isbonus;
            isActif = isactif;
        }
    }
}
