#region GAMEPLAY_LOADING_AD_PANEL
[Title("LOADING_AD_PANEL")]

public GameObject LoadingAd_Panel;
public Text LoadingAd_PanelText;
[Header("PAUSE")]
public bool ShowPauseAdInterstital = true;
public bool ShowPauseAdRect = true;

[Header("WIN")]
public bool ShowWinAdInterstital = true;
public bool ShowWinAdRect = true;

[Header("LOSE")]
public bool ShowLoseAdInterstital = true;
public bool ShowLoseAdRect = true;

[Header("RESTART")]
public bool ShowRestartAdInterstital = false;
public bool ShowRestartAdRect = false;
public bool HideLargeBannerBeforeRestarting = true;

[Header("HOME")]
public bool ShowHomeAdInterstital = false;
public bool ShowHomeAdRect = true;

[Header("NEXT")]
public bool ShowNextAdInterstital = false;
public bool ShowNextAdRect = true;

public IEnumerator ShowLoadingAd_Admob_With_Large_Banner_Restart()
{
    /*Enable Gameplay Loading Panel from Where You Will Call this couroutines*/
    loadingPanel.SetActive(true);
    /*Enable Gameplay Loading Panel from Where You Will Call this couroutines*/
    if (ShowRestartAdInterstital)
    {
        if (HideLargeBannerBeforeRestarting)
        {
            yield return new WaitForSecondsRealtime(3.5f);
            MadActionGamesAd.Instance.HideLargeAdmobBanner();
            yield return new WaitForSecondsRealtime(0.5f);
            SceneManager.LoadScene(3);

        }
        else
        {
            yield return new WaitForSecondsRealtime(4f);
            SceneManager.LoadScene(3);


        }

    }
    else
    {
        if (HideLargeBannerBeforeRestarting)
        {
            yield return new WaitForSecondsRealtime(3.5f);
            MadActionGamesAd.Instance.HideLargeAdmobBanner();
            yield return new WaitForSecondsRealtime(0.5f);
            SceneManager.LoadScene(3);
        }
        else
        {
            yield return new WaitForSecondsRealtime(4f);
            SceneManager.LoadScene(3);

        }
       
    }

}

public IEnumerator ShowLoadingAd_Admob_With_Large_Banner_Next()
{
    /*Enable Gameplay Loading Panel from Where You Will Call this couroutines*/
    loadingPanel.SetActive(true);
    /*Enable Gameplay Loading Panel from Where You Will Call this couroutines*/
    if (ShowNextAdInterstital)
    {
        yield return new WaitForSecondsRealtime(3.0f);
        if (levelNumber > 4)
        {
            if (levelNumber % 2 == 1)
            {
                LoadingAd_PanelText.text = "Loading Ad";
                LoadingAd_Panel.SetActive(true);
                MadActionGamesAd.Instance.HideLargeAdmobBanner();
            }
        }

        yield return new WaitForSecondsRealtime(2.0f);

        if (levelNumber > 4)
        {
            if (levelNumber % 2 == 1)
            {
                MadActionGamesAd.Instance.ShowAdmobInterstitial();//LoadingAd Curtoutines
            }
        }

        LoadingAd_Panel.SetActive(false);
        if (ShowNextAdRect)
        {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
        }
        yield return new WaitForSecondsRealtime(5f);
        winPanel.SetActive(false);
        SceneManager.LoadScene(3);
    }
    else
    {

        if (ShowNextAdRect)
        {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
        }
        yield return new WaitForSecondsRealtime(5f);
        winPanel.SetActive(false);
        SceneManager.LoadScene(3);

    }
}

public IEnumerator ShowLoadingAd_Admob_With_Large_Banner_Home()
{
    /*Enable Gameplay Loading Panel from Where You Will Call this couroutines*/
    loadingPanel.SetActive(true);
    /*Enable Gameplay Loading Panel from Where You Will Call this couroutines*/

    if (ShowHomeAdInterstital)
    {

        yield return new WaitForSecondsRealtime(3.0f);
        LoadingAd_PanelText.text = "Loading Ad";
        LoadingAd_Panel.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
        MadActionGamesAd.Instance.ShowAdmobInterstitial();//LoadingAd Curtoutines
        yield return new WaitForSecondsRealtime(0.5f);
        loadingPanel.SetActive(true);
        LoadingAd_Panel.SetActive(false);
        winPanel.SetActive(false);
        pausePanel.SetActive(false);
        losePanel.SetActive(false);
        if (ShowHomeAdRect)
        {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
        }

        yield return new WaitForSecondsRealtime(6f);

        SceneManager.LoadScene(1);
    }
    else
    {
        pausePanel.SetActive(false);
        winPanel.SetActive(false);
        pausePanel.SetActive(false);
        losePanel.SetActive(false);
        loadingPanel.SetActive(true);
        LoadingAd_Panel.SetActive(false);
        winPanel.SetActive(false);
        pausePanel.SetActive(false);
        losePanel.SetActive(false);
        if (ShowHomeAdRect)
        {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
        }
        yield return new WaitForSecondsRealtime(6f);

        SceneManager.LoadScene(1);
    }


}


public IEnumerator ShowLoadingAd_Admob_With_Large_Banner_Pause()
{
    if (ShowPauseAdInterstital)
    {
        MadActionGamesAd.Instance.HideSmallBanner();
        //MadActionGamesAd.Instance.HideLargeAdmobBanner();
        LoadingAd_PanelText.text = "Loading Ad";
        LoadingAd_Panel.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
        MadActionGamesAd.Instance.Admob_Unity();//LoadingAd Curtoutines
        yield return new WaitForSecondsRealtime(0.5f);
        LoadingAd_Panel.SetActive(false);
        if (ShowPauseAdRect)
        {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
        }
    }
    else
    {
        if (ShowPauseAdRect)
        {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
        }
    }


}

public IEnumerator ShowLoadingAd_Admob_With_Large_Banner_Clear()
{
    if (ShowWinAdInterstital)
    {
        MadActionGamesAd.Instance.HideSmallBanner();
        LoadingAd_PanelText.text = "Loading Ad";
        LoadingAd_Panel.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
        MadActionGamesAd.Instance.Admob_Unity();//LoadingAd Curtoutines
        yield return new WaitForSecondsRealtime(0.5f);
        LoadingAd_Panel.SetActive(false);

        /*Enable Clear Panel Here*/
        winPanel.SetActive(true);
        /*Enable Clear Panel Here*/

        if (ShowWinAdInterstital)
        {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
        }

    }
    else
    {
        if (ShowWinAdInterstital)
        {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
        }
    }

}

public IEnumerator ShowLoadingAd_Admob_With_Large_Banner_Failed()
{
    if (ShowLoseAdInterstital)
    {
        MadActionGamesAd.Instance.HideSmallBanner();
        LoadingAd_PanelText.text = "Loading Ad";
        LoadingAd_Panel.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
        MadActionGamesAd.Instance.Admob_Unity();//LoadingAd Curtoutines
        yield return new WaitForSecondsRealtime(0.5f);
        LoadingAd_Panel.SetActive(false);

        /*Enable Fail Panel Here*/
        losePanel.SetActive(true);
        /*Enable Fail Panel Here*/

        if (ShowLoseAdRect)
        {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
        }
    }
    else
    {
        if (ShowLoseAdRect)
        {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
        }
    }



}

#endregion