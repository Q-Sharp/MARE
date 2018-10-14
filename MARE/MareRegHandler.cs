using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;

namespace MARE
{
    public class MareRegHandler
    {
        public virtual IList<GFX> AllGFX { get; set; } = new BindingList<GFX>();
        public IRegistry RegistryAccess { get; set; }
        public IMessageBox MessageBox { get; set; }
        private readonly string sMainReg = "SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}";

        public MareRegHandler(IRegistry RegistryAccess = null, IMessageBox MessageBox = null)
        {
            this.RegistryAccess = RegistryAccess ?? new MARERegistry();
            this.MessageBox = MessageBox ?? new MAREMessageBox();
        }

        public void LoadReg()
        {
            AllGFX?.Clear();

            int i = 0;
            var sk = RegistryAccess.OpenSubKey(sMainReg);
                
            var cfs = sk.GetSubKeyNames();

            foreach(var cf in cfs)
            {
                try
                {
                    int.Parse(cf);

                    var cr = sk.OpenSubKey(cf, false);
                    var a = cr.GetValue("KMD_EnableInternalLargePage", null) as int?;
                    var b = cr.GetValue("EnableCrossFireAutoLink", null) as int?;
                    var c = cr.GetValue("EnableUlps", null) as int?;
                    var d = cr.GetValue("DriverDesc", null) as string;

                    AllGFX.Add(new GFX(i, a, b, c, d));
                    i++;
                }
                catch(SecurityException)
                {
                    MessageBox.Show("This tool needs admin rights!");
                    break;
                }
                catch(Exception)
                {
                    continue;
                }
            }
        }

        public void Update(int No, string Desc, int? KMD_EnableInternalLargePage, int? EnableCrossFireAutoLink, int? EnableUlps)
        {
            var gfx = AllGFX.SingleOrDefault(x => x.No == No);

            if(gfx != null)
            {
                gfx.KMD_EnableInternalLargePage = KMD_EnableInternalLargePage;
                gfx.EnableCrossFireAutoLink = EnableCrossFireAutoLink;
                gfx.EnableUlps = EnableUlps;
            }
        }

        public void SaveReg()
        {
            int i = 0;
            var sk = RegistryAccess.OpenSubKey(sMainReg);
            var cfs = sk.GetSubKeyNames();

            foreach(var cf in cfs)
            {
                try
                {
                    int.Parse(cf);
                    var cr = sk.OpenSubKey(cf, true);

                    if(AllGFX[i].KMD_EnableInternalLargePage.HasValue)
                        cr.SetValue("KMD_EnableInternalLargePage", AllGFX[i].KMD_EnableInternalLargePage.ToString(), RegistryValueKind.DWord);

                    if(AllGFX[i].EnableCrossFireAutoLink.HasValue)
                        cr.SetValue("EnableCrossFireAutoLink", AllGFX[i].EnableCrossFireAutoLink.ToString(), RegistryValueKind.DWord);

                    if(AllGFX[i].EnableUlps.HasValue)
                        cr.SetValue("EnableUlps", AllGFX[i].EnableUlps.ToString(), RegistryValueKind.DWord);

                    i++;
                }
                catch(SecurityException)
                {
                    MessageBox.Show("This tool needs admin rights!");
                    break;
                }
                catch(Exception)
                {
                    continue;
                }
            }
        }
    }
}
