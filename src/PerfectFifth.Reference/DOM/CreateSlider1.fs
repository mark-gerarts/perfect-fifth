module P5Reference.DOM.CreateSlider1

open P5.Core
open P5.Color
open P5.DOM

let setup p5 =
    let slider = createSliderWithOptions p5 0 360 60 40
    slider.setPositionWithType 10 10 Relative
    slider.style "width" "80px"
    slider.style "display" "block"

    colorMode p5 ModeHSB

    slider

let draw p5 (slider: P5Element<float>) =
    let value = slider.getValue () |> int
    background p5 (RGBA(value, 100, 100, 1))

let run node = simulate node setup noUpdate draw
