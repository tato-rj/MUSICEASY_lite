using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class AdsManager : MonoBehaviour {

	public static AdsManager instance;
	public string bannerID;
	public string videoID;
	InterstitialAd interstitial;

	void Awake () {

		if (instance != null && instance != this) {
			Destroy (this.gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}

	}

	public void RequestBanner () {

		AdRequest request = new AdRequest.Builder().Build();

		BannerView bannerAd = new BannerView(bannerID, AdSize.SmartBanner, AdPosition.Bottom);
		bannerAd.LoadAd(request);


	}

	public void RequestInterstitialAds() {

		interstitial = new InterstitialAd(videoID);

		AdRequest request = new AdRequest.Builder().Build();

		//Register Ad Close Event
		interstitial.OnAdClosed += Interstitial_OnAdClosed;

		// Load the interstitial with the request.
		interstitial.LoadAd(request);

		Debug.Log("AD LOADED XXX");

	}

	//Ad Close Event
	private void Interstitial_OnAdClosed(object sender, System.EventArgs e)
	{
		//Resume Play Sound

	}

	public void ShowInterstitialAd()
	{
		//Show Ad
		if (interstitial.IsLoaded())
		{
			interstitial.Show();

			//Stop Sound
			//

			Debug.Log("SHOW AD XXX");
		}

	}
		
}
