using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Template_Method
{
    public abstract class ScoringAlgorithm
    {
        public int  GenerateScore(int hits,TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOveralScore(score, reduction);
        }

        public abstract int CalculateOveralScore(int score, int reduction);
       

        public   abstract int CalculateReduction(TimeSpan time);

        public abstract int CalculateBaseScore(int hits);
      
    }
}
