using JDS;
using Leopotam.Ecs;

namespace Client.Systems
{
    public static class EcsExt
    {
        public static EcsGameState Add<T>(this GSM<T> gsm, T name, EcsGameState ecsGameState, EcsWorld world)
        {
            ecsGameState.SetWorld(world);
            gsm.Add(name, ecsGameState);
            return ecsGameState;
        }
    }
}