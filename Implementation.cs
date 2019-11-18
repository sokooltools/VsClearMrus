using System;
using System.Linq;
using Microsoft.Win32;

namespace SokoolTools.VsClearMrus
{
	public static class Implementation
	{
		private const string REGISTRYLOC = @"SOFTWARE\Microsoft\VisualStudio\";

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Clears all the MRUs.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		public static void ClearAllMrus()
		{
			var versions = new[] { "8.0", "9.0", "10.0", "12.0", "14.0" };  // , "15.0", "16.0"
			foreach (string ver in versions)
			{
				ClearMRU(REGISTRYLOC + ver + "\\FileMRUList", "File");
				ClearMRU(REGISTRYLOC + ver + "\\ProjectMRUList", "File");
				ClearMRU(REGISTRYLOC + ver + "\\Find", "Command");
				ClearMRU(REGISTRYLOC + ver + "\\Find", "Find");
				ClearMRU(REGISTRYLOC + ver + "\\Find", "Replace");
				ClearMRU(REGISTRYLOC + ver + "\\WebBrowser\\MRU", "");
				ClearMRU(REGISTRYLOC + ver + "\\EnterpriseTools\\QualityTools\\RecentCompletedResults", "");

				ClearMRU(REGISTRYLOC + ver + "\\MRUItems\\{01235aad-8f1b-429f-9d02-61a0101ea275}\\Items", "");
				ClearMRU(REGISTRYLOC + ver + "\\MRUItems\\{a9c4a31f-f9cb-47a9-abc0-49ce82d0b3ac}\\Items", "");
			}

			// TODO: Implement for Visual Studio versions "15.0", "16.0" 
			// Need to access their values stored in private registry!
			// %AppData%\..\Local\Microsoft\VisualStudio\15.0_dc61f966\privateregistry.bin
			// %AppData%\..\Local\Microsoft\VisualStudio\16.0_6e759407\privateregistry.bin

		}

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Deletes all values in the HKEY_CURRENT_USER hive in the registry corresponding to the specified subkey having a value 
		/// name starting with the specified name.
		/// </summary>
		/// <param name="subKeyName">The name of the subkey.</param>
		/// <param name="valueNameStartsWith">The name the associated value starts with.</param>
		//------------------------------------------------------------------------------------------------------------------------
		private static void ClearMRU(string subKeyName, string valueNameStartsWith)
		{
			using (RegistryKey mruList = Registry.CurrentUser.OpenSubKey(subKeyName, true))
			{
				if (mruList == null)
					return;
				try
				{
					foreach (string valueName in mruList.GetValueNames().Where(m => m.StartsWith(valueNameStartsWith)))
						mruList.DeleteValue(valueName);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
	}
}
