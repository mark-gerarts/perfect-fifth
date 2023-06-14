module P5Reference.DOM.P5MediaElementRemoveCue

open P5.Core
open P5.Color
open P5.Rendering
open P5.DOM
open P5.Typography

let changeBackground p5 color () = background p5 color

let setup p5 =
    createCanvas p5 200 200

    let audioEl = createAudio p5 "assets/beat.mp3"
    audioEl.showControls ()

    // schedule three calls to changeBackground
    let id1 = audioEl.addCue 0.5 (changeBackground p5 (RGB(255, 0, 0)))
    audioEl.addCue 1.0 (changeBackground p5 (RGB(0, 255, 0))) |> ignore
    audioEl.addCue 2.5 (changeBackground p5 (RGB(0, 0, 255))) |> ignore
    audioEl.addCue 3.0 (changeBackground p5 (RGB(0, 255, 255))) |> ignore
    audioEl.addCue 4.2 (changeBackground p5 (RGB(255, 255, 0))) |> ignore
    let id2 = audioEl.addCue 5.0 (changeBackground p5 (RGB(255, 255, 0)))

    textBounded p5 "Click to remove first and last Cue!" 10 25 70 80

    (audioEl, id1, id2)

let draw _ _ = ()

let onMousePressed _ _ (audioEl: P5MediaElement, id1, id2) =
    audioEl.removeCue id1
    audioEl.removeCue id2
    (audioEl, id1, id2)

let run node =
    play node setup noUpdate draw [ OnMousePressed(Update onMousePressed) ]
