   #region LOADING_AD_PANEL
    [Title("LOADING_AD_PANEL")]

    public GameObject LoadingAd_Panel;
    public Text LoadingAd_PanelText;

    [Header("QUIT")]
    public bool ShowQuitAdInterstital=true;
    public bool ShowQuitAdRect=true;

    [Header("CROSS SETTINGS")]
    public bool ShowCrossSettingAdInterstital=false;

    [Header("PLAY")]
    public bool ShowPlayAdInterstital=true;

    [Header("WEAPON")]
    public bool ShowWeaponsAdInterstital=true;
  
    public IEnumerator ShowLoadingAd_Admob_With_Large_Banner_Quit()
    {
        if (ShowQuitAdInterstital)
        {
            MadActionGamesAd.Instance.HideSmallBanner();
            LoadingAd_PanelText.text = "Loading Ad";
            LoadingAd_Panel.SetActive(true);
            yield return new WaitForSecondsRealtime(1.0f);
            MadActionGamesAd.Instance.Show_Unity();//LoadingAd Curtoutines
            yield return new WaitForSecondsRealtime(0.5f);
            LoadingAd_Panel.SetActive(false);
            if (ShowQuitAdRect)
            {
            MadActionGamesAd.Instance.ShowLargeAdmobBanner();
            }
        }
        else
        {
            if (ShowQuitAdRect)
            {
                MadActionGamesAd.Instance.ShowLargeAdmobBanner();
            }
        }

    }
    public IEnumerator ShowLoadingAd_Admob_Without_Large_Banner_Play()
    {
        if (ShowPlayAdInterstital)
        {
            LoadingAd_PanelText.text = "Loading Ad";
            LoadingAd_Panel.SetActive(true);
            yield return new WaitForSecondsRealtime(2.0f);
            MadActionGamesAd.Instance.ShowAdmobInterstitial();//LoadingAd Curtoutines
            yield return new WaitForSecondsRealtime(0.5f);
            LoadingAd_Panel.SetActive(false);
        }
        else
        {

        }
     
    }
    public IEnumerator ShowLoadingAd_Admob_Without_Large_Banner_Weapon_or_Garage()
    {
        if (ShowWeaponsAdInterstital)
        {
            LoadingAd_PanelText.text = "Loading Ad";
            LoadingAd_Panel.SetActive(true);
            yield return new WaitForSecondsRealtime(2.0f);
            MadActionGamesAd.Instance.ShowAdmobInterstitial();//LoadingAd Curtoutines
            yield return new WaitForSecondsRealtime(0.5f);
            LoadingAd_Panel.SetActive(false);
        }
        else
        {

        }
    }
    public IEnumerator ShowLoadingAd_Admob_Without_Large_Banner_Cross_Setting()
    {
        if (ShowCrossSettingAdInterstital)
        {
            MadActionGamesAd.Instance.HideLargeAdmobBanner();
            LoadingAd_PanelText.text = "Loading Ad";
            LoadingAd_Panel.SetActive(true);
            yield return new WaitForSecondsRealtime(2.0f);
            MadActionGamesAd.Instance.ShowAdmobInterstitial();//LoadingAd Curtoutines
            yield return new WaitForSecondsRealtime(0.5f);
            MadActionGamesAd.Instance.HideLargeAdmobBanner();
            LoadingAd_Panel.SetActive(false);
        }
        else
        {
        }
    }
    
    #endregion
