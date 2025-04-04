using Oxide.Core.Plugins;

namespace Oxide.Plugins
{
    [Info("AmmoStackPlugin", "Wiizzy(YOLO, YO!)", "1.2.1")]
    [Description("Increases item stack size")]

    public class AmmoStackPlugin : CovalencePlugin
    {
        private void OnServerInitialized()
        {
            // List of items by Shortname
            string[] ammoShortNames = {
                "ammo.grenadelauncher.buckshot",
                "ammo.grenadelauncher.he",
                "ammo.grenadelauncher.smoke",
                "ammo.handmade.shell",
                "ammo.nailgun.nails",
                "ammo.pistol",
                "ammo.pistol.fire",
                "ammo.pistol.hv",
                "ammo.rifle",
                "ammo.rifle.explosive",
                "ammo.rifle.hv",
                "ammo.rifle.incendiary",
                "ammo.rocket.basic",
                "ammo.rocket.fire",
                "ammo.rocket.hv",
                "ammo.rocket.sam",
                "ammo.rocket.smoke",
                "ammo.shotgun",
                "ammo.shotgun.fire",
                "ammo.shotgun.slug",
                "ammo.snowballgun",
                "arrow.bone",
                "arrow.fire",
                "arrow.hv",
                "arrow.wooden",
                "bandage",
                "barricade.concrete",
                "barricade.metal",
                "barricade.sandbags",
                "barricade.stone",
                "barricade.wood",
                "bearmeat",
                "bearmeat.cooked",
                "bed",
                "can.beans",
                "can.tuna",
                "coal",
                "corn",
                "deermeat.burned",
                "deermeat.cooked",
                "deermeat.raw",
                "diesel_barrel",
                "easter.bronzeegg",
                "easter.paintedeggs",
                "easter.silveregg",
                "explosives",
                "explosive.satchel",
                "explosive.timed",
                "gears",
                "glue",
                "grenade.f1",
                "gunpowder",
                "healingtea.pure",
                "horsemeat.raw",
                "hq.metal.ore",
                "maxhealthtea",
                "meat.boar",
                "meat.pork.cooked",
                "meat.pork.burned",
                "metalblade",
                "metalpipe",
                "metalspring",
                "mushroom",
                "oretea.advanced",
                "oretea.pure",
                "potato",
                "radiationresisttea",
                "radiationremovetea.pure",
                "radiationremovetea",
                "radiationresisttea.pure",
                "red.berry",
                "seed.black.berry",
                "seed.blue.berry",
                "seed.corn",
                "seed.green.berry",
                "seed.hemp",
                "seed.potato",
                "seed.pumpkin",
                "seed.red.berry",
                "seed.white.berry",
                "seed.yellow.berry",
                "sewingkit",
                "sheetmetal",
                "snowball",
                "stones",
                "white.berry",
                "wolfmeat.burned",
                "wolfmeat.cooked",
                "wolfmeat.raw",
                "wolfmeat.spoiled"
            };

            foreach (string shortName in ammoShortNames)
            {
                SetItemStackSize(shortName, 644);
            }

            // We output a message to the server console
            Puts("✅ AmmoStackPlugin loaded! Ammo stack size is now 644.");
        }

        /// <summary>
        /// Sets a new stack size for an item. Shortname
        /// </summary>
        /// <param name="shortName">Shortname предмета</param>
        /// <param name="stackSize">Размер стака</param>
        private void SetItemStackSize(string shortName, int stackSize)
        {
            var itemDef = ItemManager.FindItemDefinition(shortName);
            if (itemDef != null)
            {
                itemDef.stackable = stackSize;
                Puts($"✔ {shortName}: размер стака изменен на {stackSize}");
            }
            else
            {
                Puts($"⚠ Unable to find item: {shortName}");
            }
        }
    }
}
