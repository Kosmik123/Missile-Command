using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MissileCommand.UI
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private TMP_Text pointsIndicator;
        [SerializeField] private TMP_Text highscoreIndicator;

        private void OnEnable()
        {
            GameManager.OnPointsChanged += RefreshPoints; 
        }

        private void RefreshPoints(int points)
        {
            pointsIndicator.text = points.ToString();
        }

        private void RefreshHighscore(int highscore)
        {
            highscoreIndicator.text = highscore.ToString();
        }

        private void OnDisable()
        {
            GameManager.OnPointsChanged -= RefreshPoints; 
        }
    }
}
