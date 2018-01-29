namespace ch1_the_basics_advanced
{
	public abstract class PublicServant
	{
		public int PensionAmount { get; set; }
        // public abstract void DriveToPlaceOfInterest();
        public delegate void DriveToPlaceOfInterestDelegate();
        public DriveToPlaceOfInterestDelegate DriveToPlaceOfInterest { get; set; }
    }
}

