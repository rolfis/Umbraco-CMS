namespace Umbraco.Core.Models.ContentVariations
{
    public class ChildVariant : IDeepCloneable
    {
        public ChildVariant(string key, int childId, bool isTrashed)
        {
            Key = key;
            ChildId = childId;
            IsTrashed = isTrashed;
        }

        public string Key { get; private set; }
        public int ChildId { get; private set; }
        public bool IsTrashed { get; private set; }
        
        public object DeepClone()
        {
            return MemberwiseClone();
        }
    }
}