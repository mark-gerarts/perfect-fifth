module P5Reference.DOM.P5ElementCenter

open P5.Core
open P5.DOM

let draw p5 =
    let div = createDiv p5 ""
    div.setSize 10 10
    div.style "background-color" "orange"
    div.center ()

let run node = display node draw
