using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CrmManager
{
    public static class FormBrain
    {

        private static string _registryMainKey;

        public static object GetRegistryValue(string keyName, object defaultValue)
        {
            object res = null;
            try
            {
                var k = Registry.CurrentUser.OpenSubKey(_registryMainKey, true);
                if (k != null)
                {
                    res = k.GetValue(keyName, defaultValue);
                }
                else
                {
                    k = Registry.CurrentUser.CreateSubKey(_registryMainKey);
                }
                k?.Close();
            }
            catch
            {
                //PromptMsg(ex)
            }
            return res;
        }

        public static void SetRegistryValue(string keyName, object value)
        {
            try
            {
                var k = Registry.CurrentUser.OpenSubKey(_registryMainKey, true);
                if (k != null)
                {
                    k.SetValue(keyName, value);
                }
                else
                {
                    k = Registry.CurrentUser.CreateSubKey(_registryMainKey);
                    k.SetValue(keyName, value);
                }

                k?.Close();
            }
            catch
            {
                //PromptMsg(ex)
            }
        }

        public static void Remember(this Form form, Control control)
        {
            _registryMainKey = Assembly.GetAssembly(typeof(FormBrain)).GetName().Name;

            form.Load += (sender, args) =>
            {
                var savedValue = GetRegistryValue("Brain_" + control.Name, "") as string;

                if (!string.IsNullOrWhiteSpace(savedValue))
                {
                    control.Text = savedValue;
                }
            };

            form.FormClosing += (sender, args) =>
            {
                if (!string.IsNullOrWhiteSpace(control.Text))
                {
                    SetRegistryValue("Brain_" + control.Name, control.Text);
                }
            };
        }
    }
}
