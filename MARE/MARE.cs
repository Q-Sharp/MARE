using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Security;
using System.Windows.Forms;

namespace MARE
{
    public class MARE
    {
        public class GFX : DataGridViewRow
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

        public BindingList<GFX> AllGFX { get; set; } = new BindingList<GFX>();

        private readonly string sMainReg = "SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}";

        public MARE()
        {

        }

        public void LoadReg()
        {
            AllGFX?.Clear();

            int i = 0;
            var sk = Registry.LocalMachine.OpenSubKey(sMainReg);
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

        public void SaveReg()
        {
            int i = 0;
            var sk = Registry.LocalMachine.OpenSubKey(sMainReg);
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