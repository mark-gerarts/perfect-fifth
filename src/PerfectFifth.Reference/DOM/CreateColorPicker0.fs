module P5Reference.DOM.CreateColorPicker0

open P5.Core
open P5.Color
open P5.DOM
open P5.Rendering
open P5.Environment

let setup p5 =
    createCanvas p5 100 100
    let colorPicker = createColorPickerWithValue p5 (Name "#ed225d")
    colorPicker.setPosition 0 (height p5 + 5 |> float)
    colorPicker

let draw p5 (colorPicker: P5ColorPicker) = background p5 (colorPicker.getColor ())

let run node = simulate node setup noUpdate draw
