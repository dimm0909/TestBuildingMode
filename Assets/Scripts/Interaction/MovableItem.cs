using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction
{
    public enum PlacingSurface
    {
        Floor = 0,
        Wall = 1
    }

    public class MovableItem : MonoBehaviour
    {
        [SerializeField] internal PlacingSurface surface;
        [SerializeField] internal Transform basicParent;

        private string[] possibleSurfaces = { "Floor", "Wall" };
    }
}