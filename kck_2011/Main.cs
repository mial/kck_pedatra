using System;

namespace kck_2011
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ConnectionToWorld server = new ConnectionToWorld( "Tomek" );
			Data.Realm.WorldParameters param = new Data.Realm.WorldParameters();
			server.connect(ref param);
			Console.WriteLine ("Hello World!");
		}
	}
}
