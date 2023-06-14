module P5Reference.DOM.P5MediaElementVolume0

open P5.Core
open P5.Color
open P5.Environment
open P5.DOM
open P5.Typography

let setup p5 =
    let ele = createAudio p5 "assets/lucky_dragons.mp3"
    background p5 (Grayscale 250)
    setTextAlign p5 centerTextAlign
    text p5 "Click to Play!" (width p5 / 2 |> float) (height p5 / 2 |> float)

    ele

let draw _ _ = ()

let onMouseClicked p5 _ (ele: P5MediaElement) =
    ele.setVolume 0.2
    ele.play ()
    background p5 (Grayscale 200)
    text p5 "You clicked Play!" (width p5 / 2 |> float) (height p5 / 2 |> float)

    ele

let run node =
    play node setup noUpdate draw [ OnMouseClicked(Update onMouseClicked) ]
