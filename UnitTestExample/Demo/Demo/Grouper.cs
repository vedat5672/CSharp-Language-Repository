namespace Demo
{
    public class Grouper
    {
        private int _groupCount;

        public Grouper(int groupCount)
        {
          _groupCount = groupCount;
        }

        public List<List<Measurement>> Group(List<Measurement> measurements)
        {
            //Green
            var groups=new List<List<Measurement>>();
            for (int i = 0; i < measurements.Count; i+=_groupCount)
            {
                var group = measurements.Skip(i).Take(_groupCount).ToList();
                groups.Add(group);
            }
            return groups;
        }
    }
}