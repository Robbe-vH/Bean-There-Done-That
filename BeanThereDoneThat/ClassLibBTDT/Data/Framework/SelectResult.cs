using System.Collections.Generic;

namespace ClassLibBTDT.Data.Framework
{
    public class SelectResult<T> : BaseResult
    {
        private List<T> results = new List<T>();

        public List<T> Results
        {
            get
            {
                return results;
            }
            set
            {
                foreach (T item in value)
                {
                    results.Add(item);
                }
            }
        }
    }
}