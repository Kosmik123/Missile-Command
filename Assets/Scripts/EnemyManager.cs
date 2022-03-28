using System.Collections;
using UnityEngine;


namespace MissileCommand
{
    public class EnemyManager : MonoBehaviour
    {
        public event System.Action OnRocketsEnded;

        [Header("Settings")]
        [Tooltip("Base for calculating overall missiles count that can be shot in a level")]
        [SerializeField] private int baseMissileCount;

        [Tooltip("Time between attack waves")]
        [SerializeField] private float attackInterval;
        
        [Tooltip("Maximum count of missiles that can be shot in one attack wave")]
        [SerializeField] private int maxMissileCount;
        
        [Tooltip("Height of rect in which missiles are spawned")]
        [SerializeField] private float generationAreaHeight;

        [Header("Properties")]
        [SerializeField] private Rect generationArea;
        [SerializeField] private Transform[] possibleTargets;
        [SerializeField] private int rocketsCount;


        [Header("States")]
        [SerializeField] private int remainingRockets;

        public IRectProvider rectProvider;

        private YieldInstruction wait;


        private void Start()
        {
            Rect gameplayRect = rectProvider.GetRect();
            generationArea = new Rect(new Vector2(gameplayRect.xMin, gameplayRect.yMax), new Vector2(gameplayRect.width, generationAreaHeight));

            wait = new WaitForSeconds(attackInterval);

            Restart();
        }

        public void Restart()
        {
            StartCoroutine(nameof(DropMissilesCo));
            remainingRockets = rocketsCount;
        }

        public void SetDifficulty(int difficulty)
        {
            rocketsCount = baseMissileCount + difficulty;
        }

        private void DropMissile()
        {
            Vector3 targetPosition = possibleTargets[UnityEngine.Random.Range(0, possibleTargets.Length)].position;
            Vector3 position = new Vector3(
                Random.Range(generationArea.xMin, generationArea.xMax),
                Random.Range(generationArea.yMin, generationArea.yMax));
            ProjectileInstantiator.InstantiateEnemyMissile(position, 1, targetPosition);
            rocketsCount--;
        }


        private IEnumerator DropMissilesCo()
        {
            while (rocketsCount > 0)
            {
                for (int i = 0; i < Random.Range(1, maxMissileCount); i++)
                    DropMissile();

                yield return wait;
            }

            OnRocketsEnded?.Invoke();
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            wait = new WaitForSeconds(attackInterval);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(generationArea.center, generationArea.size);
        }
#endif
    }
}
