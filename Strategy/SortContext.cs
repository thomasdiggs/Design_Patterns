namespace Strategy
{
    internal class SortContext
    {
        private ISortStrategy _sortStrategy;

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Sort(List<int> list)
        {
            _sortStrategy.Sort(list);
        }
    }
}