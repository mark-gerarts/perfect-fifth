module P5Reference.DOM.P5MediaElementAddCue

open P5.Core
open P5.Color
open P5.Rendering
open P5.DOM

let changeBackground p5 color () = background p5 color

let setup p5 =
    createCanvas p5 200 200

    let audioEl = createAudio p5 "assets/beat.mp3"
    audioEl.showControls ()

    // schedule three calls to changeBackground
    audioEl.addCue 0.5 (changeBackground p5 (RGB(255, 0, 0))) |> ignore
    audioEl.addCue 1.0 (changeBackground p5 (RGB(0, 255, 0))) |> ignore
    audioEl.addCue 2.5 (changeBackground p5 (RGB(0, 0, 255))) |> ignore
    audioEl.addCue 3.0 (changeBackground p5 (RGB(0, 255, 255))) |> ignore
    audioEl.addCue 4.2 (changeBackground p5 (RGB(255, 255, 0))) |> ignore
    audioEl.addCue 5.0 (changeBackground p5 (RGB(255, 255, 0))) |> ignore

let draw _ _ = ()

let run node = animate node setup draw
