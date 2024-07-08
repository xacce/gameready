using Unity.Entities;
using Unity.Mathematics;

namespace GameReady.Runtime
{
    public partial struct PrimaryTarget : IComponentData
    {
        public Entity target;
        public float3 targetPosition;
        public float3 hitPosition;
        public float angle;
        public bool hasTarget => !target.Equals(Entity.Null);
    }

    public partial struct Dead : IComponentData, IEnableableComponent
    {
        public float3 direction;
    }
}