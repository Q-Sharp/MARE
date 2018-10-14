using Microsoft.Win32;

namespace MARE
{
    public class MARERegistry : IRegistry
    {
        public IRegistryKey OpenSubKey(string sMainReg)
        {
            return new MARERegistryKey(Registry.LocalMachine.OpenSubKey(sMainReg));
        }
    }
}
