module P5Reference.DOM.P5MediaElementTime

open P5.Core
open P5.Color
open P5.Environment
open P5.DOM
open P5.Typography

let setup p5 =
    let ele = createAudio p5 "assets/lucky_dragons.mp3"
    background p5 (Grayscale 250)
    setTextAlign p5 centerTextAlign
    text p5 "start at beginning" (width p5 / 2 |> float) (height p5 / 2 |> float)

    (ele, true)

let draw _ _ = ()

let onMousePressed p5 _ (ele: P5MediaElement, beginning: bool) =
    match beginning with
    | true ->
        ele.play()
        ele.setTime 0
        background p5 (Grayscale 200)
        text p5 "jump 2 sec in" (width p5 / 2 |> float) (height p5 / 2 |> float)
        (ele, false)
    | false ->
        ele.play()
        ele.setTime 2
        background p5 (Grayscale 200)
        text p5 "start at beginning" (width p5 / 2 |> float) (height p5 / 2 |> float)
        (ele, true)

let run node = play node setup noUpdate draw [OnMousePressed(Update onMousePressed)]
