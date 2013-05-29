using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace SquishIt.Framework
{
	public class Platform
	{
		public static bool Unix
        {
			get { return Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX; }
        }

		static bool versionChecked;
		static Version monoVersion;
		public static Version MonoVersion 
		{
			get 
			{
				if(!versionChecked)
				{
					var type = Type.GetType ("Mono.Runtime");
					if (type != null) 
					{
						var displayName = type.GetMethod ("GetDisplayName", BindingFlags.NonPublic | BindingFlags.Static);
						if(displayName != null)
						{
							var versionString = displayName.Invoke (null, null).ToString ();
							
							Console.WriteLine("**VERSION=" + versionString);
							var regex = new Regex(@"[0-9]+\.[0-9]+\.[0-9]+");

							var versionName = regex.Matches (versionString)[0].Value;
							Console.WriteLine("**VERSIONNAME=" + versionName);
							monoVersion = new Version(versionName);
							versionChecked = true;
						}
					}
				}
				return monoVersion;
			}
		}

		public static bool Mono 
		{
			get { return MonoVersion != null; }
		}
	}
	public class Version 
	{
		public Version (string versionName)
		{
			var numbers = versionName.Split('.');
			if (numbers.Length > 0) 
			{
				Major = int.Parse(numbers [0]);
			}
			if (numbers.Length > 1) 
			{
				Minor = int.Parse(numbers [1]);
			}
			if (numbers.Length > 2) 
			{
				Build = int.Parse(numbers[2]);
			}
		}
		public int Major { get; set; }
		public int Minor { get; set; }
		public int Build { get; set; }
	}
}

