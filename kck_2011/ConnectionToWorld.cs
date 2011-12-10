using System;
using Data;

namespace kck_2011
{
	public class ConnectionToWorld
	{
		private string world;
		private string team;
		private string password;
		private string name;
		private CsClient.AgentAPI api;
		CsClient.MessageHandler message;
		private string ip;
		public ConnectionToWorld (string agentName)
		{
			name = agentName;
			world = "main";
			team = "PetadraPiatkowo";
			password = "karpfi";
			//message = new CsClient.MessageHandler();
			api = new CsClient.AgentAPI( message );
			ip = Settings.serverIP;
		}
		public bool connect( ref Data.Realm.WorldParameters data) {
			try {
				data = api.Connect(ip,6008,team,password,world,name);
			}
			catch (Exception ex) {
				Console.WriteLine("I can't connect to server.");
				return false;
			}
			return true; 
		}
	}
}
