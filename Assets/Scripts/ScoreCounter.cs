using UnityEngine.UI;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static int score = 0;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = score.ToString();
    }
}
