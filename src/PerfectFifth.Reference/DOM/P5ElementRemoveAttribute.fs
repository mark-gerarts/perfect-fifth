module P5Reference.DOM.P5ElementRemoveAttribute

open P5.Core
open P5.Color
open P5.Shape
open P5.DOM

let enableButton (button: P5Element<string>) (chk: P5Element<bool>) _ =
    if chk.isChecked () then
        do button.removeAttribute "disabled"
    else
        button.setAttribute "disabled" ""

let setup p5 =
    let checkbox = createCheckboxWithLabelAndValue p5 "enable" true
    let button = createButton p5 "button"
    button.setPosition 10 10
    checkbox.changed (enableButton button checkbox)

let draw p5 _ =
    strokeWeight p5 4
    stroke p5 (Grayscale 51)
    square p5 20 20 60

let run node = animate node setup draw
