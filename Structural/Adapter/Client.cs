namespace Adapter
{
    public class Client
    {
        public BingMaps Mapper { get; private set; }

        public void SetMapper(BingMaps bingMaps)
        {
            this.Mapper = bingMaps;
        }
        //public void SetMapper()
        //{
        //    Factory f = new Factory();
        //    this.Mapper = f.getMapper();
        //}

        public string HaceAlgo()
        {
            return this.Mapper.GetMap(1, 2);
        }
    }
}
