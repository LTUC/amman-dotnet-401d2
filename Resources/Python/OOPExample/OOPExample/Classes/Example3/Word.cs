namespace OOPExample.Classes.Example3
{
    class Word : Document
    {
        public override string Show()
        {
            return"Show word contents";
        }

        public override string Hide()
        {
            return base.Hide() + " Except not really";
        }
    }
}
