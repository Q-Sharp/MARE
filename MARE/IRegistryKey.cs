using Microsoft.Win32;

namespace MARE
{
    public interface IRegistryKey
    {
        string[] GetSubKeyNames();

        IRegistryKey OpenSubKey(string RegKey, bool bWriteable);

        object GetValue(string Name, object DefaultValue);

        void SetValue(string Name, object Value, RegistryValueKind Kind);
    }
}