using DesignPatterns.AbstractFactory.Creator;

namespace DesignPatterns.AbstractFactory;

public class AbstractFactoryClient
{
    public static void Run()
    {
        IForm attributeForm = new AttributeForm("Attribute Form");
        var attributeFormCreator = new FormCreator(attributeForm);
        attributeFormCreator.Create();

        IForm multiSelectForm = new MultiSelectionForm("Multi Select Form");
        var multiSelectFormCreator = new FormCreator(multiSelectForm);
        multiSelectFormCreator.Create();
    }
}