namespace GangOfFour.Chain.Structural
{
	/// <summary>
	/// The 'Handler' abstract class
	/// </summary>
	internal abstract class Handler
	{
		protected Handler successor;

		public abstract void HandleRequest(int request);

		public void SetSuccessor(Handler successor)
		{
			this.successor = successor;
		}
	}
}