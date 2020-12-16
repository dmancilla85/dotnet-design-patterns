namespace GangOfFour.Chain.RealWorld
{
	/// <summary>
	/// The 'Handler' abstract class
	/// </summary>
	internal abstract class Approver

	{
		protected Approver successor;

		public abstract void ProcessRequest(Purchase purchase);

		public void SetSuccessor(Approver successor)
		{
			this.successor = successor;
		}
	}
}