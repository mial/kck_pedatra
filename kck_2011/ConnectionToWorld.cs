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
		private CsClient.MessageHandler message;
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
		
		public bool stepForward() {
			try {
				if ( api.StepForward() ) 
					return true;
				else 
					return false;
			}
			catch(System.InvalidOperationException ex) {
				Console.WriteLine("Padło połączenie");
			}
			return 0;
		}
		
		public bool rotateLeft() {
			try {
				if ( api.RotateLeft() ) 
					return true;
				else 
					return false;
			}
			catch (System.InvalidOperationException ex) {
				Console.WriteLine("Padło połączenie");
			}
			return 0;
		}
		
		public bool rotateRight() {
			try {
				if ( api.RotateRight() ) 
					return true;
				else 
					return false;
			}
			catch(System.InvalidOperationException ex) {
				Console.WriteLine("Padło połączenie");
			}
			return 0;
		}
		
		public bool recharge() {
			try {
				if ( api.Recharge() ) 
					return true;
				else 
					return false;
			}
			catch(System.InvalidOperationException ex) {
				Console.WriteLine("Padło połączenie");
			}
			return 0;
		}
		
		
	}
}
