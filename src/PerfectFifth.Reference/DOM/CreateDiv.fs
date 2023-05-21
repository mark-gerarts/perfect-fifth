module P5Reference.DOM.CreateDiv

open P5.Core
open P5.DOM

let draw p5 =
    let div = createDiv p5 "this is some text"
    div.style "font-size" "16px"
    div.setPosition 10 0

let run node = display node draw
