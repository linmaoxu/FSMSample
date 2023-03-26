namespace RGY
{
    public class RGYContext
    {
        RGYRepo repo;
        public RGYRepo Repo => repo;

        public RGYContext(){
            repo = new RGYRepo();
        }
    }
}