namespace RGY
{
    public class RGYRepo
    {
        RGYLightEntity light;
        public RGYLightEntity Light => light;
        public void SetCurrentLight(RGYLightEntity light)
        {
            this.light = light;
        }
    }
}