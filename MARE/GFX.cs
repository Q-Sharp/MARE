using System;

namespace MARE
{
    [Serializable]
    public class GFX
    {
        public int No { get; private set; }

        public string Desc { get; set; }

        public int? KMD_EnableInternalLargePage { get; set; }

        public int? EnableCrossFireAutoLink { get; set; }

        public int? EnableUlps { get; set; }

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