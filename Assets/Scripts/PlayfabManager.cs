using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using Newtonsoft.Json;
using UnityEngine.UI;

public class PlayfabManager : MonoBehaviour {

    [Header("Leaderboard")]
   public GameObject rowPrefab;
    public Transform rowsParent;
    [Header("Windows")]
   public GameObject nameWindow;
      public GameObject LeaderboardWindow;





    // 🎥 Playfab episode #1 - Login with custom ID
    void Start() {
        Login();
        //PlayfabManager.SendLeaderboard(5);
    }

    void Login() {
        var request = new LoginWithCustomIDRequest {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            //CustomId = Random.Range(0, 100000).ToString(), <- ⭐️ Use this if you'd like to test something as a new user
            CreateAccount = true,
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams {
                GetPlayerProfile = true
            }
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnError);
    }
    void OnLoginSuccess(LoginResult result) {
        Debug.Log("Successful login/account create!");
        string name =null;
        if(result.InfoResultPayload.PlayerProfile!= null){
                    name= result.InfoResultPayload.PlayerProfile.DisplayName;

        }
        if(name == null){
            nameWindow.SetActive(true);
        }else 
        LeaderboardWindow.SetActive(true);
    }




    public void SendLeaderboard(int score) {
        var request = new UpdatePlayerStatisticsRequest {
            Statistics = new List<StatisticUpdate> {
                new StatisticUpdate {
                    StatisticName = "PlatformScore", // <- ✏️ CHANGE YOUR LEADERBOARD NAME HERE!
                    Value = score
                    //Value = Random.Range(10,100) <- ⭐️ Use this to test out random send data
                }
            }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);
    }
    void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result) {
        Debug.Log("Successfull leaderboard sent!");
    }

    public void GetLeaderboard() {
        var request = new GetLeaderboardRequest {
            StatisticName = "PlatformScore", // <- ✏️ CHANGE YOUR LEADERBOARD NAME HERE!
            StartPosition = 0, 
            MaxResultsCount = 10
        };
        PlayFabClientAPI.GetLeaderboard(request, OnLeaderboardGet, OnError);
    }
    void OnLeaderboardGet(GetLeaderboardResult result) {

        foreach (Transform item in rowsParent) {
            Destroy(item.gameObject);
        }

        foreach (var item in result.Leaderboard) {

            GameObject newGo = Instantiate(rowPrefab, rowsParent);
            Text[] texts = newGo.GetComponentsInChildren<Text>();
            texts[0].text = (item.Position + 1).ToString();
            texts[1].text = item.PlayFabId;
            texts[2].text = item.StatValue.ToString();

            Debug.Log(string.Format("PLACE: {0} | ID: {1} | VALUE: {2}",
                item.Position, item.PlayFabId, item.StatValue));
        }
        // foreach (var item in result.Leaderboard) {
        //     Debug.Log(item.Position+" "+item.PlayFabId+" "+item.StatValue);
        // }

    }


    // Error for all Playfab calls
    void OnError(PlayFabError error) {
        Debug.Log("Error while executing Playfab call!");
        Debug.Log(error.GenerateErrorReport());
    }



}
