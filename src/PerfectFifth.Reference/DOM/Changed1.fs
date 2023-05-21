module P5Reference.DOM.Changed1

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.DOM

let setup p5 =
    let cnv = createCanvasAndReturn p5 100 100
    let cnv' = unbox<P5Element<Unit>> cnv
    cnv'.setPosition 0 30
    noFill p5

    let checkbox = createCheckboxWithLabel p5 "fill"

    let changeFill _ =
        if checkbox.isChecked () then
            do fill p5 (Grayscale 0)
        else
            noFill p5

    checkbox.changed changeFill


let draw p5 _ =
    background p5 (Grayscale 200)
    ellipse p5 50 50 50 50

let run node = animate node setup draw
