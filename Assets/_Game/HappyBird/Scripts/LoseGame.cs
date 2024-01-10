using UnityEngine;
using UnityEngine.UI;

namespace _App.HappyBird.Scripts
{
    public class LoseGame : MonoBehaviour
    {
        public Button continueBtn, retryButton;

        public GameObject optionObj;
        public Button add0Btn, add50Btn, add100Btn, add500Btn;

        // Start is called before the first frame update
        void Start()
        {
            continueBtn.onClick.AddListener(ShowUI);
            retryButton.onClick.AddListener(Retry);
            add0Btn.onClick.AddListener(() => ContinueWithPoint(0));
            add50Btn.onClick.AddListener(() => ContinueWithPoint(50));
            add100Btn.onClick.AddListener(() => ContinueWithPoint(100));
            add500Btn.onClick.AddListener(() => ContinueWithPoint(500));
        }

        private void Retry()
        {
            GameManager.Instance.Retry();
        }

        private void ContinueWithPoint(int point)
        {
            GameManager.addPoint = point;

            switch (point)
            {
            }
            
            GameManager.Instance.Retry();
        }

        private void ShowUI()
        {
            optionObj.SetActive(true);
        }
    }
}