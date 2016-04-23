namespace VisitorPattern
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    internal interface IVisitor
    {
        void Visit(Element element);
    }
}