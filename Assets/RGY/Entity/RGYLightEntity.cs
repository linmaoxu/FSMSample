namespace RGY
{
    public class RGYLightEntity
    {
        RGYFSMCom fsm;
        public RGYFSMCom FSM => fsm;

        public RGYLightEntity(){
            fsm = new RGYFSMCom();
        }
    }
}