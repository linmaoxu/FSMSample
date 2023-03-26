namespace RGY
{
    public class RGYFSMCom
    {
        RGYState state;
        public RGYState State => state;
        RGYGreenLightState greenLightState;
        public RGYGreenLightState GreenLightState => greenLightState;
        RGYRedLightState redLightState;
        public RGYRedLightState RedLightState => redLightState;
        RGYYellowLightState yellowLightState;
        public RGYYellowLightState YellowLightState => yellowLightState;

        public RGYFSMCom()
        {
            greenLightState = new RGYGreenLightState();
            redLightState = new RGYRedLightState();
            yellowLightState = new RGYYellowLightState();
            SetLightState(RGYState.RedLight);
        }

        public void SetLightState(RGYState state)
        {
            if (state == RGYState.RedLight)
            {
                SetRedLight();
            }
            else if (state == RGYState.YellowLight)
            {
                SetYellowLight();
            }
            else if (state == RGYState.GreenLight)
            {
                SetGreenLight();
            }
        }

        public void SetRedLight()
        {
            state = RGYState.RedLight;
            redLightState.isEnter = true;
            redLightState.maintainTimeSec = 1;
            redLightState.runtimeSec = 0;
        }

        public void SetGreenLight()
        {
            state = RGYState.GreenLight;
            greenLightState.isEnter = true;
            greenLightState.maintainTimeSec = 1;
            greenLightState.runtimeSec = 0;
        }

        public void SetYellowLight()
        {
            state = RGYState.YellowLight;
            yellowLightState.isEnter = true;
            yellowLightState.maintainTimeSec = 1;
            yellowLightState.runtimeSec = 0;
        }

    }
}