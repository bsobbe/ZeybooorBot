using UnityEngine;
using System.Collections;

public class AboutController : MonoBehaviour {

	public void UrlToWebsite()
    {
        Application.OpenURL("http://sobhan.me/");
    }

    public void UrlToGithub()
    {
        Application.OpenURL("http://github.com/sobhan-me/");
    }
}
