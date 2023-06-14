module P5Reference.DOM.P5MediaElementHideControls

open P5.Core
open P5.Color
open P5.Typography
open P5.DOM
open P5.Environment

let setup p5 =
    let ele = createAudio p5 "assets/lucky_dragons.mp3"
    ele.showControls ()
    background p5 (Grayscale 200)
    setTextAlign p5 centerTextAlign
    textBounded p5 "Click to hide Controls!" 10 25 70 80
    ele

let draw _ _ = ()

let onMousePressed p5 _ (ele: P5MediaElement) =
    ele.hideControls ()
    background p5 (Grayscale 200)
    text p5 "Controls hidden" (width p5 / 2 |> float) (height p5 / 2 |> float)
    ele

let run node =
    play node setup noUpdate draw [ OnMousePressed(Update onMousePressed) ]
