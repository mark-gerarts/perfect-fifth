module P5Reference.DOM.CreateRadio0

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.DOM
open P5.Typography

let setup p5 =
    let radio = createRadio p5
    radio.option "black"
    radio.option "white"
    radio.option "gray"
    radio.setStyle "width" "60px"

    setTextAlign
        p5
        { horizontal = HorizontalAlign.Center
          vertical = Center }

    fill p5 (RGB(255, 0, 0))

    radio

let draw p5 (radio: P5Radio) =
    let value = radio.getValue ()
    background p5 (Name value)
    text p5 value (width p5 / 2 |> float) (height p5 / 2 |> float)

let run node = simulate node setup noUpdate draw
