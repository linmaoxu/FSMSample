using UnityEngine;

namespace RGY
{
    public class RGYApp : MonoBehaviour
    {
        RGYContext context;
        RGYLightDomain lightDomain;
        RGYFSMDomain fsmDomain;
        RGYLightFactory lightFactory;

        public void Awake()
        {
            //Init
            context = new RGYContext();
            lightDomain = new RGYLightDomain();
            fsmDomain = new RGYFSMDomain();
            lightFactory = new RGYLightFactory();

            //Inject
            lightDomain.Inject(context, lightFactory);
            fsmDomain.Inject(context);

            //Execute
            lightDomain.SpawnLightUnique();
        }

        //Tick
        public void Update()
        {
            var light = context.Repo.Light;
            fsmDomain.Apply(light);
        }
    }
}