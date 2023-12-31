using UnityEngine;

namespace MissileCommand
{
    public class PointsData : MonoBehaviour
    {
        public static event System.Action<int> OnPointsChanged;
        
        public static PointsData Instance { get; private set; }

        [SerializeField]
        private int points;

        [SerializeField]
        private int multiplier;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(Instance.gameObject);
        }

        public void ResetPoints()
        {
            ChangePoints(int.MinValue);
        }

        public void AddPoints(int pointsBase)
        {
            if (pointsBase < 0)
                return;

            ChangePoints(multiplier * pointsBase);
        }

        private void ChangePoints(int pointsChange)
        {
            points += pointsChange;
            points = Mathf.Max(points, 0);
            OnPointsChanged?.Invoke(points);
        }

        private void OnDestroy()
        {
            if (Instance == this)
                Instance = null;
        }
    }
}
