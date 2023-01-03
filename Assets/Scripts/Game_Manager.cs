using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] GameObject _pausePanel, _deathPanel;

    public float health = 3;
    public int numOffHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Start()
    {
        _pausePanel.SetActive(false);
        _deathPanel.SetActive(false);
    }
    void Update()
    {
        if (health > numOffHearts)
        {
            health = numOffHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOffHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if (health == 0)
        {   
            _deathPanel.SetActive(true);
        }       
    }
    public void PauseButton()
    {
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void FullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        Debug.Log("FULL SCREEN");
    }
    public void ContunieButton()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void TryAgainButton()
    {
        SceneManager.LoadScene("GameScene");
    }
   
}
    
