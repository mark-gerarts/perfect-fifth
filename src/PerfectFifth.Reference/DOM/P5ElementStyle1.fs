module P5Reference.DOM.P5ElementStyle1

open P5.Core
open P5.Color
open P5.DOM

let draw p5 =
    let col = color p5 (RGBA(25, 23, 200, 50))
    let button = createButton p5 "button"
    button.setStyle "background-color" (string col)
    button.setPosition 0 0

let run node = display node draw
