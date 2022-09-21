#region INTERMEDIATE_LOADING_AD_PANEL
[Title("LOADING_AD_PANEL")]

public GameObject LoadingAd_Panel;
public Text LoadingAd_PanelText;
public bool ShowLevelLoadingIntersitialAd = true;
public bool ShowIntermediateLoadingRectAd = true;

public IEnumerator ShowLoadingAd_Admob_With_Large_Banner_Level_Loading()
{
    if (ShowLevelLoadingIntersitialAd)
    {
        MadActionGamesAd.Instance.HideLargeAdmobBanner();
        LoadingAd_PanelText.text = "Loading Ad";
        LoadingAd_Panel.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
        MadActionGamesAd.Instance.ShowAdmobInterstitial();//LoadingAd Curtoutines
        yield return new WaitForSecondsRealtime(0.5f);
        LoadingAd_Panel.SetActive(false);
        if (ShowIntermediateLoadingRectAd)
        {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
        }
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(3);
    }

    else
    {
        LoadingAd_Panel.SetActive(false);
        if (ShowIntermediateLoadingRectAd)
        {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
        }
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(3);
    }

}
#endregion