using MelonLoader;
using UnityEngine;
using Normal.Realtime;
using System.Collections;
namespace ModTag
{
    public static class BuildInfo
    {
        public const string Name = "ModTag"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Adds a \"Mod Tag\" to the player's name."; // Description for the Mod.  (Set as null if none)
        public const string Author = "BelugaTheAxolotl#2134"; // Author of the Mod.  (MUST BE SET)
        public const string Company = "BricksVR Modding"; // Company that made the Mod.  (Set as null if none)
        public const string Version = "0.1.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = "https://github.com/BricksVR-Modding/ModTag/releases"; // Download Link for the Mod.  (Set as null if none)
    }

    public class ApplyTag : MelonMod
    {
        public override void OnSceneWasLoaded(int buildindex, string sceneName)
        {
            var rt = GameObject.Find("MetaObjects/Realtime").GetComponent<Realtime>();
            MelonCoroutines.Start(connectionCheck(rt));
        }
        public override void OnUpdate()
        {
            if(Input.GetKeyDown("u"))
            {
                var settings = GameObject.Find("MetaObjects/UserSettings").GetComponent<UserSettings>();
                if (settings.Nickname.Contains("(MODDED)")) return;
                settings.Nickname = settings.Nickname+"\n(MODDED)";
            }
        }
        public IEnumerator connectionCheck(Realtime rt)
        {
            while(true)
            {
                if(rt.connected)
                {
                    var settings = GameObject.Find("MetaObjects/UserSettings").GetComponent<UserSettings>();
                    if (!settings.Nickname.Contains("(MODDED)")) settings.Nickname = settings.Nickname + "\n(MODDED)";
                }
                else
                {
                    var settings = GameObject.Find("MetaObjects/UserSettings").GetComponent<UserSettings>();
                    if (settings.Nickname.Contains("(MODDED)")) settings.Nickname = settings.Nickname.Replace("\n(MODDED)", "");

                }
                yield return new WaitForSeconds(1);
            }
        }
    }
}