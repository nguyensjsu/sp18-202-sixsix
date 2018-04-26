using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderBoard : MonoBehaviour {


    string name = "";
    string score = "";
    List<Scores> highscore;


    // Use this for initialization
    void Start()
    {
        //EventManager._instance._buttonClick += ButtonClicked;

        highscore = new List<Scores>();

    }


    void ButtonClicked(GameObject _obj)
    {
        print("Clicked button:" + _obj.name);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        // For clear Leader Board Only
        // HighScoreManager._instance.ClearLeaderBoard();

        highscore = HighScoreManager._instance.GetHighScore();
        
		GUI.contentColor = Color.black;
        GUILayout.Space(90);


        GUILayout.BeginHorizontal();
		GUILayout.Label("", GUILayout.Width(Screen.width / 3));
		GUILayout.Label("Name", GUILayout.Width(Screen.width / 4));
		GUILayout.Label("Scores", GUILayout.Width(Screen.width / 6));
		GUILayout.Label("", GUILayout.Width(Screen.width / 4));
        GUILayout.EndHorizontal();

        GUILayout.Space(10);

        foreach (Scores _score in highscore)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label("", GUILayout.Width(Screen.width / 3));
			GUILayout.Label(_score.name, GUILayout.Width(Screen.width / 4));
			GUILayout.Label("" + _score.score, GUILayout.Width(Screen.width / 6));
			GUILayout.Label("", GUILayout.Width(Screen.width / 4));
            GUILayout.EndHorizontal();
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
