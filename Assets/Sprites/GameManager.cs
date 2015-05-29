using UnityEngine;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour {
  public AudioMixer MainMixer;

  void Awake() {
    // Get the main mixer's original master volume setting. Annoyingly, GetFloat
    // returns a value through a reference argument instead of a normal return
    // value.
    float origVolume;
    MainMixer.GetFloat("MasterVolume", out origVolume);
    // Bring master volume down at game start. This isn't actually fast enough;
    // you'll hear a flash of full-volume sound before this code executes. A
    // better solution is to use a starting snapshot with the main volume at
    // -80dB.
    MainMixer.SetFloat("MasterVolume", -80f);
    // Tween master volume back up to full.
    LeanTween.value(gameObject,
      val => MainMixer.SetFloat("MasterVolume", val), // statement that sets volume
      -80f, // from value
      origVolume,  // to value
      1f); // time
  }
}
