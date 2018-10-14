using Microsoft.Win32;

namespace MARE
{
    public class MARERegistryKey : IRegistryKey
    {
        private RegistryKey OrginalRegKey;

        public MARERegistryKey(RegistryKey OrginalRegKey)
        {
            this.OrginalRegKey = OrginalRegKey;
        }

        public string[] GetSubKeyNames()
        {
            return OrginalRegKey.GetSubKeyNames();
        }

        public object GetValue(string Name, object DefaultValue)
        {
            return OrginalRegKey.GetValue(Name, DefaultValue);
        }

        public IRegistryKey OpenSubKey(string RegKey, bool bWriteable)
        {
            return new MARERegistryKey(OrginalRegKey.OpenSubKey(RegKey, bWriteable));
        }

        public void SetValue(string Name, object Value, RegistryValueKind Kind)
        {
            OrginalRegKey.SetValue(Name, Value, Kind);
        }
    }
}