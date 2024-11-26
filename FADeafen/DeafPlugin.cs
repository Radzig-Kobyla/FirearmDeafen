using BepInEx;
using UnityEngine;
using BepInEx.Logging;

namespace FADeafen
{
    [BepInPlugin("com.kobrakon.gunshotdeaf", "GunShotDeafen", "1.2.0")]
    public class Plugin : BaseUnityPlugin
    {
        internal static ManualLogSource logger;

        void Awake()
        { 
            logger = Logger;
            new OuchiePatch().Enable();
            new OuchieGrenadePatch().Enable();
        }
    }
}