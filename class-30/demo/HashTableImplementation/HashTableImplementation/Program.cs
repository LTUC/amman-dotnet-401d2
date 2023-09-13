namespace HashTableImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashMap hashMap = new HashMap(10);

            hashMap.Set("Ahmad", "Civil Engineer");
            hashMap.Set("Osama", "Mechanical Engineer");
            hashMap.Set("Zaid", "Doctor");
            hashMap.Set("Mohammad", "CS");
            hashMap.Set("Bashar", "CIS");
            hashMap.Set("Anas", "SE");
            hashMap.Set("Ala'a", "Math");
            hashMap.Set("Abdullah", "Chemistry");
            hashMap.Set("Yaman", "Physics");
            hashMap.Set("Said", "CS");

            hashMap.Print();
        }
    }
}