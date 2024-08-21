using System;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class AdsManager : MonoBehaviour
{
#if UNITY_ANDROID

    //private void Awake()
    //{
    //    Debug.Log("AdMob is Missing");
    //}

    private BannerView _bannerView;
    private InterstitialAd _interstitial;
    private RewardBasedVideoAd _rewardBasedVideoAd;

    public string DeviceID = "BBFF5C1D1E34C26B";

    public void Start()
    {
        string appId = "ca-app-pub-2609763721733837~2994240567";

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        // Get singleton reward based video ad reference.
        _rewardBasedVideoAd = RewardBasedVideoAd.Instance;

        RequestBanner();
        //RequestInterstitial();
    }

    private void RequestBanner()
    {
        string adUnitId = "ca-app-pub-2609763721733837/3732607165";

        // Create a 320x50 banner.
        //AdSize adSize = new AdSize(640, 50);
        _bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        //AdRequest request = new AdRequest.Builder().TagForChildDirectedTreatment(true).Build();
        //AdRequest request = new AdRequest.Builder().AddTestDevice(DeviceID).Build();     //used for test

        // Load the banner with the request.
        _bannerView.LoadAd(request);
    }

    /*
    private void RequestInterstitial()
    {
        string adUnitId = "ca-app-pub-2609763721733837/7568525371";

        // Initialize an InterstitialAd.
        _interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        //AdRequest request = new AdRequest.Builder().AddTestDevice(DeviceID).Build();
        //AdRequest request = new AdRequest.Builder().TagForChildDirectedTreatment(true).Build();

        // Load the interstitial with the request.
        _interstitial.LoadAd(request);
    }

    public void LoadBasicAd()
    {
        RequestInterstitial();
    }

    public void ShowBasicAd()
    {
        if (_interstitial.IsLoaded())
        {
            _interstitial.Show();
        }
    }

    private void RequestRewardBasedVideo()
    {
        string adUnitId = "ca-app-pub-2609763721733837/4343650136";

        _rewardBasedVideoAd.LoadAd(new AdRequest.Builder().Build(), adUnitId);
        //_rewardBasedVideoAd.LoadAd(new AdRequest.Builder().AddTestDevice(DeviceID).Build(), adUnitId);
        //_rewardBasedVideoAd.LoadAd(new AdRequest.Builder().TagForChildDirectedTreatment(true).Build(), adUnitId);

        // RewardBasedVideoAd is a singleton, so handlers should only be registered once.
        _rewardBasedVideoAd.OnAdLoaded += HandleRewardBasedVideoLoaded;
        _rewardBasedVideoAd.OnAdFailedToLoad += HandleRewardBasedVideoFailedToLoad;
        _rewardBasedVideoAd.OnAdOpening += HandleRewardBasedVideoOpened;
        _rewardBasedVideoAd.OnAdStarted += HandleRewardBasedVideoStarted;
        _rewardBasedVideoAd.OnAdRewarded += HandleRewardBasedVideoRewarded;
        _rewardBasedVideoAd.OnAdClosed += HandleRewardBasedVideoClosed;
        _rewardBasedVideoAd.OnAdLeavingApplication += HandleRewardBasedVideoLeftApplication;
    }

    public void LoadRewardAdButton()
    {
        RequestRewardBasedVideo();
    }

    public void ShowRewardAdButton()
    {
        ShowRewardBasedAd();
    }

    private void ShowRewardBasedAd()
    {
        if (_rewardBasedVideoAd.IsLoaded())
        {
            _rewardBasedVideoAd.Show();
        }
    }

    public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
    {
        print("HandleRewardBasedVideoLoaded event received");
    }

    public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        //try to reload
        print("HandleRewardBasedVideoFailedToLoad event received with message: " + args.Message);

    }

    public void HandleRewardBasedVideoOpened(object sender, EventArgs args)
    {
        //Pause the game
        print("HandleRewardBasedVideoOpened event received");
    }

    public void HandleRewardBasedVideoStarted(object sender, EventArgs args)
    {
        //Mute The game
        print("HandleRewardBasedVideoStarted event received");
    }

    public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
    {
        //Back to the game
        print("HandleRewardBasedVideoClosed event received");
    }

    public void HandleRewardBasedVideoRewarded(object sender, Reward args)
    {
        //reward the player
        //string type = args.Type;
        //double amount = args.Amount;
        //print("HandleRewardBasedVideoRewarded event received for " + amount.ToString() + " " + type);
    }

    public void HandleRewardBasedVideoLeftApplication(object sender, EventArgs args)
    {
        print("HandleRewardBasedVideoLeftApplication event received");
    }
*/
#endif
}