module P5Reference.DOM.CreateColorPicker1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.DOM

let draw p5 =
    createCanvas p5 100 100
    background p5 (Name "grey")
    let inp1 = createColorPickerWithValue p5 (Name "#ff0000")
    let inp2 = createColorPickerWithValue p5 (Name "yellow")

    let setMidShade _ =
        let commonShade = lerpColor p5 (inp1.color ()) (inp2.color ()) 0.5
        fill p5 commonShade
        square p5 20 20 60

    inp1.setPosition 0 (height p5 + 5 |> float)
    inp1.input setMidShade

    inp2.setPosition 0 (height p5 + 30 |> float)
    inp2.input setMidShade

    setMidShade ()

let run node = display node draw
