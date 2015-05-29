using UnityEngine;
using UnityEngine.Audio;

public class ButtonController : MonoBehaviour {

  public AudioMixer MainMixer;
  public string SnapshotName;

  private AudioMixerSnapshot snapshot;

  void Start () {
    snapshot = MainMixer.FindSnapshot(SnapshotName);
  }

  void OnTriggerEnter2D(Collider2D c) {
    if (c.gameObject == PlayerManager.Player) {
      // When player enters this area, transition to area's mixer snapshot.
      snapshot.TransitionTo(0.5f);
    }
  }

  public void OnClick() {
    // Move the player UI Image to the center of the button object.
    LeanTween
      .move(PlayerManager.Player, transform.position, 1.0f)
      .setEase(LeanTweenType.easeInOutSine);
  }
}
