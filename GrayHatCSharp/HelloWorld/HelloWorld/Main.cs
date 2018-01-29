using System;

namespace HelloWorld
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Class variable declarations
			string hello = "Hello ";
			DateTime now = DateTime.Now;

			// Class actions
			if ( args.Length > 0 ) 
			{
				Console.Write( hello + args [0] + "!" );

			} 
			else
			{
				Console.Write( "Hello World!" );
			}

			Console.WriteLine( " The date is " + now.ToLongDateString() );

		} // end of Main()

	} // end of MainClass

} // end of namespace HelloWorld
