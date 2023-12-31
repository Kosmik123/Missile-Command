using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MissileCommand.UI
{
    public class UIController : MonoBehaviour
    {
        public static UIController Instance { get; private set; }

        [Header("Prefabs")]
        [SerializeField] 
        private GameObject cannonAmmoIndicator;

        [Header("To link")]
        [SerializeField] 
        private Canvas worldCanvas;

        [SerializeField] 
        private RectTransform results;

        [SerializeField] 
        private TMP_Text pointsIndicator;
        [SerializeField] 
        private TMP_Text highscoreIndicator;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void OnEnable()
        {
            PointsData.OnPointsChanged += RefreshPoints;
        }

        private void ShowResults()
        {
            
        }

        private void RefreshPoints(int points)
        {
            pointsIndicator.text = points.ToString();
        }

        public void InstantiateCannonAmmoIndicator(ShooterController shooterController)
        {
            var obj = Instantiate(cannonAmmoIndicator, worldCanvas.transform);
            obj.transform.position = shooterController.transform.position;

            var indicator = obj.GetComponent<AmmoIndicatorController>();
            indicator.Shooter = shooterController;
            indicator.Init();
        }

        private void RefreshHighscore(int highscore)
        {
            highscoreIndicator.text = highscore.ToString();
        }

        private void OnDisable()
        {
            PointsData.OnPointsChanged -= RefreshPoints;
        }

        private void OnDestroy()
        {
            if (Instance == this)
                Instance = null;
        }
    }
}
