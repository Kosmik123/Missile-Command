
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace MissileCommand
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private TMP_Text pointsIndicator;
        [SerializeField] private TMP_Text highscoreIndicator;

        private void OnEnable()
        {
            GameController.OnPointsChanged += RefreshPoints; 
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
            GameController.OnPointsChanged -= RefreshPoints; 
        }
    }
}
