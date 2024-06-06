namespace Composite;

internal class Composite : Component
{
    protected List<Component> _children = [];

    public override void Add(Component compoennt)
    {
        _children.Add(compoennt);
    }

    public override void Remove(Component component)
    {
        _children.Remove(component);
    }

    public override string Operation()
    {
        int i = 0;
        string result = "Branch(";

        foreach(Component component in _children)
        {
            result += component.Operation();
            if (i != _children.Count - 1)
            {
                result += "+";
            }
            i++;
        }

        return result + ")";
    }
}
