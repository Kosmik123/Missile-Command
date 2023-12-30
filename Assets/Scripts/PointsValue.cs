using UnityEngine;

namespace MissileCommand {

    public class PointsValue : MonoBehaviour
    {
        [SerializeField]
        private int value;

        public void AddPoints()
        {
            Debug.Log("CO�tam");
            //GameManager.Instance.AddPoints(value);
        }
    }
}
