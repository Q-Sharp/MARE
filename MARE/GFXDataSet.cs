namespace MARE
{
    partial class GFXDataSet
    {
        public virtual MareRegHandler Mare { get; set; } = new MareRegHandler();
       
        public void Load()
        {
            Mare?.LoadReg();

            GFXDataTable.BeginLoadData();

            foreach(var gfx in Mare.AllGFX)
                GFXDataTable.AddGFXDataTableRow(gfx.No, gfx.Desc, gfx.KMD_EnableInternalLargePage ?? 0, gfx.EnableCrossFireAutoLink ?? 0, gfx.EnableUlps ?? 0);

            GFXDataTable.EndLoadData();
        }

        public void Save()
        {
            foreach(var r in GFXDataTable)
                Mare.Update(r.No, r.Desc, r.KMD_EnableInternalLargePage, r.EnableCrossFireAutoLink, r.EnableUlps);

            Mare.SaveReg();
        }
    }
}
