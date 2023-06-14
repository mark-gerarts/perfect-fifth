module P5Reference.DOM.P5MediaElementClearCues

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

    textBounded p5 "Click to change Cue!" 10 25 70 80

    audioEl.addCue 0.5 (changeBackground p5 (RGB(255, 0, 0))) |> ignore
    audioEl.addCue 1.0 (changeBackground p5 (RGB(0, 255, 0))) |> ignore
    audioEl.addCue 2.5 (changeBackground p5 (RGB(0, 0, 255))) |> ignore
    audioEl.addCue 3.0 (changeBackground p5 (RGB(0, 255, 255))) |> ignore
    audioEl.addCue 4.2 (changeBackground p5 (RGB(255, 255, 0))) |> ignore
    audioEl.addCue 5.0 (changeBackground p5 (RGB(255, 255, 0))) |> ignore

    audioEl

let draw _ _ = ()

let onMousePressed p5 _ (audioEl: P5MediaElement) =
    audioEl.clearCues ()
    // then we add some more callbacks
    audioEl.addCue 1 (changeBackground p5 (RGB(2, 2, 2))) |> ignore
    audioEl.addCue 3 (changeBackground p5 (RGB(255, 255, 0))) |> ignore

    audioEl

let run node =
    play node setup noUpdate draw [ OnMousePressed(Update onMousePressed) ]
