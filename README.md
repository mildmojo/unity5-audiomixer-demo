# Unity 5 Mixer Demo

This is a sample project that demonstrates using the Unity 5 Audio Mixer to
give different game locations their own soundscapes.

#### 'Before' branch

Checkout the [before branch](https://github.com/mildmojo/unity5-audiomixer-demo/tree/before)
([download .zip](https://github.com/mildmojo/unity5-audiomixer-demo/archive/before.zip))
to hear the original project with no effects applied. **The changes I made during
the RunJumpDev May 2015 monthly meeting are not included.** Snapshots turn the
ambient sounds on for each game location, but the mixer groups don't have any
effects added.

#### 'After' branch

Checkout the [after branch](https://github.com/mildmojo/unity5-audiomixer-demo/tree/after)
([download .zip](https://github.com/mildmojo/unity5-audiomixer-demo/archive/after.zip))
to hear the effects I added during the RunJumpDev May 2015 monthly meeting to
give each game location a unique mix and feel.

## About the game

You're Captain Doubletree of the Wild Wild Westin, and you've accidentally
triggered the ship's self-destruct while trying to make a cup of coffee. Make
your way to the Star Dolphin spacecraft at the rear of the ship to escape certain
death.

This is a toy, so most actual gamelike features aren't implemented. You can click
a location to move the captain there. Each location has a 2D trigger collider
that transitions the AudioMixer to the corresponding location snapshot over 0.5s
(see [ButtonController.cs](assets/Scripts/ButtonController.cs)).

## About the demo

In the demo, I demonstrated adding high- and low-pass filters, echo, and reverb
to make locations sound different. I also demonstrated the use of snapshots to
store a set of mixer settings and the code to transition between them.

The mixer setup might be a little different from a real game. In a real game,
each scene might have its own mixer wired to the master mixer. This is a tiny
project with a lot of audio shared between locations, so locations are assigned
to groups within a single mixer. Each location's ambient audio has its own group,
and there are separate groups for the loudspeaker voiceover and the background
music.

## Additional resources

- [Mixing Sweet Beats in Unity 5.0](http://blogs.unity3d.com/2014/07/24/mixing-sweet-beats-in-unity-5-0/)
- [AudioMixer and AudioMixer Groups (video)](http://unity3d.com/learn/tutorials/modules/beginner/5-pre-order-beta/audiomixer-and-audiomixer-groups)
- [AudioMixer Snapshots (video)](http://unity3d.com/learn/tutorials/modules/beginner/5-pre-order-beta/audiomixer-snapshots)
- [Send and Receive Audio Effects (video)](http://unity3d.com/learn/tutorials/modules/beginner/5-pre-order-beta/send-and-receive-audio-effects)
- [Duck Volume Audio Effect (video)](http://unity3d.com/learn/tutorials/modules/beginner/5-pre-order-beta/duck-volume-audio-effect)
- [Exposed AudioMixer Parameters (video)](http://unity3d.com/learn/tutorials/modules/beginner/5-pre-order-beta/exposed-audiomixer-parameters)

## Sound credits

"EDM Detection Mode", "Lost Time"
Kevin MacLeod (http://incompetech.com)
Licensed under Creative Commons: By Attribution 3.0
http://creativecommons.org/licenses/by/3.0/

Sound effects from [Sonniss sound effects library](http://www.sonniss.com/sound-effects/free-download-game-audio/).
