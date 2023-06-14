module P5Reference.DOM.P5MediaElementDuration

open P5.Core
open P5.Color
open P5.Typography
open P5.DOM
open P5.Environment

let setup p5 =
    let ele = createAudio p5 "assets/doorbell.mp3"
    background p5 (Grayscale 250)
    setTextAlign p5 centerTextAlign
    textBounded p5 "Click to know the duration!" 10 25 70 80
    ele

let draw p5 _ = ()

let onMouseClicked p5 _ (ele: P5MediaElement) =
    ele.play ()
    background p5 (Grayscale 200)

    text p5 (sprintf "%.2f seconds" (ele.duration ())) (width p5 / 2 |> float) (height p5 / 2 |> float)

    ele

let run node =
    play node setup noUpdate draw [ OnMouseClicked(Update onMouseClicked) ]
