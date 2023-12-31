using UnityEngine;

namespace MissileCommand
{
    public class PointsValue : MonoBehaviour
    {
        [SerializeField]
        private int value;

        public void AddPoints()
        {
            PointsData.Instance.AddPoints(value);
        }
    }
}
