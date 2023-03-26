using UnityEngine;

namespace RGY
{
    public class RGYFSMDomain
    {
        RGYContext context;

        public void Inject(RGYContext context)
        {
            this.context = context;
        }

        public void Apply(RGYLightEntity light)
        {
            var fsm = light.FSM;
            if (fsm.State == RGYState.RedLight)
            {
                Apply_RedLight(fsm);
            }
            else if (fsm.State == RGYState.YellowLight)
            {
                Apply_YellowLight(fsm);
            }
            else if (fsm.State == RGYState.GreenLight)
            {
                Apply_GreenLight(fsm);
            }
        }

        public void Apply_RedLight(RGYFSMCom fsm)
        {
            var state = fsm.RedLightState;
            if (state.isEnter)
            {
                state.isEnter = false;
                Debug.Log("Enter RedLight");
                return;
            }

            state.runtimeSec += Time.deltaTime;
            if (state.runtimeSec > state.maintainTimeSec)
            {
                fsm.SetGreenLight();
            }
        }

        public void Apply_GreenLight(RGYFSMCom fsm)
        {
            var state = fsm.GreenLightState;
            if (state.isEnter)
            {
                state.isEnter = false;
                Debug.Log("Enter GreenLight");
                return;
            }

            state.runtimeSec += Time.deltaTime;
            if (state.runtimeSec > state.maintainTimeSec)
            {
                fsm.SetYellowLight();
            }
        }

        public void Apply_YellowLight(RGYFSMCom fsm)
        {
            var state = fsm.YellowLightState;
            if (state.isEnter)
            {
                state.isEnter = false;
                Debug.Log("Enter YellowLight");
                return;
            }

            state.runtimeSec += Time.deltaTime;
            if (state.runtimeSec > state.maintainTimeSec)
            {
                fsm.SetRedLight();
            }
        }
    }
}