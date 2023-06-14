module P5Reference.DOM.P5ElementStyle0

open P5.Core
open P5.DOM

let draw p5 =
    let myDiv = createDiv p5 "I like pandas."
    myDiv.setStyle "font-size" "18px"
    myDiv.setStyle "color" "#ff0000"
    myDiv.setPosition 0 0

let run node = display node draw
