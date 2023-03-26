module P5Reference.DOM.CreateSlider0

open P5.Core
open P5.Color
open P5.DOM

let setup p5 =
    let slider = createSliderWithOptions p5 0 255 100 1
    slider.setPositionWithType 10 10 Relative
    slider.style "width" "80px"
    slider.style "display" "block"

    slider

let draw p5 (slider: P5Element<float>) =
    let value = slider.getValue () |> int
    background p5 (Grayscale value)

let run node = simulate node setup noUpdate draw
