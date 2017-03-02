using UnityEngine;
using System.Collections;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
public class MyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://fir-e5fd4.firebaseio.com/");
        FirebaseApp.DefaultInstance.SetEditorP12FileName("Demo-cc8907c2ecb5.p12");
        FirebaseApp.DefaultInstance.SetEditorServiceAccountEmail("newkey@fir-e5fd4.iam.gserviceaccount.com");
        FirebaseApp.DefaultInstance.SetEditorP12Password("notasecret");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void addUser()
    {
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        reference.Child("users").Child("u1").Child("name").SetValueAsync("anhmantk");
        string newkey = reference.Push().Key;
        Debug.Log(string.Format("new key: {0}", newkey));        
    }
}
