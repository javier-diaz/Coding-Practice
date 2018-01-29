namespace ch1_the_basics
{
	public class Firefighter : PublicServant, IPerson
	{
		// implement the IPerson interface
		public string Name { get; set; }
		public int Age { get; set; }

		private void GetInFiretruck ()
		{
		}

		private void TurnOnSiren ()
		{
		}

		private void FollowDirections ()
		{
		}

		public Firefighter ( string name, int age )
		{
			this.Name = name;
			this.Age = age;
		}

		public override void DriveToPlaceOfInterest ()
		{
			GetInFiretruck();
			TurnOnSiren();
			FollowDirections();
		}
	}
}

