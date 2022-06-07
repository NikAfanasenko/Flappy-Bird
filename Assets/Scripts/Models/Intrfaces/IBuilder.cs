using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdGame
{
    public interface IBuilder
    {
        public void Reset(PilotScriptableObject pilot);
        public void Init();
        public void CreatePilot();
        public void CreatePilotView();
        public void Deconstruct(out IFlyable pilot, out PilotView pilotView);
        public IFlyable Result();
    }
}
