#if UNITY_EDITOR
using GameReady.Runtime;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace GameReady.Hybrid.Authoring
{
    public class PrimaryTargetAuthoring : MonoBehaviour
    {
        public GameObject setOnInit_s;

        private class PrimaryTargetBaker : Baker<PrimaryTargetAuthoring>
        {
            public override void Bake(PrimaryTargetAuthoring authoring)
            {
                var e = GetEntity(TransformUsageFlags.None);
                if (authoring.setOnInit_s != null)
                {
                    AddComponent(
                        e,
                        new PrimaryTarget()
                        {
                            target = GetEntity(authoring.setOnInit_s, TransformUsageFlags.WorldSpace),
                            hitPosition = authoring.setOnInit_s.transform.position,
                            angle = Vector3.Angle(authoring.transform.forward, math.normalize(authoring.setOnInit_s.transform.position - authoring.transform.position))
                        });
                }
                else
                {
                    AddComponent(
                        e,
                        new PrimaryTarget()
                        {

                        });
                }
            }
        }
    }

}

#endif