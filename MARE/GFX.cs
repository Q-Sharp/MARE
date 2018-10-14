using System;

namespace MARE
{
    [Serializable]
    public class GFX
    {
        public virtual int No { get; set; }

        public virtual string Desc { get; set; }

        public virtual int? KMD_EnableInternalLargePage { get; set; }

        public virtual int? EnableCrossFireAutoLink { get; set; }

        public virtual int? EnableUlps { get; set; }

        public GFX(int i, int? nKMD_EnableInternalLargePage, int? nEnableCrossFireAutoLink, int? nEnableUlps, string sDesc)
        {
            No = i;

            KMD_EnableInternalLargePage = nKMD_EnableInternalLargePage;
            EnableCrossFireAutoLink = nEnableCrossFireAutoLink;
            EnableUlps = nEnableUlps;
            Desc = sDesc;
        }
    }
}
