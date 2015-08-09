﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GardenWarfare.Chat {
    class Commands {

        /*

        private static string s_HelpText =
            "Garden Conquest is a new, open source, Conquest-type mod. " +
            "It introduces ship classes and control points for " +
            "combat-focused servers.\n\n" +
            "If you're new to GC, check out the help subtopics below.\n\n" +
            "Chat Commands:\n" +
            "/gc help - Show this screen\n" +
            "/gc help [category] - Show help for a category:\n" +
            "        classes     - Ship Classes and their limits\n" +
            "        classifiers - Hull Classifier blocks\n" +
            "        cps            - Control Points\n" +
            "        licenses    - Ship License components\n" +
            "/gc fleet - Information on your fleet \n" +
            //"/gc fleet remove \"Ship Name\"- Disown a ship";
            "/gc violations - Your fleet's current rule violations, if any";

        private static string s_HelpClassesText;
        private static string s_HelpClassifiersText;
        private static string s_HelpCPsText;

        private static string s_HelpLicensesText =
            "Ship Licences are a new type of building component introduced by " +
            "Garden Conquest. You can acquire Ship Licences by holding " +
            "Control Points. \n\n" +
            "You use Ship Licenses to build Hull Classifier " +
            "blocks, which determine the class of your Ship/Station.\n\n" +
            "For more info, see:\n" +
            "    /gc help classifiers\n" +
            "    /gc help cps\n";




        private String helpClassifiersText() {
            if (s_HelpClassifiersText != null)
                return s_HelpClassifiersText;

            s_HelpClassifiersText =
                "Hull Classifiers are new blocks that each correspond to one " +
                "of the various classes.\n\n" +

                "Classifiers must be fully built and powered to designate your " +
                "ship as a member of its class.\n\n" +

                "Every Ship/Station must be classified, even the \"Unlicensed\" " +
                "ones. Unlicensed classifiers do not require Ship Licenses " +
                "to build, but they have relatively low block limits.\n\n" +

                "Unclassified ships are not allowed and will have some of their " +
                "blocks removed every " +
                Utility.General.prettySeconds(m_MailMan.ServerSettings.CleanupPeriod) + ", " +

                "For more info on Classes, type \"/gc help classes\"\n";

            return s_HelpClassifiersText;
        }

        private String helpClassesText() {
            if (s_HelpClassesText != null)
                return s_HelpClassesText;

            s_HelpClassesText = "";
            int blockTypesLength = m_MailMan.ServerSettings.BlockTypes.Length;
            List<String> allowedBlockTypes = new List<String>();
            List<String> disallowedBlockTypes = new List<String>();
            String name;
            int limit;

            foreach (Records.HullRuleSet hr in m_MailMan.ServerSettings.HullRules) {
                s_HelpClassesText +=
                    " --- " + hr.DisplayName + " --- \n" +
                    "CP Control Value:  " + hr.CaptureMultiplier + "\n" +
                    "Total allowed: " +
                    hr.MaxPerFaction + " per faction, " +
                    hr.MaxPerSoloPlayer + " for an individual.\n" +
                    "Max blocks: " + hr.MaxBlocks + "\n";

                allowedBlockTypes.Clear();
                disallowedBlockTypes.Clear();

                for (int i = 0; i < blockTypesLength; ++i) {
                    limit = hr.BlockTypeLimits[i];
                    name = m_MailMan.ServerSettings.BlockTypes[i].DisplayName;
                    if (limit < 0) {
                        allowedBlockTypes.Add("unlimited " + name);
                    }
                    else if (limit > 0) {
                        allowedBlockTypes.Add(limit + " " + name);
                    }
                    else {
                        disallowedBlockTypes.Add(name);
                    }
                }

                s_HelpClassesText +=
                    "Allowed: " + String.Join(", ", allowedBlockTypes) + "\n" +
                    "Denied: " + String.Join(", ", disallowedBlockTypes) + "\n\n";
            }

            // todo - get more info in here like the below
            // i.e.  ▲ StrikeCraft
            // += symbol, tier, name, license cost, max per faction
            // i.e. ▲ III Gunship - 55 L, 3 per faction
            // += grid size, block max
            // i.e. Large or Station, 500 blocks
            // foreach block limit
            // += num, category
            // i.e. 1 turret
            // 2 static weapons
            // 3 production

            return s_HelpClassesText;
        }

        private String helpCPsText() {
            if (s_HelpCPsText != null)
                return s_HelpCPsText;

            s_HelpCPsText =
                "Control Points are areas of the map you can hold and control. " +
                "Each CP has a Position, Radius, and Reward:\n\n";

            foreach (Records.ControlPoint cp in m_MailMan.ServerSettings.ControlPoints) {
                s_HelpCPsText += String.Format("{0} @ {1}, {2}, {3} Licenses\n",
                    cp.Name, cp.Position, Utility.General.prettyDistance(cp.Radius), cp.TokensPerPeriod);
            }

            s_HelpCPsText +=
                "\nWhomever controls a CP at the end of a round will receive its reward. " +
                "Rounds are calculated every " +
                Utility.General.prettySeconds(m_MailMan.ServerSettings.CPPeriod) + ".\n\n" +

                "In order to control the CP, your fleet must " +
                "have the most ships in that area that:\n" +
                "* have a powered, broadcasting Hull Classifier beacon\n" +
                "* have a broadcast range on the classifier at least as large " +
                " as the ship's distance to the CP. (This is to prevent players " +
                "from hiding while capturing a CP. If someone stands in the " +
                "center of a CP, they will see broadcasts from every " +
                "Conquesting ship.)\n\n" +

                "Bigger ships count more towards your total. In the event of a " +
                "tie, no one wins.\n\n" +

                "The winner of a round will receive the Licenses directly into " +
                "the first open inventory in their largest ship. If they have no " +
                "open inventory, they won't receive the Licenses.\n";

            return s_HelpCPsText;
        }

        */

    }
}
