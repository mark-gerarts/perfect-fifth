module P5Reference.DOM.CreateRadio1

open P5.Core
open P5.Color
open P5.Environment
open P5.DOM
open P5.Typography

let setup p5 =
    let radio = createRadio p5
    radio.optionWithLabel "1" "apple"
    radio.optionWithLabel "2" "bread"
    radio.optionWithLabel "3" "juice"
    radio.style "width" "30px"
    radio.selected "2"

    setTextAlign
        p5
        { horizontal = HorizontalAlign.Center
          vertical = Center }

    radio

let draw p5 (radio: P5Radio) =
    background p5 (Grayscale 200)

    let value = radio.getValue ()
    text p5 (sprintf "item cost is $%s" value) (width p5 / 2 |> float) (height p5 / 2 |> float)

let run node = simulate node setup noUpdate draw
