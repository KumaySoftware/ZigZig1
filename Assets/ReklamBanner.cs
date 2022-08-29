using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;


public class ReklamBanner : MonoBehaviour
{
    private BannerView bannerView;                              // Banner Ad
    public InterstitialAd interstitial;                         // Interstitial Ad
    static int loadCount = 0;                                   // Interstitial Ad

    public void Awake()
    {
        MobileAds.Initialize(initStatus => { });                // Initializing Ad SDK
    }

    public void Start()
    {
        this.RequestBanner();                                   // Show Banner AD in the Start
        /*if (loadCount % 3 == 0)                                 // Interstitial Ad - only show ad every third death - Got this line from another stackoverflow question - so, is loadCount universal?
        {
            this.ShowInterstitial();
        }
        loadCount++;*/
    }

    public void RequestBanner()
    {
        string adUnitId = "ca-app-pub-7268447515840067/5920255251";
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();    // Create an empty ad request.
        this.bannerView.LoadAd(request);                        // Load the banner with the request.
    }

    /*public void RequestInterstitial()                                   // Interstitial Ad
    {
        string InterstitialAdID = "ca-app-pub-7268447515840067/3280231198";
        this.interstitial = new InterstitialAd(InterstitialAdID);       // Initialize an InterstitialAd.

        AdRequest request = new AdRequest.Builder().Build();            // Create an empty ad request.
        this.interstitial.LoadAd(request);                              // Load the interstitial with the request.
    }*//*
   public void ShowInterstitial()                                   // Interstitial Ad
    {
        if(this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }
    */
}