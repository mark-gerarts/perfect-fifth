module P5Reference.DOM.P5ElementAttribute

open P5.Core
open P5.DOM

let draw p5 =
    let myDiv = createDiv p5 "I like pandas."
    myDiv.attribute "align" "center"

let run node = display node draw
