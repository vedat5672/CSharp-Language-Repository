using System.Collections;

namespace DesignPattern.Composite
{
    public class Employees : IEnumerable<IPerson>,IPerson
    {
        List<IPerson> _people=new List<IPerson>() ;

        public string Name { get ; set ; }

        public void Addpeople(IPerson person)
        {
            _people.Add(person);
        }
        public void Removepeople(IPerson person)
        {
            _people.Remove( person);
        } 
        public IPerson Getpeople(int index)
        {
            return _people[index];
        }
       
        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var item in _people)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
