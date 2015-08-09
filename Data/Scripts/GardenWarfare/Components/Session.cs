using System;
using System.Collections.Generic;
using System.Text;

using Sandbox.Common;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Definitions;
using Sandbox.ModAPI;
using VRage.Library.Utils;
using Interfaces = Sandbox.ModAPI.Interfaces;
using InGame = Sandbox.ModAPI.Ingame;

using SEGarden.Chat;
using SEGarden.Logging;
using Commands = SEGarden.Chat.Commands;
using SEGarden.Notifications;

namespace GardenWarfare.Components {

    /// <summary>
    /// LoadData, UnloadData, Update Before/After/Simulate, UpdatingStopped
    /// </summary>
	[Sandbox.Common.MySessionComponentDescriptor(Sandbox.Common.MyUpdateOrder.BeforeSimulation)]
	class Session : Sandbox.Common.MySessionComponentBase {

		//private Core_Base m_CoreProcessor = null;
        private static Logger Logger;
        private static Commands.Processor CommandProcesor;

        private int Frame;
        private AlertNotification testNotice;

        public override void LoadData() {
            base.LoadData();

            Logger = new Logger("GardenWarfare.Components", "Session");
            Logger.info("Starting", "Init");

            Frame = 0;

            testNotice = new AlertNotification() {
                Text = "Testing, testing, 1 2 3"
            };

            CommandProcesor = new Commands.Processor();
            //if (m_CoreProcessor == null)
            //	startCore();
        }

        protected override void UnloadData() {
            base.UnloadData();

            Logger.close();
            CommandProcesor.Dispose();

            //if (m_CoreProcessor != null)
            //	m_CoreProcessor.unloadData();
        }

        /*
		public override void Init(MyObjectBuilder_SessionComponent sessionComponent) {
			base.Init(sessionComponent);
		}
         * */

		public override void UpdateBeforeSimulation() {
			base.UpdateBeforeSimulation();

            Frame++;

            if (Frame % 100 == 0) {
                AlertNotification testNotice1 = new AlertNotification() {
                    Text = "Loaded? " + Loaded.ToString()
                };
                AlertNotification testNotice2 = new AlertNotification() {
                    Text = "Testing, testing, 1 2 3 - " + Frame + " test notice null? " + (testNotice == null).ToString()
                };
                AlertNotification testNotice3 = new AlertNotification() {
                    Text = "Logger null? " + (Logger == null).ToString()
                };

                testNotice1.Raise();

                testNotice2.Raise();

                testNotice3.Raise();
            }


			//if (m_CoreProcessor == null)
			//	startCore();

			//m_CoreProcessor.updateBeforeSimulation();
		}



        /*
		/// <summary>
		/// Starts up the proper core process depending on whether we are a client or server.
		/// </summary>
		private void startCore() {
			if (Utility.isServer()) {
				m_CoreProcessor = new Core_Server();
			} else {
				m_CoreProcessor = new Core_Client();
			}

			m_CoreProcessor.initialize();
		}
         * */
	}

}