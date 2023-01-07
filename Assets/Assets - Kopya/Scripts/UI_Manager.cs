using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] GameObject _mainPannel, _settingsPanel;
    void Start()
    {
        _mainPannel.SetActive(true);
        _settingsPanel.SetActive(false);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("level1");
    }
    public void SettingsButton()
    {
        _mainPannel.SetActive(false);
        _settingsPanel.SetActive(true);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void BackButton()
    {
        _mainPannel.SetActive(true);
        _settingsPanel.SetActive(false);
    }
    public void FullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        Debug.Log("FULL SCREEN");
    }
}
