module P5Reference.DOM.P5MediaElementSrc

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Typography
open P5.DOM
open P5.Events

let setup p5 =
    background p5 (Grayscale 250)

    let ele = createAudio p5 "assets/beat.mp3"

    setTextAlign
        p5
        { horizontal = HorizontalAlign.Center
          vertical = Center }

    text p5 "Click Me!" (width p5 / 2 |> float) (height p5 / 2 |> float)

    ele

let draw _ _ = ()

let onMouseClicked p5 _ (ele: P5MediaElement) =
    let mouseX = mouseX p5
    let mouseY = mouseY p5
    let width = width p5
    let height = height p5

    if (mouseX >= 0 && mouseX <= width && mouseY >= 0 && mouseY <= height) then
        do
            print p5 (ele.src)

    ele

let run node =
    play node setup noUpdate draw [ OnMouseClicked(Update onMouseClicked) ]
