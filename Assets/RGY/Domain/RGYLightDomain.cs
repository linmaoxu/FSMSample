namespace RGY
{
    public class RGYLightDomain
    {
        RGYContext context;
        RGYLightFactory factory;

        public void Inject(RGYContext context, RGYLightFactory factory)
        {
            this.context = context;
            this.factory = factory;
        }

        public void SpawnLightUnique()
        {
            var light = factory.SpawnLight();
            context.Repo.SetCurrentLight(light);
        }
    }
}