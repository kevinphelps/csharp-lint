namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1516ElementsMustBeSeparatedByBlankLine : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.None;
            }
        }
    }
}
